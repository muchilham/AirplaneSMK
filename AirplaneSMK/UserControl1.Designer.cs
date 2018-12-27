namespace AirplaneSMK
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnDetail = new System.Windows.Forms.Button();
            this.lblplane = new System.Windows.Forms.Label();
            this.btnBooking = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDepartureArrival = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblDuration);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.btnDetail);
            this.groupBox1.Controls.Add(this.lblplane);
            this.groupBox1.Controls.Add(this.btnBooking);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblDepartureArrival);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(905, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID Schedule";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(231, 96);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(70, 20);
            this.lblDuration.TabIndex = 7;
            this.lblDuration.Text = "Duration";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(231, 66);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(215, 20);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Departure Date - Arrival Date";
            // 
            // btnDetail
            // 
            this.btnDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetail.BackColor = System.Drawing.Color.Gold;
            this.btnDetail.FlatAppearance.BorderSize = 0;
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.Location = new System.Drawing.Point(777, 66);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(107, 26);
            this.btnDetail.TabIndex = 5;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // lblplane
            // 
            this.lblplane.AutoSize = true;
            this.lblplane.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplane.Location = new System.Drawing.Point(28, 45);
            this.lblplane.Name = "lblplane";
            this.lblplane.Size = new System.Drawing.Size(114, 24);
            this.lblplane.TabIndex = 4;
            this.lblplane.Text = "Plane Name";
            // 
            // btnBooking
            // 
            this.btnBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBooking.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBooking.FlatAppearance.BorderSize = 0;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Location = new System.Drawing.Point(664, 66);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(107, 26);
            this.btnBooking.TabIndex = 3;
            this.btnBooking.Text = "Book Now!";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(728, 31);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(70, 25);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Harga";
            // 
            // lblDepartureArrival
            // 
            this.lblDepartureArrival.AutoSize = true;
            this.lblDepartureArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureArrival.Location = new System.Drawing.Point(231, 36);
            this.lblDepartureArrival.Name = "lblDepartureArrival";
            this.lblDepartureArrival.Size = new System.Drawing.Size(227, 20);
            this.lblDepartureArrival.TabIndex = 0;
            this.lblDepartureArrival.Text = "Departure Origin - Arrival Origin";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(911, 133);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Label lblDepartureArrival;
        public System.Windows.Forms.Button btnBooking;
        public System.Windows.Forms.Label lblplane;
        public System.Windows.Forms.Button btnDetail;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lblDuration;
    }
}
