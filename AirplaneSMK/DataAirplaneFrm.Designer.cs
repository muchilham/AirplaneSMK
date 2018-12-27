namespace AirplaneSMK
{
    partial class DataAirplaneFrm
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
            this.dgvAirplane = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbAirplane = new System.Windows.Forms.TextBox();
            this.tbNameplane = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nupdSeatplane = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbClassname = new System.Windows.Forms.TextBox();
            this.btnLookUp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.eValidasi = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirplane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdSeatplane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eValidasi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAirplane
            // 
            this.dgvAirplane.AllowUserToAddRows = false;
            this.dgvAirplane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAirplane.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAirplane.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAirplane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirplane.Location = new System.Drawing.Point(313, 98);
            this.dgvAirplane.Name = "dgvAirplane";
            this.dgvAirplane.ReadOnly = true;
            this.dgvAirplane.Size = new System.Drawing.Size(443, 275);
            this.dgvAirplane.TabIndex = 0;
            this.dgvAirplane.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAirplane_CellContentClick);
            this.dgvAirplane.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAirplane_CellContentDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(681, 379);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbAirplane
            // 
            this.tbAirplane.Location = new System.Drawing.Point(104, 101);
            this.tbAirplane.Name = "tbAirplane";
            this.tbAirplane.Size = new System.Drawing.Size(180, 20);
            this.tbAirplane.TabIndex = 2;
            this.tbAirplane.TextChanged += new System.EventHandler(this.tbAirplane_TextChanged);
            this.tbAirplane.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAirplane_KeyPress);
            // 
            // tbNameplane
            // 
            this.tbNameplane.Location = new System.Drawing.Point(104, 127);
            this.tbNameplane.Name = "tbNameplane";
            this.tbNameplane.Size = new System.Drawing.Size(180, 20);
            this.tbNameplane.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(104, 206);
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
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Plane";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Data Airplane";
            // 
            // nupdSeatplane
            // 
            this.nupdSeatplane.Location = new System.Drawing.Point(104, 153);
            this.nupdSeatplane.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupdSeatplane.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nupdSeatplane.Name = "nupdSeatplane";
            this.nupdSeatplane.Size = new System.Drawing.Size(180, 20);
            this.nupdSeatplane.TabIndex = 14;
            this.nupdSeatplane.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Seat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Class";
            // 
            // tbClassname
            // 
            this.tbClassname.Enabled = false;
            this.tbClassname.Location = new System.Drawing.Point(104, 182);
            this.tbClassname.Name = "tbClassname";
            this.tbClassname.ReadOnly = true;
            this.tbClassname.Size = new System.Drawing.Size(118, 20);
            this.tbClassname.TabIndex = 18;
            // 
            // btnLookUp
            // 
            this.btnLookUp.Location = new System.Drawing.Point(247, 181);
            this.btnLookUp.Name = "btnLookUp";
            this.btnLookUp.Size = new System.Drawing.Size(37, 23);
            this.btnLookUp.TabIndex = 19;
            this.btnLookUp.Text = "...";
            this.btnLookUp.UseVisualStyleBackColor = true;
            this.btnLookUp.Click += new System.EventHandler(this.btnLookUp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "CANCEL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eValidasi
            // 
            this.eValidasi.ContainerControl = this;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(600, 379);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // DataAirplaneFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 407);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLookUp);
            this.Controls.Add(this.tbClassname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nupdSeatplane);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbNameplane);
            this.Controls.Add(this.tbAirplane);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvAirplane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataAirplaneFrm";
            this.Text = "DataCustomerFrm";
            this.Load += new System.EventHandler(this.DataAirplaneFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirplane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdSeatplane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eValidasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAirplane;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbAirplane;
        private System.Windows.Forms.TextBox tbNameplane;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nupdSeatplane;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbClassname;
        private System.Windows.Forms.Button btnLookUp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider eValidasi;
        private System.Windows.Forms.Button btnUpdate;
    }
}