namespace DevExpressReports.Reports.FeedMill.Feed.Summary.FeedSoldDelivery
{
    partial class SR_FM_FeedSoldDelivery
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
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition crossTabColumnDefinition1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(2F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition crossTabColumnDefinition2 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(2F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField crossTabColumnField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField crossTabColumnField2 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField crossTabColumnField3 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabDataField crossTabDataField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SR_FM_FeedSoldDelivery));
            DevExpress.XtraReports.Parameters.GroupLayoutItem groupLayoutItem1 = new DevExpress.XtraReports.Parameters.GroupLayoutItem("", false);
            DevExpress.XtraReports.Parameters.GroupLayoutItem groupLayoutItem2 = new DevExpress.XtraReports.Parameters.GroupLayoutItem("", true);
            this.ShowSignature = new DevExpress.XtraReports.Parameters.Parameter();
            this.ShowSignatureAllPages = new DevExpress.XtraReports.Parameters.Parameter();
            this.HideReportHeader = new DevExpress.XtraReports.Parameters.Parameter();
            this.HideReportFooter = new DevExpress.XtraReports.Parameters.Parameter();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfoCurrentTime = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfoCurrentDate = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfoPageNoOfTotal = new DevExpress.XtraReports.UI.XRPageInfo();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.SubBand6 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportSignature_PageFooter = new DevExpress.XtraReports.UI.XRSubreport();
            this.SubBand7 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportFooterCustom = new DevExpress.XtraReports.UI.XRSubreport();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.SubBand3 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportHeaderCustom = new DevExpress.XtraReports.UI.XRSubreport();
            this.SubBand5 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportHeader = new DevExpress.XtraReports.UI.XRSubreport();
            this.PageHeaderSub1 = new DevExpress.XtraReports.UI.SubBand();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.SubBand2 = new DevExpress.XtraReports.UI.SubBand();
            this.xrCrossTab1 = new DevExpress.XtraReports.UI.XRCrossTab();
            this.crossTabHeaderCell1 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabDataCell1 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell2 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell3 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell4 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell1 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell5 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell2 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell3 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell6 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell7 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell4 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell5 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell8 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell9 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell6 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell7 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.dsFinance1 = new DevExpressReports.Reports.Finance.DataSets.dsFinance();
            this.ReportFooterSub1 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportNotes = new DevExpress.XtraReports.UI.XRSubreport();
            this.ReportFooterSub2 = new DevExpress.XtraReports.UI.SubBand();
            this.srReportSignature = new DevExpress.XtraReports.UI.XRSubreport();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabGeneralStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabHeaderStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabDataStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabTotalStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.Abs_OpenBal = new DevExpress.XtraReports.UI.CalculatedField();
            this.DebitCreditOpenBalRes = new DevExpress.XtraReports.UI.CalculatedField();
            this.Debit_Str = new DevExpress.XtraReports.UI.CalculatedField();
            this.Credit_Str = new DevExpress.XtraReports.UI.CalculatedField();
            this.OpenDebit = new DevExpress.XtraReports.UI.CalculatedField();
            this.OpenCredit = new DevExpress.XtraReports.UI.CalculatedField();
            this.Result = new DevExpress.XtraReports.UI.CalculatedField();
            this.CloseDebit = new DevExpress.XtraReports.UI.CalculatedField();
            this.Open_Balance_Prod = new DevExpress.XtraReports.UI.CalculatedField();
            this.Inputs_Prod = new DevExpress.XtraReports.UI.CalculatedField();
            this.Consumed_Prod = new DevExpress.XtraReports.UI.CalculatedField();
            this.Outputs_Prod = new DevExpress.XtraReports.UI.CalculatedField();
            this.Other_Output_Prod = new DevExpress.XtraReports.UI.CalculatedField();
            this.Close_Balance_Prod = new DevExpress.XtraReports.UI.CalculatedField();
            this.CondLoss_Prod = new DevExpress.XtraReports.UI.CalculatedField();
            this.Deviation_Prod = new DevExpress.XtraReports.UI.CalculatedField();
            this.ProdType_Prod = new DevExpress.XtraReports.UI.CalculatedField();
            this.Produced = new DevExpress.XtraReports.UI.CalculatedField();
            this.Rejected = new DevExpress.XtraReports.UI.CalculatedField();
            this.IsRTL = new DevExpress.XtraReports.Parameters.Parameter();
            this.IsCustomReportFooter = new DevExpress.XtraReports.Parameters.Parameter();
            this.IsCustomReportHeader = new DevExpress.XtraReports.Parameters.Parameter();
            this.IsDealType = new DevExpress.XtraReports.Parameters.Parameter();
            this.NoOfGroupsPerPage = new DevExpress.XtraReports.Parameters.Parameter();
            this.FontSize = new DevExpress.XtraReports.Parameters.Parameter();
            this.DateFrom = new DevExpress.XtraReports.Parameters.Parameter();
            this.DateTo = new DevExpress.XtraReports.Parameters.Parameter();
            this.Code_Str = new DevExpress.XtraReports.Parameters.Parameter();
            this.CustSupp = new DevExpress.XtraReports.Parameters.Parameter();
            this.FarmNo = new DevExpress.XtraReports.Parameters.Parameter();
            this.FlockCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.WeekNo = new DevExpress.XtraReports.Parameters.Parameter();
            this.SheetNo = new DevExpress.XtraReports.Parameters.Parameter();
            this.Total_Res = new DevExpress.XtraReports.Parameters.Parameter();
            this.FeedMillCode = new DevExpress.XtraReports.Parameters.Parameter();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sR_FM_Fed_SUM_DeliveryTableAdapter = new DevExpressReports.Reports.Finance.DataSets.dsFinanceTableAdapters.SR_FM_Fed_SUM_DeliveryTableAdapter();
            this.SexType = new DevExpress.XtraReports.Parameters.Parameter();
            this.crossTabGeneralStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabHeaderStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabDataStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabTotalStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
            ((System.ComponentModel.ISupportInitialize)(this.xrCrossTab1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFinance1)).BeginInit();
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
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            // 
            // PageFooter
            // 
            this.PageFooter.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?HideReportFooter==false")});
            this.PageFooter.Name = "PageFooter";
            this.PageFooter.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand6,
            this.SubBand7});
            // 
            // SubBand6
            // 
            this.SubBand6.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportSignature_PageFooter});
            this.SubBand6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?ShowSignature == True && ?ShowSignatureAllPages == True\n")});
            this.SubBand6.Name = "SubBand6";
            // 
            // srReportSignature_PageFooter
            // 
            this.srReportSignature_PageFooter.Name = "srReportSignature_PageFooter";
            this.srReportSignature_PageFooter.ReportSource = new DevExpressReports.PredefinedReports.SubReportSignature();
            // 
            // SubBand7
            // 
            this.SubBand7.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportFooterCustom});
            this.SubBand7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?IsCustomReportFooter")});
            this.SubBand7.Name = "SubBand7";
            // 
            // srReportFooterCustom
            // 
            this.srReportFooterCustom.Name = "srReportFooterCustom";
            // 
            // PageHeader
            // 
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand3,
            this.SubBand5,
            this.PageHeaderSub1});
            // 
            // SubBand3
            // 
            this.SubBand3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportHeaderCustom});
            this.SubBand3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?IsCustomReportHeader\nand ?HideReportHeader==false\n")});
            this.SubBand3.Name = "SubBand3";
            // 
            // srReportHeaderCustom
            // 
            this.srReportHeaderCustom.Name = "srReportHeaderCustom";
            this.srReportHeaderCustom.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("HideReportHeader", this.HideReportHeader));
            // 
            // SubBand5
            // 
            this.SubBand5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.srReportHeader});
            this.SubBand5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Not ?IsCustomReportHeader\nand ?HideReportHeader==false\n")});
            this.SubBand5.Name = "SubBand5";
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
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
            this.PageHeaderSub1.Name = "PageHeaderSub1";
            // 
            // xrLabel4
            // 
            this.xrLabel4.AutoWidth = true;
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.CanPublishOptions.Xls = false;
            this.xrLabel4.CanPublishOptions.Xlsx = false;
            this.xrLabel4.CanShrink = true;
            this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "!IsNullOrEmpty(?SexType)")});
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.StylePriority.UseBorders = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.AutoWidth = true;
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.CanPublishOptions.Xls = false;
            this.xrLabel3.CanPublishOptions.Xlsx = false;
            this.xrLabel3.CanShrink = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.StylePriority.UseBorders = false;
            // 
            // xrLabel2
            // 
            this.xrLabel2.AutoWidth = true;
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.CanPublishOptions.Xls = false;
            this.xrLabel2.CanPublishOptions.Xlsx = false;
            this.xrLabel2.CanShrink = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.StylePriority.UseBorders = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.CanGrow = false;
            this.xrLabel1.CanPublishOptions.Xls = false;
            this.xrLabel1.CanPublishOptions.Xlsx = false;
            this.xrLabel1.Name = "xrLabel1";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand2,
            this.ReportFooterSub1,
            this.ReportFooterSub2});
            // 
            // SubBand2
            // 
            this.SubBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCrossTab1});
            this.SubBand2.Name = "SubBand2";
            // 
            // xrCrossTab1
            // 
            this.xrCrossTab1.Cells.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.crossTabHeaderCell1,
            this.crossTabDataCell1,
            this.crossTabHeaderCell2,
            this.crossTabHeaderCell3,
            this.crossTabHeaderCell4,
            this.crossTabTotalCell1,
            this.crossTabHeaderCell5,
            this.crossTabTotalCell2,
            this.crossTabTotalCell3,
            this.crossTabHeaderCell6,
            this.crossTabHeaderCell7,
            this.crossTabTotalCell4,
            this.crossTabTotalCell5,
            this.crossTabHeaderCell8,
            this.crossTabHeaderCell9,
            this.crossTabTotalCell6,
            this.crossTabTotalCell7});
            crossTabColumnDefinition1.Visible = false;
            crossTabColumnDefinition2.Visible = false;
            this.xrCrossTab1.ColumnDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition[] {
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(110.5901F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(141.0796F),
            crossTabColumnDefinition1,
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(70.83331F),
            crossTabColumnDefinition2});
            crossTabColumnField1.FieldName = "ModuleType";
            crossTabColumnField2.FieldName = "FarmType";
            crossTabColumnField3.FieldName = "Destination";
            this.xrCrossTab1.ColumnFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField[] {
            crossTabColumnField1,
            crossTabColumnField2,
            crossTabColumnField3});
            this.xrCrossTab1.DataAreaStyleName = "crossTabDataStyle2";
            crossTabDataField1.FieldName = "NetWeight";
            this.xrCrossTab1.DataFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField[] {
            crossTabDataField1});
            this.xrCrossTab1.DataMember = "SR_FM_FeedSoldDelivery";
            this.xrCrossTab1.DataSource = this.dsFinance1;
            this.xrCrossTab1.GeneralStyleName = "crossTabGeneralStyle2";
            this.xrCrossTab1.HeaderAreaStyleName = "crossTabHeaderStyle2";
            this.xrCrossTab1.Name = "xrCrossTab1";
            this.xrCrossTab1.RowDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition[] {
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(24.99999F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(24.99999F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(24.99999F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(36.45833F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(24.99999F)});
            crossTabRowField1.FieldName = "FeedType_en";
            this.xrCrossTab1.RowFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField[] {
            crossTabRowField1});
            this.xrCrossTab1.TotalAreaStyleName = "crossTabTotalStyle2";
            // 
            // crossTabHeaderCell1
            // 
            this.crossTabHeaderCell1.BackColor = System.Drawing.Color.White;
            this.crossTabHeaderCell1.BorderWidth = 1.4F;
            this.crossTabHeaderCell1.ColumnIndex = 0;
            this.crossTabHeaderCell1.Name = "crossTabHeaderCell1";
            this.crossTabHeaderCell1.RowIndex = 0;
            this.crossTabHeaderCell1.RowSpan = 3;
            this.crossTabHeaderCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabDataCell1
            // 
            this.crossTabDataCell1.BorderWidth = 1.4F;
            this.crossTabDataCell1.ColumnIndex = 1;
            this.crossTabDataCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL != True, \'MiddleRight\', \'MiddleLeft\')\n")});
            this.crossTabDataCell1.Name = "crossTabDataCell1";
            this.crossTabDataCell1.RowIndex = 3;
            // 
            // crossTabHeaderCell2
            // 
            this.crossTabHeaderCell2.BackColor = System.Drawing.Color.White;
            this.crossTabHeaderCell2.BorderWidth = 1.4F;
            this.crossTabHeaderCell2.ColumnIndex = 1;
            this.crossTabHeaderCell2.ColumnSpan = 2;
            this.crossTabHeaderCell2.Name = "crossTabHeaderCell2";
            this.crossTabHeaderCell2.RowIndex = 0;
            this.crossTabHeaderCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabHeaderCell3
            // 
            this.crossTabHeaderCell3.BackColor = System.Drawing.Color.White;
            this.crossTabHeaderCell3.BorderWidth = 1.4F;
            this.crossTabHeaderCell3.ColumnIndex = 0;
            this.crossTabHeaderCell3.Name = "crossTabHeaderCell3";
            this.crossTabHeaderCell3.RowIndex = 3;
            this.crossTabHeaderCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabHeaderCell4
            // 
            this.crossTabHeaderCell4.BackColor = System.Drawing.Color.White;
            this.crossTabHeaderCell4.BorderWidth = 1.4F;
            this.crossTabHeaderCell4.ColumnIndex = 0;
            this.crossTabHeaderCell4.Name = "crossTabHeaderCell4";
            this.crossTabHeaderCell4.RowIndex = 4;
            this.crossTabHeaderCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabTotalCell1
            // 
            this.crossTabTotalCell1.BorderWidth = 1.4F;
            this.crossTabTotalCell1.ColumnIndex = 1;
            this.crossTabTotalCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL != True, \'MiddleRight\', \'MiddleLeft\')\n")});
            this.crossTabTotalCell1.Name = "crossTabTotalCell1";
            this.crossTabTotalCell1.RowIndex = 4;
            // 
            // crossTabHeaderCell5
            // 
            this.crossTabHeaderCell5.ColumnIndex = 4;
            this.crossTabHeaderCell5.Name = "crossTabHeaderCell5";
            this.crossTabHeaderCell5.RowIndex = 0;
            this.crossTabHeaderCell5.RowSpan = 3;
            // 
            // crossTabTotalCell2
            // 
            this.crossTabTotalCell2.ColumnIndex = 4;
            this.crossTabTotalCell2.Name = "crossTabTotalCell2";
            this.crossTabTotalCell2.RowIndex = 3;
            // 
            // crossTabTotalCell3
            // 
            this.crossTabTotalCell3.ColumnIndex = 4;
            this.crossTabTotalCell3.Name = "crossTabTotalCell3";
            this.crossTabTotalCell3.RowIndex = 4;
            // 
            // crossTabHeaderCell6
            // 
            this.crossTabHeaderCell6.BackColor = System.Drawing.Color.White;
            this.crossTabHeaderCell6.BorderWidth = 1.4F;
            this.crossTabHeaderCell6.ColumnIndex = 1;
            this.crossTabHeaderCell6.Name = "crossTabHeaderCell6";
            this.crossTabHeaderCell6.RowIndex = 1;
            this.crossTabHeaderCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabHeaderCell7
            // 
            this.crossTabHeaderCell7.BackColor = System.Drawing.Color.White;
            this.crossTabHeaderCell7.BorderWidth = 1.4F;
            this.crossTabHeaderCell7.ColumnIndex = 3;
            this.crossTabHeaderCell7.Name = "crossTabHeaderCell7";
            this.crossTabHeaderCell7.RowIndex = 0;
            this.crossTabHeaderCell7.RowSpan = 3;
            this.crossTabHeaderCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabTotalCell4
            // 
            this.crossTabTotalCell4.BorderWidth = 1.4F;
            this.crossTabTotalCell4.ColumnIndex = 3;
            this.crossTabTotalCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL != True, \'MiddleRight\', \'MiddleLeft\')\n")});
            this.crossTabTotalCell4.Name = "crossTabTotalCell4";
            this.crossTabTotalCell4.RowIndex = 3;
            // 
            // crossTabTotalCell5
            // 
            this.crossTabTotalCell5.BorderWidth = 1.4F;
            this.crossTabTotalCell5.ColumnIndex = 3;
            this.crossTabTotalCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL != True, \'MiddleRight\', \'MiddleLeft\')\n")});
            this.crossTabTotalCell5.Name = "crossTabTotalCell5";
            this.crossTabTotalCell5.RowIndex = 4;
            // 
            // crossTabHeaderCell8
            // 
            this.crossTabHeaderCell8.BackColor = System.Drawing.Color.White;
            this.crossTabHeaderCell8.BorderWidth = 1.4F;
            this.crossTabHeaderCell8.ColumnIndex = 1;
            this.crossTabHeaderCell8.Name = "crossTabHeaderCell8";
            this.crossTabHeaderCell8.RowIndex = 2;
            this.crossTabHeaderCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabHeaderCell9
            // 
            this.crossTabHeaderCell9.ColumnIndex = 2;
            this.crossTabHeaderCell9.Name = "crossTabHeaderCell9";
            this.crossTabHeaderCell9.RowIndex = 1;
            this.crossTabHeaderCell9.RowSpan = 2;
            // 
            // crossTabTotalCell6
            // 
            this.crossTabTotalCell6.ColumnIndex = 2;
            this.crossTabTotalCell6.Name = "crossTabTotalCell6";
            this.crossTabTotalCell6.RowIndex = 3;
            // 
            // crossTabTotalCell7
            // 
            this.crossTabTotalCell7.ColumnIndex = 2;
            this.crossTabTotalCell7.Name = "crossTabTotalCell7";
            this.crossTabTotalCell7.RowIndex = 4;
            // 
            // dsFinance1
            // 
            this.dsFinance1.DataSetName = "dsFinance";
            this.dsFinance1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // crossTabGeneralStyle1
            // 
            this.crossTabGeneralStyle1.BackColor = System.Drawing.Color.White;
            this.crossTabGeneralStyle1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.crossTabGeneralStyle1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabGeneralStyle1.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.crossTabGeneralStyle1.ForeColor = System.Drawing.Color.Black;
            this.crossTabGeneralStyle1.Name = "crossTabGeneralStyle1";
            this.crossTabGeneralStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            // 
            // crossTabHeaderStyle1
            // 
            this.crossTabHeaderStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.crossTabHeaderStyle1.Name = "crossTabHeaderStyle1";
            this.crossTabHeaderStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabDataStyle1
            // 
            this.crossTabDataStyle1.Name = "crossTabDataStyle1";
            this.crossTabDataStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // crossTabTotalStyle1
            // 
            this.crossTabTotalStyle1.Name = "crossTabTotalStyle1";
            this.crossTabTotalStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // Abs_OpenBal
            // 
            this.Abs_OpenBal.DataMember = "SR_FC_CustSuppSheet";
            this.Abs_OpenBal.Expression = "Abs([OpenBalance])";
            this.Abs_OpenBal.Name = "Abs_OpenBal";
            // 
            // DebitCreditOpenBalRes
            // 
            this.DebitCreditOpenBalRes.DataMember = "SR_FC_CustSuppSheet";
            this.DebitCreditOpenBalRes.Expression = "Iif([OpenBalance] > 0,[Debit_Str] , Iif([OpenBalance] < 0, [Credit_Str], \'\'))";
            this.DebitCreditOpenBalRes.Name = "DebitCreditOpenBalRes";
            // 
            // Debit_Str
            // 
            this.Debit_Str.DataMember = "SR_FC_CustSuppSheet";
            this.Debit_Str.Expression = "Iif(?IsRTL == true,\'(مدين)\' , \'(Debit)\')";
            this.Debit_Str.Name = "Debit_Str";
            // 
            // Credit_Str
            // 
            this.Credit_Str.DataMember = "SR_FC_CustSuppSheet";
            this.Credit_Str.Expression = "Iif(?IsRTL == true,\'(دائن)\' , \'(Credit)\')";
            this.Credit_Str.Name = "Credit_Str";
            // 
            // OpenDebit
            // 
            this.OpenDebit.DataMember = "SR_FC_CustSuppSheet";
            this.OpenDebit.Expression = "Iif([OpenBalance] > 0, [OpenBalance], NULL)";
            this.OpenDebit.Name = "OpenDebit";
            // 
            // OpenCredit
            // 
            this.OpenCredit.DataMember = "SR_FC_CustSuppSheet";
            this.OpenCredit.Expression = "Iif([OpenBalance] < 0, Abs([OpenBalance]), NULL)\n";
            this.OpenCredit.Name = "OpenCredit";
            // 
            // Result
            // 
            this.Result.DataMember = "SR_FC_CustSuppSheet";
            this.Result.Expression = "[Debit] - [Credit]";
            this.Result.Name = "Result";
            // 
            // CloseDebit
            // 
            this.CloseDebit.DataMember = "SR_FC_CustSuppSheet";
            this.CloseDebit.Expression = "Iif([CloseBalance] > 0, [CloseBalance], 0)";
            this.CloseDebit.Name = "CloseDebit";
            // 
            // Open_Balance_Prod
            // 
            this.Open_Balance_Prod.DataMember = "SR_FC_FM_StockMovement";
            this.Open_Balance_Prod.Expression = "Iif([FormulaOperand_Prod]<>0,ToDecimal([OpenBalance])/[FormulaOperand_Prod] ,0 )";
            this.Open_Balance_Prod.Name = "Open_Balance_Prod";
            // 
            // Inputs_Prod
            // 
            this.Inputs_Prod.DataMember = "SR_FC_FM_StockMovement";
            this.Inputs_Prod.Expression = "Iif([FormulaOperand_Prod]<>0,ToDecimal([InputsStdUnit])/[FormulaOperand_Prod] ,0 " +
    ")\n";
            this.Inputs_Prod.Name = "Inputs_Prod";
            // 
            // Consumed_Prod
            // 
            this.Consumed_Prod.DataMember = "SR_FC_FM_StockMovement";
            this.Consumed_Prod.Expression = "Iif([FormulaOperand_Prod]<>0,ToDecimal([Consumed])/[FormulaOperand_Prod] ,0 )\n";
            this.Consumed_Prod.Name = "Consumed_Prod";
            // 
            // Outputs_Prod
            // 
            this.Outputs_Prod.DataMember = "SR_FC_FM_StockMovement";
            this.Outputs_Prod.Expression = "Iif([FormulaOperand_Prod]<>0,ToDecimal([SoldTransferOut])/[FormulaOperand_Prod] ," +
    "0 )\n";
            this.Outputs_Prod.Name = "Outputs_Prod";
            // 
            // Other_Output_Prod
            // 
            this.Other_Output_Prod.DataMember = "SR_FC_FM_StockMovement";
            this.Other_Output_Prod.Expression = "Iif([FormulaOperand_Prod]<>0,ToDecimal([OtherOutputsStdUnit])/[FormulaOperand_Pro" +
    "d] ,0 )\n";
            this.Other_Output_Prod.Name = "Other_Output_Prod";
            // 
            // Close_Balance_Prod
            // 
            this.Close_Balance_Prod.DataMember = "SR_FC_FM_StockMovement";
            this.Close_Balance_Prod.Expression = "Iif([FormulaOperand_Prod]<>0,ToDecimal([CloseBalance])/[FormulaOperand_Prod] ,0 )" +
    "\n";
            this.Close_Balance_Prod.Name = "Close_Balance_Prod";
            // 
            // CondLoss_Prod
            // 
            this.CondLoss_Prod.DataMember = "SR_FC_FM_StockMovement";
            this.CondLoss_Prod.Expression = "Iif([FormulaOperand_Prod]<>0,ToDecimal([CondLoss])/[FormulaOperand_Prod] ,0 )\n\n";
            this.CondLoss_Prod.Name = "CondLoss_Prod";
            // 
            // Deviation_Prod
            // 
            this.Deviation_Prod.DataMember = "SR_FC_FM_StockMovement";
            this.Deviation_Prod.Expression = "Iif([FormulaOperand_Prod]<>0,ToDecimal([Deviation])/[FormulaOperand_Prod] ,0 )\n\n";
            this.Deviation_Prod.Name = "Deviation_Prod";
            // 
            // ProdType_Prod
            // 
            this.ProdType_Prod.DataMember = "SR_FC_FM_StockMovement";
            this.ProdType_Prod.Expression = "[ProdType]+\'_\'+[Product]";
            this.ProdType_Prod.Name = "ProdType_Prod";
            // 
            // Produced
            // 
            this.Produced.DataMember = "SR_LAY_ProdWeeklyDepl";
            this.Produced.Expression = "IsNull([TotalSelleable],0 )+IsNull([HouseEggsReject],0 )+IsNull([MOBA],0 )";
            this.Produced.Name = "Produced";
            // 
            // Rejected
            // 
            this.Rejected.DataMember = "SR_LAY_ProdWeeklyDepl";
            this.Rejected.Expression = "IsNull([HouseEggsReject],0 )+IsNull([MOBA],0 )";
            this.Rejected.Name = "Rejected";
            // 
            // IsRTL
            // 
            this.IsRTL.Name = "IsRTL";
            this.IsRTL.Type = typeof(bool);
            this.IsRTL.ValueInfo = "False";
            this.IsRTL.Visible = false;
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
            // IsDealType
            // 
            this.IsDealType.Enabled = false;
            this.IsDealType.Name = "IsDealType";
            this.IsDealType.Type = typeof(bool);
            this.IsDealType.ValueInfo = "True";
            this.IsDealType.Visible = false;
            // 
            // NoOfGroupsPerPage
            // 
            this.NoOfGroupsPerPage.Name = "NoOfGroupsPerPage";
            // 
            // FontSize
            // 
            this.FontSize.Name = "FontSize";
            this.FontSize.Visible = false;
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
            // CustSupp
            // 
            this.CustSupp.Enabled = false;
            this.CustSupp.Name = "CustSupp";
            this.CustSupp.Visible = false;
            // 
            // FarmNo
            // 
            this.FarmNo.Name = "FarmNo";
            this.FarmNo.Visible = false;
            // 
            // FlockCode
            // 
            this.FlockCode.AllowNull = true;
            this.FlockCode.Name = "FlockCode";
            this.FlockCode.Visible = false;
            // 
            // WeekNo
            // 
            this.WeekNo.Name = "WeekNo";
            this.WeekNo.Type = typeof(int);
            this.WeekNo.ValueInfo = "0";
            this.WeekNo.Visible = false;
            // 
            // SheetNo
            // 
            this.SheetNo.Name = "SheetNo";
            this.SheetNo.Type = typeof(int);
            this.SheetNo.ValueInfo = "0";
            this.SheetNo.Visible = false;
            // 
            // Total_Res
            // 
            this.Total_Res.AllowNull = true;
            this.Total_Res.Name = "Total_Res";
            this.Total_Res.Visible = false;
            // 
            // FeedMillCode
            // 
            this.FeedMillCode.Name = "FeedMillCode";
            this.FeedMillCode.Visible = false;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "dslayer";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "RowSeq1";
            table1.Name = "SR_LAY_SortHouseIssue";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "RowData1";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "RowSeq2";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "RowData2";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "ColData1";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "ColData2";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "DataValue";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Name = "SR_LAY_SortHouseIssue";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // sR_FM_Fed_SUM_DeliveryTableAdapter
            // 
            this.sR_FM_Fed_SUM_DeliveryTableAdapter.ClearBeforeFill = true;
            // 
            // SexType
            // 
            this.SexType.Name = "SexType";
            this.SexType.Visible = false;
            // 
            // crossTabGeneralStyle2
            // 
            this.crossTabGeneralStyle2.BackColor = System.Drawing.Color.White;
            this.crossTabGeneralStyle2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.crossTabGeneralStyle2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabGeneralStyle2.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.crossTabGeneralStyle2.ForeColor = System.Drawing.Color.Black;
            this.crossTabGeneralStyle2.Name = "crossTabGeneralStyle2";
            this.crossTabGeneralStyle2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            // 
            // crossTabHeaderStyle2
            // 
            this.crossTabHeaderStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.crossTabHeaderStyle2.Name = "crossTabHeaderStyle2";
            this.crossTabHeaderStyle2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabDataStyle2
            // 
            this.crossTabDataStyle2.Name = "crossTabDataStyle2";
            this.crossTabDataStyle2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // crossTabTotalStyle2
            // 
            this.crossTabTotalStyle2.Name = "crossTabTotalStyle2";
            this.crossTabTotalStyle2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // SR_FM_FeedSoldDelivery
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
            this.OpenDebit,
            this.OpenCredit,
            this.Result,
            this.CloseDebit,
            this.Open_Balance_Prod,
            this.Inputs_Prod,
            this.Consumed_Prod,
            this.Outputs_Prod,
            this.Other_Output_Prod,
            this.Close_Balance_Prod,
            this.CondLoss_Prod,
            this.Deviation_Prod,
            this.ProdType_Prod,
            this.Produced,
            this.Rejected});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1,
            this.dsFinance1});
            this.DataMember = "SR_FM_FeedSoldDelivery";
            this.DataSource = this.dsFinance1;
            this.ExportOptions.Pdf.DocumentOptions.Author = "VetSoft";
            this.ExportOptions.Xls.IgnoreErrors = DevExpress.XtraPrinting.XlIgnoreErrors.NumberStoredAsText;
            this.ExportOptions.Xls.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text;
            this.ExportOptions.Xlsx.IgnoreErrors = DevExpress.XtraPrinting.XlIgnoreErrors.NumberStoredAsText;
            this.ExportOptions.Xlsx.TextExportMode = DevExpress.XtraPrinting.TextExportMode.Text;
            this.Landscape = true;
            this.LocalizationItems.AddRange(new DevExpress.XtraReports.Localization.LocalizationItem[] {
            new DevExpress.XtraReports.Localization.LocalizationItem(this.BottomMargin, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.Code_Str, "Default", "Description", "Code_Str"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabDataCell1, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell1, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell1, "Default", "Text", "Feed Type"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell1, "ar", "Text", "نوع العلف"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell2, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell3, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell4, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell4, "Default", "Text", "Total"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell4, "ar", "Text", "الاجمالي"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell5, "Default", "Text", "Grand Total"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell6, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell7, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell7, "Default", "Text", "Total"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell7, "ar", "Text", "الاجمالي"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell7, "Default", "TextFormatString", "Total {0}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell8, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell9, "Default", "TextFormatString", "Total {0}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabTotalCell1, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabTotalCell4, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabTotalCell4, "Default", "TextFormatString", "{0:N0}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabTotalCell5, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.CustSupp, "Default", "Description", "CustSupp"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateFrom, "Default", "Description", "From"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateFrom, "ar", "Description", "من"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateTo, "Default", "Description", "To"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateTo, "ar", "Description", "إلى"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.Detail, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.FarmNo, "Default", "Description", "FarmNo"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.FeedMillCode, "Default", "Description", "FeedMillCode"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.FlockCode, "Default", "Description", "FlockCode"),
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
            new DevExpress.XtraReports.Localization.LocalizationItem(this.NoOfGroupsPerPage, "Default", "Description", "No of groups / page"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.NoOfGroupsPerPage, "ar", "Description", "عدد المجموعات / صفحة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageFooter, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeader, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeaderSub1, "Default", "HeightF", 20.00001F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentDate, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentDate, "Default", "SizeF", new System.Drawing.SizeF(341.4617F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentTime, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(353.5F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentTime, "Default", "SizeF", new System.Drawing.SizeF(930F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentTime, "Default", "TextFormatString", "{0:HH:mm:ss}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoPageNoOfTotal, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1328.833F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoPageNoOfTotal, "Default", "SizeF", new System.Drawing.SizeF(308.1638F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoPageNoOfTotal, "Default", "TextFormatString", "Page {0} of {1}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooter, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooterSub1, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooterSub2, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SexType, "Default", "Description", "SexType"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SheetNo, "Default", "Description", "SheetNo"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignature, "Default", "Description", "Show signature"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignature, "ar", "Description", "عرض التوقيع"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignatureAllPages, "Default", "Description", "Show signature in all page"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignatureAllPages, "ar", "Description", "عرض التوقيع في كل الصفحات"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportFooterCustom, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportFooterCustom, "Default", "SizeF", new System.Drawing.SizeF(1637F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportHeader, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(3.003375F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportHeader, "Default", "SizeF", new System.Drawing.SizeF(1633.993F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportHeaderCustom, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportHeaderCustom, "Default", "SizeF", new System.Drawing.SizeF(1637F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportNotes, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportNotes, "Default", "SizeF", new System.Drawing.SizeF(1637F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature, "Default", "SizeF", new System.Drawing.SizeF(1636.997F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature_PageFooter, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(2.000046F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature_PageFooter, "Default", "SizeF", new System.Drawing.SizeF(1634.997F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "DisplayName", "SR_FC_FM_StockMovement"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "ar", "DisplayName", "قيود يومية تفصيلي"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Margins", new DevExpress.Drawing.DXMargins(7F, 10F, 20F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "PaperKind", DevExpress.Drawing.Printing.DXPaperKind.A3),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand2, "Default", "HeightF", 137.7083F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand3, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand5, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand6, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand7, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.TopMargin, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.Total_Res, "Default", "Description", "Total_Res"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.WeekNo, "Default", "Description", "WeekNo"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCrossTab1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(9.999998F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCrossTab1, "Default", "SizeF", new System.Drawing.SizeF(326.503F, 136.4583F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(170.6285F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "ar", "LocationFloat", new DevExpress.Utils.PointFloat(178.3537F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "SizeF", new System.Drawing.SizeF(203.733F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "ar", "SizeF", new System.Drawing.SizeF(181.858F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "Default", "Text", "From: [?DateFrom!dd-MM-yyyy]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel1, "ar", "Text", "من: [?DateFrom!dd-MM-yyyy]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(397.4754F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "ar", "LocationFloat", new DevExpress.Utils.PointFloat(375.7455F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "Default", "SizeF", new System.Drawing.SizeF(211.0246F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "Default", "Text", "To: [?DateTo!dd-MM-yyyy]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "ar", "Text", "الي: [?DateTo!dd-MM-yyyy]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(3.003367F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "Default", "SizeF", new System.Drawing.SizeF(155.0867F, 20.00001F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "ar", "SizeF", new System.Drawing.SizeF(172.7951F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "Default", "Text", "FeedMill: [?FeedMillCode]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "ar", "Text", "مصنع العلف: [?FeedMillCode]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel4, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(625.399F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel4, "ar", "LocationFloat", new DevExpress.Utils.PointFloat(586.7701F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel4, "Default", "SizeF", new System.Drawing.SizeF(174.601F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel4, "Default", "Text", "Sex Type: [?SexType]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel4, "ar", "Text", "النوع: [?SexType]")});
            this.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.PageHeightF = 1169.291F;
            this.PageWidthF = 1653.543F;
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
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.NoOfGroupsPerPage, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.FontSize, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.DateFrom, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.DateTo, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.Code_Str, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.CustSupp, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.FarmNo, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.FlockCode, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.WeekNo, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.SheetNo, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.Total_Res, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.FeedMillCode, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.SexType, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.IsRTL,
            this.IsCustomReportFooter,
            this.IsCustomReportHeader,
            this.ShowSignature,
            this.ShowSignatureAllPages,
            this.HideReportHeader,
            this.HideReportFooter,
            this.IsDealType,
            this.NoOfGroupsPerPage,
            this.FontSize,
            this.DateFrom,
            this.DateTo,
            this.Code_Str,
            this.CustSupp,
            this.FarmNo,
            this.FlockCode,
            this.WeekNo,
            this.SheetNo,
            this.Total_Res,
            this.FeedMillCode,
            this.SexType});
            this.ScriptReferencesString = "E:\\VetSoft Projects .Net2024\\VetSoft Projects\\VetSoftDevExpress\\bin\\Release\\net8." +
    "0\\VetSoftDevExpress.dll";
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailData3_Odd,
            this.PageInfo,
            this.crossTabGeneralStyle1,
            this.crossTabHeaderStyle1,
            this.crossTabDataStyle1,
            this.crossTabTotalStyle1,
            this.crossTabGeneralStyle2,
            this.crossTabHeaderStyle2,
            this.crossTabDataStyle2,
            this.crossTabTotalStyle2});
            this.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.Version = "25.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrCrossTab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFinance1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoCurrentTime;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoCurrentDate;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfoPageNoOfTotal;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.SubBand SubBand6;
        private DevExpress.XtraReports.UI.XRSubreport srReportSignature_PageFooter;
        private DevExpress.XtraReports.UI.SubBand SubBand7;
        private DevExpress.XtraReports.UI.XRSubreport srReportFooterCustom;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.SubBand SubBand3;
        private DevExpress.XtraReports.UI.XRSubreport srReportHeaderCustom;
        private DevExpress.XtraReports.Parameters.Parameter HideReportHeader;
        private DevExpress.XtraReports.UI.SubBand SubBand5;
        private DevExpress.XtraReports.UI.XRSubreport srReportHeader;
        private DevExpress.XtraReports.UI.SubBand PageHeaderSub1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.SubBand SubBand2;
        private DevExpress.XtraReports.UI.SubBand ReportFooterSub1;
        private DevExpress.XtraReports.UI.XRSubreport srReportNotes;
        private DevExpress.XtraReports.UI.SubBand ReportFooterSub2;
        private DevExpress.XtraReports.UI.XRSubreport srReportSignature;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabGeneralStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabHeaderStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabDataStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabTotalStyle1;
        private DevExpress.XtraReports.UI.CalculatedField Abs_OpenBal;
        private DevExpress.XtraReports.UI.CalculatedField DebitCreditOpenBalRes;
        private DevExpress.XtraReports.UI.CalculatedField Debit_Str;
        private DevExpress.XtraReports.UI.CalculatedField Credit_Str;
        private DevExpress.XtraReports.UI.CalculatedField OpenDebit;
        private DevExpress.XtraReports.UI.CalculatedField OpenCredit;
        private DevExpress.XtraReports.UI.CalculatedField Result;
        private DevExpress.XtraReports.UI.CalculatedField CloseDebit;
        private DevExpress.XtraReports.UI.CalculatedField Open_Balance_Prod;
        private DevExpress.XtraReports.UI.CalculatedField Inputs_Prod;
        private DevExpress.XtraReports.UI.CalculatedField Consumed_Prod;
        private DevExpress.XtraReports.UI.CalculatedField Outputs_Prod;
        private DevExpress.XtraReports.UI.CalculatedField Other_Output_Prod;
        private DevExpress.XtraReports.UI.CalculatedField Close_Balance_Prod;
        private DevExpress.XtraReports.UI.CalculatedField CondLoss_Prod;
        private DevExpress.XtraReports.UI.CalculatedField Deviation_Prod;
        private DevExpress.XtraReports.UI.CalculatedField ProdType_Prod;
        private DevExpress.XtraReports.UI.CalculatedField Produced;
        private DevExpress.XtraReports.UI.CalculatedField Rejected;
        private DevExpress.XtraReports.Parameters.Parameter IsRTL;
        private DevExpress.XtraReports.Parameters.Parameter IsCustomReportFooter;
        private DevExpress.XtraReports.Parameters.Parameter IsCustomReportHeader;
        private DevExpress.XtraReports.Parameters.Parameter ShowSignature;
        private DevExpress.XtraReports.Parameters.Parameter ShowSignatureAllPages;
        private DevExpress.XtraReports.Parameters.Parameter HideReportFooter;
        private DevExpress.XtraReports.Parameters.Parameter IsDealType;
        private DevExpress.XtraReports.Parameters.Parameter NoOfGroupsPerPage;
        private DevExpress.XtraReports.Parameters.Parameter FontSize;
        private DevExpress.XtraReports.Parameters.Parameter DateFrom;
        private DevExpress.XtraReports.Parameters.Parameter DateTo;
        private DevExpress.XtraReports.Parameters.Parameter Code_Str;
        private DevExpress.XtraReports.Parameters.Parameter CustSupp;
        private DevExpress.XtraReports.Parameters.Parameter FarmNo;
        private DevExpress.XtraReports.Parameters.Parameter FlockCode;
        private DevExpress.XtraReports.Parameters.Parameter WeekNo;
        private DevExpress.XtraReports.Parameters.Parameter SheetNo;
        private DevExpress.XtraReports.Parameters.Parameter Total_Res;
        private DevExpress.XtraReports.Parameters.Parameter FeedMillCode;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private Finance.DataSets.dsFinance dsFinance1;
        private Finance.DataSets.dsFinanceTableAdapters.SR_FM_Fed_SUM_DeliveryTableAdapter sR_FM_Fed_SUM_DeliveryTableAdapter;
        private DevExpress.XtraReports.Parameters.Parameter SexType;
        private DevExpress.XtraReports.UI.XRCrossTab xrCrossTab1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabDataCell1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell2;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell3;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell4;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabGeneralStyle2;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabHeaderStyle2;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabDataStyle2;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabTotalStyle2;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell5;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell2;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell3;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell6;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell7;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell4;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell5;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell8;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell9;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell6;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell7;
    }
}
