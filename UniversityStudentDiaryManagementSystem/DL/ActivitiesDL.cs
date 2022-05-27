using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;

namespace UniversityStudentDiaryManagementSystem.DL
{
    internal class ActivitiesDL
    {
        private static List<Activities> activitiesList = new List<Activities>();
        public static bool setIntoActivitiesList(Activities activities)
        {
            activitiesList.Add(activities);
            return true;
        }
        public static List<Activities> getActivitieslist()
        {
            return activitiesList;
        }
        public static void deleteFromActivitiesList(Activities activities)
        {
            for (int index = 0; index < activitiesList.Count; index++)
            {
                if (activitiesList[index].TypeAcitivity == activities.TypeAcitivity && activitiesList[index].Minutes == activities.Minutes && activitiesList[index].Remarks == activities.Remarks)
                {
                    activitiesList.RemoveAt(index);
                }
            }
        }
        public static bool EditFromActivitiesList(Activities previous, Activities updated)
        {
            foreach (Activities a in activitiesList)
            {
                if (a.TypeAcitivity == previous.TypeAcitivity && a.Minutes == previous.Minutes && a.Remarks == previous.Remarks)
                {
                    a.TypeAcitivity = updated.TypeAcitivity;
                    a.Minutes = updated.Minutes;
                    a.Remarks = updated.Remarks;
                    return true;
                }
            }
            return false;
        }
    }
}
