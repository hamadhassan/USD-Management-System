namespace UniversityStudentDiaryManagementSystem.Forms
{
    partial class frmMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbxLocalIP = new System.Windows.Forms.TextBox();
            this.txtbxLocalPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxRemoteIP = new System.Windows.Forms.TextBox();
            this.txtbxRemortPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.listbxMessage = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtbxMessage = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbxRemortPort);
            this.groupBox2.Controls.Add(this.txtbxRemoteIP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(277, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parent";
            // 
            // txtbxLocalIP
            // 
            this.txtbxLocalIP.Enabled = false;
            this.txtbxLocalIP.Location = new System.Drawing.Point(54, 31);
            this.txtbxLocalIP.Name = "txtbxLocalIP";
            this.txtbxLocalIP.Size = new System.Drawing.Size(185, 26);
            this.txtbxLocalIP.TabIndex = 1;
            // 
            // txtbxLocalPort
            // 
            this.txtbxLocalPort.Location = new System.Drawing.Point(54, 60);
            this.txtbxLocalPort.Name = "txtbxLocalPort";
            this.txtbxLocalPort.Size = new System.Drawing.Size(185, 26);
            this.txtbxLocalPort.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Port";
            // 
            // txtbxRemoteIP
            // 
            this.txtbxRemoteIP.Enabled = false;
            this.txtbxRemoteIP.Location = new System.Drawing.Point(59, 28);
            this.txtbxRemoteIP.Name = "txtbxRemoteIP";
            this.txtbxRemoteIP.Size = new System.Drawing.Size(179, 26);
            this.txtbxRemoteIP.TabIndex = 0;
            // 
            // txtbxRemortPort
            // 
            this.txtbxRemortPort.Location = new System.Drawing.Point(59, 60);
            this.txtbxRemortPort.Name = "txtbxRemortPort";
            this.txtbxRemortPort.Size = new System.Drawing.Size(179, 26);
            this.txtbxRemortPort.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConnect.Location = new System.Drawing.Point(546, 21);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(95, 51);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // listbxMessage
            // 
            this.listbxMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listbxMessage.FormattingEnabled = true;
            this.listbxMessage.ItemHeight = 20;
            this.listbxMessage.Location = new System.Drawing.Point(12, 118);
            this.listbxMessage.Name = "listbxMessage";
            this.listbxMessage.Size = new System.Drawing.Size(639, 322);
            this.listbxMessage.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.Location = new System.Drawing.Point(566, 442);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(85, 31);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtbxLocalPort);
            this.groupBox3.Controls.Add(this.txtbxLocalIP);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "IP";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(546, 78);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 31);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtbxMessage
            // 
            this.txtbxMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxMessage.Location = new System.Drawing.Point(12, 443);
            this.txtbxMessage.Name = "txtbxMessage";
            this.txtbxMessage.Size = new System.Drawing.Size(548, 30);
            this.txtbxMessage.TabIndex = 6;
            this.txtbxMessage.Text = "";
            // 
            // frmMessage
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 480);
            this.Controls.Add(this.txtbxMessage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.listbxMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.Load += new System.EventHandler(this.frmMessage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbxLocalPort;
        private System.Windows.Forms.TextBox txtbxLocalIP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbxRemortPort;
        private System.Windows.Forms.TextBox txtbxRemoteIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox listbxMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox txtbxMessage;
    }
}