using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;
using System.IO;

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
        public static void clearList()
        {
            hostelExpenditureList.Clear();
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
                    string typeHostelExpenditure= parseData(record, 1);
                    string month=parseData(record, 2);
                    double charges =double.Parse( parseData(record, 3));
                    string remarks = parseData(record, 4);
                    HostelExpenditure hostelExpenditure=new HostelExpenditure(typeHostelExpenditure, month, charges, remarks);
                    hostelExpenditureList.Add(hostelExpenditure);
                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeRecordIntoFile(HostelExpenditure record, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(record.TypeHostelExpenditure + "," + record.Month + "," + record.Charges + "," + record.Remarks);
            file.Flush();
            file.Close();

        }
        public static void storeAllRecordIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (HostelExpenditure record in hostelExpenditureList)
            {
                file.WriteLine(record.TypeHostelExpenditure + "," + record.Month + "," + record.Charges + "," + record.Remarks);
            }
            file.Flush();
            file.Close();
        }

    }
}
