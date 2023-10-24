using Colegio_BE;
using Colegio_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Colegio_GUI.Forms.Operations.Teachers
{
    public partial class TeacherOperations_Add : Form
    {

        StaffBL objStaffBL = new StaffBL();
        StaffBE objStaffBE = new StaffBE();

        TeacherBL objTeacherBL = new TeacherBL();
        TeacherBE objTeacherBE = new TeacherBE();

        // To fill combo boxes
        UbigeoBL objUbigeoBL = new UbigeoBL();
        SubjectBL objSubjectBL = new SubjectBL();
        // To allow uploading pictures
        OpenFileDialog dlg = new OpenFileDialog();

        public TeacherOperations_Add()
        {
            InitializeComponent();
        }

        private void TeacherOperations_Add_Load(object sender, EventArgs e)
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

                // Fill Subjects
                dt = objSubjectBL.ListSubjects();
                dr = dt.NewRow();
                dr["SubjectID"] = 0;
                dr["SubjectName"] = "--Select--";
                dt.Rows.InsertAt(dr, 0);

                cboSubject.DataSource = dt;
                cboSubject.ValueMember = "SubjectID";
                cboSubject.DisplayMember = "SubjectName";


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
                txtContactNumber.Text.Trim() == "" ||
                txtQualifications.Text.Trim() == ""
                )
            {
                MessageBox.Show("All text fields must be filled");
            }
            // Second, we validate the combo boxes are all selected correctly
            if (cboDepartment.SelectedIndex == 0 || cboProvince.SelectedIndex == 0 || cboDistrict.SelectedIndex == 0)
            {
                MessageBox.Show("All locations fields must be selected");
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
            objStaffBE.FirstName = txtFirstName.Text.Trim();
            objStaffBE.SecondName = txtSecondName.Text.Trim();
            objStaffBE.FirstLastName = txtFirstLastName.Text.Trim();
            objStaffBE.SecondLastName = txtSecondLastN.Text.Trim();
            objStaffBE.Address = txtAddress.Text.Trim();
            objStaffBE.ContactMail = txtContactMail.Text.Trim();
            objStaffBE.ContactNumber = txtContactNumber.Text.Trim();
            objStaffBE.DateOfBirth = dtpDateOfBirth.Value;
            objStaffBE.OnBoardingStart = dtpOnBoard.Value;
            objStaffBE.CurrentState = (Int16)lstCurrentState.SelectedIndex;
            objStaffBE.ID_Ubigeo = cboDepartment.SelectedValue.ToString() + cboProvince.SelectedValue.ToString() + cboDistrict.SelectedValue.ToString();
            objStaffBE.RegisteringUser = clsCredentials.User;
            objStaffBE.StaffPhoto = File.ReadAllBytes(dlg.FileName);
            objStaffBE.IntRole = 0; // Since this is only to add teachers we'll set it here

            if (objStaffBL.InsertStaff(objStaffBE) == true)
            {

                // MessageBox.Show("Student added");

                StaffBE lastStaffID = objStaffBL.GetLastStaffIDFromTeacher();
                // We need to get the value from the column StaffID from the returned table
                Int16 staffID = Convert.ToInt16(lastStaffID.StaffID);
                objTeacherBE.StaffID = staffID;
                objTeacherBE.Qualifications = txtQualifications.Text.Trim();
                objTeacherBE.SubjectTaught = Convert.ToInt16(cboSubject.SelectedValue.ToString());
                objTeacherBE.RegisteringUser = clsCredentials.User;

                if (objTeacherBL.InsertTeacher(objTeacherBE) == true)
                {
                    MessageBox.Show("Teacher added");
                }
                else
                {
                    MessageBox.Show("Error adding teacher");
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Error adding Staff");
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
