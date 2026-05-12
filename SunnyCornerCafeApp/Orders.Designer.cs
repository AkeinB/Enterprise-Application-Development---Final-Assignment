namespace SunnyCornerCafeApp
{
    partial class Orders
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
            this.LB_Orders = new System.Windows.Forms.Label();
            this.GV_OrderList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BTN_NewOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GV_OrderList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Orders
            // 
            this.LB_Orders.AutoSize = true;
            this.LB_Orders.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Orders.Location = new System.Drawing.Point(200, 15);
            this.LB_Orders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Orders.Name = "LB_Orders";
            this.LB_Orders.Size = new System.Drawing.Size(124, 42);
            this.LB_Orders.TabIndex = 0;
            this.LB_Orders.Text = "Orders";
            // 
            // GV_OrderList
            // 
            this.GV_OrderList.AllowUserToAddRows = false;
            this.GV_OrderList.AllowUserToDeleteRows = false;
            this.GV_OrderList.AllowUserToResizeColumns = false;
            this.GV_OrderList.AllowUserToResizeRows = false;
            this.GV_OrderList.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.GV_OrderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GV_OrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV_OrderList.Location = new System.Drawing.Point(31, 60);
            this.GV_OrderList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GV_OrderList.Name = "GV_OrderList";
            this.GV_OrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GV_OrderList.Size = new System.Drawing.Size(497, 330);
            this.GV_OrderList.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.BTN_NewOrder);
            this.groupBox1.Location = new System.Drawing.Point(101, 396);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(345, 73);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(187, 16);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN_NewOrder
            // 
            this.BTN_NewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NewOrder.Location = new System.Drawing.Point(58, 16);
            this.BTN_NewOrder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BTN_NewOrder.Name = "BTN_NewOrder";
            this.BTN_NewOrder.Size = new System.Drawing.Size(105, 41);
            this.BTN_NewOrder.TabIndex = 4;
            this.BTN_NewOrder.Text = "New Order";
            this.BTN_NewOrder.UseVisualStyleBackColor = true;
            this.BTN_NewOrder.Click += new System.EventHandler(this.BTN_NewOrder_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(560, 485);
            this.Controls.Add(this.LB_Orders);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GV_OrderList);
            this.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GV_OrderList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Orders;
        private System.Windows.Forms.DataGridView GV_OrderList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTN_NewOrder;
    }
}