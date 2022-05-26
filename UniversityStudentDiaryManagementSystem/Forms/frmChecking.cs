using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityStudentDiaryManagementSystem.DL;

namespace UniversityStudentDiaryManagementSystem.Forms
{
    public partial class frmChecking : Form
    {
        public frmChecking()
        {
            InitializeComponent();
        }

        private void frmChecking_Load(object sender, EventArgs e)
        {
          dataGridView1.DataSource=PhoneDL.getPhonelist();
        }
    }
}
