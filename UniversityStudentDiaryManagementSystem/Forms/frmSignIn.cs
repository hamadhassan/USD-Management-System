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


namespace UniversityStudentDiaryManagementSystem
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (combxLoginAs.SelectedIndex != 0)
            {
                string loginAs = combxLoginAs.SelectedItem.ToString();
                string username = txtbxUsername.Text;
                string password = txtbxPassword.Text;
                Credential crediational = new Credential();
                CredentialDL.setIntoListCrediantialList(crediational);
                bool checkCondition = crediational.checkUser(loginAs, username, password, CredentialDL.getCrediationalList());
                if (checkCondition)
                {
                    frmMain main = new frmMain();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username and password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                combxLoginAs.Text = "Select one option";
                txtbxUsername.Clear();
                txtbxPassword.Clear();
            }
            else
            {
                MessageBox.Show("Please select the type ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                combxLoginAs.Focus();
            }
            

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            frmCreateAccount f = new frmCreateAccount();
            f.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {
            combxLoginAs.SelectedIndex = 0;
        }
    }
}
