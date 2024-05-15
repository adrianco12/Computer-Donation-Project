namespace FinalProject
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnReturn = new Button();
            dataGridView = new DataGridView();
            Column0 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Model = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 46);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Computer Parts Data";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(1507, 529);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(180, 87);
            btnReturn.TabIndex = 2;
            btnReturn.Text = "Return To Parts Input";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Column0, Column1, Column2, Column3, Model, Column5, Column6 });
            dataGridView.Location = new Point(46, 95);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(1641, 388);
            dataGridView.TabIndex = 5;
            // 
            // Column0
            // 
            Column0.HeaderText = "Type of Part";
            Column0.Name = "Column0";
            // 
            // Column1
            // 
            Column1.HeaderText = "Vendor";
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Price";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Make";
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Model
            // 
            Model.HeaderText = "Model";
            Model.Name = "Model";
            Model.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "Comments";
            Column5.Name = "Column5";
            Column5.Width = 300;
            // 
            // Column6
            // 
            Column6.HeaderText = "Specific Part Information";
            Column6.Name = "Column6";
            Column6.Width = 500;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1825, 662);
            Controls.Add(dataGridView);
            Controls.Add(btnReturn);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnReturn;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Column0;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}