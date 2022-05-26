using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;

namespace UniversityStudentDiaryManagementSystem.DL
{
    internal class PhoneDL
    {
        private static List<Phone> phoneList = new List<Phone>();
        public static bool setIntoPhoneList(Phone meal)
        {
            phoneList.Add(meal);
            return true;
        }
        public static List<Phone> getPhonelist()
        {
            return phoneList;
        }
    }
}
