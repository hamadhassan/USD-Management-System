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
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbcType.SelectedIndex == 1)
            {
                lblBookFrom.Text = "Friend Name :";
            }
            else if(cmbcType.SelectedIndex == 2)
            {
                lblBookFrom.Text = "Publisher :";

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            cmbcType.SelectedIndex = 0;
        }
    }
}
