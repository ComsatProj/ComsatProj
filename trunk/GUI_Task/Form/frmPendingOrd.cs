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
    public partial class frmPendingOrd : Form
    {
        int fcboDefaultValue = 0;
        public frmPendingOrd()
        {
            InitializeComponent();
        }

        private void pending_Orders_Load(object sender, EventArgs e)
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
            
            //Main Group Combo Fill
            lSQL = "select cgdCode, cgdDesc from catdtl where cgcode="+Convert.ToString((int)Category.enmMainGroup);
            lSQL += " order by cgdDesc";

            clsFillCombo.FillCombo(cboMainGrp, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboMainGrp.SelectedValue);

            //Transport Combo Fill
            lSQL = "select cgdCode, cgdDesc from catdtl where cgcode="+Convert.ToString((int)Category.enmItemGroup);
            lSQL += " order by cgdDesc";

            clsFillCombo.FillCombo(cboItemGrp, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboItemGrp.SelectedValue);
        }

        private void frmPendingOrd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
