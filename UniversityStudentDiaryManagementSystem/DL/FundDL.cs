using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;
using System.IO;

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
        public static void clearList()
        {
            fundList.Clear();
        }
        public static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        public static bool loadRecordFromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string typeFund = parseData(record, 1);
                    double amount=double.Parse( parseData(record, 2));
                    string remarks= parseData(record, 3);
                    Fund fund = new Fund(typeFund, amount, remarks);
                    fundList.Add(fund);
                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeRecordIntoFile(Fund record, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(record.TypeFund + "," + record.Amount + "," + record.Remarks);
            file.Flush();
            file.Close();

        }
        public static void storeAllRecordIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Fund record in fundList)
            {
                file.WriteLine(record.TypeFund + "," + record.Amount + "," + record.Remarks);
            }
            file.Flush();
            file.Close();
        }
    }
}
