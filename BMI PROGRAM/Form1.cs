
using System;
using System.Windows.Forms;

namespace BMI_PROGRAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateBMI_Click(object sender, EventArgs e)
        {
            try
            {
                double weight = double.Parse(txtweight.Text);
                double height = double.Parse(txtheight.Text);

                double BMI;

                if (weight > 0 && height > 0)
                {
                    BMI = (weight * 703) / (height * height);

                    listOuput.Items.Add("Your BMI is: " + BMI.ToString("F2"));

                    if (BMI < 18.5)
                    {
                        MessageBox.Show("You are Underweight.");
                    }
                    else if (BMI >= 18.5 && BMI < 25)
                    {
                        MessageBox.Show("You have Normal Weight.");
                    }
                    else if (BMI >= 25 && BMI < 30)
                    {
                        MessageBox.Show("You are Overweight.");
                    }
                    else
                    {
                        MessageBox.Show("You are Obese.");
                    }
                }
                else
                {
                    MessageBox.Show("Weight and height must be greater than zero.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Weight and height must be numeric values.");
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred. Please try again.");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtheight.Clear();
            txtweight.Clear();
            listOuput.Items.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listOuput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

