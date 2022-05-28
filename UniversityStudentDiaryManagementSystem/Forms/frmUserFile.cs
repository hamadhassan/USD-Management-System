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
            if (cmbxOption.SelectedIndex == 1)
            {
                datagvAll.DataSource = AchivementDL.getAchivementslist();
            }
            else if (cmbxOption.SelectedIndex==2)
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


        }

        private void frmUserFile_Load(object sender, EventArgs e)
        {
           cmbxOption.SelectedIndex=0;
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
            datagvAll.Refresh();
        }
        private void datagvAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(cmbxOption.SelectedIndex != 0)
            {
                if (cmbxOption.SelectedIndex == 1)
                {
                    Achivement achivement = (Achivement)datagvAll.CurrentRow.DataBoundItem;
                    if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                    {
                        AchivementDL.deleteFromAchivementsList(achivement);
                        dataBind();
                    }
                    else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                    {
                        frmAchivements a = new frmAchivements(achivement);
                        a.ShowDialog();
                        dataBind();
                    }
                }
                else if(cmbxOption.SelectedIndex == 2)
                {
                    Activities activities  = (Activities)datagvAll.CurrentRow.DataBoundItem;
                    if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                    {
                        ActivitiesDL.deleteFromActivitiesList(activities);
                        dataBind();
                    }
                    else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                    {
                        frmAcivities a = new frmAcivities(activities);
                        a.ShowDialog();
                        dataBind();
                    }
                }
                else if (cmbxOption.SelectedIndex == 3)
                {
                    Book book = (Book)datagvAll.CurrentRow.DataBoundItem;
                    if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                    {
                        BookDL.deleteFromBookList(book);
                        dataBind();
                    }
                    else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                    {
                        frmBooks b = new frmBooks(book);
                        b.ShowDialog();
                        dataBind();
                    }
                }
                else if (cmbxOption.SelectedIndex == 4)
                {
                    Fee fee = (Fee)datagvAll.CurrentRow.DataBoundItem;
                    if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                    {
                        FeeDL.deleteFromFeeList(fee);
                        dataBind();
                    }
                    else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                    {
                        frmFee f = new frmFee(fee);
                        f.ShowDialog();
                        dataBind();
                    }
                }
                else if (cmbxOption.SelectedIndex == 5)
                {
                    Fund fund = (Fund)datagvAll.CurrentRow.DataBoundItem;
                    if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                    {
                        FundDL.deleteFromFundList(fund);
                        dataBind();
                    }
                    else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                    {
                        frmFunds f = new frmFunds(fund);
                        f.ShowDialog();
                        dataBind();
                    }
                }
                else if (cmbxOption.SelectedIndex == 6)
                {
                    HelpingMaterial helpingMaterial = (HelpingMaterial)datagvAll.CurrentRow.DataBoundItem;
                    if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                    {
                        HelpingMaterialDL.deleteFromHelpingMaterialList(helpingMaterial);
                        dataBind();
                    }
                    else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                    {
                        frmHelpingMaterial f = new frmHelpingMaterial(helpingMaterial);
                        f.ShowDialog();
                        dataBind();
                    }
                }
                else if (cmbxOption.SelectedIndex == 7)
                {
                    HostelExpenditure hostelExpenditure = (HostelExpenditure)datagvAll.CurrentRow.DataBoundItem;
                    if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                    {
                        HostelExpenditureDL.deleteFromHostelExpenditureList(hostelExpenditure);
                        dataBind();
                    }
                    else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                    {
                        frmHostelExpenditure f = new frmHostelExpenditure(hostelExpenditure);
                        f.ShowDialog();
                        dataBind();
                    }
                }
                else if (cmbxOption.SelectedIndex == 8)
                {
                    Meal meal = (Meal)datagvAll.CurrentRow.DataBoundItem;
                    if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                    {
                        MealDL.deleteFromMealList(meal);
                        dataBind();
                    }
                    else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                    {
                        frmMeal f = new frmMeal(meal);
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
                        dataBind();
                    }
                    else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                    {
                        frmPhone f = new frmPhone(phone);
                        f.ShowDialog();
                        dataBind();
                    }
                }
                else if (cmbxOption.SelectedIndex == 10)
                {
                    Secret secret = (Secret)datagvAll.CurrentRow.DataBoundItem;
                    if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
                    {
                        SecretDL.deleteFromSecretList(secret);
                        dataBind();
                    }
                    else if (datagvAll.Columns["Edit"].Index == e.ColumnIndex)
                    {
                        frmSecret f = new frmSecret(secret);
                        f.ShowDialog();
                        dataBind();
                    }
                }
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }
    }
}
