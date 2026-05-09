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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BT_Orders = new System.Windows.Forms.Button();
            this.BT_Cart = new System.Windows.Forms.Button();
            this.BT_BookTable = new System.Windows.Forms.Button();
            this.BT_HDrinks = new System.Windows.Forms.Button();
            this.BT_CDrinks = new System.Windows.Forms.Button();
            this.BT_Pastries = new System.Windows.Forms.Button();
            this.BT_Deli = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
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
            this.ordersToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.userProfileToolStripMenuItem.Name = "userProfileToolStripMenuItem";
            this.userProfileToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.userProfileToolStripMenuItem.Text = "User Profile";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.accountToolStripMenuItem.Text = "Account Information";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ordersToolStripMenuItem.Text = "Edit Profile";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // bookTableToolStripMenuItem
            // 
            this.bookTableToolStripMenuItem.Name = "bookTableToolStripMenuItem";
            this.bookTableToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.bookTableToolStripMenuItem.Text = "Book Table";
            // 
            // ordersToolStripMenuItem2
            // 
            this.ordersToolStripMenuItem2.Name = "ordersToolStripMenuItem2";
            this.ordersToolStripMenuItem2.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem2.Text = "Orders";
            // 
            // cartToolStripMenuItem
            // 
            this.cartToolStripMenuItem.Name = "cartToolStripMenuItem";
            this.cartToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.cartToolStripMenuItem.Text = "Cart";
            // 
            // managerUsersToolStripMenuItem
            // 
            this.managerUsersToolStripMenuItem.Name = "managerUsersToolStripMenuItem";
            this.managerUsersToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.managerUsersToolStripMenuItem.Text = "Manage Users";
            this.managerUsersToolStripMenuItem.Click += new System.EventHandler(this.managerUsersToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.logoutToolStripMenuItem.Text = "Log out";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // BT_Orders
            // 
            this.BT_Orders.Location = new System.Drawing.Point(32, 278);
            this.BT_Orders.Name = "BT_Orders";
            this.BT_Orders.Size = new System.Drawing.Size(145, 38);
            this.BT_Orders.TabIndex = 2;
            this.BT_Orders.Text = "Orders";
            this.BT_Orders.UseVisualStyleBackColor = true;
            this.BT_Orders.Click += new System.EventHandler(this.BT_Orders_Click);
            // 
            // BT_Cart
            // 
            this.BT_Cart.Location = new System.Drawing.Point(32, 331);
            this.BT_Cart.Name = "BT_Cart";
            this.BT_Cart.Size = new System.Drawing.Size(145, 38);
            this.BT_Cart.TabIndex = 3;
            this.BT_Cart.Text = "Cart";
            this.BT_Cart.UseVisualStyleBackColor = true;
            this.BT_Cart.Click += new System.EventHandler(this.BT_Cart_Click);
            // 
            // BT_BookTable
            // 
            this.BT_BookTable.Location = new System.Drawing.Point(32, 384);
            this.BT_BookTable.Name = "BT_BookTable";
            this.BT_BookTable.Size = new System.Drawing.Size(145, 38);
            this.BT_BookTable.TabIndex = 4;
            this.BT_BookTable.Text = "Book Table";
            this.BT_BookTable.UseVisualStyleBackColor = true;
            this.BT_BookTable.Click += new System.EventHandler(this.BT_BookTable_Click);
            // 
            // BT_HDrinks
            // 
            this.BT_HDrinks.Location = new System.Drawing.Point(445, 79);
            this.BT_HDrinks.Name = "BT_HDrinks";
            this.BT_HDrinks.Size = new System.Drawing.Size(150, 177);
            this.BT_HDrinks.TabIndex = 5;
            this.BT_HDrinks.Text = "Hot Drinks";
            this.BT_HDrinks.UseVisualStyleBackColor = true;
            // 
            // BT_CDrinks
            // 
            this.BT_CDrinks.Location = new System.Drawing.Point(601, 79);
            this.BT_CDrinks.Name = "BT_CDrinks";
            this.BT_CDrinks.Size = new System.Drawing.Size(150, 177);
            this.BT_CDrinks.TabIndex = 6;
            this.BT_CDrinks.Text = "Cold Drinks";
            this.BT_CDrinks.UseVisualStyleBackColor = true;
            // 
            // BT_Pastries
            // 
            this.BT_Pastries.Location = new System.Drawing.Point(601, 262);
            this.BT_Pastries.Name = "BT_Pastries";
            this.BT_Pastries.Size = new System.Drawing.Size(150, 177);
            this.BT_Pastries.TabIndex = 7;
            this.BT_Pastries.Text = "Pastries";
            this.BT_Pastries.UseVisualStyleBackColor = true;
            // 
            // BT_Deli
            // 
            this.BT_Deli.Location = new System.Drawing.Point(445, 262);
            this.BT_Deli.Name = "BT_Deli";
            this.BT_Deli.Size = new System.Drawing.Size(150, 177);
            this.BT_Deli.TabIndex = 8;
            this.BT_Deli.Text = "Deli";
            this.BT_Deli.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("a Auto Signature", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "WELCOME     TO";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_Deli);
            this.Controls.Add(this.BT_Pastries);
            this.Controls.Add(this.BT_CDrinks);
            this.Controls.Add(this.BT_HDrinks);
            this.Controls.Add(this.BT_BookTable);
            this.Controls.Add(this.BT_Cart);
            this.Controls.Add(this.BT_Orders);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sunny Corner Cafe";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
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
    }
}