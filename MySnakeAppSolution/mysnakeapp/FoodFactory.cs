using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MySnakeApp
{
    class FoodFactory
    {
        private int x, y, width, height;
        private SolidBrush brush;
        public Rectangle food;

        public FoodFactory(Random randomFood)
        {
            x = randomFood.Next(0, 280);
            y = randomFood.Next(0, 290);
            brush = new SolidBrush(Color.Red);
            width = 10;
            height=10;
            food = new Rectangle(x, y, width, height);
        }

        public void Foodlocation(Random randomFood)
        {
            x = randomFood.Next(0, 280);
            y = randomFood.Next(0, 290);
        }

        public void DrawFood(Graphics board)
        {
            food.X = x;
            food.Y = y;
            board.FillRectangle(brush, food);
        }


    }
}
