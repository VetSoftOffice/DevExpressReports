namespace DevExpressReports.PredefinedReports
{
    partial class SubReportHeader
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
            this.ReportName = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.ReportHeaderSub1 = new DevExpress.XtraReports.UI.SubBand();
            this.ReportPQP_ar = new DevExpress.XtraReports.UI.XRLabel();
            this.ModuleName_ar = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportPQP_en = new DevExpress.XtraReports.UI.XRLabel();
            this.CompanyName_en = new DevExpress.XtraReports.UI.XRLabel();
            this.CompanyName_ar = new DevExpress.XtraReports.UI.XRLabel();
            this.imgLogo = new DevExpress.XtraReports.UI.XRPictureBox();
            this.ModuleName_en = new DevExpress.XtraReports.UI.XRLabel();
            this.ReportHeaderSub2 = new DevExpress.XtraReports.UI.SubBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.LogoPath = new DevExpress.XtraReports.Parameters.Parameter();
            this.IsRTL = new DevExpress.XtraReports.Parameters.Parameter();
            this.FontSize = new DevExpress.XtraReports.Parameters.Parameter();
            this.HideReportHeader = new DevExpress.XtraReports.Parameters.Parameter();
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
            // ReportName
            // 
            this.ReportName.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.ReportName.CanGrow = false;
            this.ReportName.Font = new DevExpress.Drawing.DXFont("Tahoma", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.ReportName.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.ReportName.Name = "ReportName";
            this.ReportName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ReportName.SizeF = new System.Drawing.SizeF(807F, 20F);
            this.ReportName.StylePriority.UseFont = false;
            this.ReportName.StylePriority.UseTextAlignment = false;
            this.ReportName.Text = "ReportName";
            this.ReportName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // ReportHeader
            // 
            this.ReportHeader.HeightF = 0F;
            this.ReportHeader.KeepTogether = true;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.ReportHeader.SubBands.AddRange(new DevExpress.XtraReports.UI.SubBand[] {
            this.ReportHeaderSub1,
            this.ReportHeaderSub2});
            this.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            // 
            // ReportHeaderSub1
            // 
            this.ReportHeaderSub1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.ReportPQP_ar,
            this.ModuleName_ar,
            this.ReportPQP_en,
            this.CompanyName_en,
            this.CompanyName_ar,
            this.imgLogo,
            this.ModuleName_en});
            this.ReportHeaderSub1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Visible", "?HideReportHeader == False")});
            this.ReportHeaderSub1.HeightF = 74.08333F;
            this.ReportHeaderSub1.Name = "ReportHeaderSub1";
            // 
            // ReportPQP_ar
            // 
            this.ReportPQP_ar.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right;
            this.ReportPQP_ar.CanGrow = false;
            this.ReportPQP_ar.Font = new DevExpress.Drawing.DXFont("Tahoma", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.ReportPQP_ar.LocationFloat = new DevExpress.Utils.PointFloat(487F, 41.93052F);
            this.ReportPQP_ar.Name = "ReportPQP_ar";
            this.ReportPQP_ar.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ReportPQP_ar.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            this.ReportPQP_ar.SizeF = new System.Drawing.SizeF(320F, 20F);
            this.ReportPQP_ar.StylePriority.UseFont = false;
            this.ReportPQP_ar.StylePriority.UseTextAlignment = false;
            this.ReportPQP_ar.Text = "ReportPQP_ar";
            this.ReportPQP_ar.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ModuleName_ar
            // 
            this.ModuleName_ar.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right;
            this.ModuleName_ar.CanGrow = false;
            this.ModuleName_ar.Font = new DevExpress.Drawing.DXFont("Tahoma", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.ModuleName_ar.LocationFloat = new DevExpress.Utils.PointFloat(487F, 21.79165F);
            this.ModuleName_ar.Name = "ModuleName_ar";
            this.ModuleName_ar.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ModuleName_ar.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            this.ModuleName_ar.SizeF = new System.Drawing.SizeF(320F, 20F);
            this.ModuleName_ar.StylePriority.UseFont = false;
            this.ModuleName_ar.StylePriority.UseTextAlignment = false;
            this.ModuleName_ar.Text = "ModuleName_ar";
            this.ModuleName_ar.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // ReportPQP_en
            // 
            this.ReportPQP_en.CanGrow = false;
            this.ReportPQP_en.Font = new DevExpress.Drawing.DXFont("Tahoma", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.ReportPQP_en.LocationFloat = new DevExpress.Utils.PointFloat(0F, 41.93052F);
            this.ReportPQP_en.Name = "ReportPQP_en";
            this.ReportPQP_en.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ReportPQP_en.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            this.ReportPQP_en.SizeF = new System.Drawing.SizeF(320F, 20F);
            this.ReportPQP_en.StylePriority.UseFont = false;
            this.ReportPQP_en.StylePriority.UseTextAlignment = false;
            this.ReportPQP_en.Text = "ReportPQP_en";
            this.ReportPQP_en.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // CompanyName_en
            // 
            this.CompanyName_en.CanGrow = false;
            this.CompanyName_en.Font = new DevExpress.Drawing.DXFont("Tahoma", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.CompanyName_en.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0.9583156F);
            this.CompanyName_en.Name = "CompanyName_en";
            this.CompanyName_en.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.CompanyName_en.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            this.CompanyName_en.SizeF = new System.Drawing.SizeF(320F, 20F);
            this.CompanyName_en.StylePriority.UseBorderWidth = false;
            this.CompanyName_en.StylePriority.UseFont = false;
            this.CompanyName_en.StylePriority.UseTextAlignment = false;
            this.CompanyName_en.Text = "CompanyName_en";
            this.CompanyName_en.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // CompanyName_ar
            // 
            this.CompanyName_ar.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right;
            this.CompanyName_ar.CanGrow = false;
            this.CompanyName_ar.Font = new DevExpress.Drawing.DXFont("Tahoma", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.CompanyName_ar.LocationFloat = new DevExpress.Utils.PointFloat(487F, 0.9583156F);
            this.CompanyName_ar.Name = "CompanyName_ar";
            this.CompanyName_ar.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.CompanyName_ar.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            this.CompanyName_ar.SizeF = new System.Drawing.SizeF(320F, 20F);
            this.CompanyName_ar.StylePriority.UseFont = false;
            this.CompanyName_ar.StylePriority.UseTextAlignment = false;
            this.CompanyName_ar.Text = "CompanyName_ar";
            this.CompanyName_ar.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // imgLogo
            // 
            this.imgLogo.AnchorHorizontal = ((DevExpress.XtraReports.UI.HorizontalAnchorStyles)((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right)));
            this.imgLogo.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageUrl", "?LogoPath")});
            this.imgLogo.Font = new DevExpress.Drawing.DXFont("Times New Roman", 9.75F);
            this.imgLogo.ForeColor = System.Drawing.Color.Black;
            this.imgLogo.LocationFloat = new DevExpress.Utils.PointFloat(354.1598F, 0.9583156F);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.imgLogo.SizeF = new System.Drawing.SizeF(98.68056F, 71.80556F);
            this.imgLogo.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // ModuleName_en
            // 
            this.ModuleName_en.CanGrow = false;
            this.ModuleName_en.Font = new DevExpress.Drawing.DXFont("Tahoma", 11F, DevExpress.Drawing.DXFontStyle.Bold);
            this.ModuleName_en.LocationFloat = new DevExpress.Utils.PointFloat(0F, 21.79165F);
            this.ModuleName_en.Name = "ModuleName_en";
            this.ModuleName_en.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.ModuleName_en.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            this.ModuleName_en.SizeF = new System.Drawing.SizeF(320F, 20F);
            this.ModuleName_en.StylePriority.UseFont = false;
            this.ModuleName_en.StylePriority.UseTextAlignment = false;
            this.ModuleName_en.Text = "ModuleName_en";
            this.ModuleName_en.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // ReportHeaderSub2
            // 
            this.ReportHeaderSub2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.ReportName});
            this.ReportHeaderSub2.HeightF = 20F;
            this.ReportHeaderSub2.Name = "ReportHeaderSub2";
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
            // LogoPath
            // 
            this.LogoPath.Description = "Logo path";
            this.LogoPath.Name = "LogoPath";
            this.LogoPath.Visible = false;
            // 
            // IsRTL
            // 
            this.IsRTL.Description = "Right to left";
            this.IsRTL.Name = "IsRTL";
            this.IsRTL.Type = typeof(bool);
            this.IsRTL.ValueInfo = "False";
            this.IsRTL.Visible = false;
            // 
            // FontSize
            // 
            this.FontSize.Description = "Font size";
            this.FontSize.Name = "FontSize";
            this.FontSize.Visible = false;
            // 
            // HideReportHeader
            // 
            this.HideReportHeader.Description = "Hide report header";
            this.HideReportHeader.Name = "HideReportHeader";
            this.HideReportHeader.Type = typeof(bool);
            this.HideReportHeader.ValueInfo = "False";
            this.HideReportHeader.Visible = false;
            // 
            // SubReportHeader
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.ReportHeader,
            this.TopMargin,
            this.BottomMargin});
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.BorderWidth = 0.5F;
            this.Font = new DevExpress.Drawing.DXFont("Tahoma", 8.25F);
            this.Margins = new DevExpress.Drawing.DXMargins(10F, 10F, 0F, 0F);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4;
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.IsRTL, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.LogoPath, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.FontSize, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.HideReportHeader, DevExpress.XtraReports.Parameters.Orientation.Vertical)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.IsRTL,
            this.LogoPath,
            this.FontSize,
            this.HideReportHeader});
            this.Version = "24.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel ReportName;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel ModuleName_ar;
        private DevExpress.XtraReports.UI.XRLabel ReportPQP_en;
        private DevExpress.XtraReports.UI.XRLabel CompanyName_en;
        private DevExpress.XtraReports.UI.XRLabel CompanyName_ar;
        private DevExpress.XtraReports.UI.XRLabel ModuleName_en;
        private DevExpress.XtraReports.UI.XRPictureBox imgLogo;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.Parameters.Parameter LogoPath;
        private DevExpress.XtraReports.Parameters.Parameter IsRTL;
        private DevExpress.XtraReports.Parameters.Parameter FontSize;
        private DevExpress.XtraReports.UI.XRLabel ReportPQP_ar;
        private DevExpress.XtraReports.UI.SubBand ReportHeaderSub1;
        private DevExpress.XtraReports.Parameters.Parameter HideReportHeader;
        private DevExpress.XtraReports.UI.SubBand ReportHeaderSub2;
    }
}
