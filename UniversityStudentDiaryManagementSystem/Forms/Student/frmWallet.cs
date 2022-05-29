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
    public partial class frmWallet : Form
    {
        public frmWallet()
        {
            InitializeComponent();
        }

        private void frmWallet_Load(object sender, EventArgs e)
        {
            Wallet wallet = WalletDL.loadRecordFromFile(FilePath.Wallet);
            txtbxBalance.Text =Convert.ToString(wallet.Amount);
            rctxtbxComments.Text = wallet.Comments;

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

        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
