using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;

namespace UniversityStudentDiaryManagementSystem.DL
{
    internal class FundDL
    {
        private static List<Fund> fundList = new List<Fund>();
        public static bool setIntoFundList(Fund fund)
        {
            fundList.Add(fund);
            return true;
        }
        public static List<Fund> getFundlist()
        {
            return fundList;
        }
    }
}
