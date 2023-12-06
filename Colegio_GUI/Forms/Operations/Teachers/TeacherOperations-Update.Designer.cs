namespace Colegio_GUI.Forms.Operations.Teachers
{
    partial class TeacherOperations_Update
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
            label16 = new Label();
            label15 = new Label();
            txtQualifications = new TextBox();
            label4 = new Label();
            btnClose = new Button();
            btnUpdate = new Button();
            lstCurrentState = new ListBox();
            cboSubject = new ComboBox();
            cboDistrict = new ComboBox();
            cboProvince = new ComboBox();
            cboDepartment = new ComboBox();
            dtpOnBoard = new DateTimePicker();
            dtpDateOfBirth = new DateTimePicker();
            txtSecondName = new TextBox();
            txtSecondLastN = new TextBox();
            txtAddress = new TextBox();
            txtContactNumber = new TextBox();
            txtContactMail = new TextBox();
            txtFirstName = new TextBox();
            txtFirstLastName = new TextBox();
            btnAddPhoto = new Button();
            pcbStudentPic = new PictureBox();
            label6 = new Label();
            label12 = new Label();
            label14 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label13 = new Label();
            label5 = new Label();
            txtSecondLastName = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label17 = new Label();
            lblTeacherID = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbStudentPic).BeginInit();
            SuspendLayout();
            // 
            // label16
            // 
            label16.BorderStyle = BorderStyle.FixedSingle;
            label16.Location = new Point(402, 20);
            label16.Name = "label16";
            label16.Size = new Size(165, 23);
            label16.TabIndex = 92;
            label16.Text = "0 - Teacher";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(356, 20);
            label15.Name = "label15";
            label15.Size = new Size(36, 15);
            label15.TabIndex = 91;
            label15.Text = "Role: ";
            // 
            // txtQualifications
            // 
            txtQualifications.Location = new Point(133, 566);
            txtQualifications.Name = "txtQualifications";
            txtQualifications.Size = new Size(205, 23);
            txtQualifications.TabIndex = 71;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 537);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 90;
            label4.Text = "Subject Taught:";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(396, 659);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(187, 38);
            btnClose.TabIndex = 74;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(137, 659);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(187, 38);
            btnUpdate.TabIndex = 73;
            btnUpdate.Text = "Update Register";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lstCurrentState
            // 
            lstCurrentState.FormattingEnabled = true;
            lstCurrentState.ItemHeight = 15;
            lstCurrentState.Items.AddRange(new object[] { "Employed", "On Vacations", "Fired", "Retired", "Others" });
            lstCurrentState.Location = new Point(137, 424);
            lstCurrentState.Name = "lstCurrentState";
            lstCurrentState.Size = new Size(204, 94);
            lstCurrentState.TabIndex = 69;
            // 
            // cboSubject
            // 
            cboSubject.FormattingEnabled = true;
            cboSubject.Location = new Point(134, 534);
            cboSubject.Name = "cboSubject";
            cboSubject.Size = new Size(204, 23);
            cboSubject.TabIndex = 70;
            // 
            // cboDistrict
            // 
            cboDistrict.FormattingEnabled = true;
            cboDistrict.Location = new Point(137, 273);
            cboDistrict.Name = "cboDistrict";
            cboDistrict.Size = new Size(204, 23);
            cboDistrict.TabIndex = 65;
            // 
            // cboProvince
            // 
            cboProvince.FormattingEnabled = true;
            cboProvince.Location = new Point(137, 246);
            cboProvince.Name = "cboProvince";
            cboProvince.Size = new Size(204, 23);
            cboProvince.TabIndex = 64;
            cboProvince.SelectedIndexChanged += cboProvince_SelectedIndexChanged;
            // 
            // cboDepartment
            // 
            cboDepartment.FormattingEnabled = true;
            cboDepartment.Location = new Point(137, 219);
            cboDepartment.Name = "cboDepartment";
            cboDepartment.Size = new Size(204, 23);
            cboDepartment.TabIndex = 63;
            cboDepartment.SelectedIndexChanged += cboDepartment_SelectedIndexChanged;
            // 
            // dtpOnBoard
            // 
            dtpOnBoard.Checked = false;
            dtpOnBoard.Format = DateTimePickerFormat.Short;
            dtpOnBoard.Location = new Point(137, 150);
            dtpOnBoard.Name = "dtpOnBoard";
            dtpOnBoard.Size = new Size(204, 23);
            dtpOnBoard.TabIndex = 62;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Checked = false;
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(137, 121);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(204, 23);
            dtpDateOfBirth.TabIndex = 61;
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(474, 53);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(204, 23);
            txtSecondName.TabIndex = 58;
            // 
            // txtSecondLastN
            // 
            txtSecondLastN.Location = new Point(474, 83);
            txtSecondLastN.Name = "txtSecondLastN";
            txtSecondLastN.Size = new Size(204, 23);
            txtSecondLastN.TabIndex = 60;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(474, 273);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(204, 23);
            txtAddress.TabIndex = 66;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(137, 340);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(204, 23);
            txtContactNumber.TabIndex = 67;
            // 
            // txtContactMail
            // 
            txtContactMail.Location = new Point(137, 371);
            txtContactMail.Name = "txtContactMail";
            txtContactMail.Size = new Size(204, 23);
            txtContactMail.TabIndex = 68;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(137, 54);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(204, 23);
            txtFirstName.TabIndex = 57;
            // 
            // txtFirstLastName
            // 
            txtFirstLastName.Location = new Point(137, 83);
            txtFirstLastName.Name = "txtFirstLastName";
            txtFirstLastName.Size = new Size(204, 23);
            txtFirstLastName.TabIndex = 59;
            // 
            // btnAddPhoto
            // 
            btnAddPhoto.Location = new Point(474, 339);
            btnAddPhoto.Name = "btnAddPhoto";
            btnAddPhoto.Size = new Size(75, 23);
            btnAddPhoto.TabIndex = 72;
            btnAddPhoto.Text = "Add Photo";
            btnAddPhoto.UseVisualStyleBackColor = true;
            btnAddPhoto.Click += btnAddPhoto_Click;
            // 
            // pcbStudentPic
            // 
            pcbStudentPic.BackgroundImageLayout = ImageLayout.Center;
            pcbStudentPic.BorderStyle = BorderStyle.FixedSingle;
            pcbStudentPic.Location = new Point(362, 368);
            pcbStudentPic.Name = "pcbStudentPic";
            pcbStudentPic.Size = new Size(316, 276);
            pcbStudentPic.SizeMode = PictureBoxSizeMode.Zoom;
            pcbStudentPic.TabIndex = 89;
            pcbStudentPic.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 424);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 88;
            label6.Text = "Current Status: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(37, 343);
            label12.Name = "label12";
            label12.Size = new Size(91, 15);
            label12.TabIndex = 87;
            label12.Text = "Phone Number:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(19, 569);
            label14.Name = "label14";
            label14.Size = new Size(83, 15);
            label14.TabIndex = 85;
            label14.Text = "Qualifications:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(37, 374);
            label11.Name = "label11";
            label11.Size = new Size(36, 15);
            label11.TabIndex = 86;
            label11.Text = "Mail: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(356, 277);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 84;
            label10.Text = "Address:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 276);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 83;
            label9.Text = "District: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 249);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 82;
            label8.Text = "Province: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 222);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 81;
            label7.Text = "Department: ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(30, 154);
            label13.Name = "label13";
            label13.Size = new Size(104, 15);
            label13.TabIndex = 79;
            label13.Text = "On Boarding Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 127);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 80;
            label5.Text = "Date Of Birth: ";
            // 
            // txtSecondLastName
            // 
            txtSecondLastName.AutoSize = true;
            txtSecondLastName.Location = new Point(356, 86);
            txtSecondLastName.Name = "txtSecondLastName";
            txtSecondLastName.Size = new Size(111, 15);
            txtSecondLastName.TabIndex = 78;
            txtSecondLastName.Text = "Second Last Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 86);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 77;
            label3.Text = "First Last Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 56);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 76;
            label2.Text = "Second Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 53);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 75;
            label1.Text = "First Name: ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(37, 17);
            label17.Name = "label17";
            label17.Size = new Size(84, 15);
            label17.TabIndex = 93;
            label17.Text = "Teacher Code: ";
            // 
            // lblTeacherID
            // 
            lblTeacherID.BorderStyle = BorderStyle.FixedSingle;
            lblTeacherID.Location = new Point(137, 19);
            lblTeacherID.Name = "lblTeacherID";
            lblTeacherID.Size = new Size(146, 23);
            lblTeacherID.TabIndex = 94;
            // 
            // TeacherOperations_Update
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 728);
            Controls.Add(lblTeacherID);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(txtQualifications);
            Controls.Add(label4);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(lstCurrentState);
            Controls.Add(cboSubject);
            Controls.Add(cboDistrict);
            Controls.Add(cboProvince);
            Controls.Add(cboDepartment);
            Controls.Add(dtpOnBoard);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(txtSecondName);
            Controls.Add(txtSecondLastN);
            Controls.Add(txtAddress);
            Controls.Add(txtContactNumber);
            Controls.Add(txtContactMail);
            Controls.Add(txtFirstName);
            Controls.Add(txtFirstLastName);
            Controls.Add(btnAddPhoto);
            Controls.Add(pcbStudentPic);
            Controls.Add(label6);
            Controls.Add(label12);
            Controls.Add(label14);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label13);
            Controls.Add(label5);
            Controls.Add(txtSecondLastName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TeacherOperations_Update";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Teacher";
            Load += TeacherOperations_Update_Load;
            ((System.ComponentModel.ISupportInitialize)pcbStudentPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label16;
        private Label label15;
        private TextBox txtQualifications;
        private Label label4;
        private Button btnClose;
        private Button btnUpdate;
        private ListBox lstCurrentState;
        private ComboBox cboSubject;
        private ComboBox cboDistrict;
        private ComboBox cboProvince;
        private ComboBox cboDepartment;
        private DateTimePicker dtpOnBoard;
        private DateTimePicker dtpDateOfBirth;
        private TextBox txtSecondName;
        private TextBox txtSecondLastN;
        private TextBox txtAddress;
        private TextBox txtContactNumber;
        private TextBox txtContactMail;
        private TextBox txtFirstName;
        private TextBox txtFirstLastName;
        private Button btnAddPhoto;
        private PictureBox pcbStudentPic;
        private Label label6;
        private Label label12;
        private Label label14;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label13;
        private Label label5;
        private Label txtSecondLastName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label17;
        private Label lblTeacherID;
    }
}