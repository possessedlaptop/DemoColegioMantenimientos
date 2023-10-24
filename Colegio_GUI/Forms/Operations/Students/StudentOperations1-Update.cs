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
    public partial class StudentOperations1_Update : Form
    {


        StudentBL objStudentBL = new StudentBL();
        StudentBE objStudentBE = new StudentBE();
        // To fill combo boxes
        UbigeoBL objUbigeoBL = new UbigeoBL();
        OpenFileDialog dlg = new OpenFileDialog();
        ClassroomBL objClassroomBL = new ClassroomBL();

        public StudentOperations1_Update()
        {
            InitializeComponent();
        }

        public Int16 StudentID { get; set; }

        private void StudentOperations1_Update_Load(object sender, EventArgs e)
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


                // -- Here we populate the fields with the selected student from the code --
                objStudentBE = objStudentBL.GetStudentByID(StudentID);
                txtStudentID.Text = this.StudentID.ToString();
                // text fields
                txtFirstName.Text = objStudentBE.FirstName;
                txtSecondName.Text = objStudentBE.SecondName;
                txtFirstLastName.Text = objStudentBE.FirstLastName;
                txtSecondLastN.Text = objStudentBE.SecondLastName;
                txtContactMail.Text = objStudentBE.ContactMail;
                txtAddress.Text = objStudentBE.Address;
                mtbDNI.Text = objStudentBE.DNI_Number;
                dtpDateOfBirth.Value = objStudentBE.DateOfBirth;
                // Gender
                if (objStudentBE.Gender == 0)
                {
                    optMale.Checked = true;
                }
                else if (objStudentBE.Gender == 1)
                {
                    optFemale.Checked = true;
                }
                else
                {
                    optOther.Checked = true;
                }
                // listbox
                lstCurrentState.SelectedIndex = objStudentBE.CurrentState;
                // combo boxes
                cboDepartment.SelectedValue = objStudentBE.ID_Ubigeo.Substring(0, 2);
                cboProvince.SelectedValue = objStudentBE.ID_Ubigeo.Substring(2, 2);
                cboDistrict.SelectedValue = objStudentBE.ID_Ubigeo.Substring(4, 2);
                cboClassroom.SelectedValue = objStudentBE.ClassroomId;
                // picture box
                if (objStudentBE.StudentPhoto == null)
                {
                    pcbStudentPic.Image = null;
                }
                else
                {
                    MemoryStream ms = new MemoryStream(objStudentBE.StudentPhoto);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            validateFieldsComplete();

            // Now we add the student, hopefully
            objStudentBE.StudentID = this.StudentID;
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

            if (!string.IsNullOrEmpty(dlg.FileName))
            {
                objStudentBE.StudentPhoto = File.ReadAllBytes(dlg.FileName);
            }
            else
            {
                objStudentBE.StudentPhoto = null;
            }

            objStudentBE.LastModifiedUser = clsCredentials.User;

            if (objStudentBL.UpdateStudent(objStudentBE) == true)
            {
                MessageBox.Show("Student updated");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error updating student");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
