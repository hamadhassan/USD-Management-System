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
using UniversityStudentDiaryManagementSystem.Path;


namespace UniversityStudentDiaryManagementSystem
{
    public partial class frmAcivities : Form
    {
        private int selectedIndex;
        private Activities previous;
        public frmAcivities(int selectedIndex)
        {
            InitializeComponent();
            this.selectedIndex = selectedIndex;
        }
        public frmAcivities(Activities previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAcivities_Load(object sender, EventArgs e)
        {
            if (previous != null)
            {
                cmbxType.Text = previous.TypeAcitivity;
                txtbxMinutes.Text = previous.Minutes;
                rctxtbxRemarks.Text = previous.Remarks;
            }
            if (selectedIndex == 1)
            {
                cmbxType.SelectedIndex = 1;
            }
            else if (selectedIndex == 2)
            {
                cmbxType.SelectedIndex = 2;
            }
        }
        private void clearFields()
        {
            cmbxType.SelectedIndex = 0;
            txtbxMinutes.Clear();
            rctxtbxRemarks.Clear();
            cmbxType.Focus();
        }
        private Activities saveRecord()
        {
            if (cmbxType.SelectedIndex != 0)
            {
                if (txtbxMinutes.Text != String.Empty)
                {
                    string typeAcitivity = cmbxType.SelectedItem.ToString();
                    string minutes = txtbxMinutes.Text;
                    string remarks = rctxtbxRemarks.Text;
                    Activities activities = new Activities(typeAcitivity, minutes, remarks);
                    return activities;
                }
                else
                {
                    MessageBox.Show("Please provide the detail ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbxMinutes.Focus();
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
            if (previous != null)
            {
                if (ActivitiesDL.EditFromActivitiesList(previous, saveRecord()))
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
                if (ActivitiesDL.setIntoActivitiesList(saveRecord()))
                {
                    MessageBox.Show("Data Successfully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActivitiesDL.storeRecordIntoFile(saveRecord(), FilePath.Activities);
                    ActivitiesDL.clearList();
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
