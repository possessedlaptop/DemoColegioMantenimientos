namespace Colegio_GUI.Forms.Operations.Enrollments
{
    partial class EnrollmentOperations_Update
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
            lblStudentName = new Label();
            btnCancel = new Button();
            btnUpdate = new Button();
            lstPayment = new ListBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            cboGrade = new ComboBox();
            txtStudentID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            lblEnrollmentID = new Label();
            txtRecepcionist = new TextBox();
            SuspendLayout();
            // 
            // lblStudentName
            // 
            lblStudentName.BorderStyle = BorderStyle.FixedSingle;
            lblStudentName.Location = new Point(253, 43);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(362, 23);
            lblStudentName.TabIndex = 25;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(461, 234);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(339, 234);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lstPayment
            // 
            lstPayment.FormattingEnabled = true;
            lstPayment.ItemHeight = 15;
            lstPayment.Items.AddRange(new object[] { "Not Completely Paid", "Completely Paid", "Not Paid at all", "Scholarship", "Other" });
            lstPayment.Location = new Point(415, 120);
            lstPayment.Name = "lstPayment";
            lstPayment.Size = new Size(200, 94);
            lstPayment.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(319, 152);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 21;
            label5.Text = "Payment Status: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(416, 87);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // cboGrade
            // 
            cboGrade.FormattingEnabled = true;
            cboGrade.Location = new Point(98, 87);
            cboGrade.Name = "cboGrade";
            cboGrade.Size = new Size(201, 23);
            cboGrade.TabIndex = 1;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(118, 43);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(100, 23);
            txtStudentID.TabIndex = 0;
            txtStudentID.TextChanged += txtStudentID_TextChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 150);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 16;
            label4.Text = "Recepcionist: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 90);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 15;
            label3.Text = "Date Created: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 90);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 14;
            label2.Text = "Grade: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 46);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 13;
            label1.Text = "StudentID: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 9);
            label6.Name = "label6";
            label6.Size = new Size(82, 15);
            label6.TabIndex = 26;
            label6.Text = "EnrollmentID: ";
            // 
            // lblEnrollmentID
            // 
            lblEnrollmentID.BorderStyle = BorderStyle.FixedSingle;
            lblEnrollmentID.Location = new Point(131, 8);
            lblEnrollmentID.Name = "lblEnrollmentID";
            lblEnrollmentID.Size = new Size(168, 23);
            lblEnrollmentID.TabIndex = 27;
            // 
            // txtRecepcionist
            // 
            txtRecepcionist.Enabled = false;
            txtRecepcionist.Location = new Point(118, 147);
            txtRecepcionist.Name = "txtRecepcionist";
            txtRecepcionist.Size = new Size(181, 23);
            txtRecepcionist.TabIndex = 28;
            // 
            // EnrollmentOperations_Update
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 278);
            Controls.Add(txtRecepcionist);
            Controls.Add(lblEnrollmentID);
            Controls.Add(label6);
            Controls.Add(lblStudentName);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(lstPayment);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(cboGrade);
            Controls.Add(txtStudentID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EnrollmentOperations_Update";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Enrollments";
            Load += EnrollmentOperations_Update_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentName;
        private Button btnCancel;
        private Button btnUpdate;
        private ListBox lstPayment;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private ComboBox cboGrade;
        private TextBox txtStudentID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label lblEnrollmentID;
        private TextBox txtRecepcionist;
    }
}