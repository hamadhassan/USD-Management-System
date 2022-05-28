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
        public static void deleteFromFeeList(Fee fee)
        {
            for (int index = 0; index < feeList.Count; index++)
            {
                if (feeList[index].FeeType == fee.FeeType && feeList[index].Semester == fee.Semester && feeList[index].ChallanNo == fee.ChallanNo && feeList[index].Amount == fee.Amount && feeList[index].Date == fee.Date && feeList[index].Remarks == fee.Remarks)
                {
                    feeList.RemoveAt(index);

                }
            }
        }
        public static bool EditFromFeeList(Fee previous, Fee updated)
        {
            foreach (Fee a in feeList)
            {
                if (a.FeeType == previous.FeeType && a.Semester == previous.Semester && a.ChallanNo == previous.ChallanNo && a.Amount == previous.Amount && a.Date == previous.Date && a.Remarks == previous.Remarks)
                {
                    a.FeeType = updated.FeeType;
                    a.Semester = updated.Semester;
                    a.Amount = updated.Amount;
                    a.ChallanNo = updated.ChallanNo;
                    a.Date = updated.Date;
                    a.Remarks = updated.Remarks;
                    return true;
                }
            }
            return false;
        }
    }
}
