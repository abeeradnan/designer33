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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            slide3panel1.Top = button10.Top;
            slide3panel1.Height = button10.Height;
            userControl31.BringToFront();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
          
        }

        private void button10_Click(object sender, EventArgs e)
        {
            slide3panel1.Top = button10.Top;
            slide3panel1.Height = button10.Height;
            userControl31.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
