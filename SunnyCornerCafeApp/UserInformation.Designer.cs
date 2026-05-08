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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TB_Address = new System.Windows.Forms.TextBox();
            this.LB_Email = new System.Windows.Forms.Label();
            this.LB_Address = new System.Windows.Forms.Label();
            this.LB_Telephone = new System.Windows.Forms.Label();
            this.LB_CDate = new System.Windows.Forms.Label();
            this.BT_Main = new System.Windows.Forms.Button();
            this.BT_Cart = new System.Windows.Forms.Button();
            this.TB_CreateDate = new System.Windows.Forms.TextBox();
            this.BT_Edit = new System.Windows.Forms.Button();
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
            this.LB_Username.Location = new System.Drawing.Point(93, 280);
            this.LB_Username.Name = "LB_Username";
            this.LB_Username.Size = new System.Drawing.Size(73, 13);
            this.LB_Username.TabIndex = 1;
            this.LB_Username.Text = "-- Username --";
            this.LB_Username.Click += new System.EventHandler(this.label1_Click);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(286, 105);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(201, 20);
            this.TB_Name.TabIndex = 2;
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.Location = new System.Drawing.Point(283, 89);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(35, 13);
            this.LB_Name.TabIndex = 3;
            this.LB_Name.Text = "Name";
            this.LB_Name.Click += new System.EventHandler(this.LB_UserName_Click);
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(286, 189);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(201, 20);
            this.TB_Email.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(549, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(201, 20);
            this.textBox3.TabIndex = 5;
            // 
            // TB_Address
            // 
            this.TB_Address.Location = new System.Drawing.Point(286, 274);
            this.TB_Address.Name = "TB_Address";
            this.TB_Address.Size = new System.Drawing.Size(201, 20);
            this.TB_Address.TabIndex = 6;
            // 
            // LB_Email
            // 
            this.LB_Email.AutoSize = true;
            this.LB_Email.Location = new System.Drawing.Point(283, 173);
            this.LB_Email.Name = "LB_Email";
            this.LB_Email.Size = new System.Drawing.Size(73, 13);
            this.LB_Email.TabIndex = 8;
            this.LB_Email.Text = "Email Address";
            // 
            // LB_Address
            // 
            this.LB_Address.AutoSize = true;
            this.LB_Address.Location = new System.Drawing.Point(283, 258);
            this.LB_Address.Name = "LB_Address";
            this.LB_Address.Size = new System.Drawing.Size(45, 13);
            this.LB_Address.TabIndex = 9;
            this.LB_Address.Text = "Address";
            // 
            // LB_Telephone
            // 
            this.LB_Telephone.AutoSize = true;
            this.LB_Telephone.Location = new System.Drawing.Point(546, 89);
            this.LB_Telephone.Name = "LB_Telephone";
            this.LB_Telephone.Size = new System.Drawing.Size(98, 13);
            this.LB_Telephone.TabIndex = 10;
            this.LB_Telephone.Text = "Telephone Number";
            // 
            // LB_CDate
            // 
            this.LB_CDate.AutoSize = true;
            this.LB_CDate.Location = new System.Drawing.Point(546, 173);
            this.LB_CDate.Name = "LB_CDate";
            this.LB_CDate.Size = new System.Drawing.Size(70, 13);
            this.LB_CDate.TabIndex = 11;
            this.LB_CDate.Text = "Created Date";
            // 
            // BT_Main
            // 
            this.BT_Main.Location = new System.Drawing.Point(391, 380);
            this.BT_Main.Name = "BT_Main";
            this.BT_Main.Size = new System.Drawing.Size(131, 33);
            this.BT_Main.TabIndex = 12;
            this.BT_Main.Text = "Home";
            this.BT_Main.UseVisualStyleBackColor = true;
            // 
            // BT_Cart
            // 
            this.BT_Cart.Location = new System.Drawing.Point(619, 380);
            this.BT_Cart.Name = "BT_Cart";
            this.BT_Cart.Size = new System.Drawing.Size(131, 33);
            this.BT_Cart.TabIndex = 13;
            this.BT_Cart.Text = "Cart";
            this.BT_Cart.UseVisualStyleBackColor = true;
            // 
            // TB_CreateDate
            // 
            this.TB_CreateDate.Location = new System.Drawing.Point(549, 189);
            this.TB_CreateDate.Name = "TB_CreateDate";
            this.TB_CreateDate.Size = new System.Drawing.Size(201, 20);
            this.TB_CreateDate.TabIndex = 14;
            // 
            // BT_Edit
            // 
            this.BT_Edit.Location = new System.Drawing.Point(163, 380);
            this.BT_Edit.Name = "BT_Edit";
            this.BT_Edit.Size = new System.Drawing.Size(115, 33);
            this.BT_Edit.TabIndex = 15;
            this.BT_Edit.Text = "Edit";
            this.BT_Edit.UseVisualStyleBackColor = true;
            // 
            // UserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_Edit);
            this.Controls.Add(this.TB_CreateDate);
            this.Controls.Add(this.BT_Cart);
            this.Controls.Add(this.BT_Main);
            this.Controls.Add(this.LB_CDate);
            this.Controls.Add(this.LB_Telephone);
            this.Controls.Add(this.LB_Address);
            this.Controls.Add(this.LB_Email);
            this.Controls.Add(this.TB_Address);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.TB_Email);
            this.Controls.Add(this.LB_Name);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.LB_Username);
            this.Controls.Add(this.PB_UserPicture);
            this.Name = "UserInformation";
            this.Text = "User Information";
            this.Load += new System.EventHandler(this.UserInformation_Load);
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox TB_Address;
        private System.Windows.Forms.Label LB_Email;
        private System.Windows.Forms.Label LB_Address;
        private System.Windows.Forms.Label LB_Telephone;
        private System.Windows.Forms.Label LB_CDate;
        private System.Windows.Forms.Button BT_Main;
        private System.Windows.Forms.Button BT_Cart;
        private System.Windows.Forms.TextBox TB_CreateDate;
        private System.Windows.Forms.Button BT_Edit;
    }
}