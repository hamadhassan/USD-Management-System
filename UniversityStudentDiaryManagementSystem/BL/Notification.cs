using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStudentDiaryManagementSystem.BL
{
    internal class Notification
    {
        private string message;
        private int id;
        public Notification(string message,int id)
        {
            if (id == 1)
            {
                this.message = message;
                this.id = id;
            }
            else if(id == 2)
            {
                this.message = message;
                this.id = id;
            }
        }
        public string Message { get => message; set => message = value; }
        public int Id { get => id; set => id = value; }
    }
}
