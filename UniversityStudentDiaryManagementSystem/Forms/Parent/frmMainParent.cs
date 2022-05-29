using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityStudentDiaryManagementSystem.Forms;

namespace UniversityStudentDiaryManagementSystem
{
    public partial class frmMainParent : Form
    {
        public frmMainParent()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmWalletParent walletParent=new frmWalletParent();
            walletParent.ShowDialog();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmReport report = new frmReport();
            report.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmMessage message = new frmMessage();
            message.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWalletParent walletParent =new frmWalletParent();
            walletParent.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSignIn signIn = new frmSignIn();
            signIn.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMainParent_Load(object sender, EventArgs e)
        {
            tolstplblCurentDate.Text = DateTime.Now.ToString("dddd dd/MM/yyyy");
            tolstplblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss:tt");
        }

        private void dailyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void monthlyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();

        }
    }
}
