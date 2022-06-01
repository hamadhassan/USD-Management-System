﻿using System;
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
                FeeDL.loadRecordFromFile(PathFile.Fee);
                Fee academicFee = FeeDL.getAcademicFee();
                if (academicFee != null)
                {
                    string messageAcademic = "The academic fee was readed ";
                    Notification notification = new Notification(messageAcademic, 1);
                    NotificationDL.clearListAtID(1);
                    NotificationDL.setIntoNotificationList(notification);
                    NotificationDL.storeAllRecordIntoFile(PathFile.Notification);
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
                    NotificationDL.storeAllRecordIntoFile(PathFile.Notification);
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

        private void btnMarkAsDone_Click(object sender, EventArgs e)
        {
            try
            {
                NotificationDL.loadRecordFromFile(PathFile.Notification);
                string message = "The academic fee was paid ";
                NotificationDL.updateMessage(1,message);
                NotificationDL.storeAllRecordIntoFile(PathFile.Notification);
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
                NotificationDL.loadRecordFromFile(PathFile.Notification);
                NotificationDL.updateMessage(2, message);
                NotificationDL.storeAllRecordIntoFile(PathFile.Notification);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }
    }
}
