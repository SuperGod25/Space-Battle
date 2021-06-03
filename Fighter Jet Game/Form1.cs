using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fighter_Jet_Game
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, Shooting, isGameOver;
        int score, playerSpeed=12, enemySpeed, bulletSpeed;
        Random rnd = new Random();

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            resetGame();
        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {
            if(goLeft==true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            if(goRight==true && player.Left<735)
            {
                player.Left += playerSpeed;
            }
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        void resetGame()
        {
            timer1.Start();
        }

        void gameOver()
        {

        }
    }
}
