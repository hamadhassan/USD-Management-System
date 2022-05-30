using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;
using System.IO;

namespace UniversityStudentDiaryManagementSystem.DL
{
    internal class HelpingMaterialDL
    {
        private static List<HelpingMaterial> helpingMaterialList = new List<HelpingMaterial>();
        public static bool setIntoHelpingMaterialList(HelpingMaterial helpingMaterial)
        {
            helpingMaterialList.Add(helpingMaterial);
            return true;
        }
        public static List<HelpingMaterial> getHelpingMateriallist()
        {
            return helpingMaterialList;
        }
        public static void deleteFromHelpingMaterialList(HelpingMaterial helpingMaterial)
        {
            for (int index = 0; index < helpingMaterialList.Count; index++)
            {
                if (helpingMaterialList[index].TypeHelpingMaterial == helpingMaterial.TypeHelpingMaterial && helpingMaterialList[index].Charges == helpingMaterial.Charges && helpingMaterialList[index].Remarks == helpingMaterial.Remarks)
                {
                    helpingMaterialList.RemoveAt(index);

                }
            }
        }
        public static bool EditFromhelpingMaterialList(HelpingMaterial previous, HelpingMaterial updated)
        {
            foreach (HelpingMaterial a in helpingMaterialList)
            {
                if (a.TypeHelpingMaterial == previous.TypeHelpingMaterial && a.Charges == previous.Charges && a.Remarks == previous.Remarks)
                {
                    a.TypeHelpingMaterial = updated.TypeHelpingMaterial;
                    a.Charges = updated.Charges;
                    a.Remarks = updated.Remarks;
                    return true;
                }
            }
            return false;
        }
        public static void clearList()
        {
            helpingMaterialList.Clear();
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
                    string typeHelpingMaterial = parseData(record, 1);
                    double charges= double.Parse(parseData(record, 2));
                    string remarks= parseData(record, 3);
                    HelpingMaterial helpingMaterial = new HelpingMaterial(typeHelpingMaterial, charges, remarks);
                    helpingMaterialList.Add(helpingMaterial);
                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeRecordIntoFile(HelpingMaterial record, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(record.TypeHelpingMaterial + "," + record.Charges + "," + record.Remarks);
            file.Flush();
            file.Close();

        }
        public static void storeAllRecordIntoFile(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (HelpingMaterial record in helpingMaterialList)
            {
                file.WriteLine(record.TypeHelpingMaterial + "," + record.Charges + "," + record.Remarks);
            }
            file.Flush();
            file.Close();
        }
    }

}
