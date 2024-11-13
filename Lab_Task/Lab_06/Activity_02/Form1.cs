namespace Activity_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Small");
            comboBox1.Items.Add("Medium");
            comboBox1.Items.Add("Large");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string size = comboBox1.Text;
            string topping="";

            if (checkBox2.Checked)
                topping += $"{checkBox2.Text}";

            if (checkBox3.Checked)
                topping += $" , {checkBox3.Text} ";

            if (checkBox4.Checked)
                topping += $" , {checkBox4.Text}";

            string crust = "";

            if(radioButton1.Checked)
            {
                crust = radioButton1.Text;
            }

            if (radioButton2.Checked)
            {
                crust = radioButton2.Text;
            }


            label4.Visible=true;

            label4.Text = $"\n                        Order Summary\n\nPizza Size : {size}\nToppings : {topping}\nCrust : {crust}\n\n\n                Your Order is Placed Successfully\n";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0     || comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 2 )
            {
                panel1.Visible = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                panel2.Visible = true;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                panel2.Visible = false;
                button1.Visible = false;

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                panel2.Visible = true;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                panel2.Visible = false;
                button1.Visible = false;
               
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                panel2.Visible = true;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                panel2.Visible = false;
                button1.Visible = false;

            }
        }
    }
}