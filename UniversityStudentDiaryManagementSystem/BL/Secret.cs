using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStudentDiaryManagementSystem.BL
{
    public class Secret
    {
        private string typeSecret;
        private string detail;
        public Secret(string typeSecret,string detail)
        {
            this.typeSecret = typeSecret;
            this.detail = detail;
        }
        public string TypeSecret { get => typeSecret; set => typeSecret = value; }
        public string Detail { get => detail; set => detail = value; }
    }
}
