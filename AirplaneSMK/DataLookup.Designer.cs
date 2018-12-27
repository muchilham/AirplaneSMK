namespace AirplaneSMK
{
    partial class DataLookup
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
            this.dgvLookup = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLookup)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLookup
            // 
            this.dgvLookup.AllowUserToAddRows = false;
            this.dgvLookup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLookup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLookup.Location = new System.Drawing.Point(12, 72);
            this.dgvLookup.Name = "dgvLookup";
            this.dgvLookup.ReadOnly = true;
            this.dgvLookup.Size = new System.Drawing.Size(376, 251);
            this.dgvLookup.TabIndex = 0;
            this.dgvLookup.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLookup_CellContentDoubleClick);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(59, 32);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(217, 20);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextChanged += new System.EventHandler(this.btnSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // DataLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 335);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvLookup);
            this.Name = "DataLookup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataLookup";
            this.Load += new System.EventHandler(this.DataLookup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLookup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLookup;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
    }
}