using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStudentDiaryManagementSystem.Path
{
    public class FilePath
    {
        private static string achivement = "achivement.txt";
        private static string activities = "activities.txt";
        private static string books = "book.txt";
        private static string credential = "credential.txt";
        private static string fee = "fee.txt";
        private static string fund = "fund.txt";
        private static string helpingMaterial = "helpingMaterial.txt";
        private static string hostelExpenditure = "hostelExpenditure.txt";
        private static string meal = "meal.txt";
        private static string phone = "phone.txt";
        private static string secret = "secret.txt";
        private static string transport = "transport.txt";
        private static string result = "result.txt";
        private static string wallet = "wallet.txt";

        public  static string Achivement { get => achivement; set => achivement = value; }
        public static string Activities { get => activities; set => activities = value; }
        public static string Books { get => books; set => books = value; }
        public static string Credential { get => credential; set => credential = value; }
        public static string Fee { get => fee; set => fee = value; }
        public static string Fund { get => fund; set => fund = value; }
        public static string HelpingMaterial { get => helpingMaterial; set => helpingMaterial = value; }
        public static string HostelExpenditure { get => hostelExpenditure; set => hostelExpenditure = value; }
        public static string Meal { get => meal; set => meal = value; }
        public static string Phone { get => phone; set => phone = value; }
        public static string Secret { get => secret; set => secret = value; }
        public static string Transport { get => transport; set => transport = value; }
        public static string Wallet { get => wallet; set => wallet = value; }
        public static string Result { get => result; set => result = value; }
    }
}
