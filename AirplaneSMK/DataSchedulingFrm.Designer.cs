namespace AirplaneSMK
{
    partial class DataSchedulingFrm
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
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbIdschedule = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbArrivalorigin = new System.Windows.Forms.TextBox();
            this.btnArrival = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPlane = new System.Windows.Forms.Button();
            this.tbIdplane = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNameplane = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDeparturedate = new System.Windows.Forms.DateTimePicker();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeparture = new System.Windows.Forms.Button();
            this.tbDepartureorigin = new System.Windows.Forms.TextBox();
            this.tbDeparturename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbArrivalname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.eValidasi = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.nupTotalseat = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpArrivaldate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eValidasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTotalseat)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToAddRows = false;
            this.dgvSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedule.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Location = new System.Drawing.Point(315, 98);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.ReadOnly = true;
            this.dgvSchedule.Size = new System.Drawing.Size(459, 545);
            this.dgvSchedule.TabIndex = 0;
            this.dgvSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedule_CellContentClick);
            this.dgvSchedule.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedule_CellContentDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(699, 649);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbIdschedule
            // 
            this.tbIdschedule.Location = new System.Drawing.Point(104, 101);
            this.tbIdschedule.Name = "tbIdschedule";
            this.tbIdschedule.ReadOnly = true;
            this.tbIdschedule.Size = new System.Drawing.Size(180, 20);
            this.tbIdschedule.TabIndex = 2;
            this.tbIdschedule.TextChanged += new System.EventHandler(this.tbIdschedule_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(109, 609);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Schedule";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Flight Scheduling";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Arrival Origin";
            // 
            // tbArrivalorigin
            // 
            this.tbArrivalorigin.BackColor = System.Drawing.Color.White;
            this.tbArrivalorigin.Location = new System.Drawing.Point(104, 244);
            this.tbArrivalorigin.Name = "tbArrivalorigin";
            this.tbArrivalorigin.ReadOnly = true;
            this.tbArrivalorigin.Size = new System.Drawing.Size(137, 20);
            this.tbArrivalorigin.TabIndex = 18;
            // 
            // btnArrival
            // 
            this.btnArrival.Location = new System.Drawing.Point(247, 243);
            this.btnArrival.Name = "btnArrival";
            this.btnArrival.Size = new System.Drawing.Size(37, 23);
            this.btnArrival.TabIndex = 19;
            this.btnArrival.Text = "...";
            this.btnArrival.UseVisualStyleBackColor = true;
            this.btnArrival.Click += new System.EventHandler(this.btnArrival_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(190, 609);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPlane
            // 
            this.btnPlane.Location = new System.Drawing.Point(247, 126);
            this.btnPlane.Name = "btnPlane";
            this.btnPlane.Size = new System.Drawing.Size(37, 23);
            this.btnPlane.TabIndex = 23;
            this.btnPlane.Text = "...";
            this.btnPlane.UseVisualStyleBackColor = true;
            this.btnPlane.Click += new System.EventHandler(this.btnPlane_Click);
            // 
            // tbIdplane
            // 
            this.tbIdplane.BackColor = System.Drawing.Color.White;
            this.tbIdplane.Location = new System.Drawing.Point(104, 127);
            this.tbIdplane.Name = "tbIdplane";
            this.tbIdplane.ReadOnly = true;
            this.tbIdplane.Size = new System.Drawing.Size(137, 20);
            this.tbIdplane.TabIndex = 22;
            this.tbIdplane.TextChanged += new System.EventHandler(this.tbIdplane_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "ID Plane";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Departure Origin";
            // 
            // tbNameplane
            // 
            this.tbNameplane.Enabled = false;
            this.tbNameplane.Location = new System.Drawing.Point(104, 155);
            this.tbNameplane.Name = "tbNameplane";
            this.tbNameplane.ReadOnly = true;
            this.tbNameplane.Size = new System.Drawing.Size(180, 20);
            this.tbNameplane.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Name Plane";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 590);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Price";
            // 
            // dtpDeparturedate
            // 
            this.dtpDeparturedate.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpDeparturedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeparturedate.Location = new System.Drawing.Point(109, 531);
            this.dtpDeparturedate.Name = "dtpDeparturedate";
            this.dtpDeparturedate.Size = new System.Drawing.Size(180, 20);
            this.dtpDeparturedate.TabIndex = 32;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(109, 583);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(180, 20);
            this.tbPrice.TabIndex = 33;
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 537);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Departure Date";
            // 
            // btnDeparture
            // 
            this.btnDeparture.Location = new System.Drawing.Point(247, 186);
            this.btnDeparture.Name = "btnDeparture";
            this.btnDeparture.Size = new System.Drawing.Size(37, 23);
            this.btnDeparture.TabIndex = 36;
            this.btnDeparture.Text = "...";
            this.btnDeparture.UseVisualStyleBackColor = true;
            this.btnDeparture.Click += new System.EventHandler(this.btnDeparture_Click);
            // 
            // tbDepartureorigin
            // 
            this.tbDepartureorigin.BackColor = System.Drawing.Color.White;
            this.tbDepartureorigin.Location = new System.Drawing.Point(104, 187);
            this.tbDepartureorigin.Name = "tbDepartureorigin";
            this.tbDepartureorigin.ReadOnly = true;
            this.tbDepartureorigin.Size = new System.Drawing.Size(137, 20);
            this.tbDepartureorigin.TabIndex = 35;
            // 
            // tbDeparturename
            // 
            this.tbDeparturename.Enabled = false;
            this.tbDeparturename.Location = new System.Drawing.Point(104, 213);
            this.tbDeparturename.Name = "tbDeparturename";
            this.tbDeparturename.ReadOnly = true;
            this.tbDeparturename.Size = new System.Drawing.Size(180, 20);
            this.tbDeparturename.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Name Airport";
            // 
            // tbArrivalname
            // 
            this.tbArrivalname.Enabled = false;
            this.tbArrivalname.Location = new System.Drawing.Point(104, 270);
            this.tbArrivalname.Name = "tbArrivalname";
            this.tbArrivalname.ReadOnly = true;
            this.tbArrivalname.Size = new System.Drawing.Size(180, 20);
            this.tbArrivalname.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Name Airport";
            // 
            // eValidasi
            // 
            this.eValidasi.ContainerControl = this;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(618, 649);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 509);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "Total Seat";
            // 
            // nupTotalseat
            // 
            this.nupTotalseat.Enabled = false;
            this.nupTotalseat.Location = new System.Drawing.Point(109, 505);
            this.nupTotalseat.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nupTotalseat.Name = "nupTotalseat";
            this.nupTotalseat.Size = new System.Drawing.Size(180, 20);
            this.nupTotalseat.TabIndex = 44;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(15, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 201);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transit Point (Optional)";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(263, 182);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 563);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 68;
            this.label11.Text = "Arrival Date";
            // 
            // dtpArrivaldate
            // 
            this.dtpArrivaldate.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpArrivaldate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrivaldate.Location = new System.Drawing.Point(109, 557);
            this.dtpArrivaldate.Name = "dtpArrivaldate";
            this.dtpArrivaldate.Size = new System.Drawing.Size(180, 20);
            this.dtpArrivaldate.TabIndex = 67;
            // 
            // DataSchedulingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 677);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpArrivaldate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.nupTotalseat);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbArrivalname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbDeparturename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeparture);
            this.Controls.Add(this.tbDepartureorigin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.dtpDeparturedate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbNameplane);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPlane);
            this.Controls.Add(this.tbIdplane);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnArrival);
            this.Controls.Add(this.tbArrivalorigin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbIdschedule);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvSchedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataSchedulingFrm";
            this.Text = "DataCustomerFrm";
            this.Load += new System.EventHandler(this.DataSchedulingFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eValidasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTotalseat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbIdschedule;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbArrivalorigin;
        private System.Windows.Forms.Button btnArrival;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPlane;
        private System.Windows.Forms.TextBox tbIdplane;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNameplane;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDeparturedate;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDeparture;
        private System.Windows.Forms.TextBox tbDepartureorigin;
        private System.Windows.Forms.TextBox tbDeparturename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbArrivalname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider eValidasi;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown nupTotalseat;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpArrivaldate;
    }
}