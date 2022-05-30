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
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string academicFeeNotification = parseData(record, 1);
                    string hostelFeeNotification = parseData(record, 2);
                    Notification notification=new Notification(academicFeeNotification, hostelFeeNotification);
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
