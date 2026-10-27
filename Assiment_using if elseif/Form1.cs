using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assiment_using_if_elseif
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

                double score1 = double.Parse(txtscore1.Text);
                double score2 = double.Parse(txtscore2.Text);
                double score3 = double.Parse(txtscore3.Text);

                double sum;
                double Average;
             

                if (score1 < 0 && score2 < 0 && score3 < 0)
                {
                    MessageBox.Show(" score can not be negative ");

                }
                else if (score1 > 100 && score2 > 100 && score3 > 100)
                {
                    MessageBox.Show("can not be greather than 100");

                }

                else {
                    sum= score1 + score2+ score3;
                    Average = sum / 3;
                    lblaverage.Text = Average.ToString();   



                }



                  



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtscore1.Clear();
            txtscore2.Clear();
            txtscore3.Clear();

            lblaverage.Text= string.Empty;

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
