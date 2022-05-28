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
        private Phone previous;
        public frmPhone()
        {
            InitializeComponent();
        }
        public frmPhone(Phone previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmPhone_Load(object sender, EventArgs e)
        {
            if(previous != null)
            {
                txtbxAmount.Text=previous.Amount.ToString();
                rctxtbxRemarks.Text=previous.Remarks;
            }
        }
        private void clearFields()
        {
            txtbxAmount.Clear();
            rctxtbxRemarks.Clear();
            txtbxAmount.Focus();

        }
        private Phone takePhoneRecord()
        {
            if (txtbxAmount.Text != String.Empty)
            {
                double amount = double.Parse(txtbxAmount.Text);
                string remarks = rctxtbxRemarks.Text;
                Phone phone = new Phone(amount, remarks);
                return phone;
            }
            else
            {
                MessageBox.Show("Please enter the amount ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbxAmount.Focus();
            }
            return null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (previous != null)
            {
                if (PhoneDL.EditFromPhoneList(previous,takePhoneRecord()))
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
                if (PhoneDL.setIntoPhoneList(takePhoneRecord()))
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
        }
    }
}
