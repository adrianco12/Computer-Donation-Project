namespace FinalProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbPart = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnSubmit = new Button();
            btnDisplay = new Button();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtVendor = new TextBox();
            txtPrice = new TextBox();
            label7 = new Label();
            txtSocketType = new TextBox();
            txtModel = new TextBox();
            txtMake = new TextBox();
            txtMemory = new TextBox();
            txtCapacity = new TextBox();
            txtSpeed = new TextBox();
            txtFormFactor = new TextBox();
            txtLength = new TextBox();
            txtTypeCable = new TextBox();
            txtTypeOther = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label31 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label4 = new Label();
            label29 = new Label();
            txtClockSpeed = new TextBox();
            txtCoreCount = new TextBox();
            label17 = new Label();
            txtConnectorType = new TextBox();
            txtSocketTypeMB = new TextBox();
            txtComments = new RichTextBox();
            label18 = new Label();
            SuspendLayout();
            // 
            // cmbPart
            // 
            cmbPart.FormattingEnabled = true;
            cmbPart.Items.AddRange(new object[] { "CPU", "GPU", "RAM", "Motherboard", "Cables", "Other" });
            cmbPart.Location = new Point(60, 122);
            cmbPart.Name = "cmbPart";
            cmbPart.Size = new Size(121, 23);
            cmbPart.TabIndex = 0;
            cmbPart.SelectedIndexChanged += cmbPart_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(44, 29);
            label1.Name = "label1";
            label1.Size = new Size(374, 29);
            label1.TabIndex = 1;
            label1.Text = "COMP 350: Final Project - Parts";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(39, 94);
            label2.Name = "label2";
            label2.Size = new Size(215, 20);
            label2.TabIndex = 2;
            label2.Text = "1. Choose which part to input";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(833, 547);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(226, 76);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(1084, 547);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(214, 76);
            btnDisplay.TabIndex = 4;
            btnDisplay.Text = "Display Data";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(39, 178);
            label3.Name = "label3";
            label3.Size = new Size(256, 20);
            label3.TabIndex = 5;
            label3.Text = "2. Enter general info about the part";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 210);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 7;
            label5.Text = "Vendor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 265);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 8;
            label6.Text = "Price";
            // 
            // txtVendor
            // 
            txtVendor.Location = new Point(60, 228);
            txtVendor.Name = "txtVendor";
            txtVendor.Size = new Size(100, 23);
            txtVendor.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(60, 284);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(344, 94);
            label7.Name = "label7";
            label7.Size = new Size(256, 20);
            label7.TabIndex = 12;
            label7.Text = "3. Enter specific info about the part";
            // 
            // txtSocketType
            // 
            txtSocketType.Location = new Point(349, 176);
            txtSocketType.Name = "txtSocketType";
            txtSocketType.Size = new Size(100, 23);
            txtSocketType.TabIndex = 22;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(62, 396);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 21;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(62, 340);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(100, 23);
            txtMake.TabIndex = 20;
            // 
            // txtMemory
            // 
            txtMemory.Location = new Point(538, 176);
            txtMemory.Name = "txtMemory";
            txtMemory.Size = new Size(100, 23);
            txtMemory.TabIndex = 25;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(730, 229);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(100, 23);
            txtCapacity.TabIndex = 27;
            // 
            // txtSpeed
            // 
            txtSpeed.Location = new Point(730, 176);
            txtSpeed.Name = "txtSpeed";
            txtSpeed.Size = new Size(100, 23);
            txtSpeed.TabIndex = 26;
            // 
            // txtFormFactor
            // 
            txtFormFactor.Location = new Point(346, 455);
            txtFormFactor.Name = "txtFormFactor";
            txtFormFactor.Size = new Size(100, 23);
            txtFormFactor.TabIndex = 31;
            // 
            // txtLength
            // 
            txtLength.Location = new Point(538, 455);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(100, 23);
            txtLength.TabIndex = 33;
            // 
            // txtTypeCable
            // 
            txtTypeCable.Location = new Point(538, 402);
            txtTypeCable.Name = "txtTypeCable";
            txtTypeCable.Size = new Size(100, 23);
            txtTypeCable.TabIndex = 32;
            // 
            // txtTypeOther
            // 
            txtTypeOther.Location = new Point(733, 402);
            txtTypeOther.Name = "txtTypeOther";
            txtTypeOther.Size = new Size(100, 23);
            txtTypeOther.TabIndex = 35;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(62, 322);
            label14.Name = "label14";
            label14.Size = new Size(36, 15);
            label14.TabIndex = 38;
            label14.Text = "Make";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(62, 378);
            label15.Name = "label15";
            label15.Size = new Size(41, 15);
            label15.TabIndex = 39;
            label15.Text = "Model";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(538, 158);
            label16.Name = "label16";
            label16.Size = new Size(91, 15);
            label16.TabIndex = 40;
            label16.Text = "Memory (in GB)";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(349, 158);
            label19.Name = "label19";
            label19.Size = new Size(69, 15);
            label19.TabIndex = 43;
            label19.Text = "Socket Type";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(730, 158);
            label20.Name = "label20";
            label20.Size = new Size(75, 15);
            label20.TabIndex = 44;
            label20.Text = "Speed (MHz)";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(730, 211);
            label21.Name = "label21";
            label21.Size = new Size(92, 15);
            label21.TabIndex = 45;
            label21.Text = "Capacity (in GB)";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(347, 384);
            label23.Name = "label23";
            label23.Size = new Size(69, 15);
            label23.TabIndex = 46;
            label23.Text = "Socket Type";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(346, 437);
            label24.Name = "label24";
            label24.Size = new Size(71, 15);
            label24.TabIndex = 48;
            label24.Text = "Form Factor";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(538, 384);
            label25.Name = "label25";
            label25.Size = new Size(78, 15);
            label25.TabIndex = 49;
            label25.Text = "Type of Cable";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(538, 437);
            label26.Name = "label26";
            label26.Size = new Size(104, 15);
            label26.TabIndex = 50;
            label26.Text = "Length (in Meters)";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(730, 384);
            label27.Name = "label27";
            label27.Size = new Size(69, 15);
            label27.TabIndex = 51;
            label27.Text = "Type of Part";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(961, 130);
            label31.Name = "label31";
            label31.Size = new Size(66, 15);
            label31.TabIndex = 55;
            label31.Text = "Comments";
            label31.Click += label31_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label8.Location = new Point(348, 130);
            label8.Name = "label8";
            label8.Size = new Size(33, 17);
            label8.TabIndex = 57;
            label8.Text = "CPU";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label9.Location = new Point(541, 128);
            label9.Name = "label9";
            label9.Size = new Size(34, 17);
            label9.TabIndex = 58;
            label9.Text = "GPU";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label10.Location = new Point(733, 130);
            label10.Name = "label10";
            label10.Size = new Size(37, 17);
            label10.TabIndex = 59;
            label10.Text = "RAM";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label11.Location = new Point(348, 355);
            label11.Name = "label11";
            label11.Size = new Size(89, 17);
            label11.TabIndex = 60;
            label11.Text = "Motherboard";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label12.Location = new Point(538, 353);
            label12.Name = "label12";
            label12.Size = new Size(48, 17);
            label12.TabIndex = 61;
            label12.Text = "Cables";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label13.Location = new Point(730, 353);
            label13.Name = "label13";
            label13.Size = new Size(43, 17);
            label13.TabIndex = 62;
            label13.Text = "Other";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(349, 211);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 66;
            label4.Text = "Core Count";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(349, 266);
            label29.Name = "label29";
            label29.Size = new Size(105, 15);
            label29.TabIndex = 65;
            label29.Text = "Clock Speed (GHz)";
            // 
            // txtClockSpeed
            // 
            txtClockSpeed.Location = new Point(349, 284);
            txtClockSpeed.Name = "txtClockSpeed";
            txtClockSpeed.Size = new Size(100, 23);
            txtClockSpeed.TabIndex = 64;
            // 
            // txtCoreCount
            // 
            txtCoreCount.Location = new Point(349, 229);
            txtCoreCount.Name = "txtCoreCount";
            txtCoreCount.Size = new Size(100, 23);
            txtCoreCount.TabIndex = 63;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(538, 491);
            label17.Name = "label17";
            label17.Size = new Size(90, 15);
            label17.TabIndex = 68;
            label17.Text = "Connector Type";
            // 
            // txtConnectorType
            // 
            txtConnectorType.Location = new Point(538, 509);
            txtConnectorType.Name = "txtConnectorType";
            txtConnectorType.Size = new Size(100, 23);
            txtConnectorType.TabIndex = 67;
            // 
            // txtSocketTypeMB
            // 
            txtSocketTypeMB.Location = new Point(349, 402);
            txtSocketTypeMB.Name = "txtSocketTypeMB";
            txtSocketTypeMB.Size = new Size(100, 23);
            txtSocketTypeMB.TabIndex = 69;
            // 
            // txtComments
            // 
            txtComments.Location = new Point(961, 155);
            txtComments.Name = "txtComments";
            txtComments.Size = new Size(312, 167);
            txtComments.TabIndex = 70;
            txtComments.Text = "";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.Highlight;
            label18.Location = new Point(961, 94);
            label18.Name = "label18";
            label18.Size = new Size(215, 20);
            label18.TabIndex = 71;
            label18.Text = "4. Enter additional comments";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 683);
            Controls.Add(label18);
            Controls.Add(txtComments);
            Controls.Add(txtSocketTypeMB);
            Controls.Add(label17);
            Controls.Add(txtConnectorType);
            Controls.Add(label4);
            Controls.Add(label29);
            Controls.Add(txtClockSpeed);
            Controls.Add(txtCoreCount);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label31);
            Controls.Add(label27);
            Controls.Add(label26);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(txtTypeOther);
            Controls.Add(txtLength);
            Controls.Add(txtTypeCable);
            Controls.Add(txtFormFactor);
            Controls.Add(txtCapacity);
            Controls.Add(txtSpeed);
            Controls.Add(txtMemory);
            Controls.Add(txtSocketType);
            Controls.Add(txtModel);
            Controls.Add(txtMake);
            Controls.Add(label7);
            Controls.Add(txtPrice);
            Controls.Add(txtVendor);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(btnDisplay);
            Controls.Add(btnSubmit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbPart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPart;
        private Label label1;
        private Label label2;
        private Button btnSubmit;
        private Button btnDisplay;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtVendor;
        private TextBox txtPrice;
        private Label label7;
        private TextBox txtSocketType;
        private TextBox txtModel;
        private TextBox txtMake;
        private TextBox txtMemory;
        private TextBox txtModelGPU;
        private TextBox txtMakeGPU;
        private TextBox txtCapacity;
        private TextBox txtSpeed;
        private TextBox txtFormFactor;
        private TextBox txtModelMB;
        private TextBox txtMakeMB;
        private TextBox txtLength;
        private TextBox txtTypeCable;
        private TextBox txtTypeOther;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label31;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label4;
        private Label label29;
        private TextBox txtClockSpeed;
        private TextBox txtCoreCount;
        private TextBox txtConnectorType;
        private TextBox txtSocketTypeMB;
        private RichTextBox txtComments;
    }
}