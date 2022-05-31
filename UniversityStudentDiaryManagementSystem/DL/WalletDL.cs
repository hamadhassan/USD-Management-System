using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;
using System.IO;
using UniversityStudentDiaryManagementSystem.Paths;

namespace UniversityStudentDiaryManagementSystem.DL
{
    internal class WalletDL
    {
        public static double updateBalance()
        {
            FundDL.loadRecordFromFile(PathFile.Fund);
            HelpingMaterialDL.loadRecordFromFile(PathFile.HelpingMaterial);
            HostelExpenditureDL.loadRecordFromFile(PathFile.HostelExpenditure);
            MealDL.loadRecordFromFile(PathFile.Meal);
            PhoneDL.loadRecordFromFile(PathFile.Phone);
            TransportDL.loadRecordFromFile(PathFile.Transport);
            double fund=0;
            double helpingMaterial = 0;
            double hostelExpenditure = 0;
            double meal = 0;
            double phone = 0;
            double transport = 0;
            Wallet wallet = loadRecordFromFile(PathFile.Wallet);
            double openingBalance = wallet.Amount;
            foreach(Fund f in FundDL.getFundlist())
            {
                fund += f.Amount;
            }
            foreach(HelpingMaterial h in HelpingMaterialDL.getHelpingMateriallist())
            {
                helpingMaterial += h.Charges;
            }
            foreach(HostelExpenditure h in HostelExpenditureDL.getHostelExpenditurelist())
            {
                hostelExpenditure += h.Charges;
            }
            foreach(Meal m in MealDL.getMeallist())
            {
                meal += m.Charges;
            }
            foreach(Phone p in PhoneDL.getPhonelist())
            {
                phone += p.Amount;
            }
            foreach(Transport t in TransportDL.getTransportlist())
            {
                transport += t.Amount;
            }
            double closingBalance = openingBalance - fund - helpingMaterial - helpingMaterial - meal - phone - transport;
            return closingBalance;
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
