using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStudentDiaryManagementSystem.BL
{
    public class Transport
    {
        private string typeTransport;
        private string pickupLocation;
        private string destination;
        private double amount;
        private string remarks;
        public Transport(string typeTransport, string pickupLocation, string destination, double amount, string remarks)
        {
            this.typeTransport = typeTransport;
            this.pickupLocation = pickupLocation;
            this.destination = destination;
            this.amount = amount;
            this.remarks = remarks;
        }
        public string TypeTransport { get => typeTransport; set => typeTransport = value; }
        public string PickupLocation { get => pickupLocation; set => pickupLocation = value; }
        public string Destination { get => destination; set => destination = value; }
        public double Amount { get => amount; set => amount = value; }
        public string Remarks { get => remarks; set => remarks = value; }
    }
}
