namespace SunnyCornerCafeApp
{
    partial class BookTable
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
            this.LB_Date = new System.Windows.Forms.Label();
            this.LB_NumofPerson = new System.Windows.Forms.Label();
            this.LB_Area = new System.Windows.Forms.Label();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.TB_NumofPersons = new System.Windows.Forms.TrackBar();
            this.CL_Area = new System.Windows.Forms.CheckedListBox();
            this.LB_Reservation = new System.Windows.Forms.Label();
            this.BT_BookNow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TB_NumofPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Date
            // 
            this.LB_Date.AutoSize = true;
            this.LB_Date.Location = new System.Drawing.Point(153, 97);
            this.LB_Date.Name = "LB_Date";
            this.LB_Date.Size = new System.Drawing.Size(30, 13);
            this.LB_Date.TabIndex = 0;
            this.LB_Date.Text = "Date";
            // 
            // LB_NumofPerson
            // 
            this.LB_NumofPerson.AutoSize = true;
            this.LB_NumofPerson.Location = new System.Drawing.Point(118, 286);
            this.LB_NumofPerson.Name = "LB_NumofPerson";
            this.LB_NumofPerson.Size = new System.Drawing.Size(97, 13);
            this.LB_NumofPerson.TabIndex = 2;
            this.LB_NumofPerson.Text = "Number of Persons";
            // 
            // LB_Area
            // 
            this.LB_Area.AutoSize = true;
            this.LB_Area.Location = new System.Drawing.Point(154, 191);
            this.LB_Area.Name = "LB_Area";
            this.LB_Area.Size = new System.Drawing.Size(29, 13);
            this.LB_Area.TabIndex = 3;
            this.LB_Area.Text = "Area";
            // 
            // DTP_Date
            // 
            this.DTP_Date.Location = new System.Drawing.Point(66, 126);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(201, 20);
            this.DTP_Date.TabIndex = 4;
            // 
            // TB_NumofPersons
            // 
            this.TB_NumofPersons.Location = new System.Drawing.Point(66, 319);
            this.TB_NumofPersons.Maximum = 15;
            this.TB_NumofPersons.Name = "TB_NumofPersons";
            this.TB_NumofPersons.Size = new System.Drawing.Size(201, 45);
            this.TB_NumofPersons.TabIndex = 6;
            // 
            // CL_Area
            // 
            this.CL_Area.FormattingEnabled = true;
            this.CL_Area.Items.AddRange(new object[] {
            "Inside",
            "Pergola "});
            this.CL_Area.Location = new System.Drawing.Point(66, 207);
            this.CL_Area.Name = "CL_Area";
            this.CL_Area.Size = new System.Drawing.Size(201, 34);
            this.CL_Area.TabIndex = 8;
            // 
            // LB_Reservation
            // 
            this.LB_Reservation.AutoSize = true;
            this.LB_Reservation.Font = new System.Drawing.Font("a Antara Distance", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Reservation.Location = new System.Drawing.Point(78, 22);
            this.LB_Reservation.Name = "LB_Reservation";
            this.LB_Reservation.Size = new System.Drawing.Size(189, 34);
            this.LB_Reservation.TabIndex = 9;
            this.LB_Reservation.Text = "Make A Reservation";
            // 
            // BT_BookNow
            // 
            this.BT_BookNow.Location = new System.Drawing.Point(105, 409);
            this.BT_BookNow.Name = "BT_BookNow";
            this.BT_BookNow.Size = new System.Drawing.Size(131, 46);
            this.BT_BookNow.TabIndex = 10;
            this.BT_BookNow.Text = "Book Now";
            this.BT_BookNow.UseVisualStyleBackColor = true;
            this.BT_BookNow.Click += new System.EventHandler(this.BT_BookNow_Click);
            // 
            // BookTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 485);
            this.Controls.Add(this.BT_BookNow);
            this.Controls.Add(this.LB_Reservation);
            this.Controls.Add(this.CL_Area);
            this.Controls.Add(this.TB_NumofPersons);
            this.Controls.Add(this.DTP_Date);
            this.Controls.Add(this.LB_Area);
            this.Controls.Add(this.LB_NumofPerson);
            this.Controls.Add(this.LB_Date);
            this.Name = "BookTable";
            this.Text = "Book Table";
            ((System.ComponentModel.ISupportInitialize)(this.TB_NumofPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Date;
        private System.Windows.Forms.Label LB_NumofPerson;
        private System.Windows.Forms.Label LB_Area;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.TrackBar TB_NumofPersons;
        private System.Windows.Forms.CheckedListBox CL_Area;
        private System.Windows.Forms.Label LB_Reservation;
        private System.Windows.Forms.Button BT_BookNow;
    }
}