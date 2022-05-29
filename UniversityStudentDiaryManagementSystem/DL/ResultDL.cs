using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;
using System.IO;


namespace UniversityStudentDiaryManagementSystem.DL
{
    internal class ResultDL
    {
        private static List<Result> resultList = new List<Result>();
        public static bool setIntoResultList(Result meal)
        {
            resultList.Add(meal);
            return true;
        }
        public static List<Result> getResultlist()
        {
            return resultList;
        }
        public static void deleteFromResultList(Result result)
        {
            for (int index = 0; index < resultList.Count; index++)
            {
                if (resultList[index].Semester == result.Semester && resultList[index].Cgpa == result.Cgpa && resultList[index].Gpa == result.Gpa && resultList[index].Remarks == result.Remarks)
                {
                    resultList.RemoveAt(index);
                }
            }
        }
        public static bool EditFromResultlList(Result previous, Result updated)
        {
            foreach (Result a in resultList)
            {
                if (a.Semester == previous.Semester && a.Gpa == previous.Gpa && a.Cgpa == previous.Cgpa && a.Remarks == previous.Remarks)
                {
                    a.Semester = updated.Semester;
                    a.Gpa = updated.Gpa;
                    a.Cgpa = updated.Cgpa;
                    a.Remarks = updated.Remarks;
                    return true;
                }
            }
            return false;
        }
        public static void clearList()
        {
            resultList.Clear();
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
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string semester= parseData(record, 1);
                    string gpa=parseData(record, 2);
                    string cgpa=parseData(record, 3);
                    string remarks=parseData(record, 4);
                    Result result = new Result(semester, gpa, cgpa, remarks);
                    resultList.Add(result);
                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeRecordIntoFile(Result record, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(record.Semester + "," + record.Gpa + "," + record.Cgpa + "," + record.Remarks);
            file.Flush();
            file.Close();

        }
        public static void storeAllRecordIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Result record in resultList)
            {
                file.WriteLine(record.Semester + "," + record.Gpa + "," + record.Cgpa + "," + record.Remarks);
            }
            file.Flush();
            file.Close();
        }
    }
}
