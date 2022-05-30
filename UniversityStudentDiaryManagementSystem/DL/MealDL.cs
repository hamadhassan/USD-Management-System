using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;
using System.IO;

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
        public static void clearList()
        {
            mealList.Clear();
        }
        public static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        public static bool loadRecordFromFile(string path)
        {
            clearList();
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string typeMeal= parseData(record, 1);
                    string menu=parseData(record, 2);
                    double charges= double.Parse(parseData(record, 3));
                    string remakrs= parseData(record, 4);
                    Meal meal = new Meal(typeMeal, menu, charges, remakrs);
                    mealList.Add(meal);
                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeRecordIntoFile(Meal record, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(record.TypeMeal + "," + record.Menu + "," + record.Charges + "," + record.Remakrs);
            file.Flush();
            file.Close();

        }
        public static void storeAllRecordIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Meal record in mealList)
            {
                file.WriteLine(record.TypeMeal + "," + record.Menu + "," + record.Charges + "," + record.Remakrs);
            }
            file.Flush();
            file.Close();
        }
    }
}
