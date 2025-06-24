namespace DevExpressReports.PredefinedReports
{
    partial class SR_FC_AccountSheet
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
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary6 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary7 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary8 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.Parameters.GroupLayoutItem groupLayoutItem1 = new DevExpress.XtraReports.Parameters.GroupLayoutItem("", false);
            DevExpress.XtraReports.Parameters.GroupLayoutItem groupLayoutItem2 = new DevExpress.XtraReports.Parameters.GroupLayoutItem("", true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SR_FC_AccountSheet));
            this.ShowSignature = new DevExpress.XtraReports.Parameters.Parameter();
            this.ShowSignatureAllPages = new DevExpress.XtraReports.Parameters.Parameter();
            this.HideReportHeader = new DevExpress.XtraReports.Parameters.Parameter();
            this.HideReportFooter = new DevExpress.XtraReports.Parameters.Parameter();
            this.dsGeneralLedger1 = new DevExpressReports.Reports.GeneralLedger.DataSets.dsGeneralLedger();
            this.sR_FC_AccountSheetTableAdapter = new DevExpressReports.Reports.GeneralLedger.DataSets.dsGeneralLedgerTableAdapters.SR_FC_JournalEntryTableAdapter();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.lblVetSoftData = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfoCurrentTime = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfoCurrentDate = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfoPageNoOfTotal = new DevExpress.XtraReports.UI.XRPageInfo();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.tDetail = new DevExpress.XtraReports.UI.XRTable();
            this.trDetail = new DevExpress.XtraReports.UI.XRTableRow();
            this.tdDate = new DevExpress.XtraReports.UI.XRTableCell();
            this.tdDebit = new DevExpress.XtraReports.UI.XRTableCell();
            this.tdCredit = new DevExpress.XtraReports.UI.XRTableCell();
            this.tdDebitBal = new DevExpress.XtraReports.UI.XRTableCell();
            this.tdCreditBal = new DevExpress.XtraReports.UI.XRTableCell();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.SubBand3 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportSignature_PageFooter = new DevExpress.XtraReports.UI.XRSubreport();
            this.SubBand4 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportFooterCustom = new DevExpress.XtraReports.UI.XRSubreport();
            this.IsRTL = new DevExpress.XtraReports.Parameters.Parameter();
            this.FontSize = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportHeaderCustom = new DevExpress.XtraReports.UI.XRSubreport();
            this.SubBand2 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportHeader = new DevExpress.XtraReports.UI.XRSubreport();
            this.PageHeaderSub1 = new DevExpress.XtraReports.UI.SubBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.ReportFooterSub1 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportNotes = new DevExpress.XtraReports.UI.XRSubreport();
            this.ReportFooterSub2 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportSignature = new DevExpress.XtraReports.UI.XRSubreport();
            this.NoOfGroupsPerPage = new DevExpress.XtraReports.Parameters.Parameter();
            this.DateFrom = new DevExpress.XtraReports.Parameters.Parameter();
            this.DateTo = new DevExpress.XtraReports.Parameters.Parameter();
            this.DebitMinusCredit = new DevExpress.XtraReports.UI.CalculatedField();
            this.sR_FC_AccountSheetTableAdapter1 = new DevExpressReports.Reports.GeneralLedger.DataSets.dsGeneralLedgerTableAdapters.SR_FC_AccountSheetTableAdapter();
            this.tfCreditBal_GPT = new DevExpress.XtraReports.UI.XRTableCell();
            this.tfDebitBal_GPT = new DevExpress.XtraReports.UI.XRTableCell();
            this.tfCredit_GPT = new DevExpress.XtraReports.UI.XRTableCell();
            this.tfDebit_GPT = new DevExpress.XtraReports.UI.XRTableCell();
            this.tfTotal = new DevExpress.XtraReports.UI.XRTableCell();
            this.trFooter = new DevExpress.XtraReports.UI.XRTableRow();
            this.tFooter = new DevExpress.XtraReports.UI.XRTable();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.thOpenCredit_GPT = new DevExpress.XtraReports.UI.XRTableCell();
            this.thOpenDebit_GPT = new DevExpress.XtraReports.UI.XRTableCell();
            this.thOpenBalance = new DevExpress.XtraReports.UI.XRTableCell();
            this.thAccountName = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.GroupHeaderSub2 = new DevExpress.XtraReports.UI.SubBand();
            this.thCreditBal = new DevExpress.XtraReports.UI.XRTableCell();
            this.thDebitBal = new DevExpress.XtraReports.UI.XRTableCell();
            this.thCredit = new DevExpress.XtraReports.UI.XRTableCell();
            this.thDebit = new DevExpress.XtraReports.UI.XRTableCell();
            this.thDate2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.trHeader2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.thBalance = new DevExpress.XtraReports.UI.XRTableCell();
            this.thMovement = new DevExpress.XtraReports.UI.XRTableCell();
            this.thDate1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.trHeader1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tHeader = new DevExpress.XtraReports.UI.XRTable();
            this.GroupHeaderSub1 = new DevExpress.XtraReports.UI.SubBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.IsCustomReportFooter = new DevExpress.XtraReports.Parameters.Parameter();
            this.IsCustomReportHeader = new DevExpress.XtraReports.Parameters.Parameter();
            this.AccountDim = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dsGeneralLedger1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHeader)).BeginInit();
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
            // sR_FC_AccountSheetTableAdapter
            // 
            this.sR_FC_AccountSheetTableAdapter.ClearBeforeFill = true;
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
            this.pageInfoCurrentTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pageInfoCurrentTime.Name = "pageInfoCurrentTime";
            this.pageInfoCurrentTime.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pageInfoCurrentTime.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfoCurrentTime.StyleName = "PageInfo";
            this.pageInfoCurrentTime.StylePriority.UseTextAlignment = false;
            this.pageInfoCurrentTime.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // pageInfoCurrentDate
            // 
            this.pageInfoCurrentDate.Name = "pageInfoCurrentDate";
            this.pageInfoCurrentDate.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfoCurrentDate.StyleName = "PageInfo";
            this.pageInfoCurrentDate.StylePriority.UseTextAlignment = false;
            this.pageInfoCurrentDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // pageInfoPageNoOfTotal
            // 
            this.pageInfoPageNoOfTotal.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right;
            this.pageInfoPageNoOfTotal.Name = "pageInfoPageNoOfTotal";
            this.pageInfoPageNoOfTotal.StyleName = "PageInfo";
            this.pageInfoPageNoOfTotal.StylePriority.UseTextAlignment = false;
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
            this.tdDate,
            this.tdDebit,
            this.tdCredit,
            this.tdDebitBal,
            this.tdCreditBal});
            this.trDetail.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "!IsNullOrEmpty([RegDate])")});
            this.trDetail.Name = "trDetail";
            // 
            // tdDate
            // 
            this.tdDate.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tdDate.Multiline = true;
            this.tdDate.Name = "tdDate";
            this.tdDate.StylePriority.UseBorders = false;
            this.tdDate.StylePriority.UseFont = false;
            this.tdDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // tdDebit
            // 
            this.tdDebit.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tdDebit.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n")});
            this.tdDebit.Multiline = true;
            this.tdDebit.Name = "tdDebit";
            this.tdDebit.StylePriority.UseBorders = false;
            this.tdDebit.StylePriority.UseFont = false;
            this.tdDebit.StylePriority.UseTextAlignment = false;
            this.tdDebit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // tdCredit
            // 
            this.tdCredit.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tdCredit.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n")});
            this.tdCredit.Multiline = true;
            this.tdCredit.Name = "tdCredit";
            this.tdCredit.StylePriority.UseBorders = false;
            this.tdCredit.StylePriority.UseFont = false;
            this.tdCredit.StylePriority.UseTextAlignment = false;
            this.tdCredit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // tdDebitBal
            // 
            this.tdDebitBal.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tdDebitBal.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "iif\n(\n\tIsNull([OpenBalance], 0) + sumRunningSum([DebitMinusCredit]) > 0,\n\tIsNull(" +
                    "[OpenBalance], 0) + sumRunningSum([DebitMinusCredit]),\n\tnull\n)")});
            this.tdDebitBal.Multiline = true;
            this.tdDebitBal.Name = "tdDebitBal";
            this.tdDebitBal.StylePriority.UseBorders = false;
            this.tdDebitBal.StylePriority.UseFont = false;
            this.tdDebitBal.StylePriority.UseTextAlignment = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.tdDebitBal.Summary = xrSummary1;
            this.tdDebitBal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // tdCreditBal
            // 
            this.tdCreditBal.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tdCreditBal.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "iif\n(\n\tIsNull([OpenBalance], 0) + sumRunningSum([DebitMinusCredit]) < 0,\n\tAbs(IsN" +
                    "ull([OpenBalance]) + sumRunningSum([DebitMinusCredit])),\n\tnull\n)")});
            this.tdCreditBal.Multiline = true;
            this.tdCreditBal.Name = "tdCreditBal";
            this.tdCreditBal.StylePriority.UseBorders = false;
            this.tdCreditBal.StylePriority.UseFont = false;
            this.tdCreditBal.StylePriority.UseTextAlignment = false;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.tdCreditBal.Summary = xrSummary2;
            this.tdCreditBal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
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
            this.SubBand3,
            this.SubBand4});
            // 
            // SubBand3
            // 
            this.SubBand3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportSignature_PageFooter});
            this.SubBand3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?ShowSignature == True And ?ShowSignatureAllPages == True\n")});
            this.SubBand3.Name = "SubBand3";
            // 
            // srReportSignature_PageFooter
            // 
            this.srReportSignature_PageFooter.Name = "srReportSignature_PageFooter";
            this.srReportSignature_PageFooter.ReportSource = new DevExpressReports.PredefinedReports.SubReportSignature();
            // 
            // SubBand4
            // 
            this.SubBand4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportFooterCustom});
            this.SubBand4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?IsCustomReportFooter")});
            this.SubBand4.Name = "SubBand4";
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
            this.SubBand1,
            this.SubBand2,
            this.PageHeaderSub1});
            // 
            // SubBand1
            // 
            this.SubBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportHeaderCustom});
            this.SubBand1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?IsCustomReportHeader\nand ?HideReportHeader==false\n\n\n\n")});
            this.SubBand1.Name = "SubBand1";
            // 
            // srReportHeaderCustom
            // 
            this.srReportHeaderCustom.Name = "srReportHeaderCustom";
            this.srReportHeaderCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("HideReportHeader", this.HideReportHeader));
            this.srReportHeaderCustom.ReportSource = new DevExpressReports.PredefinedReports.SubReportHeaderCustom();
            // 
            // SubBand2
            // 
            this.SubBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportHeader});
            this.SubBand2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Not ?IsCustomReportHeader\nand ?HideReportHeader==false\n\n\n\n")});
            this.SubBand2.Name = "SubBand2";
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
            this.xrLabel6,
            this.xrLabel3,
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
            // ReportFooter
            // 
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.ReportFooterSub1,
            this.ReportFooterSub2});
            // 
            // ReportFooterSub1
            // 
            this.ReportFooterSub1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportNotes});
            this.ReportFooterSub1.Name = "ReportFooterSub1";
            // 
            // srReportNotes
            // 
            this.srReportNotes.Name = "srReportNotes";
            this.srReportNotes.ReportSource = new DevExpressReports.PredefinedReports.SubReportNotes();
            // 
            // ReportFooterSub2
            // 
            this.ReportFooterSub2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportSignature});
            this.ReportFooterSub2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?ShowSignature == True And ?ShowSignatureAllPages == False")});
            this.ReportFooterSub2.Name = "ReportFooterSub2";
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
            // DebitMinusCredit
            // 
            this.DebitMinusCredit.DataMember = "SR_FC_AccountSheet";
            this.DebitMinusCredit.Expression = "IsNull([Debit], 0) - IsNull([Credit], 0)";
            this.DebitMinusCredit.FieldType = DevExpress.XtraReports.UI.FieldType.Decimal;
            this.DebitMinusCredit.Name = "DebitMinusCredit";
            // 
            // sR_FC_AccountSheetTableAdapter1
            // 
            this.sR_FC_AccountSheetTableAdapter1.ClearBeforeFill = true;
            // 
            // tfCreditBal_GPT
            // 
            this.tfCreditBal_GPT.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\r\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "iif\n(\n\tIsNull([OpenBalance], 0) + sumSum([DebitMinusCredit]) < 0,\n\tAbs(IsNull([Op" +
                    "enBalance], 0) + sumSum([DebitMinusCredit])),\n\tnull\n)")});
            this.tfCreditBal_GPT.Multiline = true;
            this.tfCreditBal_GPT.Name = "tfCreditBal_GPT";
            this.tfCreditBal_GPT.StylePriority.UseTextAlignment = false;
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.tfCreditBal_GPT.Summary = xrSummary3;
            this.tfCreditBal_GPT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // tfDebitBal_GPT
            // 
            this.tfDebitBal_GPT.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "iif\n(\n\tIsNull([OpenBalance], 0) + sumSum([DebitMinusCredit]) > 0,\n\tIsNull([OpenBa" +
                    "lance], 0) + sumSum([DebitMinusCredit]),\n\tnull\n)")});
            this.tfDebitBal_GPT.Multiline = true;
            this.tfDebitBal_GPT.Name = "tfDebitBal_GPT";
            this.tfDebitBal_GPT.StylePriority.UseTextAlignment = false;
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.tfDebitBal_GPT.Summary = xrSummary4;
            this.tfDebitBal_GPT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // tfCredit_GPT
            // 
            this.tfCredit_GPT.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Credit])")});
            this.tfCredit_GPT.Multiline = true;
            this.tfCredit_GPT.Name = "tfCredit_GPT";
            this.tfCredit_GPT.StylePriority.UseTextAlignment = false;
            xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.tfCredit_GPT.Summary = xrSummary5;
            this.tfCredit_GPT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // tfDebit_GPT
            // 
            this.tfDebit_GPT.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Debit])\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\r\n")});
            this.tfDebit_GPT.Multiline = true;
            this.tfDebit_GPT.Name = "tfDebit_GPT";
            this.tfDebit_GPT.StylePriority.UseTextAlignment = false;
            xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.tfDebit_GPT.Summary = xrSummary6;
            this.tfDebit_GPT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // tfTotal
            // 
            this.tfTotal.Multiline = true;
            this.tfTotal.Name = "tfTotal";
            // 
            // trFooter
            // 
            this.trFooter.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tfTotal,
            this.tfDebit_GPT,
            this.tfCredit_GPT,
            this.tfDebitBal_GPT,
            this.tfCreditBal_GPT});
            this.trFooter.Name = "trFooter";
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
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tFooter});
            this.GroupFooter1.Name = "GroupFooter1";
            this.GroupFooter1.Scripts.OnBeforePrint = "GroupFooter1_BeforePrint";
            // 
            // thOpenCredit_GPT
            // 
            this.thOpenCredit_GPT.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([OpenBalance] < 0, Abs([OpenBalance]), null)"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n")});
            this.thOpenCredit_GPT.Multiline = true;
            this.thOpenCredit_GPT.Name = "thOpenCredit_GPT";
            this.thOpenCredit_GPT.StylePriority.UseFont = false;
            this.thOpenCredit_GPT.StylePriority.UseTextAlignment = false;
            xrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.thOpenCredit_GPT.Summary = xrSummary7;
            this.thOpenCredit_GPT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // thOpenDebit_GPT
            // 
            this.thOpenDebit_GPT.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif([OpenBalance] > 0, [OpenBalance], null)"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n")});
            this.thOpenDebit_GPT.Multiline = true;
            this.thOpenDebit_GPT.Name = "thOpenDebit_GPT";
            this.thOpenDebit_GPT.StylePriority.UseFont = false;
            this.thOpenDebit_GPT.StylePriority.UseTextAlignment = false;
            xrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.thOpenDebit_GPT.Summary = xrSummary8;
            this.thOpenDebit_GPT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // thOpenBalance
            // 
            this.thOpenBalance.Multiline = true;
            this.thOpenBalance.Name = "thOpenBalance";
            this.thOpenBalance.StylePriority.UseFont = false;
            this.thOpenBalance.StylePriority.UseTextAlignment = false;
            this.thOpenBalance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // thAccountName
            // 
            this.thAccountName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[AccountName]")});
            this.thAccountName.Multiline = true;
            this.thAccountName.Name = "thAccountName";
            this.thAccountName.StylePriority.UseFont = false;
            this.thAccountName.StylePriority.UseTextAlignment = false;
            this.thAccountName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.thAccountName,
            this.thOpenBalance,
            this.thOpenDebit_GPT,
            this.thOpenCredit_GPT});
            this.xrTableRow1.Name = "xrTableRow1";
            // 
            // xrTable1
            // 
            this.xrTable1.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrTable1.BackColor = System.Drawing.Color.Transparent;
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.StylePriority.UseBackColor = false;
            this.xrTable1.StylePriority.UseBorders = false;
            // 
            // GroupHeaderSub2
            // 
            this.GroupHeaderSub2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.GroupHeaderSub2.Name = "GroupHeaderSub2";
            // 
            // thCreditBal
            // 
            this.thCreditBal.Multiline = true;
            this.thCreditBal.Name = "thCreditBal";
            this.thCreditBal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // thDebitBal
            // 
            this.thDebitBal.Multiline = true;
            this.thDebitBal.Name = "thDebitBal";
            this.thDebitBal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // thCredit
            // 
            this.thCredit.Multiline = true;
            this.thCredit.Name = "thCredit";
            this.thCredit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // thDebit
            // 
            this.thDebit.Multiline = true;
            this.thDebit.Name = "thDebit";
            this.thDebit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // thDate2
            // 
            this.thDate2.Multiline = true;
            this.thDate2.Name = "thDate2";
            this.thDate2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // trHeader2
            // 
            this.trHeader2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.thDate2,
            this.thDebit,
            this.thCredit,
            this.thDebitBal,
            this.thCreditBal});
            this.trHeader2.Name = "trHeader2";
            // 
            // thBalance
            // 
            this.thBalance.Multiline = true;
            this.thBalance.Name = "thBalance";
            this.thBalance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // thMovement
            // 
            this.thMovement.Multiline = true;
            this.thMovement.Name = "thMovement";
            this.thMovement.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // thDate1
            // 
            this.thDate1.Multiline = true;
            this.thDate1.Name = "thDate1";
            this.thDate1.RowSpan = 2;
            this.thDate1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // trHeader1
            // 
            this.trHeader1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.thDate1,
            this.thMovement,
            this.thBalance});
            this.trHeader1.Name = "trHeader1";
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
            this.trHeader1,
            this.trHeader2});
            this.tHeader.StylePriority.UseBackColor = false;
            this.tHeader.StylePriority.UseBorders = false;
            // 
            // GroupHeaderSub1
            // 
            this.GroupHeaderSub1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tHeader});
            this.GroupHeaderSub1.Name = "GroupHeaderSub1";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("AccountName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.GroupHeaderSub1,
            this.GroupHeaderSub2});
            // 
            // IsCustomReportFooter
            // 
            this.IsCustomReportFooter.Name = "IsCustomReportFooter";
            this.IsCustomReportFooter.Type = typeof(bool);
            this.IsCustomReportFooter.ValueInfo = "False";
            this.IsCustomReportFooter.Visible = false;
            // 
            // IsCustomReportHeader
            // 
            this.IsCustomReportHeader.Name = "IsCustomReportHeader";
            this.IsCustomReportHeader.Type = typeof(bool);
            this.IsCustomReportHeader.ValueInfo = "False";
            this.IsCustomReportHeader.Visible = false;
            // 
            // AccountDim
            // 
            this.AccountDim.Name = "AccountDim";
            this.AccountDim.Visible = false;
            // 
            // xrLabel6
            // 
            this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "!IsNullOrEmpty(?AccountDim)\n")});
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "!IsNullOrEmpty(?AccountDim)\n")});
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.Scripts.OnBeforePrint = "xrLabel3_BeforePrint";
            // 
            // SR_FC_AccountSheet
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.Detail,
            this.BottomMargin,
            this.PageFooter,
            this.PageHeader,
            this.ReportFooter,
            this.GroupHeader1,
            this.GroupFooter1});
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.BorderWidth = 0.5F;
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.DebitMinusCredit});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dsGeneralLedger1});
            this.DataMember = "SR_FC_AccountSheet";
            this.DataSource = this.dsGeneralLedger1;
            this.ExportOptions.Pdf.DocumentOptions.Author = "VetSoft";
            this.LocalizationItems.AddRange(new DevExpress.XtraReports.Localization.LocalizationItem[] {
            new DevExpress.XtraReports.Localization.LocalizationItem(this.AccountDim, "Default", "Description", "AccountDim"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.BottomMargin, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateFrom, "Default", "Description", "From"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateFrom, "ar", "Description", "من"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateTo, "Default", "Description", "To"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateTo, "ar", "Description", "إلى"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.Detail, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.FontSize, "Default", "Description", "Font Size"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.FontSize, "ar", "Description", "حجم الخط"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.GroupFooter1, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.GroupHeader1, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.GroupHeaderSub1, "Default", "HeightF", 40F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.GroupHeaderSub2, "Default", "HeightF", 20F),
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
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeaderSub1, "Default", "HeightF", 20.00003F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentDate, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentDate, "Default", "SizeF", new System.Drawing.SizeF(204.12F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentTime, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(355.0001F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentTime, "Default", "SizeF", new System.Drawing.SizeF(101F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentTime, "Default", "TextFormatString", "{0:HH:mm:ss}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoPageNoOfTotal, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(597.67F, 0F)),
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
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportHeader, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportHeader, "Default", "SizeF", new System.Drawing.SizeF(807F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportHeaderCustom, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportHeaderCustom, "Default", "SizeF", new System.Drawing.SizeF(804.9998F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportNotes, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportNotes, "Default", "SizeF", new System.Drawing.SizeF(807F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature, "Default", "SizeF", new System.Drawing.SizeF(807F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature_PageFooter, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature_PageFooter, "Default", "SizeF", new System.Drawing.SizeF(807F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "DisplayName", "Account Sheet Summary"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "ar", "DisplayName", "كشف حساب تجميعي"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Margins", new DevExpress.Drawing.DXMargins(10F, 10F, 20F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "PaperKind", DevExpress.Drawing.Printing.DXPaperKind.A4),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand1, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand2, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand3, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand4, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCredit, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCredit, "Default", "Text", "[Credit!N2]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCredit, "Default", "Weight", 0.36231884057971014D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCreditBal, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCreditBal, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCreditBal, "Default", "Weight", 0.36231884057971014D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdDate, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdDate, "Default", "Text", "[RegDate!dd-MM-yyyy]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdDate, "Default", "Weight", 0.21739130434782608D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdDebit, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdDebit, "Default", "Text", "[Debit!N2]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdDebit, "Default", "Weight", 0.36231884057971014D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdDebitBal, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdDebitBal, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdDebitBal, "Default", "Weight", 0.36231884057971009D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tDetail, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tDetail, "Default", "SizeF", new System.Drawing.SizeF(805F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfCreditBal_GPT, "Default", "Text", "tfCreditBal_GPT"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfCreditBal_GPT, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfCreditBal_GPT, "Default", "Weight", 0.88509379954405643D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfCredit_GPT, "Default", "Text", "tfCredit_GPT"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfCredit_GPT, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfCredit_GPT, "Default", "Weight", 0.88509377353086438D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfDebitBal_GPT, "Default", "Text", "tfDebitBal_GPT"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfDebitBal_GPT, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfDebitBal_GPT, "Default", "Weight", 0.8850937472648599D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfDebit_GPT, "Default", "Text", "tfDebit_GPT"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfDebit_GPT, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfDebit_GPT, "Default", "Weight", 0.88509374484618708D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tFooter, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tFooter, "Default", "SizeF", new System.Drawing.SizeF(805F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfTotal, "Default", "Text", "Total"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfTotal, "ar", "Text", "المجموع"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tfTotal, "Default", "Weight", 0.53105626373968706D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thAccountName, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thAccountName, "Default", "Weight", 2.3821658837706807D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thBalance, "Default", "Text", "Balance"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thBalance, "ar", "Text", "الرصيد"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thBalance, "Default", "Weight", 1.8957601897751837D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thCredit, "Default", "Text", "Credit"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thCredit, "ar", "Text", "دائن"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thCredit, "Default", "Weight", 0.94788011558089358D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thCreditBal, "Default", "Text", "Credit"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thCreditBal, "ar", "Text", "دائن"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thCreditBal, "Default", "Weight", 0.947880136106846D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thDate1, "Default", "Text", "Date"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thDate1, "ar", "Text", "التاريخ"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thDate1, "Default", "Weight", 0.56872804494981966D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thDate2, "Default", "Text", "Date"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thDate2, "ar", "Text", "التاريخ"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thDate2, "Default", "Weight", 0.56872804494981966D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thDebit, "Default", "Text", "Debit"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thDebit, "ar", "Text", "مدين"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thDebit, "Default", "Weight", 0.94788004837249773D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thDebitBal, "Default", "Text", "Debit"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thDebitBal, "ar", "Text", "مدين"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thDebitBal, "Default", "Weight", 0.94788005366833783D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tHeader, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0.999999F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tHeader, "Default", "SizeF", new System.Drawing.SizeF(805F, 40F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thMovement, "Default", "Text", "Movement"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thMovement, "ar", "Text", "الحركة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thMovement, "Default", "Weight", 1.8957601639533914D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thOpenBalance, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thOpenBalance, "Default", "Text", "Open Balance"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thOpenBalance, "ar", "Text", "رصيد افتتاحي"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thOpenBalance, "Default", "Weight", 1.4888537384092428D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thOpenCredit_GPT, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thOpenCredit_GPT, "Default", "Text", ""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thOpenCredit_GPT, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thOpenCredit_GPT, "Default", "Weight", 1.4888538105153231D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thOpenDebit_GPT, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thOpenDebit_GPT, "Default", "Text", ""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thOpenDebit_GPT, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.thOpenDebit_GPT, "Default", "Weight", 1.4888536917601543D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.TopMargin, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.trDetail, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.trFooter, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.trHeader1, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.trHeader2, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(7.947286E-06F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "SizeF", new System.Drawing.SizeF(144.358F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "Text", "From: [?DateFrom!dd-MM-yyyy]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "ar", "Text", "من: [?DateFrom!dd-MM-yyyy]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(144.358F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "Default", "SizeF", new System.Drawing.SizeF(144.358F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "Default", "Text", "To: [?DateTo!dd-MM-yyyy]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "ar", "Text", "إلى: [?DateTo!dd-MM-yyyy]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(517.8962F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "Default", "SizeF", new System.Drawing.SizeF(199.9818F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "Default", "Text", "[?AccountDim]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel6, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(388.9583F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel6, "Default", "SizeF", new System.Drawing.SizeF(128.9379F, 20.00003F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel6, "Default", "Text", "Account Dimension:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel6, "ar", "Text", "أبعاد الحساب:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0.999999F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable1, "Default", "SizeF", new System.Drawing.SizeF(805F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow1, "Default", "Weight", 1D)});
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
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IsCustomReportFooter, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IsCustomReportHeader, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            groupLayoutItem1,
            groupLayoutItem2,
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.NoOfGroupsPerPage, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.FontSize, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.DateFrom, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.DateTo, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.AccountDim, DevExpress.XtraReports.Parameters.Orientation.Vertical)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.IsRTL,
            this.IsCustomReportFooter,
            this.IsCustomReportHeader,
            this.ShowSignature,
            this.ShowSignatureAllPages,
            this.HideReportHeader,
            this.HideReportFooter,
            this.NoOfGroupsPerPage,
            this.FontSize,
            this.DateFrom,
            this.DateTo,
            this.AccountDim});
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
            ((System.ComponentModel.ISupportInitialize)(this.dsGeneralLedger1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tFooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion
        private Reports.GeneralLedger.DataSets.dsGeneralLedger dsGeneralLedger1;
        private Reports.GeneralLedger.DataSets.dsGeneralLedgerTableAdapters.SR_FC_JournalEntryTableAdapter sR_FC_AccountSheetTableAdapter;
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
        private DevExpress.XtraReports.UI.XRTableCell tdDate;
        private DevExpress.XtraReports.UI.XRTableCell tdDebitBal;
        private DevExpress.XtraReports.UI.XRTableCell tdCreditBal;
        private DevExpress.XtraReports.UI.XRTableCell tdDebit;
        private DevExpress.XtraReports.UI.XRTableCell tdCredit;
        private DevExpress.XtraReports.Parameters.Parameter DateFrom;
        private DevExpress.XtraReports.Parameters.Parameter DateTo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.CalculatedField DebitMinusCredit;
        private DevExpress.XtraReports.UI.XRLabel lblVetSoftData;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoCurrentTime;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoCurrentDate;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoPageNoOfTotal;
        private Reports.GeneralLedger.DataSets.dsGeneralLedgerTableAdapters.SR_FC_AccountSheetTableAdapter sR_FC_AccountSheetTableAdapter1;
        private DevExpress.XtraReports.UI.XRTableCell tfCreditBal_GPT;
        private DevExpress.XtraReports.UI.XRTableCell tfDebitBal_GPT;
        private DevExpress.XtraReports.UI.XRTableCell tfCredit_GPT;
        private DevExpress.XtraReports.UI.XRTableCell tfDebit_GPT;
        private DevExpress.XtraReports.UI.XRTableCell tfTotal;
        private DevExpress.XtraReports.UI.XRTableRow trFooter;
        private DevExpress.XtraReports.UI.XRTable tFooter;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRTableCell thOpenCredit_GPT;
        private DevExpress.XtraReports.UI.XRTableCell thOpenDebit_GPT;
        private DevExpress.XtraReports.UI.XRTableCell thOpenBalance;
        private DevExpress.XtraReports.UI.XRTableCell thAccountName;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.SubBand GroupHeaderSub2;
        private DevExpress.XtraReports.UI.XRTableCell thCreditBal;
        private DevExpress.XtraReports.UI.XRTableCell thDebitBal;
        private DevExpress.XtraReports.UI.XRTableCell thCredit;
        private DevExpress.XtraReports.UI.XRTableCell thDebit;
        private DevExpress.XtraReports.UI.XRTableCell thDate2;
        private DevExpress.XtraReports.UI.XRTableRow trHeader2;
        private DevExpress.XtraReports.UI.XRTableCell thBalance;
        private DevExpress.XtraReports.UI.XRTableCell thMovement;
        private DevExpress.XtraReports.UI.XRTableCell thDate1;
        private DevExpress.XtraReports.UI.XRTableRow trHeader1;
        private DevExpress.XtraReports.UI.XRTable tHeader;
        private DevExpress.XtraReports.UI.SubBand GroupHeaderSub1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.SubBand SubBand1;
        private DevExpress.XtraReports.UI.SubBand SubBand2;
        private DevExpress.XtraReports.UI.SubBand SubBand3;
        private DevExpress.XtraReports.UI.SubBand SubBand4;
        private DevExpress.XtraReports.UI.XRSubreport srReportHeaderCustom;
        private DevExpress.XtraReports.UI.XRSubreport srReportFooterCustom;
        private DevExpress.XtraReports.Parameters.Parameter IsCustomReportFooter;
        private DevExpress.XtraReports.Parameters.Parameter IsCustomReportHeader;
        private DevExpress.XtraReports.Parameters.Parameter AccountDim;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
    }
}