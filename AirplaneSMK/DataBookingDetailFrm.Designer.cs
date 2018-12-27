namespace AirplaneSMK
{
    partial class DataBookingDetailFrm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.eValidasi = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBookingdate = new System.Windows.Forms.TextBox();
            this.tbIdschedule = new System.Windows.Forms.TextBox();
            this.tbIdbooking = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.dgvBookingdetail = new System.Windows.Forms.DataGridView();
            this.IDCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDConsumption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consumption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceConsumption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoSeat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eValidasi)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingdetail)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(200, 20, 200, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(979, 271);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // eValidasi
            // 
            this.eValidasi.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.dgvBookingdetail);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 343);
            this.panel1.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbBookingdate);
            this.groupBox1.Controls.Add(this.tbIdschedule);
            this.groupBox1.Controls.Add(this.tbIdbooking);
            this.groupBox1.Location = new System.Drawing.Point(37, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(908, 78);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking Header";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Booking Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Schedule";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Booking";
            // 
            // tbBookingdate
            // 
            this.tbBookingdate.Location = new System.Drawing.Point(383, 40);
            this.tbBookingdate.Name = "tbBookingdate";
            this.tbBookingdate.ReadOnly = true;
            this.tbBookingdate.Size = new System.Drawing.Size(166, 20);
            this.tbBookingdate.TabIndex = 2;
            // 
            // tbIdschedule
            // 
            this.tbIdschedule.Location = new System.Drawing.Point(202, 40);
            this.tbIdschedule.Name = "tbIdschedule";
            this.tbIdschedule.ReadOnly = true;
            this.tbIdschedule.Size = new System.Drawing.Size(166, 20);
            this.tbIdschedule.TabIndex = 1;
            // 
            // tbIdbooking
            // 
            this.tbIdbooking.Location = new System.Drawing.Point(21, 40);
            this.tbIdbooking.Name = "tbIdbooking";
            this.tbIdbooking.ReadOnly = true;
            this.tbIdbooking.Size = new System.Drawing.Size(166, 20);
            this.tbIdbooking.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(50, 292);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(149, 25);
            this.lblTotal.TabIndex = 28;
            this.lblTotal.Text = "Total Harga :";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(818, 287);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(124, 40);
            this.btnPay.TabIndex = 27;
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // dgvBookingdetail
            // 
            this.dgvBookingdetail.AllowUserToAddRows = false;
            this.dgvBookingdetail.AllowUserToDeleteRows = false;
            this.dgvBookingdetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookingdetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBookingdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingdetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCustomer,
            this.NameCustomer,
            this.IDConsumption,
            this.Consumption,
            this.Quantity,
            this.PriceConsumption,
            this.NoSeat});
            this.dgvBookingdetail.Location = new System.Drawing.Point(37, 90);
            this.dgvBookingdetail.Name = "dgvBookingdetail";
            this.dgvBookingdetail.ReadOnly = true;
            this.dgvBookingdetail.Size = new System.Drawing.Size(905, 150);
            this.dgvBookingdetail.TabIndex = 26;
            // 
            // IDCustomer
            // 
            this.IDCustomer.HeaderText = "ID Customer";
            this.IDCustomer.Name = "IDCustomer";
            this.IDCustomer.ReadOnly = true;
            // 
            // NameCustomer
            // 
            this.NameCustomer.HeaderText = "Customer Name";
            this.NameCustomer.Name = "NameCustomer";
            this.NameCustomer.ReadOnly = true;
            // 
            // IDConsumption
            // 
            this.IDConsumption.HeaderText = "ID Consumption";
            this.IDConsumption.Name = "IDConsumption";
            this.IDConsumption.ReadOnly = true;
            // 
            // Consumption
            // 
            this.Consumption.HeaderText = "Consumption";
            this.Consumption.Name = "Consumption";
            this.Consumption.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // PriceConsumption
            // 
            this.PriceConsumption.HeaderText = "Price Consumption";
            this.PriceConsumption.Name = "PriceConsumption";
            this.PriceConsumption.ReadOnly = true;
            // 
            // NoSeat
            // 
            this.NoSeat.HeaderText = "No Seat";
            this.NoSeat.Name = "NoSeat";
            this.NoSeat.ReadOnly = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(37, 246);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(86, 23);
            this.btnRemove.TabIndex = 29;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // DataBookingDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 614);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataBookingDetailFrm";
            this.Text = "Booking Detail";
            this.Load += new System.EventHandler(this.ChooseSeatFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eValidasi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingdetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ErrorProvider eValidasi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBookingdate;
        private System.Windows.Forms.TextBox tbIdschedule;
        private System.Windows.Forms.TextBox tbIdbooking;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPay;
        public System.Windows.Forms.DataGridView dgvBookingdetail;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDConsumption;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consumption;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceConsumption;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoSeat;
    }
}