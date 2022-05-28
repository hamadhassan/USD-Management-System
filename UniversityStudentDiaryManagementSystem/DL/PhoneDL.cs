using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;
using System.IO;

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
        public static void clearList()
        {
            phoneList.Clear();
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
                    double amount=double.Parse( parseData(record, 1));
                    string remarks= parseData(record, 2);
                    Phone phone = new Phone(amount, remarks);
                    phoneList.Add(phone);  
                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeRecordIntoFile(Phone record, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(record.Amount + "," + record.Remarks);
            file.Flush();
            file.Close();

        }
        public static void storeAllRecordIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Phone record in phoneList)
            {
                file.WriteLine(record.Amount + "," + record.Remarks);
            }
            file.Flush();
            file.Close();
        }
    }
}
