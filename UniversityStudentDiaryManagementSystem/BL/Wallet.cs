using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStudentDiaryManagementSystem.BL
{
    public class Wallet
    {
        private double amount;
        private string comments;
        public Wallet(double amount, string comments)
        {
            this.amount = amount;
            this.comments = comments;
        }
        public double Amount { get => amount; set => amount = value; }
        public string Comments { get => comments; set => comments = value; }
    }
}
