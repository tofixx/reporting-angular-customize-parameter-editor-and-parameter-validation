namespace CustomParameterEditorAngularExample.PredefinedReports
{
    partial class CustomParameterReport
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
      DevExpress.XtraReports.Parameters.StaticListLookUpSettings staticListLookUpSettings1 = new DevExpress.XtraReports.Parameters.StaticListLookUpSettings();
      this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
      this.Detail = new DevExpress.XtraReports.UI.DetailBand();
      this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
      this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
      this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
      this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
      this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
      this.label2 = new DevExpress.XtraReports.UI.XRLabel();
      this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
      this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
      this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
      this.DetailCaption3 = new DevExpress.XtraReports.UI.XRControlStyle();
      this.DetailData3 = new DevExpress.XtraReports.UI.XRControlStyle();
      this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
      this.DetailCaptionBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
      this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
      this.daterange_Start = new DevExpress.XtraReports.Parameters.RangeStartParameter();
      this.daterange_End = new DevExpress.XtraReports.Parameters.RangeEndParameter();
      this.daterange = new DevExpress.XtraReports.Parameters.Parameter();
      this.multi = new DevExpress.XtraReports.Parameters.Parameter();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      // 
      // TopMargin
      // 
      this.TopMargin.HeightF = 78F;
      this.TopMargin.Name = "TopMargin";
      this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
      this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
      // 
      // Detail
      // 
      this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1,
            this.label2,
            this.xrLabel10});
      this.Detail.HeightF = 289.72F;
      this.Detail.KeepTogether = true;
      this.Detail.Name = "Detail";
      this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
      this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
      // 
      // xrLabel5
      // 
      this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(91.2501F, 175.825F);
      this.xrLabel5.Multiline = true;
      this.xrLabel5.Name = "xrLabel5";
      this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel5.SizeF = new System.Drawing.SizeF(83.83332F, 25.55338F);
      this.xrLabel5.StyleName = "Title";
      this.xrLabel5.Text = "End";
      // 
      // xrLabel4
      // 
      this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(91.2501F, 136.2F);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel4.SizeF = new System.Drawing.SizeF(83.83332F, 25.55338F);
      this.xrLabel4.StyleName = "Title";
      this.xrLabel4.Text = "Start";
      // 
      // xrLabel3
      // 
      this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?daterange_End")});
      this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(193.6801F, 175.825F);
      this.xrLabel3.Multiline = true;
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel3.SizeF = new System.Drawing.SizeF(262.55F, 28.22F);
      // 
      // xrLabel2
      // 
      this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?daterange_Start")});
      this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(193.6801F, 133.5334F);
      this.xrLabel2.Multiline = true;
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel2.SizeF = new System.Drawing.SizeF(262.55F, 28.22F);
      // 
      // xrLabel1
      // 
      this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 97.50001F);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel1.SizeF = new System.Drawing.SizeF(376.5417F, 25.55338F);
      this.xrLabel1.StyleName = "Title";
      this.xrLabel1.Text = "Date Range with dxDateRangeBox:";
      // 
      // label2
      // 
      this.label2.LocationFloat = new DevExpress.Utils.PointFloat(179.5133F, 52.70001F);
      this.label2.Multiline = true;
      this.label2.Name = "label2";
      this.label2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.label2.SizeF = new System.Drawing.SizeF(262.55F, 28.22F);
      // 
      // xrLabel10
      // 
      this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
      this.xrLabel10.Multiline = true;
      this.xrLabel10.Name = "xrLabel10";
      this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      this.xrLabel10.SizeF = new System.Drawing.SizeF(249.4583F, 25.55338F);
      this.xrLabel10.StyleName = "Title";
      this.xrLabel10.Text = "Send this report to:";
      // 
      // BottomMargin
      // 
      this.BottomMargin.Name = "BottomMargin";
      this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
      this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
      // 
      // Title
      // 
      this.Title.BackColor = System.Drawing.Color.Transparent;
      this.Title.BorderColor = System.Drawing.Color.Black;
      this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
      this.Title.BorderWidth = 1F;
      this.Title.Font = new DevExpress.Drawing.DXFont("Tahoma", 14F);
      this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
      this.Title.Name = "Title";
      // 
      // DetailCaption3
      // 
      this.DetailCaption3.BackColor = System.Drawing.Color.Transparent;
      this.DetailCaption3.BorderColor = System.Drawing.Color.Transparent;
      this.DetailCaption3.Borders = DevExpress.XtraPrinting.BorderSide.None;
      this.DetailCaption3.Font = new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold);
      this.DetailCaption3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
      this.DetailCaption3.Name = "DetailCaption3";
      this.DetailCaption3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
      this.DetailCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // DetailData3
      // 
      this.DetailData3.Font = new DevExpress.Drawing.DXFont("Tahoma", 8F);
      this.DetailData3.ForeColor = System.Drawing.Color.Black;
      this.DetailData3.Name = "DetailData3";
      this.DetailData3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
      this.DetailData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // DetailData3_Odd
      // 
      this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
      this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
      this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
      this.DetailData3_Odd.BorderWidth = 1F;
      this.DetailData3_Odd.Font = new DevExpress.Drawing.DXFont("Tahoma", 8F);
      this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
      this.DetailData3_Odd.Name = "DetailData3_Odd";
      this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
      this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // DetailCaptionBackground3
      // 
      this.DetailCaptionBackground3.BackColor = System.Drawing.Color.Transparent;
      this.DetailCaptionBackground3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
      this.DetailCaptionBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Top;
      this.DetailCaptionBackground3.BorderWidth = 2F;
      this.DetailCaptionBackground3.Name = "DetailCaptionBackground3";
      // 
      // PageInfo
      // 
      this.PageInfo.Font = new DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold);
      this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
      this.PageInfo.Name = "PageInfo";
      this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
      // 
      // daterange_Start
      // 
      this.daterange_Start.Name = "daterange_Start";
      this.daterange_Start.ValueInfo = "2026-01-13";
      // 
      // daterange_End
      // 
      this.daterange_End.Name = "daterange_End";
      this.daterange_End.ValueInfo = "2026-01-13";
      // 
      // daterange
      // 
      this.daterange.Description = "daterangeparam";
      this.daterange.Name = "daterange";
      this.daterange.Type = typeof(global::System.DateTime);
      this.daterange.ValueSourceSettings = new DevExpress.XtraReports.Parameters.RangeParametersSettings(this.daterange_Start, this.daterange_End);
      // 
      // multi
      // 
      this.multi.Description = "select min one of";
      this.multi.MultiValue = true;
      this.multi.Name = "multi";
      this.multi.Type = typeof(int);
      staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(0, "select"));
      staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(0, "at least"));
      staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue(0, "one element"));
      this.multi.ValueSourceSettings = staticListLookUpSettings1;
      // 
      // CustomParameterReport
      // 
      this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.Detail,
            this.BottomMargin});
      this.DisplayName = "CustomParameterReport";
      this.Extensions.Add("DataSerializationExtension", "myCustomDataSerializer");
      this.Margins = new DevExpress.Drawing.DXMargins(100F, 100F, 78F, 100F);
      this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.daterange, DevExpress.XtraReports.Parameters.Orientation.Vertical),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.multi, DevExpress.XtraReports.Parameters.Orientation.Vertical)});
      this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.daterange,
            this.multi});
      this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption3,
            this.DetailData3,
            this.DetailData3_Odd,
            this.DetailCaptionBackground3,
            this.PageInfo});
      this.Version = "24.1";
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel label2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption3;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaptionBackground3;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
    private DevExpress.XtraReports.UI.XRLabel xrLabel3;
    private DevExpress.XtraReports.UI.XRLabel xrLabel2;
    private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    private DevExpress.XtraReports.Parameters.RangeStartParameter daterange_Start;
    private DevExpress.XtraReports.Parameters.RangeEndParameter daterange_End;
    private DevExpress.XtraReports.Parameters.Parameter daterange;
    private DevExpress.XtraReports.UI.XRLabel xrLabel5;
    private DevExpress.XtraReports.UI.XRLabel xrLabel4;
    private DevExpress.XtraReports.Parameters.Parameter multi;
  }
}
