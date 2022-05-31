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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        #region DataTime
        private void timerCurrentDateTime_Tick(object sender, EventArgs e)
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
        #endregion

        #region Credientail
        private void createAUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCreateAccount frmCreateAccount = new frmCreateAccount();
                frmCreateAccount.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmUpdatePassword updatePassword = new frmUpdatePassword();
                updatePassword.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
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
        #endregion

        #region Wallet
        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmWallet wallet = new frmWallet();
                wallet.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Fee
        private void academicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmFee acdemicFee = new frmFee(1);
                acdemicFee.ShowDialog();
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
                frmFee acdemicFee = new frmFee(2);
                acdemicFee.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


        #region Meal
        private void breakfastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmMeal meal = new frmMeal(1);
                meal.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lunchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmMeal meal = new frmMeal(2);
                meal.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dinnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmMeal meal = new frmMeal(3);
                meal.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void hangOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmMeal meal = new frmMeal(4);
                meal.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Expebditure
        private void messMealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmHostelExpenditure hostelExpenditure = new frmHostelExpenditure(1);
                hostelExpenditure.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmHostelExpenditure hostelExpenditure = new frmHostelExpenditure(2);
                hostelExpenditure.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void roomRenovationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmHostelExpenditure hostelExpenditure = new frmHostelExpenditure(3);
                hostelExpenditure.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void laundaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmHostelExpenditure hostelExpenditure = new frmHostelExpenditure(4);
                hostelExpenditure.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmHostelExpenditure hostelExpenditure = new frmHostelExpenditure(5);
                hostelExpenditure.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Helping material
        private void printingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmHelpingMaterial helpingMaterial = new frmHelpingMaterial(1);
                helpingMaterial.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void copyingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmHelpingMaterial helpingMaterial = new frmHelpingMaterial(2);
                helpingMaterial.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Fund
        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmFunds funds=new frmFunds(1);
                funds.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void socitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmFunds funds = new frmFunds(2);
                funds.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void socialWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmFunds funds = new frmFunds(3);
                funds.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Goals
        private void dailyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void quatilyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void yearlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            { }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion 

        #region Package 
        private void packagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPhone phone = new frmPhone();
                phone.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
       
        #region Book
        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBooks books = new frmBooks(1);
                books.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmBooks books = new frmBooks(2);
                books.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Trasport
        private void busToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmTransport transport = new frmTransport(1);
                transport.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmTransport transport = new frmTransport(2);
                transport.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region activities
        private void sportiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAcivities acivities = new frmAcivities(1);
                acivities.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void socialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAcivities acivities = new frmAcivities(2);
                acivities.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Secret
        private void quotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSecret secret = new frmSecret(1);
                secret.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSecret secret = new frmSecret(2);
                secret.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSecret secret = new frmSecret(3);
                secret.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Achivements
        private void coToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAchivements achivements = new frmAchivements(1);
                achivements.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                frmAchivements achivements = new frmAchivements(2);
                achivements.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resultToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmResult result = new frmResult();
                result.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Tool Srip Button 
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                frmWallet wallet = new frmWallet();
                wallet.ShowDialog();
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

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                frmMeal meal = new frmMeal(0);
                meal.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                frmHostelExpenditure hostelExpenditure = new frmHostelExpenditure(0);
                hostelExpenditure.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            try
            {
                frmHelpingMaterial helpingMaterial = new frmHelpingMaterial(1);
                helpingMaterial.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            try
            {
                frmHelpingMaterial helpingMaterial = new frmHelpingMaterial(2);
                helpingMaterial.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            try
            {
                frmFunds funds = new frmFunds(0);
                funds.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            try
            {
                frmPhone phone = new frmPhone();
                phone.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
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
        #endregion

        #region File
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmUserFile file = new frmUserFile();
                file.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmUserFile file = new frmUserFile();
                file.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmUserFile file = new frmUserFile();
                file.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Close 

        private void toolStripButton11_Click(object sender, EventArgs e)
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
        #endregion

        #region Notification
        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            try
            {
                frmNotification notification = new frmNotification();
                notification.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            try
            {
                frmSecret secret = new frmSecret(0);
                secret.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
