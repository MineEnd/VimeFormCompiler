using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vime_Form_Compiler
{
    public partial class logSearcher : Form
    {
        public logSearcher()
        {
            InitializeComponent();
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            string PCuserName = Environment.UserName;
            string logsPath;
            logsPath = @"C:\Users\" + PCuserName.ToString() + @"\AppData\Roaming\.vimeworld\".ToString() + comboBox1.Text.ToString() + @"\logs\latest.log".ToString();
            if (e.KeyCode == Keys.Enter)
            {
                var lines = File.ReadLines(logsPath);
                string result = string.Join(Environment.NewLine, lines.Where(s => s.IndexOf(textBox1.Text, StringComparison.InvariantCultureIgnoreCase) >= 0));
                textBox2.Text = result;
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Ничего не найдено", "Ошибка");
                }
            }
        }
    }
}
