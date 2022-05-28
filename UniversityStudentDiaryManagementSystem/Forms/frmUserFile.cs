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

        }

        private void frmUserFile_Load(object sender, EventArgs e)
        {
           cmbxOption.SelectedIndex=0;
        }
        public void dataBind()
        {

            datagvAll.DataSource = null;
            if(cmbxOption.SelectedIndex == 1)
            {
                datagvAll.DataSource = AchivementDL.getAchivementslist();
            }
            else if (cmbxOption.SelectedIndex == 2)
            {
                datagvAll.DataSource= ActivitiesDL.getActivitieslist();
            }
            else if (cmbxOption.SelectedIndex == 3)
            {
                datagvAll.DataSource= BookDL.getBooklist();
            }
            else if (cmbxOption.SelectedIndex == 4)
            {
                datagvAll.DataSource = FeeDL.getFeeList();
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
