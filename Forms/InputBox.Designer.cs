namespace ScreenScraper
{
    partial class InputBox
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
            this.tBInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBInput
            // 
            this.tBInput.Location = new System.Drawing.Point(24, 35);
            this.tBInput.Name = "tBInput";
            this.tBInput.Size = new System.Drawing.Size(178, 20);
            this.tBInput.TabIndex = 0;
            this.tBInput.Text = "Input name of the point";
            this.tBInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBInput_KeyDown);
            this.tBInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBInput_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 114);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InputBox";
            this.Text = "InputBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBInput;
        private System.Windows.Forms.Button button1;
    }
}