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
        public static void deleteFromPhoneList(Phone phone)
        {
            for (int index = 0; index < phoneList.Count; index++)
            {
                if (phoneList[index].Amount == phone.Amount && phoneList[index].Remarks == phone.Remarks)
                {
                    phoneList.RemoveAt(index);
                }
            }
        }
        public static bool EditFromPhoneList(Phone previous, Phone updated)
        {
            foreach (Phone a in phoneList)
            {
                if (a.Amount == previous.Amount && a.Remarks == previous.Remarks)
                {
                    a.Amount = updated.Amount;
                    a.Remarks = updated.Remarks;
                    return true;
                }
            }
            return false;
        }
    }
}
