using System;
using System.Windows.Forms;

namespace Vime_Form_Compiler
{
    public partial class options : Form
    {
        public options()
        {
            InitializeComponent();
            if (Properties.Settings.Default.numbering == true)
            {
                numberingChBox.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void numberingChBox_CheckedChanged(object sender, EventArgs e)
        {
            if (numberingChBox.Checked == true)
            {
                Properties.Settings.Default.numbering = true;
            } else
            {
                Properties.Settings.Default.numbering = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string DebugUserName = Environment.UserName;
            MessageBox.Show(DebugUserName);
        }
    }
}
