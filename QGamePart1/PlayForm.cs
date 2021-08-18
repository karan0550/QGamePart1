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

namespace KSharmaAssignment2
{
    public partial class PlayForm : Form
    {
        public PlayForm()
        {
            InitializeComponent();
        }
        
        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "QGame files (*.qgame)|*.qgame";
            openFileDialog.FilterIndex = 0;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string openFileName = openFileDialog.FileName;
                var lines = File.ReadAllLines(openFileName);
                int totalRows = Convert.ToInt32(lines[0]);
                int totalColumns = Convert.ToInt32(lines[1]);
                PictureBox[,] picBox = new PictureBox[totalRows, totalColumns];
                Block blockItem = new Block();
                for (int i = 2; i < lines.Length; i += 3)
                {
                    int rowIndex = Convert.ToInt32(lines[i]);
                    int columnIndex = Convert.ToInt32(lines[i+1]);
                    int enumType = Convert.ToInt32(lines[i+2]);
                    switch (enumType)
                    {
                        case 0:
                            blockItem = new None();
                            break;
                        case 1:
                            blockItem = new Wall();
                            break;
                        case 2:
                            blockItem = new RedDoor();
                            break;
                        case 3:
                            blockItem = new GreenDoor();
                            break;
                        case 4:
                            blockItem = new RedBox();
                            break;
                        case 5:
                            blockItem = new GreenBox();
                            break;

                        default:
                            blockItem = new None();
                            break;
                    }
                    picBox[rowIndex, columnIndex] = new PictureBox();
                    picBox[rowIndex, columnIndex].Location = new Point(rowIndex * 40, columnIndex * 40);
                    picBox[rowIndex, columnIndex].Width = 40;
                    picBox[rowIndex, columnIndex].Height = 40;
                    picBox[rowIndex, columnIndex].Visible = true;
                    picBox[rowIndex, columnIndex].BorderStyle = BorderStyle.Fixed3D;
                    //picBox[rowIndex, columnIndex].Click += Grid_Click;
                    picBox[rowIndex, columnIndex].BackgroundImageLayout = ImageLayout.Stretch;
                    picBox[rowIndex, columnIndex].Image = blockItem.Image;
                    picBox[rowIndex, columnIndex].Tag = blockItem.ItemType;
                    playPanel.Controls.Add(picBox[rowIndex, columnIndex]);
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QGameControlPanel qGameControlPanel = new QGameControlPanel();
            this.Close();
            qGameControlPanel.Show();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
