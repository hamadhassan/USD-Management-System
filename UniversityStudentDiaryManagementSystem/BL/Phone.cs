using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStudentDiaryManagementSystem.BL
{
    internal class Phone
    {
        private double amount;
        private string remarks;
        public Phone(double amount,string remarks)
        {
            this.Amount = amount;
            this.Remarks = remarks;
        }
        public double Amount { get => amount; set => amount = value; }
        public string Remarks { get => remarks; set => remarks = value; }
    }
}
