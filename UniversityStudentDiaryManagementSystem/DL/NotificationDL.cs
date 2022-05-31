using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using UniversityStudentDiaryManagementSystem.BL;

namespace UniversityStudentDiaryManagementSystem.DL
{
    internal class NotificationDL
    {
        private static List<Notification> notificationList = new List<Notification>();
        public static void setIntoNotificationList(Notification notification)
        {
            notificationList.Add(notification);
        }
        public static List<Notification> getNotificationlist()
        {
            return notificationList;
        }
        public static string getNotificationByID(int id)
        {
            foreach (Notification notification in notificationList)
            {
                if (notification.Id == id)
                {
                    return notification.Message;
                }
            }
            return null;
        }
        public static void clearListAtID(int id)
        {
            int index=0;
            foreach(Notification notification in notificationList)
            {
                if (notification.Id == id)
                {
                    notificationList.RemoveAt(index);
                }
                index++;
            }
        }
        public static void updateMessage(int id,string message)
        {
            int index = 0;
            foreach (Notification n in notificationList)
            {
                if (n.Id == id)
                {
                    notificationList.RemoveAt(index);
                    Notification notification = new Notification(message, id);
                    notificationList.Add(notification);
                    break;
                }
                index++;
            }
        }
        public static bool isListEmpty()
        {
            if(notificationList.Count == 0)
            {
                return true;
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
        public static bool loadRecordFromFile(string path)
        {
            notificationList.Clear();
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string message = parseData(record, 1);
                    int id =int.Parse(parseData(record, 2));
                    if (id == 1)
                    {
                        Notification notification=new Notification(message,id);
                        notificationList.Add(notification);
                    }
                    else if (id == 2)
                    {
                        Notification notification = new Notification(message, id);
                        notificationList.Add(notification);
                    }
                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeRecordIntoFile(Notification record, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(record.Message + ","+record.Id);
            file.Flush();
            file.Close();

        }
        public static void storeAllRecordIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Notification record in notificationList)
            {
                file.WriteLine(record.Message + "," + record.Id);
            }
            file.Flush();
            file.Close();
        }
    }
}
