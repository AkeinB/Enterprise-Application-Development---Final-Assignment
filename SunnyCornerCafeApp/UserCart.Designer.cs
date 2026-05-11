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
            this.BT_Checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Checkout.Location = new System.Drawing.Point(134, 394);
            this.BT_Checkout.Name = "BT_Checkout";
            this.BT_Checkout.Size = new System.Drawing.Size(142, 58);
            this.BT_Checkout.TabIndex = 0;
            this.BT_Checkout.Text = "CHECKOUT";
            this.BT_Checkout.UseVisualStyleBackColor = true;
            this.BT_Checkout.Click += new System.EventHandler(this.BT_Checkout_Click);
            // 
            // LB_YourCart
            // 
            this.LB_YourCart.AutoSize = true;
            this.LB_YourCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_YourCart.Location = new System.Drawing.Point(64, 33);
            this.LB_YourCart.Name = "LB_YourCart";
            this.LB_YourCart.Size = new System.Drawing.Size(165, 39);
            this.LB_YourCart.TabIndex = 1;
            this.LB_YourCart.Text = "Your Cart";
            // 
            // BT_AddMore
            // 
            this.BT_AddMore.Location = new System.Drawing.Point(53, 409);
            this.BT_AddMore.Name = "BT_AddMore";
            this.BT_AddMore.Size = new System.Drawing.Size(75, 23);
            this.BT_AddMore.TabIndex = 2;
            this.BT_AddMore.Text = "Add More";
            this.BT_AddMore.UseVisualStyleBackColor = true;
            // 
            // BT_Back
            // 
            this.BT_Back.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BT_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_Back.Location = new System.Drawing.Point(12, 12);
            this.BT_Back.Name = "BT_Back";
            this.BT_Back.Size = new System.Drawing.Size(31, 31);
            this.BT_Back.TabIndex = 3;
            this.BT_Back.Text = "<";
            this.BT_Back.UseVisualStyleBackColor = false;
            this.BT_Back.Click += new System.EventHandler(this.BT_Back_Click);
            // 
            // GV_Cart
            // 
            this.GV_Cart.AllowUserToResizeColumns = false;
            this.GV_Cart.AllowUserToResizeRows = false;
            this.GV_Cart.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GV_Cart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GV_Cart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GV_Cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_Cart.GridColor = System.Drawing.SystemColors.Control;
            this.GV_Cart.Location = new System.Drawing.Point(12, 100);
            this.GV_Cart.MultiSelect = false;
            this.GV_Cart.Name = "GV_Cart";
            this.GV_Cart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GV_Cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV_Cart.Size = new System.Drawing.Size(291, 252);
            this.GV_Cart.TabIndex = 4;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "OrderDetails";
            // 
            // UserCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 481);
            this.Controls.Add(this.GV_Cart);
            this.Controls.Add(this.BT_Back);
            this.Controls.Add(this.BT_AddMore);
            this.Controls.Add(this.LB_YourCart);
            this.Controls.Add(this.BT_Checkout);
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