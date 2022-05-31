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
using UniversityStudentDiaryManagementSystem.Paths;
namespace UniversityStudentDiaryManagementSystem
{
    public partial class frmSignIn : Form
    {
        private static string name;
        public static string Name { get => name; set => name = value; }

        public frmSignIn()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (combxLoginAs.SelectedIndex != 0 || txtbxPassword.Text != String.Empty || txtbxUsername.Text != String.Empty)
                {
                    string loginAs = combxLoginAs.SelectedItem.ToString();
                    string username = txtbxUsername.Text;
                    string password = txtbxPassword.Text;
                    Credential crediational = new Credential();
                    // CredentialDL.setIntoListCrediantialList(crediational);
                    bool checkCondition = crediational.checkUser(loginAs, username, password, CredentialDL.getCrediationalList());
                    if (checkCondition)
                    {
                        Credential obj = crediational.checkRole(loginAs, username, password, CredentialDL.getCrediationalList());
                        if (obj.Role == "Student")
                        {
                            Name = obj.FirstName + " " + obj.LastName;
                            frmMain main = new frmMain();
                            main.Show();
                            Hide();
                        }
                        else if(obj.Role== "Parent")
                        {
                            Name = obj.FirstName + " " + obj.LastName;
                            frmMainParent mainParent = new frmMainParent();
                            mainParent.Show();
                            Hide();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username and password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    combxLoginAs.SelectedIndex = 0;
                    txtbxUsername.Clear();
                    txtbxPassword.Clear();
                }
                else
                {
                    MessageBox.Show("Please select the type ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    combxLoginAs.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                frmCreateAccount f = new frmCreateAccount();
                f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {
            try
            {
                combxLoginAs.SelectedIndex = 0;
                CredentialDL.clearList();
                CredentialDL.loadRecordFromFile(PathFile.Credential);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
