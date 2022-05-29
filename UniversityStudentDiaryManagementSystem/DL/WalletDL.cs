using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;
using System.IO;

namespace UniversityStudentDiaryManagementSystem.DL
{
    internal class WalletDL
    {
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
        public static Wallet loadRecordFromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    double amount =double.Parse(parseData(record, 1));
                    string comment = parseData(record, 2);
                    Wallet wallet = new Wallet(amount, comment);
                    return wallet;
                }
                fileVariable.Close();
                return null;
            }
            else
            {
                return null;
            }
        }
        public static void storeRecordIntoFile(Wallet record, string path)
        {
            StreamWriter file = new StreamWriter(path);
            file.WriteLine(record.Amount + "," + record.Comments);
            file.Flush();
            file.Close();

        }
    }
}
