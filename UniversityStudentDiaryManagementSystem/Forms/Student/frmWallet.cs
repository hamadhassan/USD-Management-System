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
    public partial class frmWallet : Form
    {
        private static string pathImage;
        public frmWallet()
        {
            InitializeComponent();
        }

        private void frmWallet_Load(object sender, EventArgs e)
        {
            try
            {
                lblUserName.Text = frmSignIn.Name;
                Wallet wallet = WalletDL.loadRecordFromFile(PathFile.Wallet);
                rctxtbxComments.Text = wallet.Comments;
                txtbxBalance.Text = WalletDL.updateBalance().ToString();
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

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            File.Copy(pathImage, Path.Combine(@"D:\COMPUTER SCIENCE\PD\USDMS\UniversityStudentDiaryManagementSystem\UserProviedImage\") + Path.GetFileName(pathImage), true);

        }
    }
}
