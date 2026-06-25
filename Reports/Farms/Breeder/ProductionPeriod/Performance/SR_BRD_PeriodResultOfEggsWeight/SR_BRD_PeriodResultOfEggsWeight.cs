using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace DevExpressReports.Reports.Farms.Breeder.ProductionPeriod.Performance.SR_BRD_PeriodResultOfEggsWeight
{
    public partial class SR_BRD_PeriodResultOfEggsWeight : DevExpress.XtraReports.UI.XtraReport
    {
        public SR_BRD_PeriodResultOfEggsWeight()
        {
            InitializeComponent();
        }

        private TopMarginBand TopMargin;
        private BottomMarginBand BottomMargin;
        private XRPageInfo pageInfoCurrentTime;
        private XRPageInfo pageInfoCurrentDate;
        private XRPageInfo pageInfoPageNoOfTotal;
        private DetailBand Detail;
        private PageFooterBand PageFooter;
        private SubBand SubBand6;
        private XRSubreport srReportSignature_PageFooter;
        private SubBand SubBand7;
        private XRSubreport srReportFooterCustom;
        private PageHeaderBand PageHeader;
        private SubBand SubBand3;
        private XRSubreport srReportHeaderCustom;
        private DevExpress.XtraReports.Parameters.Parameter HideReportHeader;
        private SubBand SubBand5;
        private XRSubreport srReportHeader;
        private SubBand PageHeaderSub1;
        private SubBand SubBand1;
        private ReportFooterBand ReportFooter;
        private SubBand SubBand2;
        private XRCrossTab xrCrossTab1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabDataCell1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell2;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell3;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell4;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell5;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell2;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell3;
        private DevExpress.XtraReports.Parameters.Parameter IsRTL;
        private SubBand ReportFooterSub1;
        private XRSubreport srReportNotes;
        private SubBand ReportFooterSub2;
        private XRSubreport srReportSignature;
        private XRControlStyle Title;
        private XRControlStyle DetailCaption1;
        private XRControlStyle DetailData1;
        private XRControlStyle DetailData3_Odd;
        private XRControlStyle PageInfo;
        private XRControlStyle crossTabGeneralStyle1;
        private XRControlStyle crossTabHeaderStyle1;
        private XRControlStyle crossTabDataStyle1;
        private XRControlStyle crossTabTotalStyle1;
        private CalculatedField Abs_OpenBal;
        private CalculatedField DebitCreditOpenBalRes;
        private CalculatedField Debit_Str;
        private CalculatedField Credit_Str;
        private CalculatedField OpenDebit;
        private CalculatedField OpenCredit;
        private CalculatedField Result;
        private CalculatedField CloseDebit;
        private CalculatedField Open_Balance_Prod;
        private CalculatedField Inputs_Prod;
        private CalculatedField Consumed_Prod;
        private CalculatedField Outputs_Prod;
        private CalculatedField Other_Output_Prod;
        private CalculatedField Close_Balance_Prod;
        private CalculatedField CondLoss_Prod;
        private CalculatedField Deviation_Prod;
        private CalculatedField ProdType_Prod;
        private CalculatedField Produced;
        private CalculatedField Rejected;
        private CalculatedField CopyRight;
        private DevExpress.XtraReports.Parameters.Parameter IsCustomReportFooter;
        private DevExpress.XtraReports.Parameters.Parameter IsCustomReportHeader;
        private DevExpress.XtraReports.Parameters.Parameter ShowSignature;
        private DevExpress.XtraReports.Parameters.Parameter ShowSignatureAllPages;
        private DevExpress.XtraReports.Parameters.Parameter HideReportFooter;
        private DevExpress.XtraReports.Parameters.Parameter NoOfGroupsPerPage;
        private DevExpress.XtraReports.Parameters.Parameter FontSize;
        private DevExpress.XtraReports.Parameters.Parameter DateFrom;
        private DevExpress.XtraReports.Parameters.Parameter Farm;
        private DevExpress.XtraReports.Parameters.Parameter SheetNo;
        private DevExpress.XtraReports.Parameters.Parameter DateTo;
        private DevExpress.XtraReports.Parameters.Parameter BookPerf;
        private DevExpress.XtraReports.Parameters.Parameter Flock;
        private DevExpress.XtraReports.Parameters.Parameter CropNo;
        private DevExpress.XtraReports.Parameters.Parameter Breed;
        private DevExpress.DataAccess.Sql.SqlDataSource dsBreeder;
        private IContainer components;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition crossTabColumnDefinition1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(2.000031F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField crossTabColumnField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabDataField crossTabDataField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition crossTabRowDefinition1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(2F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition crossTabRowDefinition2 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(2F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition crossTabRowDefinition3 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(2F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField2 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField3 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
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
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column12 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression12 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column13 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression13 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column14 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression14 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column15 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression15 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column16 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression16 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SR_BRD_PeriodResultOfEggsWeight));
            DevExpress.DataAccess.Sql.SelectQuery selectQuery2 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column17 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression17 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column18 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression18 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column19 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression19 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column20 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression20 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column21 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression21 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column22 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression22 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column23 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression23 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column24 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression24 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column25 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression25 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column26 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression26 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column27 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression27 = new DevExpress.DataAccess.Sql.ColumnExpression();
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
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.xrTable7 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable8 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable9 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable10 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable11 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
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
            this.crossTabHeaderCell8 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell4 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell5 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell9 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell10 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell11 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell6 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell7 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.IsRTL = new DevExpress.XtraReports.Parameters.Parameter();
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
            this.CopyRight = new DevExpress.XtraReports.UI.CalculatedField();
            this.IsCustomReportFooter = new DevExpress.XtraReports.Parameters.Parameter();
            this.IsCustomReportHeader = new DevExpress.XtraReports.Parameters.Parameter();
            this.NoOfGroupsPerPage = new DevExpress.XtraReports.Parameters.Parameter();
            this.FontSize = new DevExpress.XtraReports.Parameters.Parameter();
            this.DateFrom = new DevExpress.XtraReports.Parameters.Parameter();
            this.Farm = new DevExpress.XtraReports.Parameters.Parameter();
            this.SheetNo = new DevExpress.XtraReports.Parameters.Parameter();
            this.DateTo = new DevExpress.XtraReports.Parameters.Parameter();
            this.BookPerf = new DevExpress.XtraReports.Parameters.Parameter();
            this.Flock = new DevExpress.XtraReports.Parameters.Parameter();
            this.CropNo = new DevExpress.XtraReports.Parameters.Parameter();
            this.Breed = new DevExpress.XtraReports.Parameters.Parameter();
            this.dsBreeder = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.LineType = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrCrossTab1)).BeginInit();
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
            this.pageInfoCurrentTime.ForeColor = System.Drawing.Color.Black;
            this.pageInfoCurrentTime.Name = "pageInfoCurrentTime";
            this.pageInfoCurrentTime.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.pageInfoCurrentTime.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfoCurrentTime.StyleName = "PageInfo";
            this.pageInfoCurrentTime.StylePriority.UseForeColor = false;
            this.pageInfoCurrentTime.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // pageInfoCurrentDate
            // 
            this.pageInfoCurrentDate.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.pageInfoCurrentDate.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.pageInfoCurrentDate.ForeColor = System.Drawing.Color.Black;
            this.pageInfoCurrentDate.Name = "pageInfoCurrentDate";
            this.pageInfoCurrentDate.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfoCurrentDate.StyleName = "PageInfo";
            this.pageInfoCurrentDate.StylePriority.UseForeColor = false;
            this.pageInfoCurrentDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // pageInfoPageNoOfTotal
            // 
            this.pageInfoPageNoOfTotal.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.pageInfoPageNoOfTotal.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.pageInfoPageNoOfTotal.ForeColor = System.Drawing.Color.Black;
            this.pageInfoPageNoOfTotal.Name = "pageInfoPageNoOfTotal";
            this.pageInfoPageNoOfTotal.StyleName = "PageInfo";
            this.pageInfoPageNoOfTotal.StylePriority.UseForeColor = false;
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
            this.PageHeaderSub1,
            this.SubBand1});
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
            this.xrLabel3,
            this.xrLabel2});
            this.PageHeaderSub1.Name = "PageHeaderSub1";
            // 
            // xrLabel3
            // 
            this.xrLabel3.CanPublishOptions.Xls = false;
            this.xrLabel3.CanPublishOptions.Xlsx = false;
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "!IsNullOrEmpty(?LineType)")});
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.CanPublishOptions.Xls = false;
            this.xrLabel2.CanPublishOptions.Xlsx = false;
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // SubBand1
            // 
            this.SubBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable7,
            this.xrTable8,
            this.xrTable9,
            this.xrTable10,
            this.xrTable11,
            this.xrTable6,
            this.xrTable5,
            this.xrTable4,
            this.xrTable3,
            this.xrTable2,
            this.xrTable1});
            this.SubBand1.Name = "SubBand1";
            // 
            // xrTable7
            // 
            this.xrTable7.CanPublishOptions.Xls = false;
            this.xrTable7.CanPublishOptions.Xlsx = false;
            this.xrTable7.Name = "xrTable7";
            this.xrTable7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrTable7.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow7});
            this.xrTable7.StylePriority.UseTextAlignment = false;
            this.xrTable7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell13,
            this.xrTableCell14});
            this.xrTableRow7.Name = "xrTableRow7";
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.Multiline = true;
            this.xrTableCell13.Name = "xrTableCell13";
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[StartFemaleBirds]")});
            this.xrTableCell14.Multiline = true;
            this.xrTableCell14.Name = "xrTableCell14";
            // 
            // xrTable8
            // 
            this.xrTable8.CanPublishOptions.Xls = false;
            this.xrTable8.CanPublishOptions.Xlsx = false;
            this.xrTable8.Name = "xrTable8";
            this.xrTable8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrTable8.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow8});
            this.xrTable8.StylePriority.UseTextAlignment = false;
            this.xrTable8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell15,
            this.xrTableCell16});
            this.xrTableRow8.Name = "xrTableRow8";
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.Multiline = true;
            this.xrTableCell15.Name = "xrTableCell15";
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[StartMaleBirds]")});
            this.xrTableCell16.Multiline = true;
            this.xrTableCell16.Name = "xrTableCell16";
            // 
            // xrTable9
            // 
            this.xrTable9.CanPublishOptions.Xls = false;
            this.xrTable9.CanPublishOptions.Xlsx = false;
            this.xrTable9.Name = "xrTable9";
            this.xrTable9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrTable9.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow9});
            this.xrTable9.StylePriority.UseTextAlignment = false;
            this.xrTable9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell17,
            this.xrTableCell18});
            this.xrTableRow9.Name = "xrTableRow9";
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.Multiline = true;
            this.xrTableCell17.Name = "xrTableCell17";
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.Multiline = true;
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.Scripts.OnBeforePrint = "xrTableCell18_BeforePrint";
            // 
            // xrTable10
            // 
            this.xrTable10.CanPublishOptions.Xls = false;
            this.xrTable10.CanPublishOptions.Xlsx = false;
            this.xrTable10.Name = "xrTable10";
            this.xrTable10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrTable10.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow10});
            this.xrTable10.StylePriority.UseTextAlignment = false;
            this.xrTable10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell19,
            this.xrTableCell20});
            this.xrTableRow10.Name = "xrTableRow10";
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.Multiline = true;
            this.xrTableCell19.Name = "xrTableCell19";
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HatchDate]")});
            this.xrTableCell20.Multiline = true;
            this.xrTableCell20.Name = "xrTableCell20";
            // 
            // xrTable11
            // 
            this.xrTable11.CanPublishOptions.Xls = false;
            this.xrTable11.CanPublishOptions.Xlsx = false;
            this.xrTable11.Name = "xrTable11";
            this.xrTable11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrTable11.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow11});
            this.xrTable11.StylePriority.UseTextAlignment = false;
            this.xrTable11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell21,
            this.xrTableCell22});
            this.xrTableRow11.Name = "xrTableRow11";
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.Multiline = true;
            this.xrTableCell21.Name = "xrTableCell21";
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ArrivalDate]")});
            this.xrTableCell22.Multiline = true;
            this.xrTableCell22.Name = "xrTableCell22";
            // 
            // xrTable6
            // 
            this.xrTable6.CanPublishOptions.Xls = false;
            this.xrTable6.CanPublishOptions.Xlsx = false;
            this.xrTable6.Name = "xrTable6";
            this.xrTable6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6});
            this.xrTable6.StylePriority.UseTextAlignment = false;
            this.xrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell11,
            this.xrTableCell12});
            this.xrTableRow6.Name = "xrTableRow6";
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Multiline = true;
            this.xrTableCell11.Name = "xrTableCell11";
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[PlaceDate_Flk]")});
            this.xrTableCell12.Multiline = true;
            this.xrTableCell12.Name = "xrTableCell12";
            // 
            // xrTable5
            // 
            this.xrTable5.CanPublishOptions.Xls = false;
            this.xrTable5.CanPublishOptions.Xlsx = false;
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5});
            this.xrTable5.StylePriority.UseTextAlignment = false;
            this.xrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell9,
            this.xrTableCell10});
            this.xrTableRow5.Name = "xrTableRow5";
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Multiline = true;
            this.xrTableCell9.Name = "xrTableCell9";
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[RearFarmCode]")});
            this.xrTableCell10.Multiline = true;
            this.xrTableCell10.Name = "xrTableCell10";
            // 
            // xrTable4
            // 
            this.xrTable4.CanPublishOptions.Xls = false;
            this.xrTable4.CanPublishOptions.Xlsx = false;
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
            this.xrTable4.StylePriority.UseTextAlignment = false;
            this.xrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.xrTableCell8});
            this.xrTableRow4.Name = "xrTableRow4";
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HousesNo]")});
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            // 
            // xrTable3
            // 
            this.xrTable3.CanPublishOptions.Xls = false;
            this.xrTable3.CanPublishOptions.Xlsx = false;
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable3.StylePriority.UseTextAlignment = false;
            this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell5,
            this.xrTableCell6});
            this.xrTableRow3.Name = "xrTableRow3";
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Breed]")});
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            // 
            // xrTable2
            // 
            this.xrTable2.CanPublishOptions.Xls = false;
            this.xrTable2.CanPublishOptions.Xlsx = false;
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell3,
            this.xrTableCell4});
            this.xrTableRow2.Name = "xrTableRow2";
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FlockCode]")});
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            // 
            // xrTable1
            // 
            this.xrTable1.CanPublishOptions.Xls = false;
            this.xrTable1.CanPublishOptions.Xlsx = false;
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2});
            this.xrTableRow1.Name = "xrTableRow1";
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FarmCode]")});
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
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
            this.crossTabHeaderCell8,
            this.crossTabTotalCell4,
            this.crossTabTotalCell5,
            this.crossTabHeaderCell9,
            this.crossTabHeaderCell10,
            this.crossTabHeaderCell11,
            this.crossTabTotalCell6,
            this.crossTabTotalCell7});
            crossTabColumnDefinition1.Visible = false;
            this.xrCrossTab1.ColumnDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition[] {
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(102.0833F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(61.45831F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(69.79163F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(92.73424F),
            crossTabColumnDefinition1});
            crossTabColumnField1.FieldName = "ColSeq";
            this.xrCrossTab1.ColumnFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField[] {
            crossTabColumnField1});
            this.xrCrossTab1.DataAreaStyleName = "crossTabDataStyle1";
            crossTabDataField1.FieldName = "ColValue";
            this.xrCrossTab1.DataFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField[] {
            crossTabDataField1});
            this.xrCrossTab1.GeneralStyleName = "crossTabGeneralStyle1";
            this.xrCrossTab1.HeaderAreaStyleName = "crossTabHeaderStyle1";
            this.xrCrossTab1.Name = "xrCrossTab1";
            this.xrCrossTab1.Parameters.AddRange(new DevExpress.XtraReports.UI.XRControlParameter[] {
            new DevExpress.XtraReports.UI.XRControlParameter("IsRTL", this.IsRTL)});
            crossTabRowDefinition1.Visible = false;
            crossTabRowDefinition2.Visible = false;
            crossTabRowDefinition3.Visible = false;
            this.xrCrossTab1.RowDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition[] {
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
            crossTabRowDefinition1,
            crossTabRowDefinition2,
            crossTabRowDefinition3});
            crossTabRowField1.FieldName = "DateWeekEnd";
            crossTabRowField1.SortOrder = DevExpress.XtraReports.UI.XRColumnSortOrder.None;
            crossTabRowField2.FieldName = "rf_WeeKNo";
            crossTabRowField3.FieldName = "rf_ProdWeeKNo";
            this.xrCrossTab1.RowFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField[] {
            crossTabRowField1,
            crossTabRowField2,
            crossTabRowField3});
            this.xrCrossTab1.TotalAreaStyleName = "crossTabTotalStyle1";
            // 
            // crossTabHeaderCell1
            // 
            this.crossTabHeaderCell1.BackColor = System.Drawing.Color.White;
            this.crossTabHeaderCell1.BorderColor = System.Drawing.Color.DarkGray;
            this.crossTabHeaderCell1.BorderWidth = 1.4F;
            this.crossTabHeaderCell1.ColumnIndex = 0;
            this.crossTabHeaderCell1.Name = "crossTabHeaderCell1";
            this.crossTabHeaderCell1.RowIndex = 0;
            this.crossTabHeaderCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabDataCell1
            // 
            this.crossTabDataCell1.BorderColor = System.Drawing.Color.DarkGray;
            this.crossTabDataCell1.BorderWidth = 1.4F;
            this.crossTabDataCell1.ColumnIndex = 3;
            this.crossTabDataCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n")});
            this.crossTabDataCell1.Name = "crossTabDataCell1";
            this.crossTabDataCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(4F, 4F, 0F, 0F, 100F);
            this.crossTabDataCell1.RowIndex = 1;
            this.crossTabDataCell1.Scripts.OnBeforePrint = "crossTabDataCell1_BeforePrint";
            this.crossTabDataCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // crossTabHeaderCell2
            // 
            this.crossTabHeaderCell2.BackColor = System.Drawing.Color.White;
            this.crossTabHeaderCell2.BorderColor = System.Drawing.Color.DarkGray;
            this.crossTabHeaderCell2.BorderWidth = 1.4F;
            this.crossTabHeaderCell2.ColumnIndex = 3;
            this.crossTabHeaderCell2.Name = "crossTabHeaderCell2";
            this.crossTabHeaderCell2.RowIndex = 0;
            this.crossTabHeaderCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabHeaderCell3
            // 
            this.crossTabHeaderCell3.BackColor = System.Drawing.Color.White;
            this.crossTabHeaderCell3.BorderColor = System.Drawing.Color.DarkGray;
            this.crossTabHeaderCell3.BorderWidth = 1.4F;
            this.crossTabHeaderCell3.ColumnIndex = 0;
            this.crossTabHeaderCell3.Name = "crossTabHeaderCell3";
            this.crossTabHeaderCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5F, 5F, 0F, 0F, 100F);
            this.crossTabHeaderCell3.RowIndex = 1;
            this.crossTabHeaderCell3.RowSpan = 2;
            this.crossTabHeaderCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabHeaderCell4
            // 
            this.crossTabHeaderCell4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.crossTabHeaderCell4.BorderColor = System.Drawing.Color.DarkGray;
            this.crossTabHeaderCell4.BorderWidth = 1.4F;
            this.crossTabHeaderCell4.ColumnIndex = 4;
            this.crossTabHeaderCell4.Name = "crossTabHeaderCell4";
            this.crossTabHeaderCell4.RowIndex = 0;
            this.crossTabHeaderCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabTotalCell1
            // 
            this.crossTabTotalCell1.BorderColor = System.Drawing.Color.DarkGray;
            this.crossTabTotalCell1.BorderWidth = 1.4F;
            this.crossTabTotalCell1.ColumnIndex = 4;
            this.crossTabTotalCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n")});
            this.crossTabTotalCell1.Name = "crossTabTotalCell1";
            this.crossTabTotalCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(4F, 4F, 0F, 0F, 100F);
            this.crossTabTotalCell1.RowIndex = 1;
            this.crossTabTotalCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // crossTabHeaderCell5
            // 
            this.crossTabHeaderCell5.ColumnIndex = 0;
            this.crossTabHeaderCell5.ColumnSpan = 3;
            this.crossTabHeaderCell5.Name = "crossTabHeaderCell5";
            this.crossTabHeaderCell5.RowIndex = 4;
            // 
            // crossTabTotalCell2
            // 
            this.crossTabTotalCell2.ColumnIndex = 3;
            this.crossTabTotalCell2.Name = "crossTabTotalCell2";
            this.crossTabTotalCell2.RowIndex = 4;
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
            this.crossTabHeaderCell6.ColumnIndex = 1;
            this.crossTabHeaderCell6.Name = "crossTabHeaderCell6";
            this.crossTabHeaderCell6.RowIndex = 0;
            this.crossTabHeaderCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabHeaderCell7
            // 
            this.crossTabHeaderCell7.BackColor = System.Drawing.Color.White;
            this.crossTabHeaderCell7.ColumnIndex = 1;
            this.crossTabHeaderCell7.Name = "crossTabHeaderCell7";
            this.crossTabHeaderCell7.RowIndex = 1;
            this.crossTabHeaderCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabHeaderCell8
            // 
            this.crossTabHeaderCell8.ColumnIndex = 0;
            this.crossTabHeaderCell8.ColumnSpan = 3;
            this.crossTabHeaderCell8.Name = "crossTabHeaderCell8";
            this.crossTabHeaderCell8.RowIndex = 3;
            // 
            // crossTabTotalCell4
            // 
            this.crossTabTotalCell4.ColumnIndex = 3;
            this.crossTabTotalCell4.Name = "crossTabTotalCell4";
            this.crossTabTotalCell4.RowIndex = 3;
            // 
            // crossTabTotalCell5
            // 
            this.crossTabTotalCell5.ColumnIndex = 4;
            this.crossTabTotalCell5.Name = "crossTabTotalCell5";
            this.crossTabTotalCell5.RowIndex = 3;
            // 
            // crossTabHeaderCell9
            // 
            this.crossTabHeaderCell9.BackColor = System.Drawing.Color.White;
            this.crossTabHeaderCell9.ColumnIndex = 2;
            this.crossTabHeaderCell9.Name = "crossTabHeaderCell9";
            this.crossTabHeaderCell9.RowIndex = 0;
            this.crossTabHeaderCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabHeaderCell10
            // 
            this.crossTabHeaderCell10.BackColor = System.Drawing.Color.White;
            this.crossTabHeaderCell10.ColumnIndex = 2;
            this.crossTabHeaderCell10.Name = "crossTabHeaderCell10";
            this.crossTabHeaderCell10.RowIndex = 1;
            this.crossTabHeaderCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabHeaderCell11
            // 
            this.crossTabHeaderCell11.BackColor = System.Drawing.Color.White;
            this.crossTabHeaderCell11.ColumnIndex = 1;
            this.crossTabHeaderCell11.ColumnSpan = 2;
            this.crossTabHeaderCell11.Name = "crossTabHeaderCell11";
            this.crossTabHeaderCell11.RowIndex = 2;
            // 
            // crossTabTotalCell6
            // 
            this.crossTabTotalCell6.ColumnIndex = 3;
            this.crossTabTotalCell6.Name = "crossTabTotalCell6";
            this.crossTabTotalCell6.RowIndex = 2;
            // 
            // crossTabTotalCell7
            // 
            this.crossTabTotalCell7.ColumnIndex = 4;
            this.crossTabTotalCell7.Name = "crossTabTotalCell7";
            this.crossTabTotalCell7.RowIndex = 2;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "dsBreeder";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "RearFarmCode";
            table1.Name = "SR_BRD_PeriodResultOfEggsWeight";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "FlockCode";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "HatchDate";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "ArrivalDate";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "StartFemaleBirds";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "StartMaleBirds";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "DateWeekEnd";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "rf_WeeKNo";
            columnExpression8.Table = table1;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "rf_ProdWeeKNo";
            columnExpression9.Table = table1;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "ColSeq";
            columnExpression10.Table = table1;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "HouseCode";
            columnExpression11.Table = table1;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "ColValue";
            columnExpression12.Table = table1;
            column12.Expression = columnExpression12;
            columnExpression13.ColumnName = "Breed";
            columnExpression13.Table = table1;
            column13.Expression = columnExpression13;
            columnExpression14.ColumnName = "FarmCode";
            columnExpression14.Table = table1;
            column14.Expression = columnExpression14;
            columnExpression15.ColumnName = "HousesNo";
            columnExpression15.Table = table1;
            column15.Expression = columnExpression15;
            columnExpression16.ColumnName = "PlaceDate_Flk";
            columnExpression16.Table = table1;
            column16.Expression = columnExpression16;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Columns.Add(column8);
            selectQuery1.Columns.Add(column9);
            selectQuery1.Columns.Add(column10);
            selectQuery1.Columns.Add(column11);
            selectQuery1.Columns.Add(column12);
            selectQuery1.Columns.Add(column13);
            selectQuery1.Columns.Add(column14);
            selectQuery1.Columns.Add(column15);
            selectQuery1.Columns.Add(column16);
            selectQuery1.Name = "SR_BRD_PeriodResultOfEggsWeight";
            selectQuery1.Tables.Add(table1);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // IsRTL
            // 
            this.IsRTL.Name = "IsRTL";
            this.IsRTL.Type = typeof(bool);
            this.IsRTL.ValueInfo = "False";
            this.IsRTL.Visible = false;
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
            // CopyRight
            // 
            this.CopyRight.DataMember = "SR_FM_RationResult";
            this.CopyRight.Expression = "Iif(?IsRTL, \'حقوق النسخ 2003-2025 فيت سوفت - جميع الحقوق محفوظة\', \'Copyright @ 20" +
    "03-2025 VetSoft Office, All rights reserved\')\n";
            this.CopyRight.Name = "CopyRight";
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
            // Farm
            // 
            this.Farm.Name = "Farm";
            this.Farm.Visible = false;
            // 
            // SheetNo
            // 
            this.SheetNo.Name = "SheetNo";
            this.SheetNo.Type = typeof(int);
            this.SheetNo.ValueInfo = "0";
            this.SheetNo.Visible = false;
            // 
            // DateTo
            // 
            this.DateTo.Name = "DateTo";
            this.DateTo.Visible = false;
            // 
            // BookPerf
            // 
            this.BookPerf.Name = "BookPerf";
            this.BookPerf.Visible = false;
            // 
            // Flock
            // 
            this.Flock.Name = "Flock";
            this.Flock.Visible = false;
            // 
            // CropNo
            // 
            this.CropNo.Name = "CropNo";
            this.CropNo.Visible = false;
            // 
            // Breed
            // 
            this.Breed.Name = "Breed";
            this.Breed.Visible = false;
            // 
            // dsBreeder
            // 
            this.dsBreeder.ConnectionName = "dsBreeder";
            this.dsBreeder.Name = "dsBreeder";
            columnExpression17.ColumnName = "RowSeq";
            table2.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"283\" />";
            table2.Name = "SR_BRD_DailyDataFlkWise";
            columnExpression17.Table = table2;
            column17.Expression = columnExpression17;
            columnExpression18.ColumnName = "RowData";
            columnExpression18.Table = table2;
            column18.Expression = columnExpression18;
            columnExpression19.ColumnName = "ColSeq1";
            columnExpression19.Table = table2;
            column19.Expression = columnExpression19;
            columnExpression20.ColumnName = "ColData1";
            columnExpression20.Table = table2;
            column20.Expression = columnExpression20;
            columnExpression21.ColumnName = "ColSeq2";
            columnExpression21.Table = table2;
            column21.Expression = columnExpression21;
            columnExpression22.ColumnName = "ColData2";
            columnExpression22.Table = table2;
            column22.Expression = columnExpression22;
            columnExpression23.ColumnName = "ColSeq3";
            columnExpression23.Table = table2;
            column23.Expression = columnExpression23;
            columnExpression24.ColumnName = "ColData3";
            columnExpression24.Table = table2;
            column24.Expression = columnExpression24;
            columnExpression25.ColumnName = "ColSeq4";
            columnExpression25.Table = table2;
            column25.Expression = columnExpression25;
            columnExpression26.ColumnName = "ColData4";
            columnExpression26.Table = table2;
            column26.Expression = columnExpression26;
            columnExpression27.ColumnName = "DataValue";
            columnExpression27.Table = table2;
            column27.Expression = columnExpression27;
            selectQuery2.Columns.Add(column17);
            selectQuery2.Columns.Add(column18);
            selectQuery2.Columns.Add(column19);
            selectQuery2.Columns.Add(column20);
            selectQuery2.Columns.Add(column21);
            selectQuery2.Columns.Add(column22);
            selectQuery2.Columns.Add(column23);
            selectQuery2.Columns.Add(column24);
            selectQuery2.Columns.Add(column25);
            selectQuery2.Columns.Add(column26);
            selectQuery2.Columns.Add(column27);
            selectQuery2.Name = "Query";
            selectQuery2.Tables.Add(table2);
            this.dsBreeder.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery2});
            this.dsBreeder.ResultSchemaSerializable = resources.GetString("dsBreeder.ResultSchemaSerializable");
            // 
            // LineType
            // 
            this.LineType.Name = "LineType";
            this.LineType.Visible = false;
            // 
            // SR_BRD_PeriodResultOfEggsWeight
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
            this.Rejected,
            this.CopyRight});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dsBreeder,
            this.sqlDataSource1});
            this.DataMember = "SR_BRD_PeriodResultOfEggsWeight";
            this.DataSource = this.sqlDataSource1;
            this.ExportOptions.Pdf.DocumentOptions.Author = "VetSoft";
            this.Landscape = true;
            this.LocalizationItems.AddRange(new DevExpress.XtraReports.Localization.LocalizationItem[] {
            new DevExpress.XtraReports.Localization.LocalizationItem(this.BookPerf, "Default", "Description", "BookPerf"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.BottomMargin, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.Breed, "Default", "Description", "Breed"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.CropNo, "Default", "Description", "CropNo"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabDataCell1, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabDataCell1, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell1, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell1, "Default", "Text", " End week"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell1, "ar", "Text", "تاريخ نهاية الاسبوع"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell10, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell11, "Default", "TextFormatString", "Total {0}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell2, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell3, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell3, "Default", "TextFormatString", "{0:dd/MM/yyyy}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell4, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell4, "Default", "Text", " Total"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell4, "ar", "Text", "الاجمالي"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell5, "Default", "Text", "Grand Total"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell6, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell6, "Default", "Text", "Age"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell6, "ar", "Text", "العمر"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell7, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell8, "Default", "TextFormatString", "Total {0}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell9, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 7F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell9, "Default", "Text", "Prod"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell9, "ar", "Text", "اسبوع انتاجي"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabTotalCell1, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabTotalCell1, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateFrom, "Default", "Description", "From"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateFrom, "ar", "Description", "من"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateTo, "Default", "Description", "DateTo"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.Detail, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.Farm, "Default", "Description", "Farm"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.Flock, "Default", "Description", "Flock"),
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
            new DevExpress.XtraReports.Localization.LocalizationItem(this.LineType, "Default", "Description", "LineType"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.NoOfGroupsPerPage, "Default", "Description", "No of groups / page"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.NoOfGroupsPerPage, "ar", "Description", "عدد المجموعات / صفحة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageFooter, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeader, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeaderSub1, "Default", "HeightF", 23F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentDate, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentDate, "Default", "SizeF", new System.Drawing.SizeF(326.0675F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentTime, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(353.5F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentTime, "Default", "SizeF", new System.Drawing.SizeF(929.7717F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoCurrentTime, "Default", "TextFormatString", "{0:HH:mm:ss}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoPageNoOfTotal, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(1316.333F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoPageNoOfTotal, "Default", "SizeF", new System.Drawing.SizeF(320.4355F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.pageInfoPageNoOfTotal, "Default", "TextFormatString", "Page {0} of {1}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooter, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooterSub1, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooterSub2, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SheetNo, "Default", "Description", "SheetNo"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignature, "Default", "Description", "Show signature"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignature, "ar", "Description", "عرض التوقيع"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignatureAllPages, "Default", "Description", "Show signature in all page"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignatureAllPages, "ar", "Description", "عرض التوقيع في كل الصفحات"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportFooterCustom, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportFooterCustom, "Default", "SizeF", new System.Drawing.SizeF(1636.543F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportHeader, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(3.003343F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportHeader, "Default", "SizeF", new System.Drawing.SizeF(1633.765F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportHeaderCustom, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportHeaderCustom, "Default", "SizeF", new System.Drawing.SizeF(1636.544F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportNotes, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportNotes, "Default", "SizeF", new System.Drawing.SizeF(1636.769F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature, "Default", "SizeF", new System.Drawing.SizeF(1636.769F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature_PageFooter, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(2.000046F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.srReportSignature_PageFooter, "Default", "SizeF", new System.Drawing.SizeF(1634.543F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "ar", "DisplayName", "قيود يومية تفصيلي"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Margins", new DevExpress.Drawing.DXMargins(7F, 10F, 20F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "PaperKind", DevExpress.Drawing.Printing.DXPaperKind.A3),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand1, "Default", "HeightF", 158.6667F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand2, "Default", "HeightF", 162.125F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand3, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand5, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand6, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SubBand7, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.TopMargin, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCrossTab1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 21.16667F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCrossTab1, "Default", "SizeF", new System.Drawing.SizeF(328.0675F, 56F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "Default", "SizeF", new System.Drawing.SizeF(250F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "Default", "Text", "Std Book: [?BookPerf]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel2, "ar", "Text", "المرجع: [?BookPerf]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(273.1667F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "Default", "SizeF", new System.Drawing.SizeF(234.375F, 23F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "Default", "Text", "Line Type: [?LineType]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrLabel3, "ar", "Text", "خط الانتاج: [?LineType]"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable1, "Default", "SizeF", new System.Drawing.SizeF(200F, 25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable10, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(422.5F, 74.99997F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable10, "Default", "SizeF", new System.Drawing.SizeF(200F, 25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable11, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(422.5F, 99.99997F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable11, "Default", "SizeF", new System.Drawing.SizeF(200F, 25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable2, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable2, "Default", "SizeF", new System.Drawing.SizeF(200F, 25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable3, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 50F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable3, "Default", "SizeF", new System.Drawing.SizeF(200F, 25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable4, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 75F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable4, "Default", "SizeF", new System.Drawing.SizeF(200F, 25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable5, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 100F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable5, "Default", "SizeF", new System.Drawing.SizeF(200F, 25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable6, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(0F, 125F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable6, "Default", "SizeF", new System.Drawing.SizeF(200F, 25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable7, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(422.5F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable7, "Default", "SizeF", new System.Drawing.SizeF(200F, 25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable8, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(422.5F, 24.99997F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable8, "Default", "SizeF", new System.Drawing.SizeF(200F, 25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable9, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(422.5F, 49.99997F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTable9, "Default", "SizeF", new System.Drawing.SizeF(200F, 25F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell1, "Default", "Text", "Farm Code"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell1, "ar", "Text", "مزرعة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell1, "Default", "Weight", 1.125D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell10, "Default", "Text", "xrTableCell2"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell10, "Default", "Weight", 0.875D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell11, "Default", "Text", "Flock Place Date"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell11, "ar", "Text", "تاريخ تسكين القطيع"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell11, "Default", "Weight", 1.125D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell12, "Default", "Text", "xrTableCell2"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell12, "Default", "TextFormatString", "{0:dd/MM/yyyy}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell12, "Default", "Weight", 0.875D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell13, "Default", "Text", "No of Female"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell13, "ar", "Text", "عدد الاناث"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell13, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell14, "Default", "Text", "xrTableCell2"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell14, "Default", "TextFormatString", "{0:N0}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell14, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell15, "Default", "Text", "No of Male"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell15, "ar", "Text", "عدد الذكور"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell15, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell16, "Default", "Text", "xrTableCell2"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell16, "Default", "TextFormatString", "{0:N0}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell16, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell17, "Default", "Text", "Sex Ratio"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell17, "ar", "Text", "نسبة الذكور"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell17, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell18, "Default", "Text", ""),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell18, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell19, "Default", "Text", "Hatch Date"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell19, "ar", "Text", "تاريخ الفقس"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell19, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell2, "Default", "Text", "xrTableCell2"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell2, "Default", "Weight", 0.875D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell20, "Default", "Text", "xrTableCell2"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell20, "Default", "TextFormatString", "{0:dd/MM/yyyy}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell20, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell21, "Default", "Text", "Arrival Date"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell21, "ar", "Text", "تاريخ الوصول"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell21, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell22, "Default", "Text", "xrTableCell2"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell22, "Default", "TextFormatString", "{0:dd/MM/yyyy}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell22, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell3, "Default", "Text", "Flock Code"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell3, "ar", "Text", "قطيع"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell3, "Default", "Weight", 1.125D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell4, "Default", "Text", "xrTableCell2"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell4, "Default", "Weight", 0.875D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell5, "Default", "Text", "Breed"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell5, "ar", "Text", "سلالة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell5, "Default", "Weight", 1.125D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell6, "Default", "Text", "xrTableCell2"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell6, "Default", "Weight", 0.875D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell7, "Default", "Text", "No. Of Houses"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell7, "ar", "Text", "عدد العنابر"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell7, "Default", "Weight", 1.125D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell8, "Default", "Text", "xrTableCell2"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell8, "Default", "Weight", 0.875D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell9, "Default", "Text", "Rear Farm Code"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell9, "ar", "Text", "مزرعة التربية"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableCell9, "Default", "Weight", 1.125D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow1, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow10, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow11, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow2, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow3, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow4, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow5, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow6, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow7, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow8, "Default", "Weight", 1D),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrTableRow9, "Default", "Weight", 1D)});
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
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.NoOfGroupsPerPage, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.FontSize, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.DateFrom, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.Farm, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.SheetNo, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.DateTo, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.BookPerf, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.Flock, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.CropNo, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.Breed, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.LineType, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
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
            this.Farm,
            this.SheetNo,
            this.DateTo,
            this.BookPerf,
            this.Flock,
            this.CropNo,
            this.Breed,
            this.LineType});
            this.ScriptReferencesString = "E:\\VetSoft Projects .Net2024\\VetSoft Projects\\VetSoftDevExpress\\bin\\Release\\net8." +
    "0\\VetSoftDevExpress.dll";
            this.ScriptsSource = resources.GetString("$this.ScriptsSource");
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailData3_Odd,
            this.PageInfo,
            this.crossTabGeneralStyle1,
            this.crossTabHeaderStyle1,
            this.crossTabDataStyle1,
            this.crossTabTotalStyle1});
            this.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.Version = "25.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrCrossTab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        private XRLabel xrLabel3;
        private XRLabel xrLabel2;
        private XRTable xrTable7;
        private XRTableRow xrTableRow7;
        private XRTableCell xrTableCell13;
        private XRTableCell xrTableCell14;
        private XRTable xrTable8;
        private XRTableRow xrTableRow8;
        private XRTableCell xrTableCell15;
        private XRTableCell xrTableCell16;
        private XRTable xrTable9;
        private XRTableRow xrTableRow9;
        private XRTableCell xrTableCell17;
        private XRTableCell xrTableCell18;
        private XRTable xrTable10;
        private XRTableRow xrTableRow10;
        private XRTableCell xrTableCell19;
        private XRTableCell xrTableCell20;
        private XRTable xrTable11;
        private XRTableRow xrTableRow11;
        private XRTableCell xrTableCell21;
        private XRTableCell xrTableCell22;
        private XRTable xrTable6;
        private XRTableRow xrTableRow6;
        private XRTableCell xrTableCell11;
        private XRTableCell xrTableCell12;
        private XRTable xrTable5;
        private XRTableRow xrTableRow5;
        private XRTableCell xrTableCell9;
        private XRTableCell xrTableCell10;
        private XRTable xrTable4;
        private XRTableRow xrTableRow4;
        private XRTableCell xrTableCell7;
        private XRTableCell xrTableCell8;
        private XRTable xrTable3;
        private XRTableRow xrTableRow3;
        private XRTableCell xrTableCell5;
        private XRTableCell xrTableCell6;
        private XRTable xrTable2;
        private XRTableRow xrTableRow2;
        private XRTableCell xrTableCell3;
        private XRTableCell xrTableCell4;
        private XRTable xrTable1;
        private XRTableRow xrTableRow1;
        private XRTableCell xrTableCell1;
        private XRTableCell xrTableCell2;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.Parameters.Parameter LineType;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell6;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell7;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell8;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell4;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell5;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell9;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell10;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell11;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell6;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell7;
    }
}
