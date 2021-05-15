using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5Ex10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Red) button1.BackColor = Color.Yellow;
            else button1.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.Red) button2.BackColor = Color.Yellow;
            else button2.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Red) button3.BackColor = Color.Yellow;
            else button3.BackColor = Color.Red;
        }
        private void button4_MouseEnter(object sender, System.EventArgs e)
        { button4.BackColor = Color.Aqua; button4.Text = "Butoane apasate"; }
        private void button4_MouseLeave(object sender, System.EventArgs e)
        {
            textBox1.Visible = false; button4.Text = "Starea butoanelor";
            button4.BackColor = Color.Orange;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true; textBox1.Text = "";
            if (
                button1.BackColor == Color.Yellow) textBox1.Text = textBox1.Text + 'A';
            if (
                button2.BackColor == Color.Yellow) textBox1.Text = textBox1.Text + 'B';
            if (
                button3.BackColor == Color.Yellow) textBox1.Text = textBox1.Text + 'C';
        }
    }
}
