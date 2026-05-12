namespace SunnyCornerCafeApp
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.PB_SignInImage = new System.Windows.Forms.PictureBox();
            this.LB_WelcomeBack = new System.Windows.Forms.Label();
            this.LB_UserName = new System.Windows.Forms.Label();
            this.TB_UserName = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.LB_Password = new System.Windows.Forms.Label();
            this.BTN_Login = new System.Windows.Forms.Button();
            this.LB_RegisterHere = new System.Windows.Forms.Label();
            this.CHB_ShowPW = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_SignInImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_SignInImage
            // 
            this.PB_SignInImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_SignInImage.Image = global::SunnyCornerCafeApp.Properties.Resources._292_2924858_user_icon_business_man_flat_png_transparent_png;
            this.PB_SignInImage.Location = new System.Drawing.Point(88, 47);
            this.PB_SignInImage.Name = "PB_SignInImage";
            this.PB_SignInImage.Size = new System.Drawing.Size(115, 110);
            this.PB_SignInImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_SignInImage.TabIndex = 0;
            this.PB_SignInImage.TabStop = false;
            // 
            // LB_WelcomeBack
            // 
            this.LB_WelcomeBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_WelcomeBack.AutoSize = true;
            this.LB_WelcomeBack.BackColor = System.Drawing.Color.Transparent;
            this.LB_WelcomeBack.Font = new System.Drawing.Font("Yu Gothic", 11.5F, System.Drawing.FontStyle.Bold);
            this.LB_WelcomeBack.ForeColor = System.Drawing.Color.Khaki;
            this.LB_WelcomeBack.Location = new System.Drawing.Point(106, 169);
            this.LB_WelcomeBack.Name = "LB_WelcomeBack";
            this.LB_WelcomeBack.Size = new System.Drawing.Size(81, 21);
            this.LB_WelcomeBack.TabIndex = 1;
            this.LB_WelcomeBack.Text = "Welcome";
            // 
            // LB_UserName
            // 
            this.LB_UserName.AutoSize = true;
            this.LB_UserName.BackColor = System.Drawing.Color.Transparent;
            this.LB_UserName.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.LB_UserName.ForeColor = System.Drawing.Color.Khaki;
            this.LB_UserName.Location = new System.Drawing.Point(22, 222);
            this.LB_UserName.Name = "LB_UserName";
            this.LB_UserName.Size = new System.Drawing.Size(80, 17);
            this.LB_UserName.TabIndex = 2;
            this.LB_UserName.Text = "User Name";
            // 
            // TB_UserName
            // 
            this.TB_UserName.Location = new System.Drawing.Point(25, 242);
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(251, 20);
            this.TB_UserName.TabIndex = 3;
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(24, 301);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(251, 20);
            this.TB_Password.TabIndex = 5;
            // 
            // LB_Password
            // 
            this.LB_Password.AutoSize = true;
            this.LB_Password.BackColor = System.Drawing.Color.Transparent;
            this.LB_Password.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.LB_Password.ForeColor = System.Drawing.Color.Khaki;
            this.LB_Password.Location = new System.Drawing.Point(22, 281);
            this.LB_Password.Name = "LB_Password";
            this.LB_Password.Size = new System.Drawing.Size(71, 17);
            this.LB_Password.TabIndex = 4;
            this.LB_Password.Text = "Password";
            // 
            // BTN_Login
            // 
            this.BTN_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Login.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Login.Location = new System.Drawing.Point(23, 375);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(250, 50);
            this.BTN_Login.TabIndex = 6;
            this.BTN_Login.Text = "LOGIN";
            this.BTN_Login.UseVisualStyleBackColor = true;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // LB_RegisterHere
            // 
            this.LB_RegisterHere.AutoSize = true;
            this.LB_RegisterHere.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_RegisterHere.Location = new System.Drawing.Point(58, 437);
            this.LB_RegisterHere.Name = "LB_RegisterHere";
            this.LB_RegisterHere.Size = new System.Drawing.Size(171, 14);
            this.LB_RegisterHere.TabIndex = 7;
            this.LB_RegisterHere.Text = "No Account Yet? Register Here";
            this.LB_RegisterHere.Click += new System.EventHandler(this.LB_RegisterHere_Click);
            // 
            // CHB_ShowPW
            // 
            this.CHB_ShowPW.AutoSize = true;
            this.CHB_ShowPW.BackColor = System.Drawing.Color.Transparent;
            this.CHB_ShowPW.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHB_ShowPW.ForeColor = System.Drawing.Color.Khaki;
            this.CHB_ShowPW.Location = new System.Drawing.Point(23, 331);
            this.CHB_ShowPW.Name = "CHB_ShowPW";
            this.CHB_ShowPW.Size = new System.Drawing.Size(112, 18);
            this.CHB_ShowPW.TabIndex = 9;
            this.CHB_ShowPW.Text = "Show Password";
            this.CHB_ShowPW.UseVisualStyleBackColor = false;
            this.CHB_ShowPW.CheckedChanged += new System.EventHandler(this.CHB_ShowPW_CheckedChanged);
            // 
            // LogInForm
            // 
            this.AcceptButton = this.BTN_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImage = global::SunnyCornerCafeApp.Properties.Resources.coffee;
            this.ClientSize = new System.Drawing.Size(289, 516);
            this.Controls.Add(this.CHB_ShowPW);
            this.Controls.Add(this.LB_RegisterHere);
            this.Controls.Add(this.BTN_Login);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.LB_Password);
            this.Controls.Add(this.TB_UserName);
            this.Controls.Add(this.LB_UserName);
            this.Controls.Add(this.LB_WelcomeBack);
            this.Controls.Add(this.PB_SignInImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.PB_SignInImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_SignInImage;
        private System.Windows.Forms.Label LB_WelcomeBack;
        private System.Windows.Forms.Label LB_UserName;
        private System.Windows.Forms.TextBox TB_UserName;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Label LB_Password;
        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.Label LB_RegisterHere;
        private System.Windows.Forms.CheckBox CHB_ShowPW;
    }
}

