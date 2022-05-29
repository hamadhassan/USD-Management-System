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
    public partial class frmTransport : Form
    {
        private int selectedIndex;
        private Transport previous;
        public frmTransport(int selectedIndex)
        {
            InitializeComponent();
            this.selectedIndex = selectedIndex;

        }
        public frmTransport (Transport previous)
        {
            InitializeComponent();
            this.previous = previous;
        }
        private void frmTransport_Load(object sender, EventArgs e)
        {
            cmbxType.SelectedIndex = 0;
            if(previous != null)
            {
                cmbxType.Text=previous.TypeTransport;
                txtbxAmount.Text=previous.Amount.ToString();
                txtbxDestination.Text=previous.Destination;
                txtbxPickupLocation.Text=previous.PickupLocation;
                rctxbxReamarks.Text=previous.Remarks;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void clearFields()
        {
            cmbxType.SelectedIndex = 0;
            txtbxAmount.Clear();
            txtbxDestination.Clear();
            txtbxPickupLocation.Clear();
            rctxbxReamarks.Clear();
            cmbxType.Focus();
        }
        private Transport takeTransportRecord()
        {
            if (cmbxType.SelectedIndex != 0)
            {
                if (txtbxAmount.Text != String.Empty)
                {
                    if (txtbxDestination.Text != String.Empty || txtbxPickupLocation.Text != String.Empty)
                    {
                        string typeTransport=cmbxType.SelectedItem.ToString();
                        string pickupLocation=txtbxPickupLocation.Text;
                        string destination=txtbxDestination.Text;
                        double amount=double.Parse(txtbxAmount.Text);
                        string remarks = rctxbxReamarks.Text;
                        Transport transport = new Transport(typeTransport, pickupLocation, destination, amount, remarks);
                        return transport;
                    }
                    else
                    {
                        MessageBox.Show("Please provide the all detail ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please select the amount ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtbxAmount.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please select the type ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbxType.Focus();
            }
            return null;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (previous != null)
            {
                if (TransportDL.EditFromTransportList(previous, takeTransportRecord()))
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
                if (TransportDL.setIntoTransportList(takeTransportRecord()))
                {
                    MessageBox.Show("Data Successfully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TransportDL.storeRecordIntoFile(takeTransportRecord(), FilePath.Transport);
                    TransportDL.clearList();
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
