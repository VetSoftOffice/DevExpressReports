namespace DevExpressReports.Reports.FeedFormulation.Nutrient.RationResIngNut_Nut
{
    partial class RationResIngNut_Nut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RationResIngNut_Nut));
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition crossTabColumnDefinition1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(150.3472F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField crossTabColumnField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabDataField crossTabDataField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition crossTabRowDefinition1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
            DevExpress.XtraReports.Parameters.GroupLayoutItem groupLayoutItem1 = new DevExpress.XtraReports.Parameters.GroupLayoutItem("", false);
            DevExpress.XtraReports.Parameters.GroupLayoutItem groupLayoutItem2 = new DevExpress.XtraReports.Parameters.GroupLayoutItem("", true);
            this.ShowSignature = new DevExpress.XtraReports.Parameters.Parameter();
            this.ShowSignatureAllPages = new DevExpress.XtraReports.Parameters.Parameter();
            this.HideReportHeader = new DevExpress.XtraReports.Parameters.Parameter();
            this.HideReportFooter = new DevExpress.XtraReports.Parameters.Parameter();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.PageHeaderSub1 = new DevExpress.XtraReports.UI.SubBand();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
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
            this.Sa = new DevExpress.XtraReports.UI.CalculatedField();
            this.IsRTL = new DevExpress.XtraReports.Parameters.Parameter();
            this.IsCustomReportFooter = new DevExpress.XtraReports.Parameters.Parameter();
            this.IsCustomReportHeader = new DevExpress.XtraReports.Parameters.Parameter();
            this.NoOfGroupsPerPage = new DevExpress.XtraReports.Parameters.Parameter();
            this.FontSize = new DevExpress.XtraReports.Parameters.Parameter();
            this.DateFrom = new DevExpress.XtraReports.Parameters.Parameter();
            this.SheetNo = new DevExpress.XtraReports.Parameters.Parameter();
            this.DateTo = new DevExpress.XtraReports.Parameters.Parameter();
            this.dsBreeder = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.dsFinance1 = new DevExpressReports.Reports.Finance.DataSets.dsFinance();
            this.sR_FM_RationResult_NutTableAdapter = new DevExpressReports.Reports.Finance.DataSets.dsFinanceTableAdapters.SR_FM_RationResult_NutTableAdapter();
            this.NutQuantityValue = new DevExpress.XtraReports.UI.CalculatedField();
            this.IsShowDM = new DevExpress.XtraReports.Parameters.Parameter();
            this.IsPer = new DevExpress.XtraReports.Parameters.Parameter();
            this.crossTabTotalStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabHeaderStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabDataStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabGeneralStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
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
            this.crossTabGeneralStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabHeaderStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabDataStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabTotalStyle2 = new DevExpress.XtraReports.UI.XRControlStyle();
            ((System.ComponentModel.ISupportInitialize)(this.dsFinance1)).BeginInit();
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
            this.BottomMargin.Name = "BottomMargin";
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
            // 
            // PageHeader
            // 
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.PageHeaderSub1});
            // 
            // PageHeaderSub1
            // 
            this.PageHeaderSub1.Name = "PageHeaderSub1";
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
            // Sa
            // 
            this.Sa.DataMember = "SR_FR_PH_PestControl";
            this.Sa.Expression = "Iif([DoneAction] == 1, \'√\', Char(168))";
            this.Sa.Name = "Sa";
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
            // dsBreeder
            // 
            this.dsBreeder.ConnectionName = "dsBreeder";
            this.dsBreeder.Name = "dsBreeder";
            columnExpression1.ColumnName = "Place";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"200\" Height=\"163\" />";
            table1.Name = "SR_FR_PH_PestControl";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "PestType";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "PestAction";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "TypeDone";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "DoneAction";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Name = "SR_FR_PH_PestControl";
            selectQuery1.Tables.Add(table1);
            this.dsBreeder.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.dsBreeder.ResultSchemaSerializable = resources.GetString("dsBreeder.ResultSchemaSerializable");
            // 
            // dsFinance1
            // 
            this.dsFinance1.DataSetName = "dsFinance";
            this.dsFinance1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sR_FM_RationResult_NutTableAdapter
            // 
            this.sR_FM_RationResult_NutTableAdapter.ClearBeforeFill = true;
            // 
            // NutQuantityValue
            // 
            this.NutQuantityValue.DataMember = "SR_FM_RationResult_Nut";
            this.NutQuantityValue.Expression = "Iif(?IsShowDM, [Quantity_DM], [Quantity])\n";
            this.NutQuantityValue.Name = "NutQuantityValue";
            // 
            // IsShowDM
            // 
            this.IsShowDM.Name = "IsShowDM";
            this.IsShowDM.Type = typeof(bool);
            this.IsShowDM.ValueInfo = "False";
            this.IsShowDM.Visible = false;
            // 
            // IsPer
            // 
            this.IsPer.Name = "IsPer";
            this.IsPer.Type = typeof(bool);
            this.IsPer.ValueInfo = "False";
            this.IsPer.Visible = false;
            // 
            // crossTabTotalStyle1
            // 
            this.crossTabTotalStyle1.Name = "crossTabTotalStyle1";
            this.crossTabTotalStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
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
            this.crossTabGeneralStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCrossTab1});
            this.ReportFooter.Name = "ReportFooter";
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
            this.crossTabTotalCell3});
            crossTabColumnDefinition1.Visible = false;
            this.xrCrossTab1.ColumnDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition[] {
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(181.5972F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(150.3472F),
            crossTabColumnDefinition1});
            crossTabColumnField1.FieldName = "RationName";
            this.xrCrossTab1.ColumnFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField[] {
            crossTabColumnField1});
            this.xrCrossTab1.DataAreaStyleName = "crossTabDataStyle2";
            crossTabDataField1.FieldName = "NutQuantityValue";
            this.xrCrossTab1.DataFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField[] {
            crossTabDataField1});
            this.xrCrossTab1.DataMember = "SR_FM_RationResult_Nut";
            this.xrCrossTab1.DataSource = this.dsFinance1;
            this.xrCrossTab1.GeneralStyleName = "crossTabGeneralStyle2";
            this.xrCrossTab1.HeaderAreaStyleName = "crossTabHeaderStyle2";
            this.xrCrossTab1.Name = "xrCrossTab1";
            this.xrCrossTab1.Parameters.AddRange(new DevExpress.XtraReports.UI.XRControlParameter[] {
            new DevExpress.XtraReports.UI.XRControlParameter("IsRTL", this.IsRTL)});
            crossTabRowDefinition1.Visible = false;
            this.xrCrossTab1.RowDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition[] {
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
            crossTabRowDefinition1});
            crossTabRowField1.FieldName = "NutrientName";
            this.xrCrossTab1.RowFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField[] {
            crossTabRowField1});
            this.xrCrossTab1.TotalAreaStyleName = "crossTabTotalStyle2";
            // 
            // crossTabHeaderCell1
            // 
            this.crossTabHeaderCell1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.crossTabHeaderCell1.BorderColor = System.Drawing.Color.DarkGray;
            this.crossTabHeaderCell1.BorderWidth = 1.3F;
            this.crossTabHeaderCell1.ColumnIndex = 0;
            this.crossTabHeaderCell1.Name = "crossTabHeaderCell1";
            this.crossTabHeaderCell1.RowIndex = 0;
            this.crossTabHeaderCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabDataCell1
            // 
            this.crossTabDataCell1.BorderColor = System.Drawing.Color.DarkGray;
            this.crossTabDataCell1.BorderWidth = 1F;
            this.crossTabDataCell1.ColumnIndex = 1;
            this.crossTabDataCell1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "TextAlignment", "Iif(?IsRTL == True, \'MiddleLeft\', \'MiddleRight\')\n")});
            this.crossTabDataCell1.Name = "crossTabDataCell1";
            this.crossTabDataCell1.RowIndex = 1;
            // 
            // crossTabHeaderCell2
            // 
            this.crossTabHeaderCell2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.crossTabHeaderCell2.BorderColor = System.Drawing.Color.DarkGray;
            this.crossTabHeaderCell2.BorderWidth = 1.3F;
            this.crossTabHeaderCell2.ColumnIndex = 1;
            this.crossTabHeaderCell2.Name = "crossTabHeaderCell2";
            this.crossTabHeaderCell2.RowIndex = 0;
            this.crossTabHeaderCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabHeaderCell3
            // 
            this.crossTabHeaderCell3.BackColor = System.Drawing.Color.White;
            this.crossTabHeaderCell3.BorderColor = System.Drawing.Color.DarkGray;
            this.crossTabHeaderCell3.BorderWidth = 1F;
            this.crossTabHeaderCell3.ColumnIndex = 0;
            this.crossTabHeaderCell3.Name = "crossTabHeaderCell3";
            this.crossTabHeaderCell3.RowIndex = 1;
            this.crossTabHeaderCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabHeaderCell4
            // 
            this.crossTabHeaderCell4.ColumnIndex = 0;
            this.crossTabHeaderCell4.Name = "crossTabHeaderCell4";
            this.crossTabHeaderCell4.RowIndex = 2;
            // 
            // crossTabTotalCell1
            // 
            this.crossTabTotalCell1.ColumnIndex = 1;
            this.crossTabTotalCell1.Name = "crossTabTotalCell1";
            this.crossTabTotalCell1.RowIndex = 2;
            // 
            // crossTabHeaderCell5
            // 
            this.crossTabHeaderCell5.ColumnIndex = 2;
            this.crossTabHeaderCell5.Name = "crossTabHeaderCell5";
            this.crossTabHeaderCell5.RowIndex = 0;
            // 
            // crossTabTotalCell2
            // 
            this.crossTabTotalCell2.ColumnIndex = 2;
            this.crossTabTotalCell2.Name = "crossTabTotalCell2";
            this.crossTabTotalCell2.RowIndex = 1;
            // 
            // crossTabTotalCell3
            // 
            this.crossTabTotalCell3.ColumnIndex = 2;
            this.crossTabTotalCell3.Name = "crossTabTotalCell3";
            this.crossTabTotalCell3.RowIndex = 2;
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
            this.crossTabGeneralStyle2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
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
            // RationResIngNut_Nut
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
            this.Sa,
            this.NutQuantityValue});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dsBreeder,
            this.dsFinance1});
            this.DataMember = "SR_FM_RationResult_Nut";
            this.DataSource = this.dsFinance1;
            this.ExportOptions.Pdf.DocumentOptions.Author = "VetSoft";
            this.LocalizationItems.AddRange(new DevExpress.XtraReports.Localization.LocalizationItem[] {
            new DevExpress.XtraReports.Localization.LocalizationItem(this.BottomMargin, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabDataCell1, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabDataCell1, "Default", "TextFormatString", "{0:N2}"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell1, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell1, "Default", "Text", "Nutrient Name"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell1, "ar", "Text", "العنصر"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell2, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell3, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell4, "Default", "Text", "Grand Total"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.crossTabHeaderCell5, "Default", "Text", "Grand Total"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateFrom, "Default", "Description", "From"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateFrom, "ar", "Description", "من"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.DateTo, "Default", "Description", "DateTo"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.Detail, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.FontSize, "Default", "Description", "Font Size"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.FontSize, "ar", "Description", "حجم الخط"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.HideReportFooter, "Default", "Description", "Hide report footer"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.HideReportFooter, "ar", "Description", "إخفاء ذيل التقرير"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.HideReportHeader, "Default", "Description", "Hide report header"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.HideReportHeader, "ar", "Description", "إخفاء رأس التقرير"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.IsCustomReportFooter, "Default", "Description", "IsCustomReportFooter"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.IsCustomReportHeader, "Default", "Description", "IsCustomReportHeader"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.IsPer, "Default", "Description", "IsPer"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.IsRTL, "Default", "Description", "Right to left"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.IsRTL, "ar", "Description", "عرض من اليمبن لليسار"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.IsShowDM, "Default", "Description", "IsShowDM"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.NoOfGroupsPerPage, "Default", "Description", "No of groups / page"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.NoOfGroupsPerPage, "ar", "Description", "عدد المجموعات / صفحة"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageFooter, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeader, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.PageHeaderSub1, "Default", "HeightF", 0F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "ar", "DisplayName", "قيود يومية تفصيلي"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Font", new DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Bold)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "Margins", new DevExpress.Drawing.DXMargins(10F, 10F, 20F, 20F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this, "Default", "PaperKind", DevExpress.Drawing.Printing.DXPaperKind.A4),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ReportFooter, "Default", "HeightF", 75F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.SheetNo, "Default", "Description", "SheetNo"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignature, "Default", "Description", "Show signature"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignature, "ar", "Description", "عرض التوقيع"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignatureAllPages, "Default", "Description", "Show signature in all page"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.ShowSignatureAllPages, "ar", "Description", "عرض التوقيع في كل الصفحات"),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.TopMargin, "Default", "HeightF", 20F),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCrossTab1, "Default", "LocationFloat", new DevExpress.Utils.PointFloat(22.91664F, 0F)),
            new DevExpress.XtraReports.Localization.LocalizationItem(this.xrCrossTab1, "Default", "SizeF", new System.Drawing.SizeF(482.2917F, 75F))});
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
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IsShowDM, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IsPer, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            groupLayoutItem1,
            groupLayoutItem2,
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.NoOfGroupsPerPage, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.FontSize, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.DateFrom, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.SheetNo, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.DateTo, DevExpress.XtraReports.Parameters.Orientation.Vertical)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.IsRTL,
            this.IsCustomReportFooter,
            this.IsCustomReportHeader,
            this.IsShowDM,
            this.IsPer,
            this.ShowSignature,
            this.ShowSignatureAllPages,
            this.HideReportHeader,
            this.HideReportFooter,
            this.NoOfGroupsPerPage,
            this.FontSize,
            this.DateFrom,
            this.SheetNo,
            this.DateTo});
            this.ScriptReferencesString = "E:\\VetSoft Projects .Net2024\\VetSoft Projects\\VetSoftDevExpress\\bin\\Release\\net8." +
    "0\\VetSoftDevExpress.dll";
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailData3_Odd,
            this.PageInfo,
            this.crossTabTotalStyle1,
            this.crossTabHeaderStyle1,
            this.crossTabDataStyle1,
            this.crossTabGeneralStyle1,
            this.crossTabGeneralStyle2,
            this.crossTabHeaderStyle2,
            this.crossTabDataStyle2,
            this.crossTabTotalStyle2});
            this.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.Version = "24.2";
            ((System.ComponentModel.ISupportInitialize)(this.dsFinance1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrCrossTab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.Parameters.Parameter HideReportHeader;
        private DevExpress.XtraReports.UI.SubBand PageHeaderSub1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
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
        private DevExpress.XtraReports.UI.CalculatedField Sa;
        private DevExpress.XtraReports.Parameters.Parameter IsRTL;
        private DevExpress.XtraReports.Parameters.Parameter IsCustomReportFooter;
        private DevExpress.XtraReports.Parameters.Parameter IsCustomReportHeader;
        private DevExpress.XtraReports.Parameters.Parameter ShowSignature;
        private DevExpress.XtraReports.Parameters.Parameter ShowSignatureAllPages;
        private DevExpress.XtraReports.Parameters.Parameter HideReportFooter;
        private DevExpress.XtraReports.Parameters.Parameter NoOfGroupsPerPage;
        private DevExpress.XtraReports.Parameters.Parameter FontSize;
        private DevExpress.XtraReports.Parameters.Parameter DateFrom;
        private DevExpress.XtraReports.Parameters.Parameter SheetNo;
        private DevExpress.XtraReports.Parameters.Parameter DateTo;
        private DevExpress.DataAccess.Sql.SqlDataSource dsBreeder;
        private Finance.DataSets.dsFinance dsFinance1;
        private Finance.DataSets.dsFinanceTableAdapters.SR_FM_RationResult_NutTableAdapter sR_FM_RationResult_NutTableAdapter;
        private DevExpress.XtraReports.UI.CalculatedField NutQuantityValue;
        private DevExpress.XtraReports.Parameters.Parameter IsShowDM;
        private DevExpress.XtraReports.Parameters.Parameter IsPer;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabTotalStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabHeaderStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabDataStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabGeneralStyle1;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRCrossTab xrCrossTab1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabDataCell1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell2;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell3;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell4;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell5;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell2;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell3;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabGeneralStyle2;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabHeaderStyle2;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabDataStyle2;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabTotalStyle2;
    }
}
