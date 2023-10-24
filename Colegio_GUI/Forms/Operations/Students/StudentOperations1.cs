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
            dtv.RowFilter = "FirstName like '%" + strFilter + "%'";
            // we pass on the result view to our datagridview
            dtgData.DataSource = dtv;
            // and for the entries
            lblEntries.Text = dtv.Count.ToString();
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
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
