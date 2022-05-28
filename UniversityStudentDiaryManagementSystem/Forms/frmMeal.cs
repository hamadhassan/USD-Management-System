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
using UniversityStudentDiaryManagementSystem.Path;


namespace UniversityStudentDiaryManagementSystem
{
    public partial class frmMeal : Form
    {
        private int selectedIndex;
        private Meal previous;
        public frmMeal(int selectedIndex)
        {
            InitializeComponent();
            this.selectedIndex = selectedIndex;
        }
        public frmMeal(Meal previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void frmMeal_Load(object sender, EventArgs e)
        {
            if (previous != null)
            {
                cmbxTime.Text = previous.TypeMeal;
                txtbxMenu.Text=previous.Menu;
                txtbxCharges.Text=previous.Charges.ToString();
                rctxtbxRemaks.Text=previous.Remakrs;
            }
            else
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
        private Meal takeMealRecord()
        {

            if (cmbxTime.SelectedIndex != 0)
            {
                if (txtbxMenu.Text != String.Empty || txtbxCharges.Text != String.Empty)
                {
                    string typeMeal = cmbxTime.SelectedItem.ToString();
                    string menu = txtbxMenu.Text;
                    double charges = double.Parse(txtbxCharges.Text);
                    string remarks = rctxtbxRemaks.Text;
                    Meal meal = new Meal(typeMeal, menu, charges, remarks);
                    return meal;
                }
                else
                {
                    MessageBox.Show("Please provide the all detail ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Please select the type ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbxTime.Focus();
            }
            return null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (previous != null)
            {
                if (MealDL.EditFromMealList(previous, takeMealRecord()))
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
                if (MealDL.setIntoMealList(takeMealRecord()))
                {
                    MessageBox.Show("Data Successfully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MealDL.storeRecordIntoFile(takeMealRecord(), FilePath.Meal);
                    MealDL.clearList();
                    clearFields();
                }
                else
                {
                    MessageBox.Show("Error while storing data ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearFields();
                }
            }
        }
    }
}
