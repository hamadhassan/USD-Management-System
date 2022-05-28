using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;

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
    }
}
