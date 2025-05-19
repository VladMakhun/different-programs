using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace last
{
    internal class MovingObject
    {
        public float X, Y;
        public float DX, DY;
        public int Size;
        public Color Color;

        public MovingObject(float x, float y, float dx, float dy, int size, Color color)
        {
            X = x;
            Y = y;
            DX = dx;
            DY = dy;
            Size = size;
            Color = color;
        }

        public void Move(int width, int height)
        {
            X += DX;
            Y += DY;

            // Відбивання від країв
            if (X < 0 || X + Size > width)
                DX = -DX;
            if (Y < 0 || Y + Size > height)
                DY = -DY;
        }

        public void Draw(Graphics g)
        {
            using (Brush brush = new SolidBrush(Color))
            {
                g.FillEllipse(brush, X, Y, Size, Size);
            }
        }
    }
}
