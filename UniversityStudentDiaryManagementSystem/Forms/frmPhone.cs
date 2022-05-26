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
    public partial class frmPhone : Form
    {
        public frmPhone()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void clearFields()
        {
            txtbxAmount.Clear();
            rctxtbxRemarks.Clear();
            txtbxAmount.Focus();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtbxAmount.Text!=String.Empty)
            {
                double amount = double.Parse(txtbxAmount.Text);
                string remarks = rctxtbxRemarks.Text;
                Phone phone = new Phone(amount, remarks);
                if (PhoneDL.setIntoPhoneList(phone))
                {
                    MessageBox.Show("Data Successfully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                }
                else
                {
                    MessageBox.Show("Error while storing data ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearFields();
                }
            }
            else
            {
                MessageBox.Show("Please enter the amount ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbxAmount.Focus();
            }
        }
    }
}
