using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;

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
    }
}
