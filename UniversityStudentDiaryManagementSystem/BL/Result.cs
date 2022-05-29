using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStudentDiaryManagementSystem.BL
{
    public class Result
    {
        private string semester;
        private string gpa;
        private string cgpa;
        private string remarks;
        public Result(string semester, string gpa, string cgpa, string remarks)
        {
            this.semester = semester;
            this.gpa = gpa;
            this.cgpa = cgpa;
            this.remarks = remarks;
        }

        public string Semester { get => semester; set => semester = value; }
        public string Gpa { get => gpa; set => gpa = value; }
        public string Cgpa { get => cgpa; set => cgpa = value; }
        public string Remarks { get => remarks; set => remarks = value; }
    }
}
