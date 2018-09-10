using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication85
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            slide1panel1.Top = button1.Top;
            slide1panel1.Height = button1.Height;
            userControl11.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
          

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button12_Click(object sender, EventArgs e)
        {
          slide1panel1.Top = button1.Top;
            slide1panel1.Height = button1.Height;
            userControl11.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
          Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {  
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
          Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            this.Hide();
            f11.Show();
        }
    }
}
