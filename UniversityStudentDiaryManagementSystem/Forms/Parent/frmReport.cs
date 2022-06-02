using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityStudentDiaryManagementSystem.DL;
using UniversityStudentDiaryManagementSystem.Paths;

namespace UniversityStudentDiaryManagementSystem
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void cmbxOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbxOption.SelectedIndex == 1)
                {
                    datagv.DataSource = AchivementDL.getAchivementslist();
                }
                else if (cmbxOption.SelectedIndex == 2)
                {
                    datagv.DataSource = ActivitiesDL.getActivitieslist();
                }
                else if (cmbxOption.SelectedIndex == 3)
                {
                    datagv.DataSource = BookDL.getBooklist();
                }
                else if (cmbxOption.SelectedIndex == 4)
                {
                    datagv.DataSource = FeeDL.getFeeList();
                }
                else if (cmbxOption.SelectedIndex == 5)
                {
                    datagv.DataSource = FundDL.getFundlist();
                }
                else if (cmbxOption.SelectedIndex == 6)
                {
                    datagv.DataSource = HelpingMaterialDL.getHelpingMateriallist();
                }
                else if (cmbxOption.SelectedIndex == 7)
                {
                    datagv.DataSource = HostelExpenditureDL.getHostelExpenditurelist();
                }
                else if (cmbxOption.SelectedIndex == 8)
                {
                    datagv.DataSource = MealDL.getMeallist();
                }
                else if (cmbxOption.SelectedIndex == 9)
                {
                    datagv.DataSource = PhoneDL.getPhonelist();
                }
                else if (cmbxOption.SelectedIndex == 10)
                {
                    datagv.DataSource = SecretDL.getSecretlist();
                }
                else if (cmbxOption.SelectedIndex == 11)
                {
                    datagv.DataSource = TransportDL.getTransportlist();
                }
                else if (cmbxOption.SelectedIndex == 12)
                {
                    datagv.DataSource = ResultDL.getResultlist();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            try
            {
                cmbxOption.SelectedIndex = 0;
                AchivementDL.loadRecordFromFile(PathFile.Achivement);
                ActivitiesDL.loadRecordFromFile(PathFile.Activities);
                BookDL.loadRecordFromFile(PathFile.Books);
                FeeDL.loadRecordFromFile(PathFile.Fee);
                FundDL.loadRecordFromFile(PathFile.Fund);
                HelpingMaterialDL.loadRecordFromFile(PathFile.HelpingMaterial);
                HostelExpenditureDL.loadRecordFromFile(PathFile.HostelExpenditure);
                MealDL.loadRecordFromFile(PathFile.Meal);
                PhoneDL.loadRecordFromFile(PathFile.Phone);
                SecretDL.loadRecordFromFile(PathFile.Secret);
                TransportDL.loadRecordFromFile(PathFile.Transport);
                ResultDL.loadRecordFromFile(PathFile.Result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
