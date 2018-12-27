namespace AirplaneSMK
{
    partial class DataCustomerFrm
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
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbIdcustomer = new System.Windows.Forms.TextBox();
            this.tbNamecustomer = new System.Windows.Forms.TextBox();
            this.rtbAddresscustomer = new System.Windows.Forms.RichTextBox();
            this.tbEmailcustomer = new System.Windows.Forms.TextBox();
            this.tbPhonenumbercustomer = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.eValidasi = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eValidasi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(313, 98);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.Size = new System.Drawing.Size(443, 275);
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            this.dgvCustomer.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentDoubleClick);
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
            // tbIdcustomer
            // 
            this.tbIdcustomer.Location = new System.Drawing.Point(104, 101);
            this.tbIdcustomer.MaxLength = 9;
            this.tbIdcustomer.Name = "tbIdcustomer";
            this.tbIdcustomer.Size = new System.Drawing.Size(180, 20);
            this.tbIdcustomer.TabIndex = 2;
            this.tbIdcustomer.TextChanged += new System.EventHandler(this.tbIdcustomer_TextChanged);
            this.tbIdcustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIdcustomer_KeyPress);
            // 
            // tbNamecustomer
            // 
            this.tbNamecustomer.Location = new System.Drawing.Point(104, 127);
            this.tbNamecustomer.Name = "tbNamecustomer";
            this.tbNamecustomer.Size = new System.Drawing.Size(180, 20);
            this.tbNamecustomer.TabIndex = 3;
            // 
            // rtbAddresscustomer
            // 
            this.rtbAddresscustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbAddresscustomer.Location = new System.Drawing.Point(104, 154);
            this.rtbAddresscustomer.Name = "rtbAddresscustomer";
            this.rtbAddresscustomer.Size = new System.Drawing.Size(180, 96);
            this.rtbAddresscustomer.TabIndex = 4;
            this.rtbAddresscustomer.Text = "";
            // 
            // tbEmailcustomer
            // 
            this.tbEmailcustomer.Location = new System.Drawing.Point(104, 256);
            this.tbEmailcustomer.Name = "tbEmailcustomer";
            this.tbEmailcustomer.Size = new System.Drawing.Size(180, 20);
            this.tbEmailcustomer.TabIndex = 5;
            // 
            // tbPhonenumbercustomer
            // 
            this.tbPhonenumbercustomer.Location = new System.Drawing.Point(104, 282);
            this.tbPhonenumbercustomer.Name = "tbPhonenumbercustomer";
            this.tbPhonenumbercustomer.Size = new System.Drawing.Size(180, 20);
            this.tbPhonenumbercustomer.TabIndex = 6;
            this.tbPhonenumbercustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhonenumbercustomer_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(104, 308);
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
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Customer";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Data Customer";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(185, 308);
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
            // DataCustomerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 407);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbPhonenumbercustomer);
            this.Controls.Add(this.tbEmailcustomer);
            this.Controls.Add(this.rtbAddresscustomer);
            this.Controls.Add(this.tbNamecustomer);
            this.Controls.Add(this.tbIdcustomer);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataCustomerFrm";
            this.Text = "DataCustomerFrm";
            this.Load += new System.EventHandler(this.DataCustomerFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eValidasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbIdcustomer;
        private System.Windows.Forms.TextBox tbNamecustomer;
        private System.Windows.Forms.RichTextBox rtbAddresscustomer;
        private System.Windows.Forms.TextBox tbEmailcustomer;
        private System.Windows.Forms.TextBox tbPhonenumbercustomer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider eValidasi;
        private System.Windows.Forms.Button btnUpdate;
    }
}