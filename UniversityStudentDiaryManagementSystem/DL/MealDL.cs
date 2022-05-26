using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;

namespace UniversityStudentDiaryManagementSystem.DL
{
    internal class MealDL
    {
        private static List<Meal> mealList = new List<Meal>();
        public static bool setIntoMealList(Meal meal)
        {
            mealList.Add(meal);
            return true;
        }
        public static List<Meal> getMeallist()
        {
            return mealList;
        }
    }
}
