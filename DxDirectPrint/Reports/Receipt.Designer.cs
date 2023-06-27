namespace DxDirectPrint.Reports
{
	partial class Receipt
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
			this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
			this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
			this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
			this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
			this.detailBand2 = new DevExpress.XtraReports.UI.DetailBand();
			this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
			this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
			this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
			this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// topMarginBand1
			// 
			this.topMarginBand1.Dpi = 254F;
			this.topMarginBand1.HeightF = 10F;
			this.topMarginBand1.Name = "topMarginBand1";
			this.topMarginBand1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
			this.topMarginBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// bottomMarginBand1
			// 
			this.bottomMarginBand1.Dpi = 254F;
			this.bottomMarginBand1.HeightF = 10F;
			this.bottomMarginBand1.Name = "bottomMarginBand1";
			this.bottomMarginBand1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
			this.bottomMarginBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// detailBand1
			// 
			this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel7,
            this.xrLabel8,
            this.xrLabel9,
            this.xrLabel10,
            this.xrLabel18,
            this.xrLabel16,
            this.xrLabel15,
            this.xrLine1,
            this.xrLabel2,
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel5,
            this.xrLabel6});
			this.detailBand1.Dpi = 254F;
			this.detailBand1.HeightF = 736.8116F;
			this.detailBand1.HierarchyPrintOptions.Indent = 50.8F;
			this.detailBand1.Name = "detailBand1";
			this.detailBand1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
			this.detailBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrLabel7
			// 
			this.xrLabel7.Dpi = 254F;
			this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[InvoiceDate]")});
			this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(198.4375F, 320.0402F);
			this.xrLabel7.Multiline = true;
			this.xrLabel7.Name = "xrLabel7";
			this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
			this.xrLabel7.SizeF = new System.Drawing.SizeF(276.5624F, 58.42001F);
			this.xrLabel7.Text = "xrLabel7";
			this.xrLabel7.TextFormatString = "{0:d}";
			// 
			// xrLabel8
			// 
			this.xrLabel8.Dpi = 254F;
			this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[InvoiceId]")});
			this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(198.4375F, 378.4602F);
			this.xrLabel8.Multiline = true;
			this.xrLabel8.Name = "xrLabel8";
			this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
			this.xrLabel8.SizeF = new System.Drawing.SizeF(276.5624F, 58.42001F);
			this.xrLabel8.StylePriority.UseTextAlignment = false;
			this.xrLabel8.Text = "xrLabel8";
			this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrLabel9
			// 
			this.xrLabel9.Dpi = 254F;
			this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 378.4602F);
			this.xrLabel9.Multiline = true;
			this.xrLabel9.Name = "xrLabel9";
			this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
			this.xrLabel9.SizeF = new System.Drawing.SizeF(198.4375F, 58.42001F);
			this.xrLabel9.Text = "Invoice #";
			// 
			// xrLabel10
			// 
			this.xrLabel10.Dpi = 254F;
			this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(0F, 320.0402F);
			this.xrLabel10.Multiline = true;
			this.xrLabel10.Name = "xrLabel10";
			this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
			this.xrLabel10.SizeF = new System.Drawing.SizeF(198.4375F, 58.42001F);
			this.xrLabel10.Text = "Invoice date";
			// 
			// xrLabel18
			// 
			this.xrLabel18.Dpi = 254F;
			this.xrLabel18.Font = new DevExpress.Drawing.DXFont("Times New Roman", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
			this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(355.1018F, 645.3718F);
			this.xrLabel18.Multiline = true;
			this.xrLabel18.Name = "xrLabel18";
			this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
			this.xrLabel18.SizeF = new System.Drawing.SizeF(131.963F, 58.42004F);
			this.xrLabel18.StylePriority.UseFont = false;
			this.xrLabel18.StylePriority.UseTextAlignment = false;
			this.xrLabel18.Text = "Total";
			this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.xrLabel18.TextFormatString = "{0:$0.00}";
			// 
			// xrLabel16
			// 
			this.xrLabel16.Dpi = 254F;
			this.xrLabel16.Font = new DevExpress.Drawing.DXFont("Times New Roman", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
			this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(96.71995F, 645.3718F);
			this.xrLabel16.Multiline = true;
			this.xrLabel16.Name = "xrLabel16";
			this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
			this.xrLabel16.SizeF = new System.Drawing.SizeF(254.8818F, 58.4201F);
			this.xrLabel16.StylePriority.UseFont = false;
			this.xrLabel16.Text = "Track";
			// 
			// xrLabel15
			// 
			this.xrLabel15.Dpi = 254F;
			this.xrLabel15.Font = new DevExpress.Drawing.DXFont("Times New Roman", 9.75F, DevExpress.Drawing.DXFontStyle.Bold);
			this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(0F, 645.3718F);
			this.xrLabel15.Multiline = true;
			this.xrLabel15.Name = "xrLabel15";
			this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
			this.xrLabel15.SizeF = new System.Drawing.SizeF(82.60882F, 58.42004F);
			this.xrLabel15.StylePriority.UseFont = false;
			this.xrLabel15.Text = "Qty";
			this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			// 
			// xrLine1
			// 
			this.xrLine1.Dpi = 254F;
			this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(2.645833F, 703.7917F);
			this.xrLine1.Name = "xrLine1";
			this.xrLine1.SizeF = new System.Drawing.SizeF(484.4189F, 33.0199F);
			// 
			// xrLabel2
			// 
			this.xrLabel2.Dpi = 254F;
			this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BillingAddress]")});
			this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 116.8401F);
			this.xrLabel2.Multiline = true;
			this.xrLabel2.Name = "xrLabel2";
			this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
			this.xrLabel2.SizeF = new System.Drawing.SizeF(475.0001F, 58.42001F);
			this.xrLabel2.Text = "xrLabel2";
			// 
			// xrLabel3
			// 
			this.xrLabel3.Dpi = 254F;
			this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString(\'{0}, {1} {2}\', [BillingCity],[BillingState], [BillingPostalCode] )")});
			this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 175.26F);
			this.xrLabel3.Multiline = true;
			this.xrLabel3.Name = "xrLabel3";
			this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
			this.xrLabel3.SizeF = new System.Drawing.SizeF(475.0001F, 58.42F);
			this.xrLabel3.Text = "xrLabel3";
			// 
			// xrLabel4
			// 
			this.xrLabel4.Dpi = 254F;
			this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[BillingCountry]")});
			this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 233.68F);
			this.xrLabel4.Multiline = true;
			this.xrLabel4.Name = "xrLabel4";
			this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
			this.xrLabel4.SizeF = new System.Drawing.SizeF(475.0001F, 58.41998F);
			this.xrLabel4.Text = "xrLabel4";
			// 
			// xrLabel5
			// 
			this.xrLabel5.Dpi = 254F;
			this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Customer].[Company]")});
			this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.xrLabel5.Multiline = true;
			this.xrLabel5.Name = "xrLabel5";
			this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
			this.xrLabel5.SizeF = new System.Drawing.SizeF(475.0001F, 58.42F);
			this.xrLabel5.Text = "xrLabel5";
			// 
			// xrLabel6
			// 
			this.xrLabel6.Dpi = 254F;
			this.xrLabel6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString(\'{0} {1}\', [Customer].[FirstName], [Customer].[LastName])")});
			this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 58.42006F);
			this.xrLabel6.Multiline = true;
			this.xrLabel6.Name = "xrLabel6";
			this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
			this.xrLabel6.SizeF = new System.Drawing.SizeF(475.0001F, 58.42001F);
			this.xrLabel6.Text = "xrLabel6";
			// 
			// objectDataSource1
			// 
			this.objectDataSource1.DataSource = typeof(global::DxDirectPrint.Data.DTO.InvoiceModel);
			this.objectDataSource1.Name = "objectDataSource1";
			// 
			// ReportHeader
			// 
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
			this.ReportHeader.Dpi = 254F;
			this.ReportHeader.HeightF = 146.3981F;
			this.ReportHeader.Name = "ReportHeader";
			// 
			// xrLabel1
			// 
			this.xrLabel1.Dpi = 254F;
			this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Tahoma", 14F, DevExpress.Drawing.DXFontStyle.Bold);
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(25.39997F, 25.40001F);
			this.xrLabel1.Multiline = true;
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
			this.xrLabel1.SizeF = new System.Drawing.SizeF(449.6F, 98.9707F);
			this.xrLabel1.StylePriority.UseFont = false;
			this.xrLabel1.Text = "Chinook Music Store";
			// 
			// DetailReport
			// 
			this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.detailBand2});
			this.DetailReport.DataMember = "InvoiceLines";
			this.DetailReport.DataSource = this.objectDataSource1;
			this.DetailReport.Dpi = 254F;
			this.DetailReport.Level = 0;
			this.DetailReport.Name = "DetailReport";
			// 
			// detailBand2
			// 
			this.detailBand2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel11,
            this.xrLabel12,
            this.xrLabel14});
			this.detailBand2.Dpi = 254F;
			this.detailBand2.HeightF = 58.42F;
			this.detailBand2.HierarchyPrintOptions.Indent = 50.8F;
			this.detailBand2.Name = "detailBand2";
			// 
			// xrLabel11
			// 
			this.xrLabel11.Dpi = 254F;
			this.xrLabel11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Quantity]")});
			this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.xrLabel11.Multiline = true;
			this.xrLabel11.Name = "xrLabel11";
			this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
			this.xrLabel11.SizeF = new System.Drawing.SizeF(82.60882F, 58.41999F);
			this.xrLabel11.Text = "xrLabel11";
			this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			// 
			// xrLabel12
			// 
			this.xrLabel12.Dpi = 254F;
			this.xrLabel12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString(\'{0} / {1} ({2})\', [Track].[Name], [Track].[Album].[Title], [Track]." +
                    "[Album].[Artist].[Name])")});
			this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(96.71991F, 0F);
			this.xrLabel12.Multiline = true;
			this.xrLabel12.Name = "xrLabel12";
			this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
			this.xrLabel12.SizeF = new System.Drawing.SizeF(254.8819F, 58.42F);
			this.xrLabel12.Text = "xrLabel12";
			// 
			// xrLabel14
			// 
			this.xrLabel14.Dpi = 254F;
			this.xrLabel14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Quantity]*[UnitPrice]")});
			this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(355.1018F, 0F);
			this.xrLabel14.Multiline = true;
			this.xrLabel14.Name = "xrLabel14";
			this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
			this.xrLabel14.SizeF = new System.Drawing.SizeF(131.963F, 58.42F);
			this.xrLabel14.StylePriority.UseTextAlignment = false;
			this.xrLabel14.Text = "xrLabel14";
			this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.xrLabel14.TextFormatString = "{0:$0.00}";
			// 
			// ReportFooter
			// 
			this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel13,
            this.xrLine2,
            this.xrLabel19});
			this.ReportFooter.Dpi = 254F;
			this.ReportFooter.HeightF = 254F;
			this.ReportFooter.Name = "ReportFooter";
			// 
			// xrLine2
			// 
			this.xrLine2.Dpi = 254F;
			this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.xrLine2.Name = "xrLine2";
			this.xrLine2.SizeF = new System.Drawing.SizeF(487.0647F, 33.01992F);
			// 
			// xrLabel19
			// 
			this.xrLabel19.Dpi = 254F;
			this.xrLabel19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Total]")});
			this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(222.7986F, 55.73906F);
			this.xrLabel19.Multiline = true;
			this.xrLabel19.Name = "xrLabel19";
			this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
			this.xrLabel19.SizeF = new System.Drawing.SizeF(252.2014F, 58.42001F);
			this.xrLabel19.Text = "xrLabel19";
			this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			this.xrLabel19.TextFormatString = "{0:$0.00}";
			// 
			// xrLabel13
			// 
			this.xrLabel13.Dpi = 254F;
			this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(25.00005F, 159.8084F);
			this.xrLabel13.Multiline = true;
			this.xrLabel13.Name = "xrLabel13";
			this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrLabel13.SizeF = new System.Drawing.SizeF(449.9999F, 58.42001F);
			this.xrLabel13.Text = "Thank you for shopping";
			// 
			// Receipt
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.detailBand1,
            this.ReportHeader,
            this.DetailReport,
            this.ReportFooter});
			this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
			this.DataSource = this.objectDataSource1;
			this.Dpi = 254F;
			this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
			this.Margins = new DevExpress.Drawing.DXMargins(0F, 0F, 10F, 10F);
			this.PageHeight = 2794;
			this.PageWidth = 500;
			this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Custom;
			this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
			this.RollPaper = true;
			this.SnapGridSize = 25F;
			this.Version = "23.1";
			((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion

		private DevExpress.XtraReports.UI.DetailBand Detail;
		private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
		private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
		private DevExpress.XtraReports.UI.DetailBand detailBand1;
		private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
		private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		private DevExpress.XtraReports.UI.XRLabel xrLabel2;
		private DevExpress.XtraReports.UI.XRLabel xrLabel3;
		private DevExpress.XtraReports.UI.XRLabel xrLabel4;
		private DevExpress.XtraReports.UI.XRLabel xrLabel5;
		private DevExpress.XtraReports.UI.XRLabel xrLabel6;
		private DevExpress.XtraReports.UI.XRLabel xrLabel1;
		private DevExpress.XtraReports.UI.XRLabel xrLabel7;
		private DevExpress.XtraReports.UI.XRLabel xrLabel8;
		private DevExpress.XtraReports.UI.XRLabel xrLabel9;
		private DevExpress.XtraReports.UI.XRLabel xrLabel10;
		private DevExpress.XtraReports.UI.XRLabel xrLabel18;
		private DevExpress.XtraReports.UI.XRLabel xrLabel16;
		private DevExpress.XtraReports.UI.XRLabel xrLabel15;
		private DevExpress.XtraReports.UI.XRLine xrLine1;
		private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
		private DevExpress.XtraReports.UI.DetailBand detailBand2;
		private DevExpress.XtraReports.UI.XRLabel xrLabel11;
		private DevExpress.XtraReports.UI.XRLabel xrLabel12;
		private DevExpress.XtraReports.UI.XRLabel xrLabel14;
		private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
		private DevExpress.XtraReports.UI.XRLine xrLine2;
		private DevExpress.XtraReports.UI.XRLabel xrLabel19;
		private DevExpress.XtraReports.UI.XRLabel xrLabel13;
	}
}
