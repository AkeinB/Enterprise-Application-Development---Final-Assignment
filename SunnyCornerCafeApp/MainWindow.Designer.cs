namespace SunnyCornerCafeApp
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditProfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BT_Orders = new System.Windows.Forms.Button();
            this.BT_Cart = new System.Windows.Forms.Button();
            this.BT_BookTable = new System.Windows.Forms.Button();
            this.BT_Pastries = new System.Windows.Forms.Button();
            this.BT_Deli = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_UpdatePwPrompt = new System.Windows.Forms.Button();
            this.PB_Logo = new System.Windows.Forms.PictureBox();
            this.BT_CDrinks = new System.Windows.Forms.Button();
            this.BT_HDrinks = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userProfileToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.bookTableToolStripMenuItem,
            this.ordersToolStripMenuItem2,
            this.cartToolStripMenuItem,
            this.managerUsersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(767, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userProfileToolStripMenuItem
            // 
            this.userProfileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.EditProfilesToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.userProfileToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userProfileToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.userProfileToolStripMenuItem.Name = "userProfileToolStripMenuItem";
            this.userProfileToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.userProfileToolStripMenuItem.Text = "User Profile";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.accountToolStripMenuItem.Text = "Account Information";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // EditProfilesToolStripMenuItem
            // 
            this.EditProfilesToolStripMenuItem.Name = "EditProfilesToolStripMenuItem";
            this.EditProfilesToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.EditProfilesToolStripMenuItem.Text = "Edit Profile";
            this.EditProfilesToolStripMenuItem.Click += new System.EventHandler(this.EditProfilesToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.logoutToolStripMenuItem.Text = "Log out";
            this.logoutToolStripMenuItem.Visible = false;
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // bookTableToolStripMenuItem
            // 
            this.bookTableToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTableToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.bookTableToolStripMenuItem.Name = "bookTableToolStripMenuItem";
            this.bookTableToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.bookTableToolStripMenuItem.Text = "Book Table";
            this.bookTableToolStripMenuItem.Visible = false;
            // 
            // ordersToolStripMenuItem2
            // 
            this.ordersToolStripMenuItem2.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersToolStripMenuItem2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.ordersToolStripMenuItem2.Name = "ordersToolStripMenuItem2";
            this.ordersToolStripMenuItem2.Size = new System.Drawing.Size(58, 20);
            this.ordersToolStripMenuItem2.Text = "Orders";
            this.ordersToolStripMenuItem2.Click += new System.EventHandler(this.ordersToolStripMenuItem2_Click);
            // 
            // cartToolStripMenuItem
            // 
            this.cartToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.cartToolStripMenuItem.Name = "cartToolStripMenuItem";
            this.cartToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.cartToolStripMenuItem.Text = "Cart";
            this.cartToolStripMenuItem.Visible = false;
            // 
            // managerUsersToolStripMenuItem
            // 
            this.managerUsersToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerUsersToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.managerUsersToolStripMenuItem.Name = "managerUsersToolStripMenuItem";
            this.managerUsersToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.managerUsersToolStripMenuItem.Text = "Manage Users";
            this.managerUsersToolStripMenuItem.Click += new System.EventHandler(this.managerUsersToolStripMenuItem_Click);
            // 
            // BT_Orders
            // 
            this.BT_Orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BT_Orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Orders.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Orders.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BT_Orders.Location = new System.Drawing.Point(32, 278);
            this.BT_Orders.Name = "BT_Orders";
            this.BT_Orders.Size = new System.Drawing.Size(145, 38);
            this.BT_Orders.TabIndex = 2;
            this.BT_Orders.Text = "Orders";
            this.BT_Orders.UseVisualStyleBackColor = false;
            this.BT_Orders.Click += new System.EventHandler(this.BT_Orders_Click);
            // 
            // BT_Cart
            // 
            this.BT_Cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BT_Cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Cart.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Cart.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BT_Cart.Location = new System.Drawing.Point(32, 331);
            this.BT_Cart.Name = "BT_Cart";
            this.BT_Cart.Size = new System.Drawing.Size(145, 38);
            this.BT_Cart.TabIndex = 3;
            this.BT_Cart.Text = "Cart";
            this.BT_Cart.UseVisualStyleBackColor = false;
            this.BT_Cart.Click += new System.EventHandler(this.BT_Cart_Click);
            // 
            // BT_BookTable
            // 
            this.BT_BookTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BT_BookTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_BookTable.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_BookTable.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BT_BookTable.Location = new System.Drawing.Point(32, 384);
            this.BT_BookTable.Name = "BT_BookTable";
            this.BT_BookTable.Size = new System.Drawing.Size(145, 38);
            this.BT_BookTable.TabIndex = 4;
            this.BT_BookTable.Text = "Book Table";
            this.BT_BookTable.UseVisualStyleBackColor = false;
            this.BT_BookTable.Click += new System.EventHandler(this.BT_BookTable_Click);
            // 
            // BT_Pastries
            // 
            this.BT_Pastries.BackColor = System.Drawing.Color.Transparent;
            this.BT_Pastries.BackgroundImage = global::SunnyCornerCafeApp.Properties.Resources.Pastries_Main;
            this.BT_Pastries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_Pastries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Pastries.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Pastries.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BT_Pastries.Location = new System.Drawing.Point(601, 262);
            this.BT_Pastries.Name = "BT_Pastries";
            this.BT_Pastries.Size = new System.Drawing.Size(150, 177);
            this.BT_Pastries.TabIndex = 7;
            this.BT_Pastries.Text = "Pastries";
            this.BT_Pastries.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BT_Pastries.UseVisualStyleBackColor = false;
            // 
            // BT_Deli
            // 
            this.BT_Deli.BackColor = System.Drawing.Color.Transparent;
            this.BT_Deli.BackgroundImage = global::SunnyCornerCafeApp.Properties.Resources.sandwich;
            this.BT_Deli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_Deli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Deli.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Deli.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BT_Deli.Location = new System.Drawing.Point(445, 262);
            this.BT_Deli.Name = "BT_Deli";
            this.BT_Deli.Size = new System.Drawing.Size(150, 177);
            this.BT_Deli.TabIndex = 8;
            this.BT_Deli.Text = "Deli";
            this.BT_Deli.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BT_Deli.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.Location = new System.Drawing.Point(111, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "WELCOME     TO";
            // 
            // BTN_UpdatePwPrompt
            // 
            this.BTN_UpdatePwPrompt.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BTN_UpdatePwPrompt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_UpdatePwPrompt.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_UpdatePwPrompt.Location = new System.Drawing.Point(461, 27);
            this.BTN_UpdatePwPrompt.Name = "BTN_UpdatePwPrompt";
            this.BTN_UpdatePwPrompt.Size = new System.Drawing.Size(289, 42);
            this.BTN_UpdatePwPrompt.TabIndex = 12;
            this.BTN_UpdatePwPrompt.Text = "You are useing a default password, Click here to Update password!";
            this.BTN_UpdatePwPrompt.UseVisualStyleBackColor = false;
            this.BTN_UpdatePwPrompt.Visible = false;
            this.BTN_UpdatePwPrompt.Click += new System.EventHandler(this.BTN_UpdatePwPrompt_Click);
            // 
            // PB_Logo
            // 
            this.PB_Logo.BackColor = System.Drawing.Color.Transparent;
            this.PB_Logo.Image = global::SunnyCornerCafeApp.Properties.Resources.Sunny_corner_Cafe_logo_V1;
            this.PB_Logo.Location = new System.Drawing.Point(12, 46);
            this.PB_Logo.Name = "PB_Logo";
            this.PB_Logo.Size = new System.Drawing.Size(443, 250);
            this.PB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Logo.TabIndex = 11;
            this.PB_Logo.TabStop = false;
            // 
            // BT_CDrinks
            // 
            this.BT_CDrinks.BackColor = System.Drawing.Color.Gainsboro;
            this.BT_CDrinks.BackgroundImage = global::SunnyCornerCafeApp.Properties.Resources.iced_mocha;
            this.BT_CDrinks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_CDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_CDrinks.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CDrinks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BT_CDrinks.Location = new System.Drawing.Point(601, 79);
            this.BT_CDrinks.Name = "BT_CDrinks";
            this.BT_CDrinks.Size = new System.Drawing.Size(150, 177);
            this.BT_CDrinks.TabIndex = 6;
            this.BT_CDrinks.Text = "Cold Drinks";
            this.BT_CDrinks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BT_CDrinks.UseVisualStyleBackColor = false;
            // 
            // BT_HDrinks
            // 
            this.BT_HDrinks.BackColor = System.Drawing.Color.Transparent;
            this.BT_HDrinks.BackgroundImage = global::SunnyCornerCafeApp.Properties.Resources.latte;
            this.BT_HDrinks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_HDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_HDrinks.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_HDrinks.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BT_HDrinks.Location = new System.Drawing.Point(445, 79);
            this.BT_HDrinks.Name = "BT_HDrinks";
            this.BT_HDrinks.Size = new System.Drawing.Size(150, 177);
            this.BT_HDrinks.TabIndex = 5;
            this.BT_HDrinks.Text = "Hot Drinks";
            this.BT_HDrinks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BT_HDrinks.UseVisualStyleBackColor = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::SunnyCornerCafeApp.Properties.Resources.cafe_bar_V2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.BTN_UpdatePwPrompt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_Deli);
            this.Controls.Add(this.BT_Pastries);
            this.Controls.Add(this.BT_CDrinks);
            this.Controls.Add(this.BT_HDrinks);
            this.Controls.Add(this.BT_BookTable);
            this.Controls.Add(this.BT_Cart);
            this.Controls.Add(this.BT_Orders);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.PB_Logo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sunny Corner Cafe";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditProfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cartToolStripMenuItem;
        private System.Windows.Forms.Button BT_Orders;
        private System.Windows.Forms.Button BT_Cart;
        private System.Windows.Forms.Button BT_BookTable;
        private System.Windows.Forms.Button BT_HDrinks;
        private System.Windows.Forms.Button BT_CDrinks;
        private System.Windows.Forms.Button BT_Pastries;
        private System.Windows.Forms.Button BT_Deli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.PictureBox PB_Logo;
        private System.Windows.Forms.Button BTN_UpdatePwPrompt;
    }
}