namespace SunnyCornerCafeApp
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.LB_Password = new System.Windows.Forms.Label();
            this.TB_UserName = new System.Windows.Forms.TextBox();
            this.LB_UserName = new System.Windows.Forms.Label();
            this.LB_WelcomeToParadise = new System.Windows.Forms.Label();
            this.LB_SignInHere = new System.Windows.Forms.Label();
            this.BTN_SignUp = new System.Windows.Forms.Button();
            this.TB_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.LB_ConfirmPassword = new System.Windows.Forms.Label();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.LB_Email = new System.Windows.Forms.Label();
            this.PB_SignInImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_SignInImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(27, 332);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(251, 20);
            this.TB_Password.TabIndex = 11;
            // 
            // LB_Password
            // 
            this.LB_Password.AutoSize = true;
            this.LB_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LB_Password.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Password.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.LB_Password.Location = new System.Drawing.Point(27, 316);
            this.LB_Password.Name = "LB_Password";
            this.LB_Password.Size = new System.Drawing.Size(63, 16);
            this.LB_Password.TabIndex = 10;
            this.LB_Password.Text = "Password";
            // 
            // TB_UserName
            // 
            this.TB_UserName.Location = new System.Drawing.Point(28, 212);
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(251, 20);
            this.TB_UserName.TabIndex = 9;
            // 
            // LB_UserName
            // 
            this.LB_UserName.AutoSize = true;
            this.LB_UserName.BackColor = System.Drawing.Color.Transparent;
            this.LB_UserName.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LB_UserName.Location = new System.Drawing.Point(28, 196);
            this.LB_UserName.Name = "LB_UserName";
            this.LB_UserName.Size = new System.Drawing.Size(71, 16);
            this.LB_UserName.TabIndex = 8;
            this.LB_UserName.Text = "User Name";
            // 
            // LB_WelcomeToParadise
            // 
            this.LB_WelcomeToParadise.AutoSize = true;
            this.LB_WelcomeToParadise.BackColor = System.Drawing.Color.Transparent;
            this.LB_WelcomeToParadise.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_WelcomeToParadise.ForeColor = System.Drawing.Color.Cornsilk;
            this.LB_WelcomeToParadise.Location = new System.Drawing.Point(37, 145);
            this.LB_WelcomeToParadise.Name = "LB_WelcomeToParadise";
            this.LB_WelcomeToParadise.Size = new System.Drawing.Size(221, 19);
            this.LB_WelcomeToParadise.TabIndex = 7;
            this.LB_WelcomeToParadise.Text = "Welcome to Slice of Paradise";
            // 
            // LB_SignInHere
            // 
            this.LB_SignInHere.AutoSize = true;
            this.LB_SignInHere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LB_SignInHere.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_SignInHere.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.LB_SignInHere.Location = new System.Drawing.Point(47, 495);
            this.LB_SignInHere.Name = "LB_SignInHere";
            this.LB_SignInHere.Size = new System.Drawing.Size(202, 28);
            this.LB_SignInHere.TabIndex = 9;
            this.LB_SignInHere.Text = "Already Have An Account? Sign In Here\r\n\r\n";
            this.LB_SignInHere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_SignInHere.Click += new System.EventHandler(this.LB_SignInHere_Click);
            // 
            // BTN_SignUp
            // 
            this.BTN_SignUp.BackColor = System.Drawing.Color.DarkKhaki;
            this.BTN_SignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SignUp.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SignUp.Location = new System.Drawing.Point(27, 443);
            this.BTN_SignUp.Name = "BTN_SignUp";
            this.BTN_SignUp.Size = new System.Drawing.Size(250, 50);
            this.BTN_SignUp.TabIndex = 8;
            this.BTN_SignUp.Text = "SIGNUP";
            this.BTN_SignUp.UseVisualStyleBackColor = false;
            this.BTN_SignUp.Click += new System.EventHandler(this.BTN_SignUp_Click);
            // 
            // TB_ConfirmPassword
            // 
            this.TB_ConfirmPassword.Location = new System.Drawing.Point(26, 395);
            this.TB_ConfirmPassword.Name = "TB_ConfirmPassword";
            this.TB_ConfirmPassword.PasswordChar = '*';
            this.TB_ConfirmPassword.Size = new System.Drawing.Size(251, 20);
            this.TB_ConfirmPassword.TabIndex = 12;
            // 
            // LB_ConfirmPassword
            // 
            this.LB_ConfirmPassword.AutoSize = true;
            this.LB_ConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LB_ConfirmPassword.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ConfirmPassword.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.LB_ConfirmPassword.Location = new System.Drawing.Point(26, 379);
            this.LB_ConfirmPassword.Name = "LB_ConfirmPassword";
            this.LB_ConfirmPassword.Size = new System.Drawing.Size(113, 16);
            this.LB_ConfirmPassword.TabIndex = 13;
            this.LB_ConfirmPassword.Text = "Confirm Password";
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(27, 268);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(251, 20);
            this.TB_Email.TabIndex = 10;
            // 
            // LB_Email
            // 
            this.LB_Email.AutoSize = true;
            this.LB_Email.BackColor = System.Drawing.Color.Transparent;
            this.LB_Email.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Email.ForeColor = System.Drawing.Color.Cornsilk;
            this.LB_Email.Location = new System.Drawing.Point(27, 252);
            this.LB_Email.Name = "LB_Email";
            this.LB_Email.Size = new System.Drawing.Size(39, 16);
            this.LB_Email.TabIndex = 15;
            this.LB_Email.Text = "Email";
            // 
            // PB_SignInImage
            // 
            this.PB_SignInImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_SignInImage.Image = global::SunnyCornerCafeApp.Properties.Resources._292_2924858_user_icon_business_man_flat_png_transparent_png;
            this.PB_SignInImage.Location = new System.Drawing.Point(88, 36);
            this.PB_SignInImage.Name = "PB_SignInImage";
            this.PB_SignInImage.Size = new System.Drawing.Size(112, 106);
            this.PB_SignInImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_SignInImage.TabIndex = 6;
            this.PB_SignInImage.TabStop = false;
            // 
            // SignUpForm
            // 
            this.AcceptButton = this.BTN_SignUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BackgroundImage = global::SunnyCornerCafeApp.Properties.Resources.dark_coffee;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(289, 580);
            this.Controls.Add(this.TB_Email);
            this.Controls.Add(this.LB_Email);
            this.Controls.Add(this.TB_ConfirmPassword);
            this.Controls.Add(this.LB_ConfirmPassword);
            this.Controls.Add(this.LB_SignInHere);
            this.Controls.Add(this.BTN_SignUp);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.LB_Password);
            this.Controls.Add(this.TB_UserName);
            this.Controls.Add(this.LB_UserName);
            this.Controls.Add(this.LB_WelcomeToParadise);
            this.Controls.Add(this.PB_SignInImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpForm";
            ((System.ComponentModel.ISupportInitialize)(this.PB_SignInImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Label LB_Password;
        private System.Windows.Forms.TextBox TB_UserName;
        private System.Windows.Forms.Label LB_UserName;
        private System.Windows.Forms.Label LB_WelcomeToParadise;
        private System.Windows.Forms.PictureBox PB_SignInImage;
        private System.Windows.Forms.Label LB_SignInHere;
        private System.Windows.Forms.Button BTN_SignUp;
        private System.Windows.Forms.TextBox TB_ConfirmPassword;
        private System.Windows.Forms.Label LB_ConfirmPassword;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.Label LB_Email;
    }
}