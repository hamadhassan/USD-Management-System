using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStudentDiaryManagementSystem.BL
{
    internal class Fund
    {
        private string typeFund;
        private double amount;
        private string remarks;
        public Fund(string typeFund, double amount, string remarks)
        {
            this.typeFund = typeFund;
            this.amount = amount;
            this.remarks = remarks;
        }
        public string TypeFund { get => typeFund; set => typeFund = value; }
        public double Amount { get => amount; set => amount = value; }
        public string Remarks { get => remarks; set => remarks = value; }
       
    }
}
