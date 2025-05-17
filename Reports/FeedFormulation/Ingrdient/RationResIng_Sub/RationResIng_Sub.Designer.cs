namespace DevExpressReports.Reports.FeedFormulation.Ingrdient.RationResIng_Sub
{
    partial class RationResIng_Sub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RationResIng_Sub));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfoPageNoOfTotal = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfoCurrentDate = new DevExpress.XtraReports.UI.XRPageInfo();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.SubBand2 = new DevExpress.XtraReports.UI.SubBand();
            this.SubBand6 = new DevExpress.XtraReports.UI.SubBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.TotalCost = new DevExpress.XtraReports.UI.CalculatedField();
            this.TotalProfit = new DevExpress.XtraReports.UI.CalculatedField();
            this.Message = new DevExpress.XtraReports.UI.CalculatedField();
            this.TotalQtn_DM_CF = new DevExpress.XtraReports.UI.CalculatedField();
            this.UnitCost_CF = new DevExpress.XtraReports.UI.CalculatedField();
            this.UnitCost_DM_CF = new DevExpress.XtraReports.UI.CalculatedField();
            this.IsRTL = new DevExpress.XtraReports.Parameters.Parameter();
            this.IsShowDM = new DevExpress.XtraReports.Parameters.Parameter();
            this.IsShowCost = new DevExpress.XtraReports.Parameters.Parameter();
            this.IsShowChart = new DevExpress.XtraReports.Parameters.Parameter();
            this.ShowSignature = new DevExpress.XtraReports.Parameters.Parameter();
            this.ShowSignatureAllPages = new DevExpress.XtraReports.Parameters.Parameter();
            this.DateFrom = new DevExpress.XtraReports.Parameters.Parameter();
            this.DateTo = new DevExpress.XtraReports.Parameters.Parameter();
            this.FeedMillCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.dsFinance1 = new DevExpressReports.Reports.Finance.DataSets.dsFinance();
            this.sR_FM_RationResultTableAdapter = new DevExpressReports.Reports.Finance.DataSets.dsFinanceTableAdapters.SR_FM_RationResultTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFinance1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfoPageNoOfTotal,
            this.pageInfoCurrentDate});
            this.BottomMargin.Name = "BottomMargin";
            // 
            // pageInfoPageNoOfTotal
            // 
            this.pageInfoPageNoOfTotal.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.pageInfoPageNoOfTotal.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.pageInfoPageNoOfTotal.Name = "pageInfoPageNoOfTotal";
            this.pageInfoPageNoOfTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // pageInfoCurrentDate
            // 
            this.pageInfoCurrentDate.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.pageInfoCurrentDate.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.pageInfoCurrentDate.Name = "pageInfoCurrentDate";
            this.pageInfoCurrentDate.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfoCurrentDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail.Name = "Detail";
            // 
            // xrTable2
            // 
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell8,
            this.xrTableCell10,
            this.xrTableCell11});
            this.xrTableRow2.Name = "xrTableRow2";
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.xrTableCell8.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[IngredientName]")});
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseBorderColor = false;
            this.xrTableCell8.StylePriority.UseBorders = false;
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.xrTableCell10.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Quantity]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AccessibleDescription", "Iif([?IsRTL], \'MiddleRight\', \'MiddleLeft\')\n")});
            this.xrTableCell10.Multiline = true;
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UseBorderColor = false;
            this.xrTableCell10.StylePriority.UseBorders = false;
            this.xrTableCell10.StylePriority.UseTextAlignment = false;
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.xrTableCell11.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[QuantityPercent]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "AccessibleDescription", "Iif([?IsRTL], \'MiddleRight\', \'MiddleLeft\')\n")});
            this.xrTableCell11.Multiline = true;
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.StylePriority.UseBorderColor = false;
            this.xrTableCell11.StylePriority.UseBorders = false;
            this.xrTableCell11.StylePriority.UseTextAlignment = false;
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // PageHeader
            // 
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand2,
            this.SubBand6});
            // 
            // SubBand2
            // 
            this.SubBand2.Name = "SubBand2";
            // 
            // SubBand6
            // 
            this.SubBand6.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.SubBand6.Name = "SubBand6";
            // 
            // xrTable1
            // 
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell3,
            this.xrTableCell4});
            this.xrTableRow1.Name = "xrTableRow1";
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseBackColor = false;
            this.xrTableCell1.StylePriority.UseBorderColor = false;
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.xrTableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseBackColor = false;
            this.xrTableCell3.StylePriority.UseBorderColor = false;
            this.xrTableCell3.StylePriority.UseBorders = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTableCell4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.xrTableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseBackColor = false;
            this.xrTableCell4.StylePriority.UseBorderColor = false;
            this.xrTableCell4.StylePriority.UseBorders = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Name = "ReportFooter";
            // 
            // PageFooter
            // 
            this.PageFooter.Expanded = false;
            this.PageFooter.Name = "PageFooter";
            // 
            // TotalCost
            // 
            this.TotalCost.DataMember = "SR_FC_SalesSheet";
            this.TotalCost.Expression = "[CostPerTon] * [ActualQty]";
            this.TotalCost.Name = "TotalCost";
            // 
            // TotalProfit
            // 
            this.TotalProfit.DataMember = "SR_FC_SalesSheet";
            this.TotalProfit.Expression = "[TotalPrice] - [TotalCost]";
            this.TotalProfit.Name = "TotalProfit";
            // 
            // Message
            // 
            this.Message.DataMember = "SR_FM_IngReceiving";
            this.Message.Expression = "Iif([R_FM_IngredientRec_Remarks.Qty] <> 0, \n   \'(\' + [SR_FM_IngredientRec_Remarks" +
    ".IngredientName_en] + \' - \' + \n    FormatString([SR_FM_IngredientRec_Remarks.Qty" +
    "] / 1000, \'F3\') + \' Tons) \', \'\'\n   \n)\n";
            this.Message.Name = "Message";
            // 
            // TotalQtn_DM_CF
            // 
            this.TotalQtn_DM_CF.DataMember = "SR_FM_RationResult";
            this.TotalQtn_DM_CF.Expression = "[TotalQtn] / [TotalQtn_DM]";
            this.TotalQtn_DM_CF.Name = "TotalQtn_DM_CF";
            // 
            // UnitCost_CF
            // 
            this.UnitCost_CF.DataMember = "SR_FM_RationResult";
            this.UnitCost_CF.Expression = "[TotalCost] / [TotalQtn]";
            this.UnitCost_CF.Name = "UnitCost_CF";
            // 
            // UnitCost_DM_CF
            // 
            this.UnitCost_DM_CF.DataMember = "SR_FM_RationResult";
            this.UnitCost_DM_CF.Expression = "[TotalCost] / [TotalQtn_DM]\n";
            this.UnitCost_DM_CF.Name = "UnitCost_DM_CF";
            // 
            // IsRTL
            // 
            this.IsRTL.Name = "IsRTL";
            this.IsRTL.Type = typeof(bool);
            this.IsRTL.ValueInfo = "False";
            this.IsRTL.Visible = false;
            // 
            // IsShowDM
            // 
            this.IsShowDM.Name = "IsShowDM";
            this.IsShowDM.Type = typeof(bool);
            this.IsShowDM.ValueInfo = "False";
            this.IsShowDM.Visible = false;
            // 
            // IsShowCost
            // 
            this.IsShowCost.Name = "IsShowCost";
            this.IsShowCost.Type = typeof(bool);
            this.IsShowCost.ValueInfo = "False";
            this.IsShowCost.Visible = false;
            // 
            // IsShowChart
            // 
            this.IsShowChart.Name = "IsShowChart";
            this.IsShowChart.Type = typeof(bool);
            this.IsShowChart.ValueInfo = "False";
            this.IsShowChart.Visible = false;
            // 
            // ShowSignature
            // 
            this.ShowSignature.Name = "ShowSignature";
            this.ShowSignature.Type = typeof(bool);
            this.ShowSignature.ValueInfo = "False";
            this.ShowSignature.Visible = false;
            // 
            // ShowSignatureAllPages
            // 
            this.ShowSignatureAllPages.Name = "ShowSignatureAllPages";
            this.ShowSignatureAllPages.Type = typeof(bool);
            this.ShowSignatureAllPages.ValueInfo = "False";
            this.ShowSignatureAllPages.Visible = false;
            // 
            // DateFrom
            // 
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Visible = false;
            // 
            // DateTo
            // 
            this.DateTo.Name = "DateTo";
            this.DateTo.Visible = false;
            // 
            // FeedMillCode
            // 
            this.FeedMillCode.Name = "FeedMillCode";
            this.FeedMillCode.Visible = false;
            // 
            // dsFinance1
            // 
            this.dsFinance1.DataSetName = "dsFinance";
            this.dsFinance1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sR_FM_RationResultTableAdapter
            // 
            this.sR_FM_RationResultTableAdapter.ClearBeforeFill = true;
            // 
            // RationResIng_Sub
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.PageHeader,
            this.ReportFooter,
            this.PageFooter});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.TotalCost,
            this.TotalProfit,
            this.Message,
            this.TotalQtn_DM_CF,
            this.UnitCost_CF,
            this.UnitCost_DM_CF});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dsFinance1});
            this.DataMember = "SR_FM_RationResult";
            this.DataSource = this.dsFinance1;
            this.LocalizationItems.AddRange(new DevExpress.XtraReports.Localization.LocalizationItem[] {
            new DevExpress.XtraReports.Localization.LocalizationItem(this.BottomMargin, "Default", "HeightF", 32.99997F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateFrom, "Default", "Description", "From"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateTo, "Default", "Description", "To"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.Detail, "Default", "HeightF", 25F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.FeedMillCode, "Default", "Description", "FeedMillcode"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.IsRTL, "Default", "Description", "Right to left"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.IsShowChart, "Default", "Description", "IsShowChart"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.IsShowCost, "Default", "Description", "IsShowCost"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.IsShowDM, "Default", "Description", "IsShowDM"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageFooter, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeader, "Default", "HeightF", 1.041667F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentDate, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1.589457E-05F, 9.999974F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentDate, "Default", "SizeF", new System.Drawing.SizeF(2F, 9.666674F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoPageNoOfTotal, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(862.0833F, 8.33327F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoPageNoOfTotal, "Default", "SizeF", new System.Drawing.SizeF(2F, 11.33337F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoPageNoOfTotal, "Default", "TextFormatString", "Page {0} of {1}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Margins", new DevExpress.Drawing.DXMargins(10F, 10F, 20F, 32.99997F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "PaperKind", DevExpress.Drawing.Printing.DXPaperKind.A4),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooter, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignature, "Default", "Description", "ShowSignature"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignatureAllPages, "Default", "Description", "ShowSignatureAllPages"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand2, "Default", "HeightF", 34.16667F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand6, "Default", "HeightF", 25F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.TopMargin, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1.589457E-05F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable1, "Default", "SizeF", new System.Drawing.SizeF(396.5833F, 25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable2, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1.525879E-05F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable2, "Default", "SizeF", new System.Drawing.SizeF(396.5833F, 25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell1, "Default", "Text", "Ingredient Name"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell1, "ar", "Text", "المادة الخام"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell1, "Default", "Weight", 1.5791670227050782D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell10, "Default", "Text", "xrTableCell10"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell10, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell10, "Default", "Weight", 1.2062489318847653D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell11, "Default", "Text", "xrTableCell11"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell11, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell11, "Default", "Weight", 1.1804174804687504D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell3, "Default", "Text", "Quantity (KG)"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell3, "ar", "Text", "الكمية (كجم)"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell3, "Default", "Weight", 1.206250152587891D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell4, "Default", "Text", "%"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell4, "Default", "Weight", 1.180416259765626D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell8, "Default", "Text", "xrTableCell8"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell8, "Default", "Weight", 1.5791670227050787D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow1, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow2, "Default", "Weight", 1D)});
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IsRTL, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IsShowDM, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IsShowCost, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IsShowChart, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.ShowSignature, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.ShowSignatureAllPages, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.DateFrom, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.DateTo, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.FeedMillCode, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.IsRTL,
            this.IsShowDM,
            this.IsShowCost,
            this.IsShowChart,
            this.ShowSignature,
            this.ShowSignatureAllPages,
            this.DateFrom,
            this.DateTo,
            this.FeedMillCode});
            this.ScriptsSource = resources.GetString("$this.ScriptsSource");
            this.Version = "24.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFinance1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoPageNoOfTotal;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoCurrentDate;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.SubBand SubBand2;
        private DevExpress.XtraReports.UI.SubBand SubBand6;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.CalculatedField TotalCost;
        private DevExpress.XtraReports.UI.CalculatedField TotalProfit;
        private DevExpress.XtraReports.UI.CalculatedField Message;
        private DevExpress.XtraReports.UI.CalculatedField TotalQtn_DM_CF;
        private DevExpress.XtraReports.UI.CalculatedField UnitCost_CF;
        private DevExpress.XtraReports.UI.CalculatedField UnitCost_DM_CF;
        private DevExpress.XtraReports.Parameters.Parameter IsRTL;
        private DevExpress.XtraReports.Parameters.Parameter IsShowDM;
        private DevExpress.XtraReports.Parameters.Parameter IsShowCost;
        private DevExpress.XtraReports.Parameters.Parameter IsShowChart;
        private DevExpress.XtraReports.Parameters.Parameter ShowSignature;
        private DevExpress.XtraReports.Parameters.Parameter ShowSignatureAllPages;
        private DevExpress.XtraReports.Parameters.Parameter DateFrom;
        private DevExpress.XtraReports.Parameters.Parameter DateTo;
        private DevExpress.XtraReports.Parameters.Parameter FeedMillCode;
        private Finance.DataSets.dsFinance dsFinance1;
        private Finance.DataSets.dsFinanceTableAdapters.SR_FM_RationResultTableAdapter sR_FM_RationResultTableAdapter;
    }
}
