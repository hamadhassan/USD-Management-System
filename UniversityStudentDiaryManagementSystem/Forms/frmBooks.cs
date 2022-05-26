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
    public partial class frmBooks : Form
    {
        private int selectedIndex;

        public frmBooks(int selectedIndex)
        {
            InitializeComponent();
            this.selectedIndex = selectedIndex;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbxType.SelectedIndex == 1)
            {
                lblBookFrom.Text = "Friend Name :";
                txtbxAmount.Enabled = false;
                txtbxAmount.Clear();
            }
            else if(cmbxType.SelectedIndex == 2)
            {
                lblBookFrom.Text = "Publisher :";
                txtbxAmount.Enabled = true;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmBooks_Load(object sender, EventArgs e)
        {
            if (selectedIndex == 1)
            {
                cmbxType.SelectedIndex = 1;
            }
            else if (selectedIndex == 2)
            {
                cmbxType.SelectedIndex = 2;
            }
        }
        private void clearFields()
        {
            cmbxType.SelectedIndex = 0;
            txtbxTitle.Clear();
            txtbxAuthor.Clear();
            txtbxBookFrom.Clear();
            rctxtbxRemaks.Clear();
            txtbxAmount.Clear();
            cmbxType.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string typeBook=cmbxType.SelectedItem.ToString();
            string title=txtbxTitle.Text;
            string authorName=txtbxAuthor.Text;
            string bookFrom=txtbxBookFrom.Text;
            string remarks=rctxtbxRemaks.Text;
            if (cmbxType.SelectedIndex == 1)
            {
                if (cmbxType.SelectedIndex != 0)
                {
                    Book book = new Book(typeBook, title, authorName, bookFrom, remarks);
                    if (BookDL.setIntoBookList(book))
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
                    cmbxType.Focus();
                }
            }
            else if(cmbxType.SelectedIndex == 2)
            {
                double amount = double.Parse(txtbxAmount.Text);
                if (cmbxType.SelectedIndex != 0)
                {
                    BookPublisher book = new BookPublisher(typeBook, title, authorName, bookFrom, remarks,amount);
                    if (BookDL.setIntoBookList(book))
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
                    cmbxType.Focus();
                }
            }
           
        }
    }
}
