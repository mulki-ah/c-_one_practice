using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Room_booking_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // create variables //

                String guestName, Room;

                int numberOfnigts;
                double price;

                double serviceTax;
                double DicouAmount;
                double totalAmount;

                ///assign varibles //
                guestName = txtGuestName.Text;
                Room = txtRoomType.Text;


                numberOfnigts = int.Parse(txtNight.Text);
                price = double.Parse(txtPriceNight.Text);


                // calculate booking 

                double subTotal= numberOfnigts * price;
                  serviceTax = subTotal * 0.10;
                DicouAmount = subTotal * 0.05;
                totalAmount = ( subTotal * 2 ) + serviceTax - DicouAmount;


           

                //// DISPLAY//

                lblServiceTax.Text = serviceTax.ToString("C2");
                lblDiscount.Text =  DicouAmount.ToString("C2");
                lblTotalAmount.Text = totalAmount.ToString("c2");



            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }


        }

       
    }
}
