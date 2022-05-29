namespace UniversityStudentDiaryManagementSystem
{
    partial class frmUpdatePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdatePassword));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBxShowPassword = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxOldPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxNewPassword = new System.Windows.Forms.TextBox();
            this.txtbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbxRole = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbxRole);
            this.groupBox1.Controls.Add(this.checkBxShowPassword);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnChangePassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtbxOldPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbxUserName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtbxNewPassword);
            this.groupBox1.Controls.Add(this.txtbxConfirmPassword);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 262);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Password";
            // 
            // checkBxShowPassword
            // 
            this.checkBxShowPassword.AutoSize = true;
            this.checkBxShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBxShowPassword.Location = new System.Drawing.Point(199, 183);
            this.checkBxShowPassword.Name = "checkBxShowPassword";
            this.checkBxShowPassword.Size = new System.Drawing.Size(141, 24);
            this.checkBxShowPassword.TabIndex = 4;
            this.checkBxShowPassword.Text = "Show Password";
            this.checkBxShowPassword.UseVisualStyleBackColor = true;
            this.checkBxShowPassword.CheckedChanged += new System.EventHandler(this.checkBxShowPassword_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(260, 213);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Image")));
            this.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.Location = new System.Drawing.Point(84, 213);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(170, 30);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(9, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Confirm Password :";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // txtbxOldPassword
            // 
            this.txtbxOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbxOldPassword.Location = new System.Drawing.Point(159, 94);
            this.txtbxOldPassword.Name = "txtbxOldPassword";
            this.txtbxOldPassword.Size = new System.Drawing.Size(185, 26);
            this.txtbxOldPassword.TabIndex = 1;
            this.txtbxOldPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(9, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "New Password :";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(9, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Old Password :";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // txtbxUserName
            // 
            this.txtbxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbxUserName.Location = new System.Drawing.Point(159, 65);
            this.txtbxUserName.Name = "txtbxUserName";
            this.txtbxUserName.Size = new System.Drawing.Size(185, 26);
            this.txtbxUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(9, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "User name :";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // txtbxNewPassword
            // 
            this.txtbxNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbxNewPassword.Location = new System.Drawing.Point(159, 123);
            this.txtbxNewPassword.Name = "txtbxNewPassword";
            this.txtbxNewPassword.Size = new System.Drawing.Size(185, 26);
            this.txtbxNewPassword.TabIndex = 2;
            this.txtbxNewPassword.UseSystemPasswordChar = true;
            // 
            // txtbxConfirmPassword
            // 
            this.txtbxConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbxConfirmPassword.Location = new System.Drawing.Point(159, 152);
            this.txtbxConfirmPassword.Name = "txtbxConfirmPassword";
            this.txtbxConfirmPassword.Size = new System.Drawing.Size(185, 26);
            this.txtbxConfirmPassword.TabIndex = 3;
            this.txtbxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(9, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Role :";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // cmbxRole
            // 
            this.cmbxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbxRole.FormattingEnabled = true;
            this.cmbxRole.Items.AddRange(new object[] {
            "Select a option ",
            "Student",
            "Parent"});
            this.cmbxRole.Location = new System.Drawing.Point(159, 34);
            this.cmbxRole.Name = "cmbxRole";
            this.cmbxRole.Size = new System.Drawing.Size(185, 28);
            this.cmbxRole.TabIndex = 18;
            // 
            // frmUpdatePassword
            // 
            this.AcceptButton = this.btnChangePassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 286);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUpdatePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Password";
            this.Load += new System.EventHandler(this.frmUpdatePassword_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBxShowPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxOldPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxNewPassword;
        private System.Windows.Forms.TextBox txtbxConfirmPassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbxRole;
        private System.Windows.Forms.Label label5;
    }
}