using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JumpingButton3
{
    public partial class Form1 : Form
    {
        private const int LEFT = 20;
        private const int WIDTH = 50;
        private const int HEIGHT = 50;
        private const int TOP = 50;
        private const int VGAP = 30;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if( int.TryParse(txtNumberOfButtons.Text, out int numberOfButtons))
            {
                int x = LEFT;
                int y = TOP;

                for (int i = 0; i < numberOfButtons; i++)
                {
                    Button b = new Button();
                    b.Left = x;
                    b.Top = y;
                    b.Width = WIDTH;
                    b.Height = HEIGHT;
                    b.Text = i.ToString();

                    //adding event handler
                    b.Click += DynamicButton_Click;

                    y += VGAP + HEIGHT;
                    this.Controls.Add(b); // very important

                }
            }
            else
            {
                MessageBox.Show("Enter an intiger value!");
                txtNumberOfButtons.Clear();
                txtNumberOfButtons.Focus();
            }
            
            



        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            Button myButton = (Button)sender;
            myButton.Left += 15;
        }

        
    }
}
