using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStudentDiaryManagementSystem.BL
{
    public class BookPublisher:Book
    {
        private double amount;
        public BookPublisher(string typeBook, string title, string authorName, string bookFrom, string remarks,double amount) : base(typeBook, title, authorName, bookFrom, remarks)
        {
            this.amount = amount;
        }
        public double Amount { get => amount; set => amount = value; }
    }
}
