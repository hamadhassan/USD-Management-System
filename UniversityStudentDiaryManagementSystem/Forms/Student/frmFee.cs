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
    public partial class frmFee : Form
    {
        private int selectedIndex;
        private Fee previous;
        public frmFee(int selectedIndex)
        {
            InitializeComponent();
            this.selectedIndex = selectedIndex;
        }
        public frmFee(Fee previous)
        {
            InitializeComponent();
            this.previous = previous;
        }
        private void btnAcademicClose_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmFee_Load(object sender, EventArgs e)
        {
            try
            {
                if (previous != null)
                {
                    cmbxType.Text = previous.FeeType;
                    cmbxSemester.Text = previous.Semester;
                    txtbxChallanNo.Text = previous.ChallanNo;
                    txtbxAmount.Text = previous.Amount.ToString();
                    rchtxtbxRemarks.Text = previous.Remarks;
                    dateTimePicker.Text = previous.Date;
                }
                else
                {
                    cmbxSemester.SelectedIndex = 0;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private Fee takeFee()
        {

            if (cmbxType.SelectedIndex != 0)
            {
                if (cmbxSemester.SelectedIndex != 0)
                {
                    if (txtbxChallanNo.Text != String.Empty || txtbxAmount.Text != String.Empty)
                    {
                        string feeType = cmbxType.SelectedItem.ToString();
                        string semester = cmbxSemester.SelectedItem.ToString();
                        string challanNo = txtbxChallanNo.Text;
                        double amount = double.Parse(txtbxAmount.Text);
                        string date = dateTimePicker.Text;
                        string remarks = rchtxtbxRemarks.Text;
                        Fee fee = new Fee(feeType, semester, challanNo, amount, date, remarks);
                        return fee;
                    }
                    else
                    {
                        MessageBox.Show("Please provide the all detail ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            return null;
        }
        private void btnSaveAcademic_Click(object sender, EventArgs e)
        {
            try
            {
                if (previous != null)
                {
                    if (FeeDL.EditFromFeeList(previous, takeFee()))
                    {
                        MessageBox.Show("Data Successfully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Error while storing data ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clearFields();
                    }
                }
                else
                {
                    if (FeeDL.setIntoFeeList(takeFee()))
                    {
                        MessageBox.Show("Data Successfully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FeeDL.storeRecordIntoFile(takeFee(), PathFile.Fee);
                        FeeDL.clearList();
                        clearFields();
                    }
                    else
                    {
                        MessageBox.Show("Error while storing data ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clearFields();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
