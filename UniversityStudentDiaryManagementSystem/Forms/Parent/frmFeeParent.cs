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
            try
            {
                //NotificationDL.loadRecordFromFile(FilePath.Notification);
                FeeDL.loadRecordFromFile(FilePath.Fee);
                Fee academicFee = FeeDL.getAcademicFee();
                if (academicFee != null)
                {
                    string messageAcademic = "The academic fee was readed ";
                    Notification notification = new Notification(messageAcademic, 1);
                    NotificationDL.clearListAtID(1);
                    NotificationDL.setIntoNotificationList(notification);
                    NotificationDL.storeAllRecordIntoFile(FilePath.Notification);
                    lblNoAcademicFee.Visible = false;
                    lblSemester.Text = academicFee.Semester;
                    lblAmount.Text = academicFee.Amount.ToString();
                    lblRemarks.Text = academicFee.Remarks;
                    lblChallanNo.Text = academicFee.ChallanNo;
                    lblDate.Text = academicFee.Date;
                }
                else
                {
                    lblNoAcademicFee.Visible = true;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    lblSemester.Visible = false;
                    lblAmount.Visible = false;
                    lblRemarks.Visible = false;
                    lblChallanNo.Visible = false;
                    lblDate.Visible = false;

                }
                Fee hostelFee = FeeDL.getHostelFee();
                if (hostelFee != null)
                {
                    string messagHostel = "The Hostel fee was readed";
                    Notification notification = new Notification(messagHostel, 2);
                    NotificationDL.clearListAtID(2);
                    NotificationDL.setIntoNotificationList(notification);
                    NotificationDL.storeAllRecordIntoFile(FilePath.Notification);
                    lblNoHostelFee.Visible = false;
                    lblSemesterHostel.Text = hostelFee.Semester;
                    lblAmountHostel.Text = hostelFee.Amount.ToString();
                    lblRemarksHostel.Text = hostelFee.Remarks;
                    lblHostelChallanNo.Text = hostelFee.ChallanNo;
                    lblDueDateHostel.Text = hostelFee.Date;
                }
                else
                {
                    lblNoHostelFee.Visible = true;
                    lblHostelA.Visible = false;
                    lblHostelC.Visible = false;
                    lblHostelD.Visible = false;
                    lblHostelR.Visible = false;
                    lblHostelS.Visible = false;
                    lblSemesterHostel.Visible = false;
                    lblAmountHostel.Visible = false;
                    lblHostelChallanNo.Visible = false;
                    lblDueDateHostel.Visible = false;
                    lblRemarksHostel.Visible = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmMainParent mainParent = new frmMainParent();
                mainParent.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnMarkAsDone_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "The academic fee was paid ";
                NotificationDL.updateMessageAcademicFee(message);
                NotificationDL.storeAllRecordIntoFile(FilePath.Notification);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnMarkAsDoneHostel_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "The hostel fee was paid ";
                NotificationDL.updateMessageHostelFee(message);
                NotificationDL.storeAllRecordIntoFile(FilePath.Notification);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }
    }
}
