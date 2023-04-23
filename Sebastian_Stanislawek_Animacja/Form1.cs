using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sebastian_Stanislawek_Animacja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 1;
            if (pictureBox1.Top == 0)
            {
                timer1.Stop();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox1.Top = 470;
            timer2.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            timer2.Start();
            timer1.Stop();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if (pictureBox1.Top == 470)
            {
                timer2.Stop();
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);

            }
        }
    }
}
