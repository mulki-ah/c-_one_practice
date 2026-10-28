
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_room_boking_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // CREATE VARIABLES
            string guestName;
            string roomType = "";

            int age = 0;
            int nights = 0;
            int guests = 0;
            int capacity = 0;

            double roomRate = 0;
            double roomCost = 0;
            double breakfastCost = 0;
            double subtotal = 0;
            double discountRate = 0;
            double discount = 0;
            double seniorDiscount = 0;
            double serviceCharge = 0;
            double total = 0;

            bool bookingApproved = true;
            bool breakfastSelected;
            bool ageValid;
            bool nightsValid;
            bool guestsValid;

            // ASSIGN VALUES
            guestName = txtName.Text.Trim();

            ageValid = int.TryParse(txtAge.Text, out age);
            nightsValid = int.TryParse(txtNight.Text, out nights);
            guestsValid = int.TryParse(txtGuests.Text, out guests);

            breakfastSelected = cbbreakfast.Checked;

            // VALIDATE GUEST NAME
            if (guestName == "")
            {
                MessageBox.Show("Enter Guest Name.");
                bookingApproved = false;
            }

            // VALIDATE AGE
            if (bookingApproved && !ageValid)
            {
                MessageBox.Show("Enter a valid age.");
                bookingApproved = false;
            }

            // VALIDATE NUMBER OF NIGHTS
            if (bookingApproved && !nightsValid)
            {
                MessageBox.Show("Enter a valid number of nights.");
                bookingApproved = false;
            }

            // VALIDATE NUMBER OF GUESTS
            if (bookingApproved && !guestsValid)
            {
                MessageBox.Show("Enter a valid number of guests.");
                bookingApproved = false;
            }

            // CHECK AGE RANGE
            if (bookingApproved && (age < 18 || age > 90))
            {
                MessageBox.Show("Age must be between 18 and 90.");
                bookingApproved = false;
            }

            // CHECK NIGHTS RANGE
            if (bookingApproved && (nights < 1 || nights > 30))
            {
                MessageBox.Show("Nights must be between 1 and 30.");
                bookingApproved = false;
            }

            // CHECK GUESTS RANGE
            if (bookingApproved && (guests < 1 || guests > 6))
            {
                MessageBox.Show("Guests must be between 1 and 6.");
                bookingApproved = false;
            }

            // SELECT ROOM TYPE
            if (bookingApproved)
            {
                if (rdstandard.Checked)
                {
                    roomType = "Standard";
                }
                else if (rdNormal.Checked)
                {
                    roomType = "Normal";
                }
                else if (rdhight.Checked)
                {
                    roomType = "High";
                }
                else
                {
                    MessageBox.Show("Select a Room Type.");
                    bookingApproved = false;
                }
            }

            // REJECT INVALID BOOKING
            if (!bookingApproved)
            {
                txtBookingDetails.Text = "BOOKING REJECTED";
                return;
            }

            // ASSIGN ROOM RATE AND CAPACITY
            switch (roomType)
            {
                case "Standard":
                    roomRate = 50;
                    capacity = 2;
                    break;

                case "Normal":
                    roomRate = 80;
                    capacity = 4;
                    break;

                case "High":
                    roomRate = 130;
                    capacity = 6;
                    break;

                default:
                    MessageBox.Show("Select a valid Room Type.");
                    txtBookingDetails.Text = "BOOKING REJECTED";
                    return;
            }

            // CHECK ROOM CAPACITY
            if (guests > capacity)
            {
                MessageBox.Show("Too many guests for this room.");
                txtBookingDetails.Text = "BOOKING REJECTED";
                return;
            }

            // CALCULATE ROOM COST
            roomCost = roomRate * nights;

            // CALCULATE BREAKFAST COST
            if (breakfastSelected)
            {
                breakfastCost = 10 * guests * nights;
            }
            else
            {
                breakfastCost = 0;
            }

            // CALCULATE SUBTOTAL
            subtotal = roomCost + breakfastCost;

            // DETERMINE DISCOUNT RATE
            if (nights >= 10)
            {
                discountRate = 0.12;
            }
            else if (nights >= 5)
            {
                discountRate = 0.05;
            }
            else
            {
                discountRate = 0;
            }

            // CALCULATE NIGHT DISCOUNT
            discount = subtotal * discountRate;

            // CALCULATE SENIOR DISCOUNT
            if (age >= 60)
            {
                seniorDiscount = (subtotal - discount) * 0.05;
            }
            else
            {
                seniorDiscount = 0;
            }

            // CALCULATE SERVICE CHARGE
            if (guests > 4)
            {
                serviceCharge =
                    (subtotal - discount - seniorDiscount) * 0.05;
            }
            else
            {
                serviceCharge = 0;
            }

            // CALCULATE FINAL TOTAL
            total = subtotal - discount
                    - seniorDiscount + serviceCharge;

            // DISPLAY BOOKING DETAILS
            txtBookingDetails.Text =
                "BOOKING APPROVED\n\n" +  
                "Guest Name:  " + guestName + "\n" +
                "Age: " + age + "\n" +
                "Room Type:  " + roomType + "\n" +
                "Room Rate: $" + roomRate.ToString("F2") + "\n" +
                "Nights: " + nights + "\n" +
                "Guests: " + guests + "\n" +
                "Breakfast: " +
                (breakfastSelected ? "Yes" : "No") + "\n\n" +

                "Room Cost: $" + roomCost.ToString("F2") + "\n" +
                "Breakfast Cost: $" + breakfastCost.ToString("F2") + "\n" +
                "Subtotal: $" + subtotal.ToString("F2") + "\n" +
                "Night Discount (" +
                (discountRate * 100).ToString("F0") +
                "%): $" + discount.ToString("F2") + "\n" +
                "Senior Discount: $" +
                seniorDiscount.ToString("F2") + "\n" +
                "Service Charge: $" +
                serviceCharge.ToString("F2") + "\n" +
                "------------------------------\n" +
                "TOTAL: $" + total.ToString("F2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // CLEAR ALL FIELDS
            txtName.Clear();
            txtAge.Clear();
            txtNight.Clear();
            txtGuests.Clear();
            txtBookingDetails.Clear();

            rdstandard.Checked = false;
            rdNormal.Checked = false;
            rdhight.Checked = false;
            cbbreakfast.Checked = false;

            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // CLOSE APPLICATION
            this.Close();
        }
    }
}

