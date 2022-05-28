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
        public static void deleteFromHostelExpenditureList(HostelExpenditure hostelExpenditure)
        {
            for (int index = 0; index < hostelExpenditureList.Count; index++)
            {
                if (hostelExpenditureList[index].TypeHostelExpenditure == hostelExpenditure.TypeHostelExpenditure && hostelExpenditureList[index].Month == hostelExpenditure.Month && hostelExpenditureList[index].Charges == hostelExpenditure.Charges && hostelExpenditureList[index].Remarks == hostelExpenditure.Remarks)
                {
                    hostelExpenditureList.RemoveAt(index);

                }
            }
        }
        public static bool EditFromHostelExpenditureList(HostelExpenditure previous, HostelExpenditure updated)
        {
            foreach (HostelExpenditure a in hostelExpenditureList)
            {
                if (a.TypeHostelExpenditure == previous.TypeHostelExpenditure && a.Month == previous.Month && a.Charges == previous.Charges && a.Remarks == previous.Remarks)
                {
                    a.TypeHostelExpenditure = updated.TypeHostelExpenditure;
                    a.Month = updated.Month;
                    a.Charges = updated.Charges;
                    a.Remarks = updated.Remarks;
                    return true;
                }
            }
            return false;
        }
    }
}
