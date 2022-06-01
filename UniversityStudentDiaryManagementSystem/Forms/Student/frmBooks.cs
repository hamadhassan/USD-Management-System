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
using UniversityStudentDiaryManagementSystem.Paths;

namespace UniversityStudentDiaryManagementSystem
{
    public partial class frmBooks : Form
    {
        private int selectedIndex;
        private Book previous;

        public frmBooks(int selectedIndex)
        {
            InitializeComponent();
            this.selectedIndex = selectedIndex;
        }
        public frmBooks(Book previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbxType.SelectedIndex == 1)
                {
                    lblBookFrom.Text = "Friend Name :";
                    txtbxAmount.Enabled = false;
                    txtbxAmount.Clear();
                }
                else if (cmbxType.SelectedIndex == 2)
                {
                    lblBookFrom.Text = "Publisher :";
                    txtbxAmount.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmBooks_Load(object sender, EventArgs e)
        {
            try
            {
                if (previous != null)
                {
                    cmbxType.Text = previous.TypeBook;
                    txtbxTitle.Text = previous.Title;
                    txtbxAuthor.Text = previous.AuthorName;
                    txtbxBookFrom.Text = previous.BookFrom;
                    rctxtbxRemaks.Text = previous.Remarks;
                    //txtbxAmount.Text=previous.Amount.ToString();
                }
                else
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
        private Book takeBookBorrowRecord()
        {
            if (cmbxType.SelectedIndex != 0)
            {
                if (txtbxTitle.Text != String.Empty)
                {
                    if (txtbxAuthor.Text != String.Empty)
                    {
                        if (txtbxBookFrom.Text != String.Empty)
                        {
                            string typeBook = cmbxType.SelectedItem.ToString();
                            string title = txtbxTitle.Text;
                            string authorName = txtbxAuthor.Text;
                            string bookFrom = txtbxBookFrom.Text;
                            string remarks = rctxtbxRemaks.Text;
                            Book book = new Book(typeBook, title, authorName, bookFrom, remarks);
                            return book;
                        }
                        else
                        {
                            MessageBox.Show("Please provide the detail ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtbxBookFrom.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please provide the detail ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtbxAuthor.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please provide the detail ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbxTitle.Focus();
                }

            }
            else
            {
                MessageBox.Show("Please select the type ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbxType.Focus();
            }
            return null;
        }
        private BookPublisher takeBookPublisherRecord()
        {
            try
            {
                if (cmbxType.SelectedIndex != 0)
                {
                    if (txtbxTitle.Text != String.Empty)
                    {
                        if (txtbxAuthor.Text != String.Empty)
                        {
                            if (txtbxBookFrom.Text != String.Empty)
                            {
                                if (txtbxAmount.Text != String.Empty)
                                {
                                    string typeBook = cmbxType.SelectedItem.ToString();
                                    string title = txtbxTitle.Text;
                                    string authorName = txtbxAuthor.Text;
                                    string bookFrom = txtbxBookFrom.Text;
                                    string remarks = rctxtbxRemaks.Text;
                                    double amount = double.Parse(txtbxAmount.Text);
                                    if (amount < 0)
                                    {
                                        throw new Exception("Invalid try");
                                    }
                                    BookPublisher book = new BookPublisher(typeBook, title, authorName, bookFrom, remarks, amount);
                                    return book;
                                }
                                else
                                {
                                    MessageBox.Show("Please provide the detail ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txtbxAmount.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please provide the detail ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtbxBookFrom.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please provide the detail ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtbxAuthor.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please provide the detail ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtbxTitle.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Please select the type ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbxType.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return null;
           
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (previous != null)
                {
                    if (cmbxType.SelectedIndex == 1)
                    {//borrow
                        if (BookDL.EditFromBookList(previous, takeBookBorrowRecord()))
                        {
                            MessageBox.Show("Data Successfully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearFields();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error while storing data ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearFields();
                        }
                    }
                    else if (cmbxType.SelectedIndex == 2)
                    {//publisher
                        if (BookDL.EditFromBookList(previous, takeBookPublisherRecord()))
                        {
                            MessageBox.Show("Data Successfully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearFields();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Error while storing data ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearFields();
                        }
                    }
                }
                else
                {
                    if (cmbxType.SelectedIndex == 1)
                    {//borrow

                        if (BookDL.setIntoBookList(takeBookBorrowRecord()))
                        {
                            MessageBox.Show("Data Successfully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BookDL.storeRecordIntoFile(takeBookBorrowRecord(), PathFile.Books);
                            BookDL.clearList();
                            clearFields();
                        }
                        else
                        {
                            MessageBox.Show("Error while storing data ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearFields();
                        }
                    }
                    else if (cmbxType.SelectedIndex == 2)
                    {//publisher
                        if (BookDL.setIntoBookList(takeBookPublisherRecord()))
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
