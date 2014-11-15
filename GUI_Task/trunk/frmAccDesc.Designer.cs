namespace GUI_Task
{
    partial class frmAccDesc
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
            this.mskAccCode = new System.Windows.Forms.MaskedTextBox();
            this.lblAccCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.frmAccType = new System.Windows.Forms.Label();
            this.optDetail = new System.Windows.Forms.RadioButton();
            this.optGroup = new System.Windows.Forms.RadioButton();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mskAccCode
            // 
            this.mskAccCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskAccCode.Location = new System.Drawing.Point(107, 20);
            this.mskAccCode.Mask = "0-0-00-00-0000";
            this.mskAccCode.Name = "mskAccCode";
            this.mskAccCode.Size = new System.Drawing.Size(150, 22);
            this.mskAccCode.TabIndex = 49;
            this.mskAccCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskAccCode_KeyDown);
            this.mskAccCode.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mskAccCode_MouseDoubleClick);
            // 
            // lblAccCode
            // 
            this.lblAccCode.AllowDrop = true;
            this.lblAccCode.AutoSize = true;
            this.lblAccCode.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblAccCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccCode.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAccCode.Location = new System.Drawing.Point(12, 22);
            this.lblAccCode.Name = "lblAccCode";
            this.lblAccCode.Size = new System.Drawing.Size(87, 17);
            this.lblAccCode.TabIndex = 48;
            this.lblAccCode.Text = "Account Code  ";
            this.lblAccCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblName
            // 
            this.lblName.AllowDrop = true;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(12, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 17);
            this.lblName.TabIndex = 50;
            this.lblName.Text = "Account Name ";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(302, 20);
            this.txtName.TabIndex = 51;
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(107, 83);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(302, 20);
            this.txtName2.TabIndex = 52;
            // 
            // frmAccType
            // 
            this.frmAccType.AllowDrop = true;
            this.frmAccType.AutoSize = true;
            this.frmAccType.BackColor = System.Drawing.Color.NavajoWhite;
            this.frmAccType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.frmAccType.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmAccType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.frmAccType.Location = new System.Drawing.Point(12, 116);
            this.frmAccType.Name = "frmAccType";
            this.frmAccType.Size = new System.Drawing.Size(88, 17);
            this.frmAccType.TabIndex = 53;
            this.frmAccType.Text = "Account Type   ";
            this.frmAccType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // optDetail
            // 
            this.optDetail.AutoSize = true;
            this.optDetail.Checked = true;
            this.optDetail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optDetail.Location = new System.Drawing.Point(136, 116);
            this.optDetail.Name = "optDetail";
            this.optDetail.Size = new System.Drawing.Size(57, 19);
            this.optDetail.TabIndex = 54;
            this.optDetail.TabStop = true;
            this.optDetail.Text = "Detail";
            this.optDetail.UseVisualStyleBackColor = true;
            // 
            // optGroup
            // 
            this.optGroup.AutoSize = true;
            this.optGroup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optGroup.Location = new System.Drawing.Point(256, 116);
            this.optGroup.Name = "optGroup";
            this.optGroup.Size = new System.Drawing.Size(59, 19);
            this.optGroup.TabIndex = 55;
            this.optGroup.Text = "Group";
            this.optGroup.UseVisualStyleBackColor = true;
            this.optGroup.CheckedChanged += new System.EventHandler(this.optGroup_CheckedChanged);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(107, 154);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(72, 73);
            this.btnDel.TabIndex = 957;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(185, 154);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 73);
            this.btnExit.TabIndex = 956;
            this.btnExit.Text = "Esc/Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(337, 154);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(72, 73);
            this.btnHelp.TabIndex = 955;
            this.btnHelp.Text = "F1=Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(29, 154);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 73);
            this.btnSave.TabIndex = 954;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAccDesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 239);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.optGroup);
            this.Controls.Add(this.optDetail);
            this.Controls.Add(this.frmAccType);
            this.Controls.Add(this.txtName2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.mskAccCode);
            this.Controls.Add(this.lblAccCode);
            this.Name = "frmAccDesc";
            this.Text = "Account Description";
            this.Load += new System.EventHandler(this.frmAccDesc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskAccCode;
        private System.Windows.Forms.Label lblAccCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.Label frmAccType;
        private System.Windows.Forms.RadioButton optDetail;
        private System.Windows.Forms.RadioButton optGroup;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSave;
    }
}