using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonSvoystva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            pictureBox1.BackColor = Color.Red;
            textBox1.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Yellow;
            textBox1.Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Green;
            textBox1.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            textBox1.Visible = false;
            pictureBox1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            textBox1.Visible = true;
            pictureBox1.Visible = true;
        }
    }
}
