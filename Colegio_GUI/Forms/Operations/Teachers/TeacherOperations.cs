using Colegio_BL;
using Colegio_GUI.Forms.Operations.Students;
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
    public partial class TeacherOperations : Form
    {

        TeacherBL objTeacherBL = new TeacherBL();
        DataView dtv;

        public TeacherOperations()
        {
            InitializeComponent();
        }

        private void FillDataGridView(String strFilter)
        {
            dtv = new DataView(objTeacherBL.ListTeachers());
            // this is the query to find all names that contain what's on the search bar, not sure if we should start by name or last name yet
            // EDIT : We were requested to start by last name, but considering the colummn NombreCompleto is composed there is no need to change much
            dtv.RowFilter = "NombreCompleto like '%" + strFilter + "%'";
            // we pass on the result view to our datagridview
            dtgData.DataSource = dtv;
            // and for the entries
            lblEntries.Text = dtv.Count.ToString();

            DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dtgData.Columns["StaffPhoto"];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            // We want this column to be set to autosize horizontally
            dtgData.Columns["NombreCompleto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void TeacherOperations_Load(object sender, EventArgs e)
        {
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
            TeacherOperations_Add objTeacherAdd = new TeacherOperations_Add();
            objTeacherAdd.ShowDialog();
            FillDataGridView("");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TeacherOperations_Update objTeacherUpdate = new TeacherOperations_Update();
            Int16 teacherID = Convert.ToInt16(dtgData.CurrentRow.Cells[0].Value.ToString());

            objTeacherUpdate.TeacherID = teacherID;
            objTeacherUpdate.ShowDialog();
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
                    if (objTeacherBL.DeleteTeacher(studentID) == true)
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
