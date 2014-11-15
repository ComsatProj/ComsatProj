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
    public partial class frmAccDesc : Form
    {
        public frmAccDesc()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAccDesc_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MaximizeBox = false;
           // blnFormLoad = false;
        }

        private void AtFormLoad()
        {
            string lSQL = string.Empty;


            this.KeyPreview = true;
        }


        private void LookUp_GL()
        {
            //SELECT Code, Name FROM Heads WHERE TYPE = 'A'
            frmLookUp sForm = new frmLookUp(
                    "Code",
                    "Name",
                    "Heads",
                    this.Text.ToString(),
                    1,
                    "Account Code, Account Name",
                    "16,40",
                    " T, T",
                    true,
                    "",
                    " Type='A'",
                    "TextBox"
                    );

            mskAccCode.Mask = "";
            mskAccCode.Text = string.Empty;
            mskAccCode.Mask = clsGVar.maskGLCode;

            sForm.lupassControl = new frmLookUp.LUPassControl(PassData);
            sForm.ShowDialog();
            if (mskAccCode.Text != null)
            {
                if (mskAccCode.Text != null)
                {
                    if (mskAccCode.Text.ToString() == "" || mskAccCode.Text.ToString() == string.Empty)
                    {
                        return;
                    }
                    if (mskAccCode.Text.ToString().Trim().Length > 0)
                    {
                        PopulateRecordsGL();
                        //LoadSampleData();
                        //SumVoc();
                    }

                    //txtOrderNo.Text = txtPassDataVocID.Text.ToString();
                    //grdVoucher[pCol, pRow].Value = tmtext.Text.ToString();
                    //System.Windows.Forms.SendKeys.Send("{TAB}");
                }

                //if (msk_AccountID.Text.ToString() == "" || msk_AccountID.Text.ToString() == string.Empty)
                //{
                //    return;
                //}
                //msk_AccountID.Text = sForm.lupassControl.ToString();
                ////grdVoucher[pCol, pRow].Value = msk_AccountID.Text.ToString();
                //System.Windows.Forms.SendKeys.Send("{TAB}");
            }
        }

        private void PassData(object sender)
        {
            mskAccCode.Mask = "";
            mskAccCode.Text = ((TextBox)sender).Text;
            mskAccCode.Mask = clsGVar.maskGLCode;
            //mskAccCode.Text = ((MaskedTextBox)sender).Text;
            //mskAccCode.Mask = clsGVar.maskGLCode;

        }

        //Populate Recordset 
        private void PopulateRecordsGL()
        {
            DataSet ds = new DataSet();
            DataRow dRow;
            string tSQL = string.Empty;

            // Fields 0,1,2,3 are Begin  

            tSQL = "SELECT Name ";
            tSQL += " from Heads ";
            tSQL += " where Code ='" + mskAccCode.Text.ToString() + "';";

            try
            {
                ds = clsDbManager.GetData_Set(tSQL, "Heads");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    //fAlreadyExists = true;
                    dRow = ds.Tables[0].Rows[0];
                    // Starting title as 0
                    txtName.Text = (ds.Tables[0].Rows[0]["Name"] == DBNull.Value ? "" : ds.Tables[0].Rows[0]["Name"].ToString());
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        ds.Clear();
                        //btn_EnableDisable(true);
                    }
                    //LoadGridData();
                    //txtManualDoc.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Unable to Get Account Code...", this.Text.ToString());
            }
        }



        private void frmAccDesc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void mskAccCode_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            LookUp_GL();
 
        }

        private void mskAccCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                LookUp_GL();
            }

        }

        private void optGroup_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //SaveData();
            MessageBox.Show("Data Saved Successfullly");
        }

  
    }
}
