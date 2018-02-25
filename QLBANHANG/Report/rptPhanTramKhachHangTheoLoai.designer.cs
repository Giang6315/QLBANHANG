namespace QLBANHANG.Report
{
    partial class rptPhanTramKhachHangTheoLoai
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
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesLabel pie3DSeriesLabel1 = new DevExpress.XtraCharts.Pie3DSeriesLabel();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
            DevExpress.XtraCharts.Pie3DSeriesLabel pie3DSeriesLabel2 = new DevExpress.XtraCharts.Pie3DSeriesLabel();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView2 = new DevExpress.XtraCharts.Pie3DSeriesView();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrChartTKKHTheoLoai = new DevExpress.XtraReports.UI.XRChart();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel_TieuDe = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbDienThoai1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbDiachi = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrChartTKKHTheoLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 45.83333F;
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
            this.xrChartTKKHTheoLoai});
            this.GroupHeader1.HeightF = 439.5833F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrChartTKKHTheoLoai
            // 
            this.xrChartTKKHTheoLoai.AppearanceName = "Chameleon";
            this.xrChartTKKHTheoLoai.BorderColor = System.Drawing.Color.Black;
            this.xrChartTKKHTheoLoai.Borders = DevExpress.XtraPrinting.BorderSide.None;
            simpleDiagram3D1.RotationMatrixSerializable = "1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1";
            this.xrChartTKKHTheoLoai.Diagram = simpleDiagram3D1;
            this.xrChartTKKHTheoLoai.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Center;
            this.xrChartTKKHTheoLoai.LocationFloat = new DevExpress.Utils.PointFloat(75F, 12.5F);
            this.xrChartTKKHTheoLoai.Name = "xrChartTKKHTheoLoai";
            this.xrChartTKKHTheoLoai.PaletteName = "Solstice";
            pie3DSeriesLabel1.LineVisible = true;
            series1.Label = pie3DSeriesLabel1;
            series1.Name = "Series 1";
            series1.View = pie3DSeriesView1;
            this.xrChartTKKHTheoLoai.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            pie3DSeriesLabel2.LineVisible = true;
            this.xrChartTKKHTheoLoai.SeriesTemplate.Label = pie3DSeriesLabel2;
            this.xrChartTKKHTheoLoai.SeriesTemplate.View = pie3DSeriesView2;
            this.xrChartTKKHTheoLoai.SizeF = new System.Drawing.SizeF(509.1667F, 305F);
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbDiachi,
            this.lbDienThoai1,
            this.xrLabel1,
            this.xrLabel_TieuDe});
            this.GroupHeader2.HeightF = 149.375F;
            this.GroupHeader2.Level = 1;
            this.GroupHeader2.Name = "GroupHeader2";
            this.GroupHeader2.StylePriority.UseTextAlignment = false;
            this.GroupHeader2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel_TieuDe
            // 
            this.xrLabel_TieuDe.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.xrLabel_TieuDe.ForeColor = System.Drawing.Color.Blue;
            this.xrLabel_TieuDe.LocationFloat = new DevExpress.Utils.PointFloat(101.6667F, 110.8333F);
            this.xrLabel_TieuDe.Name = "xrLabel_TieuDe";
            this.xrLabel_TieuDe.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel_TieuDe.SizeF = new System.Drawing.SizeF(446.6667F, 31.66666F);
            this.xrLabel_TieuDe.StylePriority.UseFont = false;
            this.xrLabel_TieuDe.StylePriority.UseForeColor = false;
            this.xrLabel_TieuDe.StylePriority.UseTextAlignment = false;
            this.xrLabel_TieuDe.Text = "Phần Trăm Khách Hàng Theo Loại";
            this.xrLabel_TieuDe.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(25F, 10.00001F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(332.2917F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Văn Phòng Đại Diện Công Ty CHARABOT";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbDienThoai1
            // 
            this.lbDienThoai1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lbDienThoai1.ForeColor = System.Drawing.Color.Blue;
            this.lbDienThoai1.LocationFloat = new DevExpress.Utils.PointFloat(25F, 72.50001F);
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
            this.lbDiachi.LocationFloat = new DevExpress.Utils.PointFloat(25F, 47.50001F);
            this.lbDiachi.Name = "lbDiachi";
            this.lbDiachi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDiachi.SizeF = new System.Drawing.SizeF(388.6178F, 23F);
            this.lbDiachi.StylePriority.UseFont = false;
            this.lbDiachi.StylePriority.UseForeColor = false;
            this.lbDiachi.StylePriority.UseTextAlignment = false;
            this.lbDiachi.Text = "Địa chỉ: 100 Nguyễn Lương Bằng, Phường Tân Phú, Q.7, TP.HCM";
            this.lbDiachi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // rptPhanTramKhachHangTheoLoai
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1,
            this.GroupHeader2});
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 46, 100);
            this.Version = "11.1";
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChartTKKHTheoLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel_TieuDe;
        public DevExpress.XtraReports.UI.XRChart xrChartTKKHTheoLoai;
        private DevExpress.XtraReports.UI.XRLabel lbDiachi;
        private DevExpress.XtraReports.UI.XRLabel lbDienThoai1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
    }
}
