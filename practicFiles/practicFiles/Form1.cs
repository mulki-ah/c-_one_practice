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

namespace practicFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncreatenewFile_Click(object sender, EventArgs e)
        {
            StreamWriter outputfile;
            outputfile = File.CreateText("Home.doc");

            outputfile.WriteLine("Hello !");
            outputfile.WriteLine("welcome  ca242");
            outputfile.WriteLine(" specially hall 9 ");
            outputfile.WriteLine(" the  best classs of semester 5  ");

            outputfile.Close();

            MessageBox.Show("File created.");
        }

        private void btnReadLines_Click(object sender, EventArgs e)
        {
            lstFileContents.Items.Clear();

            StreamReader inputfile = File.OpenText("Home.doc");

            string line;
            bool endStream = false;

            while (endStream == false)
            {
                line = inputfile.ReadLine();

                endStream = (line == null);

                while (line != null)
                {
                    lstFileContents.Items.Add(line);
                    line = null;
                }
            }

            inputfile.Close();
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            File.Delete("Home.doc");
            lstFileContents.Items.Clear();
            MessageBox.Show("File deleted.");
        }

        private void btnClearContents_Click(object sender, EventArgs e)
        {
            File.WriteAllText("Home.doc", string.Empty);
            lstFileContents.Items.Clear();
            MessageBox.Show("File contents cleared.");
        }
    }
}