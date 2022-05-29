using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;
using System.IO;

namespace UniversityStudentDiaryManagementSystem.DL
{
    internal class CredentialDL
    {
        private static List<Credential> crediantialsList = new List<Credential>();

        public static void setIntoListCrediantialList(Credential newUser)
        {
            crediantialsList.Add(newUser);
        }
        public static List<Credential> getCrediationalList()
        {
            return crediantialsList;
        }
        public static bool isUserNameExist(string username)
        {
            foreach (Credential c in crediantialsList)
            {
                if (c.Username == username)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool updatePassword(string oldPassword, string newPassword,string username1,string role1)
        {
            int index = 0;
            foreach (Credential c in crediantialsList)
            {
                if (c.Role==role1 && c.Username==username1 && c.Password == oldPassword)
                {
                    string firstName=c.FirstName;
                    string lastName=c.LastName;
                    string username=c.Username;
                    string password=newPassword;
                    string role=c.Role;
                    crediantialsList.RemoveAt(index);
                    Credential credential=new Credential(firstName, lastName, username, password, role);
                    crediantialsList.Add(credential);
                    return true;
                }
                index++;
            }
            return false;
        }
        public static void clearList()
        {
            crediantialsList.Clear();
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
                    string firstName=parseData(record,1);
                    string lastName = parseData(record, 2);
                    string username = parseData(record, 3);
                    string password = parseData(record, 4);
                    string role = parseData(record, 5);
                    Credential credential = new Credential(firstName, lastName, username, password, role);
                    crediantialsList.Add(credential);  
                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeRecordIntoFile(Credential record, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(record.FirstName + "," + record.LastName + "," + record.Username + "," + record.Password + "," + record.Role);
            file.Flush();
            file.Close();

        }
        public static void storeAllRecordIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Credential record in crediantialsList)
            {
                file.WriteLine(record.FirstName + "," + record.LastName + "," + record.Username + "," + record.Password + "," + record.Role);
            }
            file.Flush();
            file.Close();
        }


    }
}
