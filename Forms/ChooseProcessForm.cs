using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenScraper
{
    public partial class ChooseProcessForm : Form
    {
        private List<Proc> activeProcs = new List<Proc>();
        BindingSource bs;
        public Proc chosenProc { get; private set; }
        public ChooseProcessForm()
        {
            InitializeComponent();
        }

        private void ChooseProcessfrom_Load(object sender, EventArgs e)
        {
            var processes = Process.GetProcesses()
            .Where(p => p.MainWindowHandle != IntPtr.Zero && !String.IsNullOrEmpty(p.MainWindowTitle))
            .ToArray();

            foreach (Process theprocess in processes)
            {
                Proc temp = new Proc();
                temp.Name = theprocess.MainWindowTitle;
                temp.hWnd = theprocess.MainWindowHandle;
                activeProcs.Add(temp);
            }
            bs = new BindingSource
            {
                DataSource = activeProcs
            };

            lBoxProcesses.DataSource = bs;
            bs.EndEdit();
            bs.ResetBindings(false);
            
        }

        private void lBoxProcesses_DoubleClick(object sender, EventArgs e)
        {
            chosenProc = (Proc)lBoxProcesses.Items[lBoxProcesses.SelectedIndex];
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
