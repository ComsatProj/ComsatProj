namespace GUI_Task
{
    partial class frmJournalVoc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lstVocNum = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkPrinter = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnVocHelp = new System.Windows.Forms.Button();
            this.grdJournalVoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mskAccCode = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnExitSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtVocDet = new System.Windows.Forms.TextBox();
            this.txtDrAmount1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDrAmount2 = new System.Windows.Forms.TextBox();
            this.lblNameBottom = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblCr = new System.Windows.Forms.Label();
            this.lblDr = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdJournalVoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lstVocNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 54);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(372, 16);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(106, 20);
            this.dt.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(299, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "   Date   ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstVocNum
            // 
            this.lstVocNum.FormattingEnabled = true;
            this.lstVocNum.Location = new System.Drawing.Point(148, 16);
            this.lstVocNum.Name = "lstVocNum";
            this.lstVocNum.Size = new System.Drawing.Size(127, 17);
            this.lstVocNum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "   Voucher Number   ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkPrinter);
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.btnVocHelp);
            this.groupBox2.Location = new System.Drawing.Point(529, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 70);
            this.groupBox2.TabIndex = 96;
            this.groupBox2.TabStop = false;
            // 
            // chkPrinter
            // 
            this.chkPrinter.AutoSize = true;
            this.chkPrinter.Checked = true;
            this.chkPrinter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrinter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrinter.Location = new System.Drawing.Point(166, 4);
            this.chkPrinter.Name = "chkPrinter";
            this.chkPrinter.Size = new System.Drawing.Size(62, 19);
            this.chkPrinter.TabIndex = 97;
            this.chkPrinter.Text = "Printer";
            this.chkPrinter.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(148, 29);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(104, 25);
            this.btnPrint.TabIndex = 21;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnVocHelp
            // 
            this.btnVocHelp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVocHelp.Location = new System.Drawing.Point(6, 29);
            this.btnVocHelp.Name = "btnVocHelp";
            this.btnVocHelp.Size = new System.Drawing.Size(124, 25);
            this.btnVocHelp.TabIndex = 20;
            this.btnVocHelp.Text = "[F1] = Unposted Voc.";
            this.btnVocHelp.UseVisualStyleBackColor = true;
            this.btnVocHelp.Click += new System.EventHandler(this.button4_Click);
            // 
            // grdJournalVoc
            // 
            this.grdJournalVoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdJournalVoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grdJournalVoc.Location = new System.Drawing.Point(9, 88);
            this.grdJournalVoc.Name = "grdJournalVoc";
            this.grdJournalVoc.Size = new System.Drawing.Size(794, 239);
            this.grdJournalVoc.TabIndex = 97;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Account Code";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Account Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Voucher Details";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Debits";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Credits";
            this.Column5.Name = "Column5";
            // 
            // mskAccCode
            // 
            this.mskAccCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskAccCode.Location = new System.Drawing.Point(12, 370);
            this.mskAccCode.Mask = "0-0-00-00-0000";
            this.mskAccCode.Name = "mskAccCode";
            this.mskAccCode.Size = new System.Drawing.Size(106, 22);
            this.mskAccCode.TabIndex = 109;
            this.mskAccCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskAccCode_KeyDown);
            this.mskAccCode.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mskAccCode_MouseDoubleClick);
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(450, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 107;
            this.label5.Text = "      Balance      ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(145, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 17);
            this.label4.TabIndex = 106;
            this.label4.Text = "                               Account Name                               ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 105;
            this.label3.Text = "   Account Code   ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(547, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 111;
            this.label6.Text = "  Dr  ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(679, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 113;
            this.label7.Text = "  Cr  ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(548, 453);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 20);
            this.btnExit.TabIndex = 122;
            this.btnExit.Text = "[Esc] = Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(638, 418);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 20);
            this.btnHelp.TabIndex = 121;
            this.btnHelp.Text = "[F1] = Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnExitSave
            // 
            this.btnExitSave.Enabled = false;
            this.btnExitSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExitSave.Location = new System.Drawing.Point(548, 418);
            this.btnExitSave.Name = "btnExitSave";
            this.btnExitSave.Size = new System.Drawing.Size(75, 20);
            this.btnExitSave.TabIndex = 120;
            this.btnExitSave.Text = "Exit + Save";
            this.btnExitSave.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(720, 380);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(60, 20);
            this.btnDel.TabIndex = 119;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(636, 380);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(62, 20);
            this.btnEdit.TabIndex = 118;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(547, 380);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 20);
            this.btnAdd.TabIndex = 117;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtVocDet
            // 
            this.txtVocDet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVocDet.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVocDet.Location = new System.Drawing.Point(230, 453);
            this.txtVocDet.Name = "txtVocDet";
            this.txtVocDet.Size = new System.Drawing.Size(312, 21);
            this.txtVocDet.TabIndex = 126;
            // 
            // txtDrAmount1
            // 
            this.txtDrAmount1.Location = new System.Drawing.Point(9, 453);
            this.txtDrAmount1.Name = "txtDrAmount1";
            this.txtDrAmount1.Size = new System.Drawing.Size(106, 20);
            this.txtDrAmount1.TabIndex = 125;
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(230, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(311, 17);
            this.label8.TabIndex = 124;
            this.label8.Text = "                                    Voucher Details                              " +
                "     ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AllowDrop = true;
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(12, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 123;
            this.label9.Text = "   Debit Amount   ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AllowDrop = true;
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(121, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 17);
            this.label10.TabIndex = 127;
            this.label10.Text = "   Debit Amount   ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDrAmount2
            // 
            this.txtDrAmount2.Location = new System.Drawing.Point(118, 453);
            this.txtDrAmount2.Name = "txtDrAmount2";
            this.txtDrAmount2.Size = new System.Drawing.Size(106, 20);
            this.txtDrAmount2.TabIndex = 128;
            // 
            // lblNameBottom
            // 
            this.lblNameBottom.AutoSize = true;
            this.lblNameBottom.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblNameBottom.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameBottom.Location = new System.Drawing.Point(142, 377);
            this.lblNameBottom.Name = "lblNameBottom";
            this.lblNameBottom.Size = new System.Drawing.Size(274, 15);
            this.lblNameBottom.TabIndex = 153;
            this.lblNameBottom.Text = "                                                                                 " +
                "        ";
            this.lblNameBottom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblBalance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(447, 377);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(91, 15);
            this.lblBalance.TabIndex = 154;
            this.lblBalance.Text = "                            ";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCr
            // 
            this.lblCr.AutoSize = true;
            this.lblCr.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblCr.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCr.Location = new System.Drawing.Point(719, 342);
            this.lblCr.Name = "lblCr";
            this.lblCr.Size = new System.Drawing.Size(91, 15);
            this.lblCr.TabIndex = 155;
            this.lblCr.Text = "                            ";
            this.lblCr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDr
            // 
            this.lblDr.AutoSize = true;
            this.lblDr.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblDr.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDr.Location = new System.Drawing.Point(582, 342);
            this.lblDr.Name = "lblDr";
            this.lblDr.Size = new System.Drawing.Size(91, 15);
            this.lblDr.TabIndex = 156;
            this.lblDr.Text = "                            ";
            this.lblDr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmJournalVoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 499);
            this.Controls.Add(this.lblDr);
            this.Controls.Add(this.lblCr);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblNameBottom);
            this.Controls.Add(this.txtDrAmount2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtVocDet);
            this.Controls.Add(this.txtDrAmount1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExitSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskAccCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grdJournalVoc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmJournalVoc";
            this.Text = "Journal Voucher";
            this.Load += new System.EventHandler(this.journal_Voucher_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdJournalVoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstVocNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkPrinter;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnVocHelp;
        private System.Windows.Forms.DataGridView grdJournalVoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.MaskedTextBox mskAccCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnExitSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtVocDet;
        private System.Windows.Forms.TextBox txtDrAmount1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDrAmount2;
        private System.Windows.Forms.Label lblNameBottom;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblCr;
        private System.Windows.Forms.Label lblDr;
    }
}