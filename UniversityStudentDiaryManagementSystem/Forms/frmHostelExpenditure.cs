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
    public partial class frmHostelExpenditure : Form
    {
        private int selectedIndex;
        public frmHostelExpenditure(int selectedIndex)
        {
            InitializeComponent();
            this.selectedIndex = selectedIndex;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHostelExpenditure_Load(object sender, EventArgs e)
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
        private void clearFields()
        {
            cmbxType.SelectedIndex = 0;
            cmbxMonth.SelectedIndex = 0;
            txbxCharges.Clear();
            rctxtbxRemaks.Clear();
            cmbxType.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string typeHostelExpenditure=cmbxType.SelectedItem.ToString();
            string month=cmbxMonth.SelectedItem.ToString();
            double charges=double.Parse(txbxCharges.Text);
            string remarks=rctxtbxRemaks.Text;

            if (cmbxType.SelectedIndex != 0)
            {
                if (cmbxMonth.SelectedIndex != 0)
                {
                    HostelExpenditure hostelExpenditure = new HostelExpenditure(typeHostelExpenditure, month, charges, remarks);
                    if (HostelExpenditureDL.setIntoHostelExpenditureList(hostelExpenditure))
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
                    cmbxMonth.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please select the type ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbxType.Focus();
            }
        }
    }
}
