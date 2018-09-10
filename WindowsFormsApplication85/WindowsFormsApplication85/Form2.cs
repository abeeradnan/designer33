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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            slide2panel1.Top = button11.Top;
            slide2panel1.Height = button11.Height;
            userControl21.BringToFront();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
             slide2panel1.Top = button11.Top;
            slide2panel1.Height = button11.Height;
            userControl21.BringToFront();
        }
    }
}
