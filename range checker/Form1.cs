using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logical_operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncheck_Click(object sender, EventArgs e)
        {

            try
            {
                int number;


                if (int.TryParse(txtnumber.Text, out number))
                {

                    if (number >= 1 && number <= 10)
                    {

                        txtrangedecision.Text = "waa saxday";

                    }
                    else
                    {

                        txtrangedecision.Text = " waa qaladay";

                    }


                }
                else
                {
                    MessageBox.Show("only accept numeric value");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        
           
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            txtnumber.Clear();
            txtrangedecision.Text = " ";
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
