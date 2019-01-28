using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_week_3
{
    public partial class Form1 : Form
    {
        
        int minNum;
        int maxNum;
        int randNum;
        int att = 0;
        public int RandomNumber(int minNum, int maxNum)
        {
            Random random = new Random();
            return random.Next(minNum, maxNum);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            guess.Enabled = true;
            att = 0;
            attempts.Text = Convert.ToString(att);
            label1.Visible = false;
            picBox1.Image = null;
            picBox2.Image = null;
            if (comboBox1.Text == "1-10")
            {
                maxNum = 10;
                randNum = RandomNumber(minNum, maxNum);

                label1.Text = Convert.ToString(randNum);
            }
            else if (comboBox1.Text == "1-50")
            {
                maxNum = 50;
                randNum = RandomNumber(minNum, maxNum);

                label1.Text = Convert.ToString(randNum);
            }
            else if (comboBox1.Text == "1-100")
            {
                maxNum = 100;
                randNum = RandomNumber(minNum, maxNum);

                label1.Text = Convert.ToString(randNum);
            }
            else if (comboBox1.Text == "1-1000")
            {
                maxNum = 1000;
                randNum = RandomNumber(minNum, maxNum);

                label1.Text = Convert.ToString(randNum);
            }
            else MessageBox.Show("Please select a difficulty!");
        }

        private void guess_Click(object sender, EventArgs e)
        {
            att++;
            attempts.Text = Convert.ToString(att);
            if (att >= 10)
            {
                picBox2.Image = Homework_week_3.Properties.Resources.gameover;
                guess.Enabled = false;
                picBox1.Image = null;
            }

            try
            {

                if (Convert.ToInt32(textBox1.Text) > randNum && textBox1.Text != "Choose a difficulty")
                {
                    picBox1.Visible = true;
                    picBox1.Image = Homework_week_3.Properties.Resources.arrowDown;
                }
                else if (Convert.ToInt32(textBox1.Text) < randNum && textBox1.Text != "Choose a difficulty")
                {
                    picBox1.Visible = true;
                    picBox1.Image = Homework_week_3.Properties.Resources.arrowUp;
                }
                else if (Convert.ToInt32(textBox1.Text) == randNum && textBox1.Text != "Choose a difficulty")
                {
                    picBox2.Image = Homework_week_3.Properties.Resources.thumUp;
                    picBox1.Image = null;
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Please enter a number!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cheat_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }
    }
}
