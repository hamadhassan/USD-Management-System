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
using UniversityStudentDiaryManagementSystem.Path;


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
                AchivementDL.loadRecordFromFile(FilePath.Achivement);
                ActivitiesDL.loadRecordFromFile(FilePath.Activities);
                BookDL.loadRecordFromFile(FilePath.Books);
                FeeDL.loadRecordFromFile(FilePath.Fee);
                FundDL.loadRecordFromFile(FilePath.Fund);
                HelpingMaterialDL.loadRecordFromFile(FilePath.HelpingMaterial);
                HostelExpenditureDL.loadRecordFromFile(FilePath.HostelExpenditure);
                MealDL.loadRecordFromFile(FilePath.Meal);
                PhoneDL.loadRecordFromFile(FilePath.Phone);
                SecretDL.loadRecordFromFile(FilePath.Secret);
                TransportDL.loadRecordFromFile(FilePath.Transport);
                ResultDL.loadRecordFromFile(FilePath.Result);
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
                        AchivementDL.storeAllRecordIntoFile(FilePath.Achivement);
                        Achivement achivement = (Achivement)datagvAll.CurrentRow.DataBoundItem;
                        if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                        {
                            AchivementDL.deleteFromAchivementsList(achivement);
                            AchivementDL.storeAllRecordIntoFile(FilePath.Achivement);
                            dataBind();
                        }
                        else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                        {
                            frmAchivements a = new frmAchivements(achivement);
                            a.ShowDialog();
                            AchivementDL.storeAllRecordIntoFile(FilePath.Achivement);
                            dataBind();
                        }
                    }
                    else if (cmbxOption.SelectedIndex == 2)
                    {
                        ActivitiesDL.storeAllRecordIntoFile(FilePath.Activities);
                        Activities activities = (Activities)datagvAll.CurrentRow.DataBoundItem;
                        if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                        {
                            ActivitiesDL.deleteFromActivitiesList(activities);
                            ActivitiesDL.storeAllRecordIntoFile(FilePath.Activities);
                            dataBind();
                        }
                        else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                        {
                            frmAcivities a = new frmAcivities(activities);
                            a.ShowDialog();
                            ActivitiesDL.storeAllRecordIntoFile(FilePath.Activities);
                            dataBind();
                        }
                    }
                    else if (cmbxOption.SelectedIndex == 3)
                    {
                        BookDL.storeAllRecordIntoFile(FilePath.Books);
                        Book book = (Book)datagvAll.CurrentRow.DataBoundItem;
                        if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                        {
                            BookDL.deleteFromBookList(book);
                            BookDL.storeAllRecordIntoFile(FilePath.Books);
                            dataBind();
                        }
                        else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                        {
                            frmBooks b = new frmBooks(book);
                            b.ShowDialog();
                            BookDL.storeAllRecordIntoFile(FilePath.Books);
                            dataBind();
                        }
                    }
                    else if (cmbxOption.SelectedIndex == 4)
                    {
                        FeeDL.storeAllRecordIntoFile(FilePath.Fee);
                        Fee fee = (Fee)datagvAll.CurrentRow.DataBoundItem;
                        if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                        {
                            FeeDL.deleteFromFeeList(fee);
                            FeeDL.storeAllRecordIntoFile(FilePath.Fee);
                            dataBind();
                        }
                        else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                        {
                            frmFee f = new frmFee(fee);
                            f.ShowDialog();
                            FeeDL.storeAllRecordIntoFile(FilePath.Fee);
                            dataBind();
                        }
                    }
                    else if (cmbxOption.SelectedIndex == 5)
                    {
                        FundDL.storeAllRecordIntoFile(FilePath.Fund);
                        Fund fund = (Fund)datagvAll.CurrentRow.DataBoundItem;
                        if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                        {
                            FundDL.deleteFromFundList(fund);
                            FundDL.storeAllRecordIntoFile(FilePath.Fund);
                            dataBind();
                        }
                        else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                        {
                            frmFunds f = new frmFunds(fund);
                            f.ShowDialog();
                            FundDL.storeAllRecordIntoFile(FilePath.Fund);
                            dataBind();
                        }
                    }
                    else if (cmbxOption.SelectedIndex == 6)
                    {
                        HelpingMaterialDL.storeAllRecordIntoFile(FilePath.HelpingMaterial);
                        HelpingMaterial helpingMaterial = (HelpingMaterial)datagvAll.CurrentRow.DataBoundItem;
                        if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                        {
                            HelpingMaterialDL.deleteFromHelpingMaterialList(helpingMaterial);
                            HelpingMaterialDL.storeAllRecordIntoFile(FilePath.HelpingMaterial);
                            dataBind();
                        }
                        else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                        {
                            frmHelpingMaterial f = new frmHelpingMaterial(helpingMaterial);
                            f.ShowDialog();
                            HelpingMaterialDL.storeAllRecordIntoFile(FilePath.HelpingMaterial);
                            dataBind();
                        }
                    }
                    else if (cmbxOption.SelectedIndex == 7)
                    {
                        HostelExpenditureDL.storeAllRecordIntoFile(FilePath.HostelExpenditure);
                        HostelExpenditure hostelExpenditure = (HostelExpenditure)datagvAll.CurrentRow.DataBoundItem;
                        if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                        {
                            HostelExpenditureDL.deleteFromHostelExpenditureList(hostelExpenditure);
                            HostelExpenditureDL.storeAllRecordIntoFile(FilePath.HostelExpenditure);
                            dataBind();
                        }
                        else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                        {
                            frmHostelExpenditure f = new frmHostelExpenditure(hostelExpenditure);
                            f.ShowDialog();
                            HostelExpenditureDL.storeAllRecordIntoFile(FilePath.HostelExpenditure);
                            dataBind();
                        }
                    }
                    else if (cmbxOption.SelectedIndex == 8)
                    {
                        MealDL.storeAllRecordIntoFile(FilePath.Meal);
                        Meal meal = (Meal)datagvAll.CurrentRow.DataBoundItem;
                        if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                        {
                            MealDL.deleteFromMealList(meal);
                            MealDL.storeAllRecordIntoFile(FilePath.Meal);
                            dataBind();
                        }
                        else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                        {
                            frmMeal f = new frmMeal(meal);
                            MealDL.storeAllRecordIntoFile(FilePath.Meal);
                            f.ShowDialog();
                            dataBind();
                        }
                    }
                    else if (cmbxOption.SelectedIndex == 9)
                    {
                        PhoneDL.storeAllRecordIntoFile(FilePath.Phone);
                        Phone phone = (Phone)datagvAll.CurrentRow.DataBoundItem;
                        if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                        {
                            PhoneDL.deleteFromPhoneList(phone);
                            PhoneDL.storeAllRecordIntoFile(FilePath.Phone);
                            dataBind();
                        }
                        else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                        {
                            frmPhone f = new frmPhone(phone);
                            f.ShowDialog();
                            PhoneDL.storeAllRecordIntoFile(FilePath.Phone);
                            dataBind();
                        }
                    }
                    else if (cmbxOption.SelectedIndex == 10)
                    {
                        SecretDL.storeAllRecordIntoFile(FilePath.Secret);
                        Secret secret = (Secret)datagvAll.CurrentRow.DataBoundItem;
                        if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                        {
                            SecretDL.deleteFromSecretList(secret);
                            SecretDL.storeAllRecordIntoFile(FilePath.Secret);
                            dataBind();
                        }
                        else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                        {
                            frmSecret f = new frmSecret(secret);
                            f.ShowDialog();
                            SecretDL.storeAllRecordIntoFile(FilePath.Secret);
                            dataBind();
                        }
                    }
                    else if (cmbxOption.SelectedIndex == 11)
                    {
                        TransportDL.storeAllRecordIntoFile(FilePath.Transport);
                        Transport transport = (Transport)datagvAll.CurrentRow.DataBoundItem;
                        if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                        {
                            TransportDL.deleteFromTransportList(transport);
                            TransportDL.storeAllRecordIntoFile(FilePath.Transport);
                            dataBind();
                        }
                        else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                        {
                            frmTransport f = new frmTransport(transport);
                            f.ShowDialog();
                            TransportDL.storeAllRecordIntoFile(FilePath.Transport);
                            dataBind();
                        }
                    }
                    else if (cmbxOption.SelectedIndex == 12)
                    {
                        ResultDL.storeAllRecordIntoFile(FilePath.Result);
                        Result result = (Result)datagvAll.CurrentRow.DataBoundItem;
                        if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                        {
                            ResultDL.deleteFromResultList(result);
                            ResultDL.storeAllRecordIntoFile(FilePath.Result);
                            dataBind();
                        }
                        else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                        {
                            frmResult f = new frmResult(result);
                            f.ShowDialog();
                            ResultDL.storeAllRecordIntoFile(FilePath.Result);
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
