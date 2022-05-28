using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityStudentDiaryManagementSystem.BL;

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
    }
}
