using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GUI_Task.Class;
using JThomas.Controls;
using GUI_Task.StringFun01;

namespace GUI_Task
{
    enum GColIstm
    {
        ItemID = 0,
        ItemCode = 1,
        ItemName = 2,
        SizeName = 4,
        ColorName = 5,
        UnitName = 6,
        MinLevel = 7,
        MaxLevel = 8,
        CurrentStock = 9,
        SizeID = 10,
        ColorID = 11,
        UOMID = 12,
        //GodownID = 12
    }

    public partial class frmItemsStockLevelDetail : Form
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
        List<string> fManySQL = null;                      // List string for storing Multiple Queri
        string fRptTitle = string.Empty;
        //bool fFormClosing = false;

        bool ftTIsBalloon = true;
        bool fEditMod = false;
        int fEditRow = 0;
        //bool fFrmLoading = true;                    // Form is Loading Controls (to accomodate Load event so that first time loading requirement is done)
        int fTErr = 0;                              // Total Errors while Saving or other operation.
        string ErrrMsg = string.Empty;              // To display error message if any.
        string fLastID = string.Empty;              // Last Voucher/Doc ID (Saved new or modified)
        //
        //int fDocTypeID = 1;                         // Voucher/Doc Type ID
        int fDocFiscal = 1;                         // Accounting / Fiscal Period    
        //int fTNOA = 0;                              // Total Number of Attachments.    
        int fTNOT = 0;                              // Total Number of Grid Transactions.
        decimal fDocAmt = 0;                        // Document Amount Debit or Credit for DocMaster Field.
        string fDocWhere = string.Empty;            // Where string to build where clause for Voucher level
        int fLastRow = 0;                           // Last row number of the grid.
        Int64 fDocID = 1;
        bool fGridControl = false;                  // To overcome Grid's tabing

        bool fSingleEntryAllowed = true;            // for the time being later set to false.
        bool fDocAlreadyExists = false;             // Check if Doc/voucher already exists (Edit Mode = True, New Mode = false)
        bool fIDConfirmed = false;                  // Account ID is valid and existance in Table is confirmed.
        bool fCellEditMode = false;                 // Cell Edit Mode

        bool blnFormLoad = true;
        int fcboDefaultValue = 0;
        public frmItemsStockLevelDetail()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmItemsStockLevelDetail_Load(object sender, EventArgs e)
        {
            AtFormLoad();
            this.MaximizeBox = false;
            blnFormLoad = false;
        }

        private void AtFormLoad()
        {
            string lSQL = string.Empty;

            SettingGridVariable();
            LoadInitialControls();

            this.KeyPreview = true;


            ////Emp Code Combo Fill
            //lSQL = "SELECT employeeid, first_name +' '+ last_name AS EmpName FROM PR_Employee ";
            ////lSQL += " order by cgdDesc";

            //clsFillCombo.FillCombo(cboEmpCode, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", lSQL);
            //fcboDefaultValue = Convert.ToInt16(cboEmpCode.SelectedValue);


            ////Gate cOMBO
            //lSQL = "select cgdCode, cgdDesc from catdtl where cgcode=" + Convert.ToString((int)Category.enmShift);
            //lSQL += " order by cgdDesc";

            //clsFillCombo.FillCombo(cboShift, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", lSQL);
            //fcboDefaultValue = Convert.ToInt16(cboShift.SelectedValue);

            //Category Combo Fill
            lSQL = "SELECT DISTINCT 1,RIGHT(Itemcode,1) FROM Item ";
            //lSQL += " order by cgdDesc";

            clsFillCombo.FillCombo(cboCategory, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboCategory.SelectedValue);

            //Item group cOMBO
            lSQL = "select cgdCode, cgdDesc from catdtl where cgcode=" + Convert.ToString((int)Category.enmItemGroup);
            lSQL += " order by cgdDesc";

            clsFillCombo.FillCombo(cboItemGroup, clsGVar.ConString1, "CatDtl" + "," + "cgdCode" + "," + "False", lSQL);
            fcboDefaultValue = Convert.ToInt16(cboItemGroup.SelectedValue);



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


        }


        private void LoadInitialControls()
        {
            // 1 = dGV Grid Control
            // 2 = Column Total (Total number of Columns for cross verification with other parameters like width, format)
            // 3 = Column Header
            // 4 = Column Width to be displayed on Grid
            // 5 = Column MaxInputLen   // 0 = unlimited, 
            // 6 = Column Format        // T = Text, N = Numeric, H = Hiden
            // 7 = Column ReadOnly      // 1 = ReadOnly, 0 = Not ReadOnly
            // 8 = Grid Color Scheme    // Default = 1
            // RO 
            grd.Rows.Clear();
            grd.Columns.Clear();

            List<string> lMask = null; //new List<string>;
            List<string> lCboFillType = null; //new List<string>;
            List<string> lCboTableKeyField = null; //new List<string>;
            List<string> lCboQry = null; //new List<string>;

            clsDbManager.SetGridHeaderCmb(
                grd,
                12,
                fHDR,
                fColWidth,
                fColMaxInputLen,
                fColMinWidth,
                fColFormat,
                fColReadOnly,
                "DATA",
                lMask,
                lCboFillType,
                lCboTableKeyField,
                lCboQry,
                false,
                2);

        }

        private void LoadGridData()
        {
            string lSQL = "";
            
            lSQL += " SELECT sld.ItemId AS Code, i.ItemCode, i.Name AS ItemName, sz.cgdDesc AS SizeName, ";
            lSQL += " clr.cgdDesc AS ColorName,  u.UnitName, sld.SizeID, sld.ColorID, ";
            lSQL += " i.UOMID  from StockLevelDetail sld INNER JOIN Item i ON sld.ItemId=i.ItemId ";
            lSQL += " JOIN CatDtl clr ON sld.ColorID=clr.cgdCode AND clr.cgCode=3 ";
            lSQL += " INNER JOIN CatDtl sz ON sld.sizeid=sz.cgdCode AND sz.cgCode=5 ";
            lSQL += " INNER JOIN IMS_UOM u ON i.UOMID=u.UOMID ";
            lSQL += " where sld.StockLevelId ='" + txtStockLevelNo.Text.ToString() + "'; ";

            clsDbManager.FillDataGrid(
                grd,
                lSQL,
                fFieldList,
                fColFormat);
        }


        private void PopulateRecords()
        {
            DataSet ds = new DataSet();
            DataRow dRow;
            string tSQL = string.Empty;

            // Fields 0,1,2,3 are Begin  


            tSQL = "select sl.StockLevelId, sl.Date, cd.cgdDesc AS ItemGroupName, sl.Note, sl.ItemGroupID ";
            tSQL += "from StockLevel sl inner join StockLevelDetail sld on sl.StockLevelId=sld.StockLevelId ";
            tSQL += " inner join CatDtl cd on sl.ItemGroupID=cd.cgdCode AND cd.cgCode=6";
            tSQL += " where sl.StockLevelId='" + txtStockLevelNo.Text.ToString() + "';";
            try
            {
                ds = clsDbManager.GetData_Set(tSQL, "StockLevel");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dRow = ds.Tables[0].Rows[0];
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        ds.Clear();
                    }
                    LoadGridData();
                }
            }
            catch
            {
                MessageBox.Show("Unable to Get Account Code...", this.Text.ToString());
            }
        }


        private void txtStockLevelNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                LookUp_Voc();
            }
        }



        private void txtStockLevelNo_DoubleClick(object sender, EventArgs e)
        {
            LookUp_Voc();
        }
        #region LookUp_Voc

        private void LookUp_Voc()
        {

            //string pSource,
            //int pRow,
            //int pCol

            // MessageBox.Show("Lookup Source: " + pSource);

            // 1- KeyField
            // 2- Field List
            // 3- Table Name
            // 4- Form Title
            // 5- Default Find Field (Int) 0,1,2,3 etc Default = 1 = title field
            // 6- Grid Title List
            // 7- Grid Title Width
            // 8- Grid Title format T = Text, N = Numeric etc
            // 9- Bool One Table = True, More Then One = False
            // 10 Join String Otherwise Empty String.
            // 11 Optional Where
            // 11 Return Control Type TextBox or MaskedTextBox Default mtextBox
            //
            //select doc_id, doc_strid, doc_date, doc_remarks, doc_amt 
            //from gl_tran
            //where doc_vt_id=1 and doc_fiscal_id=1

            //SELECT d.Ord_No, d.Cont_No, d.Ord_Date, h.Name AS CustName, d.Qty, d.Amount, d.Category
            //FROM Ord_Det d INNER JOIN Heads h ON d.Customer=h.Code
            //WHERE d.Category = 1
//                    "d.DNId",
//                    "d.Date, ig.cgdDesc AS ItemGroupName, pd.department_name, " 
//                    + "pe.first_name + ' ' + pe.last_name AS EmpName, d.Note ",
//                    "DN d INNER JOIN CatDtl ig ON d.ItemGroupId=ig.cgdCode AND ig.cgCode=6 "
//                    + "INNER JOIN PR_Department pd ON d.DepartmentId=pd.departmentid " 
//                    + "INNER JOIN PR_Employee pe ON d.EmployeeId=pe.employeeid",
//                    this.Text.ToString(),
//                    1,
//                    "DN#,Date,Item Group Name,Department Name,Employee Name,Note ",
//                    "10,8,12,12,12,15",
//                    " T, T, T, T, T, T",
//                    true,
//                    "",

//            select sl.StockLevelId, sl.Date, cd.cgdDesc AS ItemGroupName, sl.Note 
//from StockLevel sl inner join StockLevelDetail sld on sl.StockLevelId=sld.StockLevelId
//inner join CatDtl cd on sl.ItemGroupID=cd.cgdCode AND cd.cgCode=6

            frmLookUp sForm = new frmLookUp(
                    "sl.StockLevelId",
                " sl.Date, cd.cgdDesc AS ItemGroupName, sl.Note ",
                "  StockLevel sl inner join StockLevelDetail sld on sl.StockLevelId=sld.StockLevelId "
                + " inner join CatDtl cd on sl.ItemGroupID=cd.cgdCode AND cd.cgCode=6",
                    this.Text.ToString(),
                    1,
                    "Stock #,Date,Item Group Name,Note",
                    "12,8,15,20",
                    " T, T, T, T",
                    true,
                    "",
                //"d.Category = " + cboMainGroup.SelectedValue.ToString(), 
                    "",
                    "TextBox"
                    );
            txtStockLevelNo.Text = string.Empty;
            sForm.lupassControl = new frmLookUp.LUPassControl(PassDataVocID);
            sForm.ShowDialog();

            if (txtStockLevelNo.Text != null)
            {
                if (txtStockLevelNo.Text != null)
                {
                    if (txtStockLevelNo.Text.ToString() == "" || txtStockLevelNo.Text.ToString() == string.Empty)
                    {
                        return;
                    }
                    if (txtStockLevelNo.Text.ToString().Trim().Length > 0)
                    {
                        PopulateRecords();
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
        #endregion

        private void PassDataVocID(object sender)
        {
            //txtPassDataVocID.Text = ((TextBox)sender).Text;
            txtStockLevelNo.Text = ((TextBox)sender).Text;
            //msk_VocCode.Text = ((MaskedTextBox)sender).Text;
        }

        

        
        #region Color ForeGround/Background

        //private class CellBackColorAlternate : SourceGrid.Cells.Views.Cell
        //{
        //    public CellBackColorAlternate(Color firstColor, Color secondColor)
        //    {
        //        FirstBackground = new DevAge.Drawing.VisualElements.BackgroundSolid(firstColor);
        //        SecondBackground = new DevAge.Drawing.VisualElements.BackgroundSolid(secondColor);
        //    }

        //    private DevAge.Drawing.VisualElements.IVisualElement mFirstBackground;
        //    public DevAge.Drawing.VisualElements.IVisualElement FirstBackground
        //    {
        //        get { return mFirstBackground; }
        //        set { mFirstBackground = value; }
        //    }

        //    private DevAge.Drawing.VisualElements.IVisualElement mSecondBackground;
        //    public DevAge.Drawing.VisualElements.IVisualElement SecondBackground
        //    {
        //        get { return mSecondBackground; }
        //        set { mSecondBackground = value; }
        //    }

        //    protected override void PrepareView(SourceGrid.CellContext context)
        //    {
        //        base.PrepareView(context);

        //        if (Math.IEEERemainder(context.Position.Row, 2) == 0)
        //            Background = FirstBackground;
        //        else
        //            Background = SecondBackground;
        //    }
        //}

        //private class CheckBoxBackColorAlternate : SourceGrid.Cells.Views.CheckBox
        //{
        //    public CheckBoxBackColorAlternate(Color firstColor, Color secondColor)
        //    {
        //        FirstBackground = new DevAge.Drawing.VisualElements.BackgroundSolid(firstColor);
        //        SecondBackground = new DevAge.Drawing.VisualElements.BackgroundSolid(secondColor);
        //    }

        //    private DevAge.Drawing.VisualElements.IVisualElement mFirstBackground;
        //    public DevAge.Drawing.VisualElements.IVisualElement FirstBackground
        //    {
        //        get { return mFirstBackground; }
        //        set { mFirstBackground = value; }
        //    }

        //    private DevAge.Drawing.VisualElements.IVisualElement mSecondBackground;
        //    public DevAge.Drawing.VisualElements.IVisualElement SecondBackground
        //    {
        //        get { return mSecondBackground; }
        //        set { mSecondBackground = value; }
        //    }

        //    protected override void PrepareView(SourceGrid.CellContext context)
        //    {
        //        base.PrepareView(context);

        //        if (Math.IEEERemainder(context.Position.Row, 2) == 0)
        //            Background = FirstBackground;
        //        else
        //            Background = SecondBackground;
        //    }

        //}
        #endregion

        private void chkReadOnly_CheckedChanged(object sender, EventArgs e)
        {
            //DataSet ds = new DataSet();
            //string tSQL = string.Empty;
            //tSQL = "SELECT cgdDesc FROM CatDtl WHERE cgCode=" + Convert.ToString((int)Category.enmColor);
            //ds = clsDbManager.GetData_Set(tSQL, "CatDtl");
            //int count = ds.Tables[0].Rows.Count;
            //string[] a_Color = new string[count];

            //for (int i = 0; i < count; i++)
            //{
            //    a_Color[i] = ds.Tables[0].Rows[i]["cgdDesc"].ToString();
            //}
            //ds.Dispose();
            //ds.Clear();

            //SourceGrid.Cells.Editors.EditorBase mEditor_Color;
            //mEditor_Color = new SourceGrid.Cells.Editors.ComboBox(typeof(string), a_Color, false);
            //mEditor_Color.EditableMode = SourceGrid.EditableMode.Focus | SourceGrid.EditableMode.AnyKey | SourceGrid.EditableMode.SingleClick;

            //for (int r = 1; r < grid1.RowsCount - 1; r++)
            //    for (int c = 0; c < grid1.ColumnsCount; c++)
            //    {
            //        if (grid1[2, 3].Editor != null)
            //            grid1[2, 4].Editor.EnableEdit = true;
            //        //grid1[r, c].Editor.EnableEdit = !chkReadOnly.Checked;
            //    }
        }


        private void SettingGridVariable()
        {

            string lHDR = "";                       // Column Header
            string lColWidth = "";                  // Column Width (Input)
            string lColMinWidth = "";               // Column Minimum Width
            string lColMaxInputLen = "";            // Column Visible Length/Width 
            string lColFormat = "";                 // Column Format  
            string lColReadOnly = "";               // Column ReadOnly 1 = ReadOnly, 0 = Read-Write  
            string lFieldList = "";
            string tColType = "";
            string tFieldName = "";

            //
            lFieldList = "Code";                //  0-    ItemID";       
            lFieldList += ",ItemCode";            //  1-    ItemCode";     
            lFieldList += ",ItemName";            //  2-    ItemName"; 
            lFieldList += ",SizeName";            //  4-    SizeName";       
            lFieldList += ",ColorName";           //  5-    ColorName";      
            lFieldList += ",UnitName";            //  6-    UOMName";
            lFieldList += ",MinLevel";          // 7- GodownName
            lFieldList += ",MaxLevel";                   // 8- Qty
             lFieldList += ",CurrentStock";           // 3- Description
            lFieldList += ",SizeID";              // 9    SizeID";     
            lFieldList += ",ColorID";             // 10    ColorID";     
            lFieldList += ",UOMID";               // 11    UOMID"; 
            //lFieldList += ",GodownId";              // 12- GodownID

            lHDR += "Item ID";             //  0-    ItemID";      
            lHDR += ",Item Code";            //  1-    ItemCod     
            lHDR += ",Item Name";            //  2-    ItemNam 
            lHDR += ",Size";                 //  4-    SizeNam     
            lHDR += ",Color";                //  5-    ColorNa     
            lHDR += ",UOM Name";             //  6-    UOMName
            lHDR += ",MinLevel";               // 7- GodownName
            lHDR += ",MaxLevel";                    // 8- Qty
            lHDR += ",CurrentStock";            // 3- Descripti
            lHDR += ",SizeID";               // 9    SizeID";    
            lHDR += ",ColorID";              // 10    ColorID"    
            lHDR += ",UOMID";                // 11    UOMID"; 
           // lHDR += ",GodownId";               // 12- GodownID

            // Col Visible Width
            lColWidth = "   5";                 //  0-    ItemID";        
            lColWidth += ",12";                   //  1-    ItemCod";     
            lColWidth += ",20";                 //  2-    ItemNam; 
            lColWidth += ",10";                     // 3- Descripti
            lColWidth += ", 7";                   //  4-    SizeNam       
            lColWidth += ", 7";                   //  5-    ColorNa;      
            lColWidth += ", 7";                   //  6-    UOMName
            lColWidth += ", 7";                   // 7- GodownName
            lColWidth += ", 5";                     // 8- Qty
            lColWidth += ", 5";                   // 9    SizeID";      
            lColWidth += ", 5";                   // 10    ColorID";     
            lColWidth += ", 5";                   // 11    UOMID"; 
            //lColWidth += ", 5";                     // 12- GodownID

            // Column Input Length/Width
            lColMaxInputLen = "  0";                 //  0-    ItemID";    
            lColMaxInputLen += ", 0";                  //  1-    ItemCod   
            lColMaxInputLen += ", 0";                  //  2-    ItemNam
            lColMaxInputLen += ", 0";                    // 3- Descripti
            lColMaxInputLen += ", 0";                  //  4-    SizeNam   
            lColMaxInputLen += ", 0";                  //  5-    ColorNa   
            lColMaxInputLen += ", 0";                  //  6-    UOMName
            lColMaxInputLen += ", 0";                  // 7- GodownName
            lColMaxInputLen += ", 0";                    // 8- Qty
            lColMaxInputLen += ", 0";                  // 9    SizeID";  
            lColMaxInputLen += ", 0";                  // 10    ColorID"  
            lColMaxInputLen += ", 0";                  // 11    UOMID"; 
            //lColMaxInputLen += ", 0";                    // 12- GodownID

            // Column Min Width
            lColMinWidth = "   0";                      //  0-    ItemID";       
            lColMinWidth += ", 0";                        //  1-    ItemCod;     
            lColMinWidth += ", 0";                        //  2-    ItemNam; 
            lColMinWidth += ", 0";                          // 3- Descripti
            lColMinWidth += ", 0";                        //  4-    SizeNam      
            lColMinWidth += ", 0";                        //  5-    ColorNa      
            lColMinWidth += ", 0";                        //  6-    UOMName
            lColMinWidth += ", 0";                        // 7- GodownName
            lColMinWidth += ", 0";                          // 8- Qty
            lColMinWidth += ", 0";                        // 9    SizeID";     
            lColMinWidth += ", 0";                        // 10    ColorID"     
            lColMinWidth += ", 0";                        // 11    UOMID"; 
            //lColMinWidth += ", 0";                          // 12- GodownID

            // Column Format
            lColFormat = "   T";                       //  0-    ItemID";       
            lColFormat += ", T";                         //  1-    ItemCod     
            lColFormat += ", T";                         //  2-    ItemNam 
            lColFormat += ", T";                           // 3- Descripti
            lColFormat += ", T";                         //  4-    SizeNam     
            lColFormat += ", T";                         //  5-    ColorNa     
            lColFormat += ", T";                         //  6-    UOMName
            lColFormat += ", T";                         // 7- GodownName
            lColFormat += ", T";                           // 8- Qty
            lColFormat += ", T";                         // 9    SizeID";    
            lColFormat += ", H";                         // 10    ColorID"    
            lColFormat += ", H";                         // 11    UOMID"; 
            //lColFormat += ", H";                           // 12- GodownID

            // Column ReadOnly 1= readonly, 0 = read-write
            lColReadOnly = "  0";                       //  0-    ItemID";      
            lColReadOnly += ",1";                         //  1-    ItemCod     
            lColReadOnly += ",1";                         //  2-    ItemNam
            lColReadOnly += ",0";                           // 3- Descripti
            lColReadOnly += ",0";                         //  4-    SizeNam     
            lColReadOnly += ",0";                         //  5-    ColorNa     
            lColReadOnly += ",0";                         //  6-    UOMName
            lColReadOnly += ",0";                         // 7- GodownName
            lColReadOnly += ",0";                           // 8- Qty
            lColReadOnly += ",1";                         // 9    SizeID";    
            lColReadOnly += ",1";                         // 10    ColorID"    
            lColReadOnly += ",1";                         // 11    UOMID"; 
            //lColReadOnly += ",1";                           // 12- GodownID

            // For Saving Time
            tColType += "  N0";             //  0-    ItemID"; 
            tColType += ",SKP";               //  1-    ItemCod
            tColType += ",SKP";               //  2-    ItemNam
            tColType += ",SKP";                  // 3- Descripti
            tColType += ",SKP";               //  4-    SizeNam
            tColType += ",SKP";               //  5-    ColorNa
            tColType += ",SKP";               //  6-    UOMName
            tColType += ",N0";               // 7- GodownName
            tColType += ", N0";                 // 8- Qty
            tColType += ", N0";               // 9    SizeID"; 
            tColType += ", N0";               // 10    ColorID"
            tColType += ", N0";               // 11    UOMID"; 
            //tColType += ", N0";                 // 12- GodownID

            tFieldName += "Code";                //  0-    ItemID";       
            tFieldName += ",ItemCode";             //  1-    ItemCode";     
            tFieldName += ",ItemName";             //  2-    ItemName"; 
            tFieldName += ",SizeName";             //  4-    SizeNamD";       
            tFieldName += ",ColorName";            //  5-    ColorNaID";      
            tFieldName += ",UnitName";             //  6-    UOMNameD"; 
            tFieldName += ",MinLevel";           // 7- GodownName
            tFieldName += ",MaxLevel";                    // 8- Qty
            tFieldName += ",CurrentStock";            // 3- Descripti
            tFieldName += ",SizeID";               // 9    SizeID";     
            tFieldName += ",ColorID";              // 10    ColorID";     
            tFieldName += ",UOMID";              // 11    UOMID"; 
            //tFieldName += ",GodownID";               // 12- GodownID

            fHDR = lHDR;
            fColWidth = lColWidth;
            fColMaxInputLen = lColMaxInputLen;
            fColMinWidth = lColMinWidth;
            fColFormat = lColFormat;
            fColReadOnly = lColReadOnly;
            fFieldList = lFieldList;

            fColType = tColType;
            fFieldName = tFieldName;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            grd.Rows.Add(txt_I_ItemID.Text.ToString(),
                lbl_I_ItemCode.Text.ToString(),
                lbl_I_ItemName.Text.ToString(),
                cbo_I_Size.Text.ToString(),
                cbo_I_Color.Text.ToString(),
                cbo_I_UOM.Text.ToString(),
                txtMinLevel.Text.ToString(),
                txtMaxLevel.Text.ToString(),
                txtCurrentStock.Text.ToString(),
                //cboGodown.Text.ToString(),
                //txtQty.Text.ToString(),
                cbo_I_Size.SelectedValue.ToString(),
                cbo_I_Color.SelectedValue.ToString(),
                cbo_I_UOM.SelectedValue.ToString());
                //cboGodown.SelectedValue.ToString()

            SumVoc();
        }
        private int GridTNOT(DataGridView pdGv)
        {
            int rtnValue = 0;
            try
            {
                //
                for (int dGVRow = 0; dGVRow < pdGv.Rows.Count; dGVRow++)
                {
                    if (pdGv.Rows[dGVRow].Cells[(int)GCol.ItemID].Value == null)
                    {
                        if (dGVRow == fLastRow)
                        {
                            break;
                        }
                    }
                    else
                    {
                        if ((pdGv.Rows[dGVRow].Cells[(int)GCol.ItemID].Value.ToString()).Trim(' ', '-') == "")
                        {
                            if (dGVRow == fLastRow)
                            {
                                break;
                            }
                        }
                    }

                    rtnValue++;
                } // End For loopo
                return rtnValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save Grid TNOT: " + ex.Message, this.Text.ToString());
                return rtnValue;
            }
        }
        private void ClearThisForm()
        {
            if (grd.Rows.Count > 0)
            {
                grd.Rows.Clear();
            }
            ResetFields();
        }

        private void ResetFields()
        {
            // Reset Form Level Variables/Fields
            fEditMod = false;
            fTNOT = 0;
            fDocAmt = 0;
            fDocWhere = string.Empty;
            fLastRow = 0;
        }

        private void SumVoc()
        {
            bool bcheck;
            decimal fQty = 0;
            decimal fAmount = 0;
            decimal rtnVal = 0;
            decimal outValue = 0;

        }
        private void cmdSave_Click(object sender, EventArgs e)
        {
            SaveData();
            MessageBox.Show("Data Saved Successfullly");
            //}
        }
        private bool FormValidation()
        {
            bool lRtnValue = true;
            DateTime lNow = DateTime.Now;
            decimal lDebit = 0;
            decimal lCredit = 0;
            fDocAmt = 0;
            try
            {
                SumVoc();

                return lRtnValue;

            }
            catch (Exception ex)
            {
                fTErr++;
                ErrrMsg = StrF01.BuildErrMsg(ErrrMsg, "Exception: FormValidation -> " + ex.Message.ToString());
                return false;
            }
        }

        private bool SaveData()
        {
            bool rtnValue = true;
            fTErr = 0;
            if (fManySQL != null)
            {
                if (fManySQL.Count() > 0)
                {
                    fManySQL.Clear();
                }
            }
            string lSQL = string.Empty;
            DateTime lNow = DateTime.Now;
            try
            {
                ErrrMsg = "";
                if (grd.Rows.Count < 1)
                {
                    fTErr++;
                    MessageBox.Show("No transaction in grid to Save", "Save: " + this.Text.ToString());
                    return false;
                }
                fLastRow = grd.Rows.Count - 1;
                if (!FormValidation())
                {
                    textAlert.Text = "Form Validation Error: Not Saved." + "  " + lNow.ToString();
                    MessageBox.Show(ErrrMsg, "Save: " + this.Text.ToString());
                    return false;
                }

                fManySQL = new List<string>();

                // Prepare Master Doc Query List
                fTNOT = GridTNOT(grd);
                if (!PrepareDocMaster())
                {
                    textAlert.Text = "DocMaster: Modifying Doc/Voucher not available for updation.'  ...." + "  " + lNow.ToString();
                    //tabMDtl.SelectedTab = tabError;
                    return false;
                }
                //
                if (grd.Rows.Count > 0)
                {
                    // Prepare Detail Doc Query List
                    if (!PrepareDocDetail())
                    {
                        return false;
                    }
                }
                else
                {
                    DateTime now = DateTime.Now;
                    textAlert.Text = "selected Box Empty... " + now.ToString("T");
                    // pending return false;
                }
                // Execute Query
                if (fManySQL.Count > 0)
                {
                    if (!clsDbManager.ExeMany(fManySQL))
                    {
                        MessageBox.Show("Not Saved see log...", this.Text.ToString());
                        return false;
                    }
                    else
                    {
                        fLastID = txtStockLevelNo.Text.ToString();
                        ClearThisForm();
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("Data Preparation list empty, Not Saved...", this.Text.ToString());
                    return false;
                } // End Execute Query
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Processing Save: " + ex.Message, "Save Data: " + this.Text.ToString());
                return false;
            }

        } // End Save

        private bool PrepareDocMaster()
        {
            bool rtnValue = true;
            string lSQL = string.Empty;

            try
            {
                if (txtStockLevelNo.Text.ToString().Trim(' ', '-') == "")
                {
                    fDocAlreadyExists = false;
                    fDocID = clsDbManager.GetNextValDocID("StockLevel", "StockLevelId", fDocWhere, "");

                    lSQL = "insert into StockLevel (";
                    lSQL += "  StockLevelId ";                              //  0-    ItemID";   
                   // lSQL += ", GateInwordNo ";                                //  1-    ItemCod  
                    lSQL += ", Date ";                                        //  2-    ItemNam 
                    //lSQL += ", VendorId ";                                      // 3- Descripti
                                                           //  4-    SizeNam  
                    lSQL += ", ItemGroupId ";                                 //  5-    ColorNa  
                    lSQL += ", Note "; 
                    //lSQL += ", GateId ";                                      //  6-    UOMName
                    lSQL += ", UserId ";                                      // 7- GodownName
                    lSQL += ", OrgId ";                                         // 8- Qty
                    //lSQL += ", Status ";                                      // 9    SizeID";   
                    lSQL += ", BranchId ";                                    // 10    ColorID"  
                    //lSQL += ", Disc2 ";                                     // 11    UOMID"; 
                    //lSQL += ", Adda ";                                        // 12- GodownID
                    lSQL += " ) values (";
                    //                                                       
                    lSQL += "'" + fDocID.ToString() + "'";                  //  0-    ItemID";   
                    lSQL += ",'" + txtStockLevelNo.Text.ToString() + "";        //  1-    ItemCod  
                    lSQL += ", " + StrF01.D2Str(dtpStockLevel) + "";          //  2-    ItemNam 
                    lSQL += ",";                                              // 3- Descripti
                    lSQL += ",'" + txtNote + "'";                             //  4-    SizeNam  
                    lSQL += ", " + cboItemGroup.SelectedValue.ToString() + "";  //  5-    ColorNa  
                    lSQL += ", 1";                                            //  6-    UOMName
                    lSQL += ", 0";                                            // 7- GodownName
                    lSQL += ", 1";                                              // 8- Qty
                    lSQL += ", 0";                                             // 9    SizeID";   
                    lSQL += ", 1";                                            // 10    ColorID"  
                    lSQL += ")";                                              // 11    UOMID"; 
                }                                                               // 12- GodownID
                else
                {
                    fDocWhere = " StockLevelId = '" + txtStockLevelNo.Text.ToString() + "'";
                    if (clsDbManager.IDAlreadyExistWw("StockLevel", "StockLevelId", fDocWhere))
                    {

                        fDocAlreadyExists = true;
                        lSQL = "delete from StockLevelDetail ";
                        lSQL += " where " + fDocWhere;

                        fManySQL.Add(lSQL);
                        //
                    }

                    lSQL = "update StockLevel set";
                    lSQL += "  Date = '" + StrF01.D2Str(dtpStockLevel.Value) + "'";
                    lSQL += ", ItemGroupID = " + cboItemGroup.SelectedValue.ToString() + "";
                    lSQL += ", Note = '" + txtNote.Text.ToString() + "'";
                    lSQL += ", UserId = 0";
                    lSQL += ", OrgId = 1";
      //              lSQL += ",VendorId = '' ";
                   
                    
    //                lSQL += ", GateID = 1";
                    
  //                  lSQL += ", Status = 0";
                    lSQL += ", BranchId = 1";
                    lSQL += " where ";
                    lSQL += fDocWhere;

                }
                fManySQL.Add(lSQL);


                return rtnValue;
            }
            catch (Exception ex)
            {
                rtnValue = false;
                MessageBox.Show("Save Master Doc: " + ex.Message, this.Text.ToString());
                return false;
            }
        }

        private bool PrepareDocDetail()
        {
            bool rtnValue = true;
            string lSQL = "";
            try
            {
                for (int dGVRow = 0; dGVRow < grd.Rows.Count; dGVRow++)
                {
                    if (grd.Rows[dGVRow].Cells[(int)GCol.ItemID].Value == null)
                    {
                        if (dGVRow == fLastRow)
                        {
                            continue;
                        }
                    }
                    else
                    {
                        if ((grd.Rows[dGVRow].Cells[(int)GCol.ItemID].Value.ToString()).Trim(' ', '-') == "")
                        {
                            //lBlank = true;
                            if (dGVRow == fLastRow)
                            {
                                continue;
                            }
                        }
                    }

                    lSQL = "INSERT INTO StockLevelDetail (StockLevelId";
                    lSQL += ",ItemId,SizeId,ColorID,MinLevel,MaxLevel)";
                    lSQL += " VALUES (";
                    lSQL += "'" + txtStockLevelNo.Text.ToString() + "'";
                    lSQL += ", " + grd.Rows[dGVRow].Cells[(int)GColIstm.ItemID].Value.ToString() + "";
                    lSQL += ", " + grd.Rows[dGVRow].Cells[(int)GColIstm.SizeID].Value.ToString() + "";
                    lSQL += ", " + grd.Rows[dGVRow].Cells[(int)GColIstm.ColorID].Value.ToString() + "";
                    lSQL += ", " + grd.Rows[dGVRow].Cells[(int)GColIstm.MinLevel].Value.ToString() + "";
                    lSQL += ", " + grd.Rows[dGVRow].Cells[(int)GColIstm.MaxLevel].Value.ToString() + "";
                    //lSQL += ", '" + grd.Rows[dGVRow].Cells[(int)GColIstm.Description].Value.ToString() + "'";
                    lSQL += ")";
                    fManySQL.Add(lSQL);
                } // End For loopo
                return rtnValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save Detail Doc: " + ex.Message, this.Text.ToString());
                return false;
            }


        }

        private void frmItemsStockLevelDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }



        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    grd.Rows.Add(txt_I_ItemID.Text.ToString(),
        //        lbl_I_ItemCode.Text.ToString(),
        //        lbl_I_ItemName.Text.ToString(),
        //        txtDescription.Text.ToString(),
        //        cbo_I_Size.Text.ToString(),
        //        cbo_I_Color.Text.ToString(),
        //        cbo_I_UOM.Text.ToString(),
        //        //cboGodown.Text.ToString(),
        //        txtQty.Text.ToString(),
        //        cbo_I_Size.SelectedValue.ToString(),
        //        cbo_I_Color.SelectedValue.ToString(),
        //        cbo_I_UOM.SelectedValue.ToString(),
        //        //cboGodown.SelectedValue.ToString());

        //    SumVoc();
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            MessageBox.Show("Data Saved Successfullly");
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            LookUp_Voc();
        }

        private void txt_I_ItemID_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmItemsHelpAuto frm = new frmItemsHelpAuto();
            frm.ShowDialog();

            txt_I_ItemID.Text = frm.Ret_ItemID.ToString();
            lbl_I_ItemCode.Text = frm.Ret_ItemCode.ToString();
            lbl_I_ItemName.Text = frm.Ret_ItemName.ToString();
        }

        private void txt_I_ItemID_KeyDown(object sender, KeyEventArgs e)
        {
            frmItemsHelpAuto frm = new frmItemsHelpAuto();
            frm.ShowDialog();

            txt_I_ItemID.Text = frm.Ret_ItemID.ToString();
            lbl_I_ItemCode.Text = frm.Ret_ItemCode.ToString();
            lbl_I_ItemName.Text = frm.Ret_ItemName.ToString();
        }

        private void btnEscExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
