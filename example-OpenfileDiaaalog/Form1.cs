using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace example_OpenfileDiaaalog
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            // Allow saving to an existing file without confirmation
            saveFileDialo1.OverwritePrompt = false;
        }

        private void openfiledialog_Click(object sender, EventArgs e)
        {
            // reading the file//

            StreamReader Reads;

            //create dialog result
            DialogResult Results;


            //Results variable only store ok or cancle
            Results = openFileDialog2.ShowDialog();


            //checking the user selection
            if (Results == DialogResult.OK)

            {
                //open the file - reading



                //Daynamic reading path file
                Reads = File.OpenText(openFileDialog2.FileName);

                // process 
                string lines;

                while (Reads.EndOfStream == false)
                {
                    lines = Reads.ReadLine();

                    //store list box when reading item the file
                    listBox1.Items.Add(lines);
                }
     
              //close
                Reads.Close();

            }
            else
            {

                MessageBox.Show(" NOT OPEN THE FILE");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //example of creating new file , writting the file
            //import class/


            StreamWriter writes;


            DialogResult results;

            results = saveFileDialo1.ShowDialog();

            if (results == DialogResult.OK)
            {

                //oen the file -creating new file //
                writes = File.AppendText(saveFileDialo1.FileName);

                //process

                writes.WriteLine(" java");
         

                //close//
                writes.Close();

                MessageBox.Show("sucessfull");

            }
            else if (results == DialogResult.Cancel)
            {
                MessageBox.Show("Waa la joojiyay keydinta.");
            }
        }

       

    }
}


    
