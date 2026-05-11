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
            this.GB_Payment.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_Pay
            // 
            this.BT_Pay.Location = new System.Drawing.Point(106, 257);
            this.BT_Pay.Name = "BT_Pay";
            this.BT_Pay.Size = new System.Drawing.Size(75, 23);
            this.BT_Pay.TabIndex = 0;
            this.BT_Pay.Text = "Pay";
            this.BT_Pay.UseVisualStyleBackColor = true;
            this.BT_Pay.Click += new System.EventHandler(this.BT_Pay_Click);
            // 
            // RB_Cash
            // 
            this.RB_Cash.AutoSize = true;
            this.RB_Cash.Location = new System.Drawing.Point(28, 56);
            this.RB_Cash.Name = "RB_Cash";
            this.RB_Cash.Size = new System.Drawing.Size(49, 17);
            this.RB_Cash.TabIndex = 1;
            this.RB_Cash.TabStop = true;
            this.RB_Cash.Text = "Cash";
            this.RB_Cash.UseVisualStyleBackColor = true;
            this.RB_Cash.CheckedChanged += new System.EventHandler(this.RB_Cash_CheckedChanged);
            // 
            // RB_Card
            // 
            this.RB_Card.AutoSize = true;
            this.RB_Card.Location = new System.Drawing.Point(28, 103);
            this.RB_Card.Name = "RB_Card";
            this.RB_Card.Size = new System.Drawing.Size(47, 17);
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
            this.GB_Payment.Location = new System.Drawing.Point(38, 136);
            this.GB_Payment.Name = "GB_Payment";
            this.GB_Payment.Size = new System.Drawing.Size(285, 309);
            this.GB_Payment.TabIndex = 3;
            this.GB_Payment.TabStop = false;
            this.GB_Payment.Text = "INFO";
            // 
            // MTB_CardNumber
            // 
            this.MTB_CardNumber.Location = new System.Drawing.Point(106, 66);
            this.MTB_CardNumber.Mask = "0000 0000 0000 0000";
            this.MTB_CardNumber.Name = "MTB_CardNumber";
            this.MTB_CardNumber.Size = new System.Drawing.Size(173, 20);
            this.MTB_CardNumber.TabIndex = 12;
            // 
            // MTB_CVV
            // 
            this.MTB_CVV.Location = new System.Drawing.Point(106, 171);
            this.MTB_CVV.Mask = "000";
            this.MTB_CVV.Name = "MTB_CVV";
            this.MTB_CVV.Size = new System.Drawing.Size(48, 20);
            this.MTB_CVV.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // TB_MAddress
            // 
            this.TB_MAddress.AcceptsTab = true;
            this.TB_MAddress.Location = new System.Drawing.Point(106, 136);
            this.TB_MAddress.Name = "TB_MAddress";
            this.TB_MAddress.Size = new System.Drawing.Size(173, 20);
            this.TB_MAddress.TabIndex = 7;
            // 
            // TB_CName
            // 
            this.TB_CName.AcceptsTab = true;
            this.TB_CName.Location = new System.Drawing.Point(106, 30);
            this.TB_CName.Name = "TB_CName";
            this.TB_CName.Size = new System.Drawing.Size(173, 20);
            this.TB_CName.TabIndex = 6;
            // 
            // LB_CVV
            // 
            this.LB_CVV.AutoSize = true;
            this.LB_CVV.Location = new System.Drawing.Point(18, 174);
            this.LB_CVV.Name = "LB_CVV";
            this.LB_CVV.Size = new System.Drawing.Size(28, 13);
            this.LB_CVV.TabIndex = 4;
            this.LB_CVV.Text = "CVV";
            // 
            // LB_Address
            // 
            this.LB_Address.AutoSize = true;
            this.LB_Address.Location = new System.Drawing.Point(18, 136);
            this.LB_Address.Name = "LB_Address";
            this.LB_Address.Size = new System.Drawing.Size(81, 13);
            this.LB_Address.TabIndex = 3;
            this.LB_Address.Text = "Mailing Address";
            // 
            // LB_Expiry
            // 
            this.LB_Expiry.AutoSize = true;
            this.LB_Expiry.Location = new System.Drawing.Point(18, 100);
            this.LB_Expiry.Name = "LB_Expiry";
            this.LB_Expiry.Size = new System.Drawing.Size(61, 13);
            this.LB_Expiry.TabIndex = 2;
            this.LB_Expiry.Text = "Expiry Date";
            // 
            // LB_CardNumber
            // 
            this.LB_CardNumber.AutoSize = true;
            this.LB_CardNumber.Location = new System.Drawing.Point(18, 69);
            this.LB_CardNumber.Name = "LB_CardNumber";
            this.LB_CardNumber.Size = new System.Drawing.Size(69, 13);
            this.LB_CardNumber.TabIndex = 1;
            this.LB_CardNumber.Text = "Card Number";
            // 
            // LB_Name
            // 
            this.LB_Name.AutoSize = true;
            this.LB_Name.Location = new System.Drawing.Point(18, 37);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(75, 13);
            this.LB_Name.TabIndex = 0;
            this.LB_Name.Text = "Name on Card";
            // 
            // LB_Payment
            // 
            this.LB_Payment.AutoSize = true;
            this.LB_Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Payment.Location = new System.Drawing.Point(123, 9);
            this.LB_Payment.Name = "LB_Payment";
            this.LB_Payment.Size = new System.Drawing.Size(131, 33);
            this.LB_Payment.TabIndex = 4;
            this.LB_Payment.Text = "Pay Now";
            // 
            // UserPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 474);
            this.Controls.Add(this.LB_Payment);
            this.Controls.Add(this.GB_Payment);
            this.Controls.Add(this.RB_Card);
            this.Controls.Add(this.RB_Cash);
            this.Name = "UserPayment";
            this.Text = "Payment";
            this.GB_Payment.ResumeLayout(false);
            this.GB_Payment.PerformLayout();
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
    }
}