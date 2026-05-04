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
            this.PB_SignInImage = new System.Windows.Forms.PictureBox();
            this.LB_WelcomeBack = new System.Windows.Forms.Label();
            this.LB_UserName = new System.Windows.Forms.Label();
            this.TB_UserName = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.LB_Password = new System.Windows.Forms.Label();
            this.BTN_Login = new System.Windows.Forms.Button();
            this.LB_RegisterHere = new System.Windows.Forms.Label();
            this.PN_TopPanel = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_SignInImage)).BeginInit();
            this.PN_TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PB_SignInImage
            // 
            this.PB_SignInImage.Location = new System.Drawing.Point(85, 122);
            this.PB_SignInImage.Name = "PB_SignInImage";
            this.PB_SignInImage.Size = new System.Drawing.Size(112, 113);
            this.PB_SignInImage.TabIndex = 0;
            this.PB_SignInImage.TabStop = false;
            // 
            // LB_WelcomeBack
            // 
            this.LB_WelcomeBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_WelcomeBack.AutoSize = true;
            this.LB_WelcomeBack.Location = new System.Drawing.Point(116, 238);
            this.LB_WelcomeBack.Name = "LB_WelcomeBack";
            this.LB_WelcomeBack.Size = new System.Drawing.Size(52, 13);
            this.LB_WelcomeBack.TabIndex = 1;
            this.LB_WelcomeBack.Text = "Welcome";
            // 
            // LB_UserName
            // 
            this.LB_UserName.AutoSize = true;
            this.LB_UserName.Location = new System.Drawing.Point(21, 272);
            this.LB_UserName.Name = "LB_UserName";
            this.LB_UserName.Size = new System.Drawing.Size(60, 13);
            this.LB_UserName.TabIndex = 2;
            this.LB_UserName.Text = "User Name";
            // 
            // TB_UserName
            // 
            this.TB_UserName.Location = new System.Drawing.Point(25, 298);
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(251, 20);
            this.TB_UserName.TabIndex = 3;
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(24, 357);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(251, 20);
            this.TB_Password.TabIndex = 5;
            // 
            // LB_Password
            // 
            this.LB_Password.AutoSize = true;
            this.LB_Password.Location = new System.Drawing.Point(20, 331);
            this.LB_Password.Name = "LB_Password";
            this.LB_Password.Size = new System.Drawing.Size(53, 13);
            this.LB_Password.TabIndex = 4;
            this.LB_Password.Text = "Password";
            // 
            // BTN_Login
            // 
            this.BTN_Login.Location = new System.Drawing.Point(23, 431);
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
            this.LB_RegisterHere.Location = new System.Drawing.Point(70, 495);
            this.LB_RegisterHere.Name = "LB_RegisterHere";
            this.LB_RegisterHere.Size = new System.Drawing.Size(157, 13);
            this.LB_RegisterHere.TabIndex = 7;
            this.LB_RegisterHere.Text = "No Account Yet? Register Here";
            this.LB_RegisterHere.Click += new System.EventHandler(this.LB_RegisterHere_Click);
            // 
            // PN_TopPanel
            // 
            this.PN_TopPanel.BackColor = System.Drawing.Color.White;
            this.PN_TopPanel.Controls.Add(this.close);
            this.PN_TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_TopPanel.Location = new System.Drawing.Point(0, 0);
            this.PN_TopPanel.Name = "PN_TopPanel";
            this.PN_TopPanel.Size = new System.Drawing.Size(289, 35);
            this.PN_TopPanel.TabIndex = 8;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Firebrick;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(236, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(41, 23);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 556);
            this.Controls.Add(this.PN_TopPanel);
            this.Controls.Add(this.LB_RegisterHere);
            this.Controls.Add(this.BTN_Login);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.LB_Password);
            this.Controls.Add(this.TB_UserName);
            this.Controls.Add(this.LB_UserName);
            this.Controls.Add(this.LB_WelcomeBack);
            this.Controls.Add(this.PB_SignInImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_SignInImage)).EndInit();
            this.PN_TopPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel PN_TopPanel;
        private System.Windows.Forms.Button close;
    }
}

