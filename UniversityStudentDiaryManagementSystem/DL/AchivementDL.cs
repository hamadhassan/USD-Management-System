using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;

namespace UniversityStudentDiaryManagementSystem.DL
{
    internal class AchivementDL
    {
        private static List<Achivement> achivementList=new List<Achivement>();
        public static bool setIntoAchivementsList(Achivement achivement)
        {
            achivementList.Add(achivement);
            return true;
        }
        public static List<Achivement> getAchivementslist()
        {
            return achivementList;
        }

    }
}
