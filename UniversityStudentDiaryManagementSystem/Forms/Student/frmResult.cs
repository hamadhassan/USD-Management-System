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
using UniversityStudentDiaryManagementSystem.BL;
using UniversityStudentDiaryManagementSystem.Paths;

namespace UniversityStudentDiaryManagementSystem
{
    public partial class frmResult : Form
    {
        private Result previous;
        public frmResult()
        {
            InitializeComponent();
        }
        public frmResult(Result previous)
        {
            this.previous = previous;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmResult_Load(object sender, EventArgs e)
        {
            try
            {
                if (previous != null)
                {
                    txtbxSemester.Text = previous.Semester;
                    txtbxGPA.Text = previous.Gpa;
                    txtbxCGPA.Text = previous.Cgpa;
                    rctxtbxRemarks.Text = previous.Remarks;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearFields()
        {
            txtbxSemester.Clear();
            txtbxGPA.Clear();
            txtbxCGPA.Clear();
            rctxtbxRemarks.Clear();
            txtbxSemester.Focus();
        }
        private Result takeResultRecord()
        {
            if (txtbxSemester.Text !=String.Empty)
            {
                if (txtbxCGPA.Text != String.Empty || txtbxGPA.Text != String.Empty)
                {
                    string semester= txtbxSemester.Text;
                    string gpa=txtbxGPA.Text;
                    string cgpa=txtbxCGPA.Text;
                    string remarks = rctxtbxRemarks.Text;
                    Result result = new Result(semester, gpa, cgpa, remarks);
                    return result;
                }
                else
                {
                    MessageBox.Show("Please provide the all detail ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Please provide semester detail ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbxSemester.Focus();
            }
            return null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (takeResultRecord() != null)
                {
                    if (previous != null)
                    {
                        if (ResultDL.EditFromResultlList(previous, takeResultRecord()))
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
                    else
                    {
                        if (ResultDL.setIntoResultList(takeResultRecord()))
                        {
                            MessageBox.Show("Data Successfully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResultDL.storeRecordIntoFile(takeResultRecord(), PathFile.Result);
                            ResultDL.clearList();
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
