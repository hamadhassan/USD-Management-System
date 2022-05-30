using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStudentDiaryManagementSystem.BL
{
    internal class Notification
    {
        private string academicFeeNotification;
        private string hostelFeeNotification;
        private int id;
        public Notification(string academicFeeNotification, string hostelFeeNotification)
        {
            this.academicFeeNotification = academicFeeNotification;
            this.hostelFeeNotification = hostelFeeNotification;
            this.id =0;
        }
        public Notification(string feeNotification,int id)
        {
            if(id == 1)
            {//academic
               academicFeeNotification = feeNotification;
            }
            else if(id == 2)
            {//hostel
                hostelFeeNotification = feeNotification;
            }
        }
        public string AcademicFeeNotification { get => academicFeeNotification; set => academicFeeNotification = value; }
        public string HostelFeeNotification { get => hostelFeeNotification; set => hostelFeeNotification = value; }
        public int Id { get => id; set => id = value; }
    }
}
