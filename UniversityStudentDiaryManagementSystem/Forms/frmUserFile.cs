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
        }

        private void frmUserFile_Load(object sender, EventArgs e)
        {
           cmbxOption.SelectedIndex=0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = datagvAll.CurrentCell.RowIndex;
            datagvAll.Rows.RemoveAt(rowIndex);

        }

        private void datagvAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (datagvAll.Columns["Delete"].Index == e.ColumnIndex)
            //{
            //    MUserDL.deleteUserFromList(user);
            //    MUserDL.storeAllDataIntoFile(path);
            //    dataBind();
            //}
            //else if (usersGV.Columns["Edit"].Index == e.ColumnIndex)
            //{
            //    EditUserForm myform = new EditUserForm(user);
            //    myform.ShowDialog();
            //    MUserDL.storeAllDataIntoFile(path);
            //    dataBind();
            //}
        }
    }
}
