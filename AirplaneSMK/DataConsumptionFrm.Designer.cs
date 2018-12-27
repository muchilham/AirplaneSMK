namespace AirplaneSMK
{
    partial class DataConsumptionFrm
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
            this.dgvConsumption = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbIdconsumption = new System.Windows.Forms.TextBox();
            this.tbNameconsumption = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.eValidasi = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tbPriceconsumption = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eValidasi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsumption
            // 
            this.dgvConsumption.AllowUserToAddRows = false;
            this.dgvConsumption.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsumption.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsumption.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvConsumption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsumption.Location = new System.Drawing.Point(295, 98);
            this.dgvConsumption.Name = "dgvConsumption";
            this.dgvConsumption.ReadOnly = true;
            this.dgvConsumption.Size = new System.Drawing.Size(461, 275);
            this.dgvConsumption.TabIndex = 0;
            this.dgvConsumption.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsumption_CellContentClick);
            this.dgvConsumption.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsumption_CellContentDoubleClick);
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
            // tbIdconsumption
            // 
            this.tbIdconsumption.Enabled = false;
            this.tbIdconsumption.Location = new System.Drawing.Point(104, 101);
            this.tbIdconsumption.Name = "tbIdconsumption";
            this.tbIdconsumption.ReadOnly = true;
            this.tbIdconsumption.Size = new System.Drawing.Size(180, 20);
            this.tbIdconsumption.TabIndex = 2;
            this.tbIdconsumption.TextChanged += new System.EventHandler(this.tbIdconsumption_TextChanged);
            // 
            // tbNameconsumption
            // 
            this.tbNameconsumption.Location = new System.Drawing.Point(104, 127);
            this.tbNameconsumption.Name = "tbNameconsumption";
            this.tbNameconsumption.Size = new System.Drawing.Size(180, 20);
            this.tbNameconsumption.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(102, 178);
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
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Consumption";
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
            this.label6.Size = new System.Drawing.Size(210, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Data Consumption";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(183, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // eValidasi
            // 
            this.eValidasi.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Price";
            // 
            // tbPriceconsumption
            // 
            this.tbPriceconsumption.Location = new System.Drawing.Point(104, 152);
            this.tbPriceconsumption.Name = "tbPriceconsumption";
            this.tbPriceconsumption.Size = new System.Drawing.Size(180, 20);
            this.tbPriceconsumption.TabIndex = 22;
            this.tbPriceconsumption.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPriceconsumption_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(600, 379);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // DataConsumptionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 407);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPriceconsumption);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbNameconsumption);
            this.Controls.Add(this.tbIdconsumption);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvConsumption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataConsumptionFrm";
            this.Text = "DataCustomerFrm";
            this.Load += new System.EventHandler(this.DataConsumptionFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eValidasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsumption;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbIdconsumption;
        private System.Windows.Forms.TextBox tbNameconsumption;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider eValidasi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPriceconsumption;
        private System.Windows.Forms.Button btnUpdate;
    }
}