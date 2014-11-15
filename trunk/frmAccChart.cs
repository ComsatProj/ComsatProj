using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Task
{
    public partial class frmAccChart : Form
    {
        public frmAccChart()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chart_Of_Accounts_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void frmAccChart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        
    }
}
