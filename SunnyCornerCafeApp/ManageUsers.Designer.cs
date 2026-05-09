namespace SunnyCornerCafeApp
{
    partial class ManageUsers
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
            this.BTN_EditUser = new System.Windows.Forms.Button();
            this.BTN_ResetPassword = new System.Windows.Forms.Button();
            this.BTN_AddNewUser = new System.Windows.Forms.Button();
            this.GV_UserList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GV_UserList)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_EditUser
            // 
            this.BTN_EditUser.Location = new System.Drawing.Point(12, 266);
            this.BTN_EditUser.Name = "BTN_EditUser";
            this.BTN_EditUser.Size = new System.Drawing.Size(165, 60);
            this.BTN_EditUser.TabIndex = 21;
            this.BTN_EditUser.Text = "Edit User";
            this.BTN_EditUser.UseVisualStyleBackColor = true;
            this.BTN_EditUser.Click += new System.EventHandler(this.BTN_EditUser_Click);
            // 
            // BTN_ResetPassword
            // 
            this.BTN_ResetPassword.Location = new System.Drawing.Point(12, 188);
            this.BTN_ResetPassword.Name = "BTN_ResetPassword";
            this.BTN_ResetPassword.Size = new System.Drawing.Size(165, 60);
            this.BTN_ResetPassword.TabIndex = 20;
            this.BTN_ResetPassword.Text = "Reset Password";
            this.BTN_ResetPassword.UseVisualStyleBackColor = true;
            this.BTN_ResetPassword.Click += new System.EventHandler(this.BTN_ResetPassword_Click);
            // 
            // BTN_AddNewUser
            // 
            this.BTN_AddNewUser.Location = new System.Drawing.Point(12, 108);
            this.BTN_AddNewUser.Name = "BTN_AddNewUser";
            this.BTN_AddNewUser.Size = new System.Drawing.Size(165, 60);
            this.BTN_AddNewUser.TabIndex = 19;
            this.BTN_AddNewUser.Text = "Add New User";
            this.BTN_AddNewUser.UseVisualStyleBackColor = true;
            this.BTN_AddNewUser.Click += new System.EventHandler(this.BTN_AddNewUser_Click);
            // 
            // GV_UserList
            // 
            this.GV_UserList.AllowUserToResizeColumns = false;
            this.GV_UserList.AllowUserToResizeRows = false;
            this.GV_UserList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.GV_UserList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GV_UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_UserList.GridColor = System.Drawing.SystemColors.ControlLight;
            this.GV_UserList.Location = new System.Drawing.Point(196, 12);
            this.GV_UserList.Name = "GV_UserList";
            this.GV_UserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV_UserList.Size = new System.Drawing.Size(332, 426);
            this.GV_UserList.TabIndex = 18;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.BTN_EditUser);
            this.Controls.Add(this.BTN_ResetPassword);
            this.Controls.Add(this.BTN_AddNewUser);
            this.Controls.Add(this.GV_UserList);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManagerUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_UserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTN_EditUser;
        private System.Windows.Forms.Button BTN_ResetPassword;
        private System.Windows.Forms.Button BTN_AddNewUser;
        private System.Windows.Forms.DataGridView GV_UserList;
    }
}