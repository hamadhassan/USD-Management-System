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
    public partial class frmFee : Form
    {
        private int selectedIndex;
        public frmFee(int selectedIndex)
        {
            InitializeComponent();
            this.selectedIndex = selectedIndex;
        }
        private void btnAcademicClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void clearFields()
        {
            cmbxType.SelectedIndex = 0;
            cmbxSemester.SelectedIndex = 0;
            txtbxChallanNo.Clear();
            txtbxAmount.Clear();
            rchtxtbxRemarks.Clear();
            DateTime today = DateTime.Today;
            dateTimePicker.Text = today.ToString();
            cmbxType.Focus();
        }
        private void btnSaveAcademic_Click(object sender, EventArgs e)
        {
            string feeType=cmbxType.SelectedItem.ToString();
            string semester=cmbxSemester.SelectedItem.ToString();
            string challanNo=txtbxChallanNo.Text;
            double amount=double.Parse(txtbxAmount.Text);
            string date=dateTimePicker.Text;
            string remarks=rchtxtbxRemarks.Text;
            if (cmbxType.SelectedIndex != 0)
            {
                if (cmbxSemester.SelectedIndex != 0)
                {
                   Fee fee=new Fee(feeType,semester,challanNo,amount,date,remarks);
                    if (FeeDL.setIntoFeeList(fee))
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
                    MessageBox.Show("Please select the semester ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxSemester.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please select the type ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbxType.Focus();
            }
        }

        private void frmFee_Load(object sender, EventArgs e)
        {
            if (selectedIndex == 1)
            {
                cmbxType.SelectedIndex = 1;
            }
            else if (selectedIndex == 2)
            {
                cmbxType.SelectedIndex = 2;
            }
        }
    }
}
