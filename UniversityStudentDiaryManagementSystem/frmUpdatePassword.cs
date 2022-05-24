using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityStudentDiaryManagementSystem.DL;

namespace UniversityStudentDiaryManagementSystem
{
    public partial class frmUpdatePassword : Form
    {
        public frmUpdatePassword()
        {
            InitializeComponent();
        }

        private void checkBxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBxShowPassword.Checked)
            {
                txtbxOldPassword.UseSystemPasswordChar = false;
                txtbxNewPassword.UseSystemPasswordChar = false;
                txtbxConfirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtbxOldPassword.UseSystemPasswordChar=true;
                txtbxNewPassword.UseSystemPasswordChar = true;
                txtbxConfirmPassword.UseSystemPasswordChar = true;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtbxNewPassword.Text == txtbxConfirmPassword.Text)
            {
                if (CredentialDL.isUserNameExist(txtbxUserName.Text))
                {
                    if(CredentialDL.updatePassword(txtbxOldPassword.Text, txtbxNewPassword.Text))
                    {
                        MessageBox.Show("Password successfully changed");
                        txtbxUserName.Clear();
                        txtbxOldPassword.Clear();
                        txtbxNewPassword.Clear();
                        txtbxConfirmPassword.Clear();
                        txtbxUserName.Focus();
                        txtbxUserName.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Invalid");

                    }
                }
                else
                {
                    MessageBox.Show("Username is not exit");
                }
            }
            else
            {
                MessageBox.Show("Password is not match");
                txtbxNewPassword.Clear();
                txtbxConfirmPassword.Clear();
                txtbxUserName.Focus();
            }
        }
    }
}
