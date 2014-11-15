namespace GUI_Task
{
    partial class frmAccChart
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optSortByName = new System.Windows.Forms.RadioButton();
            this.optSortByCode = new System.Windows.Forms.RadioButton();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRptShow = new System.Windows.Forms.Button();
            this.btnLrgStyle = new System.Windows.Forms.Button();
            this.btnSmallStyle = new System.Windows.Forms.Button();
            this.btnLstStyle = new System.Windows.Forms.Button();
            this.btnDetStyle = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(491, 377);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(483, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Accounts List View";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.treeView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(483, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Accounts Tree View";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(474, 342);
            this.treeView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optSortByName);
            this.groupBox1.Controls.Add(this.optSortByCode);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(505, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Printing";
            // 
            // optSortByName
            // 
            this.optSortByName.AutoSize = true;
            this.optSortByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSortByName.Location = new System.Drawing.Point(19, 77);
            this.optSortByName.Name = "optSortByName";
            this.optSortByName.Size = new System.Drawing.Size(90, 17);
            this.optSortByName.TabIndex = 12;
            this.optSortByName.Text = "Sort By Name";
            this.optSortByName.UseVisualStyleBackColor = true;
            // 
            // optSortByCode
            // 
            this.optSortByCode.AutoSize = true;
            this.optSortByCode.Checked = true;
            this.optSortByCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSortByCode.Location = new System.Drawing.Point(19, 54);
            this.optSortByCode.Name = "optSortByCode";
            this.optSortByCode.Size = new System.Drawing.Size(87, 17);
            this.optSortByCode.TabIndex = 11;
            this.optSortByCode.TabStop = true;
            this.optSortByCode.Text = "Sort By Code";
            this.optSortByCode.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(19, 27);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(101, 21);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Tag = "";
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnRptShow
            // 
            this.btnRptShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRptShow.Location = new System.Drawing.Point(524, 180);
            this.btnRptShow.Name = "btnRptShow";
            this.btnRptShow.Size = new System.Drawing.Size(101, 23);
            this.btnRptShow.TabIndex = 2;
            this.btnRptShow.Text = "Show Report";
            this.btnRptShow.UseVisualStyleBackColor = true;
            // 
            // btnLrgStyle
            // 
            this.btnLrgStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLrgStyle.Location = new System.Drawing.Point(524, 246);
            this.btnLrgStyle.Name = "btnLrgStyle";
            this.btnLrgStyle.Size = new System.Drawing.Size(101, 23);
            this.btnLrgStyle.TabIndex = 3;
            this.btnLrgStyle.Text = "Large Style";
            this.btnLrgStyle.UseVisualStyleBackColor = true;
            // 
            // btnSmallStyle
            // 
            this.btnSmallStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmallStyle.Location = new System.Drawing.Point(524, 275);
            this.btnSmallStyle.Name = "btnSmallStyle";
            this.btnSmallStyle.Size = new System.Drawing.Size(101, 23);
            this.btnSmallStyle.TabIndex = 4;
            this.btnSmallStyle.Text = "Small Style";
            this.btnSmallStyle.UseVisualStyleBackColor = true;
            // 
            // btnLstStyle
            // 
            this.btnLstStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLstStyle.Location = new System.Drawing.Point(524, 304);
            this.btnLstStyle.Name = "btnLstStyle";
            this.btnLstStyle.Size = new System.Drawing.Size(101, 23);
            this.btnLstStyle.TabIndex = 5;
            this.btnLstStyle.Text = "List Style";
            this.btnLstStyle.UseVisualStyleBackColor = true;
            // 
            // btnDetStyle
            // 
            this.btnDetStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetStyle.Location = new System.Drawing.Point(524, 333);
            this.btnDetStyle.Name = "btnDetStyle";
            this.btnDetStyle.Size = new System.Drawing.Size(101, 23);
            this.btnDetStyle.TabIndex = 6;
            this.btnDetStyle.Text = "Detail Style";
            this.btnDetStyle.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(244, 395);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button7_Click);
            // 
            // frmAccChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 427);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDetStyle);
            this.Controls.Add(this.btnLstStyle);
            this.Controls.Add(this.btnSmallStyle);
            this.Controls.Add(this.btnLrgStyle);
            this.Controls.Add(this.btnRptShow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAccChart";
            this.Text = "Chart Of Accounts";
            this.Load += new System.EventHandler(this.chart_Of_Accounts_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAccChart_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.RadioButton optSortByName;
        private System.Windows.Forms.RadioButton optSortByCode;
        private System.Windows.Forms.Button btnRptShow;
        private System.Windows.Forms.Button btnLrgStyle;
        private System.Windows.Forms.Button btnSmallStyle;
        private System.Windows.Forms.Button btnLstStyle;
        private System.Windows.Forms.Button btnDetStyle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TreeView treeView1;
    }
}