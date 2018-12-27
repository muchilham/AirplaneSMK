namespace AirplaneSMK
{
    partial class DataClassFrm
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
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbIdclass = new System.Windows.Forms.TextBox();
            this.tbNameclass = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.eValidasi = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbPriceclass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eValidasi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClass
            // 
            this.dgvClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClass.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Location = new System.Drawing.Point(313, 98);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.ReadOnly = true;
            this.dgvClass.Size = new System.Drawing.Size(443, 275);
            this.dgvClass.TabIndex = 0;
            this.dgvClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClass_CellContentClick);
            this.dgvClass.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClass_CellContentDoubleClick);
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
            // tbIdclass
            // 
            this.tbIdclass.Enabled = false;
            this.tbIdclass.Location = new System.Drawing.Point(104, 101);
            this.tbIdclass.Name = "tbIdclass";
            this.tbIdclass.ReadOnly = true;
            this.tbIdclass.Size = new System.Drawing.Size(180, 20);
            this.tbIdclass.TabIndex = 2;
            this.tbIdclass.TextChanged += new System.EventHandler(this.tbIdclass_TextChanged);
            // 
            // tbNameclass
            // 
            this.tbNameclass.Location = new System.Drawing.Point(104, 127);
            this.tbNameclass.Name = "tbNameclass";
            this.tbNameclass.Size = new System.Drawing.Size(180, 20);
            this.tbNameclass.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(103, 188);
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
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Class";
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
            this.label6.Size = new System.Drawing.Size(128, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Data Class";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(184, 188);
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
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(600, 379);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbPriceclass
            // 
            this.tbPriceclass.Location = new System.Drawing.Point(104, 153);
            this.tbPriceclass.Name = "tbPriceclass";
            this.tbPriceclass.Size = new System.Drawing.Size(180, 20);
            this.tbPriceclass.TabIndex = 23;
            this.tbPriceclass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPriceclass_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Price";
            // 
            // DataClassFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 407);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPriceclass);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbNameclass);
            this.Controls.Add(this.tbIdclass);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataClassFrm";
            this.Text = "DataCustomerFrm";
            this.Load += new System.EventHandler(this.DataClassFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eValidasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbIdclass;
        private System.Windows.Forms.TextBox tbNameclass;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider eValidasi;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPriceclass;
    }
}