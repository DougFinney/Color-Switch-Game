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
            }

            player.BackColor = colors[i];
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
