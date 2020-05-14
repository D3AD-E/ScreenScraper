namespace ScreenScraper
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTest = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelGlobalPos = new System.Windows.Forms.Label();
            this.labelWindowFrPos = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.panelColors = new System.Windows.Forms.Panel();
            this.buttonChooseDrop = new System.Windows.Forms.Button();
            this.buttonClickOnProc = new System.Windows.Forms.Button();
            this.labelCurProc = new System.Windows.Forms.Label();
            this.tBPointInfo = new System.Windows.Forms.TextBox();
            this.lBPoints = new System.Windows.Forms.ListBox();
            this.cbSaveName = new System.Windows.Forms.CheckBox();
            this.cBSaveToFile = new System.Windows.Forms.CheckBox();
            this.rBTXT = new System.Windows.Forms.RadioButton();
            this.rBXML = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelColorHex = new System.Windows.Forms.Label();
            this.BRemove = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Global position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Position from window";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pixel color";
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(820, 420);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(85, 13);
            this.labelTest.TabIndex = 3;
            this.labelTest.Text = "TESTlabelTEST";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(32, 301);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(120, 35);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(783, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "TESTbuttonTEST";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelGlobalPos
            // 
            this.labelGlobalPos.AutoSize = true;
            this.labelGlobalPos.Location = new System.Drawing.Point(28, 128);
            this.labelGlobalPos.Name = "labelGlobalPos";
            this.labelGlobalPos.Size = new System.Drawing.Size(53, 13);
            this.labelGlobalPos.TabIndex = 6;
            this.labelGlobalPos.Text = "Unknown";
            // 
            // labelWindowFrPos
            // 
            this.labelWindowFrPos.AutoSize = true;
            this.labelWindowFrPos.Location = new System.Drawing.Point(29, 174);
            this.labelWindowFrPos.Name = "labelWindowFrPos";
            this.labelWindowFrPos.Size = new System.Drawing.Size(102, 13);
            this.labelWindowFrPos.TabIndex = 7;
            this.labelWindowFrPos.Text = "No process chosen!";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(29, 221);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(53, 13);
            this.labelColor.TabIndex = 8;
            this.labelColor.Text = "Unknown";
            // 
            // panelColors
            // 
            this.panelColors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColors.Location = new System.Drawing.Point(110, 234);
            this.panelColors.Name = "panelColors";
            this.panelColors.Size = new System.Drawing.Size(34, 26);
            this.panelColors.TabIndex = 9;
            // 
            // buttonChooseDrop
            // 
            this.buttonChooseDrop.Location = new System.Drawing.Point(200, 46);
            this.buttonChooseDrop.Name = "buttonChooseDrop";
            this.buttonChooseDrop.Size = new System.Drawing.Size(113, 35);
            this.buttonChooseDrop.TabIndex = 10;
            this.buttonChooseDrop.Text = "Choose a process from a list";
            this.buttonChooseDrop.UseVisualStyleBackColor = true;
            this.buttonChooseDrop.Click += new System.EventHandler(this.ButtonChooseDrop_Click);
            // 
            // buttonClickOnProc
            // 
            this.buttonClickOnProc.Location = new System.Drawing.Point(32, 47);
            this.buttonClickOnProc.Name = "buttonClickOnProc";
            this.buttonClickOnProc.Size = new System.Drawing.Size(113, 34);
            this.buttonClickOnProc.TabIndex = 11;
            this.buttonClickOnProc.Text = "Click on a window";
            this.buttonClickOnProc.UseVisualStyleBackColor = true;
            this.buttonClickOnProc.Click += new System.EventHandler(this.buttonClickOnProc_Click);
            // 
            // labelCurProc
            // 
            this.labelCurProc.AutoSize = true;
            this.labelCurProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurProc.Location = new System.Drawing.Point(33, 15);
            this.labelCurProc.Name = "labelCurProc";
            this.labelCurProc.Size = new System.Drawing.Size(159, 18);
            this.labelCurProc.TabIndex = 12;
            this.labelCurProc.Text = "Chosen process: none";
            // 
            // tBPointInfo
            // 
            this.tBPointInfo.Location = new System.Drawing.Point(488, 134);
            this.tBPointInfo.Multiline = true;
            this.tBPointInfo.Name = "tBPointInfo";
            this.tBPointInfo.ReadOnly = true;
            this.tBPointInfo.Size = new System.Drawing.Size(228, 134);
            this.tBPointInfo.TabIndex = 13;
            this.tBPointInfo.TabStop = false;
            // 
            // lBPoints
            // 
            this.lBPoints.FormattingEnabled = true;
            this.lBPoints.Location = new System.Drawing.Point(327, 135);
            this.lBPoints.Name = "lBPoints";
            this.lBPoints.Size = new System.Drawing.Size(154, 134);
            this.lBPoints.TabIndex = 14;
            this.lBPoints.SelectedIndexChanged += new System.EventHandler(this.lBPoints_SelectedIndexChanged);
            // 
            // cbSaveName
            // 
            this.cbSaveName.AutoSize = true;
            this.cbSaveName.Location = new System.Drawing.Point(488, 343);
            this.cbSaveName.Name = "cbSaveName";
            this.cbSaveName.Size = new System.Drawing.Size(163, 17);
            this.cbSaveName.TabIndex = 16;
            this.cbSaveName.Text = "Ask for name with each save";
            this.cbSaveName.UseVisualStyleBackColor = true;
            // 
            // cBSaveToFile
            // 
            this.cBSaveToFile.AutoSize = true;
            this.cBSaveToFile.Location = new System.Drawing.Point(488, 275);
            this.cBSaveToFile.Name = "cBSaveToFile";
            this.cBSaveToFile.Size = new System.Drawing.Size(79, 17);
            this.cBSaveToFile.TabIndex = 17;
            this.cBSaveToFile.Text = "Save to file";
            this.cBSaveToFile.UseVisualStyleBackColor = true;
            this.cBSaveToFile.CheckedChanged += new System.EventHandler(this.cBSaveToFile_CheckedChanged);
            // 
            // rBTXT
            // 
            this.rBTXT.AutoSize = true;
            this.rBTXT.Location = new System.Drawing.Point(488, 297);
            this.rBTXT.Name = "rBTXT";
            this.rBTXT.Size = new System.Drawing.Size(46, 17);
            this.rBTXT.TabIndex = 18;
            this.rBTXT.TabStop = true;
            this.rBTXT.Text = "TXT";
            this.rBTXT.UseVisualStyleBackColor = true;
            // 
            // rBXML
            // 
            this.rBXML.AutoSize = true;
            this.rBXML.Location = new System.Drawing.Point(488, 320);
            this.rBXML.Name = "rBXML";
            this.rBXML.Size = new System.Drawing.Size(47, 17);
            this.rBXML.TabIndex = 19;
            this.rBXML.TabStop = true;
            this.rBXML.Text = "XML";
            this.rBXML.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(323, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 80);
            this.label4.TabIndex = 20;
            this.label4.Text = "F2 - Resume\r\nF3 - Stop\r\nF4 - Save\r\nStart with button";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(153, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "OR";
            // 
            // labelColorHex
            // 
            this.labelColorHex.AutoSize = true;
            this.labelColorHex.Location = new System.Drawing.Point(29, 247);
            this.labelColorHex.Name = "labelColorHex";
            this.labelColorHex.Size = new System.Drawing.Size(53, 13);
            this.labelColorHex.TabIndex = 22;
            this.labelColorHex.Text = "Unknown";
            // 
            // BRemove
            // 
            this.BRemove.Location = new System.Drawing.Point(327, 275);
            this.BRemove.Name = "BRemove";
            this.BRemove.Size = new System.Drawing.Size(153, 29);
            this.BRemove.TabIndex = 23;
            this.BRemove.Text = "Remove";
            this.BRemove.UseVisualStyleBackColor = true;
            this.BRemove.Click += new System.EventHandler(this.BRemove_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(326, 310);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(154, 26);
            this.buttonSave.TabIndex = 24;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 375);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.BRemove);
            this.Controls.Add(this.labelColorHex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rBXML);
            this.Controls.Add(this.rBTXT);
            this.Controls.Add(this.cBSaveToFile);
            this.Controls.Add(this.cbSaveName);
            this.Controls.Add(this.lBPoints);
            this.Controls.Add(this.tBPointInfo);
            this.Controls.Add(this.labelCurProc);
            this.Controls.Add(this.buttonClickOnProc);
            this.Controls.Add(this.buttonChooseDrop);
            this.Controls.Add(this.panelColors);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelWindowFrPos);
            this.Controls.Add(this.labelGlobalPos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Screen scraper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelGlobalPos;
        private System.Windows.Forms.Label labelWindowFrPos;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Panel panelColors;
        private System.Windows.Forms.Button buttonChooseDrop;
        private System.Windows.Forms.Button buttonClickOnProc;
        private System.Windows.Forms.Label labelCurProc;
        private System.Windows.Forms.TextBox tBPointInfo;
        private System.Windows.Forms.ListBox lBPoints;
        private System.Windows.Forms.CheckBox cbSaveName;
        private System.Windows.Forms.CheckBox cBSaveToFile;
        private System.Windows.Forms.RadioButton rBTXT;
        private System.Windows.Forms.RadioButton rBXML;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelColorHex;
        private System.Windows.Forms.Button BRemove;
        private System.Windows.Forms.Button buttonSave;
    }
}

