namespace Colegio_GUI.Forms.Operations.Enrollments
{
    partial class EnrollmentOperations_Add
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtStudentID = new TextBox();
            cboGrade = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            lstPayment = new ListBox();
            btnAdd = new Button();
            btnCancel = new Button();
            lblStudentName = new Label();
            txtRecepcionist = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 22);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "StudentID: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 59);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Grade: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 59);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 2;
            label3.Text = "Date Created: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 133);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 4;
            label4.Text = "Recepcionist: ";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(120, 19);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(100, 23);
            txtStudentID.TabIndex = 0;
            txtStudentID.TextChanged += txtStudentID_TextChanged;
            // 
            // cboGrade
            // 
            cboGrade.FormattingEnabled = true;
            cboGrade.Location = new Point(99, 56);
            cboGrade.Name = "cboGrade";
            cboGrade.Size = new Size(201, 23);
            cboGrade.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(417, 56);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(321, 135);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 9;
            label5.Text = "Payment Status: ";
            // 
            // lstPayment
            // 
            lstPayment.FormattingEnabled = true;
            lstPayment.ItemHeight = 15;
            lstPayment.Items.AddRange(new object[] { "Completely Paid", "Not Completely Paid", "Not Paid at all", "Scholarship", "Other" });
            lstPayment.Location = new Point(417, 103);
            lstPayment.Name = "lstPayment";
            lstPayment.Size = new Size(200, 94);
            lstPayment.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(341, 229);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(463, 229);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblStudentName
            // 
            lblStudentName.BorderStyle = BorderStyle.FixedSingle;
            lblStudentName.Location = new Point(255, 19);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(362, 23);
            lblStudentName.TabIndex = 12;
            // 
            // txtRecepcionist
            // 
            txtRecepcionist.Enabled = false;
            txtRecepcionist.Location = new Point(120, 130);
            txtRecepcionist.Name = "txtRecepcionist";
            txtRecepcionist.Size = new Size(180, 23);
            txtRecepcionist.TabIndex = 13;
            // 
            // EnrollmentOperations_Add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 278);
            Controls.Add(txtRecepcionist);
            Controls.Add(lblStudentName);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(lstPayment);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(cboGrade);
            Controls.Add(txtStudentID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EnrollmentOperations_Add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Enrollment";
            Load += EnrollmentOperations_Add_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtStudentID;
        private ComboBox cboGrade;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private ListBox lstPayment;
        private Button btnAdd;
        private Button btnCancel;
        private Label lblStudentName;
        private TextBox txtRecepcionist;
    }
}