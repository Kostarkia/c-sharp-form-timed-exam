using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sharp__form_timed_exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int puan = 0;
        int minute = 9;
        int second = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            second--;
            if (second == 0)
            {
                second = 59;
                minute--;

                if (minute == 0)
                {

                    minute = 0;
                    second = 0;
                    label3.Text = "0";
                    label4.Text = "0";
                    timer1.Stop();
                    MessageBox.Show("Click on the CALCULATE Button to Calculate Your Score.", "Your Time Has Expired.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("Please Do Not Check Another Option.", "Your Time Has Expired.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
            label3.Text = minute.ToString();
            label4.Text = second.ToString();
            progressBar1.Value--;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            panel1.Enabled = true;
            timer1.Enabled = true;
            timer1.Start();
             progressBar1.Value = 600;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == true && radioButton3.Checked == false && radioButton4.Checked == false)//1
            {
                puan += 10;
                radioButton2.BackColor = Color.Aqua;
            }

            if (radioButton2.Checked == false)
            {
                radioButton2.BackColor = Color.Red;
            }





            if (radioButton5.Checked == true && radioButton6.Checked == false && radioButton7.Checked == false && radioButton8.Checked == false)//2
            {
                puan += 10;
                radioButton5.BackColor = Color.Aqua;
            }
            if (radioButton5.Checked == false)
            {
                radioButton5.BackColor = Color.Red;
            }





            if (radioButton9.Checked == true && radioButton10.Checked == false && radioButton11.Checked == false && radioButton12.Checked == false)//3
            {
                puan += 10;
                radioButton9.BackColor = Color.Aqua;
            }
            if (radioButton9.Checked == false)
            {
                radioButton9.BackColor = Color.Red;
            }





            if (radioButton13.Checked == false && radioButton14.Checked == false && radioButton15.Checked == false && radioButton16.Checked == true)//4
            {
                puan += 10;
                radioButton16.BackColor = Color.Aqua;
            }
            if (radioButton16.Checked == false)
            {
                radioButton16.BackColor = Color.Red;
            }




            if (radioButton17.Checked == false && radioButton18.Checked == true && radioButton19.Checked == false && radioButton20.Checked == false)//5
            {
                puan += 10;
                radioButton18.BackColor = Color.Aqua;

            }
            if (radioButton18.Checked == false)
            {
                radioButton18.BackColor = Color.Red;
            }





            if (radioButton21.Checked == false && radioButton22.Checked == false && radioButton23.Checked == false && radioButton24.Checked == true)//6
            {
                puan += 10;
                radioButton24.BackColor = Color.Aqua;
            }
            if (radioButton24.Checked == false)
            {
                radioButton24.BackColor = Color.Red;
            }



            if (radioButton25.Checked == false && radioButton26.Checked == true && radioButton28.Checked ==false  && radioButton27.Checked == false)//7
            {
                puan += 10;
                radioButton26.BackColor = Color.Aqua;
            }
            if (radioButton26.Checked == false)
            {
                radioButton26.BackColor = Color.Red;
            }




            if (radioButton29.Checked == false && radioButton31.Checked == true && radioButton30.Checked == false && radioButton32.Checked == false)//8
            {
                puan += 10;
                radioButton31.BackColor = Color.Aqua;
            }
            if (radioButton31.Checked == false)
            {
                radioButton31.BackColor = Color.Red;
            }




            if (radioButton33.Checked == true && radioButton34.Checked == false && radioButton35.Checked == false && radioButton36.Checked == false)//9
            {
                puan += 10;
                radioButton33.BackColor = Color.Aqua;
            }
            if (radioButton33.Checked == false)
            {
                radioButton33.BackColor = Color.Red;

            }






            if (radioButton37.Checked == true && radioButton38.Checked == false && radioButton39.Checked == false  && radioButton40.Checked == false)//10
            {
                puan += 10;
                radioButton37.BackColor = Color.Aqua;
            }
            if (radioButton37.Checked == false)
            {
                radioButton37.BackColor = Color.Red;

            }
            int toplam = 0;
            toplam = puan;




            point.Text = toplam.ToString();
            timer1.Stop();
            panel1.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            label2.Font = fontDialog1.Font;
            label2.ForeColor = fontDialog1.Color;
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            radioButton1.AutoCheck = false;
            radioButton8.AutoCheck = false;
            radioButton12.AutoCheck = false;
            radioButton16.AutoCheck = false;
            radioButton20.AutoCheck = false;
            radioButton24.AutoCheck = false;
            radioButton28.AutoCheck = false;
            radioButton32.AutoCheck = false;
            radioButton36.AutoCheck = false;
            radioButton40.AutoCheck = false;
        }
    }
}
