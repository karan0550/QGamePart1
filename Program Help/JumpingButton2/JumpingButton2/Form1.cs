using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpingButton2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn;
            TextBox txt;

            if (sender is Button)
            {
                btn = (Button)sender;
                btn.Left += 20;
            }
            else if (sender is TextBox)
            {
                txt = (TextBox)sender;
                txt.Left += 20;
            }
            

            
        }

        
    }
}
