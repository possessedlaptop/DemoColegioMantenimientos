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
    public partial class StudentOperations1 : Form
    {

        StudentBL objStudentBL = new StudentBL();
        DataView dtv;

        public StudentOperations1()
        {
            InitializeComponent();
        }

        private void FillDataGridView(String strFilter)
        {
            dtv = new DataView(objStudentBL.ListStudents());
            // this is the query to find all names that contain what's on the search bar, not sure if we should start by name or last name yet
            dtv.RowFilter = "FirstLastName like '%" + strFilter + "%'";
            // we pass on the result view to our datagridview
            dtgData.DataSource = dtv;
            // and for the entries
            lblEntries.Text = dtv.Count.ToString();

            DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dtgData.Columns["StudentPhoto"];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void StudentOperations1_Load(object sender, EventArgs e)
        {
            // We initialize at as empty String
            FillDataGridView("");
        }

        private void txtSearchBar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView(txtSearchBar.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentsOperations1_Add objStudentAdd = new StudentsOperations1_Add();
            objStudentAdd.ShowDialog();
            FillDataGridView("");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StudentOperations1_Update objStudentUpdate = new StudentOperations1_Update();
            Int16 studentID = Convert.ToInt16(dtgData.CurrentRow.Cells[0].Value.ToString());

            objStudentUpdate.StudentID = studentID;
            objStudentUpdate.ShowDialog();
            FillDataGridView("");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult vrpta;
                vrpta = MessageBox.Show("¿Desea Eliminar este registro?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (vrpta == DialogResult.OK)
                {
                    Int16 studentID = Convert.ToInt16(dtgData.CurrentRow.Cells[0].Value.ToString());
                    if (objStudentBL.DeleteStudent(studentID) == true)
                    {
                        // MessageBox.Show("Eliminado Correctamente");
                        FillDataGridView("");
                    }
                }
                else
                {
                    throw new Exception("Registro no se puede eliminar, por estar referenciado en otra tabla");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgData_DoubleClick(object sender, EventArgs e)
        {
            if (dtgData.SelectedRows.Count > 0)
            {
                btnUpdate.PerformClick();
            }
        }
    }
}
