using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int value = string.IsNullOrEmpty(richTextBox1.Text)?0:richTextBox1.Text.Length;
            if(value > 159)
            {
                richTextBox1.Text = richTextBox1.Text.Substring(0,159);
                MessageBox.Show("Limits of Text Box is Complete");
            }
            else
            {
                label2.Text = (159 - value).ToString();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
