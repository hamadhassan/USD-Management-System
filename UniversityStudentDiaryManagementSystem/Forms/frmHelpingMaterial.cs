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
    public partial class frmHelpingMaterial : Form
    {
        private int selectedIndex;
        public frmHelpingMaterial(int selectedIndex)
        {
            InitializeComponent();
            this.selectedIndex = selectedIndex;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmHelpingMaterial_Load(object sender, EventArgs e)
        {
            if (selectedIndex == 1)
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
        private void clearFields()
        {
            cmbxType.SelectedIndex = 0;
            txtbxCharges.Clear();
            rhtextbxRemaks.Clear();
            cmbxType.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbxType.SelectedIndex != 0)
            {
                if (txtbxCharges.Text != String.Empty)
                {
                    string typeHelpingMaterial = cmbxType.SelectedItem.ToString();
                    double charges = double.Parse(txtbxCharges.Text);
                    string remarks = rhtextbxRemaks.Text;
                    HelpingMaterial helpingMaterial = new HelpingMaterial(typeHelpingMaterial, charges, remarks);
                    if (HelpingMaterialDL.setIntoHelpingMaterialList(helpingMaterial))
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
                    MessageBox.Show("Please provide the detail ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbxCharges.Focus();
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
