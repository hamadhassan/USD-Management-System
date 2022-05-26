using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityStudentDiaryManagementSystem.BL;
using UniversityStudentDiaryManagementSystem.DL;


namespace UniversityStudentDiaryManagementSystem
{
    public partial class frmMeal : Form
    {
        private int selectedIndex;
        public frmMeal(int selectedIndex)
        {
            InitializeComponent();
            this.selectedIndex = selectedIndex;
        }

        private void frmMeal_Load(object sender, EventArgs e)
        {
            if (selectedIndex == 0)
            {
                cmbxTime.SelectedIndex = 0;
            }
            else if (selectedIndex == 1)
            {
                cmbxTime.SelectedIndex = 1;
            }
            else if (selectedIndex == 2)
            {
                cmbxTime.SelectedIndex = 2;
            }
            else if (selectedIndex == 3)
            {
                cmbxTime.SelectedIndex = 3;
            }
            else if (selectedIndex == 4)
            {
                cmbxTime.SelectedIndex = 4;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void clearFields()
        {
            cmbxTime.SelectedIndex = 0;
            txtbxMenu.Clear();
            txtbxCharges.Clear();
            rctxtbxRemaks.Clear();
            cmbxTime.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string typeMeal=cmbxTime.SelectedItem.ToString();
            string menu=txtbxMenu.Text;
            double charges=double.Parse(txtbxCharges.Text);
            string remarks=rctxtbxRemaks.Text;
            if (cmbxTime.SelectedIndex != 0)
            {
                Meal meal = new Meal(typeMeal, menu, charges, remarks);
                if (MealDL.setIntoMealList(meal))
                {
                    MessageBox.Show("Data Successfully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                }
                else
                {
                    MessageBox.Show("Error while storing data ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearFields();
                }
            }
            else
            {
                MessageBox.Show("Please select the type ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbxTime.Focus();
            }
        }
    }
}
