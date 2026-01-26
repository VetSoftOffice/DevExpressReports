namespace DevExpressReports.Reports.Farms.Breeder.RearingPeriod.Performance.FR_BRD_FlockSummary4
{
    partial class FR_BRD_FlockSummary4
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
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_BRD_FlockSummary4));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 1F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 1F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Dpi = 1F;
            this.Detail.Name = "Detail";
            this.Detail.Scripts.OnBeforePrint = "Detail_BeforePrint";
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3,
            this.xrTable2,
            this.xrTable1});
            this.PageHeader.Dpi = 1F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrTable3
            // 
            this.xrTable3.Dpi = 1F;
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0.02083333F, 0.02083333F, 0F, 0F, 1F);
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable3.StylePriority.UseFont = false;
            this.xrTable3.StylePriority.UseTextAlignment = false;
            this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9});
            this.xrTableRow3.Dpi = 1F;
            this.xrTableRow3.Name = "xrTableRow3";
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Dpi = 1F;
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Dpi = 1F;
            this.xrTableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n")});
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Scripts.OnBeforePrint = "xrTableCell8_BeforePrint";
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Dpi = 1F;
            this.xrTableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n")});
            this.xrTableCell9.Multiline = true;
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Scripts.OnBeforePrint = "xrTableCell9_BeforePrint";
            // 
            // xrTable2
            // 
            this.xrTable2.Dpi = 1F;
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0.02083333F, 0.02083333F, 0F, 0F, 1F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell10,
            this.xrTableCell6,
            this.xrTableCell11});
            this.xrTableRow2.Dpi = 1F;
            this.xrTableRow2.Name = "xrTableRow2";
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Dpi = 1F;
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Dpi = 1F;
            this.xrTableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([FemaleQtyKg])"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n")});
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell5.Summary = xrSummary1;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Dpi = 1F;
            this.xrTableCell10.Multiline = true;
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UseTextAlignment = false;
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Dpi = 1F;
            this.xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([MaleQtyKg])"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n")});
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell6.Summary = xrSummary2;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Dpi = 1F;
            this.xrTableCell11.Multiline = true;
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.StylePriority.UseTextAlignment = false;
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTable1
            // 
            this.xrTable1.Dpi = 1F;
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0.02083333F, 0.02083333F, 0F, 0F, 1F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
            this.xrTableRow1.Dpi = 1F;
            this.xrTableRow1.Name = "xrTableRow1";
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Dpi = 1F;
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Dpi = 1F;
            this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n")});
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Scripts.OnBeforePrint = "xrTableCell2_BeforePrint";
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Dpi = 1F;
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n")});
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Scripts.OnBeforePrint = "xrTableCell3_BeforePrint";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "dsBreeder";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "FeedType_en";
            table1.Name = "SR_FR_FeedByCrop";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "FemaleQtyKg";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "MaleQtyKg";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "Females";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "Males";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Name = "SR_FR_FeedByCrop";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // FR_BRD_FlockSummary4
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.PageHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "SR_FR_FeedByCrop";
            this.DataSource = this.sqlDataSource1;
            this.Dpi = 1F;
            this.LocalizationItems.AddRange(new DevExpress.XtraReports.Localization.LocalizationItem[] {
            new DevExpress.XtraReports.Localization.LocalizationItem(this.BottomMargin, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.Detail, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Font", new DevExpress.Drawing.DXFont("Arial", 9.75F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Margins", new DevExpress.Drawing.DXMargins(1F, 1F, 0.1458333F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeader, "Default", "HeightF", 0.8333333F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.TopMargin, "Default", "HeightF", 0.1458333F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable1, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable1, "Default", "SizeF", new System.Drawing.SizeF(5.34375F, 0.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable2, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable2, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable2, "Default", "SizeF", new System.Drawing.SizeF(5.34375F, 0.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable3, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable3, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0.5F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable3, "Default", "SizeF", new System.Drawing.SizeF(5.34375F, 0.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell1, "Default", "Text", "[FeedType_en] +    \' \'  + ♀♀ & ♂♂"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell1, "Default", "Weight", 2.59375D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell10, "Default", "Text", "Kgs"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell10, "ar", "Text", "كجم"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell10, "Default", "Weight", 0.42589663273860368D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell11, "Default", "Text", "Kgs"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell11, "ar", "Text", "كجم"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell11, "Default", "Weight", 0.38983089605735433D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell2, "Default", "Weight", 1.3020832538604736D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell3, "Default", "Weight", 1.4479167461395264D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell4, "Default", "Text", "Total Feed Consumed (Kgs)                          "),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell4, "ar", "Text", "اجمالي استهلاك العلف (كجم)"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell4, "Default", "Weight", 2.7709405497447936D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell5, "Default", "Text", "xrTableCell2"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell5, "Default", "Weight", 0.96513758458714827D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell6, "Default", "Text", "xrTableCell3"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell6, "Default", "Weight", 1.1569990881131069D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell7, "Default", "Text", "Total Feed Consumed Kgs / Bird                   "),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell7, "ar", "Text", "اجمالي استهلاك العلف (كجم / طائر)"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell7, "Default", "Weight", 2.65194295920804D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell8, "Default", "Weight", 1.3312965892871844D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell9, "Default", "Weight", 1.4804022075696621D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow1, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow2, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow3, "Default", "Weight", 1D)});
            this.PageHeightF = 11F;
            this.PageWidthF = 8.5F;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.Inches;
            this.ScriptsSource = resources.GetString("$this.ScriptsSource");
            this.SnapGridSize = 0.125F;
            this.Version = "25.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTable xrTable3;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
    }
}
