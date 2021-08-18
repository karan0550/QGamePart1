using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpingButton1
{
    public partial class Form1 : Form
    {

        private Button selectedButton;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.Left += 20;
            //button2.Left += 20;
            selectedButton = button1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedButton = button2;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            selectedButton.Left -= 20;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            selectedButton.Left += 20;
        }

        
    }
}
