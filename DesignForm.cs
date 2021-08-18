using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QGamePart1
{
    public partial class DesignForm : Form
    {
        int ROWS = 0;
        int COLUMNS = 0;
        string imgSource = null;
        Block clickedItem = new Block();
        //OpenFileDialog openFile = new OpenFileDialog();
        public DesignForm()
        {
            InitializeComponent();
            btnWall.Tag = new Wall();
            btnNone.Tag = new None();
            btnRedDoor.Tag = new RedDoor();
            btnRedBox.Tag = new RedBox();
            btnGreenDoor.Tag = new GreenDoor();
            btnGreenBox.Tag = new GreenBox();
        }

        /// <summary>
        /// This method checks whether the input of row and column entered by a user is a number and then generates a grid of picture boxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                // To check for the negative integer
                if (Convert.ToInt32(txtRows.Text) <= 0 || Convert.ToInt32(txtColumns.Text) <= 0) 
                {
                    MessageBox.Show("Your row and column input must not be negative integers.");
                }
                else
                {
                    ROWS = Convert.ToInt32(txtRows.Text);
                    COLUMNS = Convert.ToInt32(txtColumns.Text);
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Your row and column input must be integers." + ex);
            }

            //Generating grid for game board
            ROWS = int.Parse(txtRows.Text);
            COLUMNS = int.Parse(txtColumns.Text);
            PictureBox[,] picBox = new PictureBox[ROWS, COLUMNS];
            for (int rows = 0; rows < ROWS; rows++)
            {
                for (int columns = 0; columns < COLUMNS; columns++)
                {
                    picBox[rows, columns] = new PictureBox();
                    picBox[rows, columns].Location = new Point(rows * 40, columns * 40);
                    picBox[rows, columns].Width = 40;
                    picBox[rows, columns].Height = 40;
                    picBox[rows, columns].Visible = true;
                    picBox[rows, columns].BorderStyle = BorderStyle.Fixed3D;
                    picBox[rows, columns].Click += Grid_Click;
                    picBox[rows, columns].BackgroundImageLayout = ImageLayout.Stretch;
                    gridPanel.Controls.Add(picBox[rows, columns]);
                    
                }
            }
        }

        /// <summary>
        /// This method tags the image of the tools selected from the tool box to the grid boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grid_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            pictureBox.Image = clickedItem.Image;
            pictureBox.Tag = clickedItem.ItemType;
        }


        /// <summary>
        /// This method selects the tool selected from the tool box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tool_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            imgSource = button.Name;
            clickedItem = (Block)button.Tag;
        }


        /// <summary>
        /// This method closes the DesignForm and opens the QGameControlPanel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeMenu_Click(object sender, EventArgs e)
        {
            QGameControlPanel qGameControlPanel = new QGameControlPanel();
            this.Close();
            qGameControlPanel.Show();
        }


        /// <summary>
        /// This method saves the game to a file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveMenu_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 0;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                    string savedFileName = saveFileDialog1.FileName;
                    using (StreamWriter writer = new StreamWriter(savedFileName))
                    {
                        writer.WriteLine($"Rows = {Convert.ToString(ROWS)},  Columns =   {Convert.ToString(COLUMNS)}");

                        foreach (PictureBox pictureBox in gridPanel.Controls)
                        {
                            writer.WriteLine(pictureBox.Name);
                        }
                    } 
            }

        }
    }
}
