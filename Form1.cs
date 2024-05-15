using System.Diagnostics;
using System.IO; // must have this
using System.Runtime.Intrinsics.Arm;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        // initialize text file
        string fileName = "parts.txt";

        public Form1()
        {
            InitializeComponent();
            cmbPart.DropDownStyle = ComboBoxStyle.DropDownList; // make the combo box a drop down list

            // disable all specific part text fields initially
            disableFields(txtSocketType, txtCoreCount, txtClockSpeed, txtMemory, txtSpeed, txtCapacity, txtFormFactor, txtSocketTypeMB, txtTypeCable, txtLength, txtConnectorType, txtTypeOther);

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try // try catch block for general input data validation
            {
                // get general input from the user
                string vendor = txtVendor.Text;
                string price = txtPrice.Text;

                // assign fPrice to a function that makes sure the value is a float. If it isn't, it throws an error. If it is, it returns the value as a float.
                float fPrice = checkFloat(price, "Price");
                string make = txtMake.Text;
                string model = txtModel.Text;
                string comments = txtComments.Text;

                // get input from the user and create an object of the specified class
                if (cmbPart.SelectedItem.ToString() == "RAM") // if the drop down box selection is RAM...
                {
                    createRAM(vendor, fPrice, make, model, comments); // function that creates a ram object and writes it to CSV
                }
                else if (cmbPart.SelectedItem.ToString() == "Motherboard")
                {
                    createMB(vendor, fPrice, make, model, comments); // function that creates a motherboard object and writes to CSV
                }
                else if (cmbPart.SelectedItem.ToString() == "CPU")
                {
                    createCPU(vendor, fPrice, make, model, comments);
                }
                else if (cmbPart.SelectedItem.ToString() == "GPU")
                {
                    createGPU(vendor, fPrice, make, model, comments);
                }
                else if (cmbPart.SelectedItem.ToString() == "Cables")
                {
                    createCables(vendor, fPrice, make, model, comments);
                }
                else if (cmbPart.SelectedItem.ToString() == "Other")
                {
                    createOther(vendor, fPrice, make, model, comments);
                }

                // reset all fields
                clearFields();       
            }
            catch (InvalidParts ex) 
            {
                MessageBox.Show(ex.Message);            
            }
        }


        // creating a CPU object
        private void createCPU (string vendor, float fPrice, string make, string model, string comments)
        {
            // getting specific CPU
            string socketType = txtSocketType.Text;
            string clockSpeed = txtClockSpeed.Text;
            string coreCount = txtCoreCount.Text;

            try
            {
                float fSpeed = checkFloat(clockSpeed, "Clock Speed");
                int intCount = checkInt(coreCount, "Core Count");

                // creating a new CPU object
                CPU cpu = new CPU(socketType, intCount, fSpeed, vendor, fPrice, make, model, comments);

                // append info to a CSV file
                string cpuInfo = cpu.getData() + "\n";
                File.AppendAllText(fileName, cpuInfo);

                // let user know data was appended
                MessageBox.Show("CPU information was appended to CSV " + fileName);
            }
            catch (InvalidInteger ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // creating a GPU object
        private void createGPU (string vendor, float fPrice, string make, string model, string comments)
        {
           string memory = txtMemory.Text;
           try
            {
                int intMemory = checkInt(memory, "Memory");

                // creating a new GPU object
                GPU gpu = new GPU(intMemory, vendor, fPrice, make, model, comments);

                // append info to a CSV file
                string gpuInfo = gpu.getData() + "\n";
                File.AppendAllText(fileName, gpuInfo);

                // let user know data was appended
                MessageBox.Show("GPU information was appended to CSV " + fileName);
            }
            catch (InvalidInteger ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // creating a RAM object
        private void createRAM (string vendor, float fPrice, string make, string model, string comments)
        {
            // getting specific RAM input
            string speed = txtSpeed.Text;
            string capacity = txtCapacity.Text;
            try 
            {
                // make sure speed and capacity are integers
                int intSpeed = checkInt(speed, "Speed"); // function that checks if the value is an integer, throws an error if not
                int intCapacity = checkInt(capacity, "Capacity");

                // creating a new RAM object
                RAM ram = new RAM(intSpeed, intCapacity, vendor, fPrice, make, model, comments);

                // append info to the CSV file
                string ramInfo = ram.getData() + "\n";
                File.AppendAllText(fileName, ramInfo);

                // let user know data was appended
                MessageBox.Show("RAM information was appended to CSV " + fileName);
            }
            catch (InvalidRAM ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidInteger ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        // creating a motherboard object
        private void createMB(string vendor, float fPrice, string make, string model, string comments)
        {
            // get input from the user
            string socketType = txtSocketTypeMB.Text;
            string formFactor = txtFormFactor.Text;
            try
            {
                // creating a new motherboard object
                Motherboard motherboard = new Motherboard(formFactor, socketType, vendor, fPrice, make, model, comments);

                // append info to the CSV file
                string mbInfo = motherboard.getData() + "\n";
                File.AppendAllText(fileName, mbInfo);

                // let user know that the data was appended
                MessageBox.Show("Motherboard information was appended to CSV " + fileName);
            }
            catch (InvalidMB ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // creating a cable object
        private void createCables(string vendor, float fPrice, string make, string model, string comments)
        {
            // get input from the user
            string type = txtTypeCable.Text;
            string length = txtLength.Text;
            string connectorType = txtConnectorType.Text;

            try 
            {
                int intLength = checkInt(length, "Length");

                // create a new cable object
                Cables cables = new Cables(type, connectorType, intLength, vendor, fPrice, make, model, comments);

                // append info to the CSV file
                string cableInfo = cables.getData() + "\n";
                File.AppendAllText(fileName, cableInfo);

                // let user know that the data was appended
                MessageBox.Show("Cable information was appended to CSV " + fileName);
            }
            catch (InvalidInteger ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // creating an 'other' object
        private void createOther (string vendor, float fPrice, string make, string model, string comments)
        {
            string type = txtTypeOther.Text;

            // create new other object
            Other other = new Other(type, vendor, fPrice, make, model, comments);
            
            // append info to the CSV file
            string otherInfo = other.getData() + "\n";
            File.AppendAllText(fileName, otherInfo);

            // let user know that the data was appended
            MessageBox.Show("Part information was appended to CSV " + fileName);
        }



        // Once the user selects an item from the combo box, text fields are disabled or enabled
        private void cmbPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Disable all fields by default
            disableFields(txtSocketType, txtCoreCount, txtClockSpeed, txtMemory, txtSpeed, txtCapacity, txtFormFactor, txtSocketTypeMB, txtTypeCable, txtLength, txtConnectorType, txtTypeOther);

            if (cmbPart.SelectedItem.ToString() == "CPU")
            {
                // enable fields and disable all other fields
                enableFields(txtSocketType, txtCoreCount, txtClockSpeed);
            }
            else if (cmbPart.SelectedItem.ToString() == "GPU")
            {
                enableFields(txtMemory);
            }
            else if (cmbPart.SelectedItem.ToString() == "RAM")
            {
                enableFields(txtSpeed, txtCapacity);
            }
            else if (cmbPart.SelectedItem.ToString() == "Motherboard")
            {
                enableFields(txtFormFactor, txtSocketTypeMB);
            }
            else if (cmbPart.SelectedItem.ToString() == "Cables")
            {
                enableFields(txtTypeCable, txtLength, txtConnectorType);
            }
            else if (cmbPart.SelectedItem.ToString() == "Other")
            {
                enableFields(txtTypeOther);
            }
        }


        // function that disables text fields
        private void disableFields(params Control[] controls)
        {
            foreach (var control in controls)
            {
                control.Enabled = false;
            }
        }

        // function that enables text fields
        private void enableFields(params Control[] controls)
        {
            foreach (var control in controls)
            {
                control.Enabled = true;
            }
        }

        // function that clears all text fields
        private void clearFields()
        {
            // Clear text boxes
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }
            }
            txtComments.Clear();
        }


        // event handler that opens form 2 when the display button is clicked
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // open second form from the first form
            Form2 partsData = new Form2();
            partsData.Show();
        }


        // function that makes sure the value from a text field is an integer
        private int checkInt(string strValue, string type)
        {
            int intValue;
            if (!int.TryParse(strValue, out intValue))
            {
                if (cmbPart.SelectedItem.ToString() == "RAM")
                {
                    throw new InvalidInteger(type + " must be an integer.");
                }
            }
            return intValue;
        }


        // function that makes sure the value from a text field is a float
        private float checkFloat (string strValue, string type)
        {
            float floatValue;
            if (!float.TryParse(strValue, out floatValue))
            {
                throw new InvalidFloat(type + "must be a number");
            }
            return floatValue;
        }




















        // accidentally double clicked following functions
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {
        }
    }
}