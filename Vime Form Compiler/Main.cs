using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;
using System.Security;

namespace Vime_Form_Compiler
{
    public partial class VFC : Form
    {
        public VFC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Links A = new Links();
            A.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            About A = new About();
            A.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string FormFinished;
            if (textBox3.Text == "" || textBox2.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Пункты помеченные звездочкой - обязательны!");
            } else
            {
                if (Properties.Settings.Default.numbering == true)
                {
                    FormFinished = @"1. " + textBox3.Text + Environment.NewLine + @"2. " + textBox2.Text + Environment.NewLine + @"3. " + dateTimePicker1.Value.ToShortDateString() + Environment.NewLine + @"4. " + textBox1.Text;
                } else
                {
                    FormFinished =  textBox3.Text + Environment.NewLine + textBox2.Text + Environment.NewLine + dateTimePicker1.Value.ToShortDateString() + Environment.NewLine + textBox1.Text;
                }

                
                if (comboBox1.Text != "")
                {
                    if (Properties.Settings.Default.numbering == true)
                    {
                        FormFinished += Environment.NewLine + @"5. ".ToString() + comboBox1.Text.ToString();
                    } else
                    {
                        FormFinished += Environment.NewLine + comboBox1.Text.ToString();
                    }
                }
                if (textBox4.Text != "")
                {
                    if (Properties.Settings.Default.numbering == true)
                    {
                        FormFinished += Environment.NewLine + @"6. ".ToString() + textBox4.Text;
                    } else
                    {
                        FormFinished += Environment.NewLine + textBox4.Text;
                    }
                }
                if (comboBox1.Text == "Оскорбление проекта/сервера")
                {
                    FormFinished += Environment.NewLine + "/ban " + textBox3.Text + " 0 Оскорбление сервера";
                }
                if (comboBox1.Text == "Оскорбление Администрации")
                {
                    FormFinished += Environment.NewLine + "/ban " + textBox3.Text + " 0 Оскорбление Администрации";
                }
                if (comboBox1.Text == "Выдача себя за администрацию")
                {
                    FormFinished += Environment.NewLine + "/ban " + textBox3.Text + " 10080 Выдача себя за Администрацию";
                }
                if (comboBox1.Text == "Неккоректный никнейм")
                {
                    FormFinished += Environment.NewLine + "/ban " + textBox3.Text + " 0 Неккоректный никнейм";
                }
                if (comboBox1.Text == "Ловушка/Обман игроков")
                {
                    FormFinished += Environment.NewLine + "/ban " + textBox3.Text + " 2880 Обман игроков";
                }
                if (comboBox1.Text == "Политическая агитация")
                {
                    FormFinished += Environment.NewLine + "/ban " + textBox3.Text + " 0 Политическая агитация";
                }
                if (textBox2.Text == "_bellyache" || textBox2.Text == "Hastyxa_YT" || textBox2.Text == "xtrafrancyz")
                {
                    MessageBox.Show("Привет, " + textBox2.Text.ToString());
                }
                textBox5.Text = FormFinished;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("Копировать нечего!");
            } else
            {
                Clipboard.SetText(textBox5.Text);
                MessageBox.Show("Скопировано");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            options A = new options();
            A.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string PCuserName = Environment.UserName;
            string screensPath = @"C:\Users\" + PCuserName.ToString() + @"\AppData\Roaming\.vimeworld\minigames\screenshots".ToString();
            Process.Start(screensPath);
        }
    }
}
