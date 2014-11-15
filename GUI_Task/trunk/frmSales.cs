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
    public partial class frmSales : Form
    {
        //******* Grid Variable Setting -- Begin ******
        string fHDR = string.Empty;                       // Column Header
        string fColWidth = string.Empty;                  // Column Width (Input)
        string fColMinWidth = string.Empty;               // Column Minimum Width
        string fColMaxInputLen = string.Empty;            // Column Visible Length/Width 
        string fColFormat = string.Empty;                 // Column Format  
        string fColReadOnly = string.Empty;               // Column ReadOnly 1 = ReadOnly, 0 = Read-Write  
        string fFieldList = string.Empty;

        string fColType = string.Empty;
        string fFieldName = string.Empty;
        //******* Grid Variable Setting -- End ******

        string[] a_Color = new string[0];
        int[] a_ColorInt = new int[0];

        string[] a_Size = new string[0];
        int[] a_SizeInt = new int[0];
        int fcboDefaultValue = 0;
        public frmSales()
        {
            InitializeComponent();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            AtFormLoad();
            this.MaximizeBox = false;
        }

        private void AtFormLoad()
        {
            string lSQL = string.Empty;

            this.KeyPreview = true;

            //string lSQL = string.Empty;
            //SettingGridVariable();
            //LoadInitialControls();
            this.KeyPreview = true;

            //Size Combo Fill
            lSQL = "select cgdCode, cgdDesc from catdtl where cgcode=" + Convert.ToString((int)Category.enmSize);
            lSQL += " order by cgdDesc";

            clsFillCombo.FillCombo(cbo_I_Size, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cbo_I_Size.SelectedValue);

            DataSet ds = new DataSet();
            ds = clsDbManager.GetData_Set(lSQL, "CatDtl");
            SizeColumn.DataSource = ds.Tables[0];
            SizeColumn.ValueMember = ds.Tables[0].Columns[0].ToString();
            SizeColumn.DisplayMember = ds.Tables[0].Columns[1].ToString();
            ds.Clear();

            //Color Combo Fill
            lSQL = "select cgdCode, cgdDesc from catdtl where cgcode=" + Convert.ToString((int)Category.enmColor);
            lSQL += " order by cgdDesc";

            clsFillCombo.FillCombo(cbo_I_Color, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cbo_I_Color.SelectedValue);

            ds = clsDbManager.GetData_Set(lSQL, "CatDtl");
            ColorColumn.DataSource = ds.Tables[0];
            ColorColumn.ValueMember = ds.Tables[0].Columns[0].ToString();
            ColorColumn.DisplayMember = ds.Tables[0].Columns[1].ToString();
            ds.Clear();

            //UOM Combo Fill
            lSQL = "select UOMID, UnitName from IMS_UOM order by UnitName";

            clsFillCombo.FillCombo(cbo_I_UOM, clsGVar.ConString1, "IMS_UOM" + "," + "UnitName" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cbo_I_UOM.SelectedValue);

            ds = clsDbManager.GetData_Set(lSQL, "IMS_UOM");
            UnitColumn.DataSource = ds.Tables[0];
            UnitColumn.ValueMember = ds.Tables[0].Columns[0].ToString();
            UnitColumn.DisplayMember = ds.Tables[0].Columns[1].ToString();
            ds.Clear();

            //Godown cOMBO
            lSQL = "select cgdCode, cgdDesc from catdtl where cgcode=" + Convert.ToString((int)Category.enmGodown);
            lSQL += " order by cgdDesc";

            clsFillCombo.FillCombo(cboGodown, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboGodown.SelectedValue);

            ds = clsDbManager.GetData_Set(lSQL, "IMS_UOM");
            GodownColumn.DataSource = ds.Tables[0];
            GodownColumn.ValueMember = ds.Tables[0].Columns[0].ToString();
            GodownColumn.DisplayMember = ds.Tables[0].Columns[1].ToString();
            ds.Clear();


            //Type combo
            lSQL = "select cgdCode, cgdDesc from catdtl where cgcode=" + Convert.ToString((int)Category.enmType);
            lSQL += " order by cgdDesc";

            clsFillCombo.FillCombo(cboType, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboType.SelectedValue);


            //LC cOMBO
            lSQL = "select cgdCode, cgdDesc from catdtl where cgcode=" + Convert.ToString((int)Category.enmLC);
            lSQL += " order by cgdDesc";

            clsFillCombo.FillCombo(cboLC, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboLC.SelectedValue);

            //Item group cOMBO
            lSQL = "select cgdCode, cgdDesc from catdtl where cgcode=" + Convert.ToString((int)Category.enmItemGroup);
            lSQL += " order by cgdDesc";

            clsFillCombo.FillCombo(cboItemGroup, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboItemGroup.SelectedValue);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mskSalesCodeCR_MouseDoubleClick(object sender, MouseEventArgs e)
        
        {
            LookUp_GL();
        }

        private void LookUp_GL()
        {
            //SELECT Code, Name FROM Heads WHERE TYPE = 'A'
            frmLookUp sForm = new frmLookUp(
                    "Code",
                    "Name",
                    "Customer",
                    this.Text.ToString(),
                    1,
                    " Code, Name",
                    "16,40",
                    " T, T",
                    true,
                    "",
                    "",
                    "TextBox"
                    );

           mskSalesCodeCR.Mask = "";
           mskSalesCodeCR.Text = string.Empty;
            mskSalesCodeCR.Mask = clsGVar.maskGLCode;

            sForm.lupassControl = new frmLookUp.LUPassControl(PassData);
            sForm.ShowDialog();
            if (mskSalesCodeCR.Text != null)
            {
                if (mskSalesCodeCR.Text != null)
                {
                    if (mskSalesCodeCR.Text.ToString() == "" || mskSalesCodeCR.Text.ToString() == string.Empty)
                    {
                        return;
                    }
                    if (mskSalesCodeCR.Text.ToString().Trim().Length > 0)
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
            mskSalesCodeCR.Mask = "";
            mskSalesCodeCR.Text = ((TextBox)sender).Text;
            mskSalesCodeCR.Mask = clsGVar.maskGLCode;
            //mskCustomerCode.Text = ((MaskedTextBox)sender).Text;
            //mskCustomerCode.Mask = clsGVar.maskGLCode;

        }

        //Populate Recordset 
        private void PopulateRecordsGL()
        {
            DataSet ds = new DataSet();
            DataRow dRow;
            string tSQL = string.Empty;

            // Fields 0,1,2,3 are Begin  

            tSQL = "SELECT Name ";
            tSQL += " from Customer ";
            tSQL += " where Code ='" + mskSalesCodeCR.Text.ToString() + "';";

            try
            {
                ds = clsDbManager.GetData_Set(tSQL, "Customer");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    //fAlreadyExists = true;
                    dRow = ds.Tables[0].Rows[0];
                    // Starting title as 0
                    lblNameUp.Text = (ds.Tables[0].Rows[0]["Name"] == DBNull.Value ? "" : ds.Tables[0].Rows[0]["Name"].ToString());
                    
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


        private void mskSalesCodeCR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                LookUp_GL();
            }
        }

        private void mskCustomerCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                LookUp_GL1();
            }

        }

        private void mskCustomerCode_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LookUp_GL1();
        }



        private void LookUp_GL1()
        {
            //SELECT Code, Name FROM Heads WHERE TYPE = 'A'
            frmLookUp sForm = new frmLookUp(
                    "Code",
                    "Name",
                    "Customer",
                    this.Text.ToString(),
                    1,
                    " Code, Name",
                    "16,40",
                    " T, T",
                    true,
                    "",
                    " Type='A'",
                    "TextBox"
                    );

            mskCustomerCode.Mask = "";
            mskCustomerCode.Text = string.Empty;
            mskCustomerCode.Mask = clsGVar.maskGLCode;

            sForm.lupassControl = new frmLookUp.LUPassControl(PassData1);
            sForm.ShowDialog();
            if (mskCustomerCode.Text != null)
            {
                if (mskCustomerCode.Text != null)
                {
                    if (mskCustomerCode.Text.ToString() == "" || mskCustomerCode.Text.ToString() == string.Empty)
                    {
                        return;
                    }
                    if (mskCustomerCode.Text.ToString().Trim().Length > 0)
                    {
                        PopulateRecordsGL1();
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

        private void PassData1(object sender)
        {
            mskCustomerCode.Mask = "";
            mskCustomerCode.Text = ((TextBox)sender).Text;
            mskCustomerCode.Mask = clsGVar.maskGLCode;
            //mskCustomerCode.Text = ((MaskedTextBox)sender).Text;
            //mskCustomerCode.Mask = clsGVar.maskGLCode;

        }

        //Populate Recordset 
        private void PopulateRecordsGL1()
        {
            DataSet ds = new DataSet();
            DataRow dRow;
            string tSQL = string.Empty;

            // Fields 0,1,2,3 are Begin  

            tSQL = "SELECT Name ";
            tSQL += " from Customer ";
            tSQL += " where Code ='" + mskCustomerCode.Text.ToString() + "';";

            try
            {
                ds = clsDbManager.GetData_Set(tSQL, "Customer");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    //fAlreadyExists = true;
                    dRow = ds.Tables[0].Rows[0];
                    // Starting title as 0
                    lblNameBottom.Text = (ds.Tables[0].Rows[0]["Name"] == DBNull.Value ? "" : ds.Tables[0].Rows[0]["Name"].ToString());
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

        private void frmSales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
       
        

       

        private void txtSaleNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
               
            }
        }

        private void txtSaleNo_DoubleClick(object sender, EventArgs e)
        {
            
        }

     

       
        

        private void txtGateOutward_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                
            }
        }

        private void txtGateOutward_DoubleClick(object sender, EventArgs e)
        {
            
        }

        
          
    }
}

       


       

      
     

    