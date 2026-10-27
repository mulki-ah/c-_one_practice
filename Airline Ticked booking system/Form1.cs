using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticked_booking_system
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

                string BookingApproved;

                string passengerName = txtpassangerName.Text;
                int passengerAge;
                int NumberOftickets;
                double BaggageWeight;

                string travelclass = "";
                string insurenceOption= "";

             

                if (int.TryParse(txtpassangerAge.Text, out passengerAge) &&
                   int.TryParse(txtnumberOFticket.Text, out NumberOftickets) &&
                   double.TryParse(txtBaggageWeight.Text, out BaggageWeight))
                {

                    passengerAge = int.Parse(txtpassangerAge.Text);
                    NumberOftickets = int.Parse(txtnumberOFticket.Text);
                    BaggageWeight= double.Parse(txtBaggageWeight.Text);

                    double ticketPrice = 0;
                    if (cbfirstclass.Checked)
                    {
                        ticketPrice = 100;
                        travelclass = "first class";

                    }
                    else if (cbNormalclass.Checked)
                    {
                        ticketPrice = 200;
                        travelclass = "normal class";
                    }
                    else if (cbNormalclass.Checked)
                    {
                        ticketPrice = 300;
                        travelclass = "business class";
                    }

                    double basicticketCost = ticketPrice * NumberOftickets;

                    double discountTicket=0;
                    if(NumberOftickets>=1 && NumberOftickets <= 2)
                    {
                        discountTicket = 0;
                    }
                    else if(NumberOftickets>=3  && NumberOftickets <= 4)
                    {
                        discountTicket = basicticketCost * 0.05;
                    }
                    else if (NumberOftickets == 5)
                    {
                        discountTicket = basicticketCost * 0.10;
                    }

                    double childDiscount=0;
                    if (passengerAge < 12)
                    {
                        childDiscount = basicticketCost * 0.20;
                    }

                    double seniordiscount =0;
                    if (passengerAge >= 60)
                    {
                        seniordiscount = basicticketCost * 0.10;
                    }


                    double insuranceCost = 0;
                    if (insurance.Checked)
                    {
                        insuranceCost = 25 * NumberOftickets;

                        insurenceOption = "yes";
                    }
                    else
                    {
                        insurenceOption = "no";
                    }

                    double baggagecost = 0;
                    if (BaggageWeight < 20)
                    {
                        baggagecost = 0;

                        
                    
                    }
                    else
                    {
                        baggagecost = BaggageWeight * 10;

                    }

                    double finalticket = (basicticketCost + basicticketCost + insuranceCost)
                        -discountTicket-childDiscount-seniordiscount;
                       
                   

                   if (passengerAge >= 1 && passengerAge <= 100)
                    {

                        if (NumberOftickets >= 1 && NumberOftickets <= 5)
                        {

                            if (BaggageWeight >= 0 && BaggageWeight <= 50)
                            {

                                if (passengerAge < 12 && cbfirstclass.Checked)
                                {
                                    BookingApproved = "rejected";
                                    MessageBox.Show("Your age  is lessthan 12 you can not booked first class");

                                    DISPLAY.Items.Add("name: " + passengerName);
                                    DISPLAY.Items.Add("age: " + passengerAge);
                                    DISPLAY.Items.Add("number of ticket: " + NumberOftickets);
                                    DISPLAY.Items.Add("baggage weight: " + BaggageWeight);
                                    DISPLAY.Items.Add("travel class: " + travelclass);
                                    DISPLAY.Items.Add("insurance option: " + insurenceOption);
                                    DISPLAY.Items.Add("booking status: " + BookingApproved);






                                }
                                else
                                {
                                    BookingApproved = "booking approved";
                                    DISPLAY.Items.Add("name: " + passengerName);
                                    DISPLAY.Items.Add("age: " + passengerAge);
                                    DISPLAY.Items.Add("number of ticket: " + NumberOftickets);
                                    DISPLAY.Items.Add("baggage weight: " + BaggageWeight);
                                    DISPLAY.Items.Add("travel class: " + travelclass);
                                    DISPLAY.Items.Add("insurance option: " + insurenceOption);

                                    DISPLAY.Items.Add("ticketper price: " + ticketPrice);
                                    DISPLAY.Items.Add("basic ticket cos: " + basicticketCost);
                                    DISPLAY.Items.Add("baggae cost: " + baggagecost);
                                    DISPLAY.Items.Add("insurance cost: " + insuranceCost);

                                    DISPLAY.Items.Add("discount ticket: " + discountTicket);
                                    DISPLAY.Items.Add(" child discount ticket: " + childDiscount);
                                    DISPLAY.Items.Add(" senior discount ticket: " +seniordiscount);
                                    DISPLAY.Items.Add(" final ticket price : " +finalticket);



                                    DISPLAY.Items.Add("booking status: " + BookingApproved);
                                }


                            }
                            else
                            {

                                MessageBox.Show("baggage must between 0 and 50");
                            }






                        }
                        else
                        {
                            MessageBox.Show("number of ticket must be between 1 nad 5");
                        }


                    }
                    else
                    {
                        MessageBox.Show(" age must be between 1 and 100");
                    }

                   

                  

                    
                }
                else
                {
                    MessageBox.Show("only accept numeric value");
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            DISPLAY.Items.Clear();
        }
    }
}
