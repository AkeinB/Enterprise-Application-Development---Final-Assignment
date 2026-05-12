namespace SunnyCornerCafeApp
{
    partial class UserCart
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCart));
            this.BT_Checkout = new System.Windows.Forms.Button();
            this.LB_YourCart = new System.Windows.Forms.Label();
            this.BT_AddMore = new System.Windows.Forms.Button();
            this.BT_Back = new System.Windows.Forms.Button();
            this.GV_Cart = new System.Windows.Forms.DataGridView();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GV_Cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Checkout
            // 
            this.BT_Checkout.BackColor = System.Drawing.Color.DarkKhaki;
            this.BT_Checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Checkout.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Checkout.Location = new System.Drawing.Point(198, 369);
            this.BT_Checkout.Name = "BT_Checkout";
            this.BT_Checkout.Size = new System.Drawing.Size(142, 62);
            this.BT_Checkout.TabIndex = 0;
            this.BT_Checkout.Text = "CHECKOUT";
            this.BT_Checkout.UseVisualStyleBackColor = false;
            this.BT_Checkout.Click += new System.EventHandler(this.BT_Checkout_Click);
            // 
            // LB_YourCart
            // 
            this.LB_YourCart.AutoSize = true;
            this.LB_YourCart.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_YourCart.Location = new System.Drawing.Point(80, 9);
            this.LB_YourCart.Name = "LB_YourCart";
            this.LB_YourCart.Size = new System.Drawing.Size(172, 45);
            this.LB_YourCart.TabIndex = 1;
            this.LB_YourCart.Text = "Your Cart";
            // 
            // BT_AddMore
            // 
            this.BT_AddMore.BackColor = System.Drawing.Color.DarkKhaki;
            this.BT_AddMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_AddMore.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_AddMore.Location = new System.Drawing.Point(88, 391);
            this.BT_AddMore.Name = "BT_AddMore";
            this.BT_AddMore.Size = new System.Drawing.Size(104, 29);
            this.BT_AddMore.TabIndex = 2;
            this.BT_AddMore.Text = "Add More";
            this.BT_AddMore.UseVisualStyleBackColor = false;
            // 
            // BT_Back
            // 
            this.BT_Back.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BT_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Back.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BT_Back.Location = new System.Drawing.Point(12, 13);
            this.BT_Back.Name = "BT_Back";
            this.BT_Back.Size = new System.Drawing.Size(26, 26);
            this.BT_Back.TabIndex = 3;
            this.BT_Back.Text = "<";
            this.BT_Back.UseVisualStyleBackColor = false;
            this.BT_Back.Click += new System.EventHandler(this.BT_Back_Click);
            // 
            // GV_Cart
            // 
            this.GV_Cart.AllowUserToResizeColumns = false;
            this.GV_Cart.AllowUserToResizeRows = false;
            this.GV_Cart.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.GV_Cart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GV_Cart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GV_Cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_Cart.GridColor = System.Drawing.SystemColors.Control;
            this.GV_Cart.Location = new System.Drawing.Point(12, 68);
            this.GV_Cart.MultiSelect = false;
            this.GV_Cart.Name = "GV_Cart";
            this.GV_Cart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GV_Cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV_Cart.Size = new System.Drawing.Size(330, 271);
            this.GV_Cart.TabIndex = 4;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "OrderDetails";
            // 
            // UserCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(352, 455);
            this.Controls.Add(this.GV_Cart);
            this.Controls.Add(this.BT_Back);
            this.Controls.Add(this.BT_AddMore);
            this.Controls.Add(this.LB_YourCart);
            this.Controls.Add(this.BT_Checkout);
            this.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.UserCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_Cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Checkout;
        private System.Windows.Forms.Label LB_YourCart;
        private System.Windows.Forms.Button BT_AddMore;
        private System.Windows.Forms.Button BT_Back;
        private System.Windows.Forms.DataGridView GV_Cart;
        
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
       
    }
}