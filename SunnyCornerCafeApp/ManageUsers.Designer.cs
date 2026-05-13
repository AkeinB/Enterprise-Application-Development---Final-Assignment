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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsers));
            this.BTN_EditUser = new System.Windows.Forms.Button();
            this.BTN_ResetPassword = new System.Windows.Forms.Button();
            this.BTN_AddNewUser = new System.Windows.Forms.Button();
            this.GV_UserList = new System.Windows.Forms.DataGridView();
            this.BTN_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GV_UserList)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_EditUser
            // 
            this.BTN_EditUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_EditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EditUser.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EditUser.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BTN_EditUser.Location = new System.Drawing.Point(14, 327);
            this.BTN_EditUser.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_EditUser.Name = "BTN_EditUser";
            this.BTN_EditUser.Size = new System.Drawing.Size(192, 74);
            this.BTN_EditUser.TabIndex = 21;
            this.BTN_EditUser.Text = "Edit User";
            this.BTN_EditUser.UseVisualStyleBackColor = false;
            this.BTN_EditUser.Click += new System.EventHandler(this.BTN_EditUser_Click);
            // 
            // BTN_ResetPassword
            // 
            this.BTN_ResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_ResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ResetPassword.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ResetPassword.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BTN_ResetPassword.Location = new System.Drawing.Point(14, 231);
            this.BTN_ResetPassword.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_ResetPassword.Name = "BTN_ResetPassword";
            this.BTN_ResetPassword.Size = new System.Drawing.Size(192, 74);
            this.BTN_ResetPassword.TabIndex = 20;
            this.BTN_ResetPassword.Text = "Reset Password";
            this.BTN_ResetPassword.UseVisualStyleBackColor = false;
            this.BTN_ResetPassword.Click += new System.EventHandler(this.BTN_ResetPassword_Click);
            // 
            // BTN_AddNewUser
            // 
            this.BTN_AddNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_AddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AddNewUser.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AddNewUser.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BTN_AddNewUser.Location = new System.Drawing.Point(14, 133);
            this.BTN_AddNewUser.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_AddNewUser.Name = "BTN_AddNewUser";
            this.BTN_AddNewUser.Size = new System.Drawing.Size(192, 74);
            this.BTN_AddNewUser.TabIndex = 19;
            this.BTN_AddNewUser.Text = "Add New User";
            this.BTN_AddNewUser.UseVisualStyleBackColor = false;
            this.BTN_AddNewUser.Click += new System.EventHandler(this.BTN_AddNewUser_Click);
            // 
            // GV_UserList
            // 
            this.GV_UserList.AllowUserToResizeColumns = false;
            this.GV_UserList.AllowUserToResizeRows = false;
            this.GV_UserList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GV_UserList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GV_UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_UserList.GridColor = System.Drawing.SystemColors.ControlLight;
            this.GV_UserList.Location = new System.Drawing.Point(229, 15);
            this.GV_UserList.Margin = new System.Windows.Forms.Padding(4);
            this.GV_UserList.Name = "GV_UserList";
            this.GV_UserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV_UserList.Size = new System.Drawing.Size(387, 524);
            this.GV_UserList.TabIndex = 18;
            // 
            // BTN_Close
            // 
            this.BTN_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Close.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Close.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BTN_Close.Location = new System.Drawing.Point(41, 479);
            this.BTN_Close.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(124, 37);
            this.BTN_Close.TabIndex = 22;
            this.BTN_Close.Text = "Close";
            this.BTN_Close.UseVisualStyleBackColor = false;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(643, 554);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.BTN_EditUser);
            this.Controls.Add(this.BTN_ResetPassword);
            this.Controls.Add(this.BTN_AddNewUser);
            this.Controls.Add(this.GV_UserList);
            this.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button BTN_Close;
    }
}