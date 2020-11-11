using System;
using System.Windows.Forms;

namespace Vime_Form_Compiler
{
    public partial class IMGUpload : Form
    {
        public IMGUpload()
        {
            InitializeComponent();
        }

        private void UploadingTextBox_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(UploadingTextBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UploadingTextBox.Text = "";
        }
    }
}
