using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Random random = new Random();
        int i = 0;
        double payroll = 550;
        double salaryCap = 115;



        ////////////////////////////////////////////////////// 타자

        //////////////////////////////////////////// 포수
        private void button1_Click(object sender, EventArgs e)
        {
            double player_money = random.Next(5, 8);
            double player_year = random.Next(3, 7);
            int ind = random.Next(1, 3);
            if (textBox3.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("계약기간과 금액을 모두 입력하세요");
            }
            else if (double.Parse(textBox2.Text) < player_year)
            {
                MessageBox.Show("Mitch Garver 선수가 계약기간을 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button1.Enabled = false;
                    button1.Text = "계약실패";
                }
                i++;
            }
            else if (double.Parse(textBox3.Text) > player_money * player_year)
            {
                MessageBox.Show("Mitch Garver 선수가 계약을 받아들였습니다!");
                button1.Enabled = false;
                button1.Text = "계약완료";
                richTextBox44.Text += "\n" + string.Format("Mitch Garver를 {0}년 {1:0.0}M달러에 영입", double.Parse(textBox2.Text), double.Parse(textBox3.Text));
                salaryCap -= double.Parse(textBox3.Text) / double.Parse(textBox2.Text);
                payroll -= double.Parse(textBox3.Text);
                label91.Text = salaryCap.ToString();
                label99.Text = payroll.ToString();
            }
            else
            {
                MessageBox.Show("Mitch Garver 선수가 계약규모를 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button1.Enabled = false;
                    button1.Text = "계약실패";
                }
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double player_money = random.Next(7, 10);
            double player_year = random.Next(2, 5);
            int ind = random.Next(1, 3);
            if (textBox4.Text == "" && textBox1.Text == "")
            {
                MessageBox.Show("계약기간과 금액을 모두 입력하세요");
            }
            else if (double.Parse(textBox4.Text) < player_year)
            {
                MessageBox.Show("Yan Gomez 선수가 계약기간을 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button2.Enabled = false;
                    button2.Text = "계약실패";
                }
                i++;
            }
            else if (double.Parse(textBox1.Text) > player_money * player_year)
            {
                MessageBox.Show("Yan Gomez 선수가 계약을 받아들였습니다!");
                button2.Enabled = false;
                button2.Text = "계약완료";
                richTextBox44.Text += "\n" + string.Format("Yan Gomez를 {0}년 {1:0.0}M달러에 영입", double.Parse(textBox4.Text), double.Parse(textBox1.Text));
                salaryCap -= double.Parse(textBox1.Text) / double.Parse(textBox4.Text);
                payroll -= double.Parse(textBox1.Text);
                label91.Text = salaryCap.ToString();
                label99.Text = payroll.ToString();
            }
            else
            {
                MessageBox.Show("Yan Gomez 선수가 계약규모를 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button2.Enabled = false;
                    button2.Text = "계약실패";
                }
                i++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double player_money = random.Next(6, 9);
            double player_year = random.Next(2, 5);
            int ind = random.Next(1, 3);
            if (textBox6.Text == "" && textBox5.Text == "")
            {
                MessageBox.Show("계약기간과 금액을 모두 입력하세요");
            }
            else if (double.Parse(textBox6.Text) < player_year)
            {
                MessageBox.Show("Yasmani Grandal 선수가 계약기간을 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button3.Enabled = false;
                    button3.Text = "계약실패";
                }
                i++;
            }
            else if (double.Parse(textBox5.Text) > player_money * player_year)
            {
                MessageBox.Show("Yasmani Grandal 선수가 계약을 받아들였습니다!");
                button3.Enabled = false;
                button3.Text = "계약완료";
                richTextBox44.Text += "\n" + string.Format("Yasmani Grandal를 {0}년 {1:0.0}M달러에 영입", double.Parse(textBox6.Text), double.Parse(textBox5.Text));
                salaryCap -= double.Parse(textBox5.Text) / double.Parse(textBox6.Text);
                payroll -= double.Parse(textBox5.Text);
                label91.Text = salaryCap.ToString();
                label99.Text = payroll.ToString();
            }
            else
            {
                MessageBox.Show("Yasmani Grandal 선수가 계약규모를 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button3.Enabled = false;
                    button3.Text = "계약실패";
                }
                i++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double player_money = random.Next(3, 5);
            double player_year = random.Next(1, 3);
            int ind = random.Next(1, 3);
            if (textBox8.Text == "" && textBox7.Text == "")
            {
                MessageBox.Show("계약기간과 금액을 모두 입력하세요");
            }
            else if (double.Parse(textBox8.Text) < player_year)
            {
                MessageBox.Show("Austin Hedges 선수가 계약기간을 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button4.Enabled = false;
                    button4.Text = "계약실패";
                }
                i++;
            }
            else if (double.Parse(textBox7.Text) > player_money * player_year)
            {
                MessageBox.Show("Austin Hedges 선수가 계약을 받아들였습니다!");
                button4.Enabled = false;
                button4.Text = "계약완료";
                richTextBox44.Text += "\n" + string.Format("Austin Hedges를 {0}년 {1:0.0}M달러에 영입", double.Parse(textBox8.Text), double.Parse(textBox7.Text));
                salaryCap -= double.Parse(textBox7.Text) / double.Parse(textBox8.Text);
                payroll -= double.Parse(textBox7.Text);
                label91.Text = salaryCap.ToString();
                label99.Text = payroll.ToString();
            }
            else
            {
                MessageBox.Show("Austin Hedges 선수가 계약규모를 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button4.Enabled = false;
                    button4.Text = "계약실패";
                }
                i++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double player_money = random.Next(3, 5);
            double player_year = random.Next(2, 5);
            int ind = random.Next(1, 3);
            if (textBox10.Text == "" && textBox9.Text == "")
            {
                MessageBox.Show("계약기간과 금액을 모두 입력하세요");
            }
            else if (double.Parse(textBox10.Text) < player_year)
            {
                MessageBox.Show("Omar Narvaez 선수가 계약기간을 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button5.Enabled = false;
                    button5.Text = "계약실패";
                }
                i++;
            }
            else if (double.Parse(textBox9.Text) > player_money * player_year)
            {
                MessageBox.Show("Omar Narvaez 선수가 계약을 받아들였습니다!");
                button5.Enabled = false;
                button5.Text = "계약완료";
                richTextBox44.Text += "\n" + string.Format("Omar Narvaez를 {0}년 {1:0.0}M달러에 영입", double.Parse(textBox10.Text), double.Parse(textBox9.Text));
                salaryCap -= double.Parse(textBox9.Text) / double.Parse(textBox10.Text);
                payroll -= double.Parse(textBox9.Text);
                label91.Text = salaryCap.ToString();
                label99.Text = payroll.ToString();
            }
            else
            {
                MessageBox.Show("Omar Narvaez 선수가 계약규모를 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button5.Enabled = false;
                    button5.Text = "계약실패";
                }
                i++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double player_money = random.Next(2, 3);
            double player_year = random.Next(1, 3);
            int ind = random.Next(1, 3);
            if (textBox12.Text == "" && textBox11.Text == "")
            {
                MessageBox.Show("계약기간과 금액을 모두 입력하세요");
            }
            else if (double.Parse(textBox12.Text) < player_year)
            {
                MessageBox.Show("Manny Pina 선수가 계약기간을 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button6.Enabled = false;
                    button6.Text = "계약실패";
                }
                i++;
            }
            else if (double.Parse(textBox11.Text) > player_money * player_year)
            {
                MessageBox.Show("Manny Pina 선수가 계약을 받아들였습니다!");
                button6.Enabled = false;
                button6.Text = "계약완료";
                richTextBox44.Text += "\n" + string.Format("Manny Pina를 {0}년 {1:0.0}M달러에 영입", double.Parse(textBox12.Text), double.Parse(textBox11.Text));
                salaryCap -= double.Parse(textBox11.Text) / double.Parse(textBox12.Text);
                payroll -= double.Parse(textBox11.Text);
                label91.Text = salaryCap.ToString();
                label99.Text = payroll.ToString();
            }
            else
            {
                MessageBox.Show("Manny Pina 선수가 계약규모를 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button6.Enabled = false;
                    button6.Text = "계약실패";
                }
                i++;
            }
        }
        //////////////////////////////////////////////////////// 1루수
        private void button7_Click(object sender, EventArgs e)
        {
            double player_money = random.Next(4, 7);
            double player_year = random.Next(4, 6);
            int ind = random.Next(1, 3);
            if (textBox24.Text == "" && textBox23.Text == "")
            {
                MessageBox.Show("계약기간과 금액을 모두 입력하세요");
            }
            else if (double.Parse(textBox24.Text) < player_year)
            {
                MessageBox.Show("Josh Bell 선수가 계약기간을 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button7.Enabled = false;
                    button7.Text = "계약실패";
                }
                i++;
            }
            else if (double.Parse(textBox23.Text) > player_money * player_year)
            {
                MessageBox.Show("Josh Bell 선수가 계약을 받아들였습니다!");
                button7.Enabled = false;
                button7.Text = "계약완료";
                richTextBox44.Text += "\n" + string.Format("Josh Bell를 {0}년 {1:0.0}M달러에 영입", double.Parse(textBox24.Text), double.Parse(textBox23.Text));
                salaryCap -= double.Parse(textBox23.Text) / double.Parse(textBox24.Text);
                payroll -= double.Parse(textBox23.Text);
                label91.Text = salaryCap.ToString();
                label99.Text = payroll.ToString();
            }
            else
            {
                MessageBox.Show("Josh Bell 선수가 계약규모를 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button7.Enabled = false;
                    button7.Text = "계약실패";
                }
                i++;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double player_money = random.Next(1, 3);
            double player_year = random.Next(4, 6);
            int ind = random.Next(1, 3);
            if (textBox22.Text == "" && textBox21.Text == "")
            {
                MessageBox.Show("계약기간과 금액을 모두 입력하세요");
            }
            else if (double.Parse(textBox22.Text) < player_year)
            {
                MessageBox.Show("Ji Man choi 선수가 계약기간을 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button8.Enabled = false;
                    button8.Text = "계약실패";
                }
                i++;
            }
            else if (double.Parse(textBox21.Text) > player_money * player_year)
            {
                MessageBox.Show("Ji Man choi 선수가 계약을 받아들였습니다!");
                button8.Enabled = false;
                button8.Text = "계약완료";
                richTextBox44.Text += "\n" + string.Format("Ji Man choi를 {0}년 {1:0.0}M달러에 영입", double.Parse(textBox22.Text), double.Parse(textBox21.Text));
                salaryCap -= double.Parse(textBox21.Text) / double.Parse(textBox22.Text);
                payroll -= double.Parse(textBox21.Text);
                label91.Text = salaryCap.ToString();
                label99.Text = payroll.ToString();
            }
            else
            {
                MessageBox.Show("Ji Man choi 선수가 계약규모를 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button8.Enabled = false;
                    button8.Text = "계약실패";
                }
                i++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double player_money = random.Next(4, 6);
            double player_year = random.Next(2, 4);
            int ind = random.Next(1, 3);
            if (textBox20.Text == "" && textBox19.Text == "")
            {
                MessageBox.Show("계약기간과 금액을 모두 입력하세요");
            }
            else if (double.Parse(textBox20.Text) < player_year)
            {
                MessageBox.Show("C.J. Cron 선수가 계약기간을 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button9.Enabled = false;
                    button9.Text = "계약실패";
                }
                i++;
            }
            else if (double.Parse(textBox19.Text) > player_money * player_year)
            {
                MessageBox.Show("C.J. Cron 선수가 계약을 받아들였습니다!");
                button9.Enabled = false;
                button9.Text = "계약완료";
                richTextBox44.Text += "\n" + string.Format("C.J. Cron를 {0}년 {1:0.0}M달러에 영입", double.Parse(textBox20.Text), double.Parse(textBox19.Text));
                salaryCap -= double.Parse(textBox19.Text) / double.Parse(textBox20.Text);
                payroll -= double.Parse(textBox19.Text);
                label91.Text = salaryCap.ToString();
                label99.Text = payroll.ToString();
            }
            else
            {
                MessageBox.Show("C.J. Cron 선수가 계약규모를 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button9.Enabled = false;
                    button9.Text = "계약실패";
                }
                i++;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double player_money = random.Next(6, 8);
            double player_year = random.Next(6, 8);
            int ind = random.Next(1, 3);
            if (textBox18.Text == "" && textBox17.Text == "")
            {
                MessageBox.Show("계약기간과 금액을 모두 입력하세요");
            }
            else if (double.Parse(textBox18.Text) < player_year)
            {
                MessageBox.Show("Joey Gallo 선수가 계약기간을 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button10.Enabled = false;
                    button10.Text = "계약실패";
                }
                i++;
            }
            else if (double.Parse(textBox17.Text) > player_money * player_year)
            {
                MessageBox.Show("Joey Gallo 선수가 계약을 받아들였습니다!");
                button10.Enabled = false;
                button10.Text = "계약완료";
                richTextBox44.Text += "\n" + string.Format("Joey Gallo를 {0}년 {1:0.0}M달러에 영입", double.Parse(textBox18.Text), double.Parse(textBox17.Text));
                salaryCap -= double.Parse(textBox17.Text) / double.Parse(textBox18.Text);
                payroll -= double.Parse(textBox17.Text);
                label91.Text = salaryCap.ToString();
                label99.Text = payroll.ToString();
            }
            else
            {
                MessageBox.Show("Joey Gallo 선수가 계약규모를 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button10.Enabled = false;
                    button10.Text = "계약실패";
                }
                i++;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double player_money = random.Next(8, 11);
            double player_year = random.Next(1, 2);
            int ind = random.Next(1, 3);
            if (textBox16.Text == "" && textBox15.Text == "")
            {
                MessageBox.Show("계약기간과 금액을 모두 입력하세요");
            }
            else if (double.Parse(textBox16.Text) < player_year)
            {
                MessageBox.Show("Rhys Hoskins 선수가 계약기간을 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button11.Enabled = false;
                    button11.Text = "계약실패";
                }
                i++;
            }
            else if (double.Parse(textBox15.Text) > player_money * player_year)
            {
                MessageBox.Show("Rhys Hoskins 선수가 계약을 받아들였습니다!");
                button11.Enabled = false;
                button11.Text = "계약완료";
                richTextBox44.Text += "\n" + string.Format("Rhys Hoskins를 {0}년 {1:0.0}M달러에 영입", double.Parse(textBox16.Text), double.Parse(textBox15.Text));
                salaryCap -= double.Parse(textBox15.Text) / double.Parse(textBox16.Text);
                payroll -= double.Parse(textBox15.Text);
                label91.Text = salaryCap.ToString();
                label99.Text = payroll.ToString();
            }
            else
            {
                MessageBox.Show("Rhys Hoskins 선수가 계약규모를 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button11.Enabled = false;
                    button11.Text = "계약실패";
                }
                i++;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double player_money = random.Next(18, 21);
            double player_year = random.Next(6, 9);
            int ind = random.Next(1, 3);
            if (textBox14.Text == "" && textBox13.Text == "")
            {
                MessageBox.Show("계약기간과 금액을 모두 입력하세요");
            }
            else if (double.Parse(textBox14.Text) < player_year)
            {
                MessageBox.Show("Max Muncy 선수가 계약기간을 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button12.Enabled = false;
                    button12.Text = "계약실패";
                }
                i++;
            }
            else if (double.Parse(textBox13.Text) > player_money * player_year)
            {
                MessageBox.Show("Max Muncy 선수가 계약을 받아들였습니다!");
                button12.Enabled = false;
                button12.Text = "계약완료";
                richTextBox44.Text += "\n" + string.Format("Max Muncy를 {0}년 {1:0.0}M달러에 영입", double.Parse(textBox14.Text), double.Parse(textBox13.Text));
                salaryCap -= double.Parse(textBox13.Text) / double.Parse(textBox14.Text);
                payroll -= double.Parse(textBox13.Text);
                label91.Text = salaryCap.ToString();
                label99.Text = payroll.ToString();
            }
            else
            {
                MessageBox.Show("Max Muncy 선수가 계약규모를 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button12.Enabled = false;
                    button12.Text = "계약실패";
                }
                i++;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double player_money = random.Next(4, 6);
            double player_year = random.Next(4, 6);
            int ind = random.Next(1, 3);
            if (textBox36.Text == "" && textBox35.Text == "")
            {
                MessageBox.Show("계약기간과 금액을 모두 입력하세요");
            }
            else if (double.Parse(textBox36.Text) < player_year)
            {
                MessageBox.Show("Adam Frazier 선수가 계약기간을 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button13.Enabled = false;
                    button13.Text = "계약실패";
                }
                i++;
            }
            else if (double.Parse(textBox35.Text) > player_money * player_year)
            {
                MessageBox.Show("Adam Frazier 선수가 계약을 받아들였습니다!");
                button13.Enabled = false;
                button13.Text = "계약완료";
                richTextBox44.Text += "\n" + string.Format("Adam Frazier를 {0}년 {1:0.0}M달러에 영입", double.Parse(textBox36.Text), double.Parse(textBox35.Text));
                salaryCap -= double.Parse(textBox35.Text) / double.Parse(textBox36.Text);
                payroll -= double.Parse(textBox35.Text);
                label91.Text = salaryCap.ToString();
                label99.Text = payroll.ToString();
            }
            else
            {
                MessageBox.Show("Adam Frazier 선수가 계약규모를 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button13.Enabled = false;
                    button13.Text = "계약실패";
                }
                i++;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double player_money = random.Next(3, 5);
            double player_year = random.Next(1, 2);
            int ind = random.Next(1, 3);
            if (textBox34.Text == "" && textBox33.Text == "")
            {
                MessageBox.Show("계약기간과 금액을 모두 입력하세요");
            }
            else if (double.Parse(textBox34.Text) < player_year)
            {
                MessageBox.Show("Scott Kingery 선수가 계약기간을 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button19.Enabled = false;
                    button19.Text = "계약실패";
                }
                i++;
            }
            else if (double.Parse(textBox33.Text) > player_money * player_year)
            {
                MessageBox.Show("Scott Kingery 선수가 계약을 받아들였습니다!");
                button19.Enabled = false;
                button19.Text = "계약완료";
                richTextBox44.Text += "\n" + string.Format("Scott Kingery를 {0}년 {1:0.0}M달러에 영입", double.Parse(textBox34.Text), double.Parse(textBox33.Text));
                salaryCap -= double.Parse(textBox33.Text) / double.Parse(textBox34.Text);
                payroll -= double.Parse(textBox33.Text);
                label91.Text = salaryCap.ToString();
                label99.Text = payroll.ToString();
            }
            else
            {
                MessageBox.Show("Scott Kingery 선수가 계약규모를 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button19.Enabled = false;
                    button19.Text = "계약실패";
                }
                i++;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double player_money = random.Next(3, 5);
            double player_year = random.Next(11, 14);
            int ind = random.Next(1, 3);
            if (textBox32.Text == "" && textBox31.Text == "")
            {
                MessageBox.Show("계약기간과 금액을 모두 입력하세요");
            }
            else if (double.Parse(textBox32.Text) < player_year)
            {
                MessageBox.Show("Whit Merrifield 선수가 계약기간을 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button25.Enabled = false;
                    button25.Text = "계약실패";
                }
                i++;
            }
            else if (double.Parse(textBox31.Text) > player_money * player_year)
            {
                MessageBox.Show("Whit Merrifield 선수가 계약을 받아들였습니다!");
                button25.Enabled = false;
                button25.Text = "계약완료";
                richTextBox44.Text += "\n" + string.Format("Whit Merrifield를 {0}년 {1:0.0}M달러에 영입", double.Parse(textBox32.Text), double.Parse(textBox31.Text));
                salaryCap -= double.Parse(textBox31.Text) / double.Parse(textBox32.Text);
                payroll -= double.Parse(textBox31.Text);
                label91.Text = salaryCap.ToString();
                label99.Text = payroll.ToString();
            }
            else
            {
                MessageBox.Show("Whit Merrifield 선수가 계약규모를 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button25.Enabled = false;
                    button25.Text = "계약실패";
                }
                i++;
            }
        }
        //
        private void button43_Click(object sender, EventArgs e)
        {
            double player_money = random.Next(4, 5);
            double player_year = random.Next(1, 2);
            int ind = random.Next(1, 3);
            if (textBox30.Text == "" && textBox29.Text == "")
            {
                MessageBox.Show("계약기간과 금액을 모두 입력하세요");
            }
            else if (double.Parse(textBox30.Text) < player_year)
            {
                MessageBox.Show("Yolmer Sánchez 선수가 계약기간을 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button43.Enabled = false;
                    button43.Text = "계약실패";
                }
                i++;
            }
            else if (double.Parse(textBox29.Text) > player_money * player_year)
            {
                MessageBox.Show("Yolmer Sánchez 선수가 계약을 받아들였습니다!");
                button43.Enabled = false;
                button43.Text = "계약완료";
                richTextBox44.Text += "\n" + string.Format("Yolmer Sánchez를 {0}년 {1:0.0}M달러에 영입", double.Parse(textBox30.Text), double.Parse(textBox29.Text));
                salaryCap -= double.Parse(textBox29.Text) / double.Parse(textBox30.Text);
                payroll -= double.Parse(textBox29.Text);
                label91.Text = salaryCap.ToString();
                label99.Text = payroll.ToString();
            }
            else
            {
                MessageBox.Show("Yolmer Sánchez 선수가 계약규모를 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button43.Enabled = false;
                    button43.Text = "계약실패";
                }
                i++;
            }
        }
        //Cory Spangenberg
        private void button37_Click(object sender, EventArgs e)
        {
            double player_money = random.Next(4, 5);
            double player_year = random.Next(1, 2);
            int ind = random.Next(1, 3);
            if (textBox28.Text == "" && textBox27.Text == "")
            {
                MessageBox.Show("계약기간과 금액을 모두 입력하세요");
            }
            else if (double.Parse(textBox28.Text) < player_year)
            {
                MessageBox.Show("Cory Spangenberg 선수가 계약기간을 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button37.Enabled = false;
                    button37.Text = "계약실패";
                }
                i++;
            }
            else if (double.Parse(textBox27.Text) > player_money * player_year)
            {
                MessageBox.Show("Cory Spangenberg 선수가 계약을 받아들였습니다!");
                button37.Enabled = false;
                button37.Text = "계약완료";
                richTextBox44.Text += "\n" + string.Format("Cory Spangenberg를 {0}년 {1:0.0}M달러에 영입", double.Parse(textBox28.Text), double.Parse(textBox27.Text));
                salaryCap -= double.Parse(textBox27.Text) / double.Parse(textBox28.Text);
                payroll -= double.Parse(textBox27.Text);
                label91.Text = salaryCap.ToString();
                label99.Text = payroll.ToString();
            }
            else
            {
                MessageBox.Show("Cory Spangenberg 선수가 계약규모를 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button37.Enabled = false;
                    button37.Text = "계약실패";
                }
                i++;
            }
        }
        //Kolten Wong
        private void button31_Click(object sender, EventArgs e)
        {
            double player_money = random.Next(9, 11);
            double player_year = random.Next(1, 2);
            int ind = random.Next(1, 3);
            if (textBox26.Text == "" && textBox25.Text == "")
            {
                MessageBox.Show("계약기간과 금액을 모두 입력하세요");
            }
            else if (double.Parse(textBox26.Text) < player_year)
            {
                MessageBox.Show("Kolten Wong 선수가 계약기간을 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button31.Enabled = false;
                    button31.Text = "계약실패";
                }
                i++;
            }
            else if (double.Parse(textBox25.Text) > player_money * player_year)
            {
                MessageBox.Show("Kolten Wong 선수가 계약을 받아들였습니다!");
                button31.Enabled = false;
                button31.Text = "계약완료";
                richTextBox44.Text += "\n" + string.Format("Kolten Wong를 {0}년 {1:0.0}M달러에 영입", double.Parse(textBox26.Text), double.Parse(textBox25.Text));
                salaryCap -= double.Parse(textBox25.Text) / double.Parse(textBox26.Text);
                payroll -= double.Parse(textBox25.Text);
                label91.Text = salaryCap.ToString();
                label99.Text = payroll.ToString();
            }
            else
            {
                MessageBox.Show("Kolten Wong 선수가 계약규모를 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button31.Enabled = false;
                    button31.Text = "계약실패";
                }
                i++;
            }
        }
        ///////////////////////////////////////////////////3루수
        private void button49_Click(object sender, EventArgs e)
        {

        }

        private void button157_Click(object sender, EventArgs e)
        {
            double player_money = random.Next(3, 5);
            double player_year = random.Next(1, 2);
            int ind = random.Next(1, 3);
            if (textBox84.Text == "" && textBox83.Text == "")
            {
                MessageBox.Show("계약기간과 금액을 모두 입력하세요");
            }
            else if (double.Parse(textBox84.Text) < player_year)
            {
                MessageBox.Show("Hyun Jin Ryu 선수가 계약기간을 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button157.Enabled = false;
                    button157.Text = "계약실패";
                }
                i++;
            }
            else if (double.Parse(textBox83.Text) > player_money * player_year)
            {
                MessageBox.Show("Hyun Jin Ryu 선수가 계약을 받아들였습니다!");
                button157.Enabled = false;
                button157.Text = "계약완료";
                richTextBox44.Text += "\n" + string.Format("Hyun Jin Ryu를 {0}년 {1:0.0}M달러에 영입", double.Parse(textBox84.Text), double.Parse(textBox83.Text));
                salaryCap -= double.Parse(textBox83.Text) / double.Parse(textBox84.Text);
                payroll -= double.Parse(textBox83.Text);
                label91.Text = salaryCap.ToString();
                label99.Text = payroll.ToString();
            }
            else
            {
                MessageBox.Show("Hyun Jin Ryu 선수가 계약규모를 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button157.Enabled = false;
                    button157.Text = "계약실패";
                }
                i++;
            }
        }

        private void button163_Click(object sender, EventArgs e)
        {
            double player_money = random.Next(4, 6);
            double player_year = random.Next(23, 26);
            int ind = random.Next(1, 3);
            if (textBox82.Text == "" && textBox81.Text == "")
            {
                MessageBox.Show("계약기간과 금액을 모두 입력하세요");
            }
            else if (double.Parse(textBox82.Text) < player_year)
            {
                MessageBox.Show("Clayton Kershaw 선수가 계약기간을 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button163.Enabled = false;
                    button163.Text = "계약실패";
                }
                i++;
            }
            else if (double.Parse(textBox81.Text) > player_money * player_year)
            {
                MessageBox.Show("Clayton Kershaw 선수가 계약을 받아들였습니다!");
                button163.Enabled = false;
                button163.Text = "계약완료";
                richTextBox44.Text += "\n" + string.Format("Clayton Kershaw를 {0}년 {1:0.0}M달러에 영입", double.Parse(textBox82.Text), double.Parse(textBox81.Text));
                salaryCap -= double.Parse(textBox81.Text) / double.Parse(textBox82.Text);
                payroll -= double.Parse(textBox81.Text);
                label91.Text = salaryCap.ToString();
                label99.Text = payroll.ToString();
            }
            else
            {
                MessageBox.Show("Clayton Kershaw 선수가 계약규모를 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button163.Enabled = false;
                    button163.Text = "계약실패";
                }
                i++;
            }
        }

        private void button169_Click(object sender, EventArgs e)
        {
            double player_money = random.Next(19, 21);
            double player_year = random.Next(4, 6);
            int ind = random.Next(1, 3);
            if (textBox80.Text == "" && textBox79.Text == "")
            {
                MessageBox.Show("계약기간과 금액을 모두 입력하세요");
            }
            else if (double.Parse(textBox80.Text) < player_year)
            {
                MessageBox.Show("kyle Hendricks 선수가 계약기간을 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button169.Enabled = false;
                    button169.Text = "계약실패";
                }
                i++;
            }
            else if (double.Parse(textBox79.Text) > player_money * player_year)
            {
                MessageBox.Show("kyle Hendricks 선수가 계약을 받아들였습니다!");
                button169.Enabled = false;
                button169.Text = "계약완료";
                richTextBox44.Text += "\n" + string.Format("kyle Hendricks를 {0}년 {1:0.0}M달러에 영입", double.Parse(textBox80.Text), double.Parse(textBox79.Text));
                salaryCap -= double.Parse(textBox79.Text) / double.Parse(textBox80.Text);
                payroll -= double.Parse(textBox79.Text);
                label91.Text = salaryCap.ToString();
                label99.Text = payroll.ToString();
            }
            else
            {
                MessageBox.Show("kyle Hendricks 선수가 계약규모를 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button169.Enabled = false;
                    button169.Text = "계약실패";
                }
                i++;
            }
        }

        private void button181_Click(object sender, EventArgs e)
        {
            double player_money = random.Next(19, 21);
            double player_year = random.Next(2, 3);
            int ind = random.Next(1, 3);
            if (textBox76.Text == "" && textBox75.Text == "")
            {
                MessageBox.Show("계약기간과 금액을 모두 입력하세요");
            }
            else if (double.Parse(textBox76.Text) < player_year)
            {
                MessageBox.Show("Martín Pérez 선수가 계약기간을 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button181.Enabled = false;
                    button181.Text = "계약실패";
                }
                i++;
            }
            else if (double.Parse(textBox75.Text) > player_money * player_year)
            {
                MessageBox.Show("Martín Pérez 선수가 계약을 받아들였습니다!");
                button181.Enabled = false;
                button181.Text = "계약완료";
                richTextBox44.Text += "\n" + string.Format("Martín Pérez를 {0}년 {1:0.0}M달러에 영입", double.Parse(textBox76.Text), double.Parse(textBox75.Text));
                salaryCap -= double.Parse(textBox75.Text) / double.Parse(textBox76.Text);
                payroll -= double.Parse(textBox75.Text);
                label91.Text = salaryCap.ToString();
                label99.Text = payroll.ToString();
            }
            else
            {
                MessageBox.Show("Martín Pérez 선수가 계약규모를 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button181.Enabled = false;
                    button181.Text = "계약실패";
                }
                i++;
            }
        }

        private void button175_Click(object sender, EventArgs e)
        {
            double player_money = random.Next(24, 26);
            double player_year = random.Next(5, 7);
            int ind = random.Next(1, 3);
            if (textBox78.Text == "" && textBox77.Text == "")
            {
                MessageBox.Show("계약기간과 금액을 모두 입력하세요");
            }
            else if (double.Parse(textBox78.Text) < player_year)
            {
                MessageBox.Show("Aaron Nola 선수가 계약기간을 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button175.Enabled = false;
                    button175.Text = "계약실패";
                }
                i++;
            }
            else if (double.Parse(textBox77.Text) > player_money * player_year)
            {
                MessageBox.Show("Aaron Nola 선수가 계약을 받아들였습니다!");
                button175.Enabled = false;
                button175.Text = "계약완료";
                richTextBox44.Text += "\n" + string.Format("Aaron Nola를 {0}년 {1:0.0}M달러에 영입", double.Parse(textBox78.Text), double.Parse(textBox77.Text));
                salaryCap -= double.Parse(textBox77.Text) / double.Parse(textBox78.Text);
                payroll -= double.Parse(textBox77.Text);
                label91.Text = salaryCap.ToString();
                label99.Text = payroll.ToString();
            }
            else
            {
                MessageBox.Show("Aaron Nola 선수가 계약규모를 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button175.Enabled = false;
                    button175.Text = "계약실패";
                }
                i++;
            }
        }

        private void button187_Click(object sender, EventArgs e)
        {
            double player_money = random.Next(8, 11);
            double player_year = random.Next(20, 24);
            int ind = random.Next(1, 3);
            if (textBox74.Text == "" && textBox73.Text == "")
            {
                MessageBox.Show("계약기간과 금액을 모두 입력하세요");
            }
            else if (double.Parse(textBox74.Text) < player_year)
            {
                MessageBox.Show("Julio Urías 선수가 계약기간을 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button187.Enabled = false;
                    button187.Text = "계약실패";
                }
                i++;
            }
            else if (double.Parse(textBox73.Text) > player_money * player_year)
            {
                MessageBox.Show("Julio Urías 선수가 계약을 받아들였습니다!");
                button187.Enabled = false;
                button187.Text = "계약완료";
                richTextBox44.Text += "\n" + string.Format("Julio Urías를 {0}년 {1:0.0}M달러에 영입", double.Parse(textBox74.Text), double.Parse(textBox73.Text));
                salaryCap -= double.Parse(textBox73.Text) / double.Parse(textBox74.Text);
                payroll -= double.Parse(textBox73.Text);
                label91.Text = salaryCap.ToString();
                label99.Text = payroll.ToString();
            }
            else
            {
                MessageBox.Show("Julio Urías 선수가 계약규모를 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button187.Enabled = false;
                    button187.Text = "계약실패";
                }
                i++;
            }
        }

        private void button211_Click(object sender, EventArgs e)
        {
            double player_money = random.Next(48, 52);
            double player_year = random.Next(9, 13);
            int ind = random.Next(1, 3);
            if (textBox86.Text == "" && textBox85.Text == "")
            {
                MessageBox.Show("계약기간과 금액을 모두 입력하세요");
            }
            else if (double.Parse(textBox86.Text) < player_year)
            {
                MessageBox.Show("Shohei Ohtani 선수가 계약기간을 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button211.Enabled = false;
                    button211.Text = "계약실패";
                }
                i++;
            }
            else if (double.Parse(textBox85.Text) > player_money * player_year)
            {
                MessageBox.Show("Shohei Ohtani 선수가 계약을 받아들였습니다!");
                button211.Enabled = false;
                button211.Text = "계약완료";
                richTextBox44.Text += "\n" + string.Format("Shohei Ohtani를 {0}년 {1:0.0}M달러에 영입", double.Parse(textBox86.Text), double.Parse(textBox85.Text));
                salaryCap -= double.Parse(textBox85.Text) / double.Parse(textBox86.Text);
                payroll -= double.Parse(textBox85.Text);
                label91.Text = salaryCap.ToString();
                label99.Text = payroll.ToString();
            }
            else
            {
                MessageBox.Show("Shohei Ohtani 선수가 계약규모를 이유로 거절했습니다.");
                if (i >= ind)
                {
                    button211.Enabled = false;
                    button211.Text = "계약실패";
                }
                i++;
            }
        }

        
        private void 도움말ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            modalForm modal = new modalForm();
            modal.ShowDialog(); // 모달 대화상자 생성
                                // 모달 대화상자가 Close()될 때까지 홀딩 상태
            modal.Dispose();
            modal.Enabled= false;


        }
    }
}