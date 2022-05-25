using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStudentDiaryManagementSystem.BL
{
    internal class Fee
    {
        private string feeType;
        private string semester;
        private string challanNo;
        private double amount;
        private string date;
        private string remarks;
        public Fee(string feeType, string semester, string challanNo,double amount,string date,string remarks)
        {
            this.feeType = feeType;
            this.semester = semester;
            this.challanNo = challanNo;
            this.amount = amount;
            this.date = date;
            this.remarks = remarks;
        }

        public string FeeType { get => feeType; set => feeType = value; }
        public string Semester { get => semester; set => semester = value; }
        public string ChallanNo { get => challanNo; set => challanNo = value; }
        public double Amount { get => amount; set => amount = value; }
        public string Date { get => date; set => date = value; }
        public string Remarks { get => remarks; set => remarks = value; }
    }
}
