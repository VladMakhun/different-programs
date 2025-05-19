using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Star
    {
        public int Type { get; set; }
        public Color FillColor { get; set; }
        public Color BorderColor { get; set; }
        public int Size { get; set; }
        public Point Position { get; set; }

        public override string ToString()
        {
            return $"Зірка {Type}, X={Position.X}, Y={Position.Y}, R={Size}";
        }

        public void Draw(Graphics g)
        {
            PointF[] points = StarHelper.GenerateStarPoints(Type, Position, Size);
            using (Brush b = new SolidBrush(FillColor))
                g.FillPolygon(b, points);
            using (Pen p = new Pen(BorderColor, 2))
                g.DrawPolygon(p, points);
        }
    }
}
