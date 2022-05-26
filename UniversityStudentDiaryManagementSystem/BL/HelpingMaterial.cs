using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStudentDiaryManagementSystem.BL
{
    internal class HelpingMaterial
    {
        private string typeHelpingMaterial;
        private double charges;
        private string remarks;
        public HelpingMaterial(string typeHelpingMaterial, double charges, string remarks)
        {
            this.TypeHelpingMaterial = typeHelpingMaterial;
            this.Charges = charges;
            this.Remarks = remarks;
        }
        public string TypeHelpingMaterial { get => typeHelpingMaterial; set => typeHelpingMaterial = value; }
        public double Charges { get => charges; set => charges = value; }
        public string Remarks { get => remarks; set => remarks = value; }
    }
}
