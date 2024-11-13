using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string formattedDateTime = now.ToString("dddd, MMMM dd, yyyy\nHH:mm:ss tt");
            label3.Text = formattedDateTime;
        }

        private System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
