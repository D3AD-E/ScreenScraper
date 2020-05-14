using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenScraper
{
    public partial class InputBox : Form
    {
        public string UserInput { get; private set; }
        public InputBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserInput = tBInput.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void tBInput_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void tBInput_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                UserInput = tBInput.Text;
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
