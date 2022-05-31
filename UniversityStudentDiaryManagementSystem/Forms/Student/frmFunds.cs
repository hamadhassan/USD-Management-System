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
    public partial class frmFunds : Form
    {
        private int selectedIndex;
        private Fund previous;
        public frmFunds(int selectedIndex)
        {
            InitializeComponent();
            this.selectedIndex = selectedIndex;
        }
        public frmFunds(Fund previous)
        {
            InitializeComponent();
            this.previous=previous;
        }

        private void frmFunds_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (previous != null)
            {
                cmbxType.Text = previous.TypeFund;
                txtbxAmount.Text=previous.Amount.ToString();
                rctxbxObjective.Text=previous.Remarks;
            }
            else
            {
                if (selectedIndex == 0)
                {
                    cmbxType.SelectedIndex = 0;
                }
                else if (selectedIndex == 1)
                {
                    cmbxType.SelectedIndex = 1;
                }
                else if (selectedIndex == 2)
                {
                    cmbxType.SelectedIndex = 2;
                }
                else if (selectedIndex == 3)
                {
                    cmbxType.SelectedIndex = 3;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
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
        private void clearFields()
        {
            cmbxType.SelectedIndex = 0;
            txtbxAmount.Clear();
            rctxbxObjective.Clear();
            cmbxType.Focus();
        }
        private Fund takeFund()
        {
            if (cmbxType.SelectedIndex != 0)
            {
                if (txtbxAmount.Text != String.Empty)
                {
                    if (!(double.Parse( txtbxAmount.Text)<0))
                    {
                        double amount = double.Parse(txtbxAmount.Text);
                        string typeFund = cmbxType.SelectedItem.ToString();
                        string remarks = rctxbxObjective.Text;
                        if (amount < 0)
                        {
                            throw new Exception("Invalid try");
                        }
                        Fund fund = new Fund(typeFund, amount, remarks);
                        return fund;
                    }
                    else 
                    {
                        MessageBox.Show("Provide the coorect data ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please provide the detail ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbxAmount.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please select the type ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbxType.Focus();
            }
            return null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (previous != null)
                {
                    if (FundDL.EditFromFundList(previous, takeFund()))
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
                    if (FundDL.setIntoFundList(takeFund()))
                    {
                        MessageBox.Show("Data Successfully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FundDL.storeRecordIntoFile(takeFund(), PathFile.Fund);
                        FundDL.clearList();
                        clearFields();
                    }
                    else
                    {
                        MessageBox.Show("Error while storing data ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        clearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
