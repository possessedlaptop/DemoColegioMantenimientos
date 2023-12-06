namespace Colegio_GUI.Forms.Operations.Teachers
{
    partial class TeacherOperations_Add
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
            label4 = new Label();
            btnClose = new Button();
            btnAdd = new Button();
            lstCurrentState = new ListBox();
            cboSubject = new ComboBox();
            cboDistrict = new ComboBox();
            cboProvince = new ComboBox();
            cboDepartment = new ComboBox();
            dtpDateOfBirth = new DateTimePicker();
            txtSecondName = new TextBox();
            txtSecondLastN = new TextBox();
            txtAddress = new TextBox();
            txtContactMail = new TextBox();
            txtFirstName = new TextBox();
            txtFirstLastName = new TextBox();
            btnAddPhoto = new Button();
            pcbStudentPic = new PictureBox();
            label6 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            txtSecondLastName = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label13 = new Label();
            dtpOnBoard = new DateTimePicker();
            txtContactNumber = new TextBox();
            label14 = new Label();
            txtQualifications = new TextBox();
            label15 = new Label();
            label16 = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbStudentPic).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 536);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 53;
            label4.Text = "Subject Taught:";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(395, 658);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(187, 38);
            btnClose.TabIndex = 17;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(136, 658);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(187, 38);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add Register";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstCurrentState
            // 
            lstCurrentState.FormattingEnabled = true;
            lstCurrentState.ItemHeight = 15;
            lstCurrentState.Items.AddRange(new object[] { "Employed", "On Vacations", "Fired", "Retired", "Others" });
            lstCurrentState.Location = new Point(136, 423);
            lstCurrentState.Name = "lstCurrentState";
            lstCurrentState.Size = new Size(204, 94);
            lstCurrentState.TabIndex = 12;
            // 
            // cboSubject
            // 
            cboSubject.FormattingEnabled = true;
            cboSubject.Location = new Point(133, 533);
            cboSubject.Name = "cboSubject";
            cboSubject.Size = new Size(204, 23);
            cboSubject.TabIndex = 13;
            // 
            // cboDistrict
            // 
            cboDistrict.FormattingEnabled = true;
            cboDistrict.Location = new Point(136, 272);
            cboDistrict.Name = "cboDistrict";
            cboDistrict.Size = new Size(204, 23);
            cboDistrict.TabIndex = 8;
            // 
            // cboProvince
            // 
            cboProvince.FormattingEnabled = true;
            cboProvince.Location = new Point(136, 245);
            cboProvince.Name = "cboProvince";
            cboProvince.Size = new Size(204, 23);
            cboProvince.TabIndex = 7;
            cboProvince.SelectedIndexChanged += cboProvince_SelectedIndexChanged;
            // 
            // cboDepartment
            // 
            cboDepartment.FormattingEnabled = true;
            cboDepartment.Location = new Point(136, 218);
            cboDepartment.Name = "cboDepartment";
            cboDepartment.Size = new Size(204, 23);
            cboDepartment.TabIndex = 6;
            cboDepartment.SelectedIndexChanged += cboDepartment_SelectedIndexChanged;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Checked = false;
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(136, 120);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(204, 23);
            dtpDateOfBirth.TabIndex = 4;
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(473, 52);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(204, 23);
            txtSecondName.TabIndex = 1;
            // 
            // txtSecondLastN
            // 
            txtSecondLastN.Location = new Point(473, 82);
            txtSecondLastN.Name = "txtSecondLastN";
            txtSecondLastN.Size = new Size(204, 23);
            txtSecondLastN.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(473, 272);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(204, 23);
            txtAddress.TabIndex = 9;
            // 
            // txtContactMail
            // 
            txtContactMail.Location = new Point(136, 370);
            txtContactMail.Name = "txtContactMail";
            txtContactMail.Size = new Size(204, 23);
            txtContactMail.TabIndex = 11;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(136, 53);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(204, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtFirstLastName
            // 
            txtFirstLastName.Location = new Point(136, 82);
            txtFirstLastName.Name = "txtFirstLastName";
            txtFirstLastName.Size = new Size(204, 23);
            txtFirstLastName.TabIndex = 2;
            // 
            // btnAddPhoto
            // 
            btnAddPhoto.Location = new Point(473, 338);
            btnAddPhoto.Name = "btnAddPhoto";
            btnAddPhoto.Size = new Size(75, 23);
            btnAddPhoto.TabIndex = 15;
            btnAddPhoto.Text = "Add Photo";
            btnAddPhoto.UseVisualStyleBackColor = true;
            btnAddPhoto.Click += btnAddPhoto_Click;
            // 
            // pcbStudentPic
            // 
            pcbStudentPic.BackgroundImageLayout = ImageLayout.Center;
            pcbStudentPic.BorderStyle = BorderStyle.FixedSingle;
            pcbStudentPic.Location = new Point(361, 367);
            pcbStudentPic.Name = "pcbStudentPic";
            pcbStudentPic.Size = new Size(316, 276);
            pcbStudentPic.SizeMode = PictureBoxSizeMode.Zoom;
            pcbStudentPic.TabIndex = 51;
            pcbStudentPic.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 423);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 48;
            label6.Text = "Current Status: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(36, 342);
            label12.Name = "label12";
            label12.Size = new Size(91, 15);
            label12.TabIndex = 46;
            label12.Text = "Phone Number:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(36, 373);
            label11.Name = "label11";
            label11.Size = new Size(36, 15);
            label11.TabIndex = 43;
            label11.Text = "Mail: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(355, 276);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 42;
            label10.Text = "Address:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 275);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 39;
            label9.Text = "District: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 248);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 38;
            label8.Text = "Province: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 221);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 35;
            label7.Text = "Department: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 126);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 32;
            label5.Text = "Date Of Birth: ";
            // 
            // txtSecondLastName
            // 
            txtSecondLastName.AutoSize = true;
            txtSecondLastName.Location = new Point(355, 85);
            txtSecondLastName.Name = "txtSecondLastName";
            txtSecondLastName.Size = new Size(111, 15);
            txtSecondLastName.TabIndex = 29;
            txtSecondLastName.Text = "Second Last Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 85);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 27;
            label3.Text = "First Last Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 55);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 25;
            label2.Text = "Second Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 52);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 23;
            label1.Text = "First Name: ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(29, 153);
            label13.Name = "label13";
            label13.Size = new Size(104, 15);
            label13.TabIndex = 32;
            label13.Text = "On Boarding Date:";
            // 
            // dtpOnBoard
            // 
            dtpOnBoard.Checked = false;
            dtpOnBoard.Format = DateTimePickerFormat.Short;
            dtpOnBoard.Location = new Point(136, 149);
            dtpOnBoard.Name = "dtpOnBoard";
            dtpOnBoard.Size = new Size(204, 23);
            dtpOnBoard.TabIndex = 5;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(136, 339);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(204, 23);
            txtContactNumber.TabIndex = 10;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(18, 568);
            label14.Name = "label14";
            label14.Size = new Size(83, 15);
            label14.TabIndex = 43;
            label14.Text = "Qualifications:";
            // 
            // txtQualifications
            // 
            txtQualifications.Location = new Point(132, 565);
            txtQualifications.Name = "txtQualifications";
            txtQualifications.Size = new Size(205, 23);
            txtQualifications.TabIndex = 14;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(355, 19);
            label15.Name = "label15";
            label15.Size = new Size(36, 15);
            label15.TabIndex = 55;
            label15.Text = "Role: ";
            // 
            // label16
            // 
            label16.BorderStyle = BorderStyle.FixedSingle;
            label16.Location = new Point(401, 19);
            label16.Name = "label16";
            label16.Size = new Size(165, 23);
            label16.TabIndex = 56;
            label16.Text = "0 - Teacher";
            // 
            // TeacherOperations_Add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 728);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(txtQualifications);
            Controls.Add(label4);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
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
            Name = "TeacherOperations_Add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Teacher";
            Load += TeacherOperations_Add_Load;
            ((System.ComponentModel.ISupportInitialize)pcbStudentPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button btnClose;
        private Button btnAdd;
        private ListBox lstCurrentState;
        private ComboBox cboSubject;
        private ComboBox cboDistrict;
        private ComboBox cboProvince;
        private ComboBox cboDepartment;
        private DateTimePicker dtpDateOfBirth;
        private TextBox txtSecondName;
        private TextBox txtSecondLastN;
        private TextBox txtAddress;
        private TextBox txtContactMail;
        private TextBox txtFirstName;
        private TextBox txtFirstLastName;
        private Button btnAddPhoto;
        private PictureBox pcbStudentPic;
        private Label label6;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label txtSecondLastName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label13;
        private DateTimePicker dtpOnBoard;
        private TextBox txtContactNumber;
        private Label label14;
        private TextBox txtQualifications;
        private Label label15;
        private Label label16;
    }
}