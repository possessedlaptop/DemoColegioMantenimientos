using Colegio_ADO;
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

namespace Colegio_GUI.Forms.Operations.Teachers
{
    public partial class TeacherOperations_Update : Form
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

        public Int16 TeacherID { get; set; }

        public TeacherOperations_Update()
        {
            InitializeComponent();
        }

        private void TeacherOperations_Update_Load(object sender, EventArgs e)
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

                // -- Here we populate the fields with the selected student from the code --
                objTeacherBE = objTeacherBL.GetTeacherByID(TeacherID);
                lblTeacherID.Text = this.TeacherID.ToString();
                Int16 StaffID = objTeacherBE.StaffID;
                objStaffBE = objStaffBL.GetStaffByID(StaffID);
                // text fields
                txtFirstName.Text = objStaffBE.FirstName;
                txtSecondName.Text = objStaffBE.SecondName;
                txtFirstLastName.Text = objStaffBE.FirstLastName;
                txtSecondLastN.Text = objStaffBE.SecondLastName;
                txtContactMail.Text = objStaffBE.ContactMail;
                txtAddress.Text = objStaffBE.Address;
                txtContactNumber.Text = objStaffBE.ContactNumber;
                dtpDateOfBirth.Value = objStaffBE.DateOfBirth;
                txtQualifications.Text = objTeacherBE.Qualifications;

                // listbox
                lstCurrentState.SelectedIndex = objStaffBE.CurrentState;
                // combo boxes
                cboDepartment.SelectedValue = objStaffBE.ID_Ubigeo.Substring(0, 2);
                cboProvince.SelectedValue = objStaffBE.ID_Ubigeo.Substring(2, 2);
                cboDistrict.SelectedValue = objStaffBE.ID_Ubigeo.Substring(4, 2);
                cboSubject.SelectedValue = objTeacherBE.SubjectTaught;
                // picture box
                if (objStaffBE.StaffPhoto == null)
                {
                    pcbStudentPic.Image = null;
                }
                else
                {
                    MemoryStream ms = new MemoryStream(objStaffBE.StaffPhoto);
                    pcbStudentPic.Image = Image.FromStream(ms);
                }

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
            /* 
            if (pcbStudentPic.Image == null)
            {
                MessageBox.Show("Photo must be selected");
            }
            */
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            validateFieldsComplete();

            objTeacherBE.TeacherID = this.TeacherID;
            // Now we get the StaffID from the element with this teacher ID
            TeacherBE staffIDfromTeach = objTeacherBL.GetTeacherByID(this.TeacherID);
            Int16 StaffID = Convert.ToInt16(staffIDfromTeach.StaffID);

            objStaffBE.StaffID = StaffID;
            objStaffBE.FirstName = txtFirstName.Text.Trim();
            objStaffBE.SecondName = txtSecondName.Text.Trim();
            objStaffBE.FirstLastName = txtFirstLastName.Text.Trim();
            objStaffBE.SecondLastName = txtSecondLastN.Text.Trim();
            objStaffBE.ContactMail = txtContactMail.Text.Trim();
            objStaffBE.Address = txtAddress.Text.Trim();
            objStaffBE.ContactNumber = txtContactNumber.Text.Trim();
            objStaffBE.DateOfBirth = dtpDateOfBirth.Value;
            objStaffBE.OnBoardingStart = dtpOnBoard.Value;
            objTeacherBE.Qualifications = txtQualifications.Text.Trim();
            objTeacherBE.SubjectTaught = Convert.ToInt16(cboSubject.SelectedValue.ToString());

            objStaffBE.CurrentState = (Int16)lstCurrentState.SelectedIndex;
            objStaffBE.ID_Ubigeo = cboDepartment.SelectedValue.ToString() + cboProvince.SelectedValue.ToString() + cboDistrict.SelectedValue.ToString();

            if (string.IsNullOrEmpty(dlg.FileName))
            {
                // if no photo is selected, we use the photo in the ColegioGUI, Resources folder, defaultPhoto.png.
                // We also modified in file properties to be Content and copied on build
                objStaffBE.StaffPhoto = File.ReadAllBytes(Path.Combine(Application.StartupPath, "Resources", "defaultPhoto.png"));
            }
            else
            {
                objStaffBE.StaffPhoto = File.ReadAllBytes(dlg.FileName);
            }

            objStaffBE.LastModifiedUser = clsCredentials.User;
            objTeacherBE.LastModifiedUser = clsCredentials.User;

            if (objStaffBL.UpdateStaff(objStaffBE) == true)
            {
                //MessageBox.Show("Staff updated");

                if (objTeacherBL.UpdateTeacher(objTeacherBE) == true)
                {
                    MessageBox.Show("Teacher updated");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error updating Teacher");
                }


                // this.Close();
            }
            else
            {
                MessageBox.Show("Error updating Staff");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
