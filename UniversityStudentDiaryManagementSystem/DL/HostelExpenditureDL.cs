using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;

namespace UniversityStudentDiaryManagementSystem.DL
{
    internal class HostelExpenditureDL
    {
        private static List<HostelExpenditure> hostelExpenditureList = new List<HostelExpenditure>();
        public static bool setIntoHostelExpenditureList(HostelExpenditure hostelExpenditure)
        {
            hostelExpenditureList.Add(hostelExpenditure);
            return true;
        }
        public static List<HostelExpenditure> getHostelExpenditurelist()
        {
            return hostelExpenditureList;
        }
    }
}
