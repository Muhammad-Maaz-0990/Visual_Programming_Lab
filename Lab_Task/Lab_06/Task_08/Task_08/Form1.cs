using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Task_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsImageFile(string filePath)
        {
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            return imageExtensions.Any(ext => filePath.EndsWith(ext, StringComparison.OrdinalIgnoreCase));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        
            {
                string folderPath = textBox1.Text;

                if (Directory.Exists(folderPath))
                {
                    flowLayoutPanel1.Controls.Clear();
                    label3.Text = "0";

                    foreach (string file in Directory.GetFiles(folderPath))
                    {
                        if (IsImageFile(file))
                        {
                            PictureBox pictureBox = new PictureBox
                            {
                                Image = System.Drawing.Image.FromFile(file),
                                Width = 100,
                                Height = 100,
                                Margin = new Padding(5),
                                BorderStyle = BorderStyle.FixedSingle
                            };

                            flowLayoutPanel1.Controls.Add(pictureBox);
                            label3.Text = $"{flowLayoutPanel1.Controls.Count}";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid folder path");
                }
            }
    }
}
