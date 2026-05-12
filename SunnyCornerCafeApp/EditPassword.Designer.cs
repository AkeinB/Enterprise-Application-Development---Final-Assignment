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
            this.BTN_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_OldPassword
            // 
            this.LB_OldPassword.AutoSize = true;
            this.LB_OldPassword.Location = new System.Drawing.Point(33, 114);
            this.LB_OldPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_OldPassword.Name = "LB_OldPassword";
            this.LB_OldPassword.Size = new System.Drawing.Size(83, 16);
            this.LB_OldPassword.TabIndex = 0;
            this.LB_OldPassword.Text = "Old Password";
            // 
            // TB_OldPassword
            // 
            this.TB_OldPassword.Location = new System.Drawing.Point(175, 114);
            this.TB_OldPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TB_OldPassword.Name = "TB_OldPassword";
            this.TB_OldPassword.PasswordChar = '*';
            this.TB_OldPassword.Size = new System.Drawing.Size(208, 27);
            this.TB_OldPassword.TabIndex = 1;
            // 
            // TB_NewPassword
            // 
            this.TB_NewPassword.Location = new System.Drawing.Point(175, 192);
            this.TB_NewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TB_NewPassword.Name = "TB_NewPassword";
            this.TB_NewPassword.PasswordChar = '*';
            this.TB_NewPassword.Size = new System.Drawing.Size(208, 27);
            this.TB_NewPassword.TabIndex = 3;
            // 
            // LB_NewPassword
            // 
            this.LB_NewPassword.AutoSize = true;
            this.LB_NewPassword.Location = new System.Drawing.Point(33, 192);
            this.LB_NewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_NewPassword.Name = "LB_NewPassword";
            this.LB_NewPassword.Size = new System.Drawing.Size(89, 16);
            this.LB_NewPassword.TabIndex = 2;
            this.LB_NewPassword.Text = "New Password";
            // 
            // TB_ConfirmNewPassword
            // 
            this.TB_ConfirmNewPassword.Location = new System.Drawing.Point(175, 271);
            this.TB_ConfirmNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TB_ConfirmNewPassword.Name = "TB_ConfirmNewPassword";
            this.TB_ConfirmNewPassword.PasswordChar = '*';
            this.TB_ConfirmNewPassword.Size = new System.Drawing.Size(208, 27);
            this.TB_ConfirmNewPassword.TabIndex = 5;
            // 
            // LB_ConfirmNewPassword
            // 
            this.LB_ConfirmNewPassword.AutoSize = true;
            this.LB_ConfirmNewPassword.Location = new System.Drawing.Point(33, 271);
            this.LB_ConfirmNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_ConfirmNewPassword.Name = "LB_ConfirmNewPassword";
            this.LB_ConfirmNewPassword.Size = new System.Drawing.Size(135, 16);
            this.LB_ConfirmNewPassword.TabIndex = 4;
            this.LB_ConfirmNewPassword.Text = "Confirm New Password";
            // 
            // BTN_Submit
            // 
            this.BTN_Submit.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BTN_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Submit.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BTN_Submit.Location = new System.Drawing.Point(82, 339);
            this.BTN_Submit.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Submit.Name = "BTN_Submit";
            this.BTN_Submit.Size = new System.Drawing.Size(117, 52);
            this.BTN_Submit.TabIndex = 6;
            this.BTN_Submit.Text = "Submit";
            this.BTN_Submit.UseVisualStyleBackColor = false;
            this.BTN_Submit.Click += new System.EventHandler(this.BTN_Submit_Click);
            // 
            // BTN_Close
            // 
            this.BTN_Close.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BTN_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Close.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BTN_Close.Location = new System.Drawing.Point(217, 339);
            this.BTN_Close.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(117, 52);
            this.BTN_Close.TabIndex = 7;
            this.BTN_Close.Text = "Close";
            this.BTN_Close.UseVisualStyleBackColor = false;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // EditPassword
            // 
            this.AcceptButton = this.BTN_Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(420, 427);
            this.Controls.Add(this.BTN_Close);
            this.Controls.Add(this.BTN_Submit);
            this.Controls.Add(this.TB_ConfirmNewPassword);
            this.Controls.Add(this.LB_ConfirmNewPassword);
            this.Controls.Add(this.TB_NewPassword);
            this.Controls.Add(this.LB_NewPassword);
            this.Controls.Add(this.TB_OldPassword);
            this.Controls.Add(this.LB_OldPassword);
            this.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button BTN_Close;
    }
}