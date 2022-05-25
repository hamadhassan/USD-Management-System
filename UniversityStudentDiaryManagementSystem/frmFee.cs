using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityStudentDiaryManagementSystem
{
    public partial class frmFee : Form
    {
        public frmFee()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbxAcademicSemester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmFee_Load(object sender, EventArgs e)
        {
            cmbxAcademicSemester.SelectedIndex = 0 ;
            cobxHostelSemester.SelectedIndex = 0;
        }

        private void btnAcademicClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHostelClose_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
