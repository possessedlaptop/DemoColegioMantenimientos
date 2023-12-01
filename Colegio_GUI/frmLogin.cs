using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Colegio_BE;
using Colegio_BL;

namespace Colegio_GUI
{
    public partial class frmLogin : Form
    {

        Int16 loginTries = 0;
        Int16 maxTries = 3;
        // Int16 loginMaxTime = 30;

        UserBE objUserBE = new UserBE();
        UserBL objUserBL = new UserBL();


        public frmLogin()
        {
            InitializeComponent();
        }

        private void ValidateUser()
        {
            txtUser.Text = string.Empty;
            txtPassword.Text = string.Empty;

            if (loginTries == maxTries)
            {
                MessageBox.Show("Maximum number of tries reached, the program will close now",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() != "" && txtPassword.Text.Trim() != "")
            {
                objUserBE = objUserBL.GetUserByID(txtUser.Text.Trim());

                if (objUserBE.Login_User == null)
                {
                    loginTries++;
                    ValidateUser();
                    MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // throw new Exception("User not found");
                }

                else if (objUserBE.Login_User == txtUser.Text.Trim() && objUserBE.Login_Password == txtPassword.Text.Trim())
                {
                    this.Hide();
                    // timer1.Enabled = false; // We haven't added a timer but may do in future

                    // this variables won't change anymore, and will be used in any necessary user operation
                    clsCredentials.User = objUserBE.Login_User;
                    clsCredentials.Password = objUserBE.Login_Password;
                    clsCredentials.Level = objUserBE.Login_Level;

                    MDI_Main objMdiMain = new MDI_Main();
                    objMdiMain.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loginTries++;
                    ValidateUser();
                }
            }
            else
            {
                MessageBox.Show("Please enter user and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginTries++;
                ValidateUser();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            // Para al pulsar Enter acceder al MDI...
            if (e.KeyCode == Keys.Enter)
            {
                btnAccept.PerformClick();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            // Para al pulsar Enter acceder al MDI...
            if (e.KeyCode == Keys.Enter)
            {
                btnAccept.PerformClick();
            }
        }
    }
}
