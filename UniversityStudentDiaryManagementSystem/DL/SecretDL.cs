using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;
using System.IO;

namespace UniversityStudentDiaryManagementSystem.DL
{
    internal class SecretDL
    {
        private static List<Secret> secretList = new List<Secret>();
        public static bool setIntoSecretList(Secret secret)
        {
            secretList.Add(secret);
            return true;
        }
        public static List<Secret> getSecretlist()
        {
            return secretList;
        }
        public static void deleteFromSecretList(Secret secret)
        {
            for (int index = 0; index < secretList.Count; index++)
            {
                if (secretList[index].TypeSecret == secret.TypeSecret && secretList[index].Detail == secret.Detail)
                {
                    secretList.RemoveAt(index);
                }
            }
        }
        public static bool EditFromSecretList(Secret previous, Secret updated)
        {
            foreach (Secret a in secretList)
            {
                if (a.TypeSecret == previous.TypeSecret && a.Detail == previous.Detail)
                {
                    a.TypeSecret = updated.TypeSecret;  
                    a.Detail = updated.Detail;
                    return true;
                }
            }
            return false;
        }
        public static void clearList()
        {
            secretList.Clear();
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
                    string typeSecret=parseData(record, 1);
                    string detail = parseData(record, 2);
                    Secret secret = new Secret(typeSecret, detail);
                    secretList.Add(secret);
                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeRecordIntoFile(Secret record, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(record.TypeSecret + "," + record.Detail);
            file.Flush();
            file.Close();

        }
        public static void storeAllRecordIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Secret record in secretList)
            {
                file.WriteLine(record.TypeSecret + "," + record.Detail);
            }
            file.Flush();
            file.Close();
        }
    }
}
