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
    public partial class frmHostelExpenditure : Form
    {
        private int selectedIndex;
        private HostelExpenditure previous;
        public frmHostelExpenditure(int selectedIndex)
        {
            InitializeComponent();
            this.selectedIndex = selectedIndex;
        }
        public frmHostelExpenditure(HostelExpenditure previous)
        {
            InitializeComponent();
            this.previous = previous;
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
        private void frmHostelExpenditure_Load(object sender, EventArgs e)
        {
            try
            {
                if (previous != null)
                {
                    cmbxType.Text = previous.TypeHostelExpenditure;
                    cmbxMonth.Text = previous.Month;
                    txbxCharges.Text = previous.Charges.ToString();
                    rctxtbxRemaks.Text = previous.Remarks;
                }
                else
                {
                    cmbxMonth.SelectedIndex = 0;
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
                    else if (selectedIndex == 4)
                    {
                        cmbxType.SelectedIndex = 4;
                    }
                    else if (selectedIndex == 5)
                    {
                        cmbxType.SelectedIndex = 5;
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
            cmbxMonth.SelectedIndex = 0;
            txbxCharges.Clear();
            rctxtbxRemaks.Clear();
            cmbxType.Focus();
        }

        private HostelExpenditure takeHostelExpenditureRecord()
        {
            if (cmbxType.SelectedIndex != 0)
            {
                if (cmbxMonth.SelectedIndex != 0)
                {
                    if (txbxCharges.Text != String.Empty)
                    {
                        string typeHostelExpenditure = cmbxType.SelectedItem.ToString();
                        string month = cmbxMonth.SelectedItem.ToString();
                        double charges = double.Parse(txbxCharges.Text);
                        string remarks = rctxtbxRemaks.Text;
                        if (charges < 0)
                        {
                            throw new Exception("Invalid try");
                        }
                        HostelExpenditure hostelExpenditure = new HostelExpenditure(typeHostelExpenditure, month, charges, remarks);
                        return hostelExpenditure;
                    }
                    else
                    {
                        MessageBox.Show("Please provide the detail ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txbxCharges.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Please select the semester ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxMonth.Focus();
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
                    if (HostelExpenditureDL.EditFromHostelExpenditureList(previous, takeHostelExpenditureRecord()))
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
                    if (HostelExpenditureDL.setIntoHostelExpenditureList(takeHostelExpenditureRecord()))
                    {
                        MessageBox.Show("Data Successfully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HostelExpenditureDL.storeRecordIntoFile(takeHostelExpenditureRecord(), PathFile.HostelExpenditure);
                        HostelExpenditureDL.clearList();
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
