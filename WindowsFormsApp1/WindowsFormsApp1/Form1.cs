using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        List<Star> stars = new List<Star>();

        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Тип 1", "Тип 2", "Тип 3" });
            comboBox1.SelectedIndex = 0;

            var colorNames = Enum.GetNames(typeof(KnownColor));
            comboBox2.Items.AddRange(colorNames);
            comboBox2.SelectedItem = "Yellow";
            comboBox3.Items.AddRange(colorNames);
            comboBox3.SelectedItem = "Black";

            numericUpDown1.Value = 40; // розмір
            numericUpDown2.Value = 100; // X
            numericUpDown3.Value = 100; // Y

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var star = new Star
            {
                Type = comboBox1.SelectedIndex + 1,
                FillColor = Color.FromName(comboBox2.SelectedItem.ToString()),
                BorderColor = Color.FromName(comboBox3.SelectedItem.ToString()),
                Size = (int)numericUpDown1.Value,
                Position = new Point((int)numericUpDown2.Value, (int)numericUpDown3.Value)
            };

            stars.Add(star);
            listBox1.Items.Add(star);
            Redraw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stars.Clear();
            listBox1.Items.Clear();
            Redraw();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (i >= 0)
            {
                stars.RemoveAt(i);
                listBox1.Items.RemoveAt(i);
                Redraw();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Redraw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                foreach (var star in stars)
                {
                    star.Draw(g);
                }
            }
            pictureBox1.Image = bmp;
        }
    }
}
