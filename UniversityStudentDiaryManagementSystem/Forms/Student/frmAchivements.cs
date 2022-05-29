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
    public partial class frmAchivements : Form 
    {
        private int selectedIndex;
        private Achivement previous;
        public frmAchivements(int selectedIndex)
        {
            InitializeComponent();
            this.selectedIndex = selectedIndex;
        }
        public frmAchivements(Achivement previous)
        {
            InitializeComponent();
            this.previous = previous;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAchivements_Load(object sender, EventArgs e)
        {
            if (previous != null)
            {
                cmbxType.Text = previous.TypeAchivement;
                txtbxPresentedBy.Text = previous.PresentedBy;
                rctxtbxRemarks.Text = previous.Remakrks;
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
            txtbxPresentedBy.Clear();
            rctxtbxRemarks.Clear();
            cmbxType.Focus();
        }
        private Achivement saveRecord()
        {
            if (cmbxType.SelectedIndex != 0)
            {
                if (txtbxPresentedBy.Text != String.Empty)
                {
                    string typeAchivement = cmbxType.SelectedItem.ToString();
                    string presentedBy = txtbxPresentedBy.Text;
                    string remarks = rctxtbxRemarks.Text;
                    Achivement achivement = new Achivement(typeAchivement, presentedBy, remarks);
                    return achivement;

                }
                else
                {
                    MessageBox.Show("Please provide the detail ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbxPresentedBy.Focus();
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
                if (AchivementDL.EditFromAchivementsList(previous, saveRecord()))
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
                if (AchivementDL.setIntoAchivementsList(saveRecord()))
                {
                    MessageBox.Show("Data Successfully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AchivementDL.storeRecordIntoFile(saveRecord(), FilePath.Achivement);
                    AchivementDL.clearList();
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
