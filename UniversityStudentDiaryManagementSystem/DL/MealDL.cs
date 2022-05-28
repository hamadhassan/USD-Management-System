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
        public static void deleteFromMealList(Meal meal)
        {
            for (int index = 0; index < mealList.Count; index++)
            {
                if (mealList[index].TypeMeal == meal.TypeMeal && mealList[index].Menu == meal.Menu && mealList[index].Charges == meal.Charges && mealList[index].Remakrs == meal.Remakrs)
                {
                    mealList.RemoveAt(index);

                }
            }
        }
        public static bool EditFromMealList(Meal previous, Meal updated)
        {
            foreach (Meal a in mealList)
            {
                if (a.TypeMeal == previous.TypeMeal && a.Menu == previous.Menu && a.Charges == previous.Charges && a.Remakrs == previous.Remakrs)
                {
                    a.TypeMeal = updated.TypeMeal;
                    a.Menu = updated.Menu;
                    a.Charges = updated.Charges;
                    a.Remakrs = updated.Remakrs;
                    return true;
                }
            }
            return false;
        }
    }
}
