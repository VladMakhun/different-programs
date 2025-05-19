using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace last
{
    public partial class Form1 : Form
    {

        List<MovingObject> objects = new List<MovingObject>();
        Random rand = new Random();



        public Form1()
        {
            InitializeComponent();
            pictureBox1.Paint += pictureBox1_Paint;
            timer1.Tick += timer1_Tick;
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++) // Створити 10 об’єктів
            {
                float x = rand.Next(0, pictureBox1.Width - 30);
                float y = rand.Next(0, pictureBox1.Height - 30);
                float dx = (float)(rand.NextDouble() * 4 - 2);
                float dy = (float)(rand.NextDouble() * 4 - 2);
                int size = rand.Next(20, 40);
                Color color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

                objects.Add(new MovingObject(x, y, dx, dy, size, color));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var obj in objects)
            {
                obj.Move(pictureBox1.Width, pictureBox1.Height);
            }

            pictureBox1.Invalidate(); // Запускає перерисовку
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var obj in objects)
            {
                obj.Draw(e.Graphics);
            }
        }

        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
