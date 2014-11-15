namespace GUI_Task
{
    partial class frmBankPayVoc
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
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mskBankCode = new System.Windows.Forms.MaskedTextBox();
            this.lstVocNum = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVocHelp = new System.Windows.Forms.Button();
            this.btnNewVoc = new System.Windows.Forms.Button();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.btnBankHelp = new System.Windows.Forms.Button();
            this.grdBankPayVoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtVocDet = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mskAccCode = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkPrint = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnExitSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalance2 = new System.Windows.Forms.Label();
            this.lblNameBottom = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdBankPayVoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(397, 7);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(106, 20);
            this.dt.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(311, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 87;
            this.label5.Text = "     Name     ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(311, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 86;
            this.label4.Text = "      Date      ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mskBankCode
            // 
            this.mskBankCode.Location = new System.Drawing.Point(150, 35);
            this.mskBankCode.Mask = "0-0-00-00-0000";
            this.mskBankCode.Name = "mskBankCode";
            this.mskBankCode.Size = new System.Drawing.Size(127, 20);
            this.mskBankCode.TabIndex = 83;
            this.mskBankCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskBankCode_KeyDown);
            this.mskBankCode.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mskBankCode_MouseDoubleClick);
            // 
            // lstVocNum
            // 
            this.lstVocNum.FormattingEnabled = true;
            this.lstVocNum.Location = new System.Drawing.Point(150, 9);
            this.lstVocNum.Name = "lstVocNum";
            this.lstVocNum.Size = new System.Drawing.Size(127, 17);
            this.lstVocNum.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 82;
            this.label3.Text = "            Balance           ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 81;
            this.label2.Text = "         Bank Code         ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 79;
            this.label1.Text = "   Voucher Number   ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(311, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 89;
            this.label6.Text = "     Detail      ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnVocHelp
            // 
            this.btnVocHelp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVocHelp.Location = new System.Drawing.Point(512, 9);
            this.btnVocHelp.Name = "btnVocHelp";
            this.btnVocHelp.Size = new System.Drawing.Size(124, 20);
            this.btnVocHelp.TabIndex = 90;
            this.btnVocHelp.Text = "[F1] = Unposted Voc.";
            this.btnVocHelp.UseVisualStyleBackColor = true;
            this.btnVocHelp.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnNewVoc
            // 
            this.btnNewVoc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNewVoc.Location = new System.Drawing.Point(642, 9);
            this.btnNewVoc.Name = "btnNewVoc";
            this.btnNewVoc.Size = new System.Drawing.Size(104, 20);
            this.btnNewVoc.TabIndex = 91;
            this.btnNewVoc.Text = "New Voucher";
            this.btnNewVoc.UseVisualStyleBackColor = true;
            this.btnNewVoc.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDetail
            // 
            this.txtDetail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDetail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetail.Location = new System.Drawing.Point(397, 63);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(239, 21);
            this.txtDetail.TabIndex = 92;
            // 
            // btnBankHelp
            // 
            this.btnBankHelp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBankHelp.Location = new System.Drawing.Point(642, 63);
            this.btnBankHelp.Name = "btnBankHelp";
            this.btnBankHelp.Size = new System.Drawing.Size(104, 20);
            this.btnBankHelp.TabIndex = 93;
            this.btnBankHelp.Text = "[F1] = Banks Help";
            this.btnBankHelp.UseVisualStyleBackColor = true;
            this.btnBankHelp.Click += new System.EventHandler(this.button2_Click);
            // 
            // grdBankPayVoc
            // 
            this.grdBankPayVoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBankPayVoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.grdBankPayVoc.Location = new System.Drawing.Point(12, 90);
            this.grdBankPayVoc.Name = "grdBankPayVoc";
            this.grdBankPayVoc.Size = new System.Drawing.Size(734, 272);
            this.grdBankPayVoc.TabIndex = 94;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Account No.";
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
            this.Column4.HeaderText = "Amount";
            this.Column4.Name = "Column4";
            // 
            // txtVocDet
            // 
            this.txtVocDet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVocDet.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVocDet.Location = new System.Drawing.Point(145, 491);
            this.txtVocDet.Name = "txtVocDet";
            this.txtVocDet.Size = new System.Drawing.Size(323, 21);
            this.txtVocDet.TabIndex = 116;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(12, 491);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(106, 20);
            this.txtAmount.TabIndex = 115;
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(145, 456);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(323, 17);
            this.label8.TabIndex = 114;
            this.label8.Text = "                                      Voucher Details                            " +
                "         ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(12, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 113;
            this.label7.Text = "         Amount         ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mskAccCode
            // 
            this.mskAccCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskAccCode.Location = new System.Drawing.Point(12, 416);
            this.mskAccCode.Mask = "0-0-00-00-0000";
            this.mskAccCode.Name = "mskAccCode";
            this.mskAccCode.Size = new System.Drawing.Size(106, 22);
            this.mskAccCode.TabIndex = 111;
            this.mskAccCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskAccCode_KeyDown);
            this.mskAccCode.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mskAccCode_MouseDoubleClick);
            // 
            // label10
            // 
            this.label10.AllowDrop = true;
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(450, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 109;
            this.label10.Text = "      Balance      ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AllowDrop = true;
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(145, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(278, 17);
            this.label11.TabIndex = 108;
            this.label11.Text = "                               Account Name                               ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AllowDrop = true;
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(12, 375);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 17);
            this.label12.TabIndex = 107;
            this.label12.Text = "   Account Code   ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AllowDrop = true;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkGray;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(576, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 117;
            this.label9.Text = "    Total    ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chkPrint
            // 
            this.chkPrint.AutoSize = true;
            this.chkPrint.Checked = true;
            this.chkPrint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrint.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrint.Location = new System.Drawing.Point(684, 492);
            this.chkPrint.Name = "chkPrint";
            this.chkPrint.Size = new System.Drawing.Size(62, 19);
            this.chkPrint.TabIndex = 126;
            this.chkPrint.Text = "Printer";
            this.chkPrint.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(680, 453);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(64, 20);
            this.btnPrint.TabIndex = 125;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(474, 490);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 20);
            this.btnExit.TabIndex = 124;
            this.btnExit.Text = "[Esc] = Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(569, 453);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 20);
            this.btnHelp.TabIndex = 123;
            this.btnHelp.Text = "[F1] = Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnExitSave
            // 
            this.btnExitSave.Enabled = false;
            this.btnExitSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExitSave.Location = new System.Drawing.Point(474, 453);
            this.btnExitSave.Name = "btnExitSave";
            this.btnExitSave.Size = new System.Drawing.Size(75, 20);
            this.btnExitSave.TabIndex = 122;
            this.btnExitSave.Text = "Exit + Save";
            this.btnExitSave.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(710, 408);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(60, 20);
            this.btnDel.TabIndex = 121;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(642, 408);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(62, 20);
            this.btnEdit.TabIndex = 120;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(569, 408);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 20);
            this.btnAdd.TabIndex = 119;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(397, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(247, 15);
            this.lblName.TabIndex = 127;
            this.lblName.Text = "                                                                                ";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblBalance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(147, 66);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(127, 15);
            this.lblBalance.TabIndex = 128;
            this.lblBalance.Text = "                                        ";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBalance2
            // 
            this.lblBalance2.AutoSize = true;
            this.lblBalance2.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblBalance2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance2.Location = new System.Drawing.Point(447, 420);
            this.lblBalance2.Name = "lblBalance2";
            this.lblBalance2.Size = new System.Drawing.Size(94, 15);
            this.lblBalance2.TabIndex = 130;
            this.lblBalance2.Text = "                             ";
            this.lblBalance2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNameBottom
            // 
            this.lblNameBottom.AutoSize = true;
            this.lblNameBottom.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblNameBottom.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameBottom.Location = new System.Drawing.Point(147, 420);
            this.lblNameBottom.Name = "lblNameBottom";
            this.lblNameBottom.Size = new System.Drawing.Size(274, 15);
            this.lblNameBottom.TabIndex = 129;
            this.lblNameBottom.Text = "                                                                                 " +
                "        ";
            this.lblNameBottom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(652, 377);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(94, 15);
            this.lblTotal.TabIndex = 134;
            this.lblTotal.Text = "                             ";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmBankPayVoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 522);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblBalance2);
            this.Controls.Add(this.lblNameBottom);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.chkPrint);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExitSave);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtVocDet);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mskAccCode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.grdBankPayVoc);
            this.Controls.Add(this.btnBankHelp);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.btnNewVoc);
            this.Controls.Add(this.btnVocHelp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskBankCode);
            this.Controls.Add(this.lstVocNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBankPayVoc";
            this.Text = "Bank Payment Voucher";
            this.Load += new System.EventHandler(this.bank_payment_Voucher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBankPayVoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskBankCode;
        private System.Windows.Forms.ListBox lstVocNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVocHelp;
        private System.Windows.Forms.Button btnNewVoc;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Button btnBankHelp;
        private System.Windows.Forms.DataGridView grdBankPayVoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtVocDet;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskAccCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkPrint;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnExitSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBalance2;
        private System.Windows.Forms.Label lblNameBottom;
        private System.Windows.Forms.Label lblTotal;
    }
}