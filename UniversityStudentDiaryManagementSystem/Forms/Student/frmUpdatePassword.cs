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
using UniversityStudentDiaryManagementSystem.Path;

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
            if (cmbxRole.SelectedIndex != 0)
            {
                if (txtbxNewPassword.Text == txtbxConfirmPassword.Text)
                {
                    if (CredentialDL.isUserNameExist(txtbxUserName.Text))
                    {
                        if (CredentialDL.updatePassword(txtbxOldPassword.Text, txtbxNewPassword.Text, txtbxUserName.Text, cmbxRole.SelectedItem.ToString()))
                        {

                            CredentialDL.storeAllRecordIntoFile(FilePath.Credential);
                            MessageBox.Show("Password successfully changed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtbxUserName.Clear();
                            txtbxOldPassword.Clear();
                            txtbxNewPassword.Clear();
                            txtbxConfirmPassword.Clear();
                            txtbxUserName.Focus();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username and password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Username not exit ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
                else
                {
                    MessageBox.Show("Password not match", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtbxNewPassword.Clear();
                    txtbxConfirmPassword.Clear();
                    txtbxUserName.Focus();
                }
            }
            
        }

        private void frmUpdatePassword_Load(object sender, EventArgs e)
        {
            cmbxRole.SelectedIndex = 0;
           CredentialDL.clearList();
           CredentialDL.loadRecordFromFile(FilePath.Credential);
        }
    }
}
