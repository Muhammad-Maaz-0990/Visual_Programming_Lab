using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Enter Number", "Input Required");
            }
            else
            {
                int value = Convert.ToInt32(textBox1.Text);
                if (value > 0)
                {
                    int cel = (value - 32) * 5 / 9;
                    
                    label2.Visible = true;
                    label3.Visible = true;
                    label3.Text = cel.ToString();
                }
                else
                {
                    MessageBox.Show("Enter Correct Number", "Input Incorrect");
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
