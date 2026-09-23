using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assiment1
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            // create varibles///
            string name, department;
            int studentid;
            int semsiter;

            ///intialize values to varibles //
            name = txtname.Text;
            studentid = int.Parse(txtstudentid.Text);
            department = txtdepartment.Text;
            semsiter =int.Parse( txtsemister.Text);

            //
            ///stage processs  concatination //
            lbloutput.Text = name + ", " + studentid + ", "
                           + department + ", " + semsiter;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemister.Clear();

            lbloutput.Text = "";


        }

        private void form_Load(object sender, EventArgs e)
        {

        }
    }
}
