namespace Colegio_GUI.Forms.Operations.Students
{
    partial class StudentsOperations1_Add
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
            txtSecondLastName = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            gboGender = new GroupBox();
            optOther = new RadioButton();
            optFemale = new RadioButton();
            optMale = new RadioButton();
            label6 = new Label();
            pcbStudentPic = new PictureBox();
            btnAddPhoto = new Button();
            txtFirstLastName = new TextBox();
            txtSecondLastN = new TextBox();
            txtSecondName = new TextBox();
            txtFirstName = new TextBox();
            txtContactMail = new TextBox();
            txtAddress = new TextBox();
            dtpDateOfBirth = new DateTimePicker();
            mtbDNI = new MaskedTextBox();
            cboDepartment = new ComboBox();
            cboProvince = new ComboBox();
            cboDistrict = new ComboBox();
            lstCurrentState = new ListBox();
            btnAdd = new Button();
            btnClose = new Button();
            label4 = new Label();
            cboClassroom = new ComboBox();
            gboGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbStudentPic).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 57);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(346, 57);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 1;
            label2.Text = "Second Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 87);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 2;
            label3.Text = "First Last Name: ";
            // 
            // txtSecondLastName
            // 
            txtSecondLastName.AutoSize = true;
            txtSecondLastName.Location = new Point(346, 87);
            txtSecondLastName.Name = "txtSecondLastName";
            txtSecondLastName.Size = new Size(111, 15);
            txtSecondLastName.TabIndex = 3;
            txtSecondLastName.Text = "Second Last Name: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 128);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 4;
            label5.Text = "Date Of Birth: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 223);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 6;
            label7.Text = "Department: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 250);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 7;
            label8.Text = "Province: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 277);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 8;
            label9.Text = "District: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(346, 278);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 9;
            label10.Text = "Address:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(27, 375);
            label11.Name = "label11";
            label11.Size = new Size(36, 15);
            label11.TabIndex = 10;
            label11.Text = "Mail: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(27, 344);
            label12.Name = "label12";
            label12.Size = new Size(80, 15);
            label12.TabIndex = 11;
            label12.Text = "DNI Number: ";
            // 
            // gboGender
            // 
            gboGender.Controls.Add(optOther);
            gboGender.Controls.Add(optFemale);
            gboGender.Controls.Add(optMale);
            gboGender.Location = new Point(346, 128);
            gboGender.Name = "gboGender";
            gboGender.Size = new Size(200, 100);
            gboGender.TabIndex = 5;
            gboGender.TabStop = false;
            gboGender.Text = "Gender: ";
            // 
            // optOther
            // 
            optOther.AutoSize = true;
            optOther.Location = new Point(6, 74);
            optOther.Name = "optOther";
            optOther.Size = new Size(55, 19);
            optOther.TabIndex = 2;
            optOther.TabStop = true;
            optOther.Text = "Other";
            optOther.UseVisualStyleBackColor = true;
            // 
            // optFemale
            // 
            optFemale.AutoSize = true;
            optFemale.Location = new Point(6, 50);
            optFemale.Name = "optFemale";
            optFemale.Size = new Size(63, 19);
            optFemale.TabIndex = 1;
            optFemale.TabStop = true;
            optFemale.Text = "Female";
            optFemale.UseVisualStyleBackColor = true;
            // 
            // optMale
            // 
            optMale.AutoSize = true;
            optMale.Location = new Point(6, 25);
            optMale.Name = "optMale";
            optMale.Size = new Size(51, 19);
            optMale.TabIndex = 0;
            optMale.TabStop = true;
            optMale.Text = "Male";
            optMale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 425);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 13;
            label6.Text = "Current Status: ";
            // 
            // pcbStudentPic
            // 
            pcbStudentPic.BackgroundImageLayout = ImageLayout.Center;
            pcbStudentPic.BorderStyle = BorderStyle.FixedSingle;
            pcbStudentPic.Location = new Point(352, 369);
            pcbStudentPic.Name = "pcbStudentPic";
            pcbStudentPic.Size = new Size(316, 276);
            pcbStudentPic.SizeMode = PictureBoxSizeMode.Zoom;
            pcbStudentPic.TabIndex = 14;
            pcbStudentPic.TabStop = false;
            // 
            // btnAddPhoto
            // 
            btnAddPhoto.Location = new Point(464, 340);
            btnAddPhoto.Name = "btnAddPhoto";
            btnAddPhoto.Size = new Size(75, 23);
            btnAddPhoto.TabIndex = 13;
            btnAddPhoto.Text = "Add Photo";
            btnAddPhoto.UseVisualStyleBackColor = true;
            btnAddPhoto.Click += btnAddPhoto_Click;
            // 
            // txtFirstLastName
            // 
            txtFirstLastName.Location = new Point(127, 84);
            txtFirstLastName.Name = "txtFirstLastName";
            txtFirstLastName.Size = new Size(204, 23);
            txtFirstLastName.TabIndex = 2;
            // 
            // txtSecondLastN
            // 
            txtSecondLastN.Location = new Point(464, 84);
            txtSecondLastN.Name = "txtSecondLastN";
            txtSecondLastN.Size = new Size(204, 23);
            txtSecondLastN.TabIndex = 3;
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(464, 54);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(204, 23);
            txtSecondName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(127, 55);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(204, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtContactMail
            // 
            txtContactMail.Location = new Point(127, 372);
            txtContactMail.Name = "txtContactMail";
            txtContactMail.Size = new Size(204, 23);
            txtContactMail.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(464, 274);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(204, 23);
            txtAddress.TabIndex = 8;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Checked = false;
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(127, 122);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(204, 23);
            dtpDateOfBirth.TabIndex = 4;
            // 
            // mtbDNI
            // 
            mtbDNI.Location = new Point(127, 340);
            mtbDNI.Mask = "99999999";
            mtbDNI.Name = "mtbDNI";
            mtbDNI.Size = new Size(204, 23);
            mtbDNI.TabIndex = 9;
            // 
            // cboDepartment
            // 
            cboDepartment.FormattingEnabled = true;
            cboDepartment.Location = new Point(127, 220);
            cboDepartment.Name = "cboDepartment";
            cboDepartment.Size = new Size(204, 23);
            cboDepartment.TabIndex = 5;
            cboDepartment.SelectedIndexChanged += cboDepartment_SelectedIndexChanged;
            // 
            // cboProvince
            // 
            cboProvince.FormattingEnabled = true;
            cboProvince.Location = new Point(127, 247);
            cboProvince.Name = "cboProvince";
            cboProvince.Size = new Size(204, 23);
            cboProvince.TabIndex = 6;
            cboProvince.SelectedIndexChanged += cboProvince_SelectedIndexChanged;
            // 
            // cboDistrict
            // 
            cboDistrict.FormattingEnabled = true;
            cboDistrict.Location = new Point(127, 274);
            cboDistrict.Name = "cboDistrict";
            cboDistrict.Size = new Size(204, 23);
            cboDistrict.TabIndex = 7;
            // 
            // lstCurrentState
            // 
            lstCurrentState.FormattingEnabled = true;
            lstCurrentState.ItemHeight = 15;
            lstCurrentState.Items.AddRange(new object[] { "Studying", "Graduated", "Expulsed", "Dropped", "Others" });
            lstCurrentState.Location = new Point(127, 425);
            lstCurrentState.Name = "lstCurrentState";
            lstCurrentState.Size = new Size(204, 94);
            lstCurrentState.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(127, 660);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(187, 38);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add Register";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(386, 660);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(187, 38);
            btnClose.TabIndex = 16;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 569);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 22;
            label4.Text = "Current Classroom: ";
            // 
            // cboClassroom
            // 
            cboClassroom.FormattingEnabled = true;
            cboClassroom.Location = new Point(127, 566);
            cboClassroom.Name = "cboClassroom";
            cboClassroom.Size = new Size(204, 23);
            cboClassroom.TabIndex = 12;
            // 
            // StudentsOperations1_Add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 728);
            Controls.Add(label4);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(lstCurrentState);
            Controls.Add(cboClassroom);
            Controls.Add(cboDistrict);
            Controls.Add(cboProvince);
            Controls.Add(cboDepartment);
            Controls.Add(mtbDNI);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(txtSecondName);
            Controls.Add(txtSecondLastN);
            Controls.Add(txtAddress);
            Controls.Add(txtContactMail);
            Controls.Add(txtFirstName);
            Controls.Add(txtFirstLastName);
            Controls.Add(btnAddPhoto);
            Controls.Add(pcbStudentPic);
            Controls.Add(label6);
            Controls.Add(gboGender);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(txtSecondLastName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentsOperations1_Add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Student";
            Load += StudentsOperations1_Add_Load;
            gboGender.ResumeLayout(false);
            gboGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbStudentPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label txtSecondLastName;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private GroupBox gboGender;
        private RadioButton optOther;
        private RadioButton optFemale;
        private RadioButton optMale;
        private Label label6;
        private PictureBox pcbStudentPic;
        private Button btnAddPhoto;
        private TextBox txtFirstLastName;
        private TextBox txtSecondLastN;
        private TextBox txtSecondName;
        private TextBox txtFirstName;
        private TextBox txtContactMail;
        private TextBox txtAddress;
        private DateTimePicker dtpDateOfBirth;
        private MaskedTextBox mtbDNI;
        private ComboBox cboDepartment;
        private ComboBox cboProvince;
        private ComboBox cboDistrict;
        private ListBox lstCurrentState;
        private Button btnAdd;
        private Button btnClose;
        private Label label4;
        private ComboBox cboClassroom;
    }
}