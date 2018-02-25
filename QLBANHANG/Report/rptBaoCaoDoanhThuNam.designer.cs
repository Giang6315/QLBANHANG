namespace QLBANHANG.Report
{
    partial class rptBaoCaoDoanhThuNam
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
            this.xrTableTongDT = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.colSTT = new DevExpress.XtraReports.UI.XRTableCell();
            this.colMaDDH = new DevExpress.XtraReports.UI.XRTableCell();
            this.colTenSP = new DevExpress.XtraReports.UI.XRTableCell();
            this.colSoLuong = new DevExpress.XtraReports.UI.XRTableCell();
            this.colDonGia = new DevExpress.XtraReports.UI.XRTableCell();
            this.colThanhTien = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.lbDienThoai1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbDiachi = new DevExpress.XtraReports.UI.XRLabel();
            this.lbNam = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelTieuDe = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.STT = new DevExpress.XtraReports.UI.XRTableCell();
            this.MaDDH = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbTienBChu = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbNgayIn = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbTongTien = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            ((System.ComponentModel.ISupportInitialize)(this.xrTableTongDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTableTongDT});
            this.Detail.HeightF = 27.08333F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // xrTableTongDT
            // 
            this.xrTableTongDT.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableTongDT.LocationFloat = new DevExpress.Utils.PointFloat(37.49994F, 0F);
            this.xrTableTongDT.Name = "xrTableTongDT";
            this.xrTableTongDT.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTableTongDT.SizeF = new System.Drawing.SizeF(576.831F, 26.45832F);
            this.xrTableTongDT.StylePriority.UseBorders = false;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.colSTT,
            this.colMaDDH,
            this.colTenSP,
            this.colSoLuong,
            this.colDonGia,
            this.colThanhTien});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // colSTT
            // 
            this.colSTT.Name = "colSTT";
            this.colSTT.StylePriority.UseTextAlignment = false;
            this.colSTT.Text = "STT";
            this.colSTT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.colSTT.Weight = 0.24451408706506494D;
            // 
            // colMaDDH
            // 
            this.colMaDDH.Name = "colMaDDH";
            this.colMaDDH.StylePriority.UseTextAlignment = false;
            this.colMaDDH.Text = "MaDDH";
            this.colMaDDH.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.colMaDDH.Weight = 0.459199158238072D;
            // 
            // colTenSP
            // 
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.StylePriority.UseTextAlignment = false;
            this.colTenSP.Text = "TenSP";
            this.colTenSP.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.colTenSP.Weight = 0.88765210971192077D;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.StylePriority.UseTextAlignment = false;
            this.colSoLuong.Text = "SoLuong";
            this.colSoLuong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.colSoLuong.Weight = 0.37206357959262504D;
            // 
            // colDonGia
            // 
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.StylePriority.UseTextAlignment = false;
            this.colDonGia.Text = "DonGia";
            this.colDonGia.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.colDonGia.Weight = 0.37657712674303279D;
            // 
            // colThanhTien
            // 
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.StylePriority.UseTextAlignment = false;
            this.colThanhTien.Text = "ThanhTien";
            this.colThanhTien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.colThanhTien.Weight = 0.64253163116186474D;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 96.875F;
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
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbDienThoai1,
            this.xrLabel1,
            this.lbDiachi});
            this.GroupHeader2.HeightF = 137.5F;
            this.GroupHeader2.Level = 1;
            this.GroupHeader2.Name = "GroupHeader2";
            // 
            // lbDienThoai1
            // 
            this.lbDienThoai1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lbDienThoai1.ForeColor = System.Drawing.Color.Blue;
            this.lbDienThoai1.LocationFloat = new DevExpress.Utils.PointFloat(25F, 88.54166F);
            this.lbDienThoai1.Name = "lbDienThoai1";
            this.lbDienThoai1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDienThoai1.SizeF = new System.Drawing.SizeF(250.7349F, 23F);
            this.lbDienThoai1.StylePriority.UseFont = false;
            this.lbDienThoai1.StylePriority.UseForeColor = false;
            this.lbDienThoai1.StylePriority.UseTextAlignment = false;
            this.lbDienThoai1.Text = "Điện thoại: 08.541 369 24 - 08.541 369 25";
            this.lbDienThoai1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(25F, 26.04167F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(332.2917F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Văn Phòng Đại Diện Công Ty CHARABOT";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbDiachi
            // 
            this.lbDiachi.CanShrink = true;
            this.lbDiachi.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lbDiachi.ForeColor = System.Drawing.Color.Blue;
            this.lbDiachi.LocationFloat = new DevExpress.Utils.PointFloat(25F, 63.54167F);
            this.lbDiachi.Name = "lbDiachi";
            this.lbDiachi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDiachi.SizeF = new System.Drawing.SizeF(388.6178F, 23F);
            this.lbDiachi.StylePriority.UseFont = false;
            this.lbDiachi.StylePriority.UseForeColor = false;
            this.lbDiachi.StylePriority.UseTextAlignment = false;
            this.lbDiachi.Text = "Địa chỉ: 100 Nguyễn Lương Bằng, Phường Tân Phú, Q.7, TP.HCM";
            this.lbDiachi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbNam
            // 
            this.lbNam.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold);
            this.lbNam.ForeColor = System.Drawing.Color.Blue;
            this.lbNam.LocationFloat = new DevExpress.Utils.PointFloat(451.0417F, 16.25001F);
            this.lbNam.Name = "lbNam";
            this.lbNam.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbNam.SizeF = new System.Drawing.SizeF(94.16644F, 44.875F);
            this.lbNam.StylePriority.UseFont = false;
            this.lbNam.StylePriority.UseForeColor = false;
            this.lbNam.StylePriority.UseTextAlignment = false;
            this.lbNam.Text = "lbNam";
            this.lbNam.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabelTieuDe
            // 
            this.xrLabelTieuDe.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold);
            this.xrLabelTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.xrLabelTieuDe.LocationFloat = new DevExpress.Utils.PointFloat(100F, 16.25001F);
            this.xrLabelTieuDe.Name = "xrLabelTieuDe";
            this.xrLabelTieuDe.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelTieuDe.SizeF = new System.Drawing.SizeF(351.0417F, 44.875F);
            this.xrLabelTieuDe.StylePriority.UseFont = false;
            this.xrLabelTieuDe.StylePriority.UseForeColor = false;
            this.xrLabelTieuDe.StylePriority.UseTextAlignment = false;
            this.xrLabelTieuDe.Text = "Báo Cáo Doanh Thu Năm";
            this.xrLabelTieuDe.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1,
            this.xrLabelTieuDe,
            this.lbNam});
            this.GroupHeader1.HeightF = 116.6667F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(37.5F, 91.6667F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(576.8309F, 25F);
            this.xrTable1.StylePriority.UseBorders = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.STT,
            this.MaDDH,
            this.xrTableCell1,
            this.xrTableCell5,
            this.xrTableCell2,
            this.xrTableCell3});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // STT
            // 
            this.STT.BorderColor = System.Drawing.Color.Black;
            this.STT.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.STT.ForeColor = System.Drawing.Color.Blue;
            this.STT.Name = "STT";
            this.STT.StylePriority.UseBorderColor = false;
            this.STT.StylePriority.UseFont = false;
            this.STT.StylePriority.UseForeColor = false;
            this.STT.StylePriority.UseTextAlignment = false;
            this.STT.Text = "STT";
            this.STT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.STT.Weight = 0.24628256168276441D;
            // 
            // MaDDH
            // 
            this.MaDDH.BorderColor = System.Drawing.Color.Black;
            this.MaDDH.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.MaDDH.ForeColor = System.Drawing.Color.Blue;
            this.MaDDH.Name = "MaDDH";
            this.MaDDH.StylePriority.UseBorderColor = false;
            this.MaDDH.StylePriority.UseFont = false;
            this.MaDDH.StylePriority.UseForeColor = false;
            this.MaDDH.StylePriority.UseTextAlignment = false;
            this.MaDDH.Text = "Mã DDH";
            this.MaDDH.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.MaDDH.Weight = 0.46252066992554269D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.xrTableCell1.ForeColor = System.Drawing.Color.Blue;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseBorderColor = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseForeColor = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "Tên Sản Phẩm";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell1.Weight = 0.89407262951756161D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.xrTableCell5.ForeColor = System.Drawing.Color.Blue;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseBorderColor = false;
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UseForeColor = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "Số lượng";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell5.Weight = 0.37475479685864149D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.xrTableCell2.ForeColor = System.Drawing.Color.Blue;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseBorderColor = false;
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UseForeColor = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "Đơn Giá";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell2.Weight = 0.37930064716148526D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.BorderColor = System.Drawing.Color.Black;
            this.xrTableCell3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.xrTableCell3.ForeColor = System.Drawing.Color.Blue;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseBorderColor = false;
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UseForeColor = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "Thành Tiền";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell3.Weight = 0.64717907104060923D;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel6,
            this.lbTienBChu,
            this.xrLabel4,
            this.lbNgayIn,
            this.xrLabel2,
            this.lbTongTien,
            this.xrLabel3});
            this.GroupFooter1.HeightF = 166.6667F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(84.78969F, 45.83333F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(121.3159F, 23F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Số tiền bằng chữ:";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbTienBChu
            // 
            this.lbTienBChu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbTienBChu.LocationFloat = new DevExpress.Utils.PointFloat(206.1056F, 45.83333F);
            this.lbTienBChu.Name = "lbTienBChu";
            this.lbTienBChu.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbTienBChu.SizeF = new System.Drawing.SizeF(406.3944F, 23F);
            this.lbTienBChu.StylePriority.UseFont = false;
            this.lbTienBChu.StylePriority.UseTextAlignment = false;
            this.lbTienBChu.Text = "lbTienBChu";
            this.lbTienBChu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.xrLabel4.ForeColor = System.Drawing.Color.Black;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(349.3923F, 113.5417F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(178.125F, 23F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Người Lập Báo Cáo";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lbNgayIn
            // 
            this.lbNgayIn.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbNgayIn.LocationFloat = new DevExpress.Utils.PointFloat(450F, 79.16666F);
            this.lbNgayIn.Name = "lbNgayIn";
            this.lbNgayIn.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbNgayIn.SizeF = new System.Drawing.SizeF(162.5F, 23F);
            this.lbNgayIn.StylePriority.UseFont = false;
            this.lbNgayIn.Text = "lbNgayIn";
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(307.2917F, 79.16666F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(142.7083F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "Ngày in báo cáo:";
            // 
            // lbTongTien
            // 
            this.lbTongTien.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbTongTien.ForeColor = System.Drawing.Color.Red;
            this.lbTongTien.LocationFloat = new DevExpress.Utils.PointFloat(473.9583F, 10.00001F);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbTongTien.SizeF = new System.Drawing.SizeF(138.5417F, 23F);
            this.lbTongTien.StylePriority.UseFont = false;
            this.lbTongTien.StylePriority.UseForeColor = false;
            this.lbTongTien.Text = "lbTongTien";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(309.375F, 10.00001F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(164.5833F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "Tổng Thành Tiền:";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1});
            this.PageFooter.Name = "PageFooter";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Format = "Trang {0}";
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(292.7083F, 10.00001F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(64.58334F, 23F);
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // rptBaoCaoDoanhThuNam
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1,
            this.GroupHeader2,
            this.GroupFooter1,
            this.PageFooter});
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 97, 100);
            this.Version = "11.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTableTongDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        public DevExpress.XtraReports.UI.XRLabel lbNam;
        private DevExpress.XtraReports.UI.XRLabel xrLabelTieuDe;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell STT;
        private DevExpress.XtraReports.UI.XRTableCell MaDDH;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        public DevExpress.XtraReports.UI.XRLabel lbTongTien;
        private DevExpress.XtraReports.UI.XRLabel lbDienThoai1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel lbDiachi;
        private DevExpress.XtraReports.UI.XRLabel lbNgayIn;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        public DevExpress.XtraReports.UI.XRLabel lbTienBChu;
        private DevExpress.XtraReports.UI.XRTable xrTableTongDT;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell colSTT;
        private DevExpress.XtraReports.UI.XRTableCell colMaDDH;
        private DevExpress.XtraReports.UI.XRTableCell colTenSP;
        private DevExpress.XtraReports.UI.XRTableCell colSoLuong;
        private DevExpress.XtraReports.UI.XRTableCell colDonGia;
        private DevExpress.XtraReports.UI.XRTableCell colThanhTien;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
    }
}
