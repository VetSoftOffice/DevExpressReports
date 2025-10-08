namespace DevExpressReports.Reports.Finance.Farms.Layer.Laying.SR_LAY_EndFlockExpenses_Exp
{
    partial class SR_LAY_EndFlockExpenses_Exp
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SR_LAY_EndFlockExpenses_Exp));
            DevExpress.XtraReports.Parameters.GroupLayoutItem groupLayoutItem1 = new DevExpress.XtraReports.Parameters.GroupLayoutItem("", false);
            DevExpress.XtraReports.Parameters.GroupLayoutItem groupLayoutItem2 = new DevExpress.XtraReports.Parameters.GroupLayoutItem("", true);
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.IsRTL = new DevExpress.XtraReports.Parameters.Parameter();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.dsFinance = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.tFooter = new DevExpress.XtraReports.UI.XRTable();
            this.trFooter = new DevExpress.XtraReports.UI.XRTableRow();
            this.tfTotal = new DevExpress.XtraReports.UI.XRTableCell();
            this.tfDebit_GPT = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tfCredit_GPT = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.FlockCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.dsFinance1 = new DevExpressReports.Reports.Finance.DataSets.dsFinance();
            this.sR_BRD_EndFlockExpenses_ExpTableAdapter = new DevExpressReports.Reports.Finance.DataSets.dsFinanceTableAdapters.SR_BRD_EndFlockExpenses_ExpTableAdapter();
            this.sR_FC_CustSuppSheet_OLDTableAdapter = new DevExpressReports.Reports.Finance.DataSets.dsFinanceTableAdapters.SR_FC_CustSuppSheet_OLDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFinance1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.BorderWidth = 0F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.SnapLinePadding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.StylePriority.UseBorderWidth = false;
            this.BottomMargin.StylePriority.UsePadding = false;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Title.Name = "Title";
            this.Title.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // DetailCaption1
            // 
            this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DetailCaption1.BorderColor = System.Drawing.Color.White;
            this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailCaption1.BorderWidth = 2F;
            this.DetailCaption1.ForeColor = System.Drawing.Color.White;
            this.DetailCaption1.Name = "DetailCaption1";
            this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData1
            // 
            this.DetailData1.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailData1.BorderWidth = 2F;
            this.DetailData1.ForeColor = System.Drawing.Color.Black;
            this.DetailData1.Name = "DetailData1";
            this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3_Odd
            // 
            this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailData3_Odd.BorderWidth = 1F;
            this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
            this.DetailData3_Odd.Name = "DetailData3_Odd";
            this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageInfo
            // 
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // IsRTL
            // 
            this.IsRTL.Name = "IsRTL";
            this.IsRTL.Type = typeof(bool);
            this.IsRTL.ValueInfo = "False";
            this.IsRTL.Visible = false;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            // 
            // xrTable3
            // 
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell11,
            this.xrTableCell16,
            this.xrTableCell9,
            this.xrTableCell12,
            this.xrTableCell19,
            this.xrTableCell24,
            this.xrTableCell25,
            this.xrTableCell26});
            this.xrTableRow2.Name = "xrTableRow2";
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Item]")});
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseBorders = false;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[RearValue]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n")});
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseBorders = false;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[RearPerc]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n")});
            this.xrTableCell11.Multiline = true;
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.StylePriority.UseBorders = false;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[RearValuePerHen]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n")});
            this.xrTableCell16.Multiline = true;
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.StylePriority.UseBorders = false;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LayValue]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n")});
            this.xrTableCell9.Multiline = true;
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.StylePriority.UseBorders = false;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LayPerc]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n")});
            this.xrTableCell12.Multiline = true;
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.StylePriority.UseBorders = false;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LayValuePerHen]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n")});
            this.xrTableCell19.Multiline = true;
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.StylePriority.UseBorders = false;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalValue]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n")});
            this.xrTableCell24.Multiline = true;
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.StylePriority.UseBorders = false;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell25.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalValuePerc]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n")});
            this.xrTableCell25.Multiline = true;
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.StylePriority.UseBorders = false;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell26.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalValuePerEgg]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n")});
            this.xrTableCell26.Multiline = true;
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.StylePriority.UseBorders = false;
            // 
            // dsFinance
            // 
            this.dsFinance.ConnectionName = "dsFinance";
            this.dsFinance.Name = "dsFinance";
            columnExpression1.ColumnName = "Item";
            table1.Name = "SR_BRD_EndFlockExpenses_Exp";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "RearValue";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "LayValue";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Name = "SR_BRD_EndFlockExpenses_Exp";
            selectQuery1.Tables.Add(table1);
            this.dsFinance.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.dsFinance.ResultSchemaSerializable = resources.GetString("dsFinance.ResultSchemaSerializable");
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable6,
            this.xrTable5,
            this.xrTable4,
            this.xrTable2,
            this.xrTable1});
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrTable6
            // 
            this.xrTable6.Name = "xrTable6";
            this.xrTable6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5});
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell21,
            this.xrTableCell22,
            this.xrTableCell23});
            this.xrTableRow5.Name = "xrTableRow5";
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.BackColor = System.Drawing.Color.White;
            this.xrTableCell21.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell21.Multiline = true;
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.StylePriority.UseBackColor = false;
            this.xrTableCell21.StylePriority.UseBorders = false;
            this.xrTableCell21.StylePriority.UseFont = false;
            this.xrTableCell21.StylePriority.UseTextAlignment = false;
            this.xrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.BackColor = System.Drawing.Color.White;
            this.xrTableCell22.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell22.Multiline = true;
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.StylePriority.UseBackColor = false;
            this.xrTableCell22.StylePriority.UseBorders = false;
            this.xrTableCell22.StylePriority.UseFont = false;
            this.xrTableCell22.StylePriority.UseTextAlignment = false;
            this.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.BackColor = System.Drawing.Color.White;
            this.xrTableCell23.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell23.Multiline = true;
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.StylePriority.UseBackColor = false;
            this.xrTableCell23.StylePriority.UseBorders = false;
            this.xrTableCell23.StylePriority.UseFont = false;
            this.xrTableCell23.StylePriority.UseTextAlignment = false;
            this.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTable5
            // 
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1});
            this.xrTableRow4.Name = "xrTableRow4";
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.BackColor = System.Drawing.Color.White;
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseBackColor = false;
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTable4
            // 
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell6,
            this.xrTableCell10,
            this.xrTableCell18});
            this.xrTableRow3.Name = "xrTableRow3";
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.BackColor = System.Drawing.Color.White;
            this.xrTableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseBackColor = false;
            this.xrTableCell6.StylePriority.UseBorders = false;
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.BackColor = System.Drawing.Color.White;
            this.xrTableCell10.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell10.Multiline = true;
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UseBackColor = false;
            this.xrTableCell10.StylePriority.UseBorders = false;
            this.xrTableCell10.StylePriority.UseFont = false;
            this.xrTableCell10.StylePriority.UseTextAlignment = false;
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.BackColor = System.Drawing.Color.White;
            this.xrTableCell18.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell18.Multiline = true;
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.StylePriority.UseBackColor = false;
            this.xrTableCell18.StylePriority.UseBorders = false;
            this.xrTableCell18.StylePriority.UseFont = false;
            this.xrTableCell18.StylePriority.UseTextAlignment = false;
            this.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTable2
            // 
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell15});
            this.xrTableRow1.Name = "xrTableRow1";
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseBorders = false;
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseBorders = false;
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell15.Multiline = true;
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.StylePriority.UseBorders = false;
            this.xrTableCell15.StylePriority.UseFont = false;
            this.xrTableCell15.StylePriority.UseTextAlignment = false;
            this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTable1
            // 
            this.xrTable1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow11});
            this.xrTable1.StylePriority.UseBackColor = false;
            this.xrTable1.StylePriority.UseBorders = false;
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell3,
            this.xrTableCell2});
            this.xrTableRow11.Name = "xrTableRow11";
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.BackColor = System.Drawing.Color.White;
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseBackColor = false;
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.BackColor = System.Drawing.Color.White;
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseBackColor = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tFooter});
            this.ReportFooter.Name = "ReportFooter";
            // 
            // tFooter
            // 
            this.tFooter.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.tFooter.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tFooter.Name = "tFooter";
            this.tFooter.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.trFooter});
            this.tFooter.StylePriority.UseBorders = false;
            // 
            // trFooter
            // 
            this.trFooter.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tfTotal,
            this.tfDebit_GPT,
            this.xrTableCell13,
            this.xrTableCell17,
            this.tfCredit_GPT,
            this.xrTableCell14,
            this.xrTableCell20,
            this.xrTableCell27,
            this.xrTableCell28,
            this.xrTableCell29});
            this.trFooter.Name = "trFooter";
            // 
            // tfTotal
            // 
            this.tfTotal.Multiline = true;
            this.tfTotal.Name = "tfTotal";
            this.tfTotal.StylePriority.UseFont = false;
            this.tfTotal.StylePriority.UseTextAlignment = false;
            this.tfTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // tfDebit_GPT
            // 
            this.tfDebit_GPT.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([RearValue])")});
            this.tfDebit_GPT.Multiline = true;
            this.tfDebit_GPT.Name = "tfDebit_GPT";
            this.tfDebit_GPT.StylePriority.UseFont = false;
            this.tfDebit_GPT.StylePriority.UseTextAlignment = false;
            this.tfDebit_GPT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([RearPerc])"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n")});
            this.xrTableCell13.Multiline = true;
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.StylePriority.UseFont = false;
            this.xrTableCell13.StylePriority.UseTextAlignment = false;
            this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([RearValuePerHen])")});
            this.xrTableCell17.Multiline = true;
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.StylePriority.UseFont = false;
            this.xrTableCell17.StylePriority.UseTextAlignment = false;
            this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // tfCredit_GPT
            // 
            this.tfCredit_GPT.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([LayValue])")});
            this.tfCredit_GPT.Multiline = true;
            this.tfCredit_GPT.Name = "tfCredit_GPT";
            this.tfCredit_GPT.StylePriority.UseFont = false;
            this.tfCredit_GPT.StylePriority.UseTextAlignment = false;
            this.tfCredit_GPT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([LayPerc])"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n")});
            this.xrTableCell14.Multiline = true;
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.StylePriority.UseFont = false;
            this.xrTableCell14.StylePriority.UseTextAlignment = false;
            this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([LayValuePerHen])")});
            this.xrTableCell20.Multiline = true;
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.StylePriority.UseFont = false;
            this.xrTableCell20.StylePriority.UseTextAlignment = false;
            this.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([TotalValue])")});
            this.xrTableCell27.Multiline = true;
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.StylePriority.UseFont = false;
            this.xrTableCell27.StylePriority.UseTextAlignment = false;
            this.xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([TotalValuePerc])")});
            this.xrTableCell28.Multiline = true;
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.StylePriority.UseFont = false;
            this.xrTableCell28.StylePriority.UseTextAlignment = false;
            this.xrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([TotalValuePerEgg])")});
            this.xrTableCell29.Multiline = true;
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.StylePriority.UseFont = false;
            this.xrTableCell29.StylePriority.UseTextAlignment = false;
            this.xrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // FlockCode
            // 
            this.FlockCode.Name = "FlockCode";
            this.FlockCode.Visible = false;
            // 
            // dsFinance1
            // 
            this.dsFinance1.DataSetName = "dsFinance";
            this.dsFinance1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sR_BRD_EndFlockExpenses_ExpTableAdapter
            // 
            this.sR_BRD_EndFlockExpenses_ExpTableAdapter.ClearBeforeFill = true;
            // 
            // sR_FC_CustSuppSheet_OLDTableAdapter
            // 
            this.sR_FC_CustSuppSheet_OLDTableAdapter.ClearBeforeFill = true;
            // 
            // SR_LAY_EndFlockExpenses_Exp
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.ReportFooter});
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.BorderWidth = 0.5F;
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dsFinance,
            this.dsFinance1});
            this.DataMember = "SR_BRD_EndFlockExpenses_Exp";
            this.DataSource = this.dsFinance1;
            this.ExportOptions.Pdf.DocumentOptions.Author = "VetSoft";
            this.LocalizationItems.AddRange(new DevExpress.XtraReports.Localization.LocalizationItem[] {
            new DevExpress.XtraReports.Localization.LocalizationItem(this.BottomMargin, "Default", "HeightF", 5.833308F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.BottomMargin, "Default", "Visible", false),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.Detail, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.FlockCode, "Default", "Description", "FlockCode"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.IsRTL, "Default", "Description", "Right to left"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.IsRTL, "ar", "Description", "عرض من اليمبن لليسار"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooter, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportHeader, "Default", "HeightF", 58.58337F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "DisplayName", "SR_BRD_EndFlockExpenses_Exp"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "ar", "DisplayName", "قيود يومية تفصيلي"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Margins", new DevExpress.Drawing.DXMargins(10F, 10F, 5F, 5.833308F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "PaperKind", DevExpress.Drawing.Printing.DXPaperKind.A4),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfCredit_GPT, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfCredit_GPT, "Default", "Text", "tfCredit_GPT"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfCredit_GPT, "Default", "TextFormatString", "{0:#,#.00}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfCredit_GPT, "Default", "Weight", 0.40570155042238892D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfDebit_GPT, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfDebit_GPT, "Default", "Text", "tfDebit_GPT"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfDebit_GPT, "Default", "TextFormatString", "{0:#,#.00}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfDebit_GPT, "Default", "Weight", 0.4057059807060891D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tFooter, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tFooter, "Default", "SizeF", new System.Drawing.SizeF(747.6317F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfTotal, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 9F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfTotal, "Default", "Text", "Total"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfTotal, "ar", "Text", "إجمالي"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfTotal, "Default", "Weight", 1.0347080658544054D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.TopMargin, "Default", "HeightF", 5F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.trFooter, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(204.5816F, 1.589457E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable1, "Default", "SizeF", new System.Drawing.SizeF(372.8133F, 21.66667F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable2, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(204.5816F, 21.6667F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable2, "Default", "SizeF", new System.Drawing.SizeF(186.4082F, 36.91667F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable3, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable3, "Default", "SizeF", new System.Drawing.SizeF(747.6317F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable4, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(390.9899F, 21.6667F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable4, "Default", "SizeF", new System.Drawing.SizeF(186.41F, 36.91667F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable5, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable5, "Default", "SizeF", new System.Drawing.SizeF(204.5816F, 58.58337F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable6, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(577.3999F, 1.589457E-05F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable6, "Default", "SizeF", new System.Drawing.SizeF(170.2318F, 58.58335F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell1, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell1, "Default", "Text", "Cost Item"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell1, "ar", "Text", "بنود التكلفة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell1, "Default", "Weight", 3D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell10, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell10, "Default", "Text", "%"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell10, "Default", "Weight", 0.48300007161803293D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell11, "Default", "Text", "xrTableCell11"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell11, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell11, "Default", "Weight", 0.4754751421949916D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell12, "Default", "Text", "xrTableCell12"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell12, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell12, "Default", "Weight", 0.47545783542152242D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell13, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell13, "Default", "Text", "xrTableCell13"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell13, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell13, "Default", "Weight", 0.24429501128613546D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell14, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell14, "Default", "Text", "xrTableCell14"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell14, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell14, "Default", "Weight", 0.24428580603039846D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell15, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell15, "Default", "Text", "Cost Per Chicken"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell15, "ar", "Text", "التكلفة / دجاجة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell15, "Default", "Weight", 0.63066489867915509D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell16, "Default", "Text", "xrTableCell16"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell16, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell16, "Default", "Weight", 0.569865546082478D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell17, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell17, "Default", "Text", "xrTableCell17"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell17, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell17, "Default", "Weight", 0.29279148461714183D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell18, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell18, "Default", "Text", "Cost Per Chicken"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell18, "ar", "Text", "التكلفة / دجاجة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell18, "Default", "Weight", 0.57890014479027574D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell19, "Default", "Text", "xrTableCell19"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell19, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell19, "Default", "Weight", 0.56986035604757346D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell2, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell2, "Default", "Text", "Production Period"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell2, "ar", "Text", "فترة الانتاج"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell2, "Default", "Weight", 3.2669693888178846D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell20, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell20, "Default", "Text", "xrTableCell20"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell20, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell20, "Default", "Weight", 0.29278894268354416D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell21, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell21, "Default", "Text", "Total"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell21, "ar", "Text", "اجمالي"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell21, "Default", "Weight", 0.79590679104341333D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell22, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell22, "Default", "Text", "%"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell22, "Default", "Weight", 0.528706418322197D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell23, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell23, "Default", "Text", "Total Cost Per Egg"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell23, "ar", "Text", "اجمالي التكلفة لكل بيضة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell23, "Default", "Weight", 0.5387955921305988D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell24, "Default", "Text", "xrTableCell24"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell24, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell24, "Default", "Weight", 0.71574753009762049D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell25, "Default", "Text", "xrTableCell25"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell25, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell25, "Default", "Weight", 0.47545783204371772D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell26, "Default", "Text", "xrTableCell26"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell26, "Default", "TextFormatString", "{0:N3}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell26, "Default", "Weight", 0.48453134438611634D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell27, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell27, "Default", "Text", "xrTableCell27"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell27, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell27, "Default", "Weight", 0.36776946414542477D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell28, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell28, "Default", "Text", "xrTableCell28"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell28, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell28, "Default", "Weight", 0.24428580682781922D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell29, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell29, "Default", "Text", "xrTableCell29"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell29, "Default", "TextFormatString", "{0:N3}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell29, "Default", "Weight", 0.24894780885362208D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell3, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell3, "Default", "Text", "Rearing period"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell3, "ar", "Text", "فترة التربية"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell3, "Default", "Weight", 3.2670242219404728D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell4, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell4, "Default", "Text", "Value"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell4, "ar", "Text", "القيمة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell4, "Default", "Weight", 0.87387997735261913D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell5, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell5, "Default", "Text", "%"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell5, "Default", "Weight", 0.52620433051119486D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell6, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell6, "Default", "Text", "Value"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell6, "ar", "Text", "القيمة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell6, "Default", "Weight", 0.80220009666092618D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell7, "Default", "Text", "xrTableCell7"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell7, "Default", "Weight", 2.0138707467742787D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell8, "Default", "Text", "xrTableCell8"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell8, "Default", "TextFormatString", "{0:#,#.00}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell8, "Default", "Weight", 0.78963335466305651D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell9, "Default", "Text", "xrTableCell9"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell9, "Default", "TextFormatString", "{0:#,#.00}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell9, "Default", "Weight", 0.78967283049052184D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow1, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow11, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow2, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow3, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow4, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow5, "Default", "Weight", 1D)});
            this.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            groupLayoutItem1.BorderVisible = false;
            groupLayoutItem1.ShowExpandButton = true;
            groupLayoutItem1.TitleVisible = false;
            groupLayoutItem2.TitleVisible = false;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IsRTL, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.FlockCode, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            groupLayoutItem1,
            groupLayoutItem2});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.IsRTL,
            this.FlockCode});
            this.ScriptReferencesString = "E:\\VetSoft Projects .Net2024\\VetSoft Projects\\VetSoftDevExpress\\bin\\Release\\net8." +
    "0\\VetSoftDevExpress.dll";
            this.ScriptsSource = resources.GetString("$this.ScriptsSource");
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailData3_Odd,
            this.PageInfo});
            this.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.Version = "24.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFinance1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.Parameters.Parameter IsRTL;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.DataAccess.Sql.SqlDataSource dsFinance;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTable tFooter;
        private DevExpress.XtraReports.UI.XRTableRow trFooter;
        private DevExpress.XtraReports.UI.XRTableCell tfTotal;
        private DevExpress.XtraReports.UI.XRTableCell tfDebit_GPT;
        private DevExpress.XtraReports.UI.XRTableCell tfCredit_GPT;
        private DevExpress.XtraReports.Parameters.Parameter FlockCode;
        private DataSets.dsFinance dsFinance1;
        private DataSets.dsFinanceTableAdapters.SR_BRD_EndFlockExpenses_ExpTableAdapter sR_BRD_EndFlockExpenses_ExpTableAdapter;
        private DataSets.dsFinanceTableAdapters.SR_FC_CustSuppSheet_OLDTableAdapter sR_FC_CustSuppSheet_OLDTableAdapter;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTable xrTable4;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTable xrTable5;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell13;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell14;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell16;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell15;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell17;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell18;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell19;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell24;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell25;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell26;
        private DevExpress.XtraReports.UI.XRTable xrTable6;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell21;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell22;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell23;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell20;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell27;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell28;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell29;
    }
}