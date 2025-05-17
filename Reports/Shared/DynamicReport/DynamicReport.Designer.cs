namespace DevExpressReports.PredefinedReports
{
    partial class DynamicReport
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
            DevExpress.XtraReports.Parameters.GroupLayoutItem groupLayoutItem1 = new DevExpress.XtraReports.Parameters.GroupLayoutItem("", false);
            DevExpress.XtraReports.Parameters.GroupLayoutItem groupLayoutItem2 = new DevExpress.XtraReports.Parameters.GroupLayoutItem("", true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DynamicReport));
            this.ShowSignature = new DevExpress.XtraReports.Parameters.Parameter();
            this.ShowSignatureAllPages = new DevExpress.XtraReports.Parameters.Parameter();
            this.HideReportHeader = new DevExpress.XtraReports.Parameters.Parameter();
            this.HideReportFooter = new DevExpress.XtraReports.Parameters.Parameter();
            this.sR_FC_AccountSheetTableAdapter = new DevExpressReports.Reports.GeneralLedger.DataSets.dsGeneralLedgerTableAdapters.SR_FC_JournalEntryTableAdapter();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.lblVetSoftData = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfoCurrentTime = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfoCurrentDate = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfoPageNoOfTotal = new DevExpress.XtraReports.UI.XRPageInfo();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
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
            this.PageHeaderSub_Info = new DevExpress.XtraReports.UI.SubBand();
            this.PageHeader_SubHeader = new DevExpress.XtraReports.UI.SubBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.ReportFooterSub_Summery = new DevExpress.XtraReports.UI.SubBand();
            this.ReportFooterSub1 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportNotes = new DevExpress.XtraReports.UI.XRSubreport();
            this.ReportFooterSub2 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportSignature = new DevExpress.XtraReports.UI.XRSubreport();
            this.NoOfGroupsPerPage = new DevExpress.XtraReports.Parameters.Parameter();
            this.DateFrom = new DevExpress.XtraReports.Parameters.Parameter();
            this.DateTo = new DevExpress.XtraReports.Parameters.Parameter();
            this.DebitMinusCredit = new DevExpress.XtraReports.UI.CalculatedField();
            this.sR_FC_AccountSheetTableAdapter1 = new DevExpressReports.Reports.GeneralLedger.DataSets.dsGeneralLedgerTableAdapters.SR_FC_AccountSheetTableAdapter();
            this.IsCustomReportFooter = new DevExpress.XtraReports.Parameters.Parameter();
            this.IsCustomReportHeader = new DevExpress.XtraReports.Parameters.Parameter();
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
            this.Detail.Name = "Detail";
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
            this.PageHeaderSub_Info,
            this.PageHeader_SubHeader});
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
            // PageHeaderSub_Info
            // 
            this.PageHeaderSub_Info.Name = "PageHeaderSub_Info";
            // 
            // PageHeader_SubHeader
            // 
            this.PageHeader_SubHeader.Name = "PageHeader_SubHeader";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.ReportFooterSub_Summery,
            this.ReportFooterSub1,
            this.ReportFooterSub2});
            // 
            // ReportFooterSub_Summery
            // 
            this.ReportFooterSub_Summery.Name = "ReportFooterSub_Summery";
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
            // DynamicReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.Detail,
            this.BottomMargin,
            this.PageFooter,
            this.PageHeader,
            this.ReportFooter});
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.BorderWidth = 0.5F;
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.DebitMinusCredit});
            this.ExportOptions.Pdf.DocumentOptions.Author = "VetSoft";
            this.ImageResources.AddRange(new DevExpress.XtraPrinting.Drawing.ImageItem[] {
            new DevExpress.XtraPrinting.Drawing.ImageItem("imgFalse", new DevExpress.XtraPrinting.Drawing.ImageSource("img", "R0lGODlhDgAOAIIFANRfVdSfqtS/qtTf/////////wAAAAAAACH/C05FVFNDQVBFMi4wAwEBAAAh+QQBA" +
                        "AAFACwAAAAADgAOAAAIQgALCBwQAIBBAAEGCFwo4KBDAAIYPnwYccDEiQQvPiyoUSOBjyA/TgwZsqNGj" +
                        "iYTmjSosGHHiAJdToS5MOPBhAsDAgA7")),
            new DevExpress.XtraPrinting.Drawing.ImageItem("imgTrue", new DevExpress.XtraPrinting.Drawing.ImageSource("img", "R0lGODlhEgAOAIEDALXVl2WoMNDkuv///yH/C05FVFNDQVBFMi4wAwEBAAAh+QQBAAADACwAAAAAEgAOA" +
                        "AAITwAHCBxIcGCAgggLBhBwMCHChQIYOiQIMSKAhgIxZoxoUeNCjBUFXKTI8WDIkQYBcGS4EiVFlSs7O" +
                        "gwAk6PLhDRtapyp8ubEATR3/gQ6NCAAOw=="))});
            this.LocalizationItems.AddRange(new DevExpress.XtraReports.Localization.LocalizationItem[] {
            new DevExpress.XtraReports.Localization.LocalizationItem(this.BottomMargin, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateFrom, "Default", "Description", "From"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateFrom, "ar", "Description", "من"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateTo, "Default", "Description", "To"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateTo, "ar", "Description", "إلى"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.Detail, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "DisplayName", "Account Sheet Summary"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "ar", "DisplayName", "كشف حساب تجميعي"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Margins", new DevExpress.Drawing.DXMargins(10F, 10F, 20F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "PaperKind", DevExpress.Drawing.Printing.DXPaperKind.A4),
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
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeaderSub_Info, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeader_SubHeader, "Default", "HeightF", 0F),
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
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooterSub_Summery, "Default", "HeightF", 0F),
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
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand1, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand2, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand3, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand4, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.TopMargin, "Default", "HeightF", 20F)});
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
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.DateTo, DevExpress.XtraReports.Parameters.Orientation.Vertical)});
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
            this.DateTo});
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
            this.Version = "24.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion
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
        private DevExpress.XtraReports.UI.SubBand PageHeaderSub_Info;
        private DevExpress.XtraReports.UI.SubBand ReportFooterSub2;
        private DevExpress.XtraReports.Parameters.Parameter FontSize;
        private DevExpress.XtraReports.Parameters.Parameter DateFrom;
        private DevExpress.XtraReports.Parameters.Parameter DateTo;
        private DevExpress.XtraReports.UI.CalculatedField DebitMinusCredit;
        private DevExpress.XtraReports.UI.XRLabel lblVetSoftData;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoCurrentTime;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoCurrentDate;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoPageNoOfTotal;
        private Reports.GeneralLedger.DataSets.dsGeneralLedgerTableAdapters.SR_FC_AccountSheetTableAdapter sR_FC_AccountSheetTableAdapter1;
        private DevExpress.XtraReports.UI.SubBand SubBand1;
        private DevExpress.XtraReports.UI.SubBand SubBand2;
        private DevExpress.XtraReports.UI.SubBand SubBand3;
        private DevExpress.XtraReports.UI.SubBand SubBand4;
        private DevExpress.XtraReports.UI.XRSubreport srReportHeaderCustom;
        private DevExpress.XtraReports.UI.XRSubreport srReportFooterCustom;
        private DevExpress.XtraReports.Parameters.Parameter IsCustomReportFooter;
        private DevExpress.XtraReports.Parameters.Parameter IsCustomReportHeader;
        private DevExpress.XtraReports.UI.SubBand PageHeader_SubHeader;
        private DevExpress.XtraReports.UI.SubBand ReportFooterSub_Summery;
    }
}