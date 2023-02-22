using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Switch_Game
{
    public partial class Form1 : Form
    {
        List<Color> colors;

        Random rnd = new Random();
        Random blockPosition = new Random();

        int i;
        int speed = 5;
        int score = 0;
        int location;

        int blockColor;

        bool gameOver = false;
        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }
        
        //Two Events
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MainTimerTick(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;

            foreach (Control x in gameDisplay.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "block")
                {
                    x.Top += speed;

                    if (x.Top + x.Height > this.ClientSize.Height)
                    {
                        location = blockPosition.Next(400, 600) + (3 * blockPosition.Next(150, 250));

                        x.Top = location * -1;

                        blockColor = rnd.Next(0, colors.Count);

                        x.BackColor = colors[blockColor];

                        score += 1;
                    }
                }
            }

        }

        private void KeyIsPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space && gameOver == false)
            {
                i++;

                if (i > colors.Count - 1)
                {
                    i = 0;
                }

                player.BackColor = colors[i];                                //Changes Color Of Player
            }                                                     //All Coditions Met For Restart, R or r casing.          

            if (e.KeyChar == (char)Keys.R && gameOver == true || e.KeyChar == char.ToLower((char)Keys.R) && gameOver == true)
            {
                RestartGame();
            }
            

        }



        //Restart Function

        private void RestartGame()
        {

            blockOne.Top = -200;
            blockTwo.Top = -750;
            gameOver = false;

            colors = new List<Color> { Color.Red, Color.White, Color.Purple, Color.Yellow };

            i = 0;

            speed = 8;
            score = 0;

            txtScore.Text = "Score: " + score;

            GameTimer.Start();

        }
    }
}
