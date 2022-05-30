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
    public partial class frmFeeParent : Form
    {
        public frmFeeParent()
        {
            InitializeComponent();
        }

        private void frmFeeParent_Load(object sender, EventArgs e)
        {
            string messageAcademic = "The academic fee notification was readed ";
            string messagHostel = "The Hostel fee notifcation was readed";
            Notification notification = new Notification(messageAcademic, messagHostel);
            NotificationDL.setIntoNotificationList(notification);
            NotificationDL.storeRecordIntoFile(notification, FilePath.Notification);
            FeeDL.loadRecordFromFile(FilePath.Fee);
            Fee academicFee=FeeDL.getAcademicFee();
            if (academicFee != null)
            {
                lblNoAcademicFee.Visible=false;
                lblSemester.Text = academicFee.Semester;
                lblAmount.Text =academicFee.Amount.ToString();
                lblRemarks.Text = academicFee.Remarks;
                lblChallanNo.Text=academicFee.ChallanNo;
                lblDate.Text = academicFee.Date;
            }
            else
            {
                lblNoAcademicFee.Visible = true;
                label1.Visible = false;
                label2.Visible=false;
                label3.Visible = false;
                label4.Visible=false;
                label5.Visible=false;
                lblSemester.Visible = false;
                lblAmount.Visible = false; 
                lblRemarks.Visible = false; 
                lblChallanNo.Visible = false;
                lblDate.Visible = false;

            }
            Fee hostelFee=FeeDL.getHostelFee();
            if (hostelFee != null)
            {

            }
            else
            {

            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainParent mainParent=new frmMainParent();
            mainParent.Show(); 
        }

        private void btnMarkAsDone_Click(object sender, EventArgs e)
        {
            string message = "The academic fee was paid ";
            NotificationDL.updateMessageAcademicFee(message);
            NotificationDL.storeAllRecordIntoFile(FilePath.Notification);

        }

        private void btnMarkAsDoneHostel_Click(object sender, EventArgs e)
        {
            string message = "The hostel fee was paid ";
            NotificationDL.updateMessageHostelFee(message);
            NotificationDL.storeAllRecordIntoFile(FilePath.Notification);
        }
    }
}
