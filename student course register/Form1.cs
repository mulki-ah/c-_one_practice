using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assigmnt_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        // ADD COURSE BUTTON (button4)

        private void btnaddcurse_Click(object sender, EventArgs e)
        {
            try
            {
                string courseName = txtcourse.Text.Trim();
                decimal coursePrice = 0;
                bool valid = true;
                bool duplicate = false;

                // Validate course name
                if (string.IsNullOrWhiteSpace(courseName))
                {
                    MessageBox.Show("Please enter a course name.");
                    valid = false;
                }
                else
                {
                    // Validate course price
                    if (!decimal.TryParse(txtprice.Text, out coursePrice))
                    {
                        MessageBox.Show("Please enter a valid course price.");
                        valid = false;
                    }
                    else if (coursePrice <= 0)
                    {
                        MessageBox.Show("Course price must be greater than zero.");
                        valid = false;
                    }
                    else
                    {
                        // Maximum 5 courses allowed
                        if (listboxcourse.Items.Count >= 5)
                        {
                            MessageBox.Show("You can register a maximum of 5 courses.");
                            valid = false;
                        }
                        else
                        {
                            // Prevent duplicate course names using while loop
                            int i = 0;
                            while (i < listboxcourse.Items.Count)
                            {
                                string existingCourse = listboxcourse.Items[i].ToString();
                                int separator = existingCourse.LastIndexOf(" - $");
                                if (separator >= 0)
                                {
                                    string existingName = existingCourse.Substring(0, separator);
                                    if (existingName.Equals(courseName, StringComparison.OrdinalIgnoreCase))
                                    {
                                        duplicate = true;
                                        break;
                                    }
                                }
                                i++;
                            }

                            if (duplicate)
                            {
                                MessageBox.Show("This course is already registered.");
                                valid = false;
                            }
                        }
                    }
                }

                // Add course when validation succeeds
                if (valid == true)
                {
                    listboxcourse.Items.Add(courseName + " - $" + coursePrice.ToString("N2"));

                    
                    txtnumofcourse.Text = listboxcourse.Items.Count.ToString();

                    txtcourse.Clear();
                    txtprice.Clear();
                    MessageBox.Show("Course added successfully.");
                    txtcourse.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An unexpected error occurred while adding the course.");
            }
        }






        // REMOVE

        private void btnremove_Click(object sender, EventArgs e)
        {
            try
            {
                // Check whether a course is selected
                if (listboxcourse.SelectedIndex != -1)
                {
                    listboxcourse.Items.RemoveAt(listboxcourse.SelectedIndex);

               
                    txtnumofcourse.Text = listboxcourse.Items.Count.ToString();

                    MessageBox.Show("Course removed successfully.\nRegistered Courses: " + listboxcourse.Items.Count);
                }
                else
                {
                    MessageBox.Show("Please select a course to remove.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An unexpected error occurred while removing the course.");
            }
        }


        // CALCULATE
        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string sname = txtname.Text.Trim();
                string Sid = txtid.Text.Trim();

                int Sage = 0;
                int Coursenum = listboxcourse.Items.Count;

                decimal total = 0;
                decimal coursePrice = 0;
                decimal discount = 0;

                decimal finalregistration = 0;
                decimal finalFee = 0;

                bool valid = true;

                // Validate 
                if (string.IsNullOrWhiteSpace(sname))
                {
                    MessageBox.Show("Please enter your name.");
                    valid = false;
                }
                else
                {
                 
                    if (string.IsNullOrWhiteSpace(Sid))
                    {
                        MessageBox.Show("Please enter your Student ID.");
                        valid = false;
                    }
                    else
                    {
                     
                        if (!int.TryParse(txtage.Text, out Sage))
                        {
                            MessageBox.Show("Please enter a valid age.");
                            valid = false;
                        }
                        else if (Sage < 16 || Sage > 60)
                        {
                            MessageBox.Show("Age must be between 16 and 60.");
                            valid = false;
                        }
                        else
                        {
                            
                            if (Coursenum == 0)
                            {
                                MessageBox.Show("Please add at least one course.");
                                valid = false;
                            }
                        }
                    }
                }

                
                if (valid == true)
                {
                    int i = 0;

                   
                    while (i < listboxcourse.Items.Count)
                    {
                        string courseDetails = listboxcourse.Items[i].ToString();
                        int separator = courseDetails.LastIndexOf(" - $");

                        if (separator >= 0 && decimal.TryParse(courseDetails.Substring(separator + 4), out coursePrice))
                        {
                            total = total + coursePrice;
                        }
                        else
                        {
                            MessageBox.Show("Course price could not be read. Please add the course again.");
                            valid = false;
                            break;
                        }

                        i++;
                    }

                    if (valid == true)
                    {
                        finalregistration = total;

                      
                        if (Coursenum == 1)
                        {
                            discount = 0;
                        }
                        else if (Coursenum == 2)
                        {
                            discount = finalregistration * 0.05m;
                        }
                        else if (Coursenum == 3 || Coursenum == 4)
                        {
                            discount = finalregistration * 0.10m;
                        }
                        else if (Coursenum == 5)
                        {
                            discount = finalregistration * 0.15m;
                        }

                      
                        finalFee = finalregistration - discount;




                        // Display the results in listboxdisblay
                        listboxdisblay.Items.Clear();
                        listboxdisblay.Items.Add("===== Student Registration =====");
                        listboxdisblay.Items.Add("Name:   " + sname);
                        listboxdisblay.Items.Add("ID:    " + Sid);
                        listboxdisblay.Items.Add("Age:   " + Sage);
                        listboxdisblay.Items.Add("Number of Courses:    " + Coursenum);
                        listboxdisblay.Items.Add("Basic Registration Fee: $" + finalregistration.ToString("N2"));
                        listboxdisblay.Items.Add("Course Discount: $" + discount.ToString("N2"));

                        listboxdisblay.Items.Add("Final Registration Fee: $" + finalFee.ToString("N2"));
                        listboxdisblay.Items.Add("Registration Status: Approved");
                    }
                }
                else
                {
                    listboxdisblay.Items.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An unexpected error occurred while calculating the fee.");
            }
        }

        // CLEAR 
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtage.Clear();
            txtid.Clear();
            txtcourse.Clear();
            txtprice.Clear();
            txtnumofcourse.Clear();

            listboxcourse.Items.Clear();
            listboxdisblay.Items.Clear();
            txtname.Focus();
        }

        // EXIT 
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

    }


}
    
