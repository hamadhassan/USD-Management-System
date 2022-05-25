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
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string firstName = txtbxFirstName.Text;
            string lastName = txtbxLastName.Text;
            string username = txtbxUsername.Text;
            string password = txtbxPassword.Text;
            string role = cmbxRole.SelectedItem.ToString();
            Credential newUser = new Credential(firstName, lastName, username, password, role);
            CredentialDL.setIntoListCrediantialList(newUser);
            txtbxFirstName.Clear();
            txtbxLastName.Clear();
            txtbxPassword.Clear();
            txtbxUsername.Clear();
            cmbxRole.Text= "Select one option";
            MessageBox.Show("Account Created", "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void combxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            cmbxRole.SelectedIndex = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
