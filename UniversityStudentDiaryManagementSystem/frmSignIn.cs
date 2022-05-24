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
            string loginAs = combxLoginAs.SelectedItem.ToString();
            string username = txtbxUsername.Text;
            string password = txtbxPassword.Text;
            Credential crediational = new Credential();
            CredentialDL.setIntoListCrediantialList(crediational);
            bool checkCondition = crediational.checkUser(loginAs, username, password, CredentialDL.getCrediationalList());
            if (checkCondition)
            {
                MessageBox.Show("Login Successfully", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid username and password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            combxLoginAs.Text = "Select one option";
            txtbxUsername.Clear();
            txtbxPassword.Clear();

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
    }
}
