namespace SunnyCornerCafeApp
{
    partial class UserInformation
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
            this.PB_UserPicture = new System.Windows.Forms.PictureBox();
            this.LB_Username = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.LB_Name = new System.Windows.Forms.Label();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.TB_TelephoneNumber = new System.Windows.Forms.TextBox();
            this.TB_Address = new System.Windows.Forms.TextBox();
            this.LB_Email = new System.Windows.Forms.Label();
            this.LB_Address = new System.Windows.Forms.Label();
            this.LB_Telephone = new System.Windows.Forms.Label();
            this.LB_CDate = new System.Windows.Forms.Label();
            this.BT_Close = new System.Windows.Forms.Button();
            this.TB_CreateDate = new System.Windows.Forms.TextBox();
            this.BT_Edit = new System.Windows.Forms.Button();
            this.BTN_EditPassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_UserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_UserPicture
            // 
            this.PB_UserPicture.Location = new System.Drawing.Point(44, 44);
            this.PB_UserPicture.Name = "PB_UserPicture";
            this.PB_UserPicture.Size = new System.Drawing.Size(184, 215);
            this.PB_UserPicture.TabIndex = 0;
            this.PB_UserPicture.TabStop = false;
            // 
            // LB_Username
            // 
            this.LB_Username.AutoSize = true;
            this.LB_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Username.Location = new System.Drawing.Point(81, 276);
            this.LB_Username.Name = "LB_Username";
            this.LB_Username.Size = new System.Drawing.Size(101, 17);
            this.LB_Username.TabIndex = 1;
            this.LB_Username.Text = "-- Username --";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(252, 104);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.ReadOnly = true;
            this.TB_Name.Size = new System.Drawing.Size(201, 20);
            this.TB_Name.TabIndex = 2;
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.Location = new System.Drawing.Point(249, 88);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(35, 13);
            this.LB_Name.TabIndex = 3;
            this.LB_Name.Text = "Name";
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(252, 188);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.ReadOnly = true;
            this.TB_Email.Size = new System.Drawing.Size(201, 20);
            this.TB_Email.TabIndex = 4;
            // 
            // TB_TelephoneNumber
            // 
            this.TB_TelephoneNumber.Location = new System.Drawing.Point(515, 104);
            this.TB_TelephoneNumber.Name = "TB_TelephoneNumber";
            this.TB_TelephoneNumber.ReadOnly = true;
            this.TB_TelephoneNumber.Size = new System.Drawing.Size(201, 20);
            this.TB_TelephoneNumber.TabIndex = 5;
            // 
            // TB_Address
            // 
            this.TB_Address.Location = new System.Drawing.Point(252, 273);
            this.TB_Address.Name = "TB_Address";
            this.TB_Address.ReadOnly = true;
            this.TB_Address.Size = new System.Drawing.Size(201, 20);
            this.TB_Address.TabIndex = 6;
            // 
            // LB_Email
            // 
            this.LB_Email.AutoSize = true;
            this.LB_Email.Location = new System.Drawing.Point(249, 172);
            this.LB_Email.Name = "LB_Email";
            this.LB_Email.Size = new System.Drawing.Size(73, 13);
            this.LB_Email.TabIndex = 8;
            this.LB_Email.Text = "Email Address";
            // 
            // LB_Address
            // 
            this.LB_Address.AutoSize = true;
            this.LB_Address.Location = new System.Drawing.Point(249, 257);
            this.LB_Address.Name = "LB_Address";
            this.LB_Address.Size = new System.Drawing.Size(45, 13);
            this.LB_Address.TabIndex = 9;
            this.LB_Address.Text = "Address";
            // 
            // LB_Telephone
            // 
            this.LB_Telephone.AutoSize = true;
            this.LB_Telephone.Location = new System.Drawing.Point(512, 88);
            this.LB_Telephone.Name = "LB_Telephone";
            this.LB_Telephone.Size = new System.Drawing.Size(98, 13);
            this.LB_Telephone.TabIndex = 10;
            this.LB_Telephone.Text = "Telephone Number";
            // 
            // LB_CDate
            // 
            this.LB_CDate.AutoSize = true;
            this.LB_CDate.Location = new System.Drawing.Point(512, 172);
            this.LB_CDate.Name = "LB_CDate";
            this.LB_CDate.Size = new System.Drawing.Size(70, 13);
            this.LB_CDate.TabIndex = 11;
            this.LB_CDate.Text = "Created Date";
            // 
            // BT_Close
            // 
            this.BT_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BT_Close.Location = new System.Drawing.Point(330, 356);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(131, 33);
            this.BT_Close.TabIndex = 12;
            this.BT_Close.Text = "Close";
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // TB_CreateDate
            // 
            this.TB_CreateDate.Location = new System.Drawing.Point(515, 188);
            this.TB_CreateDate.Name = "TB_CreateDate";
            this.TB_CreateDate.ReadOnly = true;
            this.TB_CreateDate.Size = new System.Drawing.Size(201, 20);
            this.TB_CreateDate.TabIndex = 14;
            // 
            // BT_Edit
            // 
            this.BT_Edit.Location = new System.Drawing.Point(190, 356);
            this.BT_Edit.Name = "BT_Edit";
            this.BT_Edit.Size = new System.Drawing.Size(115, 33);
            this.BT_Edit.TabIndex = 15;
            this.BT_Edit.Text = "Edit";
            this.BT_Edit.UseVisualStyleBackColor = true;
            this.BT_Edit.Click += new System.EventHandler(this.BT_Edit_Click);
            // 
            // BTN_EditPassword
            // 
            this.BTN_EditPassword.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_EditPassword.Location = new System.Drawing.Point(479, 356);
            this.BTN_EditPassword.Name = "BTN_EditPassword";
            this.BTN_EditPassword.Size = new System.Drawing.Size(131, 33);
            this.BTN_EditPassword.TabIndex = 16;
            this.BTN_EditPassword.Text = "Edit Password";
            this.BTN_EditPassword.UseVisualStyleBackColor = true;
            this.BTN_EditPassword.Click += new System.EventHandler(this.BTN_EditPassword_Click);
            // 
            // UserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BT_Close;
            this.ClientSize = new System.Drawing.Size(748, 438);
            this.Controls.Add(this.BTN_EditPassword);
            this.Controls.Add(this.BT_Edit);
            this.Controls.Add(this.TB_CreateDate);
            this.Controls.Add(this.BT_Close);
            this.Controls.Add(this.LB_CDate);
            this.Controls.Add(this.LB_Telephone);
            this.Controls.Add(this.LB_Address);
            this.Controls.Add(this.LB_Email);
            this.Controls.Add(this.TB_Address);
            this.Controls.Add(this.TB_TelephoneNumber);
            this.Controls.Add(this.TB_Email);
            this.Controls.Add(this.LB_Name);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.LB_Username);
            this.Controls.Add(this.PB_UserPicture);
            this.Name = "UserInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Information";
            ((System.ComponentModel.ISupportInitialize)(this.PB_UserPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_UserPicture;
        private System.Windows.Forms.Label LB_Username;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.TextBox TB_TelephoneNumber;
        private System.Windows.Forms.TextBox TB_Address;
        private System.Windows.Forms.Label LB_Email;
        private System.Windows.Forms.Label LB_Address;
        private System.Windows.Forms.Label LB_Telephone;
        private System.Windows.Forms.Label LB_CDate;
        private System.Windows.Forms.Button BT_Close;
        private System.Windows.Forms.TextBox TB_CreateDate;
        private System.Windows.Forms.Button BT_Edit;
        private System.Windows.Forms.Button BTN_EditPassword;
    }
}