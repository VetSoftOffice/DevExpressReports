namespace DevExpressReports.Reports.FeedFormulation.IngNut.RationResult.RationResIngNut_AllRations
{
    partial class RationResIngNut_AllRations
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
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfoCurrentDate = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfoPageNoOfTotal = new DevExpress.XtraReports.UI.XRPageInfo();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.srReportHeader = new DevExpress.XtraReports.UI.XRSubreport();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportNotes = new DevExpress.XtraReports.UI.XRSubreport();
            this.SubBand5 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportSignature = new DevExpress.XtraReports.UI.XRSubreport();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.SubBand4 = new DevExpress.XtraReports.UI.SubBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.TotalCost = new DevExpress.XtraReports.UI.CalculatedField();
            this.TotalProfit = new DevExpress.XtraReports.UI.CalculatedField();
            this.Message = new DevExpress.XtraReports.UI.CalculatedField();
            this.IsRTL = new DevExpress.XtraReports.Parameters.Parameter();
            this.DateFrom = new DevExpress.XtraReports.Parameters.Parameter();
            this.DateTo = new DevExpress.XtraReports.Parameters.Parameter();
            this.FeedMillCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.RationResIngNut_Ing = new DevExpress.XtraReports.UI.XRSubreport();
            this.RationResIngNut_Nut = new DevExpress.XtraReports.UI.XRSubreport();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.SubBand2 = new DevExpress.XtraReports.UI.SubBand();
            this.SubBand3 = new DevExpress.XtraReports.UI.SubBand();
            this.dsFinance1 = new DevExpressReports.Reports.Finance.DataSets.dsFinance();
            this.sR_FF_RequirementTableAdapter = new DevExpressReports.Reports.Finance.DataSets.dsFinanceTableAdapters.SR_FF_RequirementTableAdapter();
            this.ShowSignature = new DevExpress.XtraReports.Parameters.Parameter();
            this.ShowSignatureAllPages = new DevExpress.XtraReports.Parameters.Parameter();
            this.IsShowDM = new DevExpress.XtraReports.Parameters.Parameter();
            this.CopyRight = new DevExpress.XtraReports.UI.CalculatedField();
            ((System.ComponentModel.ISupportInitialize)(this.dsFinance1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 20F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2,
            this.pageInfoCurrentDate,
            this.xrPageInfo1,
            this.pageInfoPageNoOfTotal});
            this.BottomMargin.HeightF = 23F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrPageInfo2.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.xrPageInfo2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(617.67F, 0F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(189.33F, 23F);
            this.xrPageInfo2.StylePriority.UseBorders = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrPageInfo2.TextFormatString = "Page {0} of {1}";
            // 
            // pageInfoCurrentDate
            // 
            this.pageInfoCurrentDate.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.pageInfoCurrentDate.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.pageInfoCurrentDate.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pageInfoCurrentDate.Name = "pageInfoCurrentDate";
            this.pageInfoCurrentDate.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfoCurrentDate.SizeF = new System.Drawing.SizeF(188.4583F, 22.99997F);
            this.pageInfoCurrentDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(354.1667F, 0F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrPageInfo1.TextFormatString = "{0:HH:mm:ss}";
            // 
            // pageInfoPageNoOfTotal
            // 
            this.pageInfoPageNoOfTotal.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.pageInfoPageNoOfTotal.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.pageInfoPageNoOfTotal.LocationFloat = new DevExpress.Utils.PointFloat(1044.792F, 0F);
            this.pageInfoPageNoOfTotal.Name = "pageInfoPageNoOfTotal";
            this.pageInfoPageNoOfTotal.SizeF = new System.Drawing.SizeF(2F, 3.20834F);
            this.pageInfoPageNoOfTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.pageInfoPageNoOfTotal.TextFormatString = "Page {0} of {1}";
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            // 
            // srReportHeader
            // 
            this.srReportHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.srReportHeader.Name = "srReportHeader";
            this.srReportHeader.ReportSource = new DevExpressReports.PredefinedReports.SubReportHeader();
            this.srReportHeader.SizeF = new System.Drawing.SizeF(807.0001F, 33.54166F);
            // 
            // ReportFooter
            // 
            this.ReportFooter.HeightF = 0F;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand1,
            this.SubBand5});
            // 
            // SubBand1
            // 
            this.SubBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportNotes});
            this.SubBand1.HeightF = 20F;
            this.SubBand1.Name = "SubBand1";
            // 
            // srReportNotes
            // 
            this.srReportNotes.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.srReportNotes.Name = "srReportNotes";
            this.srReportNotes.ReportSource = new DevExpressReports.PredefinedReports.SubReportNotes();
            this.srReportNotes.SizeF = new System.Drawing.SizeF(807.0001F, 20F);
            // 
            // SubBand5
            // 
            this.SubBand5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportSignature});
            this.SubBand5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?ShowSignature == True && ?ShowSignatureAllPages == False\n")});
            this.SubBand5.HeightF = 20.87501F;
            this.SubBand5.Name = "SubBand5";
            this.SubBand5.StylePriority.UseTextAlignment = false;
            this.SubBand5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // srReportSignature
            // 
            this.srReportSignature.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.srReportSignature.Name = "srReportSignature";
            this.srReportSignature.ReportSource = new DevExpressReports.PredefinedReports.SubReportSignature();
            this.srReportSignature.SizeF = new System.Drawing.SizeF(807.0001F, 20F);
            // 
            // PageFooter
            // 
            this.PageFooter.HeightF = 0F;
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand4});
            // 
            // SubBand4
            // 
            this.SubBand4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.SubBand4.HeightF = 23F;
            this.SubBand4.Name = "SubBand4";
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CopyRight]")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(7.947286E-06F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(807.0001F, 23F);
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "xrLabel1";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
            this.IsRTL.Description = "Right to left";
            this.IsRTL.Name = "IsRTL";
            this.IsRTL.Type = typeof(bool);
            this.IsRTL.ValueInfo = "False";
            this.IsRTL.Visible = false;
            // 
            // DateFrom
            // 
            this.DateFrom.Description = "From";
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Visible = false;
            // 
            // DateTo
            // 
            this.DateTo.Description = "To";
            this.DateTo.Name = "DateTo";
            this.DateTo.Visible = false;
            // 
            // FeedMillCode
            // 
            this.FeedMillCode.Description = "FeedMillcode";
            this.FeedMillCode.Name = "FeedMillCode";
            this.FeedMillCode.Visible = false;
            // 
            // RationResIngNut_Ing
            // 
            this.RationResIngNut_Ing.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
            this.RationResIngNut_Ing.Name = "RationResIngNut_Ing";
            this.RationResIngNut_Ing.ReportSource = new DevExpressReports.Reports.FeedFormulation.Ingrdient.RationResIngNut_Ing.RationResIngNut_Ing();
            this.RationResIngNut_Ing.SizeF = new System.Drawing.SizeF(807.0001F, 23F);
            // 
            // RationResIngNut_Nut
            // 
            this.RationResIngNut_Nut.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
            this.RationResIngNut_Nut.Name = "RationResIngNut_Nut";
            this.RationResIngNut_Nut.ReportSource = new DevExpressReports.Reports.FeedFormulation.Nutrient.RationResIngNut_Nut.RationResIngNut_Nut();
            this.RationResIngNut_Nut.SizeF = new System.Drawing.SizeF(807.0001F, 23F);
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportHeader});
            this.PageHeader.HeightF = 33.54166F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand2,
            this.SubBand3});
            // 
            // SubBand2
            // 
            this.SubBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.RationResIngNut_Ing});
            this.SubBand2.HeightF = 33.00002F;
            this.SubBand2.Name = "SubBand2";
            // 
            // SubBand3
            // 
            this.SubBand3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.RationResIngNut_Nut});
            this.SubBand3.HeightF = 33.00001F;
            this.SubBand3.Name = "SubBand3";
            // 
            // dsFinance1
            // 
            this.dsFinance1.DataSetName = "dsFinance";
            this.dsFinance1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sR_FF_RequirementTableAdapter
            // 
            this.sR_FF_RequirementTableAdapter.ClearBeforeFill = true;
            // 
            // ShowSignature
            // 
            this.ShowSignature.Description = "ShowSignature";
            this.ShowSignature.Name = "ShowSignature";
            this.ShowSignature.Type = typeof(bool);
            this.ShowSignature.ValueInfo = "False";
            this.ShowSignature.Visible = false;
            // 
            // ShowSignatureAllPages
            // 
            this.ShowSignatureAllPages.Description = "ShowSignatureAllPages";
            this.ShowSignatureAllPages.Name = "ShowSignatureAllPages";
            this.ShowSignatureAllPages.Type = typeof(bool);
            this.ShowSignatureAllPages.ValueInfo = "False";
            this.ShowSignatureAllPages.Visible = false;
            // 
            // IsShowDM
            // 
            this.IsShowDM.Description = "IsShowDM";
            this.IsShowDM.Name = "IsShowDM";
            this.IsShowDM.Type = typeof(bool);
            this.IsShowDM.ValueInfo = "False";
            this.IsShowDM.Visible = false;
            // 
            // CopyRight
            // 
            this.CopyRight.DataMember = "SR_FM_RationResult";
            this.CopyRight.Expression = "Iif(?IsRTL, \'حقوق النسخ 2003-2025 فيت سوفت - جميع الحقوق محفوظة\', \'Copyright @ 20" +
    "03-2025 VetSoft Office, All rights reserved\')\n";
            this.CopyRight.Name = "CopyRight";
            // 
            // RationResIngNut_AllRations
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportFooter,
            this.PageFooter,
            this.PageHeader});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.TotalCost,
            this.TotalProfit,
            this.Message,
            this.CopyRight});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dsFinance1});
            this.DataMember = "SR_FM_RationResult";
            this.DataSource = this.dsFinance1;
            this.Font = new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Margins = new DevExpress.Drawing.DXMargins(10F, 10F, 20F, 23F);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IsRTL, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.ShowSignature, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.ShowSignatureAllPages, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IsShowDM, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.DateFrom, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.DateTo, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.FeedMillCode, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.IsRTL,
            this.ShowSignature,
            this.ShowSignatureAllPages,
            this.IsShowDM,
            this.DateFrom,
            this.DateTo,
            this.FeedMillCode});
            this.Version = "24.2";
            this.BeforePrint += new DevExpress.XtraReports.UI.BeforePrintEventHandler(this.RationResIngNut_AllRations_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.dsFinance1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRSubreport srReportHeader;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.CalculatedField TotalCost;
        private DevExpress.XtraReports.UI.CalculatedField TotalProfit;
        private DevExpress.XtraReports.UI.CalculatedField Message;
        private DevExpress.XtraReports.Parameters.Parameter IsRTL;
        private DevExpress.XtraReports.Parameters.Parameter DateFrom;
        private DevExpress.XtraReports.Parameters.Parameter DateTo;
        private DevExpress.XtraReports.Parameters.Parameter FeedMillCode;
        private DevExpress.XtraReports.UI.SubBand SubBand1;
        private DevExpress.XtraReports.UI.SubBand SubBand5;
        private DevExpress.XtraReports.UI.XRSubreport srReportNotes;
        private DevExpress.XtraReports.UI.XRSubreport srReportSignature;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoPageNoOfTotal;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoCurrentDate;
        private DevExpress.XtraReports.UI.XRSubreport RationResIngNut_Ing;
        private DevExpress.XtraReports.UI.XRSubreport RationResIngNut_Nut;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.SubBand SubBand2;
        private DevExpress.XtraReports.UI.SubBand SubBand3;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private Finance.DataSets.dsFinance dsFinance1;
        private Finance.DataSets.dsFinanceTableAdapters.SR_FF_RequirementTableAdapter sR_FF_RequirementTableAdapter;
        private DevExpress.XtraReports.Parameters.Parameter ShowSignature;
        private DevExpress.XtraReports.Parameters.Parameter ShowSignatureAllPages;
        private DevExpress.XtraReports.Parameters.Parameter IsShowDM;
        private DevExpress.XtraReports.UI.SubBand SubBand4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.CalculatedField CopyRight;
    }
}
