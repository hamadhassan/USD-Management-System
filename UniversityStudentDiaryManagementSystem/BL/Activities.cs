using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStudentDiaryManagementSystem.BL
{
    internal class Activities
    {
        private string typeAcitivity;
        private string minutes;
        private string remarks;
        public Activities(string typeActivity,string minutes,string remarks)
        {
            this.typeAcitivity = typeActivity;
            this.minutes = minutes;
            this.remarks = remarks;
        }

        public string TypeAcitivity { get => typeAcitivity; set => typeAcitivity = value; }
        public string Minutes { get => minutes; set => minutes = value; }
        public string Remarks { get => remarks; set => remarks = value; }
    }
}
