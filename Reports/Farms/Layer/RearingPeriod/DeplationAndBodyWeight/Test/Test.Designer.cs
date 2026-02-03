using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;

namespace DevExpressReports.Reports.Farms.Layer.RearingPeriod.DeplationAndBodyWeight.Test
{
    partial class Test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Main Band Properties
        public ReportHeaderBand Area1 { get; private set; }
        public DetailBand Area3 { get; private set; }
        public GroupHeaderBand GroupHeaderArea1 { get; private set; }
        public GroupFooterBand GroupFooterArea1 { get; private set; }
        public PageHeaderBand Area2 { get; private set; }
        public ReportFooterBand Area4 { get; private set; }
        public PageFooterBand Area5 { get; private set; }

        // SubBand Properties
        public SubBand GroupFooterSection1 { get; private set; }
        public SubBand GroupFooterSection3 { get; private set; }
        public SubBand GroupFooterSection4 { get; private set; }
        public SubBand PageHeaderSection2 { get; private set; }
        public SubBand Section2 { get; private set; }
        public SubBand Section4 { get; private set; }
        public SubBand ReportFooterSection2 { get; private set; }
        public SubBand ReportFooterSection4 { get; private set; }
        public SubBand ReportFooterSection3 { get; private set; }
        public SubBand SignatureReportFooterSection { get; private set; }
        public SubBand SignaturePageFooterSection { get; private set; }
        public SubBand Section5 { get; private set; }

        // XRControl Properties (labels, lines, etc.)
        public XRLabel HouseCode1 { get; private set; }
        public XRLabel BreedNameen1 { get; private set; }
        public XRLabel rfFemaleStarted1 { get; private set; }
        public XRLabel rfWeeKNo1 { get; private set; }
        public XRLabel rfPlaceDate1 { get; private set; }
        public XRLabel DailyMort1 { get; private set; }
        public XRLabel MortStand1 { get; private set; }
        public XRLabel CummMort1 { get; private set; }
        public XRLabel CummMortStand1 { get; private set; }
        public XRLabel DailCulls1 { get; private set; }
        public XRLabel CullsStand1 { get; private set; }
        public XRLabel CummCulls1 { get; private set; }
        public XRLabel CummCullsStand1 { get; private set; }
        public XRLabel BalanceBirds1 { get; private set; }
        public XRLabel rsFABW1 { get; private set; }
        public XRLabel BWStand1 { get; private set; }
        public XRLabel LightHours1 { get; private set; }
        public XRLabel LightStand1 { get; private set; }
        public XRLabel FeedIntake1 { get; private set; }
        public XRLabel FeedStand1 { get; private set; }
        public XRLabel MortPercent_2 { get; private set; }
        public XRLabel CummMortPercent_1 { get; private set; }
        public XRLabel CullsPercent_2 { get; private set; }
        public XRLabel CummCullsPercent_1 { get; private set; }
        public XRLabel Depletion_1 { get; private set; }
        public XRLabel DepletionPercent_2 { get; private set; }
        public XRLine Line2 { get; private set; }
        public XRLine Line22 { get; private set; }
        public XRLine Line23 { get; private set; }
        public XRLabel FlockCode1 { get; private set; }
        public XRLabel GroupNameFarmCode1 { get; private set; }
        public XRLabel StdFeedIntake { get; private set; }
        public XRLabel ActFeedIntake { get; private set; }
        public XRLabel HouseNo { get; private set; }
        public XRLabel Breed { get; private set; }
        public XRLabel BirdsPlaced { get; private set; }
        public XRLabel Ageweek { get; private set; }
        public XRLabel DatePlaced { get; private set; }
        public XRLabel Mort { get; private set; }
        public XRLabel MortStdPercent { get; private set; }
        public XRLabel CumMort { get; private set; }
        public XRLabel CumMortStd { get; private set; }
        public XRLabel Culls { get; private set; }
        public XRLabel CullsStdPercent { get; private set; }
        public XRLabel CumCulls { get; private set; }
        public XRLabel CummCullsStd { get; private set; }
        public XRLabel BalanceBirds { get; private set; }
        public XRLabel Weight { get; private set; }
        public XRLabel WeightStd { get; private set; }
        public XRLabel ActualLightHrs { get; private set; }
        public XRLabel StdLightHrs { get; private set; }
        public XRLabel MortPercent_1 { get; private set; }
        public XRLabel CumMortPercent { get; private set; }
        public XRLabel CullsPercent_1 { get; private set; }
        public XRLabel CumCullsPercent { get; private set; }
        public XRLabel TotDepletion { get; private set; }
        public XRLabel DepletionPercent_1 { get; private set; }
        public XRLabel CropNo1 { get; private set; }
        public XRLabel Crop { get; private set; }
        public XRLine Line9 { get; private set; }
        public XRLine Line1 { get; private set; }
        public XRLine Line5 { get; private set; }
        public XRLine Line6 { get; private set; }
        public XRLine Line8 { get; private set; }
        public XRLabel FlockNo { get; private set; }
        public XRLabel SumofrfFemaleStarted3 { get; private set; }
        public XRLabel AvgofrfWeeKNo3 { get; private set; }
        public XRLabel SumofDailyMort3 { get; private set; }
        public XRLabel SumofDailCulls3 { get; private set; }
        public XRLabel AvgofMortPercent3 { get; private set; }
        public XRLabel AvgofCullsPercent3 { get; private set; }
        public XRLabel AvgofMortStand3 { get; private set; }
        public XRLabel AvgofCullsStand3 { get; private set; }
        public XRLabel SumofCummMort3 { get; private set; }
        public XRLabel SumofCummCulls3 { get; private set; }
        public XRLabel AvgofCummMortPercent3 { get; private set; }
        public XRLabel AvgofCummMortStand3 { get; private set; }
        public XRLabel AvgofCummCullsPercent3 { get; private set; }
        public XRLabel AvgofCummCullsStand3 { get; private set; }
        public XRLabel SumofDepletion3 { get; private set; }
        public XRLabel AvgofDepletionPercent3 { get; private set; }
        public XRLabel SumofBalanceBirds3 { get; private set; }
        public XRLabel AvgofrsFABW3 { get; private set; }
        public XRLabel TotalAverage { get; private set; }
        public XRLine Line3 { get; private set; }
        public XRLabel GT_AvgBWStd_1 { get; private set; }
        public XRLabel Vaccination { get; private set; }
        public XRSubreport Subreport3 { get; private set; }
        public XRSubreport Subreport4 { get; private set; }
        public XRLabel Medication { get; private set; }
        public XRSubreport Subreport7 { get; private set; }
        public XRLabel Date { get; private set; }
        public XRLabel Datee1 { get; private set; }
        public XRLabel BookPerf_1 { get; private set; }
        public XRLabel BookPerf_2 { get; private set; }
        public XRSubreport Subreport1 { get; private set; }
        public XRSubreport Subreport2 { get; private set; }
        public XRLabel ReportNotes_1 { get; private set; }
        public XRLabel Text5 { get; private set; }
        public XRSubreport Subreport5 { get; private set; }
        public XRSubreport Subreport6 { get; private set; }
        public XRPageInfo PageNofM1 { get; private set; }
        public XRPageInfo PrintTime1 { get; private set; }
        public XRPageInfo PrintDate1 { get; private set; }

        // Cross Band Line Properties
        public XRCrossBandLine Line10 { get; private set; }
        public XRCrossBandLine Line11 { get; private set; }
        public XRCrossBandLine Line12 { get; private set; }
        public XRCrossBandLine Line13 { get; private set; }
        public XRCrossBandLine Line14 { get; private set; }
        public XRCrossBandLine Line15 { get; private set; }
        public XRCrossBandLine Line16 { get; private set; }
        public XRCrossBandLine Line17 { get; private set; }
        public XRCrossBandLine Line18 { get; private set; }
        public XRCrossBandLine Line19 { get; private set; }
        public XRCrossBandLine Line20 { get; private set; }
        public XRCrossBandLine Line21 { get; private set; }
        public XRCrossBandLine Line24 { get; private set; }
        public XRCrossBandLine Line25 { get; private set; }
        public XRCrossBandLine Line26 { get; private set; }
        public XRCrossBandLine Line27 { get; private set; }
        public XRCrossBandLine Line29 { get; private set; }
        public XRCrossBandLine Line30 { get; private set; }
        public XRCrossBandLine Line31 { get; private set; }
        public XRCrossBandLine Line32 { get; private set; }
        public XRCrossBandLine Line33 { get; private set; }
        public XRCrossBandLine Line28 { get; private set; }
        public XRCrossBandLine Line34 { get; private set; }
        public XRCrossBandLine Line35 { get; private set; }
        public XRCrossBandLine Line36 { get; private set; }
        public XRCrossBandLine Line37 { get; private set; }

        // Calculated Field Properties
        public CalculatedField ReportName { get; private set; }
        public CalculatedField MortPercent { get; private set; }
        public CalculatedField CummMortPercent { get; private set; }
        public CalculatedField CullsPercent { get; private set; }
        public CalculatedField CummCullsPercent { get; private set; }
        public CalculatedField Depletion { get; private set; }
        public CalculatedField DepletionPercent { get; private set; }
        public CalculatedField LogoPath { get; private set; }
        public CalculatedField ModuleName_en { get; private set; }
        public CalculatedField CompanyName_en { get; private set; }
        public CalculatedField ReportPQP { get; private set; }
        public CalculatedField ModuleName_ar { get; private set; }
        public CalculatedField CompanyName_ar { get; private set; }
        public CalculatedField BookPerf { get; private set; }
        public CalculatedField ShowSignature { get; private set; }
        public CalculatedField ShowSignatureAllPages { get; private set; }
        public CalculatedField ReportNotes { get; private set; }
        public CalculatedField FilterDataHeader { get; private set; }
        public CalculatedField FilterData { get; private set; }
        public CalculatedField GT_AvgBWStd { get; private set; }

        // Parameter Properties
        public Parameter Datee { get; private set; }


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
            DevExpress.XtraReports.UI.XRSummary xrSummary7 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary8 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary9 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary10 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary11 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary12 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary13 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary14 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary15 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary16 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary17 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary18 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.DataAccess.ConnectionParameters.XmlFileConnectionParameters xmlFileConnectionParameters1 = new DevExpress.DataAccess.ConnectionParameters.XmlFileConnectionParameters();
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
            DevExpress.DataAccess.Sql.Column column17 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression17 = new DevExpress.DataAccess.Sql.ColumnExpression();
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
            DevExpress.DataAccess.Sql.Column column28 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression28 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column29 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression29 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.Area3 = new DevExpress.XtraReports.UI.DetailBand();
            this.GroupHeaderArea1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupFooterArea1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.Area1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.Area2 = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.Area4 = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.Area5 = new DevExpress.XtraReports.UI.PageFooterBand();
            this.HouseCode1 = new DevExpress.XtraReports.UI.XRLabel();
            this.BreedNameen1 = new DevExpress.XtraReports.UI.XRLabel();
            this.rfFemaleStarted1 = new DevExpress.XtraReports.UI.XRLabel();
            this.rfWeeKNo1 = new DevExpress.XtraReports.UI.XRLabel();
            this.rfPlaceDate1 = new DevExpress.XtraReports.UI.XRLabel();
            this.DailyMort1 = new DevExpress.XtraReports.UI.XRLabel();
            this.MortStand1 = new DevExpress.XtraReports.UI.XRLabel();
            this.CummMort1 = new DevExpress.XtraReports.UI.XRLabel();
            this.CummMortStand1 = new DevExpress.XtraReports.UI.XRLabel();
            this.DailCulls1 = new DevExpress.XtraReports.UI.XRLabel();
            this.CullsStand1 = new DevExpress.XtraReports.UI.XRLabel();
            this.CummCulls1 = new DevExpress.XtraReports.UI.XRLabel();
            this.CummCullsStand1 = new DevExpress.XtraReports.UI.XRLabel();
            this.BalanceBirds1 = new DevExpress.XtraReports.UI.XRLabel();
            this.rsFABW1 = new DevExpress.XtraReports.UI.XRLabel();
            this.BWStand1 = new DevExpress.XtraReports.UI.XRLabel();
            this.LightHours1 = new DevExpress.XtraReports.UI.XRLabel();
            this.LightStand1 = new DevExpress.XtraReports.UI.XRLabel();
            this.FeedIntake1 = new DevExpress.XtraReports.UI.XRLabel();
            this.FeedStand1 = new DevExpress.XtraReports.UI.XRLabel();
            this.MortPercent_2 = new DevExpress.XtraReports.UI.XRLabel();
            this.CummMortPercent_1 = new DevExpress.XtraReports.UI.XRLabel();
            this.CullsPercent_2 = new DevExpress.XtraReports.UI.XRLabel();
            this.CummCullsPercent_1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Depletion_1 = new DevExpress.XtraReports.UI.XRLabel();
            this.DepletionPercent_2 = new DevExpress.XtraReports.UI.XRLabel();
            this.Line2 = new DevExpress.XtraReports.UI.XRLine();
            this.Line22 = new DevExpress.XtraReports.UI.XRLine();
            this.Line23 = new DevExpress.XtraReports.UI.XRLine();
            this.FlockCode1 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupNameFarmCode1 = new DevExpress.XtraReports.UI.XRLabel();
            this.StdFeedIntake = new DevExpress.XtraReports.UI.XRLabel();
            this.ActFeedIntake = new DevExpress.XtraReports.UI.XRLabel();
            this.HouseNo = new DevExpress.XtraReports.UI.XRLabel();
            this.Breed = new DevExpress.XtraReports.UI.XRLabel();
            this.BirdsPlaced = new DevExpress.XtraReports.UI.XRLabel();
            this.Ageweek = new DevExpress.XtraReports.UI.XRLabel();
            this.DatePlaced = new DevExpress.XtraReports.UI.XRLabel();
            this.Mort = new DevExpress.XtraReports.UI.XRLabel();
            this.MortStdPercent = new DevExpress.XtraReports.UI.XRLabel();
            this.CumMort = new DevExpress.XtraReports.UI.XRLabel();
            this.CumMortStd = new DevExpress.XtraReports.UI.XRLabel();
            this.Culls = new DevExpress.XtraReports.UI.XRLabel();
            this.CullsStdPercent = new DevExpress.XtraReports.UI.XRLabel();
            this.CumCulls = new DevExpress.XtraReports.UI.XRLabel();
            this.CummCullsStd = new DevExpress.XtraReports.UI.XRLabel();
            this.BalanceBirds = new DevExpress.XtraReports.UI.XRLabel();
            this.Weight = new DevExpress.XtraReports.UI.XRLabel();
            this.WeightStd = new DevExpress.XtraReports.UI.XRLabel();
            this.ActualLightHrs = new DevExpress.XtraReports.UI.XRLabel();
            this.StdLightHrs = new DevExpress.XtraReports.UI.XRLabel();
            this.MortPercent_1 = new DevExpress.XtraReports.UI.XRLabel();
            this.CumMortPercent = new DevExpress.XtraReports.UI.XRLabel();
            this.CullsPercent_1 = new DevExpress.XtraReports.UI.XRLabel();
            this.CumCullsPercent = new DevExpress.XtraReports.UI.XRLabel();
            this.TotDepletion = new DevExpress.XtraReports.UI.XRLabel();
            this.DepletionPercent_1 = new DevExpress.XtraReports.UI.XRLabel();
            this.CropNo1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Crop = new DevExpress.XtraReports.UI.XRLabel();
            this.Line9 = new DevExpress.XtraReports.UI.XRLine();
            this.Line1 = new DevExpress.XtraReports.UI.XRLine();
            this.Line5 = new DevExpress.XtraReports.UI.XRLine();
            this.Line6 = new DevExpress.XtraReports.UI.XRLine();
            this.Line8 = new DevExpress.XtraReports.UI.XRLine();
            this.FlockNo = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupFooterSection1 = new DevExpress.XtraReports.UI.SubBand();
            this.GroupFooterSection3 = new DevExpress.XtraReports.UI.SubBand();
            this.GroupFooterSection4 = new DevExpress.XtraReports.UI.SubBand();
            this.SumofrfFemaleStarted3 = new DevExpress.XtraReports.UI.XRLabel();
            this.AvgofrfWeeKNo3 = new DevExpress.XtraReports.UI.XRLabel();
            this.SumofDailyMort3 = new DevExpress.XtraReports.UI.XRLabel();
            this.SumofDailCulls3 = new DevExpress.XtraReports.UI.XRLabel();
            this.AvgofMortPercent3 = new DevExpress.XtraReports.UI.XRLabel();
            this.AvgofCullsPercent3 = new DevExpress.XtraReports.UI.XRLabel();
            this.AvgofMortStand3 = new DevExpress.XtraReports.UI.XRLabel();
            this.AvgofCullsStand3 = new DevExpress.XtraReports.UI.XRLabel();
            this.SumofCummMort3 = new DevExpress.XtraReports.UI.XRLabel();
            this.SumofCummCulls3 = new DevExpress.XtraReports.UI.XRLabel();
            this.AvgofCummMortPercent3 = new DevExpress.XtraReports.UI.XRLabel();
            this.AvgofCummMortStand3 = new DevExpress.XtraReports.UI.XRLabel();
            this.AvgofCummCullsPercent3 = new DevExpress.XtraReports.UI.XRLabel();
            this.AvgofCummCullsStand3 = new DevExpress.XtraReports.UI.XRLabel();
            this.SumofDepletion3 = new DevExpress.XtraReports.UI.XRLabel();
            this.AvgofDepletionPercent3 = new DevExpress.XtraReports.UI.XRLabel();
            this.SumofBalanceBirds3 = new DevExpress.XtraReports.UI.XRLabel();
            this.AvgofrsFABW3 = new DevExpress.XtraReports.UI.XRLabel();
            this.TotalAverage = new DevExpress.XtraReports.UI.XRLabel();
            this.Line3 = new DevExpress.XtraReports.UI.XRLine();
            this.GT_AvgBWStd_1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Vaccination = new DevExpress.XtraReports.UI.XRLabel();
            this.Subreport3 = new DevExpress.XtraReports.UI.XRSubreport();
            this.Subreport4 = new DevExpress.XtraReports.UI.XRSubreport();
            this.Medication = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeaderSection2 = new DevExpress.XtraReports.UI.SubBand();
            this.Section2 = new DevExpress.XtraReports.UI.SubBand();
            this.Subreport7 = new DevExpress.XtraReports.UI.XRSubreport();
            this.Date = new DevExpress.XtraReports.UI.XRLabel();
            this.Datee1 = new DevExpress.XtraReports.UI.XRLabel();
            this.BookPerf_1 = new DevExpress.XtraReports.UI.XRLabel();
            this.BookPerf_2 = new DevExpress.XtraReports.UI.XRLabel();
            this.Section4 = new DevExpress.XtraReports.UI.SubBand();
            this.ReportFooterSection2 = new DevExpress.XtraReports.UI.SubBand();
            this.ReportFooterSection4 = new DevExpress.XtraReports.UI.SubBand();
            this.ReportFooterSection3 = new DevExpress.XtraReports.UI.SubBand();
            this.SignatureReportFooterSection = new DevExpress.XtraReports.UI.SubBand();
            this.Subreport1 = new DevExpress.XtraReports.UI.XRSubreport();
            this.Subreport2 = new DevExpress.XtraReports.UI.XRSubreport();
            this.ReportNotes_1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Text5 = new DevExpress.XtraReports.UI.XRLabel();
            this.Subreport5 = new DevExpress.XtraReports.UI.XRSubreport();
            this.SignaturePageFooterSection = new DevExpress.XtraReports.UI.SubBand();
            this.Section5 = new DevExpress.XtraReports.UI.SubBand();
            this.Subreport6 = new DevExpress.XtraReports.UI.XRSubreport();
            this.PageNofM1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.PrintTime1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.PrintDate1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.Line10 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.Line11 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.Line12 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.Line13 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.Line14 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.Line15 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.Line16 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.Line17 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.Line18 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.Line19 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.Line20 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.Line21 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.Line24 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.Line25 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.Line26 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.Line27 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.Line29 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.Line30 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.Line31 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.Line32 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.Line33 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.Line28 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.Line34 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.Line35 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.Line36 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.Line37 = new DevExpress.XtraReports.UI.XRCrossBandLine();
            this.ReportName = new DevExpress.XtraReports.UI.CalculatedField();
            this.MortPercent = new DevExpress.XtraReports.UI.CalculatedField();
            this.CummMortPercent = new DevExpress.XtraReports.UI.CalculatedField();
            this.CullsPercent = new DevExpress.XtraReports.UI.CalculatedField();
            this.CummCullsPercent = new DevExpress.XtraReports.UI.CalculatedField();
            this.Depletion = new DevExpress.XtraReports.UI.CalculatedField();
            this.DepletionPercent = new DevExpress.XtraReports.UI.CalculatedField();
            this.LogoPath = new DevExpress.XtraReports.UI.CalculatedField();
            this.ModuleName_en = new DevExpress.XtraReports.UI.CalculatedField();
            this.CompanyName_en = new DevExpress.XtraReports.UI.CalculatedField();
            this.ReportPQP = new DevExpress.XtraReports.UI.CalculatedField();
            this.ModuleName_ar = new DevExpress.XtraReports.UI.CalculatedField();
            this.CompanyName_ar = new DevExpress.XtraReports.UI.CalculatedField();
            this.BookPerf = new DevExpress.XtraReports.UI.CalculatedField();
            this.ShowSignature = new DevExpress.XtraReports.UI.CalculatedField();
            this.ShowSignatureAllPages = new DevExpress.XtraReports.UI.CalculatedField();
            this.ReportNotes = new DevExpress.XtraReports.UI.CalculatedField();
            this.FilterDataHeader = new DevExpress.XtraReports.UI.CalculatedField();
            this.FilterData = new DevExpress.XtraReports.UI.CalculatedField();
            this.GT_AvgBWStd = new DevExpress.XtraReports.UI.CalculatedField();
            this.Datee = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Area3
            // 
            this.Area3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.HouseCode1,
            this.BreedNameen1,
            this.rfFemaleStarted1,
            this.rfWeeKNo1,
            this.rfPlaceDate1,
            this.DailyMort1,
            this.MortStand1,
            this.CummMort1,
            this.CummMortStand1,
            this.DailCulls1,
            this.CullsStand1,
            this.CummCulls1,
            this.CummCullsStand1,
            this.BalanceBirds1,
            this.rsFABW1,
            this.BWStand1,
            this.LightHours1,
            this.LightStand1,
            this.FeedIntake1,
            this.FeedStand1,
            this.MortPercent_2,
            this.CummMortPercent_1,
            this.CullsPercent_2,
            this.CummCullsPercent_1,
            this.Depletion_1,
            this.DepletionPercent_2,
            this.Line2,
            this.Line22,
            this.Line23,
            this.FlockCode1});
            this.Area3.HeightF = 34F;
            this.Area3.KeepTogether = true;
            this.Area3.Name = "Area3";
            this.Area3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.Area3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeaderArea1
            // 
            this.GroupHeaderArea1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.GroupNameFarmCode1,
            this.StdFeedIntake,
            this.ActFeedIntake,
            this.HouseNo,
            this.Breed,
            this.BirdsPlaced,
            this.Ageweek,
            this.DatePlaced,
            this.Mort,
            this.MortStdPercent,
            this.CumMort,
            this.CumMortStd,
            this.Culls,
            this.CullsStdPercent,
            this.CumCulls,
            this.CummCullsStd,
            this.BalanceBirds,
            this.Weight,
            this.WeightStd,
            this.ActualLightHrs,
            this.StdLightHrs,
            this.MortPercent_1,
            this.CumMortPercent,
            this.CullsPercent_1,
            this.CumCullsPercent,
            this.TotDepletion,
            this.DepletionPercent_1,
            this.CropNo1,
            this.Crop,
            this.Line9,
            this.Line1,
            this.Line5,
            this.Line6,
            this.Line8,
            this.FlockNo});
            this.GroupHeaderArea1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("FarmCode", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeaderArea1.HeightF = 148F;
            this.GroupHeaderArea1.KeepTogether = true;
            this.GroupHeaderArea1.Name = "GroupHeaderArea1";
            this.GroupHeaderArea1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.GroupHeaderArea1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupFooterArea1
            // 
            this.GroupFooterArea1.HeightF = 0F;
            this.GroupFooterArea1.Name = "GroupFooterArea1";
            this.GroupFooterArea1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.GroupFooterArea1.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.GroupFooterSection1,
            this.GroupFooterSection3,
            this.GroupFooterSection4});
            this.GroupFooterArea1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Area1
            // 
            this.Area1.HeightF = 0F;
            this.Area1.KeepTogether = true;
            this.Area1.Name = "Area1";
            this.Area1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.Area1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Area2
            // 
            this.Area2.HeightF = 0F;
            this.Area2.Name = "Area2";
            this.Area2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.Area2.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.PageHeaderSection2,
            this.Section2});
            this.Area2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Area4
            // 
            this.Area4.HeightF = 0F;
            this.Area4.Name = "Area4";
            this.Area4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.Area4.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.Section4,
            this.ReportFooterSection2,
            this.ReportFooterSection4,
            this.ReportFooterSection3,
            this.SignatureReportFooterSection});
            this.Area4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Area5
            // 
            this.Area5.HeightF = 0F;
            this.Area5.Name = "Area5";
            this.Area5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.Area5.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SignaturePageFooterSection,
            this.Section5});
            this.Area5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // HouseCode1
            // 
            this.HouseCode1.BackColor = System.Drawing.Color.Transparent;
            this.HouseCode1.BorderColor = System.Drawing.Color.Black;
            this.HouseCode1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.HouseCode1.BorderWidth = 1F;
            this.HouseCode1.CanGrow = false;
            this.HouseCode1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HouseCode]")});
            this.HouseCode1.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.HouseCode1.ForeColor = System.Drawing.Color.Black;
            this.HouseCode1.LocationFloat = new DevExpress.Utils.PointFloat(80.55556F, 1.388889F);
            this.HouseCode1.Name = "HouseCode1";
            this.HouseCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.HouseCode1.SizeF = new System.Drawing.SizeF(22.91667F, 15.34722F);
            this.HouseCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // BreedNameen1
            // 
            this.BreedNameen1.BackColor = System.Drawing.Color.Transparent;
            this.BreedNameen1.BorderColor = System.Drawing.Color.Black;
            this.BreedNameen1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.BreedNameen1.BorderWidth = 1F;
            this.BreedNameen1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BreedName_en]")});
            this.BreedNameen1.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.BreedNameen1.ForeColor = System.Drawing.Color.Black;
            this.BreedNameen1.LocationFloat = new DevExpress.Utils.PointFloat(108.3333F, 1.388889F);
            this.BreedNameen1.Name = "BreedNameen1";
            this.BreedNameen1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.BreedNameen1.SizeF = new System.Drawing.SizeF(66.66666F, 15.34722F);
            this.BreedNameen1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // rfFemaleStarted1
            // 
            this.rfFemaleStarted1.BackColor = System.Drawing.Color.Transparent;
            this.rfFemaleStarted1.BorderColor = System.Drawing.Color.Black;
            this.rfFemaleStarted1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.rfFemaleStarted1.BorderWidth = 1F;
            this.rfFemaleStarted1.CanGrow = false;
            this.rfFemaleStarted1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[rf_Female_Started]")});
            this.rfFemaleStarted1.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.rfFemaleStarted1.ForeColor = System.Drawing.Color.Black;
            this.rfFemaleStarted1.LocationFloat = new DevExpress.Utils.PointFloat(175F, 1.388889F);
            this.rfFemaleStarted1.Name = "rfFemaleStarted1";
            this.rfFemaleStarted1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.rfFemaleStarted1.SizeF = new System.Drawing.SizeF(50F, 15.34722F);
            this.rfFemaleStarted1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // rfWeeKNo1
            // 
            this.rfWeeKNo1.BackColor = System.Drawing.Color.Transparent;
            this.rfWeeKNo1.BorderColor = System.Drawing.Color.Black;
            this.rfWeeKNo1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.rfWeeKNo1.BorderWidth = 1F;
            this.rfWeeKNo1.CanGrow = false;
            this.rfWeeKNo1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[rf_WeeKNo]")});
            this.rfWeeKNo1.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.rfWeeKNo1.ForeColor = System.Drawing.Color.Black;
            this.rfWeeKNo1.LocationFloat = new DevExpress.Utils.PointFloat(233.3333F, 1.388889F);
            this.rfWeeKNo1.Name = "rfWeeKNo1";
            this.rfWeeKNo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.rfWeeKNo1.SizeF = new System.Drawing.SizeF(33.33333F, 15.34722F);
            this.rfWeeKNo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // rfPlaceDate1
            // 
            this.rfPlaceDate1.BackColor = System.Drawing.Color.Transparent;
            this.rfPlaceDate1.BorderColor = System.Drawing.Color.Black;
            this.rfPlaceDate1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.rfPlaceDate1.BorderWidth = 1F;
            this.rfPlaceDate1.CanGrow = false;
            this.rfPlaceDate1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[rf_PlaceDate]")});
            this.rfPlaceDate1.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.rfPlaceDate1.ForeColor = System.Drawing.Color.Black;
            this.rfPlaceDate1.LocationFloat = new DevExpress.Utils.PointFloat(266.6667F, 1.388889F);
            this.rfPlaceDate1.Name = "rfPlaceDate1";
            this.rfPlaceDate1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.rfPlaceDate1.SizeF = new System.Drawing.SizeF(58.33333F, 15.34722F);
            this.rfPlaceDate1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // DailyMort1
            // 
            this.DailyMort1.BackColor = System.Drawing.Color.Transparent;
            this.DailyMort1.BorderColor = System.Drawing.Color.Black;
            this.DailyMort1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DailyMort1.BorderWidth = 1F;
            this.DailyMort1.CanGrow = false;
            this.DailyMort1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DailyMort]")});
            this.DailyMort1.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.DailyMort1.ForeColor = System.Drawing.Color.Black;
            this.DailyMort1.LocationFloat = new DevExpress.Utils.PointFloat(325F, 1.388889F);
            this.DailyMort1.Name = "DailyMort1";
            this.DailyMort1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.DailyMort1.SizeF = new System.Drawing.SizeF(28.125F, 15.34722F);
            this.DailyMort1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // MortStand1
            // 
            this.MortStand1.BackColor = System.Drawing.Color.Transparent;
            this.MortStand1.BorderColor = System.Drawing.Color.Black;
            this.MortStand1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.MortStand1.BorderWidth = 1F;
            this.MortStand1.CanGrow = false;
            this.MortStand1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MortStand]")});
            this.MortStand1.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.MortStand1.ForeColor = System.Drawing.Color.Black;
            this.MortStand1.LocationFloat = new DevExpress.Utils.PointFloat(391.6667F, 1.388889F);
            this.MortStand1.Name = "MortStand1";
            this.MortStand1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.MortStand1.SizeF = new System.Drawing.SizeF(33.33333F, 15.34722F);
            this.MortStand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // CummMort1
            // 
            this.CummMort1.BackColor = System.Drawing.Color.Transparent;
            this.CummMort1.BorderColor = System.Drawing.Color.Black;
            this.CummMort1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CummMort1.BorderWidth = 1F;
            this.CummMort1.CanGrow = false;
            this.CummMort1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CummMort]")});
            this.CummMort1.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.CummMort1.ForeColor = System.Drawing.Color.Black;
            this.CummMort1.LocationFloat = new DevExpress.Utils.PointFloat(427.0833F, 1.388889F);
            this.CummMort1.Name = "CummMort1";
            this.CummMort1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.CummMort1.SizeF = new System.Drawing.SizeF(35.41667F, 15.34722F);
            this.CummMort1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // CummMortStand1
            // 
            this.CummMortStand1.BackColor = System.Drawing.Color.Transparent;
            this.CummMortStand1.BorderColor = System.Drawing.Color.Black;
            this.CummMortStand1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CummMortStand1.BorderWidth = 1F;
            this.CummMortStand1.CanGrow = false;
            this.CummMortStand1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CummMortStand]")});
            this.CummMortStand1.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.CummMortStand1.ForeColor = System.Drawing.Color.Black;
            this.CummMortStand1.LocationFloat = new DevExpress.Utils.PointFloat(500F, 1.388889F);
            this.CummMortStand1.Name = "CummMortStand1";
            this.CummMortStand1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.CummMortStand1.SizeF = new System.Drawing.SizeF(31.25F, 15.34722F);
            this.CummMortStand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // DailCulls1
            // 
            this.DailCulls1.BackColor = System.Drawing.Color.Transparent;
            this.DailCulls1.BorderColor = System.Drawing.Color.Black;
            this.DailCulls1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DailCulls1.BorderWidth = 1F;
            this.DailCulls1.CanGrow = false;
            this.DailCulls1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DailCulls]")});
            this.DailCulls1.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.DailCulls1.ForeColor = System.Drawing.Color.Black;
            this.DailCulls1.LocationFloat = new DevExpress.Utils.PointFloat(533.3333F, 1.388889F);
            this.DailCulls1.Name = "DailCulls1";
            this.DailCulls1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.DailCulls1.SizeF = new System.Drawing.SizeF(30.20833F, 15.34722F);
            this.DailCulls1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // CullsStand1
            // 
            this.CullsStand1.BackColor = System.Drawing.Color.Transparent;
            this.CullsStand1.BorderColor = System.Drawing.Color.Black;
            this.CullsStand1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CullsStand1.BorderWidth = 1F;
            this.CullsStand1.CanGrow = false;
            this.CullsStand1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CullsStand]")});
            this.CullsStand1.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.CullsStand1.ForeColor = System.Drawing.Color.Black;
            this.CullsStand1.LocationFloat = new DevExpress.Utils.PointFloat(600F, 1.388889F);
            this.CullsStand1.Name = "CullsStand1";
            this.CullsStand1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.CullsStand1.SizeF = new System.Drawing.SizeF(31.25F, 15.34722F);
            this.CullsStand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // CummCulls1
            // 
            this.CummCulls1.BackColor = System.Drawing.Color.Transparent;
            this.CummCulls1.BorderColor = System.Drawing.Color.Black;
            this.CummCulls1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CummCulls1.BorderWidth = 1F;
            this.CummCulls1.CanGrow = false;
            this.CummCulls1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CummCulls]")});
            this.CummCulls1.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.CummCulls1.ForeColor = System.Drawing.Color.Black;
            this.CummCulls1.LocationFloat = new DevExpress.Utils.PointFloat(633.3333F, 1.388889F);
            this.CummCulls1.Name = "CummCulls1";
            this.CummCulls1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.CummCulls1.SizeF = new System.Drawing.SizeF(38.54167F, 15.34722F);
            this.CummCulls1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // CummCullsStand1
            // 
            this.CummCullsStand1.BackColor = System.Drawing.Color.Transparent;
            this.CummCullsStand1.BorderColor = System.Drawing.Color.Black;
            this.CummCullsStand1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CummCullsStand1.BorderWidth = 1F;
            this.CummCullsStand1.CanGrow = false;
            this.CummCullsStand1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CummCullsStand]")});
            this.CummCullsStand1.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.CummCullsStand1.ForeColor = System.Drawing.Color.Black;
            this.CummCullsStand1.LocationFloat = new DevExpress.Utils.PointFloat(708.3333F, 1.388889F);
            this.CummCullsStand1.Name = "CummCullsStand1";
            this.CummCullsStand1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.CummCullsStand1.SizeF = new System.Drawing.SizeF(35.41667F, 15.34722F);
            this.CummCullsStand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BalanceBirds1
            // 
            this.BalanceBirds1.BackColor = System.Drawing.Color.Transparent;
            this.BalanceBirds1.BorderColor = System.Drawing.Color.Black;
            this.BalanceBirds1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.BalanceBirds1.BorderWidth = 1F;
            this.BalanceBirds1.CanGrow = false;
            this.BalanceBirds1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BalanceBirds]")});
            this.BalanceBirds1.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.BalanceBirds1.ForeColor = System.Drawing.Color.Black;
            this.BalanceBirds1.LocationFloat = new DevExpress.Utils.PointFloat(825F, 1.388889F);
            this.BalanceBirds1.Name = "BalanceBirds1";
            this.BalanceBirds1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.BalanceBirds1.SizeF = new System.Drawing.SizeF(58.33333F, 15.34722F);
            this.BalanceBirds1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // rsFABW1
            // 
            this.rsFABW1.BackColor = System.Drawing.Color.Transparent;
            this.rsFABW1.BorderColor = System.Drawing.Color.Black;
            this.rsFABW1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.rsFABW1.BorderWidth = 1F;
            this.rsFABW1.CanGrow = false;
            this.rsFABW1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[rs_FABW]")});
            this.rsFABW1.Font = new DevExpress.Drawing.DXFont("Arial", 8F);
            this.rsFABW1.ForeColor = System.Drawing.Color.Black;
            this.rsFABW1.LocationFloat = new DevExpress.Utils.PointFloat(887.5F, 1.388889F);
            this.rsFABW1.Name = "rsFABW1";
            this.rsFABW1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.rsFABW1.SizeF = new System.Drawing.SizeF(42.70833F, 15.34722F);
            this.rsFABW1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BWStand1
            // 
            this.BWStand1.BackColor = System.Drawing.Color.Transparent;
            this.BWStand1.BorderColor = System.Drawing.Color.Black;
            this.BWStand1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.BWStand1.BorderWidth = 1F;
            this.BWStand1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BWStand]")});
            this.BWStand1.Font = new DevExpress.Drawing.DXFont("Arial", 8F);
            this.BWStand1.ForeColor = System.Drawing.Color.Black;
            this.BWStand1.LocationFloat = new DevExpress.Utils.PointFloat(933.3333F, 1.388889F);
            this.BWStand1.Name = "BWStand1";
            this.BWStand1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.BWStand1.SizeF = new System.Drawing.SizeF(43.75F, 15.34722F);
            this.BWStand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // LightHours1
            // 
            this.LightHours1.BackColor = System.Drawing.Color.Transparent;
            this.LightHours1.BorderColor = System.Drawing.Color.Black;
            this.LightHours1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.LightHours1.BorderWidth = 1F;
            this.LightHours1.CanGrow = false;
            this.LightHours1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LightHours]")});
            this.LightHours1.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.LightHours1.ForeColor = System.Drawing.Color.Black;
            this.LightHours1.LocationFloat = new DevExpress.Utils.PointFloat(977.7778F, 1.388889F);
            this.LightHours1.Name = "LightHours1";
            this.LightHours1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.LightHours1.SizeF = new System.Drawing.SizeF(28.125F, 15.34722F);
            this.LightHours1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // LightStand1
            // 
            this.LightStand1.BackColor = System.Drawing.Color.Transparent;
            this.LightStand1.BorderColor = System.Drawing.Color.Black;
            this.LightStand1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.LightStand1.BorderWidth = 1F;
            this.LightStand1.CanGrow = false;
            this.LightStand1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LightStand]")});
            this.LightStand1.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.LightStand1.ForeColor = System.Drawing.Color.Black;
            this.LightStand1.LocationFloat = new DevExpress.Utils.PointFloat(1011.111F, 1.388889F);
            this.LightStand1.Name = "LightStand1";
            this.LightStand1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.LightStand1.SizeF = new System.Drawing.SizeF(28.125F, 15.34722F);
            this.LightStand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // FeedIntake1
            // 
            this.FeedIntake1.BackColor = System.Drawing.Color.Transparent;
            this.FeedIntake1.BorderColor = System.Drawing.Color.Black;
            this.FeedIntake1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.FeedIntake1.BorderWidth = 1F;
            this.FeedIntake1.CanGrow = false;
            this.FeedIntake1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FeedIntake]")});
            this.FeedIntake1.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.FeedIntake1.ForeColor = System.Drawing.Color.Black;
            this.FeedIntake1.LocationFloat = new DevExpress.Utils.PointFloat(1041.667F, 1.388889F);
            this.FeedIntake1.Name = "FeedIntake1";
            this.FeedIntake1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.FeedIntake1.SizeF = new System.Drawing.SizeF(34.375F, 15.34722F);
            this.FeedIntake1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // FeedStand1
            // 
            this.FeedStand1.BackColor = System.Drawing.Color.Transparent;
            this.FeedStand1.BorderColor = System.Drawing.Color.Black;
            this.FeedStand1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.FeedStand1.BorderWidth = 1F;
            this.FeedStand1.CanGrow = false;
            this.FeedStand1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FeedStand]")});
            this.FeedStand1.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.FeedStand1.ForeColor = System.Drawing.Color.Black;
            this.FeedStand1.LocationFloat = new DevExpress.Utils.PointFloat(1083.333F, 1.388889F);
            this.FeedStand1.Name = "FeedStand1";
            this.FeedStand1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.FeedStand1.SizeF = new System.Drawing.SizeF(34.375F, 15.34722F);
            this.FeedStand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // MortPercent_2
            // 
            this.MortPercent_2.BackColor = System.Drawing.Color.Transparent;
            this.MortPercent_2.BorderColor = System.Drawing.Color.Black;
            this.MortPercent_2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.MortPercent_2.BorderWidth = 1F;
            this.MortPercent_2.CanGrow = false;
            this.MortPercent_2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MortPercent]")});
            this.MortPercent_2.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.MortPercent_2.ForeColor = System.Drawing.Color.Black;
            this.MortPercent_2.LocationFloat = new DevExpress.Utils.PointFloat(358.3333F, 1.388889F);
            this.MortPercent_2.Name = "MortPercent_2";
            this.MortPercent_2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.MortPercent_2.SizeF = new System.Drawing.SizeF(29.16667F, 15.34722F);
            this.MortPercent_2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // CummMortPercent_1
            // 
            this.CummMortPercent_1.BackColor = System.Drawing.Color.Transparent;
            this.CummMortPercent_1.BorderColor = System.Drawing.Color.Black;
            this.CummMortPercent_1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CummMortPercent_1.BorderWidth = 1F;
            this.CummMortPercent_1.CanGrow = false;
            this.CummMortPercent_1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CummMortPercent]")});
            this.CummMortPercent_1.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.CummMortPercent_1.ForeColor = System.Drawing.Color.Black;
            this.CummMortPercent_1.LocationFloat = new DevExpress.Utils.PointFloat(464.5833F, 1.388889F);
            this.CummMortPercent_1.Name = "CummMortPercent_1";
            this.CummMortPercent_1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.CummMortPercent_1.SizeF = new System.Drawing.SizeF(32.29167F, 15.34722F);
            this.CummMortPercent_1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // CullsPercent_2
            // 
            this.CullsPercent_2.BackColor = System.Drawing.Color.Transparent;
            this.CullsPercent_2.BorderColor = System.Drawing.Color.Black;
            this.CullsPercent_2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CullsPercent_2.BorderWidth = 1F;
            this.CullsPercent_2.CanGrow = false;
            this.CullsPercent_2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CullsPercent]")});
            this.CullsPercent_2.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.CullsPercent_2.ForeColor = System.Drawing.Color.Black;
            this.CullsPercent_2.LocationFloat = new DevExpress.Utils.PointFloat(566.6667F, 1.388889F);
            this.CullsPercent_2.Name = "CullsPercent_2";
            this.CullsPercent_2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.CullsPercent_2.SizeF = new System.Drawing.SizeF(32.29167F, 15.34722F);
            this.CullsPercent_2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // CummCullsPercent_1
            // 
            this.CummCullsPercent_1.BackColor = System.Drawing.Color.Transparent;
            this.CummCullsPercent_1.BorderColor = System.Drawing.Color.Black;
            this.CummCullsPercent_1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CummCullsPercent_1.BorderWidth = 1F;
            this.CummCullsPercent_1.CanGrow = false;
            this.CummCullsPercent_1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CummCullsPercent]")});
            this.CummCullsPercent_1.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.CummCullsPercent_1.ForeColor = System.Drawing.Color.Black;
            this.CummCullsPercent_1.LocationFloat = new DevExpress.Utils.PointFloat(675F, 1.388889F);
            this.CummCullsPercent_1.Name = "CummCullsPercent_1";
            this.CummCullsPercent_1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.CummCullsPercent_1.SizeF = new System.Drawing.SizeF(30.20833F, 15.34722F);
            this.CummCullsPercent_1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Depletion_1
            // 
            this.Depletion_1.BackColor = System.Drawing.Color.Transparent;
            this.Depletion_1.BorderColor = System.Drawing.Color.Black;
            this.Depletion_1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Depletion_1.BorderWidth = 1F;
            this.Depletion_1.CanGrow = false;
            this.Depletion_1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Depletion]")});
            this.Depletion_1.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.Depletion_1.ForeColor = System.Drawing.Color.Black;
            this.Depletion_1.LocationFloat = new DevExpress.Utils.PointFloat(750F, 1.388889F);
            this.Depletion_1.Name = "Depletion_1";
            this.Depletion_1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.Depletion_1.SizeF = new System.Drawing.SizeF(35.41667F, 15.34722F);
            this.Depletion_1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // DepletionPercent_2
            // 
            this.DepletionPercent_2.BackColor = System.Drawing.Color.Transparent;
            this.DepletionPercent_2.BorderColor = System.Drawing.Color.Black;
            this.DepletionPercent_2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DepletionPercent_2.BorderWidth = 1F;
            this.DepletionPercent_2.CanGrow = false;
            this.DepletionPercent_2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DepletionPercent]")});
            this.DepletionPercent_2.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.DepletionPercent_2.ForeColor = System.Drawing.Color.Black;
            this.DepletionPercent_2.LocationFloat = new DevExpress.Utils.PointFloat(791.6667F, 1.388889F);
            this.DepletionPercent_2.Name = "DepletionPercent_2";
            this.DepletionPercent_2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.DepletionPercent_2.SizeF = new System.Drawing.SizeF(29.16667F, 15.34722F);
            this.DepletionPercent_2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Line2
            // 
            this.Line2.BackColor = System.Drawing.Color.Transparent;
            this.Line2.BorderColor = System.Drawing.Color.Black;
            this.Line2.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.Line2.BorderWidth = 1F;
            this.Line2.ForeColor = System.Drawing.Color.Black;
            this.Line2.LocationFloat = new DevExpress.Utils.PointFloat(8.333333F, 33.33333F);
            this.Line2.Name = "Line2";
            this.Line2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.Line2.SizeF = new System.Drawing.SizeF(1116.667F, 2F);
            // 
            // Line22
            // 
            this.Line22.BackColor = System.Drawing.Color.Transparent;
            this.Line22.BorderColor = System.Drawing.Color.Black;
            this.Line22.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.Line22.BorderWidth = 1F;
            this.Line22.ForeColor = System.Drawing.Color.Black;
            this.Line22.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.Line22.LocationFloat = new DevExpress.Utils.PointFloat(76.38889F, 0F);
            this.Line22.Name = "Line22";
            this.Line22.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.Line22.SizeF = new System.Drawing.SizeF(2F, 34.65278F);
            // 
            // Line23
            // 
            this.Line23.BackColor = System.Drawing.Color.Transparent;
            this.Line23.BorderColor = System.Drawing.Color.Black;
            this.Line23.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.Line23.BorderWidth = 1F;
            this.Line23.ForeColor = System.Drawing.Color.Black;
            this.Line23.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.Line23.LocationFloat = new DevExpress.Utils.PointFloat(108.3333F, 0F);
            this.Line23.Name = "Line23";
            this.Line23.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.Line23.SizeF = new System.Drawing.SizeF(2F, 33.61111F);
            // 
            // FlockCode1
            // 
            this.FlockCode1.BackColor = System.Drawing.Color.Transparent;
            this.FlockCode1.BorderColor = System.Drawing.Color.Black;
            this.FlockCode1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.FlockCode1.BorderWidth = 1F;
            this.FlockCode1.CanGrow = false;
            this.FlockCode1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FlockCode]")});
            this.FlockCode1.Font = new DevExpress.Drawing.DXFont("Arial", 9F);
            this.FlockCode1.ForeColor = System.Drawing.Color.Black;
            this.FlockCode1.LocationFloat = new DevExpress.Utils.PointFloat(12.5F, 3.472222F);
            this.FlockCode1.Name = "FlockCode1";
            this.FlockCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.FlockCode1.SizeF = new System.Drawing.SizeF(59.72222F, 15.34722F);
            this.FlockCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // GroupNameFarmCode1
            // 
            this.GroupNameFarmCode1.BackColor = System.Drawing.Color.Transparent;
            this.GroupNameFarmCode1.BorderColor = System.Drawing.Color.Black;
            this.GroupNameFarmCode1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.GroupNameFarmCode1.BorderWidth = 1F;
            this.GroupNameFarmCode1.CanGrow = false;
            this.GroupNameFarmCode1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FarmCode]")});
            this.GroupNameFarmCode1.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GroupNameFarmCode1.ForeColor = System.Drawing.Color.Black;
            this.GroupNameFarmCode1.LocationFloat = new DevExpress.Utils.PointFloat(416.6667F, 0F);
            this.GroupNameFarmCode1.Name = "GroupNameFarmCode1";
            this.GroupNameFarmCode1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.GroupNameFarmCode1.SizeF = new System.Drawing.SizeF(283.3333F, 15.97222F);
            this.GroupNameFarmCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // StdFeedIntake
            // 
            this.StdFeedIntake.BackColor = System.Drawing.Color.Transparent;
            this.StdFeedIntake.BorderColor = System.Drawing.Color.Black;
            this.StdFeedIntake.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.StdFeedIntake.BorderWidth = 1F;
            this.StdFeedIntake.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.StdFeedIntake.ForeColor = System.Drawing.Color.Black;
            this.StdFeedIntake.LocationFloat = new DevExpress.Utils.PointFloat(1093.056F, 19.16667F);
            this.StdFeedIntake.Name = "StdFeedIntake";
            this.StdFeedIntake.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.StdFeedIntake.SizeF = new System.Drawing.SizeF(16.66667F, 105.2778F);
            this.StdFeedIntake.Text = "Std. Feed Intake";
            this.StdFeedIntake.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // ActFeedIntake
            // 
            this.ActFeedIntake.BackColor = System.Drawing.Color.Transparent;
            this.ActFeedIntake.BorderColor = System.Drawing.Color.Black;
            this.ActFeedIntake.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.ActFeedIntake.BorderWidth = 1F;
            this.ActFeedIntake.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.ActFeedIntake.ForeColor = System.Drawing.Color.Black;
            this.ActFeedIntake.LocationFloat = new DevExpress.Utils.PointFloat(1046.875F, 19.16667F);
            this.ActFeedIntake.Name = "ActFeedIntake";
            this.ActFeedIntake.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.ActFeedIntake.SizeF = new System.Drawing.SizeF(32.98611F, 105.2778F);
            this.ActFeedIntake.Text = "Actual Feed\nIntake / bird (g)";
            this.ActFeedIntake.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // HouseNo
            // 
            this.HouseNo.BackColor = System.Drawing.Color.Transparent;
            this.HouseNo.BorderColor = System.Drawing.Color.Black;
            this.HouseNo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.HouseNo.BorderWidth = 1F;
            this.HouseNo.CanGrow = false;
            this.HouseNo.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.HouseNo.ForeColor = System.Drawing.Color.Black;
            this.HouseNo.LocationFloat = new DevExpress.Utils.PointFloat(81.59722F, 19.16667F);
            this.HouseNo.Name = "HouseNo";
            this.HouseNo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.HouseNo.SizeF = new System.Drawing.SizeF(22.91667F, 105.2778F);
            this.HouseNo.Text = "House No.";
            this.HouseNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Breed
            // 
            this.Breed.BackColor = System.Drawing.Color.Transparent;
            this.Breed.BorderColor = System.Drawing.Color.Black;
            this.Breed.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Breed.BorderWidth = 1F;
            this.Breed.CanGrow = false;
            this.Breed.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Breed.ForeColor = System.Drawing.Color.Black;
            this.Breed.LocationFloat = new DevExpress.Utils.PointFloat(134.375F, 19.16667F);
            this.Breed.Name = "Breed";
            this.Breed.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.Breed.SizeF = new System.Drawing.SizeF(25F, 105.2778F);
            this.Breed.Text = "Breed";
            this.Breed.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // BirdsPlaced
            // 
            this.BirdsPlaced.BackColor = System.Drawing.Color.Transparent;
            this.BirdsPlaced.BorderColor = System.Drawing.Color.Black;
            this.BirdsPlaced.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.BirdsPlaced.BorderWidth = 1F;
            this.BirdsPlaced.CanGrow = false;
            this.BirdsPlaced.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.BirdsPlaced.ForeColor = System.Drawing.Color.Black;
            this.BirdsPlaced.LocationFloat = new DevExpress.Utils.PointFloat(176.0417F, 19.16667F);
            this.BirdsPlaced.Name = "BirdsPlaced";
            this.BirdsPlaced.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.BirdsPlaced.SizeF = new System.Drawing.SizeF(50F, 105.2778F);
            this.BirdsPlaced.Text = "\nBirds Placed";
            this.BirdsPlaced.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Ageweek
            // 
            this.Ageweek.BackColor = System.Drawing.Color.Transparent;
            this.Ageweek.BorderColor = System.Drawing.Color.Black;
            this.Ageweek.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Ageweek.BorderWidth = 1F;
            this.Ageweek.CanGrow = false;
            this.Ageweek.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Ageweek.ForeColor = System.Drawing.Color.Black;
            this.Ageweek.LocationFloat = new DevExpress.Utils.PointFloat(234.375F, 19.16667F);
            this.Ageweek.Name = "Ageweek";
            this.Ageweek.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.Ageweek.SizeF = new System.Drawing.SizeF(25F, 105.2778F);
            this.Ageweek.Text = "Age (week)";
            this.Ageweek.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // DatePlaced
            // 
            this.DatePlaced.BackColor = System.Drawing.Color.Transparent;
            this.DatePlaced.BorderColor = System.Drawing.Color.Black;
            this.DatePlaced.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DatePlaced.BorderWidth = 1F;
            this.DatePlaced.CanGrow = false;
            this.DatePlaced.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.DatePlaced.ForeColor = System.Drawing.Color.Black;
            this.DatePlaced.LocationFloat = new DevExpress.Utils.PointFloat(284.375F, 19.16667F);
            this.DatePlaced.Name = "DatePlaced";
            this.DatePlaced.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.DatePlaced.SizeF = new System.Drawing.SizeF(16.66667F, 105.2778F);
            this.DatePlaced.Text = "Date Placed";
            this.DatePlaced.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Mort
            // 
            this.Mort.BackColor = System.Drawing.Color.Transparent;
            this.Mort.BorderColor = System.Drawing.Color.Black;
            this.Mort.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Mort.BorderWidth = 1F;
            this.Mort.CanGrow = false;
            this.Mort.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Mort.ForeColor = System.Drawing.Color.Black;
            this.Mort.LocationFloat = new DevExpress.Utils.PointFloat(334.375F, 19.16667F);
            this.Mort.Name = "Mort";
            this.Mort.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.Mort.SizeF = new System.Drawing.SizeF(16.66667F, 105.2778F);
            this.Mort.Text = "Mort.";
            this.Mort.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // MortStdPercent
            // 
            this.MortStdPercent.BackColor = System.Drawing.Color.Transparent;
            this.MortStdPercent.BorderColor = System.Drawing.Color.Black;
            this.MortStdPercent.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.MortStdPercent.BorderWidth = 1F;
            this.MortStdPercent.CanGrow = false;
            this.MortStdPercent.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.MortStdPercent.ForeColor = System.Drawing.Color.Black;
            this.MortStdPercent.LocationFloat = new DevExpress.Utils.PointFloat(402.4305F, 19.16667F);
            this.MortStdPercent.Name = "MortStdPercent";
            this.MortStdPercent.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.MortStdPercent.SizeF = new System.Drawing.SizeF(16.66667F, 105.2778F);
            this.MortStdPercent.Text = "Mort Std %";
            this.MortStdPercent.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // CumMort
            // 
            this.CumMort.BackColor = System.Drawing.Color.Transparent;
            this.CumMort.BorderColor = System.Drawing.Color.Black;
            this.CumMort.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CumMort.BorderWidth = 1F;
            this.CumMort.CanGrow = false;
            this.CumMort.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.CumMort.ForeColor = System.Drawing.Color.Black;
            this.CumMort.LocationFloat = new DevExpress.Utils.PointFloat(441.6667F, 19.16667F);
            this.CumMort.Name = "CumMort";
            this.CumMort.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.CumMort.SizeF = new System.Drawing.SizeF(16.66667F, 105.2778F);
            this.CumMort.Text = "Cum Mort";
            this.CumMort.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // CumMortStd
            // 
            this.CumMortStd.BackColor = System.Drawing.Color.Transparent;
            this.CumMortStd.BorderColor = System.Drawing.Color.Black;
            this.CumMortStd.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CumMortStd.BorderWidth = 1F;
            this.CumMortStd.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.CumMortStd.ForeColor = System.Drawing.Color.Black;
            this.CumMortStd.LocationFloat = new DevExpress.Utils.PointFloat(509.7222F, 19.16667F);
            this.CumMortStd.Name = "CumMortStd";
            this.CumMortStd.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.CumMortStd.SizeF = new System.Drawing.SizeF(16.66667F, 105.2778F);
            this.CumMortStd.Text = "Cum Mort Std";
            this.CumMortStd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Culls
            // 
            this.Culls.BackColor = System.Drawing.Color.Transparent;
            this.Culls.BorderColor = System.Drawing.Color.Black;
            this.Culls.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Culls.BorderWidth = 1F;
            this.Culls.CanGrow = false;
            this.Culls.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Culls.ForeColor = System.Drawing.Color.Black;
            this.Culls.LocationFloat = new DevExpress.Utils.PointFloat(534.7222F, 19.16667F);
            this.Culls.Name = "Culls";
            this.Culls.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.Culls.SizeF = new System.Drawing.SizeF(25F, 105.2778F);
            this.Culls.Text = "Culls";
            this.Culls.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // CullsStdPercent
            // 
            this.CullsStdPercent.BackColor = System.Drawing.Color.Transparent;
            this.CullsStdPercent.BorderColor = System.Drawing.Color.Black;
            this.CullsStdPercent.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CullsStdPercent.BorderWidth = 1F;
            this.CullsStdPercent.CanGrow = false;
            this.CullsStdPercent.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.CullsStdPercent.ForeColor = System.Drawing.Color.Black;
            this.CullsStdPercent.LocationFloat = new DevExpress.Utils.PointFloat(609.7222F, 19.16667F);
            this.CullsStdPercent.Name = "CullsStdPercent";
            this.CullsStdPercent.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.CullsStdPercent.SizeF = new System.Drawing.SizeF(16.66667F, 105.2778F);
            this.CullsStdPercent.Text = "Culls Std %";
            this.CullsStdPercent.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // CumCulls
            // 
            this.CumCulls.BackColor = System.Drawing.Color.Transparent;
            this.CumCulls.BorderColor = System.Drawing.Color.Black;
            this.CumCulls.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CumCulls.BorderWidth = 1F;
            this.CumCulls.CanGrow = false;
            this.CumCulls.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.CumCulls.ForeColor = System.Drawing.Color.Black;
            this.CumCulls.LocationFloat = new DevExpress.Utils.PointFloat(643.0555F, 19.16667F);
            this.CumCulls.Name = "CumCulls";
            this.CumCulls.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.CumCulls.SizeF = new System.Drawing.SizeF(16.66667F, 105.2778F);
            this.CumCulls.Text = "Cum Culls";
            this.CumCulls.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // CummCullsStd
            // 
            this.CummCullsStd.BackColor = System.Drawing.Color.Transparent;
            this.CummCullsStd.BorderColor = System.Drawing.Color.Black;
            this.CummCullsStd.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CummCullsStd.BorderWidth = 1F;
            this.CummCullsStd.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.CummCullsStd.ForeColor = System.Drawing.Color.Black;
            this.CummCullsStd.LocationFloat = new DevExpress.Utils.PointFloat(718.0555F, 19.16667F);
            this.CummCullsStd.Name = "CummCullsStd";
            this.CummCullsStd.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.CummCullsStd.SizeF = new System.Drawing.SizeF(16.66667F, 105.2778F);
            this.CummCullsStd.Text = "Cumm Culls Std";
            this.CummCullsStd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // BalanceBirds
            // 
            this.BalanceBirds.BackColor = System.Drawing.Color.Transparent;
            this.BalanceBirds.BorderColor = System.Drawing.Color.Black;
            this.BalanceBirds.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.BalanceBirds.BorderWidth = 1F;
            this.BalanceBirds.CanGrow = false;
            this.BalanceBirds.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.BalanceBirds.ForeColor = System.Drawing.Color.Black;
            this.BalanceBirds.LocationFloat = new DevExpress.Utils.PointFloat(851.3889F, 19.16667F);
            this.BalanceBirds.Name = "BalanceBirds";
            this.BalanceBirds.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.BalanceBirds.SizeF = new System.Drawing.SizeF(16.66667F, 105.2778F);
            this.BalanceBirds.Text = "Balance Birds";
            this.BalanceBirds.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Weight
            // 
            this.Weight.BackColor = System.Drawing.Color.Transparent;
            this.Weight.BorderColor = System.Drawing.Color.Black;
            this.Weight.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Weight.BorderWidth = 1F;
            this.Weight.CanGrow = false;
            this.Weight.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Weight.ForeColor = System.Drawing.Color.Black;
            this.Weight.LocationFloat = new DevExpress.Utils.PointFloat(901.3889F, 19.16667F);
            this.Weight.Name = "Weight";
            this.Weight.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.Weight.SizeF = new System.Drawing.SizeF(16.66667F, 105.2778F);
            this.Weight.Text = "Weight";
            this.Weight.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // WeightStd
            // 
            this.WeightStd.BackColor = System.Drawing.Color.Transparent;
            this.WeightStd.BorderColor = System.Drawing.Color.Black;
            this.WeightStd.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.WeightStd.BorderWidth = 1F;
            this.WeightStd.CanGrow = false;
            this.WeightStd.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.WeightStd.ForeColor = System.Drawing.Color.Black;
            this.WeightStd.LocationFloat = new DevExpress.Utils.PointFloat(943.0555F, 19.16667F);
            this.WeightStd.Name = "WeightStd";
            this.WeightStd.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.WeightStd.SizeF = new System.Drawing.SizeF(16.66667F, 105.2778F);
            this.WeightStd.Text = "Weight Std.";
            this.WeightStd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // ActualLightHrs
            // 
            this.ActualLightHrs.BackColor = System.Drawing.Color.Transparent;
            this.ActualLightHrs.BorderColor = System.Drawing.Color.Black;
            this.ActualLightHrs.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.ActualLightHrs.BorderWidth = 1F;
            this.ActualLightHrs.CanGrow = false;
            this.ActualLightHrs.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.ActualLightHrs.ForeColor = System.Drawing.Color.Black;
            this.ActualLightHrs.LocationFloat = new DevExpress.Utils.PointFloat(983.3333F, 19.16667F);
            this.ActualLightHrs.Name = "ActualLightHrs";
            this.ActualLightHrs.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.ActualLightHrs.SizeF = new System.Drawing.SizeF(28.125F, 105.2778F);
            this.ActualLightHrs.Text = "Actual Light Hrs";
            this.ActualLightHrs.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // StdLightHrs
            // 
            this.StdLightHrs.BackColor = System.Drawing.Color.Transparent;
            this.StdLightHrs.BorderColor = System.Drawing.Color.Black;
            this.StdLightHrs.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.StdLightHrs.BorderWidth = 1F;
            this.StdLightHrs.CanGrow = false;
            this.StdLightHrs.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.StdLightHrs.ForeColor = System.Drawing.Color.Black;
            this.StdLightHrs.LocationFloat = new DevExpress.Utils.PointFloat(1017.014F, 19.16667F);
            this.StdLightHrs.Name = "StdLightHrs";
            this.StdLightHrs.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.StdLightHrs.SizeF = new System.Drawing.SizeF(23.95833F, 105.2778F);
            this.StdLightHrs.Text = "Std Light Hrs";
            this.StdLightHrs.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // MortPercent_1
            // 
            this.MortPercent_1.BackColor = System.Drawing.Color.Transparent;
            this.MortPercent_1.BorderColor = System.Drawing.Color.Black;
            this.MortPercent_1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.MortPercent_1.BorderWidth = 1F;
            this.MortPercent_1.CanGrow = false;
            this.MortPercent_1.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.MortPercent_1.ForeColor = System.Drawing.Color.Black;
            this.MortPercent_1.LocationFloat = new DevExpress.Utils.PointFloat(367.7083F, 19.16667F);
            this.MortPercent_1.Name = "MortPercent_1";
            this.MortPercent_1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.MortPercent_1.SizeF = new System.Drawing.SizeF(16.66667F, 105.2778F);
            this.MortPercent_1.Text = "Mort. %";
            this.MortPercent_1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // CumMortPercent
            // 
            this.CumMortPercent.BackColor = System.Drawing.Color.Transparent;
            this.CumMortPercent.BorderColor = System.Drawing.Color.Black;
            this.CumMortPercent.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CumMortPercent.BorderWidth = 1F;
            this.CumMortPercent.CanGrow = false;
            this.CumMortPercent.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.CumMortPercent.ForeColor = System.Drawing.Color.Black;
            this.CumMortPercent.LocationFloat = new DevExpress.Utils.PointFloat(476.3889F, 19.16667F);
            this.CumMortPercent.Name = "CumMortPercent";
            this.CumMortPercent.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.CumMortPercent.SizeF = new System.Drawing.SizeF(16.66667F, 105.2778F);
            this.CumMortPercent.Text = "Cum Mort %";
            this.CumMortPercent.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // CullsPercent_1
            // 
            this.CullsPercent_1.BackColor = System.Drawing.Color.Transparent;
            this.CullsPercent_1.BorderColor = System.Drawing.Color.Black;
            this.CullsPercent_1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CullsPercent_1.BorderWidth = 1F;
            this.CullsPercent_1.CanGrow = false;
            this.CullsPercent_1.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.CullsPercent_1.ForeColor = System.Drawing.Color.Black;
            this.CullsPercent_1.LocationFloat = new DevExpress.Utils.PointFloat(576.3889F, 19.16667F);
            this.CullsPercent_1.Name = "CullsPercent_1";
            this.CullsPercent_1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.CullsPercent_1.SizeF = new System.Drawing.SizeF(16.66667F, 105.2778F);
            this.CullsPercent_1.Text = "Culls %";
            this.CullsPercent_1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // CumCullsPercent
            // 
            this.CumCullsPercent.BackColor = System.Drawing.Color.Transparent;
            this.CumCullsPercent.BorderColor = System.Drawing.Color.Black;
            this.CumCullsPercent.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CumCullsPercent.BorderWidth = 1F;
            this.CumCullsPercent.CanGrow = false;
            this.CumCullsPercent.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.CumCullsPercent.ForeColor = System.Drawing.Color.Black;
            this.CumCullsPercent.LocationFloat = new DevExpress.Utils.PointFloat(684.7222F, 19.16667F);
            this.CumCullsPercent.Name = "CumCullsPercent";
            this.CumCullsPercent.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.CumCullsPercent.SizeF = new System.Drawing.SizeF(16.66667F, 105.2778F);
            this.CumCullsPercent.Text = "Cum Culls %";
            this.CumCullsPercent.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // TotDepletion
            // 
            this.TotDepletion.BackColor = System.Drawing.Color.Transparent;
            this.TotDepletion.BorderColor = System.Drawing.Color.Black;
            this.TotDepletion.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.TotDepletion.BorderWidth = 1F;
            this.TotDepletion.CanGrow = false;
            this.TotDepletion.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.TotDepletion.ForeColor = System.Drawing.Color.Black;
            this.TotDepletion.LocationFloat = new DevExpress.Utils.PointFloat(759.7222F, 19.16667F);
            this.TotDepletion.Name = "TotDepletion";
            this.TotDepletion.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.TotDepletion.SizeF = new System.Drawing.SizeF(16.66667F, 105.2778F);
            this.TotDepletion.Text = "Tot. Depletion";
            this.TotDepletion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // DepletionPercent_1
            // 
            this.DepletionPercent_1.BackColor = System.Drawing.Color.Transparent;
            this.DepletionPercent_1.BorderColor = System.Drawing.Color.Black;
            this.DepletionPercent_1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DepletionPercent_1.BorderWidth = 1F;
            this.DepletionPercent_1.CanGrow = false;
            this.DepletionPercent_1.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.DepletionPercent_1.ForeColor = System.Drawing.Color.Black;
            this.DepletionPercent_1.LocationFloat = new DevExpress.Utils.PointFloat(801.3889F, 19.16667F);
            this.DepletionPercent_1.Name = "DepletionPercent_1";
            this.DepletionPercent_1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.DepletionPercent_1.SizeF = new System.Drawing.SizeF(16.66667F, 105.2778F);
            this.DepletionPercent_1.Text = "Depletion %";
            this.DepletionPercent_1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // CropNo1
            // 
            this.CropNo1.BackColor = System.Drawing.Color.Transparent;
            this.CropNo1.BorderColor = System.Drawing.Color.Black;
            this.CropNo1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.CropNo1.BorderWidth = 1F;
            this.CropNo1.CanGrow = false;
            this.CropNo1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CropNo]")});
            this.CropNo1.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.CropNo1.ForeColor = System.Drawing.Color.Black;
            this.CropNo1.LocationFloat = new DevExpress.Utils.PointFloat(775F, 0F);
            this.CropNo1.Name = "CropNo1";
            this.CropNo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.CropNo1.SizeF = new System.Drawing.SizeF(61.45833F, 15.97222F);
            this.CropNo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Crop
            // 
            this.Crop.BackColor = System.Drawing.Color.Transparent;
            this.Crop.BorderColor = System.Drawing.Color.Black;
            this.Crop.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Crop.BorderWidth = 1F;
            this.Crop.CanGrow = false;
            this.Crop.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Crop.ForeColor = System.Drawing.Color.Black;
            this.Crop.LocationFloat = new DevExpress.Utils.PointFloat(725F, 0F);
            this.Crop.Name = "Crop";
            this.Crop.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.Crop.SizeF = new System.Drawing.SizeF(42.70833F, 15.97222F);
            this.Crop.Text = "Crop #";
            this.Crop.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Line9
            // 
            this.Line9.BackColor = System.Drawing.Color.Transparent;
            this.Line9.BorderColor = System.Drawing.Color.Black;
            this.Line9.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.Line9.BorderWidth = 1F;
            this.Line9.ForeColor = System.Drawing.Color.Black;
            this.Line9.LocationFloat = new DevExpress.Utils.PointFloat(8.333333F, 16.66667F);
            this.Line9.Name = "Line9";
            this.Line9.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.Line9.SizeF = new System.Drawing.SizeF(1116.667F, 2F);
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.Transparent;
            this.Line1.BorderColor = System.Drawing.Color.Black;
            this.Line1.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.Line1.BorderWidth = 1F;
            this.Line1.ForeColor = System.Drawing.Color.Black;
            this.Line1.LocationFloat = new DevExpress.Utils.PointFloat(8.333333F, 125F);
            this.Line1.Name = "Line1";
            this.Line1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.Line1.SizeF = new System.Drawing.SizeF(1116.667F, 2F);
            // 
            // Line5
            // 
            this.Line5.BackColor = System.Drawing.Color.Transparent;
            this.Line5.BorderColor = System.Drawing.Color.Black;
            this.Line5.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.Line5.BorderWidth = 1F;
            this.Line5.ForeColor = System.Drawing.Color.Black;
            this.Line5.LocationFloat = new DevExpress.Utils.PointFloat(8.333333F, 0F);
            this.Line5.Name = "Line5";
            this.Line5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.Line5.SizeF = new System.Drawing.SizeF(1116.667F, 2F);
            // 
            // Line6
            // 
            this.Line6.BackColor = System.Drawing.Color.Transparent;
            this.Line6.BorderColor = System.Drawing.Color.Black;
            this.Line6.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.Line6.BorderWidth = 1F;
            this.Line6.ForeColor = System.Drawing.Color.Black;
            this.Line6.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.Line6.LocationFloat = new DevExpress.Utils.PointFloat(76.38889F, 16.66667F);
            this.Line6.Name = "Line6";
            this.Line6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.Line6.SizeF = new System.Drawing.SizeF(2F, 108.2639F);
            // 
            // Line8
            // 
            this.Line8.BackColor = System.Drawing.Color.Transparent;
            this.Line8.BorderColor = System.Drawing.Color.Black;
            this.Line8.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.Line8.BorderWidth = 1F;
            this.Line8.ForeColor = System.Drawing.Color.Black;
            this.Line8.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical;
            this.Line8.LocationFloat = new DevExpress.Utils.PointFloat(108.3333F, 16.66667F);
            this.Line8.Name = "Line8";
            this.Line8.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.Line8.SizeF = new System.Drawing.SizeF(2F, 108.3333F);
            // 
            // FlockNo
            // 
            this.FlockNo.BackColor = System.Drawing.Color.Transparent;
            this.FlockNo.BorderColor = System.Drawing.Color.Black;
            this.FlockNo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.FlockNo.BorderWidth = 1F;
            this.FlockNo.CanGrow = false;
            this.FlockNo.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.FlockNo.ForeColor = System.Drawing.Color.Black;
            this.FlockNo.LocationFloat = new DevExpress.Utils.PointFloat(28.125F, 19.16667F);
            this.FlockNo.Name = "FlockNo";
            this.FlockNo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.FlockNo.SizeF = new System.Drawing.SizeF(25F, 105.2778F);
            this.FlockNo.Text = "Flock No.";
            this.FlockNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // GroupFooterSection1
            // 
            this.GroupFooterSection1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.SumofrfFemaleStarted3,
            this.AvgofrfWeeKNo3,
            this.SumofDailyMort3,
            this.SumofDailCulls3,
            this.AvgofMortPercent3,
            this.AvgofCullsPercent3,
            this.AvgofMortStand3,
            this.AvgofCullsStand3,
            this.SumofCummMort3,
            this.SumofCummCulls3,
            this.AvgofCummMortPercent3,
            this.AvgofCummMortStand3,
            this.AvgofCummCullsPercent3,
            this.AvgofCummCullsStand3,
            this.SumofDepletion3,
            this.AvgofDepletionPercent3,
            this.SumofBalanceBirds3,
            this.AvgofrsFABW3,
            this.TotalAverage,
            this.Line3,
            this.GT_AvgBWStd_1});
            this.GroupFooterSection1.HeightF = 48F;
            this.GroupFooterSection1.KeepTogether = true;
            this.GroupFooterSection1.Name = "GroupFooterSection1";
            this.GroupFooterSection1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.GroupFooterSection1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupFooterSection3
            // 
            this.GroupFooterSection3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Vaccination,
            this.Subreport3});
            this.GroupFooterSection3.HeightF = 39.66666F;
            this.GroupFooterSection3.KeepTogether = true;
            this.GroupFooterSection3.Name = "GroupFooterSection3";
            this.GroupFooterSection3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.GroupFooterSection3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupFooterSection4
            // 
            this.GroupFooterSection4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Subreport4,
            this.Medication});
            this.GroupFooterSection4.HeightF = 39.66666F;
            this.GroupFooterSection4.KeepTogether = true;
            this.GroupFooterSection4.Name = "GroupFooterSection4";
            this.GroupFooterSection4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.GroupFooterSection4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // SumofrfFemaleStarted3
            // 
            this.SumofrfFemaleStarted3.BackColor = System.Drawing.Color.Transparent;
            this.SumofrfFemaleStarted3.BorderColor = System.Drawing.Color.Black;
            this.SumofrfFemaleStarted3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.SumofrfFemaleStarted3.BorderWidth = 1F;
            this.SumofrfFemaleStarted3.CanGrow = false;
            this.SumofrfFemaleStarted3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([rf_Female_Started])")});
            this.SumofrfFemaleStarted3.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.SumofrfFemaleStarted3.ForeColor = System.Drawing.Color.Black;
            this.SumofrfFemaleStarted3.LocationFloat = new DevExpress.Utils.PointFloat(175F, 4.166667F);
            this.SumofrfFemaleStarted3.Name = "SumofrfFemaleStarted3";
            this.SumofrfFemaleStarted3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.SumofrfFemaleStarted3.SizeF = new System.Drawing.SizeF(50F, 15.97222F);
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.SumofrfFemaleStarted3.Summary = xrSummary1;
            this.SumofrfFemaleStarted3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // AvgofrfWeeKNo3
            // 
            this.AvgofrfWeeKNo3.BackColor = System.Drawing.Color.Transparent;
            this.AvgofrfWeeKNo3.BorderColor = System.Drawing.Color.Black;
            this.AvgofrfWeeKNo3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.AvgofrfWeeKNo3.BorderWidth = 1F;
            this.AvgofrfWeeKNo3.CanGrow = false;
            this.AvgofrfWeeKNo3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumAvg([rf_WeeKNo])")});
            this.AvgofrfWeeKNo3.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.AvgofrfWeeKNo3.ForeColor = System.Drawing.Color.Black;
            this.AvgofrfWeeKNo3.LocationFloat = new DevExpress.Utils.PointFloat(233.3333F, 4.166667F);
            this.AvgofrfWeeKNo3.Name = "AvgofrfWeeKNo3";
            this.AvgofrfWeeKNo3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.AvgofrfWeeKNo3.SizeF = new System.Drawing.SizeF(33.33333F, 15.97222F);
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.AvgofrfWeeKNo3.Summary = xrSummary2;
            this.AvgofrfWeeKNo3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // SumofDailyMort3
            // 
            this.SumofDailyMort3.BackColor = System.Drawing.Color.Transparent;
            this.SumofDailyMort3.BorderColor = System.Drawing.Color.Black;
            this.SumofDailyMort3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.SumofDailyMort3.BorderWidth = 1F;
            this.SumofDailyMort3.CanGrow = false;
            this.SumofDailyMort3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([DailyMort])")});
            this.SumofDailyMort3.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.SumofDailyMort3.ForeColor = System.Drawing.Color.Black;
            this.SumofDailyMort3.LocationFloat = new DevExpress.Utils.PointFloat(325F, 4.166667F);
            this.SumofDailyMort3.Name = "SumofDailyMort3";
            this.SumofDailyMort3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.SumofDailyMort3.SizeF = new System.Drawing.SizeF(28.125F, 15.97222F);
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.SumofDailyMort3.Summary = xrSummary3;
            this.SumofDailyMort3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // SumofDailCulls3
            // 
            this.SumofDailCulls3.BackColor = System.Drawing.Color.Transparent;
            this.SumofDailCulls3.BorderColor = System.Drawing.Color.Black;
            this.SumofDailCulls3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.SumofDailCulls3.BorderWidth = 1F;
            this.SumofDailCulls3.CanGrow = false;
            this.SumofDailCulls3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([DailCulls])")});
            this.SumofDailCulls3.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.SumofDailCulls3.ForeColor = System.Drawing.Color.Black;
            this.SumofDailCulls3.LocationFloat = new DevExpress.Utils.PointFloat(533.3333F, 4.166667F);
            this.SumofDailCulls3.Name = "SumofDailCulls3";
            this.SumofDailCulls3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.SumofDailCulls3.SizeF = new System.Drawing.SizeF(30.20833F, 15.97222F);
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.SumofDailCulls3.Summary = xrSummary4;
            this.SumofDailCulls3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // AvgofMortPercent3
            // 
            this.AvgofMortPercent3.BackColor = System.Drawing.Color.Transparent;
            this.AvgofMortPercent3.BorderColor = System.Drawing.Color.Black;
            this.AvgofMortPercent3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.AvgofMortPercent3.BorderWidth = 1F;
            this.AvgofMortPercent3.CanGrow = false;
            this.AvgofMortPercent3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumAvg([@MortPercent])")});
            this.AvgofMortPercent3.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.AvgofMortPercent3.ForeColor = System.Drawing.Color.Black;
            this.AvgofMortPercent3.LocationFloat = new DevExpress.Utils.PointFloat(358.3333F, 4.166667F);
            this.AvgofMortPercent3.Name = "AvgofMortPercent3";
            this.AvgofMortPercent3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.AvgofMortPercent3.SizeF = new System.Drawing.SizeF(29.16667F, 15.97222F);
            xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.AvgofMortPercent3.Summary = xrSummary5;
            this.AvgofMortPercent3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // AvgofCullsPercent3
            // 
            this.AvgofCullsPercent3.BackColor = System.Drawing.Color.Transparent;
            this.AvgofCullsPercent3.BorderColor = System.Drawing.Color.Black;
            this.AvgofCullsPercent3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.AvgofCullsPercent3.BorderWidth = 1F;
            this.AvgofCullsPercent3.CanGrow = false;
            this.AvgofCullsPercent3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumAvg([@CullsPercent])")});
            this.AvgofCullsPercent3.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.AvgofCullsPercent3.ForeColor = System.Drawing.Color.Black;
            this.AvgofCullsPercent3.LocationFloat = new DevExpress.Utils.PointFloat(566.6667F, 4.166667F);
            this.AvgofCullsPercent3.Name = "AvgofCullsPercent3";
            this.AvgofCullsPercent3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.AvgofCullsPercent3.SizeF = new System.Drawing.SizeF(32.29167F, 15.97222F);
            xrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.AvgofCullsPercent3.Summary = xrSummary6;
            this.AvgofCullsPercent3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // AvgofMortStand3
            // 
            this.AvgofMortStand3.BackColor = System.Drawing.Color.Transparent;
            this.AvgofMortStand3.BorderColor = System.Drawing.Color.Black;
            this.AvgofMortStand3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.AvgofMortStand3.BorderWidth = 1F;
            this.AvgofMortStand3.CanGrow = false;
            this.AvgofMortStand3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumAvg([MortStand])")});
            this.AvgofMortStand3.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.AvgofMortStand3.ForeColor = System.Drawing.Color.Black;
            this.AvgofMortStand3.LocationFloat = new DevExpress.Utils.PointFloat(391.6667F, 4.166667F);
            this.AvgofMortStand3.Name = "AvgofMortStand3";
            this.AvgofMortStand3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.AvgofMortStand3.SizeF = new System.Drawing.SizeF(33.33333F, 15.97222F);
            xrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.AvgofMortStand3.Summary = xrSummary7;
            this.AvgofMortStand3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // AvgofCullsStand3
            // 
            this.AvgofCullsStand3.BackColor = System.Drawing.Color.Transparent;
            this.AvgofCullsStand3.BorderColor = System.Drawing.Color.Black;
            this.AvgofCullsStand3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.AvgofCullsStand3.BorderWidth = 1F;
            this.AvgofCullsStand3.CanGrow = false;
            this.AvgofCullsStand3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumAvg([CullsStand])")});
            this.AvgofCullsStand3.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.AvgofCullsStand3.ForeColor = System.Drawing.Color.Black;
            this.AvgofCullsStand3.LocationFloat = new DevExpress.Utils.PointFloat(600F, 4.166667F);
            this.AvgofCullsStand3.Name = "AvgofCullsStand3";
            this.AvgofCullsStand3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.AvgofCullsStand3.SizeF = new System.Drawing.SizeF(31.25F, 15.97222F);
            xrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.AvgofCullsStand3.Summary = xrSummary8;
            this.AvgofCullsStand3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // SumofCummMort3
            // 
            this.SumofCummMort3.BackColor = System.Drawing.Color.Transparent;
            this.SumofCummMort3.BorderColor = System.Drawing.Color.Black;
            this.SumofCummMort3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.SumofCummMort3.BorderWidth = 1F;
            this.SumofCummMort3.CanGrow = false;
            this.SumofCummMort3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([CummMort])")});
            this.SumofCummMort3.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.SumofCummMort3.ForeColor = System.Drawing.Color.Black;
            this.SumofCummMort3.LocationFloat = new DevExpress.Utils.PointFloat(427.0833F, 4.166667F);
            this.SumofCummMort3.Name = "SumofCummMort3";
            this.SumofCummMort3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.SumofCummMort3.SizeF = new System.Drawing.SizeF(35.41667F, 15.97222F);
            xrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.SumofCummMort3.Summary = xrSummary9;
            this.SumofCummMort3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // SumofCummCulls3
            // 
            this.SumofCummCulls3.BackColor = System.Drawing.Color.Transparent;
            this.SumofCummCulls3.BorderColor = System.Drawing.Color.Black;
            this.SumofCummCulls3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.SumofCummCulls3.BorderWidth = 1F;
            this.SumofCummCulls3.CanGrow = false;
            this.SumofCummCulls3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([CummCulls])")});
            this.SumofCummCulls3.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.SumofCummCulls3.ForeColor = System.Drawing.Color.Black;
            this.SumofCummCulls3.LocationFloat = new DevExpress.Utils.PointFloat(633.3333F, 4.166667F);
            this.SumofCummCulls3.Name = "SumofCummCulls3";
            this.SumofCummCulls3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.SumofCummCulls3.SizeF = new System.Drawing.SizeF(38.54167F, 15.97222F);
            xrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.SumofCummCulls3.Summary = xrSummary10;
            this.SumofCummCulls3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // AvgofCummMortPercent3
            // 
            this.AvgofCummMortPercent3.BackColor = System.Drawing.Color.Transparent;
            this.AvgofCummMortPercent3.BorderColor = System.Drawing.Color.Black;
            this.AvgofCummMortPercent3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.AvgofCummMortPercent3.BorderWidth = 1F;
            this.AvgofCummMortPercent3.CanGrow = false;
            this.AvgofCummMortPercent3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumAvg([@CummMortPercent])")});
            this.AvgofCummMortPercent3.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.AvgofCummMortPercent3.ForeColor = System.Drawing.Color.Black;
            this.AvgofCummMortPercent3.LocationFloat = new DevExpress.Utils.PointFloat(464.5833F, 4.166667F);
            this.AvgofCummMortPercent3.Name = "AvgofCummMortPercent3";
            this.AvgofCummMortPercent3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.AvgofCummMortPercent3.SizeF = new System.Drawing.SizeF(32.29167F, 15.97222F);
            xrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.AvgofCummMortPercent3.Summary = xrSummary11;
            this.AvgofCummMortPercent3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // AvgofCummMortStand3
            // 
            this.AvgofCummMortStand3.BackColor = System.Drawing.Color.Transparent;
            this.AvgofCummMortStand3.BorderColor = System.Drawing.Color.Black;
            this.AvgofCummMortStand3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.AvgofCummMortStand3.BorderWidth = 1F;
            this.AvgofCummMortStand3.CanGrow = false;
            this.AvgofCummMortStand3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumAvg([CummMortStand])")});
            this.AvgofCummMortStand3.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.AvgofCummMortStand3.ForeColor = System.Drawing.Color.Black;
            this.AvgofCummMortStand3.LocationFloat = new DevExpress.Utils.PointFloat(500F, 4.166667F);
            this.AvgofCummMortStand3.Name = "AvgofCummMortStand3";
            this.AvgofCummMortStand3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.AvgofCummMortStand3.SizeF = new System.Drawing.SizeF(31.25F, 15.97222F);
            xrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.AvgofCummMortStand3.Summary = xrSummary12;
            this.AvgofCummMortStand3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // AvgofCummCullsPercent3
            // 
            this.AvgofCummCullsPercent3.BackColor = System.Drawing.Color.Transparent;
            this.AvgofCummCullsPercent3.BorderColor = System.Drawing.Color.Black;
            this.AvgofCummCullsPercent3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.AvgofCummCullsPercent3.BorderWidth = 1F;
            this.AvgofCummCullsPercent3.CanGrow = false;
            this.AvgofCummCullsPercent3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumAvg([@CummCullsPercent])")});
            this.AvgofCummCullsPercent3.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.AvgofCummCullsPercent3.ForeColor = System.Drawing.Color.Black;
            this.AvgofCummCullsPercent3.LocationFloat = new DevExpress.Utils.PointFloat(675F, 4.166667F);
            this.AvgofCummCullsPercent3.Name = "AvgofCummCullsPercent3";
            this.AvgofCummCullsPercent3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.AvgofCummCullsPercent3.SizeF = new System.Drawing.SizeF(30.20833F, 15.97222F);
            xrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.AvgofCummCullsPercent3.Summary = xrSummary13;
            this.AvgofCummCullsPercent3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // AvgofCummCullsStand3
            // 
            this.AvgofCummCullsStand3.BackColor = System.Drawing.Color.Transparent;
            this.AvgofCummCullsStand3.BorderColor = System.Drawing.Color.Black;
            this.AvgofCummCullsStand3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.AvgofCummCullsStand3.BorderWidth = 1F;
            this.AvgofCummCullsStand3.CanGrow = false;
            this.AvgofCummCullsStand3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumAvg([CummCullsStand])")});
            this.AvgofCummCullsStand3.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.AvgofCummCullsStand3.ForeColor = System.Drawing.Color.Black;
            this.AvgofCummCullsStand3.LocationFloat = new DevExpress.Utils.PointFloat(708.3333F, 4.166667F);
            this.AvgofCummCullsStand3.Name = "AvgofCummCullsStand3";
            this.AvgofCummCullsStand3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.AvgofCummCullsStand3.SizeF = new System.Drawing.SizeF(35.41667F, 15.97222F);
            xrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.AvgofCummCullsStand3.Summary = xrSummary14;
            this.AvgofCummCullsStand3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // SumofDepletion3
            // 
            this.SumofDepletion3.BackColor = System.Drawing.Color.Transparent;
            this.SumofDepletion3.BorderColor = System.Drawing.Color.Black;
            this.SumofDepletion3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.SumofDepletion3.BorderWidth = 1F;
            this.SumofDepletion3.CanGrow = false;
            this.SumofDepletion3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([@Depletion])")});
            this.SumofDepletion3.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.SumofDepletion3.ForeColor = System.Drawing.Color.Black;
            this.SumofDepletion3.LocationFloat = new DevExpress.Utils.PointFloat(750F, 4.166667F);
            this.SumofDepletion3.Name = "SumofDepletion3";
            this.SumofDepletion3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.SumofDepletion3.SizeF = new System.Drawing.SizeF(35.41667F, 15.97222F);
            xrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.SumofDepletion3.Summary = xrSummary15;
            this.SumofDepletion3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // AvgofDepletionPercent3
            // 
            this.AvgofDepletionPercent3.BackColor = System.Drawing.Color.Transparent;
            this.AvgofDepletionPercent3.BorderColor = System.Drawing.Color.Black;
            this.AvgofDepletionPercent3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.AvgofDepletionPercent3.BorderWidth = 1F;
            this.AvgofDepletionPercent3.CanGrow = false;
            this.AvgofDepletionPercent3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumAvg([@DepletionPercent])")});
            this.AvgofDepletionPercent3.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.AvgofDepletionPercent3.ForeColor = System.Drawing.Color.Black;
            this.AvgofDepletionPercent3.LocationFloat = new DevExpress.Utils.PointFloat(791.6667F, 4.166667F);
            this.AvgofDepletionPercent3.Name = "AvgofDepletionPercent3";
            this.AvgofDepletionPercent3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.AvgofDepletionPercent3.SizeF = new System.Drawing.SizeF(29.16667F, 15.97222F);
            xrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.AvgofDepletionPercent3.Summary = xrSummary16;
            this.AvgofDepletionPercent3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // SumofBalanceBirds3
            // 
            this.SumofBalanceBirds3.BackColor = System.Drawing.Color.Transparent;
            this.SumofBalanceBirds3.BorderColor = System.Drawing.Color.Black;
            this.SumofBalanceBirds3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.SumofBalanceBirds3.BorderWidth = 1F;
            this.SumofBalanceBirds3.CanGrow = false;
            this.SumofBalanceBirds3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([BalanceBirds])")});
            this.SumofBalanceBirds3.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.SumofBalanceBirds3.ForeColor = System.Drawing.Color.Black;
            this.SumofBalanceBirds3.LocationFloat = new DevExpress.Utils.PointFloat(825F, 4.166667F);
            this.SumofBalanceBirds3.Name = "SumofBalanceBirds3";
            this.SumofBalanceBirds3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.SumofBalanceBirds3.SizeF = new System.Drawing.SizeF(58.33333F, 15.97222F);
            xrSummary17.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.SumofBalanceBirds3.Summary = xrSummary17;
            this.SumofBalanceBirds3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // AvgofrsFABW3
            // 
            this.AvgofrsFABW3.BackColor = System.Drawing.Color.Transparent;
            this.AvgofrsFABW3.BorderColor = System.Drawing.Color.Black;
            this.AvgofrsFABW3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.AvgofrsFABW3.BorderWidth = 1F;
            this.AvgofrsFABW3.CanGrow = false;
            this.AvgofrsFABW3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumAvg([rs_FABW])")});
            this.AvgofrsFABW3.Font = new DevExpress.Drawing.DXFont("Arial", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.AvgofrsFABW3.ForeColor = System.Drawing.Color.Black;
            this.AvgofrsFABW3.LocationFloat = new DevExpress.Utils.PointFloat(887.5F, 4.166667F);
            this.AvgofrsFABW3.Name = "AvgofrsFABW3";
            this.AvgofrsFABW3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.AvgofrsFABW3.SizeF = new System.Drawing.SizeF(42.70833F, 15.97222F);
            xrSummary18.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.AvgofrsFABW3.Summary = xrSummary18;
            this.AvgofrsFABW3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TotalAverage
            // 
            this.TotalAverage.BackColor = System.Drawing.Color.Transparent;
            this.TotalAverage.BorderColor = System.Drawing.Color.Black;
            this.TotalAverage.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.TotalAverage.BorderWidth = 1F;
            this.TotalAverage.CanGrow = false;
            this.TotalAverage.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.TotalAverage.ForeColor = System.Drawing.Color.Black;
            this.TotalAverage.LocationFloat = new DevExpress.Utils.PointFloat(16.66667F, 4.166667F);
            this.TotalAverage.Name = "TotalAverage";
            this.TotalAverage.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.TotalAverage.SizeF = new System.Drawing.SizeF(106.25F, 15.97222F);
            this.TotalAverage.Text = "Total & Average";
            this.TotalAverage.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Line3
            // 
            this.Line3.BackColor = System.Drawing.Color.Transparent;
            this.Line3.BorderColor = System.Drawing.Color.Black;
            this.Line3.Borders = DevExpress.XtraPrinting.BorderSide.Top;
            this.Line3.BorderWidth = 1F;
            this.Line3.ForeColor = System.Drawing.Color.Black;
            this.Line3.LocationFloat = new DevExpress.Utils.PointFloat(8.333333F, 25F);
            this.Line3.Name = "Line3";
            this.Line3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.Line3.SizeF = new System.Drawing.SizeF(1116.667F, 2F);
            // 
            // GT_AvgBWStd_1
            // 
            this.GT_AvgBWStd_1.BackColor = System.Drawing.Color.Transparent;
            this.GT_AvgBWStd_1.BorderColor = System.Drawing.Color.Black;
            this.GT_AvgBWStd_1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.GT_AvgBWStd_1.BorderWidth = 1F;
            this.GT_AvgBWStd_1.CanGrow = false;
            this.GT_AvgBWStd_1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[GT_AvgBWStd]")});
            this.GT_AvgBWStd_1.Font = new DevExpress.Drawing.DXFont("Arial", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GT_AvgBWStd_1.ForeColor = System.Drawing.Color.Black;
            this.GT_AvgBWStd_1.LocationFloat = new DevExpress.Utils.PointFloat(933.3333F, 4.166667F);
            this.GT_AvgBWStd_1.Name = "GT_AvgBWStd_1";
            this.GT_AvgBWStd_1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.GT_AvgBWStd_1.SizeF = new System.Drawing.SizeF(43.75F, 15.69444F);
            this.GT_AvgBWStd_1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Vaccination
            // 
            this.Vaccination.BackColor = System.Drawing.Color.Transparent;
            this.Vaccination.BorderColor = System.Drawing.Color.Black;
            this.Vaccination.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Vaccination.BorderWidth = 1F;
            this.Vaccination.CanGrow = false;
            this.Vaccination.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Vaccination.ForeColor = System.Drawing.Color.Black;
            this.Vaccination.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0.9722222F);
            this.Vaccination.Name = "Vaccination";
            this.Vaccination.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.Vaccination.SizeF = new System.Drawing.SizeF(1127.083F, 15.34722F);
            this.Vaccination.Text = "Vaccination:";
            this.Vaccination.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Subreport3
            // 
            this.Subreport3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 16.66667F);
            this.Subreport3.Name = "Subreport3";
            this.Subreport3.ReportSource = new DevExpress.XtraReports.UI.XtraReport();
            this.Subreport3.SizeF = new System.Drawing.SizeF(1127.083F, 16.11111F);
            // 
            // Subreport4
            // 
            this.Subreport4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 16.66667F);
            this.Subreport4.Name = "Subreport4";
            this.Subreport4.ReportSource = new DevExpress.XtraReports.UI.XtraReport();
            this.Subreport4.SizeF = new System.Drawing.SizeF(1127.083F, 16.11111F);
            // 
            // Medication
            // 
            this.Medication.BackColor = System.Drawing.Color.Transparent;
            this.Medication.BorderColor = System.Drawing.Color.Black;
            this.Medication.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Medication.BorderWidth = 1F;
            this.Medication.CanGrow = false;
            this.Medication.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Medication.ForeColor = System.Drawing.Color.Black;
            this.Medication.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Medication.Name = "Medication";
            this.Medication.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.Medication.SizeF = new System.Drawing.SizeF(1127.083F, 16.11111F);
            this.Medication.Text = "Medication:";
            this.Medication.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeaderSection2
            // 
            this.PageHeaderSection2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Subreport7});
            this.PageHeaderSection2.HeightF = 27F;
            this.PageHeaderSection2.KeepTogether = true;
            this.PageHeaderSection2.Name = "PageHeaderSection2";
            this.PageHeaderSection2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.PageHeaderSection2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Section2
            // 
            this.Section2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Date,
            this.Datee1,
            this.BookPerf_1,
            this.BookPerf_2});
            this.Section2.HeightF = 15F;
            this.Section2.KeepTogether = true;
            this.Section2.Name = "Section2";
            this.Section2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.Section2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Subreport7
            // 
            this.Subreport7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Subreport7.Name = "Subreport7";
            this.Subreport7.ReportSource = new DevExpress.XtraReports.UI.XtraReport();
            this.Subreport7.SizeF = new System.Drawing.SizeF(1133.333F, 27.77778F);
            // 
            // Date
            // 
            this.Date.BackColor = System.Drawing.Color.Transparent;
            this.Date.BorderColor = System.Drawing.Color.Black;
            this.Date.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Date.BorderWidth = 1F;
            this.Date.CanGrow = false;
            this.Date.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Date.ForeColor = System.Drawing.Color.Black;
            this.Date.LocationFloat = new DevExpress.Utils.PointFloat(8.333333F, 0F);
            this.Date.Name = "Date";
            this.Date.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.Date.SizeF = new System.Drawing.SizeF(41.66667F, 15.34722F);
            this.Date.Text = "Date:";
            this.Date.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Datee1
            // 
            this.Datee1.BackColor = System.Drawing.Color.Transparent;
            this.Datee1.BorderColor = System.Drawing.Color.Black;
            this.Datee1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Datee1.BorderWidth = 1F;
            this.Datee1.CanGrow = false;
            this.Datee1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?Datee")});
            this.Datee1.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.Datee1.ForeColor = System.Drawing.Color.Black;
            this.Datee1.LocationFloat = new DevExpress.Utils.PointFloat(50F, 0F);
            this.Datee1.Name = "Datee1";
            this.Datee1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.Datee1.SizeF = new System.Drawing.SizeF(175F, 15.34722F);
            this.Datee1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BookPerf_1
            // 
            this.BookPerf_1.BackColor = System.Drawing.Color.Transparent;
            this.BookPerf_1.BorderColor = System.Drawing.Color.Black;
            this.BookPerf_1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.BookPerf_1.BorderWidth = 1F;
            this.BookPerf_1.CanGrow = false;
            this.BookPerf_1.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.BookPerf_1.ForeColor = System.Drawing.Color.Black;
            this.BookPerf_1.LocationFloat = new DevExpress.Utils.PointFloat(237.5F, 0F);
            this.BookPerf_1.Name = "BookPerf_1";
            this.BookPerf_1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.BookPerf_1.SizeF = new System.Drawing.SizeF(59.72222F, 15.34722F);
            this.BookPerf_1.Text = "Std Book:";
            this.BookPerf_1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BookPerf_2
            // 
            this.BookPerf_2.BackColor = System.Drawing.Color.Transparent;
            this.BookPerf_2.BorderColor = System.Drawing.Color.Black;
            this.BookPerf_2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.BookPerf_2.BorderWidth = 1F;
            this.BookPerf_2.CanGrow = false;
            this.BookPerf_2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BookPerf]")});
            this.BookPerf_2.Font = new DevExpress.Drawing.DXFont("Arial", 9F, DevExpress.Drawing.DXFontStyle.Bold);
            this.BookPerf_2.ForeColor = System.Drawing.Color.Black;
            this.BookPerf_2.LocationFloat = new DevExpress.Utils.PointFloat(304.1667F, 0F);
            this.BookPerf_2.Name = "BookPerf_2";
            this.BookPerf_2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.BookPerf_2.SizeF = new System.Drawing.SizeF(138.5417F, 15.34722F);
            this.BookPerf_2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Section4
            // 
            this.Section4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Subreport1});
            this.Section4.HeightF = 16F;
            this.Section4.KeepTogether = true;
            this.Section4.Name = "Section4";
            this.Section4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.Section4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportFooterSection2
            // 
            this.ReportFooterSection2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Subreport2});
            this.ReportFooterSection2.HeightF = 16F;
            this.ReportFooterSection2.KeepTogether = true;
            this.ReportFooterSection2.Name = "ReportFooterSection2";
            this.ReportFooterSection2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.ReportFooterSection2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportFooterSection4
            // 
            this.ReportFooterSection4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.ReportNotes_1});
            this.ReportFooterSection4.HeightF = 41F;
            this.ReportFooterSection4.KeepTogether = true;
            this.ReportFooterSection4.Name = "ReportFooterSection4";
            this.ReportFooterSection4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.ReportFooterSection4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportFooterSection3
            // 
            this.ReportFooterSection3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Text5});
            this.ReportFooterSection3.HeightF = 17F;
            this.ReportFooterSection3.KeepTogether = true;
            this.ReportFooterSection3.Name = "ReportFooterSection3";
            this.ReportFooterSection3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.ReportFooterSection3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // SignatureReportFooterSection
            // 
            this.SignatureReportFooterSection.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Subreport5});
            this.SignatureReportFooterSection.HeightF = 22F;
            this.SignatureReportFooterSection.KeepTogether = true;
            this.SignatureReportFooterSection.Name = "SignatureReportFooterSection";
            this.SignatureReportFooterSection.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.SignatureReportFooterSection.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Subreport1
            // 
            this.Subreport1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Subreport1.Name = "Subreport1";
            this.Subreport1.ReportSource = new DevExpress.XtraReports.UI.XtraReport();
            this.Subreport1.SizeF = new System.Drawing.SizeF(1127.083F, 16.11111F);
            // 
            // Subreport2
            // 
            this.Subreport2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Subreport2.Name = "Subreport2";
            this.Subreport2.ReportSource = new DevExpress.XtraReports.UI.XtraReport();
            this.Subreport2.SizeF = new System.Drawing.SizeF(1127.083F, 16.11111F);
            // 
            // ReportNotes_1
            // 
            this.ReportNotes_1.BackColor = System.Drawing.Color.Transparent;
            this.ReportNotes_1.BorderColor = System.Drawing.Color.Black;
            this.ReportNotes_1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.ReportNotes_1.BorderWidth = 1F;
            this.ReportNotes_1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ReportNotes]")});
            this.ReportNotes_1.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.ReportNotes_1.ForeColor = System.Drawing.Color.Black;
            this.ReportNotes_1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.ReportNotes_1.Name = "ReportNotes_1";
            this.ReportNotes_1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.ReportNotes_1.SizeF = new System.Drawing.SizeF(1131.25F, 41.59722F);
            this.ReportNotes_1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Text5
            // 
            this.Text5.BackColor = System.Drawing.Color.Transparent;
            this.Text5.BorderColor = System.Drawing.Color.Black;
            this.Text5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Text5.BorderWidth = 1F;
            this.Text5.CanGrow = false;
            this.Text5.Font = new DevExpress.Drawing.DXFont("Arial", 8F);
            this.Text5.ForeColor = System.Drawing.Color.Black;
            this.Text5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2.222222F);
            this.Text5.Name = "Text5";
            this.Text5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.Text5.SizeF = new System.Drawing.SizeF(1131.25F, 15.27778F);
            this.Text5.Text = "{@FilterDataHeader}: {@FilterData}";
            this.Text5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Subreport5
            // 
            this.Subreport5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Subreport5.Name = "Subreport5";
            this.Subreport5.ReportSource = new DevExpress.XtraReports.UI.XtraReport();
            this.Subreport5.SizeF = new System.Drawing.SizeF(1131.25F, 22.22222F);
            // 
            // SignaturePageFooterSection
            // 
            this.SignaturePageFooterSection.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Subreport6});
            this.SignaturePageFooterSection.HeightF = 59F;
            this.SignaturePageFooterSection.KeepTogether = true;
            this.SignaturePageFooterSection.Name = "SignaturePageFooterSection";
            this.SignaturePageFooterSection.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.SignaturePageFooterSection.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.SignaturePageFooterSection.Visible = false;
            // 
            // Section5
            // 
            this.Section5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.PageNofM1,
            this.PrintTime1,
            this.PrintDate1});
            this.Section5.HeightF = 18F;
            this.Section5.KeepTogether = true;
            this.Section5.Name = "Section5";
            this.Section5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0F, 0F, 0F, 0F, 100F);
            this.Section5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Subreport6
            // 
            this.Subreport6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Subreport6.Name = "Subreport6";
            this.Subreport6.ReportSource = new DevExpress.XtraReports.UI.XtraReport();
            this.Subreport6.SizeF = new System.Drawing.SizeF(1131.25F, 59.72222F);
            // 
            // PageNofM1
            // 
            this.PageNofM1.BackColor = System.Drawing.Color.Transparent;
            this.PageNofM1.BorderColor = System.Drawing.Color.Black;
            this.PageNofM1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PageNofM1.BorderWidth = 1F;
            this.PageNofM1.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.PageNofM1.ForeColor = System.Drawing.Color.Black;
            this.PageNofM1.LocationFloat = new DevExpress.Utils.PointFloat(983.3333F, 2.361111F);
            this.PageNofM1.Name = "PageNofM1";
            this.PageNofM1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.PageNofM1.SizeF = new System.Drawing.SizeF(138.5417F, 15.69444F);
            this.PageNofM1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // PrintTime1
            // 
            this.PrintTime1.BackColor = System.Drawing.Color.Transparent;
            this.PrintTime1.BorderColor = System.Drawing.Color.Black;
            this.PrintTime1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PrintTime1.BorderWidth = 1F;
            this.PrintTime1.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.PrintTime1.ForeColor = System.Drawing.Color.Black;
            this.PrintTime1.LocationFloat = new DevExpress.Utils.PointFloat(516.6667F, 2.361111F);
            this.PrintTime1.Name = "PrintTime1";
            this.PrintTime1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.PrintTime1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.PrintTime1.SizeF = new System.Drawing.SizeF(100F, 15.69444F);
            this.PrintTime1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.PrintTime1.TextFormatString = "{0:t}";
            // 
            // PrintDate1
            // 
            this.PrintDate1.BackColor = System.Drawing.Color.Transparent;
            this.PrintDate1.BorderColor = System.Drawing.Color.Black;
            this.PrintDate1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PrintDate1.BorderWidth = 1F;
            this.PrintDate1.Font = new DevExpress.Drawing.DXFont("Arial", 10F);
            this.PrintDate1.ForeColor = System.Drawing.Color.Black;
            this.PrintDate1.LocationFloat = new DevExpress.Utils.PointFloat(8.333333F, 1.388889F);
            this.PrintDate1.Name = "PrintDate1";
            this.PrintDate1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.PrintDate1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.PrintDate1.SizeF = new System.Drawing.SizeF(167.7083F, 16.66667F);
            this.PrintDate1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // sqlDataSource1
            // 
          

            columnExpression1.ColumnName = "tFrFarmID";
            table1.Name = "SR_LAY_DailyReport";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "FarmCode";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "CropNo";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "FlockCode";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "HouseCode";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "rf_ActualDay";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "rf_WeeKNo";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "rf_PlaceDate";
            columnExpression8.Table = table1;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "rf_Female_Started";
            columnExpression9.Table = table1;
            column9.Expression = columnExpression9;
            columnExpression10.ColumnName = "LightHours";
            columnExpression10.Table = table1;
            column10.Expression = columnExpression10;
            columnExpression11.ColumnName = "LightStand";
            columnExpression11.Table = table1;
            column11.Expression = columnExpression11;
            columnExpression12.ColumnName = "WeekNo";
            columnExpression12.Table = table1;
            column12.Expression = columnExpression12;
            columnExpression13.ColumnName = "DailCulls";
            columnExpression13.Table = table1;
            column13.Expression = columnExpression13;
            columnExpression14.ColumnName = "rs_FABW";
            columnExpression14.Table = table1;
            column14.Expression = columnExpression14;
            columnExpression15.ColumnName = "rf_Day";
            columnExpression15.Table = table1;
            column15.Expression = columnExpression15;
            columnExpression16.ColumnName = "FeedIntake";
            columnExpression16.Table = table1;
            column16.Expression = columnExpression16;
            columnExpression17.ColumnName = "CummCullsStand";
            columnExpression17.Table = table1;
            column17.Expression = columnExpression17;
            columnExpression18.ColumnName = "BalanceBirds";
            columnExpression18.Table = table1;
            column18.Expression = columnExpression18;
            columnExpression19.ColumnName = "CummMortStand";
            columnExpression19.Table = table1;
            column19.Expression = columnExpression19;
            columnExpression20.ColumnName = "FeedStand";
            columnExpression20.Table = table1;
            column20.Expression = columnExpression20;
            columnExpression21.ColumnName = "CummMort";
            columnExpression21.Table = table1;
            column21.Expression = columnExpression21;
            columnExpression22.ColumnName = "MortStand";
            columnExpression22.Table = table1;
            column22.Expression = columnExpression22;
            columnExpression23.ColumnName = "CummCulls";
            columnExpression23.Table = table1;
            column23.Expression = columnExpression23;
            columnExpression24.ColumnName = "CullsStand";
            columnExpression24.Table = table1;
            column24.Expression = columnExpression24;
            columnExpression25.ColumnName = "BreedName_en";
            columnExpression25.Table = table1;
            column25.Expression = columnExpression25;
            columnExpression26.ColumnName = "BWStand";
            columnExpression26.Table = table1;
            column26.Expression = columnExpression26;
            columnExpression27.ColumnName = "MinFBWStd";
            columnExpression27.Table = table1;
            column27.Expression = columnExpression27;
            columnExpression28.ColumnName = "MaxFBWStd";
            columnExpression28.Table = table1;
            column28.Expression = columnExpression28;
            columnExpression29.ColumnName = "DailyMort";
            columnExpression29.Table = table1;
            column29.Expression = columnExpression29;
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
            selectQuery1.Columns.Add(column17);
            selectQuery1.Columns.Add(column18);
            selectQuery1.Columns.Add(column19);
            selectQuery1.Columns.Add(column20);
            selectQuery1.Columns.Add(column21);
            selectQuery1.Columns.Add(column22);
            selectQuery1.Columns.Add(column23);
            selectQuery1.Columns.Add(column24);
            selectQuery1.Columns.Add(column25);
            selectQuery1.Columns.Add(column26);
            selectQuery1.Columns.Add(column27);
            selectQuery1.Columns.Add(column28);
            selectQuery1.Columns.Add(column29);
            selectQuery1.Name = "SR_LAY_DailyReport";
            selectQuery1.Tables.Add(table1);
            

            // 
            // Line10
            // 
            this.Line10.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line10.EndBand = this.GroupFooterSection1;
            this.Line10.EndPointFloat = new DevExpress.Utils.PointFloat(8.333333F, 25F);
            this.Line10.ForeColor = System.Drawing.Color.Black;
            this.Line10.Name = "Line10";
            this.Line10.StartBand = this.GroupHeaderArea1;
            this.Line10.StartPointFloat = new DevExpress.Utils.PointFloat(8.333333F, 0F);
            this.Line10.WidthF = 1.041667F;
            // 
            // Line11
            // 
            this.Line11.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line11.EndBand = this.GroupFooterSection1;
            this.Line11.EndPointFloat = new DevExpress.Utils.PointFloat(175F, 25F);
            this.Line11.ForeColor = System.Drawing.Color.Black;
            this.Line11.Name = "Line11";
            this.Line11.StartBand = this.GroupHeaderArea1;
            this.Line11.StartPointFloat = new DevExpress.Utils.PointFloat(175F, 16.66667F);
            this.Line11.WidthF = 1.041667F;
            // 
            // Line12
            // 
            this.Line12.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line12.EndBand = this.GroupFooterSection1;
            this.Line12.EndPointFloat = new DevExpress.Utils.PointFloat(233.3333F, 25F);
            this.Line12.ForeColor = System.Drawing.Color.Black;
            this.Line12.Name = "Line12";
            this.Line12.StartBand = this.GroupHeaderArea1;
            this.Line12.StartPointFloat = new DevExpress.Utils.PointFloat(233.3333F, 16.66667F);
            this.Line12.WidthF = 1.041667F;
            // 
            // Line13
            // 
            this.Line13.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line13.EndBand = this.GroupFooterSection1;
            this.Line13.EndPointFloat = new DevExpress.Utils.PointFloat(266.6667F, 25F);
            this.Line13.ForeColor = System.Drawing.Color.Black;
            this.Line13.Name = "Line13";
            this.Line13.StartBand = this.GroupHeaderArea1;
            this.Line13.StartPointFloat = new DevExpress.Utils.PointFloat(266.6667F, 16.66667F);
            this.Line13.WidthF = 1.041667F;
            // 
            // Line14
            // 
            this.Line14.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line14.EndBand = this.GroupFooterSection1;
            this.Line14.EndPointFloat = new DevExpress.Utils.PointFloat(325F, 25F);
            this.Line14.ForeColor = System.Drawing.Color.Black;
            this.Line14.Name = "Line14";
            this.Line14.StartBand = this.GroupHeaderArea1;
            this.Line14.StartPointFloat = new DevExpress.Utils.PointFloat(325F, 16.66667F);
            this.Line14.WidthF = 1.041667F;
            // 
            // Line15
            // 
            this.Line15.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line15.EndBand = this.GroupFooterSection1;
            this.Line15.EndPointFloat = new DevExpress.Utils.PointFloat(358.3333F, 25F);
            this.Line15.ForeColor = System.Drawing.Color.Black;
            this.Line15.Name = "Line15";
            this.Line15.StartBand = this.GroupHeaderArea1;
            this.Line15.StartPointFloat = new DevExpress.Utils.PointFloat(358.3333F, 16.66667F);
            this.Line15.WidthF = 1.041667F;
            // 
            // Line16
            // 
            this.Line16.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line16.EndBand = this.GroupFooterSection1;
            this.Line16.EndPointFloat = new DevExpress.Utils.PointFloat(391.6667F, 25F);
            this.Line16.ForeColor = System.Drawing.Color.Black;
            this.Line16.Name = "Line16";
            this.Line16.StartBand = this.GroupHeaderArea1;
            this.Line16.StartPointFloat = new DevExpress.Utils.PointFloat(391.6667F, 16.66667F);
            this.Line16.WidthF = 1.041667F;
            // 
            // Line17
            // 
            this.Line17.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line17.EndBand = this.GroupFooterSection1;
            this.Line17.EndPointFloat = new DevExpress.Utils.PointFloat(426.3889F, 25F);
            this.Line17.ForeColor = System.Drawing.Color.Black;
            this.Line17.Name = "Line17";
            this.Line17.StartBand = this.GroupHeaderArea1;
            this.Line17.StartPointFloat = new DevExpress.Utils.PointFloat(426.3889F, 16.66667F);
            this.Line17.WidthF = 1.041667F;
            // 
            // Line18
            // 
            this.Line18.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line18.EndBand = this.GroupFooterSection1;
            this.Line18.EndPointFloat = new DevExpress.Utils.PointFloat(465.2778F, 25F);
            this.Line18.ForeColor = System.Drawing.Color.Black;
            this.Line18.Name = "Line18";
            this.Line18.StartBand = this.GroupHeaderArea1;
            this.Line18.StartPointFloat = new DevExpress.Utils.PointFloat(465.2778F, 16.66667F);
            this.Line18.WidthF = 1.041667F;
            // 
            // Line19
            // 
            this.Line19.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line19.EndBand = this.GroupFooterSection1;
            this.Line19.EndPointFloat = new DevExpress.Utils.PointFloat(500F, 25F);
            this.Line19.ForeColor = System.Drawing.Color.Black;
            this.Line19.Name = "Line19";
            this.Line19.StartBand = this.GroupHeaderArea1;
            this.Line19.StartPointFloat = new DevExpress.Utils.PointFloat(500F, 16.66667F);
            this.Line19.WidthF = 1.041667F;
            // 
            // Line20
            // 
            this.Line20.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line20.EndBand = this.GroupFooterSection1;
            this.Line20.EndPointFloat = new DevExpress.Utils.PointFloat(533.3333F, 25F);
            this.Line20.ForeColor = System.Drawing.Color.Black;
            this.Line20.Name = "Line20";
            this.Line20.StartBand = this.GroupHeaderArea1;
            this.Line20.StartPointFloat = new DevExpress.Utils.PointFloat(533.3333F, 16.66667F);
            this.Line20.WidthF = 1.041667F;
            // 
            // Line21
            // 
            this.Line21.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line21.EndBand = this.GroupFooterSection1;
            this.Line21.EndPointFloat = new DevExpress.Utils.PointFloat(566.6667F, 25F);
            this.Line21.ForeColor = System.Drawing.Color.Black;
            this.Line21.Name = "Line21";
            this.Line21.StartBand = this.GroupHeaderArea1;
            this.Line21.StartPointFloat = new DevExpress.Utils.PointFloat(566.6667F, 16.66667F);
            this.Line21.WidthF = 1.041667F;
            // 
            // Line24
            // 
            this.Line24.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line24.EndBand = this.GroupFooterSection1;
            this.Line24.EndPointFloat = new DevExpress.Utils.PointFloat(600F, 25F);
            this.Line24.ForeColor = System.Drawing.Color.Black;
            this.Line24.Name = "Line24";
            this.Line24.StartBand = this.GroupHeaderArea1;
            this.Line24.StartPointFloat = new DevExpress.Utils.PointFloat(600F, 16.66667F);
            this.Line24.WidthF = 1.041667F;
            // 
            // Line25
            // 
            this.Line25.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line25.EndBand = this.GroupFooterSection1;
            this.Line25.EndPointFloat = new DevExpress.Utils.PointFloat(633.3333F, 25F);
            this.Line25.ForeColor = System.Drawing.Color.Black;
            this.Line25.Name = "Line25";
            this.Line25.StartBand = this.GroupHeaderArea1;
            this.Line25.StartPointFloat = new DevExpress.Utils.PointFloat(633.3333F, 16.66667F);
            this.Line25.WidthF = 1.041667F;
            // 
            // Line26
            // 
            this.Line26.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line26.EndBand = this.GroupFooterSection1;
            this.Line26.EndPointFloat = new DevExpress.Utils.PointFloat(675F, 25F);
            this.Line26.ForeColor = System.Drawing.Color.Black;
            this.Line26.Name = "Line26";
            this.Line26.StartBand = this.GroupHeaderArea1;
            this.Line26.StartPointFloat = new DevExpress.Utils.PointFloat(675F, 16.66667F);
            this.Line26.WidthF = 1.041667F;
            // 
            // Line27
            // 
            this.Line27.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line27.EndBand = this.GroupFooterSection1;
            this.Line27.EndPointFloat = new DevExpress.Utils.PointFloat(708.3333F, 25F);
            this.Line27.ForeColor = System.Drawing.Color.Black;
            this.Line27.Name = "Line27";
            this.Line27.StartBand = this.GroupHeaderArea1;
            this.Line27.StartPointFloat = new DevExpress.Utils.PointFloat(708.3333F, 16.66667F);
            this.Line27.WidthF = 1.041667F;
            // 
            // Line29
            // 
            this.Line29.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line29.EndBand = this.GroupFooterSection1;
            this.Line29.EndPointFloat = new DevExpress.Utils.PointFloat(750F, 25F);
            this.Line29.ForeColor = System.Drawing.Color.Black;
            this.Line29.Name = "Line29";
            this.Line29.StartBand = this.GroupHeaderArea1;
            this.Line29.StartPointFloat = new DevExpress.Utils.PointFloat(750F, 16.66667F);
            this.Line29.WidthF = 1.041667F;
            // 
            // Line30
            // 
            this.Line30.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line30.EndBand = this.GroupFooterSection1;
            this.Line30.EndPointFloat = new DevExpress.Utils.PointFloat(791.6667F, 25F);
            this.Line30.ForeColor = System.Drawing.Color.Black;
            this.Line30.Name = "Line30";
            this.Line30.StartBand = this.GroupHeaderArea1;
            this.Line30.StartPointFloat = new DevExpress.Utils.PointFloat(791.6667F, 16.66667F);
            this.Line30.WidthF = 1.041667F;
            // 
            // Line31
            // 
            this.Line31.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line31.EndBand = this.GroupFooterSection1;
            this.Line31.EndPointFloat = new DevExpress.Utils.PointFloat(825F, 25F);
            this.Line31.ForeColor = System.Drawing.Color.Black;
            this.Line31.Name = "Line31";
            this.Line31.StartBand = this.GroupHeaderArea1;
            this.Line31.StartPointFloat = new DevExpress.Utils.PointFloat(825F, 16.66667F);
            this.Line31.WidthF = 1.041667F;
            // 
            // Line32
            // 
            this.Line32.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line32.EndBand = this.GroupFooterSection1;
            this.Line32.EndPointFloat = new DevExpress.Utils.PointFloat(886.1111F, 25F);
            this.Line32.ForeColor = System.Drawing.Color.Black;
            this.Line32.Name = "Line32";
            this.Line32.StartBand = this.GroupHeaderArea1;
            this.Line32.StartPointFloat = new DevExpress.Utils.PointFloat(886.1111F, 16.66667F);
            this.Line32.WidthF = 1.041667F;
            // 
            // Line33
            // 
            this.Line33.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line33.EndBand = this.GroupFooterSection1;
            this.Line33.EndPointFloat = new DevExpress.Utils.PointFloat(933.3333F, 25F);
            this.Line33.ForeColor = System.Drawing.Color.Black;
            this.Line33.Name = "Line33";
            this.Line33.StartBand = this.GroupHeaderArea1;
            this.Line33.StartPointFloat = new DevExpress.Utils.PointFloat(933.3333F, 16.66667F);
            this.Line33.WidthF = 1.041667F;
            // 
            // Line28
            // 
            this.Line28.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line28.EndBand = this.GroupFooterSection1;
            this.Line28.EndPointFloat = new DevExpress.Utils.PointFloat(977.7778F, 25F);
            this.Line28.ForeColor = System.Drawing.Color.Black;
            this.Line28.Name = "Line28";
            this.Line28.StartBand = this.GroupHeaderArea1;
            this.Line28.StartPointFloat = new DevExpress.Utils.PointFloat(977.7778F, 16.66667F);
            this.Line28.WidthF = 1.041667F;
            // 
            // Line34
            // 
            this.Line34.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line34.EndBand = this.GroupFooterSection1;
            this.Line34.EndPointFloat = new DevExpress.Utils.PointFloat(1011.111F, 25F);
            this.Line34.ForeColor = System.Drawing.Color.Black;
            this.Line34.Name = "Line34";
            this.Line34.StartBand = this.GroupHeaderArea1;
            this.Line34.StartPointFloat = new DevExpress.Utils.PointFloat(1011.111F, 16.66667F);
            this.Line34.WidthF = 1.041667F;
            // 
            // Line35
            // 
            this.Line35.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line35.EndBand = this.GroupFooterSection1;
            this.Line35.EndPointFloat = new DevExpress.Utils.PointFloat(1041.667F, 25F);
            this.Line35.ForeColor = System.Drawing.Color.Black;
            this.Line35.Name = "Line35";
            this.Line35.StartBand = this.GroupHeaderArea1;
            this.Line35.StartPointFloat = new DevExpress.Utils.PointFloat(1041.667F, 16.66667F);
            this.Line35.WidthF = 1.041667F;
            // 
            // Line36
            // 
            this.Line36.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line36.EndBand = this.GroupFooterSection1;
            this.Line36.EndPointFloat = new DevExpress.Utils.PointFloat(1083.333F, 25F);
            this.Line36.ForeColor = System.Drawing.Color.Black;
            this.Line36.Name = "Line36";
            this.Line36.StartBand = this.GroupHeaderArea1;
            this.Line36.StartPointFloat = new DevExpress.Utils.PointFloat(1083.333F, 16.66667F);
            this.Line36.WidthF = 1.041667F;
            // 
            // Line37
            // 
            this.Line37.AnchorVertical = ((DevExpress.XtraReports.UI.VerticalAnchorStyles)((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom)));
            this.Line37.EndBand = this.GroupFooterSection1;
            this.Line37.EndPointFloat = new DevExpress.Utils.PointFloat(1125F, 25F);
            this.Line37.ForeColor = System.Drawing.Color.Black;
            this.Line37.Name = "Line37";
            this.Line37.StartBand = this.GroupHeaderArea1;
            this.Line37.StartPointFloat = new DevExpress.Utils.PointFloat(1125F, 0F);
            this.Line37.WidthF = 1.041667F;
            // 
            // ReportName
            // 
            this.ReportName.DataMember = "SR_LAY_DailyReport";
            this.ReportName.Expression = "PadLeft(\'\', 10)";
            this.ReportName.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.ReportName.Name = "ReportName";
            // 
            // MortPercent
            // 
            this.MortPercent.DataMember = "SR_LAY_DailyReport";
            this.MortPercent.Expression = "Iif([rf_Female_Started] <> 0, [DailyMort] / [rf_Female_Started] * 100, null)";
            this.MortPercent.FieldType = DevExpress.XtraReports.UI.FieldType.Int32;
            this.MortPercent.Name = "MortPercent";
            // 
            // CummMortPercent
            // 
            this.CummMortPercent.DataMember = "SR_LAY_DailyReport";
            this.CummMortPercent.Expression = "Iif([rf_Female_Started] <> 0, [CummMort] / [rf_Female_Started] * 100, null)";
            this.CummMortPercent.FieldType = DevExpress.XtraReports.UI.FieldType.Int32;
            this.CummMortPercent.Name = "CummMortPercent";
            // 
            // CullsPercent
            // 
            this.CullsPercent.DataMember = "SR_LAY_DailyReport";
            this.CullsPercent.Expression = "Iif([rf_Female_Started] <> 0, [DailCulls] / [rf_Female_Started] * 100, null)";
            this.CullsPercent.FieldType = DevExpress.XtraReports.UI.FieldType.Int32;
            this.CullsPercent.Name = "CullsPercent";
            // 
            // CummCullsPercent
            // 
            this.CummCullsPercent.DataMember = "SR_LAY_DailyReport";
            this.CummCullsPercent.Expression = "Iif([rf_Female_Started] <> 0, [CummCulls] / [rf_Female_Started] * 100, null)";
            this.CummCullsPercent.FieldType = DevExpress.XtraReports.UI.FieldType.Int32;
            this.CummCullsPercent.Name = "CummCullsPercent";
            // 
            // Depletion
            // 
            this.Depletion.DataMember = "SR_LAY_DailyReport";
            this.Depletion.Expression = "[DailyMort] + [DailCulls]";
            this.Depletion.FieldType = DevExpress.XtraReports.UI.FieldType.Int32;
            this.Depletion.Name = "Depletion";
            // 
            // DepletionPercent
            // 
            this.DepletionPercent.DataMember = "SR_LAY_DailyReport";
            this.DepletionPercent.Expression = "Iif([rf_Female_Started] <> 0, [Depletion] / [rf_Female_Started] * 100, null)";
            this.DepletionPercent.FieldType = DevExpress.XtraReports.UI.FieldType.Int32;
            this.DepletionPercent.Name = "DepletionPercent";
            // 
            // LogoPath
            // 
            this.LogoPath.DataMember = "SR_LAY_DailyReport";
            this.LogoPath.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.LogoPath.Name = "LogoPath";
            // 
            // ModuleName_en
            // 
            this.ModuleName_en.DataMember = "SR_LAY_DailyReport";
            this.ModuleName_en.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.ModuleName_en.Name = "ModuleName_en";
            // 
            // CompanyName_en
            // 
            this.CompanyName_en.DataMember = "SR_LAY_DailyReport";
            this.CompanyName_en.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.CompanyName_en.Name = "CompanyName_en";
            // 
            // ReportPQP
            // 
            this.ReportPQP.DataMember = "SR_LAY_DailyReport";
            this.ReportPQP.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.ReportPQP.Name = "ReportPQP";
            // 
            // ModuleName_ar
            // 
            this.ModuleName_ar.DataMember = "SR_LAY_DailyReport";
            this.ModuleName_ar.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.ModuleName_ar.Name = "ModuleName_ar";
            // 
            // CompanyName_ar
            // 
            this.CompanyName_ar.DataMember = "SR_LAY_DailyReport";
            this.CompanyName_ar.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.CompanyName_ar.Name = "CompanyName_ar";
            // 
            // BookPerf
            // 
            this.BookPerf.DataMember = "SR_LAY_DailyReport";
            this.BookPerf.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.BookPerf.Name = "BookPerf";
            // 
            // ShowSignature
            // 
            this.ShowSignature.DataMember = "SR_LAY_DailyReport";
            this.ShowSignature.Expression = "False";
            this.ShowSignature.FieldType = DevExpress.XtraReports.UI.FieldType.Boolean;
            this.ShowSignature.Name = "ShowSignature";
            // 
            // ShowSignatureAllPages
            // 
            this.ShowSignatureAllPages.DataMember = "SR_LAY_DailyReport";
            this.ShowSignatureAllPages.Expression = "False";
            this.ShowSignatureAllPages.FieldType = DevExpress.XtraReports.UI.FieldType.Boolean;
            this.ShowSignatureAllPages.Name = "ShowSignatureAllPages";
            // 
            // ReportNotes
            // 
            this.ReportNotes.DataMember = "SR_LAY_DailyReport";
            this.ReportNotes.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.ReportNotes.Name = "ReportNotes";
            // 
            // FilterDataHeader
            // 
            this.FilterDataHeader.DataMember = "SR_LAY_DailyReport";
            this.FilterDataHeader.Expression = "\'Filter Data\'";
            this.FilterDataHeader.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.FilterDataHeader.Name = "FilterDataHeader";
            // 
            // FilterData
            // 
            this.FilterData.DataMember = "SR_LAY_DailyReport";
            this.FilterData.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.FilterData.Name = "FilterData";
            // 
            // GT_AvgBWStd
            // 
            this.GT_AvgBWStd.DataMember = "SR_LAY_DailyReport";
            this.GT_AvgBWStd.Expression = "FormatString(\'{0:0}\', Iif(True, \'#NOT_SUPPORTED#\', \'average([SR_LAY_DailyReport.M" +
    "inFBWStd])\')) + \'-\' + FormatString(\'{0:0}\', Iif(True, \'#NOT_SUPPORTED#\', \'averag" +
    "e([SR_LAY_DailyReport.MaxFBWStd])\'))";
            this.GT_AvgBWStd.FieldType = DevExpress.XtraReports.UI.FieldType.String;
            this.GT_AvgBWStd.Name = "GT_AvgBWStd";
            // 
            // Datee
            // 
            this.Datee.Description = "Enter Datee:";
            this.Datee.Name = "Datee";
            this.Datee.Visible = false;
            // 
            // Test
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Area3,
            this.GroupHeaderArea1,
            this.GroupFooterArea1,
            this.Area1,
            this.Area2,
            this.Area4,
            this.Area5});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.ReportName,
            this.MortPercent,
            this.CummMortPercent,
            this.CullsPercent,
            this.CummCullsPercent,
            this.Depletion,
            this.DepletionPercent,
            this.LogoPath,
            this.ModuleName_en,
            this.CompanyName_en,
            this.ReportPQP,
            this.ModuleName_ar,
            this.CompanyName_ar,
            this.BookPerf,
            this.ShowSignature,
            this.ShowSignatureAllPages,
            this.ReportNotes,
            this.FilterDataHeader,
            this.FilterData,
            this.GT_AvgBWStd});
            
            this.CrossBandControls.AddRange(new DevExpress.XtraReports.UI.XRCrossBandControl[] {
            this.Line10,
            this.Line11,
            this.Line12,
            this.Line13,
            this.Line14,
            this.Line15,
            this.Line16,
            this.Line17,
            this.Line18,
            this.Line19,
            this.Line20,
            this.Line21,
            this.Line24,
            this.Line25,
            this.Line26,
            this.Line27,
            this.Line29,
            this.Line30,
            this.Line31,
            this.Line32,
            this.Line33,
            this.Line28,
            this.Line34,
            this.Line35,
            this.Line36,
            this.Line37});
            this.DataMember = "SR_LAY_DailyReport";

            this.Landscape = true;
            this.Margins = new DevExpress.Drawing.DXMargins(16F, 16F, 16F, 16F);
            this.PageHeightF = 826.7717F;
            this.PageWidthF = 1169.291F;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.Datee});
            this.Version = "25.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion
    }
}
