using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySnakeApp
{
    public partial class SnakeForm : Form
    {
        Random randomLocation = new Random();
        Graphics board;
        SnakeManager manager = new SnakeManager();
        FoodFactory factory;

        bool left = false;
        bool right = false;
        bool up = false;
        bool down = false;
        public static int score = 0;

        public static int getScore()
        {
            return score;
        }

        

        public SnakeForm()
        {
            InitializeComponent();
            factory = new FoodFactory(randomLocation);
        }

        private void SnakeForm_Paint(object sender, PaintEventArgs e)
        {
            board = e.Graphics;
            factory.DrawFood(board);
            manager.DrawSnake(board);
        }

        private void SnakeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                timer1.Enabled = true;
                headlineLabel.Text = "";
                spacebarLabel.Text = "";
                down = false;
                up = false;
                left = false;
                right = true;
            }
            if (e.KeyData == Keys.Down && up == false)
            {
                down = true;
                up = false;
                right = false;
                left = false;
            }
            if (e.KeyData == Keys.Up && down == false)
            {
                down = false;
                up = true;
                right = false;
                left = false;
            }
            if (e.KeyData == Keys.Left && right == false)
            {
                down = false;
                up = false;
                right = false;
                left = true;
            }
            if (e.KeyData == Keys.Right && left == false)
            {
                down = false;
                up = false;
                right = true;
                left = false;
            }
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            scoreCounter.Text = Convert.ToString(score);
            if (down) { manager.MoveDown(); }
            if (up) { manager.MoveUp(); }
            if (right) { manager.MoveRight(); }
            if (left) { manager.MoveLeft(); }
            this.Invalidate();
            Collision();   
                
            if (manager.GetSnake()[0].IntersectsWith(factory.food))
            {
                    score += 1;
                    manager.MakeSnakeGrow();
                    factory.Foodlocation(randomLocation);

            }
            
        }

        public void Restart()
        {
            timer1.Enabled = false;
            MessageBox.Show("GAME - OVER ! ! !");
            scoreCounter.Text = "0";
            score = 0;
            spacebarLabel.Text = "Press spacebar to begin";
            headlineLabel.Text = "Snake!";
            manager = new SnakeManager();
        }

        public void Collision()
        {
            if (manager.GetSnake()[0].X < 0 || manager.GetSnake()[0].X > 280)
            {
                Restart();

            }
            if (manager.GetSnake()[0].Y < 0 || manager.GetSnake()[0].Y > 290)
            {
                Restart();
            }

            for (int i = 1; i < manager.GetSnake().Length; i++)
            {
                if (manager.GetSnake()[0].IntersectsWith(manager.GetSnake()[i]))
                {
                    Restart();
                }
            }
        }

    }
}
