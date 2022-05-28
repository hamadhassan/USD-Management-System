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
        public static bool updatePassword(string oldPassword, string newPassword)
        {
            int index = 0;
            foreach (Credential c in crediantialsList)
            {
                if (c.Password == oldPassword)
                {
                    c.Password= newPassword;
                    crediantialsList.Insert(index,c);
                    index++;
                    return true;
                }
            }
            return false;
        }
       
    }
}
