namespace DevExpressReports.PredefinedReports
{
    partial class SR_FC_JournalEntry
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
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.Parameters.GroupLayoutItem groupLayoutItem1 = new DevExpress.XtraReports.Parameters.GroupLayoutItem("", false);
            DevExpress.XtraReports.Parameters.GroupLayoutItem groupLayoutItem2 = new DevExpress.XtraReports.Parameters.GroupLayoutItem("", true);
            this.ShowSignature = new DevExpress.XtraReports.Parameters.Parameter();
            this.ShowSignatureAllPages = new DevExpress.XtraReports.Parameters.Parameter();
            this.HideReportHeader = new DevExpress.XtraReports.Parameters.Parameter();
            this.HideReportFooter = new DevExpress.XtraReports.Parameters.Parameter();
            this.dsGeneralLedger1 = new DevExpressReports.Reports.GeneralLedger.DataSets.dsGeneralLedger();
            this.sR_FC_JournalEntryTableAdapter = new DevExpressReports.Reports.GeneralLedger.DataSets.dsGeneralLedgerTableAdapters.SR_FC_JournalEntryTableAdapter();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.lblVetSoftData = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfoCurrentTime = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfoCurrentDate = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfoPageNoOfTotal = new DevExpress.XtraReports.UI.XRPageInfo();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.tDetail = new DevExpress.XtraReports.UI.XRTable();
            this.trDetail = new DevExpress.XtraReports.UI.XRTableRow();
            this.tdAccount_From = new DevExpress.XtraReports.UI.XRTableCell();
            this.tdCostCenter = new DevExpress.XtraReports.UI.XRTableCell();
            this.tdDebit = new DevExpress.XtraReports.UI.XRTableCell();
            this.tdCredit = new DevExpress.XtraReports.UI.XRTableCell();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.SubBand5 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportSignature_PageFooter = new DevExpress.XtraReports.UI.XRSubreport();
            this.SubBand6 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportFooterCustom = new DevExpress.XtraReports.UI.XRSubreport();
            this.IsRTL = new DevExpress.XtraReports.Parameters.Parameter();
            this.FontSize = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.SubBand3 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportHeaderCustom = new DevExpress.XtraReports.UI.XRSubreport();
            this.SubBand4 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportHeader = new DevExpress.XtraReports.UI.XRSubreport();
            this.PageHeaderSub1 = new DevExpress.XtraReports.UI.SubBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.tHeader = new DevExpress.XtraReports.UI.XRTable();
            this.trHeader = new DevExpress.XtraReports.UI.XRTableRow();
            this.thAccount_From = new DevExpress.XtraReports.UI.XRTableCell();
            this.thCostCenter = new DevExpress.XtraReports.UI.XRTableCell();
            this.thDebit = new DevExpress.XtraReports.UI.XRTableCell();
            this.thCredit = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.ReportFooterSub1 = new DevExpress.XtraReports.UI.SubBand();
            this.tFooter = new DevExpress.XtraReports.UI.XRTable();
            this.trFooter = new DevExpress.XtraReports.UI.XRTableRow();
            this.tfTotal = new DevExpress.XtraReports.UI.XRTableCell();
            this.tfDebit_GPT = new DevExpress.XtraReports.UI.XRTableCell();
            this.tfCredit_GPT = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooterSub2 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportNotes = new DevExpress.XtraReports.UI.XRSubreport();
            this.SubBand2 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportSignature = new DevExpress.XtraReports.UI.XRSubreport();
            this.NoOfGroupsPerPage = new DevExpress.XtraReports.Parameters.Parameter();
            this.DateFrom = new DevExpress.XtraReports.Parameters.Parameter();
            this.DateTo = new DevExpress.XtraReports.Parameters.Parameter();
            this.IsCustomReportHeader = new DevExpress.XtraReports.Parameters.Parameter();
            this.IsCustomReportFooter = new DevExpress.XtraReports.Parameters.Parameter();
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
            // sR_FC_JournalEntryTableAdapter
            // 
            this.sR_FC_JournalEntryTableAdapter.ClearBeforeFill = true;
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
            this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("VoucherNo", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending),
            new DevExpress.XtraReports.UI.GroupField("DocNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
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
            this.tdAccount_From,
            this.tdCostCenter,
            this.tdDebit,
            this.tdCredit});
            this.trDetail.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "!IsNullOrEmpty([AccountName_From])")});
            this.trDetail.Name = "trDetail";
            // 
            // tdAccount_From
            // 
            this.tdAccount_From.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tdAccount_From.BorderWidth = 1.4F;
            this.tdAccount_From.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AccountName_From]")});
            this.tdAccount_From.Multiline = true;
            this.tdAccount_From.Name = "tdAccount_From";
            this.tdAccount_From.StylePriority.UseBorders = false;
            this.tdAccount_From.StylePriority.UseBorderWidth = false;
            this.tdAccount_From.StylePriority.UseFont = false;
            // 
            // tdCostCenter
            // 
            this.tdCostCenter.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tdCostCenter.BorderWidth = 1.4F;
            this.tdCostCenter.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CostCenter]")});
            this.tdCostCenter.Multiline = true;
            this.tdCostCenter.Name = "tdCostCenter";
            this.tdCostCenter.StylePriority.UseBorders = false;
            this.tdCostCenter.StylePriority.UseBorderWidth = false;
            this.tdCostCenter.StylePriority.UseFont = false;
            // 
            // tdDebit
            // 
            this.tdDebit.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tdDebit.BorderWidth = 1.4F;
            this.tdDebit.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Debit]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n")});
            this.tdDebit.Multiline = true;
            this.tdDebit.Name = "tdDebit";
            this.tdDebit.StylePriority.UseBorders = false;
            this.tdDebit.StylePriority.UseBorderWidth = false;
            this.tdDebit.StylePriority.UseFont = false;
            this.tdDebit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // tdCredit
            // 
            this.tdCredit.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tdCredit.BorderWidth = 1.4F;
            this.tdCredit.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Credit]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n\n")});
            this.tdCredit.Name = "tdCredit";
            this.tdCredit.StylePriority.UseBorders = false;
            this.tdCredit.StylePriority.UseBorderWidth = false;
            this.tdCredit.StylePriority.UseFont = false;
            this.tdCredit.StylePriority.UseTextAlignment = false;
            this.tdCredit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
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
            this.PageFooter.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?HideReportFooter==false")});
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand5,
            this.SubBand6});
            // 
            // SubBand5
            // 
            this.SubBand5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportSignature_PageFooter});
            this.SubBand5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?ShowSignature == True && ?ShowSignatureAllPages == True\n")});
            this.SubBand5.Name = "SubBand5";
            // 
            // srReportSignature_PageFooter
            // 
            this.srReportSignature_PageFooter.Name = "srReportSignature_PageFooter";
            this.srReportSignature_PageFooter.ReportSource = new DevExpressReports.PredefinedReports.SubReportSignature();
            // 
            // SubBand6
            // 
            this.SubBand6.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportFooterCustom});
            this.SubBand6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?IsCustomReportFooter")});
            this.SubBand6.Name = "SubBand6";
            // 
            // srReportFooterCustom
            // 
            this.srReportFooterCustom.Name = "srReportFooterCustom";
            this.srReportFooterCustom.ReportSource = new DevExpressReports.PredefinedReports.SubReportFooterCustom();
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
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand3,
            this.SubBand4,
            this.PageHeaderSub1,
            this.SubBand1});
            // 
            // SubBand3
            // 
            this.SubBand3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportHeaderCustom});
            this.SubBand3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?IsCustomReportHeader\nand ?HideReportHeader==false")});
            this.SubBand3.Name = "SubBand3";
            // 
            // srReportHeaderCustom
            // 
            this.srReportHeaderCustom.Name = "srReportHeaderCustom";
            this.srReportHeaderCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("HideReportHeader", this.HideReportHeader));
            this.srReportHeaderCustom.ReportSource = new DevExpressReports.PredefinedReports.SubReportHeaderCustom();
            // 
            // SubBand4
            // 
            this.SubBand4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportHeader});
            this.SubBand4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Not ?IsCustomReportHeader\nand ?HideReportHeader==false\n")});
            this.SubBand4.Name = "SubBand4";
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
            this.xrLabel1,
            this.xrLabel2});
            this.PageHeaderSub1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Not (IsNullOrEmpty(?DateFrom) And IsNullOrEmpty(?DateTo))")});
            this.PageHeaderSub1.Name = "PageHeaderSub1";
            // 
            // xrLabel1
            // 
            this.xrLabel1.CanGrow = false;
            this.xrLabel1.Name = "xrLabel1";
            // 
            // xrLabel2
            // 
            this.xrLabel2.CanGrow = false;
            this.xrLabel2.Name = "xrLabel2";
            // 
            // SubBand1
            // 
            this.SubBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tHeader});
            this.SubBand1.Name = "SubBand1";
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
            this.thAccount_From,
            this.thCostCenter,
            this.thDebit,
            this.thCredit});
            this.trHeader.Name = "trHeader";
            // 
            // thAccount_From
            // 
            this.thAccount_From.BorderWidth = 1.4F;
            this.thAccount_From.Multiline = true;
            this.thAccount_From.Name = "thAccount_From";
            this.thAccount_From.StylePriority.UseBorderWidth = false;
            this.thAccount_From.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // thCostCenter
            // 
            this.thCostCenter.BorderWidth = 1.4F;
            this.thCostCenter.Multiline = true;
            this.thCostCenter.Name = "thCostCenter";
            this.thCostCenter.StylePriority.UseBorderWidth = false;
            this.thCostCenter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // thDebit
            // 
            this.thDebit.BorderWidth = 1.4F;
            this.thDebit.Multiline = true;
            this.thDebit.Name = "thDebit";
            this.thDebit.StylePriority.UseBorderWidth = false;
            this.thDebit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // thCredit
            // 
            this.thCredit.BorderWidth = 1.4F;
            this.thCredit.Multiline = true;
            this.thCredit.Name = "thCredit";
            this.thCredit.StylePriority.UseBorderWidth = false;
            this.thCredit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.ReportFooterSub1,
            this.ReportFooterSub2,
            this.SubBand2});
            // 
            // ReportFooterSub1
            // 
            this.ReportFooterSub1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
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
            this.tfDebit_GPT,
            this.tfCredit_GPT});
            this.trFooter.Name = "trFooter";
            // 
            // tfTotal
            // 
            this.tfTotal.BorderWidth = 1.4F;
            this.tfTotal.Multiline = true;
            this.tfTotal.Name = "tfTotal";
            this.tfTotal.StylePriority.UseBorderWidth = false;
            // 
            // tfDebit_GPT
            // 
            this.tfDebit_GPT.BorderWidth = 1.4F;
            this.tfDebit_GPT.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Debit])"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n\n")});
            this.tfDebit_GPT.Multiline = true;
            this.tfDebit_GPT.Name = "tfDebit_GPT";
            this.tfDebit_GPT.StylePriority.UseBorderWidth = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.tfDebit_GPT.Summary = xrSummary1;
            this.tfDebit_GPT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // tfCredit_GPT
            // 
            this.tfCredit_GPT.BorderWidth = 1.4F;
            this.tfCredit_GPT.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Credit])"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n\n")});
            this.tfCredit_GPT.Multiline = true;
            this.tfCredit_GPT.Name = "tfCredit_GPT";
            this.tfCredit_GPT.StylePriority.UseBorderWidth = false;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.tfCredit_GPT.Summary = xrSummary2;
            this.tfCredit_GPT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ReportFooterSub2
            // 
            this.ReportFooterSub2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportNotes});
            this.ReportFooterSub2.Name = "ReportFooterSub2";
            // 
            // srReportNotes
            // 
            this.srReportNotes.Name = "srReportNotes";
            this.srReportNotes.ReportSource = new DevExpressReports.PredefinedReports.SubReportNotes();
            // 
            // SubBand2
            // 
            this.SubBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportSignature});
            this.SubBand2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?ShowSignature == True && ?ShowSignatureAllPages == False")});
            this.SubBand2.Name = "SubBand2";
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
            // IsCustomReportHeader
            // 
            this.IsCustomReportHeader.Name = "IsCustomReportHeader";
            this.IsCustomReportHeader.Type = typeof(bool);
            this.IsCustomReportHeader.ValueInfo = "False";
            this.IsCustomReportHeader.Visible = false;
            // 
            // IsCustomReportFooter
            // 
            this.IsCustomReportFooter.Name = "IsCustomReportFooter";
            this.IsCustomReportFooter.Type = typeof(bool);
            this.IsCustomReportFooter.ValueInfo = "False";
            this.IsCustomReportFooter.Visible = false;
            // 
            // SR_FC_JournalEntry
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
            this.DataMember = "SR_FC_JournalEntry";
            this.DataSource = this.dsGeneralLedger1;
            this.ExportOptions.Pdf.DocumentOptions.Author = "VetSoft";
            this.LocalizationItems.AddRange(new DevExpress.XtraReports.Localization.LocalizationItem[] {
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
            new DevExpress.XtraReports.Localization.LocalizationItem(this.IsCustomReportFooter, "Default", "Description", "IsCustomReportFooter"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.IsCustomReportHeader, "Default", "Description", "IsCustomReportHeader"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.IsRTL, "Default", "Description", "Right to left"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.IsRTL, "ar", "Description", "عرض من اليمبن لليسار"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblVetSoftData, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(4.768372E-05F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblVetSoftData, "Default", "SizeF", new System.Drawing.SizeF(100F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblVetSoftData, "Default", "Text", "lblVetSoftData"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.lblVetSoftData, "Default", "Visible", false),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.NoOfGroupsPerPage, "Default", "Description", "No of groups / page"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.NoOfGroupsPerPage, "ar", "Description", "عدد المجموعات / صفحة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageFooter, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeader, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeaderSub1, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentDate, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentDate, "Default", "SizeF", new System.Drawing.SizeF(204.12F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentTime, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(353.5F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentTime, "Default", "SizeF", new System.Drawing.SizeF(100F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentTime, "Default", "TextFormatString", "{0:HH:mm:ss}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoPageNoOfTotal, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(597.6668F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoPageNoOfTotal, "Default", "SizeF", new System.Drawing.SizeF(209.33F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoPageNoOfTotal, "Default", "TextFormatString", "Page {0} of {1}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooter, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooterSub1, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooterSub2, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignature, "Default", "Description", "Show signature"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignature, "ar", "Description", "عرض التوقيع"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignatureAllPages, "Default", "Description", "Show signature in all page"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignatureAllPages, "ar", "Description", "عرض التوقيع في كل الصفحات"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportFooterCustom, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportFooterCustom, "Default", "SizeF", new System.Drawing.SizeF(807F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportHeader, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1.00001F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportHeader, "Default", "SizeF", new System.Drawing.SizeF(804.9999F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportHeaderCustom, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportHeaderCustom, "Default", "SizeF", new System.Drawing.SizeF(804.9998F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportNotes, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportNotes, "Default", "SizeF", new System.Drawing.SizeF(807F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature, "Default", "SizeF", new System.Drawing.SizeF(807F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature_PageFooter, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature_PageFooter, "Default", "SizeF", new System.Drawing.SizeF(807F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "DisplayName", "Journal Entry Details"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "ar", "DisplayName", "قيود يومية تفصيلي"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Margins", new DevExpress.Drawing.DXMargins(10F, 10F, 20F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "PaperKind", DevExpress.Drawing.Printing.DXPaperKind.A4),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand1, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand2, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand3, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand4, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand5, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand6, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdAccount_From, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdAccount_From, "Default", "Text", "tdAccountName_From"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdAccount_From, "Default", "Weight", 3.6600258883421479D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCostCenter, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCostCenter, "Default", "Text", "tdCostCenter"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCostCenter, "Default", "Weight", 1.6378612785270195D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCredit, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCredit, "Default", "Text", "tdCredit"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCredit, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCredit, "Default", "Weight", 1.0614083095760172D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdDebit, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdDebit, "Default", "Text", "tdDebit"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdDebit, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdDebit, "Default", "Weight", 1.0065078573304949D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tDetail, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tDetail, "Default", "SizeF", new System.Drawing.SizeF(805F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfCredit_GPT, "Default", "Text", "tfCredit_GPT"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfCredit_GPT, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfCredit_GPT, "Default", "Weight", 0.42286688431248004D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfDebit_GPT, "Default", "Text", "tfDebit_GPT"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfDebit_GPT, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfDebit_GPT, "Default", "Weight", 0.40099360874912704D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tFooter, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tFooter, "Default", "SizeF", new System.Drawing.SizeF(805F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfTotal, "Default", "Text", "Total"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfTotal, "ar", "Text", "المجموع"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfTotal, "Default", "Weight", 2.1106869589980519D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thAccount_From, "Default", "Text", "Account Name"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thAccount_From, "ar", "Text", "الحساب"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thAccount_From, "Default", "Weight", 2.9813664236699373D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thCostCenter, "Default", "Text", "Cost Center"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thCostCenter, "ar", "Text", "مركز التكلفة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thCostCenter, "Default", "Weight", 1.3341610579606691D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thCredit, "Default", "Text", "Credit"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thCredit, "ar", "Text", "دائن"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thCredit, "Default", "Weight", 0.86459675925036028D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thDebit, "Default", "Text", "Debit"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thDebit, "ar", "Text", "مدين"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thDebit, "Default", "Weight", 0.81987575911903343D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tHeader, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0.999999F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tHeader, "Default", "SizeF", new System.Drawing.SizeF(805F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.TopMargin, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.trDetail, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.trFooter, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.trHeader, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(7.947286E-06F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "SizeF", new System.Drawing.SizeF(144.358F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "Text", "From: [?DateFrom!dd-MM-yyyy]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "ar", "Text", "من: [?DateFrom!dd-MM-yyyy]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(144.358F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "Default", "SizeF", new System.Drawing.SizeF(144.358F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "Default", "Text", "To: [?DateTo!dd-MM-yyyy]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "ar", "Text", "إلى: [?DateTo!dd-MM-yyyy]")});
            this.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            groupLayoutItem1.BorderVisible = false;
            groupLayoutItem1.Items.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.ShowSignature, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.ShowSignatureAllPages, DevExpress.XtraReports.Parameters.Orientation.Vertical)});
            groupLayoutItem1.ShowExpandButton = true;
            groupLayoutItem1.TitleVisible = false;
            groupLayoutItem2.Items.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.HideReportHeader, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.HideReportFooter, DevExpress.XtraReports.Parameters.Orientation.Vertical)});
            groupLayoutItem2.TitleVisible = false;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IsRTL, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IsCustomReportHeader, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IsCustomReportFooter, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            groupLayoutItem1,
            groupLayoutItem2,
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.NoOfGroupsPerPage, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.FontSize, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.DateFrom, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.DateTo, DevExpress.XtraReports.Parameters.Orientation.Vertical)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.IsRTL,
            this.IsCustomReportHeader,
            this.IsCustomReportFooter,
            this.ShowSignature,
            this.ShowSignatureAllPages,
            this.HideReportHeader,
            this.HideReportFooter,
            this.NoOfGroupsPerPage,
            this.FontSize,
            this.DateFrom,
            this.DateTo});
            this.ScriptReferencesString = "E:\\VetSoft Projects .Net2024\\VetSoft Projects\\VetSoftDevExpress\\bin\\Release\\net8." +
    "0\\VetSoftDevExpress.dll";
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailData3_Odd,
            this.PageInfo});
            this.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.Version = "24.2";
            ((System.ComponentModel.ISupportInitialize)(this.dsGeneralLedger1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion
        private Reports.GeneralLedger.DataSets.dsGeneralLedger dsGeneralLedger1;
        private Reports.GeneralLedger.DataSets.dsGeneralLedgerTableAdapters.SR_FC_JournalEntryTableAdapter sR_FC_JournalEntryTableAdapter;
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
        private DevExpress.XtraReports.UI.XRTableCell tdCredit;
        private DevExpress.XtraReports.UI.XRTableCell tdAccount_From;
        private DevExpress.XtraReports.UI.XRTableCell tdCostCenter;
        private DevExpress.XtraReports.UI.XRTableCell tdDebit;
        private DevExpress.XtraReports.UI.XRTable tHeader;
        private DevExpress.XtraReports.UI.XRTableRow trHeader;
        private DevExpress.XtraReports.UI.XRTableCell thAccount_From;
        private DevExpress.XtraReports.UI.XRTableCell thCostCenter;
        private DevExpress.XtraReports.UI.XRTableCell thDebit;
        private DevExpress.XtraReports.UI.XRTableCell thCredit;
        private DevExpress.XtraReports.Parameters.Parameter DateFrom;
        private DevExpress.XtraReports.Parameters.Parameter DateTo;
        private DevExpress.XtraReports.UI.XRTable tFooter;
        private DevExpress.XtraReports.UI.XRTableRow trFooter;
        private DevExpress.XtraReports.UI.XRTableCell tfTotal;
        private DevExpress.XtraReports.UI.XRTableCell tfDebit_GPT;
        private DevExpress.XtraReports.UI.XRTableCell tfCredit_GPT;
        private DevExpress.XtraReports.UI.XRLabel lblVetSoftData;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoCurrentTime;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoCurrentDate;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoPageNoOfTotal;
        private DevExpress.XtraReports.UI.SubBand SubBand1;
        private DevExpress.XtraReports.UI.SubBand SubBand2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.SubBand SubBand5;
        private DevExpress.XtraReports.UI.SubBand SubBand6;
        private DevExpress.XtraReports.UI.SubBand SubBand3;
        private DevExpress.XtraReports.UI.SubBand SubBand4;
        private DevExpress.XtraReports.UI.XRSubreport srReportHeaderCustom;
        private DevExpress.XtraReports.UI.XRSubreport srReportFooterCustom;
        private DevExpress.XtraReports.Parameters.Parameter IsCustomReportHeader;
        private DevExpress.XtraReports.Parameters.Parameter IsCustomReportFooter;
    }
}