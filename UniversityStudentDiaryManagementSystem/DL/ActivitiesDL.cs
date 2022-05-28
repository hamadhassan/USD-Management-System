using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;
using System.IO;

namespace UniversityStudentDiaryManagementSystem.DL
{
    internal class ActivitiesDL
    {
        private static List<Activities> activitiesList = new List<Activities>();
        public static bool setIntoActivitiesList(Activities activities)
        {
            activitiesList.Add(activities);
            return true;
        }
        public static List<Activities> getActivitieslist()
        {
            return activitiesList;
        }
        public static void deleteFromActivitiesList(Activities activities)
        {
            for (int index = 0; index < activitiesList.Count; index++)
            {
                if (activitiesList[index].TypeAcitivity == activities.TypeAcitivity && activitiesList[index].Minutes == activities.Minutes && activitiesList[index].Remarks == activities.Remarks)
                {
                    activitiesList.RemoveAt(index);
                }
            }
        }
        public static bool EditFromActivitiesList(Activities previous, Activities updated)
        {
            foreach (Activities a in activitiesList)
            {
                if (a.TypeAcitivity == previous.TypeAcitivity && a.Minutes == previous.Minutes && a.Remarks == previous.Remarks)
                {
                    a.TypeAcitivity = updated.TypeAcitivity;
                    a.Minutes = updated.Minutes;
                    a.Remarks = updated.Remarks;
                    return true;
                }
            }
            return false;
        }
        public static void clearList()
        {
            activitiesList.Clear();
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
                    string typeAcitivity = parseData(record, 1);
                    string minutes = parseData(record, 2);
                    string remarks= parseData(record, 3);
                    Activities activities = new Activities(typeAcitivity, minutes, remarks);
                    activitiesList.Add(activities);
                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeRecordIntoFile(Activities record, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(record.TypeAcitivity + "," + record.Minutes + "," + record.Remarks);
            file.Flush();
            file.Close();

        }
        public static void storeAllRecordIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Activities record in activitiesList)
            {
                file.WriteLine(record.TypeAcitivity + "," + record.Minutes + "," + record.Remarks);
            }
            file.Flush();
            file.Close();
        }
    }
}
