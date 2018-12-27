namespace AirplaneSMK
{
    partial class DataSchedulingDetailFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblArrivaldate = new System.Windows.Forms.Label();
            this.btnBooking = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblplane = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTransit = new System.Windows.Forms.Label();
            this.lblDepartureArrival = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblArrivaldate);
            this.groupBox1.Controls.Add(this.btnBooking);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblplane);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblTransit);
            this.groupBox1.Controls.Add(this.lblDepartureArrival);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 212);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID Schedule";
            // 
            // lblArrivaldate
            // 
            this.lblArrivaldate.AutoSize = true;
            this.lblArrivaldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivaldate.Location = new System.Drawing.Point(22, 158);
            this.lblArrivaldate.Name = "lblArrivaldate";
            this.lblArrivaldate.Size = new System.Drawing.Size(91, 20);
            this.lblArrivaldate.TabIndex = 6;
            this.lblArrivaldate.Text = "Arrival Date";
            // 
            // btnBooking
            // 
            this.btnBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBooking.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBooking.FlatAppearance.BorderSize = 0;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Location = new System.Drawing.Point(625, 66);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(107, 26);
            this.btnBooking.TabIndex = 4;
            this.btnBooking.Text = "Book Now!";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(22, 96);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(120, 20);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Departure Date";
            // 
            // lblplane
            // 
            this.lblplane.AutoSize = true;
            this.lblplane.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplane.Location = new System.Drawing.Point(22, 47);
            this.lblplane.Name = "lblplane";
            this.lblplane.Size = new System.Drawing.Size(114, 24);
            this.lblplane.TabIndex = 4;
            this.lblplane.Text = "Plane Name";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(620, 31);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(70, 25);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Harga";
            // 
            // lblTransit
            // 
            this.lblTransit.AutoSize = true;
            this.lblTransit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransit.Location = new System.Drawing.Point(313, 66);
            this.lblTransit.Name = "lblTransit";
            this.lblTransit.Size = new System.Drawing.Size(52, 16);
            this.lblTransit.TabIndex = 1;
            this.lblTransit.Text = "Transit:";
            // 
            // lblDepartureArrival
            // 
            this.lblDepartureArrival.AutoSize = true;
            this.lblDepartureArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartureArrival.Location = new System.Drawing.Point(312, 35);
            this.lblDepartureArrival.Name = "lblDepartureArrival";
            this.lblDepartureArrival.Size = new System.Drawing.Size(227, 20);
            this.lblDepartureArrival.TabIndex = 0;
            this.lblDepartureArrival.Text = "Departure Origin - Arrival Origin";
            // 
            // DataSchedulingDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 216);
            this.Controls.Add(this.groupBox1);
            this.Name = "DataSchedulingDetailFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DataSchedulingDetailFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblplane;
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Label lblTransit;
        public System.Windows.Forms.Label lblDepartureArrival;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Button btnBooking;
        public System.Windows.Forms.Label lblArrivaldate;
    }
}