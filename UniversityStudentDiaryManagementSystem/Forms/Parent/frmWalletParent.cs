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
    public partial class frmWalletParent : Form
    {
        public frmWalletParent()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMainParent mainParent = new frmMainParent();
            mainParent.Show();
            Hide();
        }
        private void clearFields()
        {
            txtbxBalance.Clear();
            rctxtbxComments.Clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtbxBalance.Text != String.Empty)
            {
                double amount=double.Parse(txtbxBalance.Text);
                string comment=rctxtbxComments.Text;
                Wallet wallet = new Wallet(amount, comment);
                WalletDL.storeRecordIntoFile(wallet, FilePath.Wallet);
                MessageBox.Show("Data Successfully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearFields();
            }
            else
            {
                MessageBox.Show("Please enter the balance ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbxBalance.Focus();
            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                // textBox1.Text = open.FileName;
            }
        }
    }
}
