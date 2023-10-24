using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Colegio_GUI.Forms.Operations.Enrollments;
using Colegio_GUI.Forms.Operations.Students;
using Colegio_GUI.Forms.Operations.Teachers;

// To show device in ToolStrip
using Microsoft.VisualBasic.Devices;

namespace Colegio_GUI
{
    public partial class MDI_Main : Form
    {
        Computer myComputer = new Computer();
        String myNet = "";
        TimeSpan loggedTime;

        public MDI_Main()
        {
            InitializeComponent();
        }

        private void MDI_Main_Resize(object sender, EventArgs e)
        {
            // To avoid graphic glitches on resizing
            this.Refresh();
        }

        private void MDI_Main_Load(object sender, EventArgs e)
        {
            // Info in ToolStrip
            if (myComputer.Network.IsAvailable == true)
            {
                myNet = "Available";
            }
            else
            {
                myNet = "Not Available";
            }
            lblSystem.Text = "System: " + myComputer.Name + "." + myNet;

            // For the logging Time
            loggedTime = DateTime.Now.TimeOfDay;

            // Now for the user
            this.lblUser.Text = "User: " + clsCredentials.User;

            // and this is for authorizated functions
            if (clsCredentials.Level == 1) // Admin level
            {
                operationsToolStripMenuItem.Visible = true;
                searchToolStripMenuItem.Visible = true;
                listsToolStripMenuItem.Visible = true;
                exitToolStripMenuItem.Visible = true;
            }
            else if (clsCredentials.Level == 2) // Operator level
            {
                operationsToolStripMenuItem.Visible = true;
                searchToolStripMenuItem.Visible = true;
                listsToolStripMenuItem.Visible = false;
                exitToolStripMenuItem.Visible = true;
            }
            else // other levels, from 3 to 5 (only 3 has been given to teachers)
            {
                operationsToolStripMenuItem.Visible = false;
                searchToolStripMenuItem.Visible = true;
                listsToolStripMenuItem.Visible = false;
                exitToolStripMenuItem.Visible = true;
            }
        }

        private void MDI_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void closeTheProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Text to show later
            this.Text = "Interfaz de Colegio - Logged Time - " + DateTime.Now.ToString();

            lblSession.Text = "Session: " + DateTime.Now.TimeOfDay
                .Subtract(loggedTime).ToString().Substring(0, 8); //hh-mm-ss
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentOperations1 objStudentOperations1 = new StudentOperations1();
            objStudentOperations1.MdiParent = this;
            objStudentOperations1.Show();
        }

        private void teachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherOperations teacherOperations = new TeacherOperations();
            teacherOperations.MdiParent = this;
            teacherOperations.Show();
        }

        private void enrollmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnrollmentOperations enrollmentOperations = new EnrollmentOperations();
            enrollmentOperations.MdiParent = this;
            enrollmentOperations.Show();
        }
    }
}
