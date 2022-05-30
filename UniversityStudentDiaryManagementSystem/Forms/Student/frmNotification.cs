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
    public partial class frmNotification : Form
    {
        public frmNotification()
        {
            InitializeComponent();
        }

        private void frmNotification_Load(object sender, EventArgs e)
        {
            try
            {
                NotificationDL.loadRecordFromFile(FilePath.Notification);
                List<Notification> notification = NotificationDL.getNotificationlist();
                lblAcademic.Text = notification[0].AcademicFeeNotification;
                lblHostel.Text = notification[0].HostelFeeNotification;
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
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
