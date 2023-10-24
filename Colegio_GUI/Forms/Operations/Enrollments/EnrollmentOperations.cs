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
    public partial class EnrollmentOperations : Form
    {

        EnrollmentBL objEnrollmentBL = new EnrollmentBL();
        DataView dtv;

        public EnrollmentOperations()
        {
            InitializeComponent();
        }

        private void FillDataGridView(String strFilter)
        {
            dtv = new DataView(objEnrollmentBL.ListEnrollments());
            // this is the query to find all names that contain what's on the search bar, not sure if we should start by name or last name yet
            dtv.RowFilter = "NombreAlumno like '%" + strFilter + "%'";
            // we pass on the result view to our datagridview
            dtgData.DataSource = dtv;
            // and for the entries
            lblEntries.Text = dtv.Count.ToString();
        }

        private void EnrollmentOperations_Load(object sender, EventArgs e)
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
            EnrollmentOperations_Add enrollmentOperations_Add = new EnrollmentOperations_Add();
            enrollmentOperations_Add.ShowDialog();
            FillDataGridView("");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EnrollmentOperations_Update enrollmentOperations_Update = new EnrollmentOperations_Update();
            Int16 enrollmentID = Convert.ToInt16(dtgData.CurrentRow.Cells[0].Value.ToString());
            enrollmentOperations_Update.enrollmentID = enrollmentID;
            enrollmentOperations_Update.ShowDialog();
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
                    Int16 enrollmentID = Convert.ToInt16(dtgData.CurrentRow.Cells[0].Value.ToString());
                    if (objEnrollmentBL.DeleteEnrollment(enrollmentID) == true)
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
