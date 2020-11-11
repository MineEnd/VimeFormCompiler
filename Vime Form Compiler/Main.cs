using System;
using System.Windows.Forms;
using System.Diagnostics;

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
                if (Properties.Settings.Default.AddPunishmentCommand == true)
                {
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Visible = true;
                textBox8.Visible = true;
                label9.Visible = true;
                textBox11.Visible = true;
                label10.Visible = true;
                textBox13.Visible = true;
                label12.Visible = true;
                textBox9.Visible = true;
                label11.Visible = true;
                textBox17.Visible = true;
                label15.Visible = true;
                textBox10.Visible = true;
            } else
            {
                label8.Visible = false;
                textBox8.Visible = false;
                label9.Visible = false;
                textBox11.Visible = false;
                label10.Visible = false;
                textBox13.Visible = false;
                label12.Visible = false;
                textBox9.Visible = false;
                label11.Visible = false;
                textBox17.Visible = false;
                label15.Visible = false;
                textBox10.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label13.Visible = true;
                label14.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                label18.Visible = true;
                textBox16.Visible = true;
                textBox15.Visible = true;
                textBox12.Visible = true;
                textBox7.Visible = true;
                textBox14.Visible = true;
            } else
            {
                label13.Visible = false;
                label14.Visible = false;
                label16.Visible = false;
                label17.Visible = false;
                label18.Visible = false;
                textBox16.Visible = false;
                textBox15.Visible = false;
                textBox12.Visible = false;
                textBox7.Visible = false;
                textBox14.Visible = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string FormFinished2 = "";
            string FormFinished3 = "";
            if (textBox8.Visible == true)
            {
                if (textBox8.Text == "" || textBox11.Text == "" || textBox13.Text == "" || textBox9.Text == "" || textBox17.Text == "" || textBox10.Text == "")
                {
                    MessageBox.Show("Пункты помеченные звездочкой - обязательны!");
                } else
                {
                    if (Properties.Settings.Default.numbering == true)
                    {
                        FormFinished2 = @"1. " + textBox8.Text + Environment.NewLine + @"2. " + textBox11.Text + Environment.NewLine + @"3. " + textBox13.Text + Environment.NewLine + @"4. " + textBox9.Text + Environment.NewLine + @"5. " + textBox17.Text + Environment.NewLine + @"6. " + textBox10.Text;
                    } else
                    {
                        FormFinished2 = textBox8.Text + Environment.NewLine + textBox11.Text + Environment.NewLine + textBox13.Text + Environment.NewLine + textBox9.Text + Environment.NewLine + textBox17.Text + Environment.NewLine + textBox10.Text;
                    }
                    textBox6.Text = FormFinished2;
                }
            }
            if (textBox16.Visible == true)
            {
                if (textBox16.Text == "" || textBox12.Text == "" || textBox15.Text == "" || textBox7.Text == "")
                {
                    MessageBox.Show("Пункты помеченные звездочкой - обязательны!");
                } else
                {
                    if (Properties.Settings.Default.numbering == true)
                    {
                        FormFinished3 = @"1. " + textBox16.Text + Environment.NewLine + @"2. " + textBox12.Text + Environment.NewLine + @"3. " + textBox15.Text + Environment.NewLine + @"4. " + textBox7.Text;
                        if (textBox14.Text != "")
                        {
                            FormFinished3 += Environment.NewLine + @"5. " + textBox14.Text;
                        }
                    } else
                    {
                        FormFinished3 = textBox16.Text + Environment.NewLine + textBox12.Text + Environment.NewLine + textBox15.Text + Environment.NewLine + textBox7.Text;
                        if (textBox14.Text != "")
                        {
                            FormFinished3 += Environment.NewLine + textBox14.Text;
                        }
                    }
                    textBox6.Text = FormFinished3;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                MessageBox.Show("Копировать нечего!");
            } else
            {
                Clipboard.SetText(textBox6.Text);
            }
        }
    }
}
