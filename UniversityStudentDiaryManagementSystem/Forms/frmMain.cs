using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            tolstplblCurentDate.Text = DateTime.Now.ToString("dddd dd/MM/yyyy");
            tolstplblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss:tt");
        }
        #endregion

        #region Credientail
        private void createAUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateAccount frmCreateAccount = new frmCreateAccount();
            frmCreateAccount.ShowDialog();
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdatePassword updatePassword = new frmUpdatePassword();
            updatePassword.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmSignIn signIn = new frmSignIn();
            signIn.Show();
            this.Hide();
        }
        #endregion

        #region Wallet
        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWallet wallet= new frmWallet();
            wallet.ShowDialog();
        }

        #endregion

        #region Fee
        private void academicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFee acdemicFee = new frmFee(1);
            acdemicFee.ShowDialog();
        }
        private void hostelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFee acdemicFee = new frmFee(2);
            acdemicFee.ShowDialog();
        }
        #endregion

        #region Report
        private void dailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport report=new frmReport();
            report.ShowDialog();
        }

        private void monthlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport report = new frmReport();
            report.ShowDialog();
        }

        private void yearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport report = new frmReport();
            report.ShowDialog();
        }
        #endregion

        #region Meal
        private void breakfastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeal meal=new frmMeal(1);
            meal.ShowDialog();
        }

        private void lunchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeal meal = new frmMeal(2);
            meal.ShowDialog();
        }

        private void dinnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeal meal = new frmMeal(3);
            meal.ShowDialog();
        }

        private void hangOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeal meal = new frmMeal(4);
            meal.ShowDialog();
        }
        #endregion

        #region Expebditure
        private void messMealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHostelExpenditure hostelExpenditure=new frmHostelExpenditure(1);
            hostelExpenditure.ShowDialog();
        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHostelExpenditure hostelExpenditure = new frmHostelExpenditure(2);
            hostelExpenditure.ShowDialog();
        }

        private void roomRenovationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHostelExpenditure hostelExpenditure = new frmHostelExpenditure(3);
            hostelExpenditure.ShowDialog();
        }

        private void laundaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHostelExpenditure hostelExpenditure = new frmHostelExpenditure(4);
            hostelExpenditure.ShowDialog();
        }

        private void barberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHostelExpenditure hostelExpenditure = new frmHostelExpenditure(5);
            hostelExpenditure.ShowDialog();
        }

        #endregion

        #region Helping material
        private void printingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelpingMaterial helpingMaterial=new frmHelpingMaterial(1);
            helpingMaterial.ShowDialog();
        }

        private void copyingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelpingMaterial helpingMaterial = new frmHelpingMaterial(2);
            helpingMaterial.ShowDialog();
        }
        #endregion

        #region Fund
        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFunds funds=new frmFunds(1);
            funds.ShowDialog();
        }

        private void socitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFunds funds = new frmFunds(2);
            funds.ShowDialog();
        }

        private void socialWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFunds funds = new frmFunds(3);
            funds.ShowDialog();
        }
        #endregion

        #region Goals
        private void dailyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGoals frmGoals = new frmGoals();
            frmGoals.ShowDialog();
        }

        private void quatilyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGoals frmGoals = new frmGoals();
            frmGoals.ShowDialog();
        }

        private void yearlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGoals frmGoals = new frmGoals();
            frmGoals.ShowDialog();
        }

        #endregion 

        #region Package 
        private void packagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhone phone = new frmPhone();
            phone.ShowDialog();
        }
        #endregion
       
        #region Book
        private void borrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBooks books = new frmBooks(1);
            books.ShowDialog();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBooks books = new frmBooks(2);
            books.ShowDialog();
        }
        #endregion

        #region Trasport
        private void busToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransport transport = new frmTransport(1);
            transport.ShowDialog();
        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransport transport = new frmTransport(2);
            transport.ShowDialog();
        }
        #endregion

        #region activities
        private void sportiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcivities acivities = new frmAcivities(1);
            acivities.ShowDialog();
        }

        private void socialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcivities acivities = new frmAcivities(2);
            acivities.ShowDialog();
        }
        #endregion

        #region Secret
        private void quotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecret secret = new frmSecret(1);
            secret.ShowDialog();
        }

        private void eventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecret secret = new frmSecret(2);
            secret.ShowDialog();
        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecret secret = new frmSecret(3);
            secret.ShowDialog();
        }
        #endregion

        #region Achivements
        private void coToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAchivements achivements = new frmAchivements(1);
            achivements.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmAchivements achivements = new frmAchivements(2);
            achivements.ShowDialog();
        }
        #endregion

        #region Tool Srip Button 
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmWallet wallet= new frmWallet();
            wallet.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmReport report= new frmReport();
            report.ShowDialog();    
        }
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frmGoals goals =new frmGoals();
            goals.ShowDialog();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmMeal meal = new frmMeal(0);
            meal.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmHostelExpenditure hostelExpenditure = new frmHostelExpenditure(0);
            hostelExpenditure.ShowDialog();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            frmHelpingMaterial helpingMaterial = new frmHelpingMaterial(1);
            helpingMaterial.ShowDialog();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            frmHelpingMaterial helpingMaterial = new frmHelpingMaterial(2);
            helpingMaterial.ShowDialog();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            frmFunds funds = new frmFunds(0);
            funds.ShowDialog();
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmPhone phone = new frmPhone();
            phone.ShowDialog();
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            frmSecret secret = new frmSecret(0);
            secret.ShowDialog();    
        }
        #endregion

        #region File
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserFile file = new frmUserFile();
            file.Show();
            this.Hide();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserFile file = new frmUserFile();
            file.Show();
            this.Hide();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserFile file = new frmUserFile();
            file.Show();
            this.Hide();
        }
        #endregion
    }
}
