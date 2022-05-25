using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStudentDiaryManagementSystem.BL
{
    internal class Achivement
    {
        private string typeAchivement;
        private string presentedBy;
        private string remarks;

        public Achivement(string typeAchivement,string presentedBy,string remarks)
        {
            this.typeAchivement = typeAchivement;
            this.presentedBy = presentedBy;
            this.remarks = remarks;
        }
        public string TypeAchivement { get => typeAchivement; set => typeAchivement = value; }
        public string PresentedBy { get => presentedBy; set => presentedBy = value; }
        public string Remakrks { get => remarks; set => remarks = value; }
    }
}
