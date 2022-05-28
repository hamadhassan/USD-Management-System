using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityStudentDiaryManagementSystem.BL
{
    public class Meal
    {
        private string typeMeal;
        private string menu;
        private double charges;
        private string remakrs;
        public Meal(string typeMeal,string menu,double charges,string remakrs)
        {
            this.typeMeal = typeMeal;
            this.menu = menu;
            this.charges = charges;
            this.remakrs = remakrs;
        }

        public string TypeMeal { get => typeMeal; set => typeMeal = value; }
        public string Menu { get => menu; set => menu = value; }
        public double Charges { get => charges; set => charges = value; }
        public string Remakrs { get => remakrs; set => remakrs = value; }
    }
}
