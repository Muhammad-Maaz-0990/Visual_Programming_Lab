using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_02
{
    public partial class Form1 : Form
    {

        private double value1=0;
        private double value2=0;
        private string operator_;
        bool check = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                value1 = double.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                operator_ = "+";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                value1 = double.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                operator_ = "-";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                value1 = double.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                operator_ = "*";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                value1 = double.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                operator_ = "/";
            }
        }

        private bool check_value()
        {
            if(value1 == 0  &&  value2==0 )
            {
                return false;
            }   
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(check)
            {
                textBox1.Clear();
                check = false;
            }
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (check)
            {
                textBox1.Clear();
                check = false;
            }
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (check)
            {
                textBox1.Clear();
                check = false;
            }
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (check)
            {
                textBox1.Clear();
                check = false;
            }
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (check)
            {
                textBox1.Clear();
                check = false;
            }
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (check)
            {
                textBox1.Clear();
                check = false;
            }
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (check)
            {
                textBox1.Clear();
                check = false;
            }
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (check)
            {
                textBox1.Clear();
                check = false;
            }
            textBox1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (check)
            {
                textBox1.Clear();
                check = false;
            }
            textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (check)
            {
                textBox1.Clear();
                check = false;
            }
            textBox1.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (check)
            {
                textBox1.Clear();
                check = false;
            }
            textBox1.Text += ".";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            value2 = int.Parse(textBox1.Text);
            if(operator_ == "+")
            {
                textBox1.Text = (value1 + value2).ToString();
            }
            if (operator_ == "-")
            {
                textBox1.Text = (value1 - value2).ToString();
            }
            if (operator_ == "*")
            {
                textBox1.Text = (value1 * value2).ToString();
            }
            if (operator_ == "/")
            {
                textBox1.Text = (value1 / value2).ToString();
            }
            value1 = 0;
            value2 = 0;
            operator_ = "";
            check = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
