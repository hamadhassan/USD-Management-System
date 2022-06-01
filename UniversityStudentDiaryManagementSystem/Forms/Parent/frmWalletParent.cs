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
using System.IO;

namespace UniversityStudentDiaryManagementSystem
{
    public partial class frmWalletParent : Form
    {
        private static string pathImage;
        public frmWalletParent()
        {
            InitializeComponent();
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
        private void clearFields()
        {
            try
            {
                txtbxBalance.Clear();
                rctxtbxComments.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbxBalance.Text != String.Empty)
                {
                    double amount = double.Parse(txtbxBalance.Text);
                    if (amount < 0)
                    {
                        throw new Exception("Invalid try");
                    }
                    string comment = rctxtbxComments.Text;
                    Wallet wallet = new Wallet(amount, comment);
                    WalletDL.storeRecordIntoFile(wallet, PathFile.Wallet);
                    MessageBox.Show("Data Successfully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                }
                else
                {
                    MessageBox.Show("Please enter the balance ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbxBalance.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(open.FileName);
                    pathImage = open.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmWalletParent_Load(object sender, EventArgs e)
        {
            lblUserName.Text = frmSignIn.Name;
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            File.Copy(pathImage, Path.Combine(@"D:\COMPUTER SCIENCE\PD\USDMS\UniversityStudentDiaryManagementSystem\UserProviedImage\")+Path.GetFileName(pathImage),true);
        }
    }
}
