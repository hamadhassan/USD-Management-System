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
    public partial class frmFunds : Form
    {
        public frmFunds()
        {
            InitializeComponent();
        }

        private void frmFunds_Load(object sender, EventArgs e)
        {
            cmbxType.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
