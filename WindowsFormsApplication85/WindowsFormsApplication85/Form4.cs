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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            slide4panel1.Top = button4.Top;
            slide4panel1.Height = button4.Height;
            userControl41.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

           slide4panel1.Top = button4.Top;
            slide4panel1.Height = button4.Height;
            userControl41.BringToFront();
        }

        private void userControl41_Load(object sender, EventArgs e)
        {
          
        }
    }
}
