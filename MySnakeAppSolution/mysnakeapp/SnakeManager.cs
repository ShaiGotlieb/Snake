using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MySnakeApp
{
    class SnakeManager
    {
        private Rectangle[] snake;
        private SolidBrush brush;
        private int x, y, width, height;

        public SnakeManager()
        {
            snake = new Rectangle[3];
            brush = new SolidBrush(Color.DarkGreen);
            x = 20;
            y = 0;
            width = 10;
            height = 10;
            for (int i = 0; i < snake.Length; i++)
            {
                snake[i] = new Rectangle(x, y, width, height);
                x -= 10;
            }
        }

        public Rectangle[] GetSnake()
        {
            return snake;
        }

        public void DrawSnake(Graphics board)
        {
            foreach (Rectangle link in snake)
            {
                board.FillRectangle(brush, link);
            }
        }

        public void DrawSnakeProgress()     
        {
            for (int i = snake.Length - 1; i > 0; i--)
            {
                snake[i] = snake[i - 1];
            }
        }

        public void MoveDown()
        {
            DrawSnakeProgress();
            snake[0].Y += 10;
        }
        
        public void MoveUp()
        {
            DrawSnakeProgress();
            snake[0].Y -= 10;
        }
        
        public void MoveLeft()
        {
            DrawSnakeProgress();
            snake[0].X -= 10;
        }
     
        public void MoveRight()
        {
            DrawSnakeProgress();
            snake[0].X += 10;
        }

        public void MakeSnakeGrow()
        {
            Rectangle[] newSnake = new Rectangle[snake.Length + 1];
            for (int i = 0; i < snake.Length; i++)
            {
                newSnake[i] = snake[i];
            }

            int lastX = snake[snake.Length - 1].X;
            int lastY = snake[snake.Length - 1].Y;

            newSnake[newSnake.Length - 1] = new Rectangle(lastX, lastY, width, height);
            snake = newSnake;
        }
    }
}
