using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                    }


        private bool check_input()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Enter First Number", "Input Required");
                return false;
            }
            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Enter Second Number", "Input Required");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(check_input())
            {
                int value1 = int.Parse(textBox1.Text);
                int value2 = int.Parse(textBox2.Text);

                label3.Visible = true;
                label4.Visible = true;
                label4.Text = (value1 + value2).ToString();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (check_input())
            {
                int value1 = int.Parse(textBox1.Text);
                int value2 = int.Parse(textBox2.Text);

                label3.Visible = true;
                label4.Visible = true;
                label4.Text = (value1 - value2).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (check_input())
            {
                int value1 = int.Parse(textBox1.Text);
                int value2 = int.Parse(textBox2.Text);

                label3.Visible = true;
                label4.Visible = true;
                label4.Text = (value1 * value2).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (check_input())
            {
                int value1 = int.Parse(textBox1.Text);
                int value2 = int.Parse(textBox2.Text);
                if(value2 == 0)
                {
                    MessageBox.Show("Enter Correct Value of Second ");
                    textBox2.Clear();
                    textBox2.Focus();
                }
                else
                {
                    label3.Visible = true;
                    label4.Visible = true;
                    label4.Text = (value1 / value2).ToString();
                }
                
            }
        }
    }
}
