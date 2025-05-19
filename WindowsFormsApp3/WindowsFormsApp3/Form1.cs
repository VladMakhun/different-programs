using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // 1. Малюємо будинок (стіни — прямокутник)
            Brush wallBrush = Brushes.BurlyWood;
            g.FillRectangle(wallBrush, 100, 150, 200, 150); // x, y, width, height

            // 2. Малюємо дах (трикутник — 3 лінії)
            Pen roofPen = new Pen(Color.DarkRed, 3);
            Point p1 = new Point(100, 150);
            Point p2 = new Point(200, 70);
            Point p3 = new Point(300, 150);
            g.DrawLine(roofPen, p1, p2);
            g.DrawLine(roofPen, p2, p3);

            // 3. Малюємо вікно (малий прямокутник)
            Brush windowBrush = Brushes.LightBlue;
            g.FillRectangle(windowBrush, 130, 180, 40, 40);

            // 4. Малюємо двері
            Brush doorBrush = Brushes.SaddleBrown;
            g.FillRectangle(doorBrush, 210, 200, 60, 100);

            // 5. Малюємо сонце (еліпс)
            Brush sunBrush = Brushes.Gold;
            g.FillEllipse(sunBrush, 320, 30, 60, 60); // x, y, width, height
        }
    }
}
