namespace SunnyCornerCafeApp
{
    partial class EditInformation
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
            this.LLB_ChangeImg = new System.Windows.Forms.LinkLabel();
            this.LB_Name = new System.Windows.Forms.Label();
            this.TB_CName = new System.Windows.Forms.TextBox();
            this.LB_Address = new System.Windows.Forms.Label();
            this.LB_Email = new System.Windows.Forms.Label();
            this.TB_CAddress = new System.Windows.Forms.TextBox();
            this.TB_CEmail = new System.Windows.Forms.TextBox();
            this.LB_Telephone = new System.Windows.Forms.Label();
            this.TB_CTelephone = new System.Windows.Forms.TextBox();
            this.BT_Change = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_UserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_UserPicture
            // 
            this.PB_UserPicture.Location = new System.Drawing.Point(308, 12);
            this.PB_UserPicture.Name = "PB_UserPicture";
            this.PB_UserPicture.Size = new System.Drawing.Size(184, 215);
            this.PB_UserPicture.TabIndex = 1;
            this.PB_UserPicture.TabStop = false;
            // 
            // LLB_ChangeImg
            // 
            this.LLB_ChangeImg.AutoSize = true;
            this.LLB_ChangeImg.Location = new System.Drawing.Point(363, 230);
            this.LLB_ChangeImg.Name = "LLB_ChangeImg";
            this.LLB_ChangeImg.Size = new System.Drawing.Size(76, 13);
            this.LLB_ChangeImg.TabIndex = 2;
            this.LLB_ChangeImg.TabStop = true;
            this.LLB_ChangeImg.Text = "Change Image";
            this.LLB_ChangeImg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLB_ChangeImg_LinkClicked);
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.Location = new System.Drawing.Point(136, 257);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(35, 13);
            this.LB_Name.TabIndex = 3;
            this.LB_Name.Text = "Name";
            // 
            // TB_CName
            // 
            this.TB_CName.Location = new System.Drawing.Point(139, 273);
            this.TB_CName.Name = "TB_CName";
            this.TB_CName.Size = new System.Drawing.Size(201, 20);
            this.TB_CName.TabIndex = 4;
            // 
            // LB_Address
            // 
            this.LB_Address.AutoSize = true;
            this.LB_Address.Location = new System.Drawing.Point(472, 326);
            this.LB_Address.Name = "LB_Address";
            this.LB_Address.Size = new System.Drawing.Size(45, 13);
            this.LB_Address.TabIndex = 13;
            this.LB_Address.Text = "Address";
            // 
            // LB_Email
            // 
            this.LB_Email.AutoSize = true;
            this.LB_Email.Location = new System.Drawing.Point(472, 257);
            this.LB_Email.Name = "LB_Email";
            this.LB_Email.Size = new System.Drawing.Size(73, 13);
            this.LB_Email.TabIndex = 12;
            this.LB_Email.Text = "Email Address";
            // 
            // TB_CAddress
            // 
            this.TB_CAddress.Location = new System.Drawing.Point(475, 342);
            this.TB_CAddress.Name = "TB_CAddress";
            this.TB_CAddress.Size = new System.Drawing.Size(201, 20);
            this.TB_CAddress.TabIndex = 11;
            // 
            // TB_CEmail
            // 
            this.TB_CEmail.Location = new System.Drawing.Point(475, 273);
            this.TB_CEmail.Name = "TB_CEmail";
            this.TB_CEmail.Size = new System.Drawing.Size(201, 20);
            this.TB_CEmail.TabIndex = 10;
            // 
            // LB_Telephone
            // 
            this.LB_Telephone.AutoSize = true;
            this.LB_Telephone.Location = new System.Drawing.Point(136, 326);
            this.LB_Telephone.Name = "LB_Telephone";
            this.LB_Telephone.Size = new System.Drawing.Size(98, 13);
            this.LB_Telephone.TabIndex = 15;
            this.LB_Telephone.Text = "Telephone Number";
            // 
            // TB_CTelephone
            // 
            this.TB_CTelephone.Location = new System.Drawing.Point(139, 342);
            this.TB_CTelephone.Name = "TB_CTelephone";
            this.TB_CTelephone.Size = new System.Drawing.Size(201, 20);
            this.TB_CTelephone.TabIndex = 14;
            // 
            // BT_Change
            // 
            this.BT_Change.Location = new System.Drawing.Point(345, 395);
            this.BT_Change.Name = "BT_Change";
            this.BT_Change.Size = new System.Drawing.Size(124, 27);
            this.BT_Change.TabIndex = 16;
            this.BT_Change.Text = "Change";
            this.BT_Change.UseVisualStyleBackColor = true;
            // 
            // EditInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BT_Change);
            this.Controls.Add(this.LB_Telephone);
            this.Controls.Add(this.TB_CTelephone);
            this.Controls.Add(this.LB_Address);
            this.Controls.Add(this.LB_Email);
            this.Controls.Add(this.TB_CAddress);
            this.Controls.Add(this.TB_CEmail);
            this.Controls.Add(this.TB_CName);
            this.Controls.Add(this.LB_Name);
            this.Controls.Add(this.LLB_ChangeImg);
            this.Controls.Add(this.PB_UserPicture);
            this.Name = "EditInformation";
            this.Text = "Edit Information";
            ((System.ComponentModel.ISupportInitialize)(this.PB_UserPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_UserPicture;
        private System.Windows.Forms.LinkLabel LLB_ChangeImg;
        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.TextBox TB_CName;
        private System.Windows.Forms.Label LB_Address;
        private System.Windows.Forms.Label LB_Email;
        private System.Windows.Forms.TextBox TB_CAddress;
        private System.Windows.Forms.TextBox TB_CEmail;
        private System.Windows.Forms.Label LB_Telephone;
        private System.Windows.Forms.TextBox TB_CTelephone;
        private System.Windows.Forms.Button BT_Change;
    }
}