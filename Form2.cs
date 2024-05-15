using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dataGridView.ReadOnly = true;
            DisplayData();
        }

        private void DisplayData()
        {
            // reading from file (use a loop until it reaches a null value)
            string fileName = "parts.txt"; // opening parts.txt

            // used to read file
            StreamReader sr = new StreamReader(fileName);

            // loop until we run out of data
            string line = null;

            while ((line = sr.ReadLine()) != null)
            {
                // clear any extra white space
                line = line.Trim();

                // split values at the comma
                string[] fields = line.Split(',');

                // add the array of information into the data table
                // there are 7 column headers, and 7 elements in the array once each line in the txt file is split at the comma
                dataGridView.Rows.Add(fields);
            }

            sr.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // close form 2, return to form 1
            this.Close();
        }
    }
}
