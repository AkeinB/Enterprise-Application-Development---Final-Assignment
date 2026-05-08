namespace SunnyCornerCafeApp
{
    partial class AddUser
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
            this.LB_Default = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LB_UserType = new System.Windows.Forms.Label();
            this.LB_UserName = new System.Windows.Forms.Label();
            this.CB_UserType = new System.Windows.Forms.ComboBox();
            this.TB_UserName = new System.Windows.Forms.TextBox();
            this.BTN_Submit = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.GB_AddUser = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.GB_AddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Default
            // 
            this.LB_Default.AutoSize = true;
            this.LB_Default.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Default.Location = new System.Drawing.Point(107, 27);
            this.LB_Default.Name = "LB_Default";
            this.LB_Default.Size = new System.Drawing.Size(146, 46);
            this.LB_Default.TabIndex = 0;
            this.LB_Default.Text = "Default";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LB_UserType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LB_UserName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CB_UserType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TB_UserName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(36, 96);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(282, 175);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LB_UserType
            // 
            this.LB_UserType.AutoSize = true;
            this.LB_UserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_UserType.Location = new System.Drawing.Point(3, 87);
            this.LB_UserType.Name = "LB_UserType";
            this.LB_UserType.Size = new System.Drawing.Size(69, 17);
            this.LB_UserType.TabIndex = 6;
            this.LB_UserType.Text = "User type";
            // 
            // LB_UserName
            // 
            this.LB_UserName.AutoSize = true;
            this.LB_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_UserName.Location = new System.Drawing.Point(3, 0);
            this.LB_UserName.Name = "LB_UserName";
            this.LB_UserName.Size = new System.Drawing.Size(79, 17);
            this.LB_UserName.TabIndex = 4;
            this.LB_UserName.Text = "User Name";
            // 
            // CB_UserType
            // 
            this.CB_UserType.FormattingEnabled = true;
            this.CB_UserType.Location = new System.Drawing.Point(144, 90);
            this.CB_UserType.Name = "CB_UserType";
            this.CB_UserType.Size = new System.Drawing.Size(123, 21);
            this.CB_UserType.TabIndex = 7;
            // 
            // TB_UserName
            // 
            this.TB_UserName.Location = new System.Drawing.Point(144, 3);
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(123, 20);
            this.TB_UserName.TabIndex = 5;
            // 
            // BTN_Submit
            // 
            this.BTN_Submit.Location = new System.Drawing.Point(52, 308);
            this.BTN_Submit.Name = "BTN_Submit";
            this.BTN_Submit.Size = new System.Drawing.Size(110, 43);
            this.BTN_Submit.TabIndex = 2;
            this.BTN_Submit.Text = "Submit";
            this.BTN_Submit.UseVisualStyleBackColor = true;
            this.BTN_Submit.Click += new System.EventHandler(this.BTN_Submit_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(194, 308);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(109, 43);
            this.BTN_Cancel.TabIndex = 3;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // GB_AddUser
            // 
            this.GB_AddUser.Controls.Add(this.BTN_Cancel);
            this.GB_AddUser.Controls.Add(this.BTN_Submit);
            this.GB_AddUser.Controls.Add(this.tableLayoutPanel1);
            this.GB_AddUser.Controls.Add(this.LB_Default);
            this.GB_AddUser.Location = new System.Drawing.Point(12, 12);
            this.GB_AddUser.Name = "GB_AddUser";
            this.GB_AddUser.Size = new System.Drawing.Size(338, 426);
            this.GB_AddUser.TabIndex = 0;
            this.GB_AddUser.TabStop = false;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 450);
            this.Controls.Add(this.GB_AddUser);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.GB_AddUser.ResumeLayout(false);
            this.GB_AddUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LB_Default;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LB_UserType;
        private System.Windows.Forms.Label LB_UserName;
        private System.Windows.Forms.ComboBox CB_UserType;
        private System.Windows.Forms.TextBox TB_UserName;
        private System.Windows.Forms.Button BTN_Submit;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.GroupBox GB_AddUser;
    }
}