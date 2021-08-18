using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpingButton5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Left += 15;
            button2.Left += 10;
            button3.Left += 25;
            button4.Left += 35;
            button5.Left += 30;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
