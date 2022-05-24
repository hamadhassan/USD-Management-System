using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;

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
    }
}
