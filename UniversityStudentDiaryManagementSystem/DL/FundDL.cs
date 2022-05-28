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
        public static void deleteFromFundList(Fund fund)
        {
            for (int index = 0; index < fundList.Count; index++)
            {
                if (fundList[index].TypeFund == fund.TypeFund && fundList[index].Amount == fund.Amount && fundList[index].Remarks == fund.Remarks)
                {
                    fundList.RemoveAt(index);

                }
            }
        }
        public static bool EditFromFundList(Fund previous, Fund updated)
        {
            foreach (Fund a in fundList)
            {
                if (a.TypeFund == previous.TypeFund && a.Amount == previous.Amount  && a.Remarks == previous.Remarks)
                {
                    a.TypeFund = updated.TypeFund;
                    a.Amount = updated.Amount;
                    a.Remarks = updated.Remarks;
                    return true;
                }
            }
            return false;
        }
    }
}
