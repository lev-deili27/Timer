using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        int m = 0;
        int s = 0;
        int k = 0;
        string time;
        bool flag_pause = false;
        bool flag_stop = false;

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "00:00";
            pictureBox1.Image = Timer.Properties.Resources.timer_60;
            flag_stop = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (s == 0)
            {
                if (m > 0)
                {
                    m--;
                    s = 60;
                }
                else
                {
                    timer1.Enabled = false;
                    s = 0;
                    k = 0;
                    label1.Text = "00:00";
                    pictureBox1.Image = Timer.Properties.Resources.timer_60;
                }
              
            }
            if (s > 0)
            {
                s--;
            }
            if (m < 10 && s < 10)
            {
                label1.Text = "0"+m.ToString() + ":" + "0" + s.ToString();
            }
            else if (s < 10)
            {
                label1.Text = m.ToString() + ":" + "0"+s.ToString();
            }
            else if (m < 10)
            {
                label1.Text = "0"+m.ToString() + ":" + s.ToString();
            }
            else
            {
                label1.Text = m.ToString() + ":" + s.ToString();
            }
            k = s % 60;
            k--;
            if (k == 1) { pictureBox1.Image = Timer.Properties.Resources.timer_0; }
            if (k == 2) { pictureBox1.Image = Timer.Properties.Resources.timer_1; }
            if (k == 3) { pictureBox1.Image = Timer.Properties.Resources.timer_2; }
            if (k == 4) { pictureBox1.Image = Timer.Properties.Resources.timer_3; }
            if (k == 5) { pictureBox1.Image = Timer.Properties.Resources.timer_4; }
            if (k == 6) { pictureBox1.Image = Timer.Properties.Resources.timer_5; }
            if (k == 7) { pictureBox1.Image = Timer.Properties.Resources.timer_6; }
            if (k == 8) { pictureBox1.Image = Timer.Properties.Resources.timer_7; }
            if (k == 9) { pictureBox1.Image = Timer.Properties.Resources.timer_8; }
            if (k == 10) { pictureBox1.Image = Timer.Properties.Resources.timer_9; }
            if (k == 11) { pictureBox1.Image = Timer.Properties.Resources.timer_10; }
            if (k == 12) { pictureBox1.Image = Timer.Properties.Resources.timer_11; }
            if (k == 13) { pictureBox1.Image = Timer.Properties.Resources.timer_12; }
            if (k == 14) { pictureBox1.Image = Timer.Properties.Resources.timer_13; }
            if (k == 15) { pictureBox1.Image = Timer.Properties.Resources.timer_14; }
            if (k == 16) { pictureBox1.Image = Timer.Properties.Resources.timer_15; }
            if (k == 17) { pictureBox1.Image = Timer.Properties.Resources.timer_16; }
            if (k == 18) { pictureBox1.Image = Timer.Properties.Resources.timer_17; }
            if (k == 19) { pictureBox1.Image = Timer.Properties.Resources.timer_18; }
            if (k == 20) { pictureBox1.Image = Timer.Properties.Resources.timer_19; }
            if (k == 21) { pictureBox1.Image = Timer.Properties.Resources.timer_20; }
            if (k == 22) { pictureBox1.Image = Timer.Properties.Resources.timer_21; }
            if (k == 23) { pictureBox1.Image = Timer.Properties.Resources.timer_22; }
            if (k == 24) { pictureBox1.Image = Timer.Properties.Resources.timer_23; }
            if (k == 25) { pictureBox1.Image = Timer.Properties.Resources.timer_24; }
            if (k == 26) { pictureBox1.Image = Timer.Properties.Resources.timer_25; }
            if (k == 27) { pictureBox1.Image = Timer.Properties.Resources.timer_26; }
            if (k == 28) { pictureBox1.Image = Timer.Properties.Resources.timer_27; }
            if (k == 29) { pictureBox1.Image = Timer.Properties.Resources.timer_28; }
            if (k == 30) { pictureBox1.Image = Timer.Properties.Resources.timer_29; }
            if (k == 31) { pictureBox1.Image = Timer.Properties.Resources.timer_30; }
            if (k == 32) { pictureBox1.Image = Timer.Properties.Resources.timer_31; }
            if (k == 33) { pictureBox1.Image = Timer.Properties.Resources.timer_32; }
            if (k == 34) { pictureBox1.Image = Timer.Properties.Resources.timer_33; }
            if (k == 35) { pictureBox1.Image = Timer.Properties.Resources.timer_34; }
            if (k == 36) { pictureBox1.Image = Timer.Properties.Resources.timer_35; }
            if (k == 37) { pictureBox1.Image = Timer.Properties.Resources.timer_36; }
            if (k == 38) { pictureBox1.Image = Timer.Properties.Resources.timer_37; }
            if (k == 39) { pictureBox1.Image = Timer.Properties.Resources.timer_38; }
            if (k == 40) { pictureBox1.Image = Timer.Properties.Resources.timer_39; }
            if (k == 41) { pictureBox1.Image = Timer.Properties.Resources.timer_40; }
            if (k == 42) { pictureBox1.Image = Timer.Properties.Resources.timer_41; }
            if (k == 43) { pictureBox1.Image = Timer.Properties.Resources.timer_42; }
            if (k == 44) { pictureBox1.Image = Timer.Properties.Resources.timer_43; }
            if (k == 45) { pictureBox1.Image = Timer.Properties.Resources.timer_44; }
            if (k == 46) { pictureBox1.Image = Timer.Properties.Resources.timer_45; }
            if (k == 47) { pictureBox1.Image = Timer.Properties.Resources.timer_46; }
            if (k == 48) { pictureBox1.Image = Timer.Properties.Resources.timer_47; }
            if (k == 49) { pictureBox1.Image = Timer.Properties.Resources.timer_48; }
            if (k == 50) { pictureBox1.Image = Timer.Properties.Resources.timer_49; }
            if (k == 51) { pictureBox1.Image = Timer.Properties.Resources.timer_50; }
            if (k == 52) { pictureBox1.Image = Timer.Properties.Resources.timer_52; }
            if (k == 53) { pictureBox1.Image = Timer.Properties.Resources.timer_53; }
            if (k == 54) { pictureBox1.Image = Timer.Properties.Resources.timer_54; }
            if (k == 55) { pictureBox1.Image = Timer.Properties.Resources.timer_55; }
            if (k == 56) { pictureBox1.Image = Timer.Properties.Resources.timer_56; }
            if (k == 57) { pictureBox1.Image = Timer.Properties.Resources.timer_57; }
            if (k == 58) { pictureBox1.Image = Timer.Properties.Resources.timer_58; }
            if (k == 59) { pictureBox1.Image = Timer.Properties.Resources.timer_59; }
           // if (k == 60) { pictureBox1.Image = Timer.Properties.Resources.timer_59; }
            if (k == 60) { k = 0; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            flag_pause = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (flag_pause == true)
            {
                timer1.Enabled = true;
                if (flag_stop == true)
                {
                 
                    timer1.Enabled = true;
                    time = textBox1.Text;
                    s = Convert.ToInt32(time);
                    m = s / 60;
                    s %= 60;
                    flag_stop = false;
                    flag_pause = false;
                }
            }
            else
            {
              
                timer1.Enabled = true;
                time = textBox1.Text;
                s = Convert.ToInt32(time);
                m = s / 60;
                s %= 60;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Пожалуйста, введите время в секундах");
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

      
    }
}
