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
    public partial class frmAcivities : Form
    {
        private int selectedIndex;
        public frmAcivities(int selectedIndex)
        {
            InitializeComponent();
            this.selectedIndex = selectedIndex;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAcivities_Load(object sender, EventArgs e)
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
        private void clearFields()
        {
            cmbxType.SelectedIndex = 0;
            txtbxMinutes.Clear();
            rctxtbxRemarks.Clear();
            cmbxType.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string typeAcitivity = cmbxType.SelectedItem.ToString();
            string minutes= txtbxMinutes.Text;
            string remarks= rctxtbxRemarks.Text;
            if (cmbxType.SelectedIndex != 0)
            {
                Activities activities=new Activities(typeAcitivity, minutes, remarks);
                if (ActivitiesDL.setIntoActivitiesList(activities))
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
                MessageBox.Show("Please select the type ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbxType.Focus();
            }
        }
    }
}
