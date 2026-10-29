using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tip_tax_total_assiment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcualte_Click(object sender, EventArgs e)
        {

            try
            {

                // Create Variables

                 string lblfood1;
                double food1pricelbl;

                string lblfood2;
                double food2pricelbl;

                double total;
                double percentage;


                // Assign Variables

                lblfood1 = txtfood1.Text;

                food1pricelbl = double.Parse(txtfood1price.Text);

                lblfood2 = txtfood2.Text;

                food2pricelbl = double.Parse(txtfood2price.Text);


                // Process Percentage

                total = food1pricelbl + food2pricelbl;

                percentage = total * 10 / 100;


                // Display Output

                // Display Output



                salestxt.Text =

                    "Food 1: " + lblfood1 +

                    "\r\nFood 1 Price: " + food1pricelbl +

                    "\r\nFood 2: " + lblfood2 +

                    "\r\nFood 2 Price: " + food2pricelbl +

                    "\r\nTotal: " + total +

                    "\r\nPercentage: " + percentage;

                amounttxt.Text = total.ToString();



            }
            catch
            {

            }
              
        }

        private void txtfood1price_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
