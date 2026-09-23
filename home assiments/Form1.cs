using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home_assiments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
        }

        private void btnshowdate_Click(object sender, EventArgs e)
        {
            // create varibles///
            String dayoftheweak, nameofthemounth ;
     
            int numericoftheday;
            int year;


            ///intialize values to varibles //
            dayoftheweak = txtdayoftheweak.Text;
            nameofthemounth = txtofthemounth.Text;
            numericoftheday = int.Parse(txtnumdayoftheday.Text);
          year = int.Parse(txtyear.Text);


            ///stage processs  concatination full date  //

            lbloutput.Text = dayoftheweak + " ," + nameofthemounth + " ," + numericoftheday
                + " ," + year;
        
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clear
            txtdayoftheweak.Clear();
            txtofthemounth .Clear();
            txtnumdayoftheday.Clear();
            txtyear.Clear();
          


            lbloutput.Text = " ";
            // lbloutput.text = String.Empty;//
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //exit//
            this.Close();
        }

      
    }
}
