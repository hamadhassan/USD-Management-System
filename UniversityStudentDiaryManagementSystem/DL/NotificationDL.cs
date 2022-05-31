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
        public static bool setIntoNotificationList(Notification notification)
        {
            notificationList.Add(notification);
            return true;
        }
        public static List<Notification> getNotificationlist()
        {
            return notificationList;
        }
        public static void removeAt(int index)
        {
            notificationList.RemoveAt(index);
        }
        public static void clearListAtID(int id)
        {
            int index=0;
            foreach(Notification notification in notificationList)
            {
                int _id =notification.Id;
                if (_id == 1)
                {
                    notificationList.RemoveAt(index);

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
        public static  void updateMessageAcademicFee(string newMessage)
        {
            int index=0;
            foreach(Notification n in notificationList)
            {
                if (n.Id == 0)
                {
                    notificationList.RemoveAt(index);
                    string academicFeeNotification=newMessage;
                    string hostelFeeNotification=n.HostelFeeNotification;
                    Notification notification = new Notification(academicFeeNotification, hostelFeeNotification);
                    notificationList.Add(notification);
                }
                else if (n.Id == 1)
                {
                    notificationList.RemoveAt(index);
                    string academicFeeNotification = newMessage;
                    Notification notification = new Notification(academicFeeNotification, 1);
                    notificationList.Add(notification);
                }
                index++;
            }
        }
        public static void updateMessageHostelFee(string newMessage)
        {
            int index = 0;
            foreach (Notification n in notificationList)
            {
                if (n.Id == 0)
                {
                    notificationList.RemoveAt(index);
                    string academicFeeNotification = n.AcademicFeeNotification;
                    string hostelFeeNotification = newMessage;
                    Notification notification = new Notification(academicFeeNotification, hostelFeeNotification);
                    notificationList.Add(notification);
                }
               else if (n.Id == 2)
                {
                    notificationList.RemoveAt(index);
                    string hostelFeeNotification = newMessage;
                    Notification notification = new Notification(hostelFeeNotification,2);
                    notificationList.Add(notification);
                }
                index++;
            }
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
                    string academicFeeNotification = parseData(record, 1);
                    string hostelFeeNotification = parseData(record, 2);
                    int id =int.Parse(parseData(record, 3));
                    Notification notification=new Notification(academicFeeNotification, hostelFeeNotification,id);
                    notificationList.Add(notification);
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
            file.WriteLine(record.AcademicFeeNotification + ","+ record.HostelFeeNotification+","+record.Id);
            file.Flush();
            file.Close();

        }
        public static void storeAllRecordIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Notification record in notificationList)
            {
                file.WriteLine(record.AcademicFeeNotification + "," + record.HostelFeeNotification + "," + record.Id);

            }
            file.Flush();
            file.Close();
        }
    }
}
