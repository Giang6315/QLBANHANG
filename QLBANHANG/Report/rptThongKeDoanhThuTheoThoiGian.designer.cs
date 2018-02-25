namespace QLBANHANG.Report
{
    partial class rptThongKeDoanhThuTheoThoiGian
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView1 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel2 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView2 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrChart1 = new DevExpress.XtraReports.UI.XRChart();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.lbDienThoai1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbDiachi = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbDenNgay = new DevExpress.XtraReports.UI.XRLabel();
            this.lbTuNgay = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelTieuDe = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 102.0833F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrChart1});
            this.GroupHeader1.HeightF = 373.9583F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrChart1
            // 
            this.xrChart1.BorderColor = System.Drawing.Color.Black;
            this.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.xrChart1.Diagram = xyDiagram1;
            this.xrChart1.LocationFloat = new DevExpress.Utils.PointFloat(37.5F, 12.5F);
            this.xrChart1.Name = "xrChart1";
            pointSeriesLabel1.LineVisible = true;
            series1.Label = pointSeriesLabel1;
            series1.Name = "Doanh Thu";
            series1.View = splineSeriesView1;
            this.xrChart1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            pointSeriesLabel2.LineVisible = true;
            this.xrChart1.SeriesTemplate.Label = pointSeriesLabel2;
            this.xrChart1.SeriesTemplate.View = splineSeriesView2;
            this.xrChart1.SizeF = new System.Drawing.SizeF(569.375F, 319.7917F);
            chartTitle1.Text = "Doanh Thu(USD)";
            this.xrChart1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbDienThoai1,
            this.lbDiachi,
            this.xrLabel1,
            this.lbDenNgay,
            this.lbTuNgay,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabelTieuDe});
            this.GroupHeader2.HeightF = 200F;
            this.GroupHeader2.Level = 1;
            this.GroupHeader2.Name = "GroupHeader2";
            // 
            // lbDienThoai1
            // 
            this.lbDienThoai1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lbDienThoai1.ForeColor = System.Drawing.Color.Blue;
            this.lbDienThoai1.LocationFloat = new DevExpress.Utils.PointFloat(37.5F, 72.50001F);
            this.lbDienThoai1.Name = "lbDienThoai1";
            this.lbDienThoai1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDienThoai1.SizeF = new System.Drawing.SizeF(250.7349F, 23F);
            this.lbDienThoai1.StylePriority.UseFont = false;
            this.lbDienThoai1.StylePriority.UseForeColor = false;
            this.lbDienThoai1.StylePriority.UseTextAlignment = false;
            this.lbDienThoai1.Text = "Điện thoại: 08.541 369 24 - 08.541 369 25";
            this.lbDienThoai1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbDiachi
            // 
            this.lbDiachi.CanShrink = true;
            this.lbDiachi.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lbDiachi.ForeColor = System.Drawing.Color.Blue;
            this.lbDiachi.LocationFloat = new DevExpress.Utils.PointFloat(37.5F, 47.50001F);
            this.lbDiachi.Name = "lbDiachi";
            this.lbDiachi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDiachi.SizeF = new System.Drawing.SizeF(388.6178F, 23F);
            this.lbDiachi.StylePriority.UseFont = false;
            this.lbDiachi.StylePriority.UseForeColor = false;
            this.lbDiachi.StylePriority.UseTextAlignment = false;
            this.lbDiachi.Text = "Địa chỉ: 100 Nguyễn Lương Bằng, Phường Tân Phú, Q.7, TP.HCM";
            this.lbDiachi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(37.5F, 10.00001F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(332.2917F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Văn Phòng Đại Diện Công Ty CHARABOT";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbDenNgay
            // 
            this.lbDenNgay.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lbDenNgay.LocationFloat = new DevExpress.Utils.PointFloat(439.5833F, 168.75F);
            this.lbDenNgay.Name = "lbDenNgay";
            this.lbDenNgay.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDenNgay.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lbDenNgay.StylePriority.UseFont = false;
            this.lbDenNgay.Text = "lbDenNgay";
            // 
            // lbTuNgay
            // 
            this.lbTuNgay.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lbTuNgay.LocationFloat = new DevExpress.Utils.PointFloat(216.6667F, 168.75F);
            this.lbTuNgay.Name = "lbTuNgay";
            this.lbTuNgay.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbTuNgay.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lbTuNgay.StylePriority.UseFont = false;
            this.lbTuNgay.Text = "lbTuNgay";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrLabel3.ForeColor = System.Drawing.Color.Black;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(353.125F, 168.75F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(86.45831F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseForeColor = false;
            this.xrLabel3.Text = "đến ngày:";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrLabel2.ForeColor = System.Drawing.Color.Black;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(103.125F, 168.75F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(113.5417F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.Text = "Tính từ ngày:";
            // 
            // xrLabelTieuDe
            // 
            this.xrLabelTieuDe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.xrLabelTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.xrLabelTieuDe.LocationFloat = new DevExpress.Utils.PointFloat(58.33333F, 112.5F);
            this.xrLabelTieuDe.Name = "xrLabelTieuDe";
            this.xrLabelTieuDe.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelTieuDe.SizeF = new System.Drawing.SizeF(534.3749F, 32.37502F);
            this.xrLabelTieuDe.StylePriority.UseFont = false;
            this.xrLabelTieuDe.StylePriority.UseForeColor = false;
            this.xrLabelTieuDe.StylePriority.UseTextAlignment = false;
            this.xrLabelTieuDe.Text = "THỐNG KÊ DOANH THU THEO THỜI GIAN";
            this.xrLabelTieuDe.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // rptThongKeDoanhThuTheoThoiGian
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1,
            this.GroupHeader2});
            this.Version = "11.1";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        public DevExpress.XtraReports.UI.XRChart xrChart1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.XRLabel xrLabelTieuDe;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        public DevExpress.XtraReports.UI.XRLabel lbDenNgay;
        public DevExpress.XtraReports.UI.XRLabel lbTuNgay;
        private DevExpress.XtraReports.UI.XRLabel lbDienThoai1;
        private DevExpress.XtraReports.UI.XRLabel lbDiachi;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    }
}
