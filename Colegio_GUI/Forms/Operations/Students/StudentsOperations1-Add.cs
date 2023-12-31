﻿using Colegio_ADO;
using Colegio_BE;
using Colegio_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colegio_GUI.Forms.Operations.Students
{
    public partial class StudentsOperations1_Add : Form
    {

        StudentBL objStudentBL = new StudentBL();
        StudentBE objStudentBE = new StudentBE();
        // To fill combo boxes
        UbigeoBL objUbigeoBL = new UbigeoBL();
        // To allow uploading pictures
        OpenFileDialog dlg = new OpenFileDialog();
        ClassroomBL objClassroomBL = new ClassroomBL();


        public StudentsOperations1_Add()
        {
            InitializeComponent();
        }

        private void StudentsOperations1_Add_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DataRow dr;


                // Fill departments
                dt = objUbigeoBL.ListDepartments();
                dr = dt.NewRow();
                dr["IdDepa"] = 0;
                dr["Departamento"] = "--Select--";
                dt.Rows.InsertAt(dr, 0);

                cboDepartment.DataSource = dt;
                cboDepartment.ValueMember = "IdDepa";
                cboDepartment.DisplayMember = "Departamento";



                // Fill provinces
                dt = objUbigeoBL.ListProvinces();
                dr = dt.NewRow();
                dr["IdProv"] = 0;
                dr["Provincia"] = "--Select--";
                dt.Rows.InsertAt(dr, 0);

                cboProvince.DataSource = dt;
                cboProvince.ValueMember = "IdProv";
                cboProvince.DisplayMember = "Provincia";


                // Fill districts
                dt = objUbigeoBL.ListDistricts();
                dr = dt.NewRow();
                dr["IdDist"] = 0;
                dr["Distrito"] = "--Select--";
                dt.Rows.InsertAt(dr, 0);

                cboDistrict.DataSource = dt;
                cboDistrict.ValueMember = "IdDist";
                cboDistrict.DisplayMember = "Distrito";

                // Fill Classrooms
                dt = objClassroomBL.ListClassrooms();
                dr = dt.NewRow();
                dr["ClassroomID"] = 0;
                dr["ClassroomNumber"] = "--Select--";
                dt.Rows.InsertAt(dr, 0);

                cboClassroom.DataSource = dt;
                cboClassroom.ValueMember = "ClassroomID";
                cboClassroom.DisplayMember = "ClassroomNumber";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This is to repopulate Provinces for the selected department only
            // First we get the selected Department
            DataRowView selectedDepartmentRow = (DataRowView)cboDepartment.SelectedItem;

            if (selectedDepartmentRow != null)
            {

                Int16 selectedDepartmentIndex = Convert.ToInt16(selectedDepartmentRow["IdDepa"]);

                // Then we get the provinces
                DataTable dtProvinces = objUbigeoBL.GetProvincesByDepartment(selectedDepartmentIndex);

                // We clear the current combobox just in case
                cboProvince.DataSource = null;

                // Now we repeat the process from Load but with the new table
                DataRow dr = dtProvinces.NewRow();
                dr["IdProv"] = 0;
                dr["Provincia"] = "--Select--";
                dtProvinces.Rows.InsertAt(dr, 0);

                cboProvince.DataSource = dtProvinces;
                cboProvince.ValueMember = "IdProv";
                cboProvince.DisplayMember = "Provincia";

            }

        }

        private void cboProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedDepartmentRow = (DataRowView)cboDepartment.SelectedItem;
            DataRowView selectedProvinceRow = (DataRowView)cboProvince.SelectedItem;

            if (selectedDepartmentRow != null && selectedProvinceRow != null)
            {

                Int16 selectedDepartmentIndex = Convert.ToInt16(selectedDepartmentRow["IdDepa"]);
                Int16 selectedProvinceIndex = Convert.ToInt16(selectedProvinceRow["IdProv"]);


                // Then we get the districts
                DataTable dtDistricts = objUbigeoBL.GetDistrictsByDepartmentAndProvince(selectedDepartmentIndex, selectedProvinceIndex);

                // We clear the current combobox just in case
                cboDistrict.DataSource = null;

                // Now we repeat the process from Load but with the new table
                DataRow dr = dtDistricts.NewRow();
                dr["IdDist"] = 0;
                dr["Distrito"] = "--Select--";
                dtDistricts.Rows.InsertAt(dr, 0);

                cboDistrict.DataSource = dtDistricts;
                cboDistrict.ValueMember = "IdDist";
                cboDistrict.DisplayMember = "Distrito";

            }
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                dlg.FileName = "";
                dlg.Title = "Add Photo";
                dlg.Multiselect = false;
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
                dlg.ShowDialog();

                if (dlg.FileName != "")
                {
                    pcbStudentPic.Image = Image.FromFile(dlg.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void validateFieldsComplete()
        {
            // First, we validate all text fields are filled
            if (txtFirstName.Text.Trim() == "" ||
                txtSecondName.Text.Trim() == "" ||
                txtFirstLastName.Text.Trim() == "" ||
                txtSecondLastN.Text.Trim() == "" ||
                txtContactMail.Text.Trim() == "" ||
                txtAddress.Text.Trim() == "" ||
                mtbDNI.Text.Trim() == ""
                )
            {
                MessageBox.Show("All text fields must be filled");
            }
            // Second, we validate the combo boxes are all selected correctly
            if (cboDepartment.SelectedIndex == 0 || cboProvince.SelectedIndex == 0 || cboDistrict.SelectedIndex == 0)
            {
                MessageBox.Show("All locations fields must be selected");
            }
            // Then we check a gender button has been selected
            if (optFemale.Checked == false && optMale.Checked == false && optOther.Checked == false)
            {
                MessageBox.Show("Gender must be selected");
            }
            // Same for the listbox
            if (lstCurrentState.SelectedItem == null)
            {
                MessageBox.Show("State must be selected");
            }
            // Finally, we check the photo has been selected
            if (pcbStudentPic.Image == null)
            {
                MessageBox.Show("Photo must be selected");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            validateFieldsComplete();

            // Now we add the student, hopefully
            objStudentBE.FirstName = txtFirstName.Text.Trim();
            objStudentBE.SecondName = txtSecondName.Text.Trim();
            objStudentBE.FirstLastName = txtFirstLastName.Text.Trim();
            objStudentBE.SecondLastName = txtSecondLastN.Text.Trim();
            objStudentBE.ContactMail = txtContactMail.Text.Trim();
            objStudentBE.Address = txtAddress.Text.Trim();
            objStudentBE.DNI_Number = mtbDNI.Text.Trim();
            objStudentBE.DateOfBirth = dtpDateOfBirth.Value;
            objStudentBE.ClassroomId = Convert.ToInt16(cboClassroom.SelectedValue.ToString());
            //Gender
            if (optMale.Checked)
            {
                objStudentBE.Gender = 0;
            }
            else if (optFemale.Checked)
            {
                objStudentBE.Gender = 1;
            }
            else
            {
                objStudentBE.Gender = 2;
            }
            objStudentBE.CurrentState = (Int16)lstCurrentState.SelectedIndex;
            objStudentBE.ID_Ubigeo = cboDepartment.SelectedValue.ToString() + cboProvince.SelectedValue.ToString() + cboDistrict.SelectedValue.ToString();
            objStudentBE.StudentPhoto = File.ReadAllBytes(dlg.FileName);

            objStudentBE.RegisteringUser = clsCredentials.User;

            // Insert, pls insert
            if (objStudentBL.InsertStudent(objStudentBE) == true)
            {
                MessageBox.Show("Student added");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error adding student");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
