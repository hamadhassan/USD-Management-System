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
    }
}
