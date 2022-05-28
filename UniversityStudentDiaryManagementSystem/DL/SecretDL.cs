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
        public static void deleteFromSecretList(Secret secret)
        {
            for (int index = 0; index < secretList.Count; index++)
            {
                if (secretList[index].TypeSecret == secret.TypeSecret && secretList[index].Detail == secret.Detail)
                {
                    secretList.RemoveAt(index);
                }
            }
        }
        public static bool EditFromSecretList(Secret previous, Secret updated)
        {
            foreach (Secret a in secretList)
            {
                if (a.TypeSecret == previous.TypeSecret && a.Detail == previous.Detail)
                {
                    a.TypeSecret = updated.TypeSecret;  
                    a.Detail = updated.Detail;
                    return true;
                }
            }
            return false;
        }
    }
}
