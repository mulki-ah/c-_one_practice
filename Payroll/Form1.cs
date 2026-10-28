using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check_validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {

            try
            {


                double hoursworked;
                double HourlypayRate;


                double grosspay;


                if (double.TryParse(txtHoursworked.Text, out hoursworked) &&
                    double.TryParse(txthourlypayrate.Text, out HourlypayRate))
                {
                    hoursworked = double.Parse(txtHoursworked.Text);
                    HourlypayRate = double.Parse(txthourlypayrate.Text);



                    if (hoursworked >= 0 && HourlypayRate >= 0)
                    {

                        grosspay = hoursworked * HourlypayRate;

                        lblcrosspay.Text = grosspay.ToString();

                    }

                    else
                    {
                        MessageBox.Show("hoursworkes and hourspayrate  must be greatherthan 0");
                    }




                }
                else
                {
                    MessageBox.Show("hoursworkes and hourlypayrate only accept numeric value ");
                }

                



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);


            }

    }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtHoursworked.Clear();
            txthourlypayrate.Clear();




            lblcrosspay.Text = string.Empty;


        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
