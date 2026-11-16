using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Employee_attendence_management_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnrecord_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtid.Text;
                string name = txtname.Text;
                string department = txtdepartment.Text;
                string attendence = "";

                if (!(rdpresent.Checked || rdabsent.Checked))
                {
                    MessageBox.Show("Please choose the attendence");
                }

                if (rdpresent.Checked)
                {
                    attendence = "Present";
                }
                else if (rdabsent.Checked)
                {
                    attendence = "Absent";
                }

                StreamWriter writes;
                writes = File.AppendText("mulki.txt");
                writes.WriteLine(id + " " + name + " " + department + " " + attendence);
                writes.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        // button ka view
        private void btnview_Click(object sender, EventArgs e)
        {

            try
            {

                StreamReader reads;
                reads = File.OpenText("mulki.txt");
                string lines;
                lines = reads.ReadLine();
                listBox1.Items.Add(lines);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            try
            {

                if (listBox1.SelectedIndex != -1)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);

                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        }

        private void btncount_Click(object sender, EventArgs e)
        {
            try
            {

                int total_record = listBox1.Items.Count;
                lbltotalrecord.Text = total_record.ToString();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // clear
            txtid.Clear();
            txtname.Clear();
            txtdepartment.Clear();

            rdpresent.Checked = false;
            rdabsent.Checked = false;

            lbltotalrecord.Text = "";

            listBox1.Items.Clear();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // button ka record
            try
            {
                string id = txtid.Text;
                string name = txtname.Text;
                string department = txtdepartment.Text;
                string attendence = "";

                if (!(rdpresent.Checked || rdabsent.Checked))
                {
                    MessageBox.Show("Please choose the attendence");
                }

                if (rdpresent.Checked)
                {
                    attendence = "Present";
                }
                else if (rdabsent.Checked)
                {
                    attendence = "Absent";
                }

                StreamWriter writes;
                writes = File.AppendText("C:\\Users\\hp\\Desktop\\mulki.txt");
                writes.WriteLine(id + " "+ name + " " + department + " " + attendence);
                writes.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

         

            

            // button remove

            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                 
            } else
            {
                MessageBox.Show("list is empty");
            }

            // button ka count
            lbltotalrecord.Text = listBox1.Items.Count.ToString();


        }
    }
}
