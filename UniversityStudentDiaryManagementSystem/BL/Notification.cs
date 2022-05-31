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
        public Notification(string academicFeeNotification, string hostelFeeNotification,int id)
        {
            this.academicFeeNotification = academicFeeNotification;
            this.hostelFeeNotification = hostelFeeNotification;
            this.id = id;
        }
        public Notification(string message,int id)
        {
            if (id == 1)
            {
                academicFeeNotification = message;
                this.id = id;
            }
            else if(id == 2)
            {
                hostelFeeNotification = message;
                this.id = id;
            }
        }
        public string AcademicFeeNotification { get => academicFeeNotification; set => academicFeeNotification = value; }
        public string HostelFeeNotification { get => hostelFeeNotification; set => hostelFeeNotification = value; }
        public int Id { get => id; set => id = value; }
    }
}
