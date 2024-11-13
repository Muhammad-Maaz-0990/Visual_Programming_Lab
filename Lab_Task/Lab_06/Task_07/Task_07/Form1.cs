using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_07
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

        private System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();

        private void Timer1_Tick(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            label1.Text = date;
            string formattedDateTime = DateTime.Now.ToString("HH:mm:ss tt");
            label2.Text = formattedDateTime;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
