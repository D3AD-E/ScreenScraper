using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenScraper
{
    public partial class MainForm : Form
    {
        private List<PointData> m_points = new List<PointData>();
        private PointData m_curPoint = new PointData();
        private WindowParser m_windowParser = new WindowParser();
        private bool m_isBusy = false;
        private System.Windows.Forms.Timer m_timer = new System.Windows.Forms.Timer();
        private Proc m_curProc = new Proc();
        private GlobalKeyboardHook m_globalKeyboardHook;
        private BindingSource m_bs;
        private FileWorker m_fileWorker = new FileWorker();

        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (m_curProc.hWnd == IntPtr.Zero)
            {
                var res = MessageBox.Show("No process chosen, do you really want to continue?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.Cancel)
                {
                    return;
                }
            }
            if (!m_isBusy)
            {
                StartTimer();
            }
        }

        private void StartTimer()
        {
            m_timer.Tick += new EventHandler(Timer_Tick);
            m_timer.Interval = 30;
            m_timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Point windowPos = new Point();
            Point cursorFromWindowPos = new Point();
            m_isBusy = true;
            Point mousePos = m_windowParser.GetCursorPos();
            labelGlobalPos.Text = mousePos.ToString();
            m_curPoint.gPoint = mousePos;

            Color pixelColor = m_windowParser.GetColorAtPoint(mousePos);
            panelColors.BackColor = pixelColor;
            labelColor.Text = ColorConverter.RGBConverter(pixelColor);
            labelColorHex.Text = ColorConverter.HexConverter(pixelColor);
            m_curPoint.PixelColor = pixelColor;
            if (m_curProc.hWnd == IntPtr.Zero)
            {
                labelWindowFrPos.Text = "No process chosen!";
            }
            else
            {
                m_curPoint.wPoint = new Point(-1, -1);
                if (m_windowParser.doesWindowExist(m_curProc.hWnd))
                {
                    windowPos = m_windowParser.GetUpperPoint(m_curProc.hWnd);

                    cursorFromWindowPos.X = mousePos.X - windowPos.X; //bad
                    cursorFromWindowPos.Y = mousePos.Y - windowPos.Y;

                    if (m_windowParser.isWindowOnForeground(m_curProc.hWnd))
                        labelWindowFrPos.Text = "Window is minimized";
                    else if (!m_windowParser.isPointInBorders(mousePos, m_curProc.hWnd))
                        labelWindowFrPos.Text = "Cursor is not in the window region";
                    else
                    {
                        labelWindowFrPos.Text = cursorFromWindowPos.ToString();
                        m_curPoint.wPoint = cursorFromWindowPos;
                    }
                }
                else
                {
                    labelWindowFrPos.Text = "Window with such hwnd was not found!";
                }
            }
        }

        private void ButtonChooseDrop_Click(object sender, EventArgs e)
        {
            ChooseProcessForm cForm = new ChooseProcessForm();
            var res = cForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                m_curProc = cForm.chosenProc;
                UpdateLabelProc();
            }
        }

        private async void buttonClickOnProc_Click(object sender, EventArgs e)
        {
            var res = await Task.Run(GetOtherWindow);
            m_curProc.hWnd = res;
            m_curProc.Name = m_windowParser.getWindowTitle(res);
            UpdateLabelProc();
        }

        private async Task<IntPtr> GetOtherWindow()
        {
            IntPtr currentW = m_windowParser.getOwnWindow();
            while (true)
            {
                IntPtr focusedW = m_windowParser.getFocusedWindow();
                if (currentW != focusedW && focusedW != IntPtr.Zero && m_windowParser.doesWindowExist(focusedW))
                    return focusedW;
            }
        }

        private void UpdateLabelProc()
        {
            string toFormat = "Current process: {0}, hwnd: {1}";
            toFormat = String.Format(toFormat, m_curProc.Name, m_curProc.hWnd);
            labelCurProc.Text = toFormat;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            m_globalKeyboardHook = new GlobalKeyboardHook(new Keys[] { Keys.F2, Keys.F3, Keys.F4 });
            m_globalKeyboardHook.KeyboardPressed += OnKeyPressed;
            m_bs = new BindingSource
            {
                DataSource = m_points
            };
            lBPoints.DataSource = m_bs;
            m_bs.EndEdit();
            m_bs.ResetBindings(false);
            rBTXT.Enabled = false;
            rBXML.Enabled = false;
        }

        private void SaveInfo()
        {
            PointData toAdd = new PointData(m_curPoint);
            m_points.Add(toAdd);
            m_bs.EndEdit();
            m_bs.ResetBindings(false);
        }

        private void SaveInfoToFile()
        {
            if (rBTXT.Checked)
            {
                m_fileWorker.WriteEachPoint(m_points, FileWorker.Mode.TXT);
            }
            else if (rBXML.Checked)
            {
                m_fileWorker.Write(m_points, FileWorker.Mode.XML);
            }
            else
                MessageBox.Show("Save file type not chosen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnKeyPressed(object sender, GlobalKeyboardHookEventArgs e)
        {
            if (e.KeyboardState == GlobalKeyboardHook.KeyboardState.KeyDown)
            {
                Keys loggedKey = e.KeyboardData.Key;
                if (loggedKey == Keys.F2)
                {
                    if (!m_timer.Enabled)
                        m_timer.Start();
                }
                else if (loggedKey == Keys.F3)
                {
                    if (m_timer.Enabled)
                        m_timer.Stop();
                }
                else if (loggedKey == Keys.F4)
                {
                    if (cbSaveName.Checked)
                    {
                        InputBox inputBox = new InputBox();
                        var res = inputBox.ShowDialog();
                        if (res == DialogResult.OK)
                            m_curPoint.Name = inputBox.UserInput;
                        else
                            m_curPoint.Name = "Unnamed";
                    }
                    else
                        m_curPoint.Name = "Unnamed";
                    SaveInfo();
                    if (cBSaveToFile.Checked)
                        SaveInfoToFile();
                }
            }
        }

        private void lBPoints_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBPoints.SelectedIndex != -1)
            {
                PointData toDisplay = (PointData)lBPoints.SelectedItem;
                string toPrint = "Point name: {0} \r\nGlobal position: {1}\r\nRelative position: {2}\r\nColor: {3} \r\nHex: {4}";
                if (toDisplay.wPoint == new Point(-1,-1))
                toPrint = String.Format(toPrint, toDisplay.Name, toDisplay.gPoint, "Unknown",
                    ColorConverter.RGBConverter(toDisplay.PixelColor), ColorConverter.HexConverter(toDisplay.PixelColor));
                else
                    toPrint = String.Format(toPrint, toDisplay.Name, toDisplay.gPoint, toDisplay.wPoint,
                        ColorConverter.RGBConverter(toDisplay.PixelColor), ColorConverter.HexConverter(toDisplay.PixelColor));
                tBPointInfo.Text = toPrint;
            }
        }

        private void cBSaveToFile_CheckedChanged(object sender, EventArgs e)
        {
            if (cBSaveToFile.Checked)
            {
                rBTXT.Enabled = true;
                rBXML.Enabled = true;
            }
            else
            {
                rBTXT.Enabled = false;
                rBXML.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m_fileWorker.Write<string>("AAA", FileWorker.Mode.TXT);
        }

        private void BRemove_Click(object sender, EventArgs e)
        {
            if (lBPoints.SelectedIndex == -1)
                return;
            m_points.RemoveAt(lBPoints.SelectedIndex);
            if (cBSaveToFile.Checked)
                SaveInfoToFile();
            m_bs.EndEdit();
            m_bs.ResetBindings(false);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveInfoToFile();
        }
    }
}