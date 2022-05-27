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
        public static void deleteFromAchivementsList(Achivement achivement)
        {
            for (int index = 0; index < achivementList.Count; index++)
            {
                if (achivementList[index].TypeAchivement == achivement.TypeAchivement && achivementList[index].PresentedBy == achivement.PresentedBy&& achivementList[index].Remakrks == achivement.Remakrks)
                {
                    achivementList.RemoveAt(index);
                }
            }

        }
        public static bool EditFromAchivementsList(Achivement previous, Achivement updated)
        {
            foreach (Achivement a in achivementList)
            {
                if (a.TypeAchivement == previous.TypeAchivement && a.PresentedBy == previous.PresentedBy && a.Remakrks == previous.Remakrks)
                {
                    a.TypeAchivement = updated.TypeAchivement;
                    a.PresentedBy = updated.PresentedBy;
                    a.Remakrks = updated.Remakrks;
                    return true;
                }
            }
            return false;
        }
        
    }
}
