using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GUI_Task.Class;

namespace GUI_Task
{
    public partial class frmRptMachineProd : Form
    {
        int fcboDefaultValue = 0;
        public frmRptMachineProd()
        {
            InitializeComponent();
        }

        private void machine_Production_Report_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            AtFormLoad();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void AtFormLoad()
        {
            string lSQL = string.Empty;

            this.KeyPreview = true;

            //Contractor Combo Fill
            lSQL = "select cgdCode, cgdDesc from catdtl where cgcode=" + Convert.ToString((int)Category.enmMachineNo);
            lSQL += " order by cgdDesc";

            clsFillCombo.FillCombo(cboMachineNo, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboMachineNo.SelectedValue);
        }

        private void frmRptMachineProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
