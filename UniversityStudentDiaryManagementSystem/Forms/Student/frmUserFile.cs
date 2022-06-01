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
using UniversityStudentDiaryManagementSystem.BL;
using UniversityStudentDiaryManagementSystem.Paths;


namespace UniversityStudentDiaryManagementSystem
{
    public partial class frmUserFile : Form
    {
        public frmUserFile()
        {
            InitializeComponent();
        }

        private void cmbxOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbxOption.SelectedIndex == 1)
                {
                    datagvAll.DataSource = AchivementDL.getAchivementslist();
                }
                else if (cmbxOption.SelectedIndex == 2)
                {
                    datagvAll.DataSource = ActivitiesDL.getActivitieslist();
                }
                else if (cmbxOption.SelectedIndex == 3)
                {
                    datagvAll.DataSource = BookDL.getBooklist();
                }
                else if (cmbxOption.SelectedIndex == 4)
                {
                    datagvAll.DataSource = FeeDL.getFeeList();
                }
                else if (cmbxOption.SelectedIndex == 5)
                {
                    datagvAll.DataSource = FundDL.getFundlist();
                }
                else if (cmbxOption.SelectedIndex == 6)
                {
                    datagvAll.DataSource = HelpingMaterialDL.getHelpingMateriallist();
                }
                else if (cmbxOption.SelectedIndex == 7)
                {
                    datagvAll.DataSource = HostelExpenditureDL.getHostelExpenditurelist();
                }
                else if (cmbxOption.SelectedIndex == 8)
                {
                    datagvAll.DataSource = MealDL.getMeallist();
                }
                else if (cmbxOption.SelectedIndex == 9)
                {
                    datagvAll.DataSource = PhoneDL.getPhonelist();
                }
                else if (cmbxOption.SelectedIndex == 10)
                {
                    datagvAll.DataSource = SecretDL.getSecretlist();
                }
                else if (cmbxOption.SelectedIndex == 11)
                {
                    datagvAll.DataSource = TransportDL.getTransportlist();
                }
                else if (cmbxOption.SelectedIndex == 12)
                {
                    datagvAll.DataSource = ResultDL.getResultlist();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmUserFile_Load(object sender, EventArgs e)
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
        public void dataBind()
        {

            datagvAll.DataSource = null;
            if (cmbxOption.SelectedIndex == 1)
            {
                datagvAll.DataSource = AchivementDL.getAchivementslist();
            }
            else if (cmbxOption.SelectedIndex == 2)
            {
                datagvAll.DataSource = ActivitiesDL.getActivitieslist();
            }
            else if (cmbxOption.SelectedIndex == 3)
            {
                datagvAll.DataSource = BookDL.getBooklist();
            }
            else if (cmbxOption.SelectedIndex == 4)
            {
                datagvAll.DataSource = FeeDL.getFeeList();
            }
            else if (cmbxOption.SelectedIndex == 5)
            {
                datagvAll.DataSource = FundDL.getFundlist();
            }
            else if (cmbxOption.SelectedIndex == 6)
            {
                datagvAll.DataSource = HelpingMaterialDL.getHelpingMateriallist();
            }
            else if (cmbxOption.SelectedIndex == 7)
            {
                datagvAll.DataSource = HostelExpenditureDL.getHostelExpenditurelist();
            }
            else if (cmbxOption.SelectedIndex == 8)
            {
                datagvAll.DataSource = MealDL.getMeallist();
            }
            else if (cmbxOption.SelectedIndex == 9)
            {
                datagvAll.DataSource = PhoneDL.getPhonelist();
            }
            else if (cmbxOption.SelectedIndex == 10)
            {
                datagvAll.DataSource = SecretDL.getSecretlist();
            }
            else if (cmbxOption.SelectedIndex == 11)
            {
                datagvAll.DataSource = TransportDL.getTransportlist();
            }
            else if (cmbxOption.SelectedIndex == 12)
            {
                datagvAll.DataSource = ResultDL.getResultlist();
            }

            datagvAll.Refresh();
        }
        private void datagvAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (cmbxOption.SelectedIndex != 0)
                {
                    if (cmbxOption.SelectedIndex == 1)
                    {
                        Achivement achivement = (Achivement)datagvAll.CurrentRow.DataBoundItem;
                        if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                        {
                            AchivementDL.deleteFromAchivementsList(achivement);
                            AchivementDL.storeAllRecordIntoFile(PathFile.Achivement);
                            dataBind();
                        }
                        else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                        {
                            frmAchivements a = new frmAchivements(achivement);
                            a.ShowDialog();
                            AchivementDL.storeAllRecordIntoFile(PathFile.Achivement);
                            dataBind();
                        }
                    }
                    else if (cmbxOption.SelectedIndex == 2)
                    {
                        Activities activities = (Activities)datagvAll.CurrentRow.DataBoundItem;
                        if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                        {
                            ActivitiesDL.deleteFromActivitiesList(activities);
                            ActivitiesDL.storeAllRecordIntoFile(PathFile.Activities);
                            dataBind();
                        }
                        else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                        {
                            frmAcivities a = new frmAcivities(activities);
                            a.ShowDialog();
                            ActivitiesDL.storeAllRecordIntoFile(PathFile.Activities);
                            dataBind();
                        }
                    }
                    else if (cmbxOption.SelectedIndex == 3)
                    {
                        Book book = (Book)datagvAll.CurrentRow.DataBoundItem;
                        if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                        {
                            BookDL.deleteFromBookList(book);
                            BookDL.storeAllRecordIntoFile(PathFile.Books);
                            dataBind();
                        }
                        else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                        {
                            frmBooks b = new frmBooks(book);
                            b.ShowDialog();
                            BookDL.storeAllRecordIntoFile(PathFile.Books);
                            dataBind();
                        }
                    }
                    else if (cmbxOption.SelectedIndex == 4)
                    {
                        Fee fee = (Fee)datagvAll.CurrentRow.DataBoundItem;
                        if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                        {
                            FeeDL.deleteFromFeeList(fee);
                            FeeDL.storeAllRecordIntoFile(PathFile.Fee);
                            dataBind();
                        }
                        else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                        {
                            frmFee f = new frmFee(fee);
                            f.ShowDialog();
                            FeeDL.storeAllRecordIntoFile(PathFile.Fee);
                            dataBind();
                        }
                    }
                    else if (cmbxOption.SelectedIndex == 5)
                    {
                        Fund fund = (Fund)datagvAll.CurrentRow.DataBoundItem;
                        if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                        {
                            FundDL.deleteFromFundList(fund);
                            FundDL.storeAllRecordIntoFile(PathFile.Fund);
                            dataBind();
                        }
                        else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                        {
                            frmFunds f = new frmFunds(fund);
                            f.ShowDialog();
                            FundDL.storeAllRecordIntoFile(PathFile.Fund);
                            dataBind();
                        }
                    }
                    else if (cmbxOption.SelectedIndex == 6)
                    {
                        HelpingMaterial helpingMaterial = (HelpingMaterial)datagvAll.CurrentRow.DataBoundItem;
                        if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                        {
                            HelpingMaterialDL.deleteFromHelpingMaterialList(helpingMaterial);
                            HelpingMaterialDL.storeAllRecordIntoFile(PathFile.HelpingMaterial);
                            dataBind();
                        }
                        else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                        {
                            frmHelpingMaterial f = new frmHelpingMaterial(helpingMaterial);
                            f.ShowDialog();
                            HelpingMaterialDL.storeAllRecordIntoFile(PathFile.HelpingMaterial);
                            dataBind();
                        }
                    }
                    else if (cmbxOption.SelectedIndex == 7)
                    {
                        HostelExpenditure hostelExpenditure = (HostelExpenditure)datagvAll.CurrentRow.DataBoundItem;
                        if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                        {
                            HostelExpenditureDL.deleteFromHostelExpenditureList(hostelExpenditure);
                            HostelExpenditureDL.storeAllRecordIntoFile(PathFile.HostelExpenditure);
                            dataBind();
                        }
                        else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                        {
                            frmHostelExpenditure f = new frmHostelExpenditure(hostelExpenditure);
                            f.ShowDialog();
                            HostelExpenditureDL.storeAllRecordIntoFile(PathFile.HostelExpenditure);
                            dataBind();
                        }
                    }
                    else if (cmbxOption.SelectedIndex == 8)
                    {
                        Meal meal = (Meal)datagvAll.CurrentRow.DataBoundItem;
                        if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                        {
                            MealDL.deleteFromMealList(meal);
                            MealDL.storeAllRecordIntoFile(PathFile.Meal);
                            dataBind();
                        }
                        else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                        {
                            frmMeal f = new frmMeal(meal);
                            MealDL.storeAllRecordIntoFile(PathFile.Meal);
                            f.ShowDialog();
                            dataBind();
                        }
                    }
                    else if (cmbxOption.SelectedIndex == 9)
                    {
                        Phone phone = (Phone)datagvAll.CurrentRow.DataBoundItem;
                        if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                        {
                            PhoneDL.deleteFromPhoneList(phone);
                            PhoneDL.storeAllRecordIntoFile(PathFile.Phone);
                            dataBind();
                        }
                        else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                        {
                            frmPhone f = new frmPhone(phone);
                            f.ShowDialog();
                            PhoneDL.storeAllRecordIntoFile(PathFile.Phone);
                            dataBind();
                        }
                    }
                    else if (cmbxOption.SelectedIndex == 10)
                    {
                        Secret secret = (Secret)datagvAll.CurrentRow.DataBoundItem;
                        if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                        {
                            SecretDL.deleteFromSecretList(secret);
                            SecretDL.storeAllRecordIntoFile(PathFile.Secret);
                            dataBind();
                        }
                        else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                        {
                            frmSecret f = new frmSecret(secret);
                            f.ShowDialog();
                            SecretDL.storeAllRecordIntoFile(PathFile.Secret);
                            dataBind();
                        }
                    }
                    else if (cmbxOption.SelectedIndex == 11)
                    {
                        Transport transport = (Transport)datagvAll.CurrentRow.DataBoundItem;
                        if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                        {
                            TransportDL.deleteFromTransportList(transport);
                            TransportDL.storeAllRecordIntoFile(PathFile.Transport);
                            dataBind();
                        }
                        else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                        {
                            frmTransport f = new frmTransport(transport);
                            f.ShowDialog();
                            TransportDL.storeAllRecordIntoFile(PathFile.Transport);
                            dataBind();
                        }
                    }
                    else if (cmbxOption.SelectedIndex == 12)
                    {
                        Result result = (Result)datagvAll.CurrentRow.DataBoundItem;
                        if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                        {
                            ResultDL.deleteFromResultList(result);
                            ResultDL.storeAllRecordIntoFile(PathFile.Result);
                            dataBind();
                        }
                        else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                        {
                            frmResult f = new frmResult(result);
                            f.ShowDialog();
                            ResultDL.storeAllRecordIntoFile(PathFile.Result);
                            dataBind();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            try
            {
                frmMain main = new frmMain();
                main.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
