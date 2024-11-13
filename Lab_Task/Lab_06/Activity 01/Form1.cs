namespace Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string input = textBox1.Text;
            if (!string.IsNullOrEmpty(input))
            {
                label2.Visible = true;
                label2.ForeColor = Color.Green;
                textBox1.Clear();
                label2.Text = "Welcome " + input;
            }
            else
            {
                label2.Visible = true;
                label2.ForeColor = Color.Red;
                label2.Text = "Enter Your Name";
                textBox1.Focus();
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            comboBox1.Items.Add("Year");
            comboBox1.Items.Add("Month");
            comboBox1.Items.Add("Week");
            comboBox2.Visible = false;
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                comboBox2.Visible = true;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("2013");
                comboBox2.Items.Add("2014");
                comboBox2.Items.Add("2015");
                comboBox2.Items.Add("2016");
                comboBox2.Items.Add("2017");
                comboBox2.Items.Add("2018");
                comboBox2.Items.Add("2019");
                comboBox2.Items.Add("2020");
                comboBox2.Items.Add("2021");
                comboBox2.Items.Add("2022");
                comboBox2.Items.Add("2023");
                comboBox2.Items.Add("2024");
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                comboBox2.Visible = true;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("January");
                comboBox2.Items.Add("February");
                comboBox2.Items.Add("March");
                comboBox2.Items.Add("April");
                comboBox2.Items.Add("May");
                comboBox2.Items.Add("June");
                comboBox2.Items.Add("July");
                comboBox2.Items.Add("August");
                comboBox2.Items.Add("September");
                comboBox2.Items.Add("October");
                comboBox2.Items.Add("November");
                comboBox2.Items.Add("December");
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                comboBox2.Visible = true;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Mopnday");
                comboBox2.Items.Add("Tuesday");
                comboBox2.Items.Add("Wednesday");
                comboBox2.Items.Add("Thursday");
                comboBox2.Items.Add("Friday");
                comboBox2.Items.Add("Saturday");
                comboBox2.Items.Add("Sunday");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}