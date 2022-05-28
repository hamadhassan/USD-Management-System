using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;
using System.IO;

namespace UniversityStudentDiaryManagementSystem.DL
{
    internal class AchivementDL
    {
        private static List<Achivement> achivementList=new List<Achivement>();
        public static bool setIntoAchivementsList(Achivement achivement)
        {
            achivementList.Add(achivement);
            return true;
        }
        public static List<Achivement> getAchivementslist()
        {
            return achivementList;
        }
        public static void deleteFromAchivementsList(Achivement achivement)
        {
            for (int index = 0; index < achivementList.Count; index++)
            {
                if (achivementList[index].TypeAchivement == achivement.TypeAchivement && achivementList[index].PresentedBy == achivement.PresentedBy&& achivementList[index].Remakrks == achivement.Remakrks)
                {
                    achivementList.RemoveAt(index);
                }
            }

        }
        public static bool EditFromAchivementsList(Achivement previous, Achivement updated)
        {
            foreach (Achivement a in achivementList)
            {
                if (a.TypeAchivement == previous.TypeAchivement && a.PresentedBy == previous.PresentedBy && a.Remakrks == previous.Remakrks)
                {
                    a.TypeAchivement = updated.TypeAchivement;
                    a.PresentedBy = updated.PresentedBy;
                    a.Remakrks = updated.Remakrks;
                    return true;
                }
            }
            return false;
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
        public static bool readRecordFromFile(string path)
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string typeAchivement=parseData(record,1);
                    string presentedBy =parseData(record,2);
                    string remark=parseData(record,3);
                    Achivement achivement=new Achivement(typeAchivement,presentedBy,remark);
                    achivementList.Add(achivement);
                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void storeRecordIntoFile(Achivement record, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(record.TypeAchivement + "," + record.PresentedBy + "," + record.Remakrks);
            file.Flush();
            file.Close();

        }
        public static void storeAllRecordIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Achivement record in achivementList)
            {
                file.WriteLine(record.TypeAchivement + "," + record.PresentedBy + "," + record.Remakrks);
            }
            file.Flush();
            file.Close();
        }

    }
}
