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
    public partial class frmHelpingMaterial : Form
    {
        private int selectedIndex;
        private HelpingMaterial previous;
        public frmHelpingMaterial(int selectedIndex)
        {
            InitializeComponent();
            this.selectedIndex = selectedIndex;
        }
        public frmHelpingMaterial (HelpingMaterial previous)
        {
            InitializeComponent();
            this.previous = previous;
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
        private void frmHelpingMaterial_Load(object sender, EventArgs e)
        {
            try
            {
                if (previous != null)
                {
                    cmbxType.Text = previous.TypeHelpingMaterial;
                    txtbxCharges.Text = previous.Charges.ToString();
                    rhtextbxRemaks.Text = previous.Remarks;
                }
                else
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearFields()
        {
            cmbxType.SelectedIndex = 0;
            txtbxCharges.Clear();
            rhtextbxRemaks.Clear();
            cmbxType.Focus();
        }
        private HelpingMaterial takeHelpingMaterialRecord()
        {
            if (cmbxType.SelectedIndex != 0)
            {
                if (txtbxCharges.Text != String.Empty)
                {
                    string typeHelpingMaterial = cmbxType.SelectedItem.ToString();
                    double charges = double.Parse(txtbxCharges.Text);
                    string remarks = rhtextbxRemaks.Text;
                    if (charges < 0)
                    {
                        throw new Exception("Invalid try");
                    }
                    HelpingMaterial helpingMaterial = new HelpingMaterial(typeHelpingMaterial, charges, remarks);
                    return helpingMaterial;
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
            return null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (takeHelpingMaterialRecord() != null)
                {
                    if (previous != null)
                    {
                        if (HelpingMaterialDL.EditFromhelpingMaterialList(previous, takeHelpingMaterialRecord()))
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
                        if (HelpingMaterialDL.setIntoHelpingMaterialList(takeHelpingMaterialRecord()))
                        {
                            MessageBox.Show("Data Successfully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            HelpingMaterialDL.storeRecordIntoFile(takeHelpingMaterialRecord(), PathFile.HelpingMaterial);
                            HelpingMaterialDL.clearList();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
