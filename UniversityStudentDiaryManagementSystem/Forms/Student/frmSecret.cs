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
    public partial class frmSecret : Form
    {
        private int selectedIndex;
        private Secret previous;

        public frmSecret(int selectedIndex)
        {
            InitializeComponent();
            this.selectedIndex = selectedIndex;
        }
        public frmSecret(Secret previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void frmSecret_Load(object sender, EventArgs e)
        {
            if (previous != null)
            {
                cmbxType.Text = previous.TypeSecret;
                rctxtbxComment.Text=previous.Detail;
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
            Close();
        }
        private void clearFields()
        {
            cmbxType.SelectedIndex = 0;
            rctxtbxComment.Clear();
            cmbxType.Focus();
        }
        private Secret takeSecretRecord()
        {
            if (cmbxType.SelectedIndex != 0)
            {
                if (rctxtbxComment.Text != String.Empty)
                {
                    string typeSecret = cmbxType.SelectedItem.ToString();
                    string detail = rctxtbxComment.Text;
                    Secret secret = new Secret(typeSecret, detail);
                    return secret;
                }
                else
                {
                    MessageBox.Show("Please write something", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rctxtbxComment.Focus();
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
                if (SecretDL.EditFromSecretList(previous,takeSecretRecord()))
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
                if (SecretDL.setIntoSecretList(takeSecretRecord()))
                {
                    MessageBox.Show("Data Successfully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SecretDL.storeRecordIntoFile(takeSecretRecord(), FilePath.Secret);
                    SecretDL.clearList();
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
