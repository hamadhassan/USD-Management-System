using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStudentDiaryManagementSystem.BL
{
    public class HostelExpenditure
    {
        private string typeHostelExpenditure;
        private string month;
        private double charges;
        private string remarks;
        public HostelExpenditure(string typeHostelExpenditure, string month, double charges , string remarks)
        {
            this.typeHostelExpenditure = typeHostelExpenditure;
            this.month = month;
            this.charges = charges;
            this.remarks = remarks;
        }
        public string TypeHostelExpenditure { get => typeHostelExpenditure; set => typeHostelExpenditure = value; }
        public string Month { get => month; set => month = value; }
        public double Charges { get => charges; set => charges = value; }
        public string Remarks { get => remarks; set => remarks = value; }
    }
}
