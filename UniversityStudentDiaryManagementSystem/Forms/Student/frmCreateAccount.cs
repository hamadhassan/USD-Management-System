using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityStudentDiaryManagementSystem.BL;
using UniversityStudentDiaryManagementSystem.DL;
using UniversityStudentDiaryManagementSystem.Path;

namespace UniversityStudentDiaryManagementSystem
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbxRole.SelectedIndex != 0)
                {
                    if (txtbxFirstName.Text != String.Empty)
                    {
                        if (txtbxLastName.Text != String.Empty)
                        {
                            if (txtbxPassword.Text != String.Empty)
                            {
                                if (txtbxUsername.Text != String.Empty)
                                {
                                    string firstName = txtbxFirstName.Text;
                                    string lastName = txtbxLastName.Text;
                                    string username = txtbxUsername.Text;
                                    string password = txtbxPassword.Text;
                                    string role = cmbxRole.SelectedItem.ToString();
                                    Credential newUser = new Credential(firstName, lastName, username, password, role);
                                    CredentialDL.setIntoListCrediantialList(newUser);
                                    CredentialDL.storeRecordIntoFile(newUser, FilePath.Credential);
                                    txtbxFirstName.Clear();
                                    txtbxLastName.Clear();
                                    txtbxPassword.Clear();
                                    txtbxUsername.Clear();
                                    MessageBox.Show("Account Created", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Please provide the detail ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txtbxUsername.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please provide the detail ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtbxPassword.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please provide the detail ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtbxLastName.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please provide the detail ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtbxFirstName.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please select the role ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxRole.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            try
            { 
                 cmbxRole.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
