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

namespace Colegio_GUI.Forms.Operations.Enrollments
{
    public partial class EnrollmentOperations_Add : Form
    {

        EnrollmentBE objEnrollmentBE = new EnrollmentBE();
        EnrollmentBL objEnrollmentBL = new EnrollmentBL();

        // Combos
        RecepcionistBL objRecepcionistBL = new RecepcionistBL();
        GradeBL objGradeBL = new GradeBL();

        // Testing
        StudentBL objStudentBL = new StudentBL();

        public EnrollmentOperations_Add()
        {
            InitializeComponent();
        }

        private void EnrollmentOperations_Add_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                DataRow dr;

                // Fill Grades
                dt = objGradeBL.ListGrades();
                dr = dt.NewRow();
                dr["GradeID"] = 0;
                dr["GradeName"] = "--Select--";
                dt.Rows.InsertAt(dr, 0);

                cboGrade.DataSource = dt;
                cboGrade.ValueMember = "GradeID";
                cboGrade.DisplayMember = "GradeName";

                /*
                // Fill Recepcionist
                dt = objRecepcionistBL.ListRecepcionists();
                dr = dt.NewRow();
                dr["RecepcionistID"] = 0;
                dr["NombreCompleto"] = "--Select--";
                dt.Rows.InsertAt(dr, 0);

                cboRecepcionist.DataSource = dt;
                cboRecepcionist.ValueMember = "RecepcionistID";
                cboRecepcionist.DisplayMember = "NombreCompleto";
                */

                // we populate the recepcionist combo box with the selected recepcionist according to credentials
                txtRecepcionist.Text = clsCredentials.User;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void validateFieldsComplete()
        {
            // First, we validate all text fields are filled
            if (txtStudentID.Text.Trim() == "")
            {
                MessageBox.Show("Student Code must be filled");
            }
            // Same for the listbox
            if (lstPayment.SelectedItem == null)
            {
                MessageBox.Show("State must be selected");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            validateFieldsComplete();

            objEnrollmentBE.StudentID = Convert.ToInt16(txtStudentID.Text.Trim());
            objEnrollmentBE.GradeID = Convert.ToInt16(cboGrade.SelectedValue);
            objEnrollmentBE.PaymentStatus = Convert.ToInt16(lstPayment.SelectedValue);
            // objEnrollmentBE.RecepcionistId = Convert.ToInt16(cboRecepcionist.SelectedValue);
            // TODO: Implement a stored procedure that searches for the recepcionist ID based on the user and returns a recepcionist ID
            switch (clsCredentials.User)
            {
                case "cgutierrez":
                    objEnrollmentBE.RecepcionistId = 1;
                    break;
                case "rcastro":
                    objEnrollmentBE.RecepcionistId = 2;
                    break;
                default:
                    objEnrollmentBE.RecepcionistId = 1;
                    break;
            }
            objEnrollmentBE.DateCreated = dateTimePicker1.Value;
            objEnrollmentBE.RegisteringUser = clsCredentials.User;

            if (objEnrollmentBL.InsertEnrollment(objEnrollmentBE) == true)
            {
                //MessageBox.Show("Enrollment Added");
                this.Close();
            }
            else
            {
                MessageBox.Show("Enrollment Not Added");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtStudentID_TextChanged(object sender, EventArgs e)
        {
            // We want to show in the lblStudentName the name of the student based on the StudentID selected
            if (txtStudentID.Text.Trim() != "")
            {
                if (Int16.TryParse(txtStudentID.Text.Trim(), out Int16 studentID))
                {
                    // Call a method to retrieve the student's name based on the StudentID
                    StudentBE student = objStudentBL.GetStudentByID(studentID);

                    if (student != null)
                    {
                        // Display the student's name in lblStudentName
                        lblStudentName.Text = student.FirstName + " " + student.SecondName + " " + student.FirstLastName + " " + student.SecondLastName;
                    }
                    else
                    {
                        // Student not found, I mean, just in case
                        lblStudentName.Text = "Student not found";
                    }
                }
                else
                {
                    // Clear lblStudentName if an invalid StudentID is entered
                    lblStudentName.Text = string.Empty;
                }
            }
        }
    }
}
