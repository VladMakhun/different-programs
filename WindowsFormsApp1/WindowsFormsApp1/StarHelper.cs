using System;
using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApp1
{
    public static class StarHelper
    {
        public static PointF[] GenerateStarPoints(int type, Point center, float outerRadius)
        {
            int points;

            // Визначаємо кількість вершин для кожного типу зірки
            switch (type)
            {
                case 1:
                    points = 5;
                    break;
                case 2:
                    points = 6;
                    break;
                case 3:
                    points = 8;
                    break;
                default:
                    points = 5;
                    break;
            }

            // Внутрішній радіус для проміжних точок зірки
            float innerRadius = outerRadius * 0.5f;
            List<PointF> result = new List<PointF>();

            // Початковий кут
            double angle = -Math.PI / 2;

            for (int i = 0; i < points * 2; i++)
            {
                float radius = (i % 2 == 0) ? outerRadius : innerRadius;
                float x = center.X + (float)(radius * Math.Cos(angle));
                float y = center.Y + (float)(radius * Math.Sin(angle));
                result.Add(new PointF(x, y));
                angle += Math.PI / points;
            }

            return result.ToArray();
        }
    }
}
