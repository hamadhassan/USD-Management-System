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


namespace UniversityStudentDiaryManagementSystem
{
    public partial class frmNotification : Form
    {
        public frmNotification()
        {
            InitializeComponent();
        }

        private void frmNotification_Load(object sender, EventArgs e)
        {
            List<string> notifications = NotificationDL.getNotificationlist();
            label1.Text = notifications[0];
        }
    }
}
