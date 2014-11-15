namespace GUI_Task
{
    partial class frmContractorCapacity
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
            this.grdContCapacity = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdContCapacity2 = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExitSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboItemGrp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdContCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdContCapacity2)).BeginInit();
            this.SuspendLayout();
            // 
            // grdContCapacity
            // 
            this.grdContCapacity.AllowUserToDeleteRows = false;
            this.grdContCapacity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdContCapacity.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdContCapacity.BackgroundColor = System.Drawing.Color.Gray;
            this.grdContCapacity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContCapacity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.grdContCapacity.Location = new System.Drawing.Point(1, 33);
            this.grdContCapacity.Name = "grdContCapacity";
            this.grdContCapacity.ReadOnly = true;
            this.grdContCapacity.Size = new System.Drawing.Size(648, 235);
            this.grdContCapacity.TabIndex = 639;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Production Process";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Capacity Process";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // grdContCapacity2
            // 
            this.grdContCapacity2.AllowUserToDeleteRows = false;
            this.grdContCapacity2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdContCapacity2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdContCapacity2.BackgroundColor = System.Drawing.Color.Gray;
            this.grdContCapacity2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContCapacity2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column14,
            this.Column12});
            this.grdContCapacity2.Location = new System.Drawing.Point(1, 265);
            this.grdContCapacity2.Name = "grdContCapacity2";
            this.grdContCapacity2.ReadOnly = true;
            this.grdContCapacity2.Size = new System.Drawing.Size(648, 193);
            this.grdContCapacity2.TabIndex = 640;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Item ID";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "Item Code";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.HeaderText = "Item Name";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.HeaderText = "Size ";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column14.HeaderText = "Color";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column12.HeaderText = "Capacity Process";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // btnGetAll
            // 
            this.btnGetAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAll.Location = new System.Drawing.Point(512, 2);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(104, 25);
            this.btnGetAll.TabIndex = 679;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(301, 464);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 25);
            this.btnExit.TabIndex = 680;
            this.btnExit.Text = "Esc=Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExitSave
            // 
            this.btnExitSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitSave.Location = new System.Drawing.Point(99, 464);
            this.btnExitSave.Name = "btnExitSave";
            this.btnExitSave.Size = new System.Drawing.Size(104, 25);
            this.btnExitSave.TabIndex = 681;
            this.btnExitSave.Text = "Exit+Save";
            this.btnExitSave.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 683;
            this.label4.Text = "Item Group";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboItemGrp
            // 
            this.cboItemGrp.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cboItemGrp.FormattingEnabled = true;
            this.cboItemGrp.Items.AddRange(new object[] {
            ""});
            this.cboItemGrp.Location = new System.Drawing.Point(132, 5);
            this.cboItemGrp.Name = "cboItemGrp";
            this.cboItemGrp.Size = new System.Drawing.Size(273, 21);
            this.cboItemGrp.TabIndex = 682;
            this.cboItemGrp.Text = "-";
            // 
            // frmContractorCapacity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 493);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboItemGrp);
            this.Controls.Add(this.btnExitSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.grdContCapacity2);
            this.Controls.Add(this.grdContCapacity);
            this.Name = "frmContractorCapacity";
            this.Text = "Contractor Capacity";
            this.Load += new System.EventHandler(this.frm_Contractor_Capacity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdContCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdContCapacity2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdContCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView grdContCapacity2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExitSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboItemGrp;
    }
}