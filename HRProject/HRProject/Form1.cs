using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRProject
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUser.Text != "")
                {
                    txtPW.Focus();
                }
                else
                {
                    MessageBox.Show("Please Enter the User ID!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPW.Text != "")
                {
                    butLogin.Focus();   
                }
                else
                {
                    MessageBox.Show("Please Enter the Valied Password!", "Invalied Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "" && txtPW.Text != "")
            {
                if (txtUser.Text =="user" && txtPW.Text =="123" )
                {
                    this.Visible = false;
                    FrmMain FMain = new FrmMain();
                    FMain.Show();
                    return;
                }
                else
                {
                    MessageBox.Show("Please Enter the Correct User ID and Correct Password!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Text = "";
                    txtPW.Text = "";
                    txtUser.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Fill the User ID and Password!", "MESSAGE BOX", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Text = "";
                txtPW.Text = "";
                txtUser.Focus();
                return;
            }
        }
    }
}
