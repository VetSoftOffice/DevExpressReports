namespace DevExpressReports.PredefinedReports
{
    partial class SubReportFooterCustom
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
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.SubBand1 = new DevExpress.XtraReports.UI.SubBand();
            this.Footer1 = new DevExpress.XtraReports.UI.XRLabel();
            this.SubBand2 = new DevExpress.XtraReports.UI.SubBand();
            this.Footer2 = new DevExpress.XtraReports.UI.XRLabel();
            this.SubBand3 = new DevExpress.XtraReports.UI.SubBand();
            this.Footer3 = new DevExpress.XtraReports.UI.XRLabel();
            this.SubBand4 = new DevExpress.XtraReports.UI.SubBand();
            this.Footer4 = new DevExpress.XtraReports.UI.XRLabel();
            this.SubBand5 = new DevExpress.XtraReports.UI.SubBand();
            this.Footer5 = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.IsRTL = new DevExpress.XtraReports.Parameters.Parameter();
            this.FontSize = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.Visible = false;
            // 
            // ReportHeader
            // 
            this.ReportHeader.HeightF = 0F;
            this.ReportHeader.KeepTogether = true;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.ReportHeader.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.SubBand1,
            this.SubBand2,
            this.SubBand3,
            this.SubBand4,
            this.SubBand5});
            this.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            // 
            // SubBand1
            // 
            this.SubBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Footer1});
            this.SubBand1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Not IsNullOrEmpty([ReportItems.Footer1].[Text])\n")});
            this.SubBand1.HeightF = 16F;
            this.SubBand1.Name = "SubBand1";
            // 
            // Footer1
            // 
            this.Footer1.BackColor = System.Drawing.Color.Transparent;
            this.Footer1.BorderColor = System.Drawing.Color.Black;
            this.Footer1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Footer1.BorderWidth = 1F;
            this.Footer1.CanGrow = false;
            this.Footer1.ForeColor = System.Drawing.Color.Black;
            this.Footer1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Footer1.Name = "Footer1";
            this.Footer1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Footer1.SizeF = new System.Drawing.SizeF(807F, 16F);
            this.Footer1.StylePriority.UseTextAlignment = false;
            this.Footer1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // SubBand2
            // 
            this.SubBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Footer2});
            this.SubBand2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Not IsNullOrEmpty([ReportItems.Footer2].[Text])\n")});
            this.SubBand2.HeightF = 16F;
            this.SubBand2.Name = "SubBand2";
            // 
            // Footer2
            // 
            this.Footer2.BackColor = System.Drawing.Color.Transparent;
            this.Footer2.BorderColor = System.Drawing.Color.Black;
            this.Footer2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Footer2.BorderWidth = 1F;
            this.Footer2.CanGrow = false;
            this.Footer2.ForeColor = System.Drawing.Color.Black;
            this.Footer2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Footer2.Name = "Footer2";
            this.Footer2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Footer2.SizeF = new System.Drawing.SizeF(807F, 16F);
            this.Footer2.StylePriority.UseTextAlignment = false;
            this.Footer2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // SubBand3
            // 
            this.SubBand3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Footer3});
            this.SubBand3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Not IsNullOrEmpty([ReportItems.Footer3].[Text])\n")});
            this.SubBand3.HeightF = 16F;
            this.SubBand3.Name = "SubBand3";
            // 
            // Footer3
            // 
            this.Footer3.BackColor = System.Drawing.Color.Transparent;
            this.Footer3.BorderColor = System.Drawing.Color.Black;
            this.Footer3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Footer3.BorderWidth = 1F;
            this.Footer3.CanGrow = false;
            this.Footer3.ForeColor = System.Drawing.Color.Black;
            this.Footer3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Footer3.Name = "Footer3";
            this.Footer3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Footer3.SizeF = new System.Drawing.SizeF(807F, 16F);
            this.Footer3.StylePriority.UseTextAlignment = false;
            this.Footer3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // SubBand4
            // 
            this.SubBand4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Footer4});
            this.SubBand4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Not IsNullOrEmpty([ReportItems.Footer4].[Text])\n\n")});
            this.SubBand4.HeightF = 16F;
            this.SubBand4.Name = "SubBand4";
            // 
            // Footer4
            // 
            this.Footer4.BackColor = System.Drawing.Color.Transparent;
            this.Footer4.BorderColor = System.Drawing.Color.Black;
            this.Footer4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Footer4.BorderWidth = 1F;
            this.Footer4.CanGrow = false;
            this.Footer4.ForeColor = System.Drawing.Color.Black;
            this.Footer4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Footer4.Name = "Footer4";
            this.Footer4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Footer4.SizeF = new System.Drawing.SizeF(807F, 16F);
            this.Footer4.StylePriority.UseTextAlignment = false;
            this.Footer4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // SubBand5
            // 
            this.SubBand5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.Footer5});
            this.SubBand5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "Not IsNullOrEmpty([ReportItems.Footer5].[Text])\n")});
            this.SubBand5.HeightF = 16F;
            this.SubBand5.Name = "SubBand5";
            // 
            // Footer5
            // 
            this.Footer5.BackColor = System.Drawing.Color.Transparent;
            this.Footer5.BorderColor = System.Drawing.Color.Black;
            this.Footer5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Footer5.BorderWidth = 1F;
            this.Footer5.CanGrow = false;
            this.Footer5.ForeColor = System.Drawing.Color.Black;
            this.Footer5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.Footer5.Name = "Footer5";
            this.Footer5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.Footer5.SizeF = new System.Drawing.SizeF(807F, 16F);
            this.Footer5.StylePriority.UseTextAlignment = false;
            this.Footer5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // IsRTL
            // 
            this.IsRTL.Description = "Parameter1";
            this.IsRTL.Name = "IsRTL";
            this.IsRTL.Type = typeof(bool);
            this.IsRTL.ValueInfo = "False";
            this.IsRTL.Visible = false;
            // 
            // FontSize
            // 
            this.FontSize.Description = "Parameter1";
            this.FontSize.Name = "FontSize";
            this.FontSize.Visible = false;
            // 
            // SubReportFooterCustom
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.ReportHeader,
            this.TopMargin,
            this.BottomMargin});
            this.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.Margins = new DevExpress.Drawing.DXMargins(10F, 10F, 0F, 0F);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IsRTL, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.FontSize, DevExpress.XtraReports.Parameters.Orientation.Vertical)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.IsRTL,
            this.FontSize});
            this.Version = "24.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.Parameters.Parameter IsRTL;
        private DevExpress.XtraReports.Parameters.Parameter FontSize;
        private DevExpress.XtraReports.UI.SubBand SubBand1;
        private DevExpress.XtraReports.UI.SubBand SubBand2;
        private DevExpress.XtraReports.UI.SubBand SubBand3;
        private DevExpress.XtraReports.UI.SubBand SubBand4;
        private DevExpress.XtraReports.UI.SubBand SubBand5;
        private DevExpress.XtraReports.UI.XRLabel Footer1;
        private DevExpress.XtraReports.UI.XRLabel Footer2;
        private DevExpress.XtraReports.UI.XRLabel Footer3;
        private DevExpress.XtraReports.UI.XRLabel Footer4;
        private DevExpress.XtraReports.UI.XRLabel Footer5;
    }
}
