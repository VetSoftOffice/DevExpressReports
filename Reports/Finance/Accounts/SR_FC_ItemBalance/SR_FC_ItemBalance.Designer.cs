namespace DevExpressReports.PredefinedReports
{
    partial class SR_FC_ItemBalance
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
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary6 = new DevExpress.XtraReports.UI.XRSummary();
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
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SR_FC_ItemBalance));
            DevExpress.XtraReports.Parameters.GroupLayoutItem groupLayoutItem1 = new DevExpress.XtraReports.Parameters.GroupLayoutItem("", false);
            DevExpress.XtraReports.Parameters.GroupLayoutItem groupLayoutItem2 = new DevExpress.XtraReports.Parameters.GroupLayoutItem("", true);
            this.ShowSignature = new DevExpress.XtraReports.Parameters.Parameter();
            this.ShowSignatureAllPages = new DevExpress.XtraReports.Parameters.Parameter();
            this.HideReportHeader = new DevExpress.XtraReports.Parameters.Parameter();
            this.HideReportFooter = new DevExpress.XtraReports.Parameters.Parameter();
            this.sR_FC_JournalEntryTableAdapter = new DevExpressReports.Reports.GeneralLedger.DataSets.dsGeneralLedgerTableAdapters.SR_FC_JournalEntryTableAdapter();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
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
            this.tdCloseDebit = new DevExpress.XtraReports.UI.XRTableCell();
            this.tdCloseCredit = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportSignature_PageFooter = new DevExpress.XtraReports.UI.XRSubreport();
            this.SubBand2 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportFooterCustom = new DevExpress.XtraReports.UI.XRSubreport();
            this.IsRTL = new DevExpress.XtraReports.Parameters.Parameter();
            this.FontSize = new DevExpress.XtraReports.Parameters.Parameter();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.PageHeader_RHC = new DevExpress.XtraReports.UI.SubBand();
            this.srReportHeaderCustom = new DevExpress.XtraReports.UI.XRSubreport();
            this.PageHeader_RH = new DevExpress.XtraReports.UI.SubBand();
            this.srReportHeader = new DevExpress.XtraReports.UI.XRSubreport();
            this.PageHeaderSub1 = new DevExpress.XtraReports.UI.SubBand();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeaderSub3 = new DevExpress.XtraReports.UI.SubBand();
            this.xrTable8 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell64 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell55 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell56 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell57 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell58 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.ReportFooterSub3 = new DevExpress.XtraReports.UI.SubBand();
            this.xrTable7 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell51 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell52 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooterSub1 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportNotes = new DevExpress.XtraReports.UI.XRSubreport();
            this.ReportFooterSub2 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportSignature = new DevExpress.XtraReports.UI.XRSubreport();
            this.NoOfGroupsPerPage = new DevExpress.XtraReports.Parameters.Parameter();
            this.DateFrom = new DevExpress.XtraReports.Parameters.Parameter();
            this.DateTo = new DevExpress.XtraReports.Parameters.Parameter();
            this.Code_Str = new DevExpress.XtraReports.Parameters.Parameter();
            this.IsDealType = new DevExpress.XtraReports.Parameters.Parameter();
            this.CustSupp = new DevExpress.XtraReports.Parameters.Parameter();
            this.IsShowEquivalentData = new DevExpress.XtraReports.Parameters.Parameter();
            this.WhichType = new DevExpress.XtraReports.Parameters.Parameter();
            this.OpenDebit = new DevExpress.XtraReports.UI.CalculatedField();
            this.CustomerName_CF = new DevExpress.XtraReports.UI.CalculatedField();
            this.CloseDebit = new DevExpress.XtraReports.UI.CalculatedField();
            this.Result = new DevExpress.XtraReports.UI.CalculatedField();
            this.OpenCredit = new DevExpress.XtraReports.UI.CalculatedField();
            this.Credit_Str = new DevExpress.XtraReports.UI.CalculatedField();
            this.Debit_Str = new DevExpress.XtraReports.UI.CalculatedField();
            this.DebitCreditOpenBalRes = new DevExpress.XtraReports.UI.CalculatedField();
            this.Abs_OpenBal = new DevExpress.XtraReports.UI.CalculatedField();
            this.dsFinance = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.OpenCredit_ = new DevExpress.XtraReports.UI.CalculatedField();
            this.CloseDebit_ = new DevExpress.XtraReports.UI.CalculatedField();
            this.CloseCredit_ = new DevExpress.XtraReports.UI.CalculatedField();
            this.CloseBalance_ = new DevExpress.XtraReports.UI.CalculatedField();
            this.IsCustomReportHeader = new DevExpress.XtraReports.Parameters.Parameter();
            this.IsCustomReportFooter = new DevExpress.XtraReports.Parameters.Parameter();
            this.AccountDim = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.tDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).BeginInit();
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
            // sR_FC_JournalEntryTableAdapter
            // 
            this.sR_FC_JournalEntryTableAdapter.ClearBeforeFill = true;
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
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
            this.pageInfoCurrentTime.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
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
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            // 
            // tDetail
            // 
            this.tDetail.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.tDetail.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tDetail.Name = "tDetail";
            this.tDetail.ProcessHiddenCellMode = DevExpress.XtraReports.UI.ProcessHiddenCellMode.ResizeCellsProportionally;
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
            this.tdCredit,
            this.tdCloseDebit,
            this.tdCloseCredit,
            this.xrTableCell4,
            this.xrTableCell8});
            this.trDetail.Name = "trDetail";
            // 
            // tdAccount_From
            // 
            this.tdAccount_From.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tdAccount_From.BorderWidth = 1.4F;
            this.tdAccount_From.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CustomerName]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'TopLeft\')\n\n")});
            this.tdAccount_From.Multiline = true;
            this.tdAccount_From.Name = "tdAccount_From";
            this.tdAccount_From.StylePriority.UseBorders = false;
            this.tdAccount_From.StylePriority.UseBorderWidth = false;
            this.tdAccount_From.StylePriority.UseFont = false;
            this.tdAccount_From.StylePriority.UseTextAlignment = false;
            this.tdAccount_From.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tdCostCenter
            // 
            this.tdCostCenter.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tdCostCenter.BorderWidth = 1.4F;
            this.tdCostCenter.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DealType_To]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?IsDealType\n")});
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
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OpenDebit]")});
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
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OpenCredit_]")});
            this.tdCredit.Multiline = true;
            this.tdCredit.Name = "tdCredit";
            this.tdCredit.StylePriority.UseBorders = false;
            this.tdCredit.StylePriority.UseBorderWidth = false;
            this.tdCredit.StylePriority.UseFont = false;
            this.tdCredit.StylePriority.UseTextAlignment = false;
            this.tdCredit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // tdCloseDebit
            // 
            this.tdCloseDebit.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tdCloseDebit.BorderWidth = 1.4F;
            this.tdCloseDebit.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?IsShowEquivalentData\n\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Debit]")});
            this.tdCloseDebit.Multiline = true;
            this.tdCloseDebit.Name = "tdCloseDebit";
            this.tdCloseDebit.StylePriority.UseBorders = false;
            this.tdCloseDebit.StylePriority.UseBorderWidth = false;
            this.tdCloseDebit.StylePriority.UseFont = false;
            this.tdCloseDebit.StylePriority.UseTextAlignment = false;
            this.tdCloseDebit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // tdCloseCredit
            // 
            this.tdCloseCredit.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.tdCloseCredit.BorderWidth = 1.4F;
            this.tdCloseCredit.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?IsShowEquivalentData\n\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Abs([Credit])")});
            this.tdCloseCredit.Multiline = true;
            this.tdCloseCredit.Name = "tdCloseCredit";
            this.tdCloseCredit.StylePriority.UseBorders = false;
            this.tdCloseCredit.StylePriority.UseBorderWidth = false;
            this.tdCloseCredit.StylePriority.UseFont = false;
            this.tdCloseCredit.StylePriority.UseTextAlignment = false;
            this.tdCloseCredit.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell4.BorderWidth = 1.4F;
            this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CloseDebit_]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n\n\n")});
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseBorders = false;
            this.xrTableCell4.StylePriority.UseBorderWidth = false;
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell8.BorderWidth = 1.4F;
            this.xrTableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CloseCredit_]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n\n\n")});
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseBorders = false;
            this.xrTableCell8.StylePriority.UseBorderWidth = false;
            this.xrTableCell8.StylePriority.UseFont = false;
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Title.Name = "Title";
            this.Title.Padding = new DevExpress.XtraPrinting.PaddingInfo(6F, 6F, 0F, 0F, 100F);
            // 
            // DetailCaption1
            // 
            this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DetailCaption1.BorderColor = System.Drawing.Color.White;
            this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailCaption1.BorderWidth = 2F;
            this.DetailCaption1.ForeColor = System.Drawing.Color.White;
            this.DetailCaption1.Name = "DetailCaption1";
            this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6F, 6F, 0F, 0F, 100F);
            this.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData1
            // 
            this.DetailData1.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailData1.BorderWidth = 2F;
            this.DetailData1.ForeColor = System.Drawing.Color.Black;
            this.DetailData1.Name = "DetailData1";
            this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6F, 6F, 0F, 0F, 100F);
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
            this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6F, 6F, 0F, 0F, 100F);
            this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageInfo
            // 
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(6F, 6F, 0F, 0F, 100F);
            // 
            // PageFooter
            // 
            this.PageFooter.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?HideReportFooter==false")});
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand1,
            this.SubBand2});
            // 
            // SubBand1
            // 
            this.SubBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportSignature_PageFooter});
            this.SubBand1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?ShowSignature == True && ?ShowSignatureAllPages == True\n")});
            this.SubBand1.Name = "SubBand1";
            // 
            // srReportSignature_PageFooter
            // 
            this.srReportSignature_PageFooter.Name = "srReportSignature_PageFooter";
            this.srReportSignature_PageFooter.ReportSource = new DevExpressReports.PredefinedReports.SubReportSignature();
            // 
            // SubBand2
            // 
            this.SubBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportFooterCustom});
            this.SubBand2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?IsCustomReportFooter")});
            this.SubBand2.Name = "SubBand2";
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
            this.PageHeader_RHC,
            this.PageHeader_RH,
            this.PageHeaderSub1,
            this.PageHeaderSub3});
            // 
            // PageHeader_RHC
            // 
            this.PageHeader_RHC.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportHeaderCustom});
            this.PageHeader_RHC.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?IsCustomReportHeader\nand ?HideReportHeader==false\n")});
            this.PageHeader_RHC.Name = "PageHeader_RHC";
            // 
            // srReportHeaderCustom
            // 
            this.srReportHeaderCustom.Name = "srReportHeaderCustom";
            this.srReportHeaderCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("HideReportHeader", this.HideReportHeader));
            this.srReportHeaderCustom.ReportSource = new DevExpressReports.PredefinedReports.SubReportHeaderCustom();
            // 
            // PageHeader_RH
            // 
            this.PageHeader_RH.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportHeader});
            this.PageHeader_RH.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Not ?IsCustomReportHeader\nand ?HideReportHeader==false\n")});
            this.PageHeader_RH.Name = "PageHeader_RH";
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
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel2,
            this.xrLabel1});
            this.PageHeaderSub1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Not (IsNullOrEmpty(?DateFrom) And IsNullOrEmpty(?DateTo))")});
            this.PageHeaderSub1.Name = "PageHeaderSub1";
            // 
            // xrLabel5
            // 
            this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel5.CanPublishOptions.Xls = false;
            this.xrLabel5.CanPublishOptions.Xlsx = false;
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "!IsNullOrEmpty(?AccountDim)\n")});
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel5.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink;
            this.xrLabel5.StylePriority.UseBorders = false;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.CanPublishOptions.Xls = false;
            this.xrLabel4.CanPublishOptions.Xlsx = false;
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "!IsNullOrEmpty(?AccountDim)\n")});
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel4.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink;
            this.xrLabel4.Scripts.OnBeforePrint = "xrLabel4_BeforePrint";
            this.xrLabel4.StylePriority.UseBorders = false;
            // 
            // xrLabel2
            // 
            this.xrLabel2.CanGrow = false;
            this.xrLabel2.CanPublishOptions.Xls = false;
            this.xrLabel2.CanPublishOptions.Xlsx = false;
            this.xrLabel2.Name = "xrLabel2";
            // 
            // xrLabel1
            // 
            this.xrLabel1.CanGrow = false;
            this.xrLabel1.CanPublishOptions.Xls = false;
            this.xrLabel1.CanPublishOptions.Xlsx = false;
            this.xrLabel1.Name = "xrLabel1";
            // 
            // PageHeaderSub3
            // 
            this.PageHeaderSub3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable8});
            this.PageHeaderSub3.Name = "PageHeaderSub3";
            // 
            // xrTable8
            // 
            this.xrTable8.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrTable8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.xrTable8.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable8.Name = "xrTable8";
            this.xrTable8.ProcessHiddenCellMode = DevExpress.XtraReports.UI.ProcessHiddenCellMode.ResizeCellsProportionally;
            this.xrTable8.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow10,
            this.xrTableRow11});
            this.xrTable8.StylePriority.UseBackColor = false;
            this.xrTable8.StylePriority.UseBorders = false;
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell65,
            this.xrTableCell63,
            this.xrTableCell6,
            this.xrTableCell53,
            this.xrTableCell54});
            this.xrTableRow10.Name = "xrTableRow10";
            // 
            // xrTableCell65
            // 
            this.xrTableCell65.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell65.BorderWidth = 1.4F;
            this.xrTableCell65.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CustomerName_CF]")});
            this.xrTableCell65.Multiline = true;
            this.xrTableCell65.Name = "xrTableCell65";
            this.xrTableCell65.StylePriority.UseBorders = false;
            this.xrTableCell65.StylePriority.UseBorderWidth = false;
            this.xrTableCell65.StylePriority.UseFont = false;
            this.xrTableCell65.StylePriority.UseTextAlignment = false;
            this.xrTableCell65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrTableCell63
            // 
            this.xrTableCell63.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrTableCell63.BorderWidth = 1.4F;
            this.xrTableCell63.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?IsDealType\n")});
            this.xrTableCell63.Multiline = true;
            this.xrTableCell63.Name = "xrTableCell63";
            this.xrTableCell63.StylePriority.UseBorders = false;
            this.xrTableCell63.StylePriority.UseBorderWidth = false;
            this.xrTableCell63.StylePriority.UseFont = false;
            this.xrTableCell63.StylePriority.UseTextAlignment = false;
            this.xrTableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.BorderWidth = 1.4F;
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseBorderWidth = false;
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell53
            // 
            this.xrTableCell53.BorderWidth = 1.4F;
            this.xrTableCell53.Multiline = true;
            this.xrTableCell53.Name = "xrTableCell53";
            this.xrTableCell53.StylePriority.UseBorderWidth = false;
            this.xrTableCell53.StylePriority.UseFont = false;
            this.xrTableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell54
            // 
            this.xrTableCell54.BorderWidth = 1.4F;
            this.xrTableCell54.Multiline = true;
            this.xrTableCell54.Name = "xrTableCell54";
            this.xrTableCell54.StylePriority.UseBorderWidth = false;
            this.xrTableCell54.StylePriority.UseFont = false;
            this.xrTableCell54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell66,
            this.xrTableCell64,
            this.xrTableCell16,
            this.xrTableCell13,
            this.xrTableCell55,
            this.xrTableCell56,
            this.xrTableCell57,
            this.xrTableCell58});
            this.xrTableRow11.Name = "xrTableRow11";
            // 
            // xrTableCell66
            // 
            this.xrTableCell66.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell66.BorderWidth = 1.4F;
            this.xrTableCell66.Multiline = true;
            this.xrTableCell66.Name = "xrTableCell66";
            this.xrTableCell66.StylePriority.UseBorders = false;
            this.xrTableCell66.StylePriority.UseBorderWidth = false;
            this.xrTableCell66.StylePriority.UseFont = false;
            this.xrTableCell66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell64
            // 
            this.xrTableCell64.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell64.BorderWidth = 1.4F;
            this.xrTableCell64.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?IsDealType\n")});
            this.xrTableCell64.Multiline = true;
            this.xrTableCell64.Name = "xrTableCell64";
            this.xrTableCell64.StylePriority.UseBorders = false;
            this.xrTableCell64.StylePriority.UseBorderWidth = false;
            this.xrTableCell64.StylePriority.UseFont = false;
            this.xrTableCell64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.BorderWidth = 1.4F;
            this.xrTableCell16.Multiline = true;
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.StylePriority.UseBorderWidth = false;
            this.xrTableCell16.StylePriority.UseFont = false;
            this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.BorderWidth = 1.4F;
            this.xrTableCell13.Multiline = true;
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.StylePriority.UseBorderWidth = false;
            this.xrTableCell13.StylePriority.UseFont = false;
            this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell55
            // 
            this.xrTableCell55.BorderWidth = 1.4F;
            this.xrTableCell55.Multiline = true;
            this.xrTableCell55.Name = "xrTableCell55";
            this.xrTableCell55.StylePriority.UseBorderWidth = false;
            this.xrTableCell55.StylePriority.UseFont = false;
            this.xrTableCell55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell56
            // 
            this.xrTableCell56.BorderWidth = 1.4F;
            this.xrTableCell56.Multiline = true;
            this.xrTableCell56.Name = "xrTableCell56";
            this.xrTableCell56.StylePriority.UseBorderWidth = false;
            this.xrTableCell56.StylePriority.UseFont = false;
            this.xrTableCell56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell57
            // 
            this.xrTableCell57.BorderWidth = 1.4F;
            this.xrTableCell57.Multiline = true;
            this.xrTableCell57.Name = "xrTableCell57";
            this.xrTableCell57.StylePriority.UseBorderWidth = false;
            this.xrTableCell57.StylePriority.UseFont = false;
            this.xrTableCell57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell58
            // 
            this.xrTableCell58.BorderWidth = 1.4F;
            this.xrTableCell58.Multiline = true;
            this.xrTableCell58.Name = "xrTableCell58";
            this.xrTableCell58.StylePriority.UseBorderWidth = false;
            this.xrTableCell58.StylePriority.UseFont = false;
            this.xrTableCell58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.ReportFooterSub3,
            this.ReportFooterSub1,
            this.ReportFooterSub2});
            // 
            // ReportFooterSub3
            // 
            this.ReportFooterSub3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable7});
            this.ReportFooterSub3.Name = "ReportFooterSub3";
            // 
            // xrTable7
            // 
            this.xrTable7.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.xrTable7.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable7.Name = "xrTable7";
            this.xrTable7.ProcessHiddenCellMode = DevExpress.XtraReports.UI.ProcessHiddenCellMode.ResizeCellsProportionally;
            this.xrTable7.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow9});
            this.xrTable7.StylePriority.UseBorders = false;
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell48,
            this.xrTableCell12,
            this.xrTableCell49,
            this.xrTableCell9,
            this.xrTableCell50,
            this.xrTableCell11,
            this.xrTableCell51,
            this.xrTableCell52});
            this.xrTableRow9.Name = "xrTableRow9";
            // 
            // xrTableCell48
            // 
            this.xrTableCell48.BorderWidth = 1.4F;
            this.xrTableCell48.Multiline = true;
            this.xrTableCell48.Name = "xrTableCell48";
            this.xrTableCell48.StylePriority.UseBorderWidth = false;
            this.xrTableCell48.StylePriority.UseFont = false;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.BorderWidth = 1.4F;
            this.xrTableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?IsDealType\n")});
            this.xrTableCell12.Multiline = true;
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.StylePriority.UseBorderWidth = false;
            this.xrTableCell12.StylePriority.UseFont = false;
            this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableCell49
            // 
            this.xrTableCell49.BorderWidth = 1.4F;
            this.xrTableCell49.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n\n\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([OpenDebit])")});
            this.xrTableCell49.Multiline = true;
            this.xrTableCell49.Name = "xrTableCell49";
            this.xrTableCell49.StylePriority.UseBorderWidth = false;
            this.xrTableCell49.StylePriority.UseFont = false;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell49.Summary = xrSummary1;
            this.xrTableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.BorderWidth = 1.4F;
            this.xrTableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([OpenCredit_])"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n\n\n")});
            this.xrTableCell9.Multiline = true;
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.StylePriority.UseBorderWidth = false;
            this.xrTableCell9.StylePriority.UseFont = false;
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell9.Summary = xrSummary2;
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableCell50
            // 
            this.xrTableCell50.BorderWidth = 1.4F;
            this.xrTableCell50.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Debit])")});
            this.xrTableCell50.Multiline = true;
            this.xrTableCell50.Name = "xrTableCell50";
            this.xrTableCell50.StylePriority.UseBorderWidth = false;
            this.xrTableCell50.StylePriority.UseFont = false;
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell50.Summary = xrSummary3;
            this.xrTableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.BorderWidth = 1.4F;
            this.xrTableCell11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum(Abs([Credit]))"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n\n\n")});
            this.xrTableCell11.Multiline = true;
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.StylePriority.UseBorderWidth = false;
            this.xrTableCell11.StylePriority.UseFont = false;
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell11.Summary = xrSummary4;
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableCell51
            // 
            this.xrTableCell51.BorderWidth = 1.4F;
            this.xrTableCell51.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?IsShowEquivalentData\n\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([CloseDebit_])")});
            this.xrTableCell51.Multiline = true;
            this.xrTableCell51.Name = "xrTableCell51";
            this.xrTableCell51.StylePriority.UseBorderWidth = false;
            this.xrTableCell51.StylePriority.UseFont = false;
            xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell51.Summary = xrSummary5;
            this.xrTableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrTableCell52
            // 
            this.xrTableCell52.BorderWidth = 1.4F;
            this.xrTableCell52.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?IsShowEquivalentData\n\n"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([CloseCredit_])")});
            this.xrTableCell52.Multiline = true;
            this.xrTableCell52.Name = "xrTableCell52";
            this.xrTableCell52.StylePriority.UseBorderWidth = false;
            this.xrTableCell52.StylePriority.UseFont = false;
            this.xrTableCell52.StylePriority.UseTextAlignment = false;
            xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell52.Summary = xrSummary6;
            this.xrTableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
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
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?ShowSignature == True && ?ShowSignatureAllPages == False")});
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
            // Code_Str
            // 
            this.Code_Str.AllowNull = true;
            this.Code_Str.Enabled = false;
            this.Code_Str.Name = "Code_Str";
            this.Code_Str.Visible = false;
            // 
            // IsDealType
            // 
            this.IsDealType.Name = "IsDealType";
            this.IsDealType.Type = typeof(bool);
            this.IsDealType.ValueInfo = "False";
            this.IsDealType.Visible = false;
            // 
            // CustSupp
            // 
            this.CustSupp.AllowNull = true;
            this.CustSupp.Enabled = false;
            this.CustSupp.Name = "CustSupp";
            this.CustSupp.Visible = false;
            // 
            // IsShowEquivalentData
            // 
            this.IsShowEquivalentData.Name = "IsShowEquivalentData";
            this.IsShowEquivalentData.Type = typeof(bool);
            this.IsShowEquivalentData.ValueInfo = "True";
            // 
            // WhichType
            // 
            this.WhichType.AllowNull = true;
            this.WhichType.Name = "WhichType";
            this.WhichType.Type = typeof(int);
            this.WhichType.ValueInfo = "0";
            this.WhichType.Visible = false;
            // 
            // OpenDebit
            // 
            this.OpenDebit.DataMember = "SR_FC_ItemBalance";
            this.OpenDebit.Expression = "Iif([OpenBalance]>0,[OpenBalance] ,0 )";
            this.OpenDebit.Name = "OpenDebit";
            // 
            // CustomerName_CF
            // 
            this.CustomerName_CF.DataMember = "SR_FC_ItemBalance";
            this.CustomerName_CF.Expression = "Iif(?IsRTL, \n    Iif(?WhichType == 17, \'العميل\', Iif(?WhichType == 57, \'الخزينة\'," +
    " \'المورد\')),\n    Iif(?WhichType == 17, \'Customer\', Iif(?WhichType == 57, \'Treasu" +
    "ry\', \'Supplier\'))\n)\n";
            this.CustomerName_CF.Name = "CustomerName_CF";
            // 
            // CloseDebit
            // 
            this.CloseDebit.DataMember = "SR_FC_CustSuppSheet";
            this.CloseDebit.Expression = "Iif([CloseBalance] > 0, [CloseBalance], 0)";
            this.CloseDebit.Name = "CloseDebit";
            // 
            // Result
            // 
            this.Result.DataMember = "SR_FC_CustSuppSheet";
            this.Result.Expression = "[Debit] - [Credit]";
            this.Result.Name = "Result";
            // 
            // OpenCredit
            // 
            this.OpenCredit.DataMember = "SR_FC_CustSuppSheet";
            this.OpenCredit.Expression = "Iif([OpenBalance] < 0, Abs([OpenBalance]), NULL)\n";
            this.OpenCredit.Name = "OpenCredit";
            // 
            // Credit_Str
            // 
            this.Credit_Str.DataMember = "SR_FC_CustSuppSheet";
            this.Credit_Str.Expression = "Iif(?IsRTL == true,\'(دائن)\' , \'(Credit)\')";
            this.Credit_Str.Name = "Credit_Str";
            // 
            // Debit_Str
            // 
            this.Debit_Str.DataMember = "SR_FC_CustSuppSheet";
            this.Debit_Str.Expression = "Iif(?IsRTL == true,\'(مدين)\' , \'(Debit)\')";
            this.Debit_Str.Name = "Debit_Str";
            // 
            // DebitCreditOpenBalRes
            // 
            this.DebitCreditOpenBalRes.DataMember = "SR_FC_CustSuppSheet";
            this.DebitCreditOpenBalRes.Expression = "Iif([OpenBalance] > 0,[Debit_Str] , Iif([OpenBalance] < 0, [Credit_Str], \'\'))";
            this.DebitCreditOpenBalRes.Name = "DebitCreditOpenBalRes";
            // 
            // Abs_OpenBal
            // 
            this.Abs_OpenBal.DataMember = "SR_FC_CustSuppSheet";
            this.Abs_OpenBal.Expression = "Abs([OpenBalance])";
            this.Abs_OpenBal.Name = "Abs_OpenBal";
            // 
            // dsFinance
            // 
            this.dsFinance.ConnectionName = "dsFinance";
            this.dsFinance.Name = "dsFinance";
            columnExpression1.ColumnName = "CustNameWithoutCode";
            table1.Name = "SR_FC_ItemBalance";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "CustomerName";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "DealType_To";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "Currency";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "OpenBalance";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "CloseBalance";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "Debit";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "Credit";
            columnExpression8.Table = table1;
            column8.Expression = columnExpression8;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Columns.Add(column8);
            selectQuery1.Name = "SR_FC_ItemBalance";
            selectQuery1.Tables.Add(table1);
            this.dsFinance.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.dsFinance.ResultSchemaSerializable = resources.GetString("dsFinance.ResultSchemaSerializable");
            // 
            // OpenCredit_
            // 
            this.OpenCredit_.DataMember = "SR_FC_ItemBalance";
            this.OpenCredit_.Expression = "Iif(IsNull([OpenBalance], 0)<0,Abs([OpenBalance]) ,0 )\n";
            this.OpenCredit_.Name = "OpenCredit_";
            // 
            // CloseDebit_
            // 
            this.CloseDebit_.DataMember = "SR_FC_ItemBalance";
            this.CloseDebit_.Expression = "Iif([CloseBalance_]>0,[CloseBalance_] ,0 )";
            this.CloseDebit_.Name = "CloseDebit_";
            // 
            // CloseCredit_
            // 
            this.CloseCredit_.DataMember = "SR_FC_ItemBalance";
            this.CloseCredit_.Expression = "Iif([CloseBalance_]<0,Abs([CloseBalance_]) ,0 )";
            this.CloseCredit_.Name = "CloseCredit_";
            // 
            // CloseBalance_
            // 
            this.CloseBalance_.DataMember = "SR_FC_ItemBalance";
            this.CloseBalance_.Expression = "IsNull([OpenDebit],0 )+IsNull([Debit],0 )-IsNull([OpenCredit_],0 )-IsNull([Credit" +
    "],0 )";
            this.CloseBalance_.Name = "CloseBalance_";
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
            // AccountDim
            // 
            this.AccountDim.Name = "AccountDim";
            this.AccountDim.Visible = false;
            // 
            // SR_FC_ItemBalance
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
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.Abs_OpenBal,
            this.DebitCreditOpenBalRes,
            this.Debit_Str,
            this.Credit_Str,
            this.OpenCredit,
            this.Result,
            this.CloseDebit,
            this.CustomerName_CF,
            this.OpenDebit,
            this.OpenCredit_,
            this.CloseDebit_,
            this.CloseCredit_,
            this.CloseBalance_});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dsFinance});
            this.DataMember = "SR_FC_ItemBalance";
            this.DataSource = this.dsFinance;
            this.ExportOptions.Pdf.DocumentOptions.Author = "VetSoft";
            this.ExportOptions.Xls.IgnoreErrors = DevExpress.XtraPrinting.XlIgnoreErrors.NumberStoredAsText;
            this.ExportOptions.Xls.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text;
            this.ExportOptions.Xlsx.IgnoreErrors = DevExpress.XtraPrinting.XlIgnoreErrors.NumberStoredAsText;
            this.ExportOptions.Xlsx.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text;
            this.LocalizationItems.AddRange(new DevExpress.XtraReports.Localization.LocalizationItem[] {
            new DevExpress.XtraReports.Localization.LocalizationItem(this.AccountDim, "Default", "Description", "AccountDim"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.BottomMargin, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.Code_Str, "Default", "Description", "Code_Str"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.CustSupp, "Default", "Description", "CustSupp"),
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
            new DevExpress.XtraReports.Localization.LocalizationItem(this.IsDealType, "Default", "Description", "IsDealType"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.IsRTL, "Default", "Description", "Right to left"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.IsRTL, "ar", "Description", "عرض من اليمبن لليسار"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.IsShowEquivalentData, "Default", "Description", "IsShowEquivalentData"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.NoOfGroupsPerPage, "Default", "Description", "No of groups / page"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.NoOfGroupsPerPage, "ar", "Description", "عدد المجموعات / صفحة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageFooter, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeader, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeaderSub1, "Default", "HeightF", 20.00003F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeaderSub3, "Default", "HeightF", 40F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeaderSub3, "Default", "Visible", true),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeader_RH, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeader_RHC, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentDate, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentDate, "Default", "SizeF", new System.Drawing.SizeF(205.12F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentTime, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(353.5F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentTime, "Default", "SizeF", new System.Drawing.SizeF(101F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentTime, "Default", "TextFormatString", "{0:HH:mm:ss}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoPageNoOfTotal, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(597.6668F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoPageNoOfTotal, "Default", "SizeF", new System.Drawing.SizeF(210.33F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoPageNoOfTotal, "Default", "TextFormatString", "Page {0} of {1}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooter, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooterSub1, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooterSub2, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooterSub3, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignature, "Default", "Description", "Show signature"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignature, "ar", "Description", "عرض التوقيع"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignatureAllPages, "Default", "Description", "Show signature in all page"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignatureAllPages, "ar", "Description", "عرض التوقيع في كل الصفحات"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportFooterCustom, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportFooterCustom, "Default", "SizeF", new System.Drawing.SizeF(807F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportHeader, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportHeader, "Default", "SizeF", new System.Drawing.SizeF(807F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportHeaderCustom, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportHeaderCustom, "Default", "SizeF", new System.Drawing.SizeF(807F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportNotes, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportNotes, "Default", "SizeF", new System.Drawing.SizeF(807F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature, "Default", "SizeF", new System.Drawing.SizeF(807F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature_PageFooter, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0.996844F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature_PageFooter, "Default", "SizeF", new System.Drawing.SizeF(807F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "DisplayName", "Journal Entry Details"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "ar", "DisplayName", "قيود يومية تفصيلي"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Margins", new DevExpress.Drawing.DXMargins(9F, 10F, 20F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "PaperKind", DevExpress.Drawing.Printing.DXPaperKind.A4),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand1, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand2, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdAccount_From, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdAccount_From, "Default", "Text", "tdAccountName_From"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdAccount_From, "Default", "Weight", 2.1310554877970351D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCloseCredit, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 6.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCloseCredit, "Default", "TextFormatString", "{0:#,##0.00;#,##0.00; }"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCloseCredit, "Default", "Weight", 1.4333480600619353D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCloseDebit, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 6.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCloseDebit, "Default", "TextFormatString", "{0:#,##0.00;#,##0.00; }"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCloseDebit, "Default", "Weight", 1.4333480600619353D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCostCenter, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCostCenter, "Default", "Text", "tdCostCenter"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCostCenter, "Default", "Weight", 1.5445592383317639D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCredit, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 6.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCredit, "Default", "Text", ""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCredit, "Default", "TextFormatString", "{0:#,##0.00;#,##0.00; }"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdCredit, "Default", "Weight", 1.4333480600619353D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdDebit, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 6.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdDebit, "Default", "Text", "tdDebit"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdDebit, "Default", "TextFormatString", "{0:#,##0.00;#,##0.00; }"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tdDebit, "Default", "Weight", 1.4333480600619353D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tDetail, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.tDetail, "Default", "SizeF", new System.Drawing.SizeF(808F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.TopMargin, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.trDetail, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.WhichType, "Default", "Description", "WhichType"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(7.947286E-06F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "SizeF", new System.Drawing.SizeF(144.358F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "Text", "From: [?DateFrom!dd-MM-yyyy]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "ar", "Text", "من: [?DateFrom!dd-MM-yyyy]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(144.358F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "Default", "SizeF", new System.Drawing.SizeF(144.358F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "Default", "Text", "To: [?DateTo!dd-MM-yyyy]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "ar", "Text", "إلى: [?DateTo!dd-MM-yyyy]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel4, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(496.8578F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel4, "Default", "SizeF", new System.Drawing.SizeF(199.1932F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel4, "Default", "Text", "[?AccountDim]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel5, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(353.5F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel5, "Default", "SizeF", new System.Drawing.SizeF(143.3578F, 20.00003F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel5, "Default", "Text", "Account Dimension:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel5, "ar", "Text", "أبعاد الحساب:"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable7, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable7, "Default", "SizeF", new System.Drawing.SizeF(808F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable8, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable8, "Default", "SizeF", new System.Drawing.SizeF(808F, 40F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell11, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 6.75F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell11, "Default", "Text", "xrTableCell11"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell11, "Default", "TextFormatString", "{0:#,##0.00;#,##0.00; }"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell11, "Default", "Weight", 0.69385684994785635D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell12, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 6.75F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell12, "Default", "Weight", 0.74769028012729555D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell13, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell13, "Default", "Text", "Credit"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell13, "ar", "Text", "دائن"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell13, "Default", "Weight", 0.66808995777834979D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell16, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell16, "Default", "Text", "Debit"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell16, "ar", "Text", "مدين"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell16, "Default", "Weight", 0.66808940379921289D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell4, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 6.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell4, "Default", "Text", ""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell4, "Default", "TextFormatString", "{0:#,##0.00;#,##0.00; }"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell4, "Default", "Weight", 1.4333480600619353D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell48, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell48, "Default", "Text", "Grand Total "),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell48, "ar", "Text", "الاجمالي الكلي"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell48, "Default", "Weight", 1.0316012941082409D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell49, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 6.75F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell49, "Default", "Text", "tfDebit_GPT"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell49, "Default", "TextFormatString", "{0:#,##0.00;#,##0.00; }"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell49, "Default", "Weight", 0.69385558744414666D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell50, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 6.75F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell50, "Default", "Text", "tfCredit_GPT"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell50, "Default", "TextFormatString", "{0:#,##0.00;#,##0.00; }"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell50, "Default", "Weight", 0.69385477594068368D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell51, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 6.75F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell51, "Default", "TextFormatString", "{0:#,##0.00;#,##0.00; }"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell51, "Default", "Weight", 0.69385498558095426D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell52, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 6.75F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell52, "Default", "TextFormatString", "{0:#,##0.00;#,##0.00; }"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell52, "Default", "Weight", 0.844677318189302D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell53, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell53, "Default", "Text", "Movement"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell53, "ar", "Text", "الحركة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell53, "Default", "Weight", 1.8589661235800279D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell54, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell54, "Default", "Text", "Close Balance"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell54, "ar", "Text", "رصيد اخر المدة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell54, "Default", "Weight", 2.0610018032134367D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell55, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell55, "Default", "Text", "Debit"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell55, "ar", "Text", "مدين"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell55, "Default", "Weight", 0.66809040096165939D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell56, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell56, "Default", "Text", "Credit"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell56, "ar", "Text", "دائن"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell56, "Default", "Weight", 0.66808887757497049D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell57, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell57, "Default", "Text", "Debit"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell57, "ar", "Text", "مدين"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell57, "Default", "Weight", 0.66808996294104828D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell58, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell58, "Default", "Text", "Credit"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell58, "ar", "Text", "دائن"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell58, "Default", "Weight", 0.81331296676544518D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell6, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell6, "Default", "Text", "Open Balance"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell6, "ar", "Text", "رصيد اول المدة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell6, "Default", "Weight", 1.8589635031155585D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell63, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell63, "Default", "Text", "Dealing  Type"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell63, "ar", "Text", "نوع التعامل"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell63, "Default", "Weight", 1.0011942636096305D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell64, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell64, "Default", "Weight", 0.71992558188781275D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell65, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell65, "Default", "Text", "Date"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell65, "Default", "Weight", 1.3823264033503984D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell66, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell66, "Default", "Weight", 0.99329404617274886D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell8, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 6.25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell8, "Default", "Text", "xrTableCell8"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell8, "Default", "TextFormatString", "{0:#,##0.00;#,##0.00; }"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell8, "Default", "Weight", 1.7449160721278922D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell9, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 6.75F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell9, "Default", "Text", "xrTableCell9"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell9, "Default", "TextFormatString", "{0:#,##0.00;#,##0.00; }"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell9, "Default", "Weight", 0.69385547400696856D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow10, "Default", "Weight", 0.5D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow11, "Default", "Weight", 0.5D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow9, "Default", "Weight", 1D)});
            this.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.PageHeightF = 1169.291F;
            this.PageWidthF = 826.7717F;
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
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IsDealType, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IsShowEquivalentData, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.NoOfGroupsPerPage, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.FontSize, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.DateFrom, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.DateTo, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.Code_Str, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.CustSupp, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.WhichType, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.AccountDim, DevExpress.XtraReports.Parameters.Orientation.Vertical)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.IsRTL,
            this.IsCustomReportFooter,
            this.IsCustomReportHeader,
            this.ShowSignature,
            this.ShowSignatureAllPages,
            this.HideReportHeader,
            this.HideReportFooter,
            this.IsDealType,
            this.IsShowEquivalentData,
            this.NoOfGroupsPerPage,
            this.FontSize,
            this.DateFrom,
            this.DateTo,
            this.Code_Str,
            this.CustSupp,
            this.WhichType,
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
            this.Version = "25.2";
            ((System.ComponentModel.ISupportInitialize)(this.tDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion
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
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.Parameters.Parameter DateFrom;
        private DevExpress.XtraReports.Parameters.Parameter DateTo;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoCurrentTime;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoCurrentDate;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoPageNoOfTotal;
        private DevExpress.XtraReports.Parameters.Parameter Code_Str;
        private DevExpress.XtraReports.Parameters.Parameter IsDealType;
        private DevExpress.XtraReports.Parameters.Parameter CustSupp;
        private DevExpress.XtraReports.Parameters.Parameter IsShowEquivalentData;
        private DevExpress.XtraReports.UI.XRTable tDetail;
        private DevExpress.XtraReports.UI.XRTableRow trDetail;
        private DevExpress.XtraReports.UI.XRTableCell tdAccount_From;
        private DevExpress.XtraReports.UI.XRTableCell tdCostCenter;
        private DevExpress.XtraReports.UI.XRTableCell tdDebit;
        private DevExpress.XtraReports.UI.XRTableCell tdCredit;
        private DevExpress.XtraReports.UI.XRTableCell tdCloseDebit;
        private DevExpress.XtraReports.UI.XRTableCell tdCloseCredit;
        private DevExpress.XtraReports.UI.SubBand PageHeaderSub3;
        private DevExpress.XtraReports.UI.SubBand ReportFooterSub3;
        private DevExpress.XtraReports.UI.XRTable xrTable7;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell48;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell49;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell50;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell51;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell52;
        private DevExpress.XtraReports.Parameters.Parameter WhichType;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.CalculatedField OpenDebit;
        private DevExpress.XtraReports.UI.CalculatedField CustomerName_CF;
        private DevExpress.XtraReports.UI.CalculatedField CloseDebit;
        private DevExpress.XtraReports.UI.CalculatedField Result;
        private DevExpress.XtraReports.UI.CalculatedField OpenCredit;
        private DevExpress.XtraReports.UI.CalculatedField Credit_Str;
        private DevExpress.XtraReports.UI.CalculatedField Debit_Str;
        private DevExpress.XtraReports.UI.CalculatedField DebitCreditOpenBalRes;
        private DevExpress.XtraReports.UI.CalculatedField Abs_OpenBal;
        private DevExpress.DataAccess.Sql.SqlDataSource dsFinance;
        private DevExpress.XtraReports.UI.CalculatedField OpenCredit_;
        private DevExpress.XtraReports.UI.CalculatedField CloseDebit_;
        private DevExpress.XtraReports.UI.CalculatedField CloseCredit_;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
        private DevExpress.XtraReports.UI.CalculatedField CloseBalance_;
        private DevExpress.XtraReports.UI.SubBand PageHeader_RHC;
        private DevExpress.XtraReports.UI.SubBand PageHeader_RH;
        private DevExpress.XtraReports.UI.XRSubreport srReportHeaderCustom;
        private DevExpress.XtraReports.Parameters.Parameter IsCustomReportHeader;
        private DevExpress.XtraReports.UI.SubBand SubBand1;
        private DevExpress.XtraReports.UI.SubBand SubBand2;
        private DevExpress.XtraReports.UI.XRSubreport srReportFooterCustom;
        private DevExpress.XtraReports.Parameters.Parameter IsCustomReportFooter;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
        private DevExpress.XtraReports.Parameters.Parameter AccountDim;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRTable xrTable8;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow10;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell65;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell63;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell53;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell54;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow11;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell66;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell64;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell13;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell55;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell56;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell57;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell58;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell16;
    }
}