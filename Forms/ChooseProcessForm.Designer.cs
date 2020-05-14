namespace ScreenScraper
{
    partial class ChooseProcessForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lBoxProcesses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lBoxProcesses
            // 
            this.lBoxProcesses.FormattingEnabled = true;
            this.lBoxProcesses.Location = new System.Drawing.Point(12, 32);
            this.lBoxProcesses.Name = "lBoxProcesses";
            this.lBoxProcesses.Size = new System.Drawing.Size(571, 329);
            this.lBoxProcesses.TabIndex = 0;
            this.lBoxProcesses.DoubleClick += new System.EventHandler(this.lBoxProcesses_DoubleClick);
            // 
            // ChooseProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 379);
            this.Controls.Add(this.lBoxProcesses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChooseProcessForm";
            this.Text = "ChooseProcessfrom";
            this.Load += new System.EventHandler(this.ChooseProcessfrom_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxProcesses;
    }
}