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
    public partial class frmItemCodeDes : Form
    {
        int fcboDefaultValue = 0;
        public frmItemCodeDes()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void frmItemCodeDes_Load(object sender, EventArgs e)
        {
            AtFormLoad();
            // blnFormLoad = false;
            this.MaximizeBox = false;
        }

        private void AtFormLoad()
        {
            string lSQL = string.Empty;
            //dtpOrder.Value = now.;
            //msk_VocDate.Text = now.Date.ToString();

            this.KeyPreview = true;

            //Item group cOMBO
            lSQL = "select cgdCode, cgdDesc from catdtl where cgcode=" + Convert.ToString((int)Category.enmItemGroup);
            lSQL += " order by cgdDesc";

            clsFillCombo.FillCombo(cboItemGroup, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboItemGroup.SelectedValue);

            lSQL = "select cgdCode, cgdDesc from catdtl where cgcode=" + Convert.ToString((int)Table.enmIMS_UOM);
            lSQL += " order by cgdDesc";

            clsFillCombo.FillCombo(cboUnit, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboUnit.SelectedValue);

        }

        private void frmItemCodeDes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void PassDataVocID(object sender)
        {
            txtItemID.Text = ((TextBox)sender).Text;
        }


        private void PopulateRecords()
        {
            DataSet ds = new DataSet();
            DataRow dRow;
            string tSQL = string.Empty;

            // Fields 0,1,2,3 are Begin  

            tSQL = "SELECT gi.GateInwordId, gi.Date, cd.cgdDesc AS ItemGroupName,";
            tSQL += " g.GRNId, g.Date AS GRNDate,g.Note,gi.GateTime, gt.cgdDesc AS GateName  ";
            tSQL += "FROM GateInword gi INNER JOIN CatDtl cd ON gi.ItemGroupID=cd.cgdCode AND cd.cgCode=6 ";
            tSQL += "LEFT OUTER JOIN GRN g ON gi.GateInwordId=g.GateInwordId ";
            tSQL += "INNER JOIN CatDtl gt ON gi.GateID = gt.cgdCode AND gt.cgCode = 20 ";
            try
            {
                ds = clsDbManager.GetData_Set(tSQL, "Heads");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dRow = ds.Tables[0].Rows[0];
                    txtNote.Text = (ds.Tables[0].Rows[0]["Note"] == DBNull.Value ? "" : ds.Tables[0].Rows[0]["Note"].ToString());
                    dtpGateInword.Text = (ds.Tables[0].Rows[0]["Date"] == DBNull.Value ? "" : ds.Tables[0].Rows[0]["Date"].ToString());
                    cboItemGroup.Text = (ds.Tables[0].Rows[0]["ItemGroupName"] == DBNull.Value ? "" : ds.Tables[0].Rows[0]["ItemGroupName"].ToString());
                    lblTime.Text = (ds.Tables[0].Rows[0]["GateTime"] == DBNull.Value ? "" : ds.Tables[0].Rows[0]["GateTime"].ToString());
                    cboGate.Text = (ds.Tables[0].Rows[0]["GateName"] == DBNull.Value ? "" : ds.Tables[0].Rows[0]["GateName"].ToString());

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        ds.Clear();
                    }
                    //LoadGridData();
                    SumVoc();
                }
            }
            catch
            {
                MessageBox.Show("Unable to Get Account Code...", this.Text.ToString());
            }
        }

        #region LookUp_Voc

        private void LookUp_Voc()
        {
            frmLookUp sForm = new frmLookUp(
                    "gi.GateInwordId",
                    "gi.Date, cd.cgdDesc AS ItemGroupName, "
                    + "g.GRNId,g.Date AS GRNDate,g.Note,gi.GateTime, gt.cgdDesc AS GateName",
                    " GateInword gi INNER JOIN CatDtl cd ON gi.ItemGroupID=cd.cgdCode AND cd.cgCode=6 LEFT OUTER JOIN GRN g ON gi.GateInwordId=g.GateInwordId INNER JOIN CatDtl gt ON gi.GateID = gt.cgdCode AND gt.cgCode = 20 ",
                    this.Text.ToString(),
                    1,
                    "GateInword#,Date,Item Group Name,Grn Id,Grn Date,Note, Gate Time ",
                    "10,8,12,12,12,15,8",
                    " T, T, T, T, T, T, T",
                    true,
                    "",
                    "",
                    "TextBox"
                    );

            txtItemID.Text = string.Empty;
            sForm.lupassControl = new frmLookUp.LUPassControl(PassDataVocID);
            sForm.ShowDialog();

            if (txtItemID.Text != null)
            {
                if (txtItemID.Text != null)
                {
                    if (txtItemID.Text.ToString() == "" || txtItemID.Text.ToString() == string.Empty)
                    {
                        return;
                    }
                    if (txtItemID.Text.ToString().Trim().Length > 0)
                    {
                        PopulateRecords();
                    }

                }

            }
        }
        #endregion

        private void txtItemID_DoubleClick(object sender, EventArgs e)
        {
            LookUp_Voc();
        }

        private void txtItemID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                LookUp_Voc();
            }
        }

    }
}

﻿