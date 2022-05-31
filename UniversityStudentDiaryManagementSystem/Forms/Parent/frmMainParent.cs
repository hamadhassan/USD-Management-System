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
            try
            {
                frmWalletParent walletParent = new frmWalletParent();
                walletParent.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                frmMessage message = new frmMessage();
                message.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmWalletParent walletParent = new frmWalletParent();
                walletParent.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSignIn signIn = new frmSignIn();
                signIn.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmMainParent_Load(object sender, EventArgs e)
        {
            try
            {
                tolstplblCurentDate.Text = DateTime.Now.ToString("dddd dd/MM/yyyy");
                tolstplblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss:tt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmAbout about = new frmAbout();
                about.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        #region Fee
        private void academicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmFeeParent feeParent = new frmFeeParent();
                feeParent.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void hostelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmFeeParent feeParent = new frmFeeParent();
                feeParent.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion
    }
}

