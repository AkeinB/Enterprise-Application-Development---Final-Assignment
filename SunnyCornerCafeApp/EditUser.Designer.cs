namespace SunnyCornerCafeApp
{
    partial class EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CB_UserStatus = new System.Windows.Forms.ComboBox();
            this.LB_UseStatus = new System.Windows.Forms.Label();
            this.TB_UserName = new System.Windows.Forms.TextBox();
            this.LB_UserName = new System.Windows.Forms.Label();
            this.LB_UserType = new System.Windows.Forms.Label();
            this.CB_UserType = new System.Windows.Forms.ComboBox();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Submit = new System.Windows.Forms.Button();
            this.LB_EditUser = new System.Windows.Forms.Label();
            this.LB_LableID = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CB_UserStatus, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LB_UseStatus, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TB_UserName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LB_UserName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LB_UserType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CB_UserType, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(43, 114);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(326, 193);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CB_UserStatus
            // 
            this.CB_UserStatus.FormattingEnabled = true;
            this.CB_UserStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.CB_UserStatus.Location = new System.Drawing.Point(167, 132);
            this.CB_UserStatus.Margin = new System.Windows.Forms.Padding(4);
            this.CB_UserStatus.Name = "CB_UserStatus";
            this.CB_UserStatus.Size = new System.Drawing.Size(121, 24);
            this.CB_UserStatus.TabIndex = 8;
            this.CB_UserStatus.SelectedIndexChanged += new System.EventHandler(this.CB_UserStatis_SelectedIndexChanged);
            // 
            // LB_UseStatus
            // 
            this.LB_UseStatus.AutoSize = true;
            this.LB_UseStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_UseStatus.Location = new System.Drawing.Point(4, 128);
            this.LB_UseStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_UseStatus.Name = "LB_UseStatus";
            this.LB_UseStatus.Size = new System.Drawing.Size(82, 17);
            this.LB_UseStatus.TabIndex = 7;
            this.LB_UseStatus.Text = "User Status";
            // 
            // TB_UserName
            // 
            this.TB_UserName.Location = new System.Drawing.Point(167, 4);
            this.TB_UserName.Margin = new System.Windows.Forms.Padding(4);
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(155, 27);
            this.TB_UserName.TabIndex = 4;
            // 
            // LB_UserName
            // 
            this.LB_UserName.AutoSize = true;
            this.LB_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_UserName.Location = new System.Drawing.Point(4, 0);
            this.LB_UserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_UserName.Name = "LB_UserName";
            this.LB_UserName.Size = new System.Drawing.Size(79, 17);
            this.LB_UserName.TabIndex = 3;
            this.LB_UserName.Text = "User Name";
            // 
            // LB_UserType
            // 
            this.LB_UserType.AutoSize = true;
            this.LB_UserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_UserType.Location = new System.Drawing.Point(4, 64);
            this.LB_UserType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_UserType.Name = "LB_UserType";
            this.LB_UserType.Size = new System.Drawing.Size(74, 17);
            this.LB_UserType.TabIndex = 6;
            this.LB_UserType.Text = "User Type";
            // 
            // CB_UserType
            // 
            this.CB_UserType.FormattingEnabled = true;
            this.CB_UserType.Location = new System.Drawing.Point(167, 68);
            this.CB_UserType.Margin = new System.Windows.Forms.Padding(4);
            this.CB_UserType.Name = "CB_UserType";
            this.CB_UserType.Size = new System.Drawing.Size(121, 24);
            this.CB_UserType.TabIndex = 5;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BTN_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Cancel.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_Cancel.Location = new System.Drawing.Point(238, 360);
            this.BTN_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(121, 53);
            this.BTN_Cancel.TabIndex = 6;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = false;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // BTN_Submit
            // 
            this.BTN_Submit.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BTN_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Submit.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_Submit.Location = new System.Drawing.Point(62, 360);
            this.BTN_Submit.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Submit.Name = "BTN_Submit";
            this.BTN_Submit.Size = new System.Drawing.Size(121, 53);
            this.BTN_Submit.TabIndex = 4;
            this.BTN_Submit.Text = "Submit";
            this.BTN_Submit.UseVisualStyleBackColor = false;
            this.BTN_Submit.Click += new System.EventHandler(this.BTN_Submit_Click);
            // 
            // LB_EditUser
            // 
            this.LB_EditUser.AutoSize = true;
            this.LB_EditUser.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_EditUser.Location = new System.Drawing.Point(124, 44);
            this.LB_EditUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_EditUser.Name = "LB_EditUser";
            this.LB_EditUser.Size = new System.Drawing.Size(163, 42);
            this.LB_EditUser.TabIndex = 7;
            this.LB_EditUser.Text = "Edit User";
            // 
            // LB_LableID
            // 
            this.LB_LableID.AutoSize = true;
            this.LB_LableID.ForeColor = System.Drawing.Color.DarkKhaki;
            this.LB_LableID.Location = new System.Drawing.Point(309, 11);
            this.LB_LableID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_LableID.Name = "LB_LableID";
            this.LB_LableID.Size = new System.Drawing.Size(86, 16);
            this.LB_LableID.TabIndex = 8;
            this.LB_LableID.Text = "UserID Holder";
            this.LB_LableID.Visible = false;
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(410, 478);
            this.Controls.Add(this.LB_LableID);
            this.Controls.Add(this.LB_EditUser);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.BTN_Submit);
            this.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit User";
            this.Load += new System.EventHandler(this.EditUser_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox CB_UserType;
        private System.Windows.Forms.TextBox TB_UserName;
        private System.Windows.Forms.Label LB_UserName;
        private System.Windows.Forms.Label LB_UserType;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Submit;
        private System.Windows.Forms.ComboBox CB_UserStatus;
        private System.Windows.Forms.Label LB_UseStatus;
        private System.Windows.Forms.Label LB_EditUser;
        private System.Windows.Forms.Label LB_LableID;
    }
}