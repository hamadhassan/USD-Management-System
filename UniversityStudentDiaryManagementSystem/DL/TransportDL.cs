using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;
using System.IO;

namespace UniversityStudentDiaryManagementSystem.DL
{
    internal class TransportDL
    {
        private static List<Transport> transportList = new List<Transport>();
        public static bool setIntoTransportList(Transport transport)
        {
            transportList.Add(transport);
            return true;
        }
        public static List<Transport> getTransportlist()
        {
            return transportList;
        }
        public static void deleteFromTransportList(Transport transport)
        {
            for (int index = 0; index < transportList.Count; index++)
            {
                if (transportList[index].TypeTransport == transport.TypeTransport && transportList[index].PickupLocation == transport.PickupLocation && transportList[index].Destination == transport.Destination &&  transportList[index].Amount == transport.Amount&& transportList[index].Remarks == transport.Remarks)
                {
                    transportList.RemoveAt(index);

                }
            }
        }
        public static bool EditFromTransportList(Transport previous, Transport updated)
        {
            foreach (Transport a in transportList)
            {
                if (a.TypeTransport == previous.TypeTransport&& a.PickupLocation == previous.PickupLocation&& a.Destination == previous.Destination && a.Amount == previous.Amount && a.Remarks == previous.Remarks)
                {
                    a.TypeTransport = updated.TypeTransport;
                    a.PickupLocation = updated.PickupLocation;
                    a.Destination = updated.Destination;
                    a.Amount = updated.Amount;
                    a.Remarks = updated.Remarks;
                    return true;
                }
            }
            return false;
        }
        public static void clearList()
        {
            transportList.Clear();
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
                    string typeTransport = parseData(record, 1);
                    string pickupLocation = parseData(record, 2);
                    string destination = parseData(record, 3);
                    double amount =double.Parse(parseData(record, 4));
                    string remarks= parseData(record, 5);
                    Transport transport = new Transport(typeTransport, pickupLocation, destination, amount, remarks);
                    transportList.Add(transport);
                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeRecordIntoFile(Transport record, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(record.TypeTransport + "," + record.PickupLocation + "," + record.Destination + "," + record.Amount + "," + record.Remarks);
            file.Flush();
            file.Close();

        }
        public static void storeAllRecordIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Transport record in transportList)
            {
                file.WriteLine(record.TypeTransport + "," + record.PickupLocation + "," + record.Destination + "," + record.Amount + "," + record.Remarks);
            }
            file.Flush();
            file.Close();
        }
    }
}
