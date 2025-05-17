namespace DevExpressReports.Reports.FeedFormulation.Nutrient.RationResult_Nut
{
    partial class SR_FM_RationResult_Nut
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
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfoPageNoOfTotal = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfoCurrentDate = new DevExpress.XtraReports.UI.XRPageInfo();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.SubBand2 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportHeader = new DevExpress.XtraReports.UI.XRSubreport();
            this.SubBand3 = new DevExpress.XtraReports.UI.SubBand();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.SubBand4 = new DevExpress.XtraReports.UI.SubBand();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.SubBand5 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportNotes = new DevExpress.XtraReports.UI.XRSubreport();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.SubBand7 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportSignature_PageFooter = new DevExpress.XtraReports.UI.XRSubreport();
            this.SubBand8 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportFooterCustom = new DevExpress.XtraReports.UI.XRSubreport();
            this.TotalCost = new DevExpress.XtraReports.UI.CalculatedField();
            this.TotalProfit = new DevExpress.XtraReports.UI.CalculatedField();
            this.Message = new DevExpress.XtraReports.UI.CalculatedField();
            this.IsRTL = new DevExpress.XtraReports.Parameters.Parameter();
            this.DateFrom = new DevExpress.XtraReports.Parameters.Parameter();
            this.DateTo = new DevExpress.XtraReports.Parameters.Parameter();
            this.FeedMillCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.dsFinance1 = new DevExpressReports.Reports.Finance.DataSets.dsFinance();
            this.sR_FM_IngReceivingTableAdapter = new DevExpressReports.Reports.Finance.DataSets.dsFinanceTableAdapters.SR_FM_IngReceivingTableAdapter();
            this.UnitCost_CF = new DevExpress.XtraReports.UI.CalculatedField();
            this.IsBais = new DevExpress.XtraReports.Parameters.Parameter();
            this.QtyValue1 = new DevExpress.XtraReports.UI.CalculatedField();
            this.QtyValue2 = new DevExpress.XtraReports.UI.CalculatedField();
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
            this.xrPageInfo1,
            this.pageInfoCurrentDate});
            this.BottomMargin.Name = "BottomMargin";
            // 
            // pageInfoPageNoOfTotal
            // 
            this.pageInfoPageNoOfTotal.Name = "pageInfoPageNoOfTotal";
            this.pageInfoPageNoOfTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            // 
            // pageInfoCurrentDate
            // 
            this.pageInfoCurrentDate.Name = "pageInfoCurrentDate";
            this.pageInfoCurrentDate.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfoCurrentDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel11,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4});
            this.Detail.Name = "Detail";
            // 
            // xrLabel11
            // 
            this.xrLabel11.BackColor = System.Drawing.Color.White;
            this.xrLabel11.BorderColor = System.Drawing.Color.Gray;
            this.xrLabel11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Unit]")});
            this.xrLabel11.Multiline = true;
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.StylePriority.UseBackColor = false;
            this.xrLabel11.StylePriority.UseBorderColor = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel8
            // 
            this.xrLabel8.BackColor = System.Drawing.Color.White;
            this.xrLabel8.BorderColor = System.Drawing.Color.Gray;
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[QtyValue2]")});
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.StylePriority.UseBackColor = false;
            this.xrLabel8.StylePriority.UseBorderColor = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel7
            // 
            this.xrLabel7.BackColor = System.Drawing.Color.White;
            this.xrLabel7.BorderColor = System.Drawing.Color.Gray;
            this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NutrientName]")});
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseBorderColor = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel6
            // 
            this.xrLabel6.BackColor = System.Drawing.Color.White;
            this.xrLabel6.BorderColor = System.Drawing.Color.Gray;
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Unit]")});
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseBorderColor = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BackColor = System.Drawing.Color.White;
            this.xrLabel5.BorderColor = System.Drawing.Color.Gray;
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[QtyValue1]")});
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseBorderColor = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel4
            // 
            this.xrLabel4.BackColor = System.Drawing.Color.White;
            this.xrLabel4.BorderColor = System.Drawing.Color.Gray;
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NutrientName]")});
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.StylePriority.UseBackColor = false;
            this.xrLabel4.StylePriority.UseBorderColor = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // PageHeader
            // 
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand2,
            this.SubBand3,
            this.SubBand4});
            // 
            // SubBand2
            // 
            this.SubBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportHeader});
            this.SubBand2.Name = "SubBand2";
            // 
            // srReportHeader
            // 
            this.srReportHeader.Name = "srReportHeader";
            this.srReportHeader.ReportSource = new DevExpressReports.PredefinedReports.SubReportHeader();
            // 
            // SubBand3
            // 
            this.SubBand3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel16,
            this.xrLabel14,
            this.xrLabel13,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
            this.SubBand3.Name = "SubBand3";
            // 
            // xrLabel16
            // 
            this.xrLabel16.BackColor = System.Drawing.Color.White;
            this.xrLabel16.BorderColor = System.Drawing.Color.Gray;
            this.xrLabel16.Multiline = true;
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.StylePriority.UseBackColor = false;
            this.xrLabel16.StylePriority.UseBorderColor = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel14
            // 
            this.xrLabel14.BackColor = System.Drawing.Color.White;
            this.xrLabel14.BorderColor = System.Drawing.Color.Gray;
            this.xrLabel14.Multiline = true;
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.StylePriority.UseBackColor = false;
            this.xrLabel14.StylePriority.UseBorderColor = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel13
            // 
            this.xrLabel13.BackColor = System.Drawing.Color.White;
            this.xrLabel13.BorderColor = System.Drawing.Color.Gray;
            this.xrLabel13.Multiline = true;
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.StylePriority.UseBackColor = false;
            this.xrLabel13.StylePriority.UseBorderColor = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel3
            // 
            this.xrLabel3.BackColor = System.Drawing.Color.White;
            this.xrLabel3.BorderColor = System.Drawing.Color.Gray;
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.White;
            this.xrLabel2.BorderColor = System.Drawing.Color.Gray;
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.White;
            this.xrLabel1.BorderColor = System.Drawing.Color.Gray;
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // SubBand4
            // 
            this.SubBand4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel15,
            this.xrLabel39,
            this.xrLabel40,
            this.xrLabel41,
            this.xrLabel42,
            this.xrLabel44});
            this.SubBand4.Name = "SubBand4";
            // 
            // xrLabel15
            // 
            this.xrLabel15.BackColor = System.Drawing.Color.White;
            this.xrLabel15.BorderColor = System.Drawing.Color.Gray;
            this.xrLabel15.Multiline = true;
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.StylePriority.UseBackColor = false;
            this.xrLabel15.StylePriority.UseBorderColor = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel39
            // 
            this.xrLabel39.BackColor = System.Drawing.Color.White;
            this.xrLabel39.BorderColor = System.Drawing.Color.Gray;
            this.xrLabel39.Multiline = true;
            this.xrLabel39.Name = "xrLabel39";
            this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel39.StylePriority.UseBackColor = false;
            this.xrLabel39.StylePriority.UseBorderColor = false;
            this.xrLabel39.StylePriority.UseTextAlignment = false;
            this.xrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel40
            // 
            this.xrLabel40.BackColor = System.Drawing.Color.White;
            this.xrLabel40.BorderColor = System.Drawing.Color.Gray;
            this.xrLabel40.Multiline = true;
            this.xrLabel40.Name = "xrLabel40";
            this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel40.StylePriority.UseBackColor = false;
            this.xrLabel40.StylePriority.UseBorderColor = false;
            this.xrLabel40.StylePriority.UseTextAlignment = false;
            this.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel41
            // 
            this.xrLabel41.BackColor = System.Drawing.Color.White;
            this.xrLabel41.BorderColor = System.Drawing.Color.Gray;
            this.xrLabel41.Multiline = true;
            this.xrLabel41.Name = "xrLabel41";
            this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel41.StylePriority.UseBackColor = false;
            this.xrLabel41.StylePriority.UseBorderColor = false;
            this.xrLabel41.StylePriority.UseTextAlignment = false;
            this.xrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel42
            // 
            this.xrLabel42.BackColor = System.Drawing.Color.White;
            this.xrLabel42.BorderColor = System.Drawing.Color.Gray;
            this.xrLabel42.Multiline = true;
            this.xrLabel42.Name = "xrLabel42";
            this.xrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel42.StylePriority.UseBackColor = false;
            this.xrLabel42.StylePriority.UseBorderColor = false;
            this.xrLabel42.StylePriority.UseTextAlignment = false;
            this.xrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel44
            // 
            this.xrLabel44.BackColor = System.Drawing.Color.White;
            this.xrLabel44.BorderColor = System.Drawing.Color.Gray;
            this.xrLabel44.Multiline = true;
            this.xrLabel44.Name = "xrLabel44";
            this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel44.StylePriority.UseBackColor = false;
            this.xrLabel44.StylePriority.UseBorderColor = false;
            this.xrLabel44.StylePriority.UseTextAlignment = false;
            this.xrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand5});
            // 
            // SubBand5
            // 
            this.SubBand5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportNotes});
            this.SubBand5.Name = "SubBand5";
            // 
            // srReportNotes
            // 
            this.srReportNotes.Name = "srReportNotes";
            this.srReportNotes.ReportSource = new DevExpressReports.PredefinedReports.SubReportNotes();
            // 
            // PageFooter
            // 
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand7,
            this.SubBand8});
            // 
            // SubBand7
            // 
            this.SubBand7.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportSignature_PageFooter});
            this.SubBand7.Name = "SubBand7";
            // 
            // srReportSignature_PageFooter
            // 
            this.srReportSignature_PageFooter.Name = "srReportSignature_PageFooter";
            this.srReportSignature_PageFooter.ReportSource = new DevExpressReports.PredefinedReports.SubReportSignature();
            // 
            // SubBand8
            // 
            this.SubBand8.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportFooterCustom});
            this.SubBand8.Name = "SubBand8";
            // 
            // srReportFooterCustom
            // 
            this.srReportFooterCustom.Name = "srReportFooterCustom";
            this.srReportFooterCustom.ReportSource = new DevExpressReports.PredefinedReports.SubReportHeaderCustom();
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
            // IsRTL
            // 
            this.IsRTL.Name = "IsRTL";
            this.IsRTL.Type = typeof(bool);
            this.IsRTL.ValueInfo = "False";
            this.IsRTL.Visible = false;
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
            // sR_FM_IngReceivingTableAdapter
            // 
            this.sR_FM_IngReceivingTableAdapter.ClearBeforeFill = true;
            // 
            // UnitCost_CF
            // 
            this.UnitCost_CF.DataMember = "SR_FM_RationResult_Nut";
            this.UnitCost_CF.Expression = "ToDecimal([TotalCost] / [TotalQtn])";
            this.UnitCost_CF.Name = "UnitCost_CF";
            // 
            // IsBais
            // 
            this.IsBais.Name = "IsBais";
            this.IsBais.Type = typeof(bool);
            this.IsBais.ValueInfo = "False";
            this.IsBais.Visible = false;
            // 
            // QtyValue1
            // 
            this.QtyValue1.DataMember = "SR_FM_RationResult_Nut";
            this.QtyValue1.Expression = "Iif([?IsBais] = \'true\', [Quantity], [Quantity_DM])";
            this.QtyValue1.Name = "QtyValue1";
            // 
            // QtyValue2
            // 
            this.QtyValue2.DataMember = "SR_FM_RationResult_Nut";
            this.QtyValue2.Expression = "Iif([IsBais] = \'true\', [Quantity], [Quantity_DM])";
            this.QtyValue2.Name = "QtyValue2";
            // 
            // SR_FM_RationResult_Nut
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.PageHeader,
            this.GroupHeader1,
            this.GroupFooter1,
            this.ReportFooter,
            this.PageFooter});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.TotalCost,
            this.TotalProfit,
            this.Message,
            this.UnitCost_CF,
            this.QtyValue1,
            this.QtyValue2});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dsFinance1});
            this.DataMember = "SR_FM_RationResult_Nut";
            this.DataSource = this.dsFinance1;
            this.LocalizationItems.AddRange(new DevExpress.XtraReports.Localization.LocalizationItem[] {
            new DevExpress.XtraReports.Localization.LocalizationItem(this.BottomMargin, "Default", "HeightF", 24.04173F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateFrom, "Default", "Description", "From"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateTo, "Default", "Description", "To"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.Detail, "Default", "HeightF", 23F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.FeedMillCode, "Default", "Description", "FeedMillcode"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.GroupFooter1, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.GroupHeader1, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.IsBais, "Default", "Description", "IsBais"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.IsRTL, "Default", "Description", "Right to left"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageFooter, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeader, "Default", "HeightF", 1.041667F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentDate, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0.9167354F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentDate, "Default", "SizeF", new System.Drawing.SizeF(204.12F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoPageNoOfTotal, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(683.67F, 0.9167354F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoPageNoOfTotal, "Default", "SizeF", new System.Drawing.SizeF(219.3298F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoPageNoOfTotal, "Default", "TextFormatString", "Page {0} of {1}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooter, "Default", "HeightF", 0.2500534F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportFooterCustom, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportFooterCustom, "Default", "SizeF", new System.Drawing.SizeF(902.9999F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportHeader, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0.6250064F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportHeader, "Default", "SizeF", new System.Drawing.SizeF(903F, 33.54166F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportNotes, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportNotes, "Default", "SizeF", new System.Drawing.SizeF(903F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature_PageFooter, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature_PageFooter, "Default", "SizeF", new System.Drawing.SizeF(903F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Margins", new DevExpress.Drawing.DXMargins(9F, 0F, 20F, 24.04173F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "PaperKind", DevExpress.Drawing.Printing.DXPaperKind.Custom),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand2, "Default", "HeightF", 34.16667F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand3, "Default", "HeightF", 132.375F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand4, "Default", "HeightF", 23F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand5, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand7, "Default", "HeightF", 20.29158F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand8, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.TopMargin, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "SizeF", new System.Drawing.SizeF(174.9999F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "Text", "Ration Name: [RationName]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "ar", "Text", "التركيبة: [RationName]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel11, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(789.4579F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel11, "Default", "SizeF", new System.Drawing.SizeF(113.5419F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel11, "Default", "Text", "xrLabel3"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel13, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 101.0417F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel13, "Default", "SizeF", new System.Drawing.SizeF(174.9999F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel13, "Default", "Text", "Last Update: [LastUpdateDate]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel13, "ar", "Text", "اخر تعديل: [LastUpdateDate]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel14, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(555.625F, 10.00001F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel14, "Default", "SizeF", new System.Drawing.SizeF(174.9999F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel14, "Default", "Text", "Total Cost: [TotalCost]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel14, "ar", "Text", "التكلفة الكلية: [TotalCost]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel15, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(234.983F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel15, "Default", "SizeF", new System.Drawing.SizeF(129.1666F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel15, "Default", "Text", "Value"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel15, "ar", "Text", "القيمة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel16, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(555.625F, 47.91667F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel16, "Default", "SizeF", new System.Drawing.SizeF(174.9999F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel16, "Default", "Text", "Unit Cost: [UnitCost_CF]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel16, "ar", "Text", "وحدة التكلفة: [UnitCost_CF]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 34.45832F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "Default", "SizeF", new System.Drawing.SizeF(204.12F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "Default", "Text", "Total Quantity (KG): [TotalQtn]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "ar", "Text", "الكمية الكلية (كجم): [TotalQtn]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 67.62505F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "Default", "SizeF", new System.Drawing.SizeF(174.9999F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "Default", "Text", "Requirement: [ReqName]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "ar", "Text", "الاحتياجات: [ReqName]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel39, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(790.4581F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel39, "Default", "SizeF", new System.Drawing.SizeF(113.5419F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel39, "Default", "Text", "Unit"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel39, "ar", "Text", "الوحدة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel4, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel4, "Default", "SizeF", new System.Drawing.SizeF(234.9829F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel4, "Default", "Text", "xrLabel3"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel40, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(670.6664F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel40, "Default", "SizeF", new System.Drawing.SizeF(119.7917F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel40, "Default", "Text", "Value"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel40, "ar", "Text", "القيمة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel41, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(452.6913F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel41, "Default", "SizeF", new System.Drawing.SizeF(217.9752F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel41, "Default", "Text", "Nutrient"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel41, "ar", "Text", "العنصر"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel42, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(364.1495F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel42, "Default", "SizeF", new System.Drawing.SizeF(88.54172F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel42, "Default", "Text", "Unit"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel42, "ar", "Text", "الوحدة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel44, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel44, "Default", "SizeF", new System.Drawing.SizeF(234.9829F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel44, "Default", "Text", "Nutrient"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel44, "ar", "Text", "العنصر"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel5, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(234.983F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel5, "Default", "SizeF", new System.Drawing.SizeF(129.1666F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel5, "Default", "Text", "xrLabel3"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel6, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(364.1495F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel6, "Default", "SizeF", new System.Drawing.SizeF(88.54172F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel7, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(452.6913F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel7, "Default", "SizeF", new System.Drawing.SizeF(216.975F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel8, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(669.6662F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel8, "Default", "SizeF", new System.Drawing.SizeF(119.7917F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrPageInfo1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(381.6666F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrPageInfo1, "Default", "SizeF", new System.Drawing.SizeF(117.7083F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrPageInfo1, "Default", "TextFormatString", "{0:HH:mm:ss}")});
            this.PageWidth = 913;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IsRTL, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IsBais, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.DateFrom, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.DateTo, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.FeedMillCode, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.IsRTL,
            this.IsBais,
            this.DateFrom,
            this.DateTo,
            this.FeedMillCode});
            this.Version = "24.1";
            ((System.ComponentModel.ISupportInitialize)(this.dsFinance1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.SubBand SubBand2;
        private DevExpress.XtraReports.UI.XRSubreport srReportHeader;
        private DevExpress.XtraReports.UI.SubBand SubBand3;
        private DevExpress.XtraReports.UI.SubBand SubBand4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel xrLabel39;
        private DevExpress.XtraReports.UI.XRLabel xrLabel40;
        private DevExpress.XtraReports.UI.XRLabel xrLabel41;
        private DevExpress.XtraReports.UI.XRLabel xrLabel42;
        private DevExpress.XtraReports.UI.XRLabel xrLabel44;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.SubBand SubBand5;
        private DevExpress.XtraReports.UI.XRSubreport srReportNotes;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.SubBand SubBand7;
        private DevExpress.XtraReports.UI.XRSubreport srReportSignature_PageFooter;
        private DevExpress.XtraReports.UI.SubBand SubBand8;
        private DevExpress.XtraReports.UI.XRSubreport srReportFooterCustom;
        private DevExpress.XtraReports.UI.CalculatedField TotalCost;
        private DevExpress.XtraReports.UI.CalculatedField TotalProfit;
        private DevExpress.XtraReports.UI.CalculatedField Message;
        private DevExpress.XtraReports.Parameters.Parameter IsRTL;
        private DevExpress.XtraReports.Parameters.Parameter DateFrom;
        private DevExpress.XtraReports.Parameters.Parameter DateTo;
        private DevExpress.XtraReports.Parameters.Parameter FeedMillCode;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoCurrentDate;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoPageNoOfTotal;
        private Finance.DataSets.dsFinance dsFinance1;
        private Finance.DataSets.dsFinanceTableAdapters.SR_FM_IngReceivingTableAdapter sR_FM_IngReceivingTableAdapter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.CalculatedField UnitCost_CF;
        private DevExpress.XtraReports.Parameters.Parameter IsBais;
        private DevExpress.XtraReports.UI.CalculatedField QtyValue1;
        private DevExpress.XtraReports.UI.CalculatedField QtyValue2;
    }
}
