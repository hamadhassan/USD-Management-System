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
    }
}
