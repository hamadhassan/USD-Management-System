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
    public partial class frmNotification : Form
    {
        public frmNotification()
        {
            InitializeComponent();
        }

        private void frmNotification_Load(object sender, EventArgs e)
        {
            NotificationDL.loadRecordFromFile(PathFile.Notification);
            try
            {
                if (NotificationDL.isListEmpty())
                {
                    lblAcademic.Text = "No Notification";
                    lblHostel.Visible = false;
                }
                else
                {
                    lblHostel.Visible = true;
                    lblAcademic.Text = NotificationDL.getNotificationByID(1);
                    lblHostel.Text = NotificationDL.getNotificationByID(2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
