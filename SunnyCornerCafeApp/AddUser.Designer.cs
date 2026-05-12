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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.BTN_Submit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LB_UserType = new System.Windows.Forms.Label();
            this.LB_UserName = new System.Windows.Forms.Label();
            this.TB_UserName = new System.Windows.Forms.TextBox();
            this.CB_UserType = new System.Windows.Forms.ComboBox();
            this.LB_AddUser = new System.Windows.Forms.Label();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Submit
            // 
            this.BTN_Submit.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BTN_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Submit.Location = new System.Drawing.Point(24, 307);
            this.BTN_Submit.Name = "BTN_Submit";
            this.BTN_Submit.Size = new System.Drawing.Size(104, 46);
            this.BTN_Submit.TabIndex = 0;
            this.BTN_Submit.Text = "Submit";
            this.BTN_Submit.UseVisualStyleBackColor = false;
            this.BTN_Submit.Click += new System.EventHandler(this.BTN_Submit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LB_UserType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LB_UserName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TB_UserName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CB_UserType, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 154);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(234, 95);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LB_UserType
            // 
            this.LB_UserType.AutoSize = true;
            this.LB_UserType.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_UserType.Location = new System.Drawing.Point(3, 47);
            this.LB_UserType.Name = "LB_UserType";
            this.LB_UserType.Size = new System.Drawing.Size(69, 17);
            this.LB_UserType.TabIndex = 6;
            this.LB_UserType.Text = "User Type";
            // 
            // LB_UserName
            // 
            this.LB_UserName.AutoSize = true;
            this.LB_UserName.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_UserName.Location = new System.Drawing.Point(3, 0);
            this.LB_UserName.Name = "LB_UserName";
            this.LB_UserName.Size = new System.Drawing.Size(76, 17);
            this.LB_UserName.TabIndex = 3;
            this.LB_UserName.Text = "User Name";
            // 
            // TB_UserName
            // 
            this.TB_UserName.Location = new System.Drawing.Point(120, 3);
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(104, 25);
            this.TB_UserName.TabIndex = 4;
            // 
            // CB_UserType
            // 
            this.CB_UserType.FormattingEnabled = true;
            this.CB_UserType.Location = new System.Drawing.Point(120, 50);
            this.CB_UserType.Name = "CB_UserType";
            this.CB_UserType.Size = new System.Drawing.Size(104, 22);
            this.CB_UserType.TabIndex = 5;
            // 
            // LB_AddUser
            // 
            this.LB_AddUser.AutoSize = true;
            this.LB_AddUser.Font = new System.Drawing.Font("Yu Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_AddUser.Location = new System.Drawing.Point(35, 66);
            this.LB_AddUser.Name = "LB_AddUser";
            this.LB_AddUser.Size = new System.Drawing.Size(192, 51);
            this.LB_AddUser.TabIndex = 2;
            this.LB_AddUser.Text = "Add User";
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BTN_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Cancel.Location = new System.Drawing.Point(144, 307);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(104, 46);
            this.BTN_Cancel.TabIndex = 3;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = false;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(270, 397);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.LB_AddUser);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.BTN_Submit);
            this.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Submit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LB_UserType;
        private System.Windows.Forms.Label LB_UserName;
        private System.Windows.Forms.TextBox TB_UserName;
        private System.Windows.Forms.ComboBox CB_UserType;
        private System.Windows.Forms.Label LB_AddUser;
        private System.Windows.Forms.Button BTN_Cancel;
    }
}