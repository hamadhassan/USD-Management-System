using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;
using System.IO;

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
        public static Fee getAcademicFee()
        {
            foreach(Fee fee in feeList)
            {
                if (fee.FeeType == "Academic")
                {
                    return fee;
                }
            }
            return null;
        }
        public static Fee getHostelFee()
        {
            foreach (Fee fee in feeList)
            {
                if (fee.FeeType == "Hostel")
                {
                    return fee;
                }
            }
            return null;
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
        public static void clearList()
        {
            feeList.Clear();
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
            clearList();
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string feeType=parseData(record, 1);
                    string semester= parseData(record, 2);
                    string challanNo = parseData(record, 3);
                    double amount =double.Parse( parseData(record, 4));
                    string date = parseData(record, 5);
                    string remarks = parseData(record, 6);
                    Fee fee=new Fee(feeType,semester,challanNo,amount,date,remarks);
                    feeList.Add(fee);

                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeRecordIntoFile(Fee record, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(record.FeeType + "," + record.Semester + "," + record.ChallanNo + "," + record.Amount + "," + record.Date + "," + record.Remarks);
            file.Flush();
            file.Close();

        }
        public static void storeAllRecordIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Fee record in feeList)
            {
                file.WriteLine(record.FeeType + "," + record.Semester + "," + record.ChallanNo + "," + record.Amount + "," + record.Date + "," + record.Remarks);
            }
            file.Flush();
            file.Close();
        }
    }
}
