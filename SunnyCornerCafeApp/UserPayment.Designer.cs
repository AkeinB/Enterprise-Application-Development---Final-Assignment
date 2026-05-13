namespace SunnyCornerCafeApp
{
    partial class UserPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPayment));
            this.BT_Pay = new System.Windows.Forms.Button();
            this.RB_Cash = new System.Windows.Forms.RadioButton();
            this.RB_Card = new System.Windows.Forms.RadioButton();
            this.GB_Payment = new System.Windows.Forms.GroupBox();
            this.MTB_CardNumber = new System.Windows.Forms.MaskedTextBox();
            this.MTB_CVV = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TB_MAddress = new System.Windows.Forms.TextBox();
            this.TB_CName = new System.Windows.Forms.TextBox();
            this.LB_CVV = new System.Windows.Forms.Label();
            this.LB_Address = new System.Windows.Forms.Label();
            this.LB_Expiry = new System.Windows.Forms.Label();
            this.LB_CardNumber = new System.Windows.Forms.Label();
            this.LB_Name = new System.Windows.Forms.Label();
            this.LB_Payment = new System.Windows.Forms.Label();
            this.LB_Cash = new System.Windows.Forms.Label();
            this.GB_Cash = new System.Windows.Forms.GroupBox();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.GB_Payment.SuspendLayout();
            this.GB_Cash.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_Pay
            // 
            this.BT_Pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BT_Pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Pay.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Pay.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BT_Pay.Location = new System.Drawing.Point(89, 295);
            this.BT_Pay.Margin = new System.Windows.Forms.Padding(4);
            this.BT_Pay.Name = "BT_Pay";
            this.BT_Pay.Size = new System.Drawing.Size(123, 49);
            this.BT_Pay.TabIndex = 0;
            this.BT_Pay.Text = "Pay";
            this.BT_Pay.UseVisualStyleBackColor = false;
            this.BT_Pay.Click += new System.EventHandler(this.BT_Pay_Click);
            // 
            // RB_Cash
            // 
            this.RB_Cash.AutoSize = true;
            this.RB_Cash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RB_Cash.Location = new System.Drawing.Point(22, 85);
            this.RB_Cash.Margin = new System.Windows.Forms.Padding(4);
            this.RB_Cash.Name = "RB_Cash";
            this.RB_Cash.Size = new System.Drawing.Size(52, 20);
            this.RB_Cash.TabIndex = 1;
            this.RB_Cash.TabStop = true;
            this.RB_Cash.Text = "Cash";
            this.RB_Cash.UseVisualStyleBackColor = true;
            this.RB_Cash.CheckedChanged += new System.EventHandler(this.RB_Cash_CheckedChanged);
            // 
            // RB_Card
            // 
            this.RB_Card.AutoSize = true;
            this.RB_Card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RB_Card.Location = new System.Drawing.Point(22, 126);
            this.RB_Card.Margin = new System.Windows.Forms.Padding(4);
            this.RB_Card.Name = "RB_Card";
            this.RB_Card.Size = new System.Drawing.Size(50, 20);
            this.RB_Card.TabIndex = 2;
            this.RB_Card.TabStop = true;
            this.RB_Card.Text = "Card";
            this.RB_Card.UseVisualStyleBackColor = true;
            this.RB_Card.CheckedChanged += new System.EventHandler(this.RB_Card_CheckedChanged);
            // 
            // GB_Payment
            // 
            this.GB_Payment.Controls.Add(this.MTB_CardNumber);
            this.GB_Payment.Controls.Add(this.MTB_CVV);
            this.GB_Payment.Controls.Add(this.dateTimePicker1);
            this.GB_Payment.Controls.Add(this.TB_MAddress);
            this.GB_Payment.Controls.Add(this.BT_Pay);
            this.GB_Payment.Controls.Add(this.TB_CName);
            this.GB_Payment.Controls.Add(this.LB_CVV);
            this.GB_Payment.Controls.Add(this.LB_Address);
            this.GB_Payment.Controls.Add(this.LB_Expiry);
            this.GB_Payment.Controls.Add(this.LB_CardNumber);
            this.GB_Payment.Controls.Add(this.LB_Name);
            this.GB_Payment.Location = new System.Drawing.Point(33, 166);
            this.GB_Payment.Margin = new System.Windows.Forms.Padding(4);
            this.GB_Payment.Name = "GB_Payment";
            this.GB_Payment.Padding = new System.Windows.Forms.Padding(4);
            this.GB_Payment.Size = new System.Drawing.Size(332, 380);
            this.GB_Payment.TabIndex = 3;
            this.GB_Payment.TabStop = false;
            this.GB_Payment.Text = "INFO";
            // 
            // MTB_CardNumber
            // 
            this.MTB_CardNumber.Location = new System.Drawing.Point(124, 81);
            this.MTB_CardNumber.Margin = new System.Windows.Forms.Padding(4);
            this.MTB_CardNumber.Mask = "0000 0000 0000 0000";
            this.MTB_CardNumber.Name = "MTB_CardNumber";
            this.MTB_CardNumber.Size = new System.Drawing.Size(201, 27);
            this.MTB_CardNumber.TabIndex = 12;
            // 
            // MTB_CVV
            // 
            this.MTB_CVV.Location = new System.Drawing.Point(124, 210);
            this.MTB_CVV.Margin = new System.Windows.Forms.Padding(4);
            this.MTB_CVV.Mask = "000";
            this.MTB_CVV.Name = "MTB_CVV";
            this.MTB_CVV.Size = new System.Drawing.Size(55, 27);
            this.MTB_CVV.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 123);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 27);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // TB_MAddress
            // 
            this.TB_MAddress.AcceptsTab = true;
            this.TB_MAddress.Location = new System.Drawing.Point(124, 167);
            this.TB_MAddress.Margin = new System.Windows.Forms.Padding(4);
            this.TB_MAddress.Name = "TB_MAddress";
            this.TB_MAddress.Size = new System.Drawing.Size(201, 27);
            this.TB_MAddress.TabIndex = 7;
            // 
            // TB_CName
            // 
            this.TB_CName.AcceptsTab = true;
            this.TB_CName.Location = new System.Drawing.Point(124, 37);
            this.TB_CName.Margin = new System.Windows.Forms.Padding(4);
            this.TB_CName.Name = "TB_CName";
            this.TB_CName.Size = new System.Drawing.Size(201, 27);
            this.TB_CName.TabIndex = 6;
            // 
            // LB_CVV
            // 
            this.LB_CVV.AutoSize = true;
            this.LB_CVV.Location = new System.Drawing.Point(21, 214);
            this.LB_CVV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_CVV.Name = "LB_CVV";
            this.LB_CVV.Size = new System.Drawing.Size(31, 16);
            this.LB_CVV.TabIndex = 4;
            this.LB_CVV.Text = "CVV";
            // 
            // LB_Address
            // 
            this.LB_Address.AutoSize = true;
            this.LB_Address.Location = new System.Drawing.Point(21, 167);
            this.LB_Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Address.Name = "LB_Address";
            this.LB_Address.Size = new System.Drawing.Size(96, 16);
            this.LB_Address.TabIndex = 3;
            this.LB_Address.Text = "Mailing Address";
            // 
            // LB_Expiry
            // 
            this.LB_Expiry.AutoSize = true;
            this.LB_Expiry.Location = new System.Drawing.Point(21, 123);
            this.LB_Expiry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Expiry.Name = "LB_Expiry";
            this.LB_Expiry.Size = new System.Drawing.Size(70, 16);
            this.LB_Expiry.TabIndex = 2;
            this.LB_Expiry.Text = "Expiry Date";
            // 
            // LB_CardNumber
            // 
            this.LB_CardNumber.AutoSize = true;
            this.LB_CardNumber.Location = new System.Drawing.Point(21, 85);
            this.LB_CardNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_CardNumber.Name = "LB_CardNumber";
            this.LB_CardNumber.Size = new System.Drawing.Size(80, 16);
            this.LB_CardNumber.TabIndex = 1;
            this.LB_CardNumber.Text = "Card Number";
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.Location = new System.Drawing.Point(21, 46);
            this.LB_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(86, 16);
            this.LB_Name.TabIndex = 0;
            this.LB_Name.Text = "Name on Card";
            // 
            // LB_Payment
            // 
            this.LB_Payment.AutoSize = true;
            this.LB_Payment.Font = new System.Drawing.Font("Yu Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Payment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LB_Payment.Location = new System.Drawing.Point(114, 9);
            this.LB_Payment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Payment.Name = "LB_Payment";
            this.LB_Payment.Size = new System.Drawing.Size(155, 42);
            this.LB_Payment.TabIndex = 4;
            this.LB_Payment.Text = "Pay Now";
            // 
            // LB_Cash
            // 
            this.LB_Cash.AutoSize = true;
            this.LB_Cash.Location = new System.Drawing.Point(6, 14);
            this.LB_Cash.Name = "LB_Cash";
            this.LB_Cash.Size = new System.Drawing.Size(90, 16);
            this.LB_Cash.TabIndex = 5;
            this.LB_Cash.Text = "Pay on Pick Up";
            this.LB_Cash.Click += new System.EventHandler(this.label1_Click);
            // 
            // GB_Cash
            // 
            this.GB_Cash.Controls.Add(this.BTN_Close);
            this.GB_Cash.Controls.Add(this.LB_Cash);
            this.GB_Cash.Location = new System.Drawing.Point(128, 70);
            this.GB_Cash.Name = "GB_Cash";
            this.GB_Cash.Size = new System.Drawing.Size(214, 44);
            this.GB_Cash.TabIndex = 6;
            this.GB_Cash.TabStop = false;
            // 
            // BTN_Close
            // 
            this.BTN_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Close.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Close.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.BTN_Close.Location = new System.Drawing.Point(125, 12);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(75, 30);
            this.BTN_Close.TabIndex = 6;
            this.BTN_Close.Text = "Close";
            this.BTN_Close.UseVisualStyleBackColor = false;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // UserPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(400, 566);
            this.Controls.Add(this.GB_Cash);
            this.Controls.Add(this.LB_Payment);
            this.Controls.Add(this.GB_Payment);
            this.Controls.Add(this.RB_Card);
            this.Controls.Add(this.RB_Cash);
            this.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.GB_Payment.ResumeLayout(false);
            this.GB_Payment.PerformLayout();
            this.GB_Cash.ResumeLayout(false);
            this.GB_Cash.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Pay;
        private System.Windows.Forms.RadioButton RB_Cash;
        private System.Windows.Forms.RadioButton RB_Card;
        private System.Windows.Forms.GroupBox GB_Payment;
        private System.Windows.Forms.Label LB_Expiry;
        private System.Windows.Forms.Label LB_CardNumber;
        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.Label LB_CVV;
        private System.Windows.Forms.Label LB_Address;
        private System.Windows.Forms.TextBox TB_MAddress;
        private System.Windows.Forms.TextBox TB_CName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox MTB_CVV;
        private System.Windows.Forms.MaskedTextBox MTB_CardNumber;
        private System.Windows.Forms.Label LB_Payment;
        private System.Windows.Forms.Label LB_Cash;
        private System.Windows.Forms.GroupBox GB_Cash;
        private System.Windows.Forms.Button BTN_Close;
    }
}