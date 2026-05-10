namespace SunnyCornerCafeApp
{
    partial class EditPassword
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
            this.LB_OldPassword = new System.Windows.Forms.Label();
            this.TB_OldPassword = new System.Windows.Forms.TextBox();
            this.TB_NewPassword = new System.Windows.Forms.TextBox();
            this.LB_NewPassword = new System.Windows.Forms.Label();
            this.TB_ConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.LB_ConfirmNewPassword = new System.Windows.Forms.Label();
            this.BTN_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_OldPassword
            // 
            this.LB_OldPassword.AutoSize = true;
            this.LB_OldPassword.Location = new System.Drawing.Point(28, 93);
            this.LB_OldPassword.Name = "LB_OldPassword";
            this.LB_OldPassword.Size = new System.Drawing.Size(72, 13);
            this.LB_OldPassword.TabIndex = 0;
            this.LB_OldPassword.Text = "Old Password";
            // 
            // TB_OldPassword
            // 
            this.TB_OldPassword.Location = new System.Drawing.Point(150, 93);
            this.TB_OldPassword.Name = "TB_OldPassword";
            this.TB_OldPassword.PasswordChar = '*';
            this.TB_OldPassword.Size = new System.Drawing.Size(179, 20);
            this.TB_OldPassword.TabIndex = 1;
            // 
            // TB_NewPassword
            // 
            this.TB_NewPassword.Location = new System.Drawing.Point(150, 156);
            this.TB_NewPassword.Name = "TB_NewPassword";
            this.TB_NewPassword.PasswordChar = '*';
            this.TB_NewPassword.Size = new System.Drawing.Size(179, 20);
            this.TB_NewPassword.TabIndex = 3;
            // 
            // LB_NewPassword
            // 
            this.LB_NewPassword.AutoSize = true;
            this.LB_NewPassword.Location = new System.Drawing.Point(28, 156);
            this.LB_NewPassword.Name = "LB_NewPassword";
            this.LB_NewPassword.Size = new System.Drawing.Size(78, 13);
            this.LB_NewPassword.TabIndex = 2;
            this.LB_NewPassword.Text = "New Password";
            // 
            // TB_ConfirmNewPassword
            // 
            this.TB_ConfirmNewPassword.Location = new System.Drawing.Point(150, 220);
            this.TB_ConfirmNewPassword.Name = "TB_ConfirmNewPassword";
            this.TB_ConfirmNewPassword.PasswordChar = '*';
            this.TB_ConfirmNewPassword.Size = new System.Drawing.Size(179, 20);
            this.TB_ConfirmNewPassword.TabIndex = 5;
            // 
            // LB_ConfirmNewPassword
            // 
            this.LB_ConfirmNewPassword.AutoSize = true;
            this.LB_ConfirmNewPassword.Location = new System.Drawing.Point(28, 220);
            this.LB_ConfirmNewPassword.Name = "LB_ConfirmNewPassword";
            this.LB_ConfirmNewPassword.Size = new System.Drawing.Size(116, 13);
            this.LB_ConfirmNewPassword.TabIndex = 4;
            this.LB_ConfirmNewPassword.Text = "Confirm New Password";
            // 
            // BTN_Submit
            // 
            this.BTN_Submit.Location = new System.Drawing.Point(127, 278);
            this.BTN_Submit.Name = "BTN_Submit";
            this.BTN_Submit.Size = new System.Drawing.Size(100, 42);
            this.BTN_Submit.TabIndex = 6;
            this.BTN_Submit.Text = "Submit";
            this.BTN_Submit.UseVisualStyleBackColor = true;
            this.BTN_Submit.Click += new System.EventHandler(this.BTN_Submit_Click);
            // 
            // EditPassword
            // 
            this.AcceptButton = this.BTN_Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 347);
            this.Controls.Add(this.BTN_Submit);
            this.Controls.Add(this.TB_ConfirmNewPassword);
            this.Controls.Add(this.LB_ConfirmNewPassword);
            this.Controls.Add(this.TB_NewPassword);
            this.Controls.Add(this.LB_NewPassword);
            this.Controls.Add(this.TB_OldPassword);
            this.Controls.Add(this.LB_OldPassword);
            this.Name = "EditPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_OldPassword;
        private System.Windows.Forms.TextBox TB_OldPassword;
        private System.Windows.Forms.TextBox TB_NewPassword;
        private System.Windows.Forms.Label LB_NewPassword;
        private System.Windows.Forms.TextBox TB_ConfirmNewPassword;
        private System.Windows.Forms.Label LB_ConfirmNewPassword;
        private System.Windows.Forms.Button BTN_Submit;
    }
}