using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;

namespace UniversityStudentDiaryManagementSystem.DL
{
    internal class FeeDL
    {
        private static List<Fee> feeList = new List<Fee>();
        public static bool setIntoFeeList(Fee fee)
        {
            feeList.Add(fee);
            return true;
        }
        public static List<Fee> getFeeList()
        {
            return feeList;
        }
    }
}
