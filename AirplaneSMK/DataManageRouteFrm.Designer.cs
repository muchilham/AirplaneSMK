namespace AirplaneSMK
{
    partial class DataManageRouteFrm
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
            this.dgvManageroute = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbIdroute = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLookUpdeparture = new System.Windows.Forms.Button();
            this.tbAirportdeparture = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLookUparrival = new System.Windows.Forms.Button();
            this.tbAirportarrival = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.eValidasi = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageroute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eValidasi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManageroute
            // 
            this.dgvManageroute.AllowUserToAddRows = false;
            this.dgvManageroute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvManageroute.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManageroute.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvManageroute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageroute.Location = new System.Drawing.Point(295, 98);
            this.dgvManageroute.Name = "dgvManageroute";
            this.dgvManageroute.ReadOnly = true;
            this.dgvManageroute.Size = new System.Drawing.Size(461, 275);
            this.dgvManageroute.TabIndex = 0;
            this.dgvManageroute.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageroute_CellContentClick);
            this.dgvManageroute.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageroute_CellContentDoubleClick);
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
            // tbIdroute
            // 
            this.tbIdroute.Enabled = false;
            this.tbIdroute.Location = new System.Drawing.Point(104, 101);
            this.tbIdroute.Name = "tbIdroute";
            this.tbIdroute.ReadOnly = true;
            this.tbIdroute.Size = new System.Drawing.Size(180, 20);
            this.tbIdroute.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(104, 179);
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
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Route";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Manage Route";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(185, 181);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLookUpdeparture
            // 
            this.btnLookUpdeparture.Location = new System.Drawing.Point(247, 126);
            this.btnLookUpdeparture.Name = "btnLookUpdeparture";
            this.btnLookUpdeparture.Size = new System.Drawing.Size(37, 23);
            this.btnLookUpdeparture.TabIndex = 24;
            this.btnLookUpdeparture.Text = "...";
            this.btnLookUpdeparture.UseVisualStyleBackColor = true;
            this.btnLookUpdeparture.Click += new System.EventHandler(this.btnLookUpdeparture_Click);
            // 
            // tbAirportdeparture
            // 
            this.tbAirportdeparture.Enabled = false;
            this.tbAirportdeparture.Location = new System.Drawing.Point(104, 127);
            this.tbAirportdeparture.Name = "tbAirportdeparture";
            this.tbAirportdeparture.ReadOnly = true;
            this.tbAirportdeparture.Size = new System.Drawing.Size(137, 20);
            this.tbAirportdeparture.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Departure Airport";
            // 
            // btnLookUparrival
            // 
            this.btnLookUparrival.Location = new System.Drawing.Point(247, 152);
            this.btnLookUparrival.Name = "btnLookUparrival";
            this.btnLookUparrival.Size = new System.Drawing.Size(37, 23);
            this.btnLookUparrival.TabIndex = 27;
            this.btnLookUparrival.Text = "...";
            this.btnLookUparrival.UseVisualStyleBackColor = true;
            this.btnLookUparrival.Click += new System.EventHandler(this.btnLookUparrival_Click);
            // 
            // tbAirportarrival
            // 
            this.tbAirportarrival.Enabled = false;
            this.tbAirportarrival.Location = new System.Drawing.Point(104, 153);
            this.tbAirportarrival.Name = "tbAirportarrival";
            this.tbAirportarrival.ReadOnly = true;
            this.tbAirportarrival.Size = new System.Drawing.Size(137, 20);
            this.tbAirportarrival.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Destination Airport";
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
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "UDPATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // DataManageRouteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 407);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnLookUparrival);
            this.Controls.Add(this.tbAirportarrival);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLookUpdeparture);
            this.Controls.Add(this.tbAirportdeparture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbIdroute);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvManageroute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataManageRouteFrm";
            this.Text = "DataManageForm";
            this.Load += new System.EventHandler(this.DataManageRouteFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageroute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eValidasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManageroute;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbIdroute;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLookUpdeparture;
        private System.Windows.Forms.TextBox tbAirportdeparture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLookUparrival;
        private System.Windows.Forms.TextBox tbAirportarrival;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider eValidasi;
        private System.Windows.Forms.Button btnUpdate;
    }
}