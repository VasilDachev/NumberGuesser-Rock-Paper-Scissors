using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPS
{
    public partial class Form1 : Form
    {
        int scorePlayer = 0;
        int scoreComp = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rock_Click(object sender, EventArgs e)
        {
            Play(1);
        }

        private void paper_Click(object sender, EventArgs e)
        {
            Play(2);
        }

        private void scissors_Click(object sender, EventArgs e)
        {
            Play(3);
        }

        private void Play(int selection)
        {
            Random ran = new Random();
            int compSelection = ran.Next(1, 4);
            Image(playerPic, selection);
            Image(compPic, compSelection);

            if (compSelection == selection)
            {
                return;
            }
            switch (selection)
            {
                case 1:
                    if (compSelection == 2)
                        Score(true);
                    else
                        Score(false);
                    break;
                case 2:
                    if (compSelection == 3)
                        Score(true);
                    else
                        Score(false);
                    break;
                case 3:
                    if (compSelection == 1)
                        Score(true);
                    else
                        Score(false);
                    break;

            }
        }


        private void Image(PictureBox pb, int img)
        {
            if (img == 1) pb.Image = RPS.Properties.Resources.TheRock;
            if (img == 2) pb.Image = RPS.Properties.Resources.Paper;
            if (img == 3) pb.Image = RPS.Properties.Resources.Scissors;
        }

        private void Score(bool playerWon)
        {
            if (playerWon)
            {
                scorePlayer++;
                playerScore.Text = Convert.ToString(scorePlayer);
            }
            else
            {
                scoreComp++;
                compScore.Text = Convert.ToString(scoreComp);
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click_1(object sender, EventArgs e)
        {
            scorePlayer = 0;
            scoreComp = 0;
            playerPic.Image = null;
            compPic.Image = null;
            compScore.Text = Convert.ToString(scoreComp);
            playerScore.Text = Convert.ToString(scorePlayer);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
