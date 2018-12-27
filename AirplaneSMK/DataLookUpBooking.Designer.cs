namespace AirplaneSMK
{
    partial class DataLookUpBooking
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLookupConsumption = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbConsumptionname = new System.Windows.Forms.TextBox();
            this.tbIdconsumption = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLookupcustomer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCustomername = new System.Windows.Forms.TextBox();
            this.tbIdcustomer = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.eValidasi = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eValidasi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 217);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Booking Detail";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbQuantity);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.btnLookupConsumption);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.tbConsumptionname);
            this.groupBox5.Controls.Add(this.tbIdconsumption);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox5.Location = new System.Drawing.Point(275, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(285, 163);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Consumption";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(28, 124);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(163, 20);
            this.tbQuantity.TabIndex = 16;
            this.tbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQuantity_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Consumption Name";
            // 
            // btnLookupConsumption
            // 
            this.btnLookupConsumption.Location = new System.Drawing.Point(205, 35);
            this.btnLookupConsumption.Name = "btnLookupConsumption";
            this.btnLookupConsumption.Size = new System.Drawing.Size(36, 23);
            this.btnLookupConsumption.TabIndex = 12;
            this.btnLookupConsumption.Text = "...";
            this.btnLookupConsumption.UseVisualStyleBackColor = true;
            this.btnLookupConsumption.Click += new System.EventHandler(this.btnLookupConsumption_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "ID Consumption";
            // 
            // tbConsumptionname
            // 
            this.tbConsumptionname.Location = new System.Drawing.Point(27, 79);
            this.tbConsumptionname.Name = "tbConsumptionname";
            this.tbConsumptionname.ReadOnly = true;
            this.tbConsumptionname.Size = new System.Drawing.Size(163, 20);
            this.tbConsumptionname.TabIndex = 10;
            // 
            // tbIdconsumption
            // 
            this.tbIdconsumption.Location = new System.Drawing.Point(27, 37);
            this.tbIdconsumption.Name = "tbIdconsumption";
            this.tbIdconsumption.ReadOnly = true;
            this.tbIdconsumption.Size = new System.Drawing.Size(163, 20);
            this.tbIdconsumption.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnLookupcustomer);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbCustomername);
            this.groupBox3.Controls.Add(this.tbIdcustomer);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(3, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 163);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Customer Name";
            // 
            // btnLookupcustomer
            // 
            this.btnLookupcustomer.Location = new System.Drawing.Point(202, 53);
            this.btnLookupcustomer.Name = "btnLookupcustomer";
            this.btnLookupcustomer.Size = new System.Drawing.Size(36, 23);
            this.btnLookupcustomer.TabIndex = 12;
            this.btnLookupcustomer.Text = "...";
            this.btnLookupcustomer.UseVisualStyleBackColor = true;
            this.btnLookupcustomer.Click += new System.EventHandler(this.btnLookupcustomer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID Customer";
            // 
            // tbCustomername
            // 
            this.tbCustomername.Location = new System.Drawing.Point(24, 97);
            this.tbCustomername.Name = "tbCustomername";
            this.tbCustomername.ReadOnly = true;
            this.tbCustomername.Size = new System.Drawing.Size(163, 20);
            this.tbCustomername.TabIndex = 10;
            // 
            // tbIdcustomer
            // 
            this.tbIdcustomer.Location = new System.Drawing.Point(24, 55);
            this.tbIdcustomer.Name = "tbIdcustomer";
            this.tbIdcustomer.ReadOnly = true;
            this.tbIdcustomer.Size = new System.Drawing.Size(163, 20);
            this.tbIdcustomer.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAdd);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(3, 179);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(557, 35);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(162, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(227, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // eValidasi
            // 
            this.eValidasi.ContainerControl = this;
            // 
            // DataLookUpBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 243);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DataLookUpBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataLookUpBooking";
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eValidasi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLookupConsumption;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbConsumptionname;
        private System.Windows.Forms.TextBox tbIdconsumption;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLookupcustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCustomername;
        private System.Windows.Forms.TextBox tbIdcustomer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider eValidasi;
    }
}