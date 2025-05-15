namespace DevExpressReports.PredefinedReports
{
    partial class SR_FC_DealingsAndAccounts_OLD
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
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraPrinting.BarCode.QRCodeGenerator qrCodeGenerator1 = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();
            DevExpress.XtraReports.Parameters.GroupLayoutItem groupLayoutItem1 = new DevExpress.XtraReports.Parameters.GroupLayoutItem("Signature", false);
            DevExpress.XtraReports.Parameters.GroupLayoutItem groupLayoutItem2 = new DevExpress.XtraReports.Parameters.GroupLayoutItem("Report Header & Footer", true);
            this.ShowSignature = new DevExpress.XtraReports.Parameters.Parameter();
            this.ShowSignatureAllPages = new DevExpress.XtraReports.Parameters.Parameter();
            this.HideReportHeader = new DevExpress.XtraReports.Parameters.Parameter();
            this.HideReportFooter = new DevExpress.XtraReports.Parameters.Parameter();
            this.dsGeneralLedger1 = new DevExpressReports.Reports.GeneralLedger.DataSets.dsGeneralLedger();
            this.sR_FC_DealingsAndAccountsTableAdapter = new DevExpressReports.Reports.GeneralLedger.DataSets.dsGeneralLedgerTableAdapters.SR_FC_DealingsAndAccountsTableAdapter();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.lblVetSoftData = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfoCurrentTime = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfoCurrentDate = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfoPageNoOfTotal = new DevExpress.XtraReports.UI.XRPageInfo();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.tDetail = new DevExpress.XtraReports.UI.XRTable();
            this.trDetail = new DevExpress.XtraReports.UI.XRTableRow();
            this.tdSerialNo = new DevExpress.XtraReports.UI.XRTableCell();
            this.tdProduct = new DevExpress.XtraReports.UI.XRTableCell();
            this.tdCostCenter = new DevExpress.XtraReports.UI.XRTableCell();
            this.tdDebit = new DevExpress.XtraReports.UI.XRTableCell();
            this.tdCredit = new DevExpress.XtraReports.UI.XRTableCell();
            this.tdJournalNote = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.srReportSignature_PageFooter = new DevExpress.XtraReports.UI.XRSubreport();
            this.IsRTL = new DevExpress.XtraReports.Parameters.Parameter();
            this.FontSize = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.srReportHeader = new DevExpress.XtraReports.UI.XRSubreport();
            this.PageHeaderSub1 = new DevExpress.XtraReports.UI.SubBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.lblCustomer = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblSupplier = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeaderSub2 = new DevExpress.XtraReports.UI.SubBand();
            this.xrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeaderSub3 = new DevExpress.XtraReports.UI.SubBand();
            this.xrPanel3 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeaderSub4 = new DevExpress.XtraReports.UI.SubBand();
            this.tHeader = new DevExpress.XtraReports.UI.XRTable();
            this.trHeader = new DevExpress.XtraReports.UI.XRTableRow();
            this.thSr = new DevExpress.XtraReports.UI.XRTableCell();
            this.thProduct = new DevExpress.XtraReports.UI.XRTableCell();
            this.thQty = new DevExpress.XtraReports.UI.XRTableCell();
            this.thUnit = new DevExpress.XtraReports.UI.XRTableCell();
            this.thUnitPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.thSellingPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.thDiscount = new DevExpress.XtraReports.UI.XRTableCell();
            this.thExtras = new DevExpress.XtraReports.UI.XRTableCell();
            this.thTotalPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.ReportFooterSub1 = new DevExpress.XtraReports.UI.SubBand();
            this.tFooter = new DevExpress.XtraReports.UI.XRTable();
            this.trFooter = new DevExpress.XtraReports.UI.XRTableRow();
            this.tfTotal = new DevExpress.XtraReports.UI.XRTableCell();
            this.tfSellingPrice_GT = new DevExpress.XtraReports.UI.XRTableCell();
            this.tfCredit_GPT = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooterSub2 = new DevExpress.XtraReports.UI.SubBand();
            this.ReportFooterSub3 = new DevExpress.XtraReports.UI.SubBand();
            this.ReportFooterSub4 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportNotes = new DevExpress.XtraReports.UI.XRSubreport();
            this.ReportFooterSub5 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportSignature = new DevExpress.XtraReports.UI.XRSubreport();
            this.NoOfGroupsPerPage = new DevExpress.XtraReports.Parameters.Parameter();
            this.DateFrom = new DevExpress.XtraReports.Parameters.Parameter();
            this.DateTo = new DevExpress.XtraReports.Parameters.Parameter();
            this.ActionType = new DevExpress.XtraReports.Parameters.Parameter();
            this.TotalPriceAsText = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooterSub6 = new DevExpress.XtraReports.UI.SubBand();
            this.ReportFooterSub7 = new DevExpress.XtraReports.UI.SubBand();
            this.ReportFooterSub8 = new DevExpress.XtraReports.UI.SubBand();
            this.SubBand2 = new DevExpress.XtraReports.UI.SubBand();
            this.xrBarCode1 = new DevExpress.XtraReports.UI.XRBarCode();
            ((System.ComponentModel.ISupportInitialize)(this.dsGeneralLedger1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
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
            // HideReportHeader
            // 
            this.HideReportHeader.Name = "HideReportHeader";
            this.HideReportHeader.Type = typeof(bool);
            this.HideReportHeader.ValueInfo = "False";
            // 
            // HideReportFooter
            // 
            this.HideReportFooter.Name = "HideReportFooter";
            this.HideReportFooter.Type = typeof(bool);
            this.HideReportFooter.ValueInfo = "False";
            // 
            // dsGeneralLedger1
            // 
            this.dsGeneralLedger1.DataSetName = "dsGeneralLedger";
            this.dsGeneralLedger1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sR_FC_DealingsAndAccountsTableAdapter
            // 
            this.sR_FC_DealingsAndAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblVetSoftData});
            this.TopMargin.Name = "TopMargin";
            // 
            // lblVetSoftData
            // 
            this.lblVetSoftData.LockedInUserDesigner = true;
            this.lblVetSoftData.Multiline = true;
            this.lblVetSoftData.Name = "lblVetSoftData";
            this.lblVetSoftData.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrLabel16
            // 
            this.xrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DocNumber]")});
            this.xrLabel16.Multiline = true;
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.StylePriority.UseBorders = false;
            this.xrLabel16.StylePriority.UseFont = false;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel10.Multiline = true;
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.StylePriority.UseFont = false;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfoCurrentTime,
            this.pageInfoCurrentDate,
            this.pageInfoPageNoOfTotal});
            this.BottomMargin.Name = "BottomMargin";
            // 
            // pageInfoCurrentTime
            // 
            this.pageInfoCurrentTime.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.pageInfoCurrentTime.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.pageInfoCurrentTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pageInfoCurrentTime.Name = "pageInfoCurrentTime";
            this.pageInfoCurrentTime.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pageInfoCurrentTime.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfoCurrentTime.StyleName = "PageInfo";
            this.pageInfoCurrentTime.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // pageInfoCurrentDate
            // 
            this.pageInfoCurrentDate.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.pageInfoCurrentDate.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.pageInfoCurrentDate.Name = "pageInfoCurrentDate";
            this.pageInfoCurrentDate.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfoCurrentDate.StyleName = "PageInfo";
            this.pageInfoCurrentDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // pageInfoPageNoOfTotal
            // 
            this.pageInfoPageNoOfTotal.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.pageInfoPageNoOfTotal.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.pageInfoPageNoOfTotal.Name = "pageInfoPageNoOfTotal";
            this.pageInfoPageNoOfTotal.StyleName = "PageInfo";
            this.pageInfoPageNoOfTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tDetail});
            this.Detail.Name = "Detail";
            // 
            // tDetail
            // 
            this.tDetail.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.tDetail.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tDetail.Name = "tDetail";
            this.tDetail.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.trDetail});
            this.tDetail.StylePriority.UseBorders = false;
            // 
            // trDetail
            // 
            this.trDetail.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tdSerialNo,
            this.tdProduct,
            this.tdCostCenter,
            this.tdDebit,
            this.tdCredit,
            this.tdJournalNote,
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
            this.trDetail.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "!IsNullOrEmpty([tStActionID])")});
            this.trDetail.Name = "trDetail";
            // 
            // tdSerialNo
            // 
            this.tdSerialNo.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tdSerialNo.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SerialNo]")});
            this.tdSerialNo.Multiline = true;
            this.tdSerialNo.Name = "tdSerialNo";
            this.tdSerialNo.StylePriority.UseBorders = false;
            this.tdSerialNo.StylePriority.UseFont = false;
            this.tdSerialNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // tdProduct
            // 
            this.tdProduct.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tdProduct.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Product]")});
            this.tdProduct.Multiline = true;
            this.tdProduct.Name = "tdProduct";
            this.tdProduct.StylePriority.UseBorders = false;
            this.tdProduct.StylePriority.UseFont = false;
            // 
            // tdCostCenter
            // 
            this.tdCostCenter.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tdCostCenter.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ActualQty]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')")});
            this.tdCostCenter.Multiline = true;
            this.tdCostCenter.Name = "tdCostCenter";
            this.tdCostCenter.StylePriority.UseBorders = false;
            this.tdCostCenter.StylePriority.UseFont = false;
            this.tdCostCenter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // tdDebit
            // 
            this.tdDebit.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tdDebit.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Unit]")});
            this.tdDebit.Multiline = true;
            this.tdDebit.Name = "tdDebit";
            this.tdDebit.StylePriority.UseBorders = false;
            this.tdDebit.StylePriority.UseFont = false;
            this.tdDebit.StylePriority.UseTextAlignment = false;
            this.tdDebit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // tdCredit
            // 
            this.tdCredit.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tdCredit.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PriceUnit]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')")});
            this.tdCredit.Name = "tdCredit";
            this.tdCredit.StylePriority.UseBorders = false;
            this.tdCredit.StylePriority.UseFont = false;
            this.tdCredit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // tdJournalNote
            // 
            this.tdJournalNote.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tdJournalNote.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SellingPrice]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')")});
            this.tdJournalNote.Multiline = true;
            this.tdJournalNote.Name = "tdJournalNote";
            this.tdJournalNote.StylePriority.UseBorders = false;
            this.tdJournalNote.StylePriority.UseFont = false;
            this.tdJournalNote.StylePriority.UseTextAlignment = false;
            this.tdJournalNote.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Discount]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')")});
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseBorders = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Extras]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')")});
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseBorders = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalPrice]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')")});
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseBorders = false;
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
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
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportSignature_PageFooter});
            this.PageFooter.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?ShowSignature == True && ?ShowSignatureAllPages == True")});
            this.PageFooter.Name = "PageFooter";
            // 
            // srReportSignature_PageFooter
            // 
            this.srReportSignature_PageFooter.Name = "srReportSignature_PageFooter";
            this.srReportSignature_PageFooter.ReportSource = new DevExpressReports.PredefinedReports.SubReportSignature();
            // 
            // IsRTL
            // 
            this.IsRTL.Name = "IsRTL";
            this.IsRTL.Type = typeof(bool);
            this.IsRTL.ValueInfo = "False";
            this.IsRTL.Visible = false;
            // 
            // FontSize
            // 
            this.FontSize.Name = "FontSize";
            this.FontSize.Visible = false;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportHeader});
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.PageHeaderSub1,
            this.SubBand1,
            this.PageHeaderSub2,
            this.PageHeaderSub3,
            this.PageHeaderSub4});
            // 
            // srReportHeader
            // 
            this.srReportHeader.Name = "srReportHeader";
            this.srReportHeader.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("HideReportHeader", this.HideReportHeader));
            this.srReportHeader.ReportSource = new DevExpressReports.PredefinedReports.SubReportHeader();
            // 
            // PageHeaderSub1
            // 
            this.PageHeaderSub1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.xrLabel1});
            this.PageHeaderSub1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Not (IsNullOrEmpty(?DateFrom) And IsNullOrEmpty(?DateTo))")});
            this.PageHeaderSub1.Name = "PageHeaderSub1";
            // 
            // xrLabel2
            // 
            this.xrLabel2.CanGrow = false;
            this.xrLabel2.Name = "xrLabel2";
            // 
            // xrLabel1
            // 
            this.xrLabel1.CanGrow = false;
            this.xrLabel1.Name = "xrLabel1";
            // 
            // SubBand1
            // 
            this.SubBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
            this.SubBand1.Name = "SubBand1";
            // 
            // xrPanel1
            // 
            this.xrPanel1.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.xrPanel1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblCustomer,
            this.xrLabel4,
            this.lblSupplier,
            this.xrLabel16,
            this.xrLabel10,
            this.xrLabel18,
            this.xrLabel17,
            this.xrLabel13,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel20});
            this.xrPanel1.Name = "xrPanel1";
            // 
            // lblCustomer
            // 
            this.lblCustomer.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblCustomer.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?ActionType == 18 || ?ActionType == 19")});
            this.lblCustomer.Multiline = true;
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.StylePriority.UseBorders = false;
            this.lblCustomer.StylePriority.UseFont = false;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[To]")});
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseFont = false;
            // 
            // lblSupplier
            // 
            this.lblSupplier.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.lblSupplier.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?ActionType == 16 || ?ActionType == 17")});
            this.lblSupplier.Multiline = true;
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.StylePriority.UseBorders = false;
            this.lblSupplier.StylePriority.UseFont = false;
            // 
            // xrLabel18
            // 
            this.xrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Currency]")});
            this.xrLabel18.Multiline = true;
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.StylePriority.UseBorders = false;
            this.xrLabel18.StylePriority.UseFont = false;
            // 
            // xrLabel17
            // 
            this.xrLabel17.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[RegDate]")});
            this.xrLabel17.Multiline = true;
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.StylePriority.UseBorders = false;
            this.xrLabel17.StylePriority.UseFont = false;
            // 
            // xrLabel13
            // 
            this.xrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "!IsNullOrEmpty([ReceivingOrder])")});
            this.xrLabel13.Multiline = true;
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.StylePriority.UseBorders = false;
            this.xrLabel13.StylePriority.UseFont = false;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel12.Multiline = true;
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.StylePriority.UseFont = false;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel11.Multiline = true;
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UseFont = false;
            // 
            // xrLabel20
            // 
            this.xrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ReceivingOrder]")});
            this.xrLabel20.Multiline = true;
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.StylePriority.UseBorders = false;
            this.xrLabel20.StylePriority.UseFont = false;
            // 
            // PageHeaderSub2
            // 
            this.PageHeaderSub2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel2});
            this.PageHeaderSub2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "!IsNullOrEmpty([BillStatement])")});
            this.PageHeaderSub2.Name = "PageHeaderSub2";
            // 
            // xrPanel2
            // 
            this.xrPanel2.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrPanel2.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrPanel2.CanGrow = false;
            this.xrPanel2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.xrLabel7});
            this.xrPanel2.Name = "xrPanel2";
            // 
            // xrLabel5
            // 
            this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BillStatement]")});
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.StylePriority.UseBorders = false;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel7.CanGrow = false;
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.StylePriority.UseBorders = false;
            // 
            // PageHeaderSub3
            // 
            this.PageHeaderSub3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel3});
            this.PageHeaderSub3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "!IsNullOrEmpty([BillNote])")});
            this.PageHeaderSub3.Name = "PageHeaderSub3";
            // 
            // xrPanel3
            // 
            this.xrPanel3.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrPanel3.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrPanel3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6,
            this.xrLabel8});
            this.xrPanel3.Name = "xrPanel3";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BillNote]")});
            this.xrLabel6.Name = "xrLabel6";
            // 
            // xrLabel8
            // 
            this.xrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel8.CanGrow = false;
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.StylePriority.UseBorders = false;
            // 
            // PageHeaderSub4
            // 
            this.PageHeaderSub4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tHeader});
            this.PageHeaderSub4.Name = "PageHeaderSub4";
            // 
            // tHeader
            // 
            this.tHeader.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.tHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.tHeader.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tHeader.Name = "tHeader";
            this.tHeader.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.trHeader});
            this.tHeader.StylePriority.UseBackColor = false;
            this.tHeader.StylePriority.UseBorders = false;
            // 
            // trHeader
            // 
            this.trHeader.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.thSr,
            this.thProduct,
            this.thQty,
            this.thUnit,
            this.thUnitPrice,
            this.thSellingPrice,
            this.thDiscount,
            this.thExtras,
            this.thTotalPrice});
            this.trHeader.Name = "trHeader";
            // 
            // thSr
            // 
            this.thSr.Multiline = true;
            this.thSr.Name = "thSr";
            this.thSr.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // thProduct
            // 
            this.thProduct.Multiline = true;
            this.thProduct.Name = "thProduct";
            this.thProduct.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // thQty
            // 
            this.thQty.Multiline = true;
            this.thQty.Name = "thQty";
            this.thQty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // thUnit
            // 
            this.thUnit.Multiline = true;
            this.thUnit.Name = "thUnit";
            this.thUnit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // thUnitPrice
            // 
            this.thUnitPrice.Multiline = true;
            this.thUnitPrice.Name = "thUnitPrice";
            this.thUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // thSellingPrice
            // 
            this.thSellingPrice.Multiline = true;
            this.thSellingPrice.Name = "thSellingPrice";
            this.thSellingPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // thDiscount
            // 
            this.thDiscount.Multiline = true;
            this.thDiscount.Name = "thDiscount";
            this.thDiscount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // thExtras
            // 
            this.thExtras.Multiline = true;
            this.thExtras.Name = "thExtras";
            this.thExtras.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // thTotalPrice
            // 
            this.thTotalPrice.Multiline = true;
            this.thTotalPrice.Name = "thTotalPrice";
            this.thTotalPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.ReportFooterSub1,
            this.ReportFooterSub2,
            this.ReportFooterSub3,
            this.ReportFooterSub4,
            this.ReportFooterSub5,
            this.ReportFooterSub6,
            this.ReportFooterSub7,
            this.ReportFooterSub8,
            this.SubBand2});
            // 
            // ReportFooterSub1
            // 
            this.ReportFooterSub1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel9,
            this.xrLabel3,
            this.tFooter});
            this.ReportFooterSub1.Name = "ReportFooterSub1";
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
            this.tfSellingPrice_GT,
            this.tfCredit_GPT,
            this.xrTableCell8,
            this.xrTableCell4});
            this.trFooter.Name = "trFooter";
            // 
            // tfTotal
            // 
            this.tfTotal.Multiline = true;
            this.tfTotal.Name = "tfTotal";
            // 
            // tfSellingPrice_GT
            // 
            this.tfSellingPrice_GT.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([SellingPrice])")});
            this.tfSellingPrice_GT.Multiline = true;
            this.tfSellingPrice_GT.Name = "tfSellingPrice_GT";
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.tfSellingPrice_GT.Summary = xrSummary2;
            this.tfSellingPrice_GT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // tfCredit_GPT
            // 
            this.tfCredit_GPT.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif(sumSum([Discount]) = 0, null, sumSum([Discount]))")});
            this.tfCredit_GPT.Multiline = true;
            this.tfCredit_GPT.Name = "tfCredit_GPT";
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.tfCredit_GPT.Summary = xrSummary3;
            this.tfCredit_GPT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif(sumSum([Extras]) = 0, null, sumSum([Extras]))")});
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell8.Summary = xrSummary4;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([TotalPrice])")});
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell4.Summary = xrSummary5;
            // 
            // ReportFooterSub2
            // 
            this.ReportFooterSub2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel14,
            this.xrLabel15});
            this.ReportFooterSub2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "IsNull([Expenses], 0) <> 0")});
            this.ReportFooterSub2.Name = "ReportFooterSub2";
            // 
            // ReportFooterSub3
            // 
            this.ReportFooterSub3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel21,
            this.xrLabel19});
            this.ReportFooterSub3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "IsNull([Discounts], 0) <> 0")});
            this.ReportFooterSub3.Name = "ReportFooterSub3";
            // 
            // ReportFooterSub4
            // 
            this.ReportFooterSub4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel22,
            this.xrLabel23});
            this.ReportFooterSub4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "IsNull([Vat], 0) <> 0")});
            this.ReportFooterSub4.Name = "ReportFooterSub4";
            // 
            // srReportNotes
            // 
            this.srReportNotes.Name = "srReportNotes";
            this.srReportNotes.ReportSource = new DevExpressReports.PredefinedReports.SubReportNotes();
            // 
            // ReportFooterSub5
            // 
            this.ReportFooterSub5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel25,
            this.xrLabel24});
            this.ReportFooterSub5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "IsNull([DATax], 0) <> 0")});
            this.ReportFooterSub5.Name = "ReportFooterSub5";
            // 
            // srReportSignature
            // 
            this.srReportSignature.Name = "srReportSignature";
            this.srReportSignature.ReportSource = new DevExpressReports.PredefinedReports.SubReportSignature();
            // 
            // NoOfGroupsPerPage
            // 
            this.NoOfGroupsPerPage.Name = "NoOfGroupsPerPage";
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
            // ActionType
            // 
            this.ActionType.Enabled = false;
            this.ActionType.Name = "ActionType";
            this.ActionType.Visible = false;
            // 
            // TotalPriceAsText
            // 
            this.TotalPriceAsText.Enabled = false;
            this.TotalPriceAsText.Name = "TotalPriceAsText";
            this.TotalPriceAsText.Visible = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([TotalPrice])")});
            this.xrLabel9.Multiline = true;
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrLabel9.Summary = xrSummary1;
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel14.Multiline = true;
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.StylePriority.UseBorders = false;
            this.xrLabel14.StylePriority.UseFont = false;
            // 
            // xrLabel15
            // 
            this.xrLabel15.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Expenses]")});
            this.xrLabel15.Multiline = true;
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.StylePriority.UseBorders = false;
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel19
            // 
            this.xrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel19.Multiline = true;
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.StylePriority.UseBorders = false;
            this.xrLabel19.StylePriority.UseFont = false;
            // 
            // xrLabel21
            // 
            this.xrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel21.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Discounts]")});
            this.xrLabel21.Multiline = true;
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.StylePriority.UseBorders = false;
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel22
            // 
            this.xrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Vat]")});
            this.xrLabel22.Multiline = true;
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.StylePriority.UseBorders = false;
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel23
            // 
            this.xrLabel23.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel23.Multiline = true;
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.StylePriority.UseBorders = false;
            this.xrLabel23.StylePriority.UseFont = false;
            // 
            // xrLabel24
            // 
            this.xrLabel24.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel24.Multiline = true;
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.StylePriority.UseBorders = false;
            this.xrLabel24.StylePriority.UseFont = false;
            // 
            // xrLabel25
            // 
            this.xrLabel25.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel25.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DATax]")});
            this.xrLabel25.Multiline = true;
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.StylePriority.UseBorders = false;
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.StylePriority.UseTextAlignment = false;
            this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel26
            // 
            this.xrLabel26.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel26.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BillTotalPrice]")});
            this.xrLabel26.Multiline = true;
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.StylePriority.UseBorders = false;
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.StylePriority.UseTextAlignment = false;
            this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel27
            // 
            this.xrLabel27.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel27.Multiline = true;
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.StylePriority.UseBorders = false;
            this.xrLabel27.StylePriority.UseFont = false;
            // 
            // xrLabel28
            // 
            this.xrLabel28.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel28.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?TotalPriceAsText")});
            this.xrLabel28.Multiline = true;
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.StylePriority.UseBorders = false;
            this.xrLabel28.StylePriority.UseFont = false;
            // 
            // ReportFooterSub6
            // 
            this.ReportFooterSub6.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel28,
            this.xrLabel26,
            this.xrLabel27});
            this.ReportFooterSub6.Name = "ReportFooterSub6";
            // 
            // ReportFooterSub7
            // 
            this.ReportFooterSub7.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportNotes});
            this.ReportFooterSub7.Name = "ReportFooterSub7";
            // 
            // ReportFooterSub8
            // 
            this.ReportFooterSub8.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportSignature});
            this.ReportFooterSub8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?ShowSignature == True && ?ShowSignatureAllPages == False")});
            this.ReportFooterSub8.Name = "ReportFooterSub8";
            // 
            // SubBand2
            // 
            this.SubBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrBarCode1});
            this.SubBand2.Name = "SubBand2";
            // 
            // xrBarCode1
            // 
            this.xrBarCode1.Name = "xrBarCode1";
            this.xrBarCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 96F);
            this.xrBarCode1.Symbology = qrCodeGenerator1;
            // 
            // SR_FC_DealingsAndAccounts
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.PageFooter,
            this.PageHeader,
            this.ReportFooter});
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.BorderWidth = 0.5F;
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dsGeneralLedger1});
            this.DataMember = "SR_FC_DealingsAndAccounts";
            this.DataSource = this.dsGeneralLedger1;
            this.ExportOptions.Pdf.DocumentOptions.Author = "VetSoft";
            this.LocalizationItems.AddRange(new DevExpress.XtraReports.Localization.LocalizationItem[] {
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ActionType, "Default", "Description", "Action Type"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ActionType, "ar", "Description", "نوع الحركة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.BottomMargin, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateFrom, "Default", "Description", "From"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateFrom, "ar", "Description", "من"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateTo, "Default", "Description", "To"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateTo, "ar", "Description", "إلى"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.Detail, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.FontSize, "Default", "Description", "Font Size"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.FontSize, "ar", "Description", "حجم الخط"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.HideReportFooter, "Default", "Description", "Hide report footer"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.HideReportFooter, "ar", "Description", "إخفاء ذيل التقرير"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.HideReportHeader, "Default", "Description", "Hide report header"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.HideReportHeader, "ar", "Description", "إخفاء رأس التقرير"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.IsRTL, "Default", "Description", "Right to left"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.IsRTL, "ar", "Description", "عرض من اليمبن لليسار"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblCustomer, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblCustomer, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1.585484E-05F, 39.99999F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblCustomer, "Default", "SizeF", new System.Drawing.SizeF(79.99998F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblCustomer, "Default", "Text", "Customer:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblCustomer, "ar", "Text", "العميل:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblSupplier, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblSupplier, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1.585484E-05F, 39.99999F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblSupplier, "Default", "SizeF", new System.Drawing.SizeF(79.99998F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblSupplier, "Default", "Text", "Supplier:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblSupplier, "ar", "Text", "المورد:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblVetSoftData, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(4.768372E-05F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblVetSoftData, "Default", "SizeF", new System.Drawing.SizeF(100F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblVetSoftData, "Default", "Text", "lblVetSoftData"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblVetSoftData, "Default", "Visible", false),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.NoOfGroupsPerPage, "Default", "Description", "No of groups / page"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.NoOfGroupsPerPage, "ar", "Description", "عدد المجموعات / صفحة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageFooter, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeader, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeaderSub1, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeaderSub2, "Default", "HeightF", 30F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeaderSub3, "Default", "HeightF", 30F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeaderSub4, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentDate, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentDate, "Default", "SizeF", new System.Drawing.SizeF(204.12F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentTime, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(353.5F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentTime, "Default", "SizeF", new System.Drawing.SizeF(100F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentTime, "Default", "TextFormatString", "{0:HH:mm:ss}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoPageNoOfTotal, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(597.6668F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoPageNoOfTotal, "Default", "SizeF", new System.Drawing.SizeF(209.33F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoPageNoOfTotal, "Default", "TextFormatString", "Page {0} of {1}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooter, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooterSub1, "Default", "HeightF", 50F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooterSub2, "Default", "HeightF", 30F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooterSub3, "Default", "HeightF", 30F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooterSub4, "Default", "HeightF", 30F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooterSub5, "Default", "HeightF", 30F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooterSub6, "Default", "HeightF", 70F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooterSub7, "Default", "HeightF", 20.5555F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooterSub8, "Default", "HeightF", 21.35417F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignature, "Default", "Description", "Show signature"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignature, "ar", "Description", "عرض التوقيع"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignatureAllPages, "Default", "Description", "Show signature in all page"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignatureAllPages, "ar", "Description", "عرض التوقيع في كل الصفحات"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportHeader, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportHeader, "Default", "SizeF", new System.Drawing.SizeF(807F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportNotes, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportNotes, "Default", "SizeF", new System.Drawing.SizeF(807F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature, "Default", "SizeF", new System.Drawing.SizeF(807F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature_PageFooter, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature_PageFooter, "Default", "SizeF", new System.Drawing.SizeF(807F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "DisplayName", "Bill"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "ar", "DisplayName", "الفاتورة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Margins", new DevExpress.Drawing.DXMargins(10F, 10F, 20F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "PaperKind", DevExpress.Drawing.Printing.DXPaperKind.A4),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand1, "Default", "HeightF", 70F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand2, "Default", "Visible", false),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCostCenter, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCostCenter, "Default", "Text", ""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCostCenter, "Default", "Weight", 1.7422093321852186D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCredit, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCredit, "Default", "Text", ""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCredit, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCredit, "Default", "Weight", 1.6333211957860503D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdDebit, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdDebit, "Default", "Text", ""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdDebit, "Default", "TextFormatString", ""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdDebit, "Default", "Weight", 1.6333211687453491D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tDetail, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tDetail, "Default", "SizeF", new System.Drawing.SizeF(806F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdJournalNote, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdJournalNote, "Default", "Text", ""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdJournalNote, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdJournalNote, "Default", "Weight", 2.1777616779530753D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdProduct, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdProduct, "Default", "Text", ""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdProduct, "Default", "TextFormatString", ""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdProduct, "Default", "Weight", 4.8999636713110029D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdSerialNo, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdSerialNo, "Default", "Weight", 0.65332848000535582D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfCredit_GPT, "Default", "Text", ""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfCredit_GPT, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfCredit_GPT, "Default", "Weight", 0.2679893658112617D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tFooter, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tFooter, "Default", "SizeF", new System.Drawing.SizeF(806F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfSellingPrice_GT, "Default", "Text", ""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfSellingPrice_GT, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfSellingPrice_GT, "Default", "Weight", 0.44664921444664407D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfTotal, "Default", "Text", "Total"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfTotal, "ar", "Text", "الإجمالي"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfTotal, "Default", "Weight", 2.166247323675611D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thDiscount, "Default", "Text", "Discounts"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thDiscount, "ar", "Text", "خصومات"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thDiscount, "Default", "Weight", 0.81284775730254888D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tHeader, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tHeader, "Default", "SizeF", new System.Drawing.SizeF(806F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thExtras, "Default", "Text", "Extras"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thExtras, "ar", "Text", "إضافات"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thExtras, "Default", "Weight", 0.812847757302549D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thProduct, "Default", "Text", "Product / Item"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thProduct, "ar", "Text", "المنتج / الصنف"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thProduct, "Default", "Weight", 3.048178719707888D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thQty, "Default", "Text", "Quantity"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thQty, "ar", "Text", "الكمية"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thQty, "Default", "Weight", 1.083797657786377D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thSellingPrice, "Default", "Text", "Sub-Total"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thSellingPrice, "ar", "Text", "إجمالي فرعي"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thSellingPrice, "Default", "Weight", 1.3547462587400085D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thSr, "Default", "Text", "Sr."),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thSr, "ar", "Text", "م."),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thSr, "Default", "Weight", 0.40642386996556379D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thTotalPrice, "Default", "Text", "Total"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thTotalPrice, "ar", "Text", "الإجمالي"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thTotalPrice, "Default", "Weight", 1.3682941347116917D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thUnit, "Default", "Text", "Unit"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thUnit, "ar", "Text", "الوحدة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thUnit, "Default", "Weight", 1.0160601512006249D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thUnitPrice, "Default", "Text", "Unit Price"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thUnitPrice, "ar", "Text", "سعر الوحدة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thUnitPrice, "Default", "Weight", 1.0160584972475633D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.TopMargin, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.TotalPriceAsText, "Default", "Description", "TotalPrice As Text"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.TotalPriceAsText, "ar", "Description", "الإجمالي كتابة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.trDetail, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.trFooter, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.trHeader, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrBarCode1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(429.9167F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrBarCode1, "Default", "SizeF", new System.Drawing.SizeF(377.0833F, 75F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrBarCode1, "Default", "Text", "https://www.sooscloud.com"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(7.947286E-06F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "SizeF", new System.Drawing.SizeF(144.358F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "Text", "From: [?DateFrom!dd-MM-yyyy]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "ar", "Text", "من: [?DateFrom!dd-MM-yyyy]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel10, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel10, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 10.00001F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel10, "Default", "SizeF", new System.Drawing.SizeF(79.99999F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel10, "Default", "Text", "Bill No:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel10, "ar", "Text", "رقم الفاتورة:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel10, "Default", "Visible", true),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel11, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel11, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(183.8882F, 10F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel11, "Default", "SizeF", new System.Drawing.SizeF(49.1118F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel11, "Default", "Text", "Date:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel11, "ar", "Text", "التاريخ:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel12, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel12, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(342.0833F, 10F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel12, "Default", "SizeF", new System.Drawing.SizeF(59.5285F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel12, "Default", "Text", "Currency:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel12, "ar", "Text", "العملة:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel13, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel13, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(517.453F, 10F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel13, "Default", "SizeF", new System.Drawing.SizeF(108.0663F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel13, "Default", "Text", "Receiving Order(s):"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel13, "ar", "Text", "إذن الاستلام:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel14, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel14, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1F, 9.999998F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel14, "Default", "SizeF", new System.Drawing.SizeF(204.12F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel14, "Default", "Text", "Expenses"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel14, "ar", "Text", "المصروفات"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel15, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel15, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(206.1201F, 9.999983F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel15, "Default", "SizeF", new System.Drawing.SizeF(113.5416F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel15, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel16, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel16, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(86.61198F, 10.00001F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel16, "Default", "SizeF", new System.Drawing.SizeF(99.99997F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel16, "Default", "Text", ""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel16, "Default", "Visible", true),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel17, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel17, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(233F, 10F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel17, "Default", "SizeF", new System.Drawing.SizeF(100F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel17, "Default", "Text", ""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel17, "Default", "TextFormatString", "{0:dd-MM-yyyy}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel18, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel18, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(401.6118F, 10F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel18, "Default", "SizeF", new System.Drawing.SizeF(100F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel18, "Default", "Text", ""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel19, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel19, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1F, 10F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel19, "Default", "SizeF", new System.Drawing.SizeF(204.12F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel19, "Default", "Text", "Discount"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel19, "ar", "Text", "الخصم"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(144.358F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "Default", "SizeF", new System.Drawing.SizeF(144.358F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "Default", "Text", "To: [?DateTo!dd-MM-yyyy]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "ar", "Text", "إلى: [?DateTo!dd-MM-yyyy]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel20, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel20, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(625.5193F, 10F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel20, "Default", "SizeF", new System.Drawing.SizeF(180.4807F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel20, "Default", "Text", ""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel21, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel21, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(206.1201F, 10F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel21, "Default", "SizeF", new System.Drawing.SizeF(113.5416F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel21, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel22, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel22, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(206.1201F, 10F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel22, "Default", "SizeF", new System.Drawing.SizeF(113.5416F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel22, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel23, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel23, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1F, 10F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel23, "Default", "SizeF", new System.Drawing.SizeF(204.12F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel23, "Default", "Text", "VAT"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel23, "ar", "Text", "ضريبة القيمة المضافة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel24, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel24, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1F, 10F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel24, "Default", "SizeF", new System.Drawing.SizeF(204.12F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel24, "Default", "Text", "Discount & Addition Tax"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel24, "ar", "Text", "ضريبة الخصم والإضافة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel25, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel25, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(206.1201F, 10F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel25, "Default", "SizeF", new System.Drawing.SizeF(113.5416F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel25, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel26, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel26, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(206.12F, 10F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel26, "Default", "SizeF", new System.Drawing.SizeF(113.5416F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel26, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel27, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel27, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1F, 10F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel27, "Default", "SizeF", new System.Drawing.SizeF(204.12F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel27, "Default", "Text", "Total Due"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel27, "ar", "Text", "الإجمالي المستحق"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel28, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel28, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1F, 40F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel28, "Default", "SizeF", new System.Drawing.SizeF(806F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1F, 30F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "Default", "SizeF", new System.Drawing.SizeF(204.12F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "Default", "Text", "Total Before Taxes"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "ar", "Text", "الإجمالي قبل الضرائب"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel4, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel4, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(86.61196F, 39.99999F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel4, "Default", "SizeF", new System.Drawing.SizeF(717.388F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel4, "Default", "Text", ""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel5, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(86.61182F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel5, "Default", "SizeF", new System.Drawing.SizeF(718.3883F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel5, "Default", "Text", ""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel6, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(86.61182F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel6, "Default", "SizeF", new System.Drawing.SizeF(718.3883F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel6, "Default", "Text", ""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel7, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel7, "Default", "SizeF", new System.Drawing.SizeF(80F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel7, "Default", "Text", "Statement:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel7, "ar", "Text", "البيان:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel8, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel8, "Default", "SizeF", new System.Drawing.SizeF(79.99998F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel8, "Default", "Text", "Notes:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel8, "ar", "Text", "الملاحظات:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel9, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel9, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(206.1201F, 30F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel9, "Default", "SizeF", new System.Drawing.SizeF(113.5416F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel9, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrPanel1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrPanel1, "Default", "SizeF", new System.Drawing.SizeF(806F, 70F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrPanel2, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrPanel2, "Default", "SizeF", new System.Drawing.SizeF(806F, 30F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrPanel3, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrPanel3, "Default", "SizeF", new System.Drawing.SizeF(806F, 30F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell1, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell1, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell1, "Default", "Weight", 1.3066570283199495D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell2, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell2, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell2, "Default", "Weight", 1.306657028319949D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell3, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell3, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell3, "Default", "Weight", 2.1995394609889249D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell4, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell4, "Default", "Weight", 0.45111526386310685D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell8, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell8, "Default", "Weight", 0.26798936422358921D)});
            this.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            groupLayoutItem1.BorderVisible = false;
            groupLayoutItem1.Items.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.ShowSignature, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.ShowSignatureAllPages, DevExpress.XtraReports.Parameters.Orientation.Vertical)});
            groupLayoutItem1.ShowExpandButton = true;
            groupLayoutItem1.Title = "Signature";
            groupLayoutItem1.TitleVisible = false;
            groupLayoutItem2.Items.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.HideReportHeader, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.HideReportFooter, DevExpress.XtraReports.Parameters.Orientation.Vertical)});
            groupLayoutItem2.Title = "Report Header & Footer";
            groupLayoutItem2.TitleVisible = false;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IsRTL, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            groupLayoutItem1,
            groupLayoutItem2,
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.NoOfGroupsPerPage, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.FontSize, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.DateFrom, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.DateTo, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.ActionType, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.TotalPriceAsText, DevExpress.XtraReports.Parameters.Orientation.Vertical)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.IsRTL,
            this.ShowSignature,
            this.ShowSignatureAllPages,
            this.HideReportHeader,
            this.HideReportFooter,
            this.NoOfGroupsPerPage,
            this.FontSize,
            this.DateFrom,
            this.DateTo,
            this.ActionType,
            this.TotalPriceAsText});
            this.ScriptReferencesString = "E:\\VetSoft Projects .Net2024\\VetSoft Projects\\VetSoftDevExpress\\bin\\Release\\net8." +
    "0\\VetSoftDevExpress.dll";
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailData3_Odd,
            this.PageInfo});
            this.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.Version = "23.2";
            ((System.ComponentModel.ISupportInitialize)(this.dsGeneralLedger1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion
        private Reports.GeneralLedger.DataSets.dsGeneralLedger dsGeneralLedger1;
        private Reports.GeneralLedger.DataSets.dsGeneralLedgerTableAdapters.SR_FC_DealingsAndAccountsTableAdapter sR_FC_DealingsAndAccountsTableAdapter;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRSubreport srReportHeader;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.SubBand ReportFooterSub1;
        private DevExpress.XtraReports.UI.XRSubreport srReportSignature;
        private DevExpress.XtraReports.UI.XRSubreport srReportSignature_PageFooter;
        private DevExpress.XtraReports.Parameters.Parameter ShowSignatureAllPages;
        private DevExpress.XtraReports.Parameters.Parameter ShowSignature;
        private DevExpress.XtraReports.Parameters.Parameter IsRTL;
        private DevExpress.XtraReports.Parameters.Parameter HideReportHeader;
        private DevExpress.XtraReports.Parameters.Parameter HideReportFooter;
        private DevExpress.XtraReports.Parameters.Parameter NoOfGroupsPerPage;
        private DevExpress.XtraReports.UI.XRSubreport srReportNotes;
        private DevExpress.XtraReports.UI.SubBand PageHeaderSub1;
        private DevExpress.XtraReports.UI.SubBand ReportFooterSub2;
        private DevExpress.XtraReports.Parameters.Parameter FontSize;
        private DevExpress.XtraReports.UI.XRTable tDetail;
        private DevExpress.XtraReports.UI.XRTableRow trDetail;
        private DevExpress.XtraReports.UI.XRTableCell tdSerialNo;
        private DevExpress.XtraReports.UI.XRTableCell tdCredit;
        private DevExpress.XtraReports.UI.XRTableCell tdProduct;
        private DevExpress.XtraReports.UI.XRTableCell tdCostCenter;
        private DevExpress.XtraReports.UI.XRTableCell tdDebit;
        private DevExpress.XtraReports.UI.XRTable tHeader;
        private DevExpress.XtraReports.UI.XRTableRow trHeader;
        private DevExpress.XtraReports.UI.XRTableCell thSr;
        private DevExpress.XtraReports.UI.XRTableCell thProduct;
        private DevExpress.XtraReports.UI.XRTableCell thQty;
        private DevExpress.XtraReports.UI.XRTableCell thUnit;
        private DevExpress.XtraReports.UI.XRTableCell thUnitPrice;
        private DevExpress.XtraReports.UI.XRTableCell thSellingPrice;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.Parameters.Parameter DateFrom;
        private DevExpress.XtraReports.Parameters.Parameter DateTo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRPanel xrPanel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRPanel xrPanel3;
        private DevExpress.XtraReports.UI.XRTable tFooter;
        private DevExpress.XtraReports.UI.XRTableRow trFooter;
        private DevExpress.XtraReports.UI.XRTableCell tfTotal;
        private DevExpress.XtraReports.UI.XRTableCell tfSellingPrice_GT;
        private DevExpress.XtraReports.UI.XRTableCell tfCredit_GPT;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableCell tdJournalNote;
        private DevExpress.XtraReports.UI.XRLabel lblVetSoftData;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoCurrentTime;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoCurrentDate;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoPageNoOfTotal;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel lblSupplier;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel lblCustomer;
        private DevExpress.XtraReports.Parameters.Parameter ActionType;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell thDiscount;
        private DevExpress.XtraReports.UI.XRTableCell thExtras;
        private DevExpress.XtraReports.UI.XRTableCell thTotalPrice;
        private DevExpress.XtraReports.UI.SubBand SubBand1;
        private DevExpress.XtraReports.UI.SubBand PageHeaderSub2;
        private DevExpress.XtraReports.UI.SubBand PageHeaderSub3;
        private DevExpress.XtraReports.UI.SubBand PageHeaderSub4;
        private DevExpress.XtraReports.UI.SubBand ReportFooterSub3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.Parameters.Parameter TotalPriceAsText;
        private DevExpress.XtraReports.UI.SubBand ReportFooterSub4;
        private DevExpress.XtraReports.UI.SubBand ReportFooterSub5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel22;
        private DevExpress.XtraReports.UI.XRLabel xrLabel23;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel xrLabel26;
        private DevExpress.XtraReports.UI.XRLabel xrLabel27;
        private DevExpress.XtraReports.UI.XRLabel xrLabel24;
        private DevExpress.XtraReports.UI.XRLabel xrLabel25;
        private DevExpress.XtraReports.UI.XRLabel xrLabel28;
        private DevExpress.XtraReports.UI.SubBand ReportFooterSub6;
        private DevExpress.XtraReports.UI.SubBand ReportFooterSub7;
        private DevExpress.XtraReports.UI.SubBand ReportFooterSub8;
        private DevExpress.XtraReports.UI.SubBand SubBand2;
        private DevExpress.XtraReports.UI.XRBarCode xrBarCode1;
    }
}