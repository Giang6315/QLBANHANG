namespace QLBANHANG.Report
{
    partial class rptBaoCaoTongDoanhThu
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
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.STT = new DevExpress.XtraReports.UI.XRTableCell();
            this.MaDDH = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabelTieuDe = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbDiachi = new DevExpress.XtraReports.UI.XRLabel();
            this.lbDienThoai1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbTongThanhTien = new DevExpress.XtraReports.UI.XRLabel();
            this.lbTongTT = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbTienBChu = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lbNgayInBaoCao = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
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
            this.Detail.HeightF = 26.45832F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint_1);
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
            this.TopMargin.HeightF = 101F;
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
            this.xrTable1,
            this.xrLabelTieuDe});
            this.GroupHeader1.HeightF = 108.3335F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                        | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(37.49994F, 81.25016F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(576.8311F, 27.08334F);
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.STT,
            this.MaDDH,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell3});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // STT
            // 
            this.STT.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.STT.ForeColor = System.Drawing.Color.Blue;
            this.STT.Name = "STT";
            this.STT.StylePriority.UseFont = false;
            this.STT.StylePriority.UseForeColor = false;
            this.STT.StylePriority.UseTextAlignment = false;
            this.STT.Text = "STT";
            this.STT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.STT.Weight = 0.45418959701939859D;
            // 
            // MaDDH
            // 
            this.MaDDH.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.MaDDH.ForeColor = System.Drawing.Color.Blue;
            this.MaDDH.Name = "MaDDH";
            this.MaDDH.StylePriority.UseFont = false;
            this.MaDDH.StylePriority.UseForeColor = false;
            this.MaDDH.StylePriority.UseTextAlignment = false;
            this.MaDDH.Text = "Mã DDH";
            this.MaDDH.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.MaDDH.Weight = 0.852971038269875D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrTableCell4.ForeColor = System.Drawing.Color.Blue;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UseForeColor = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "Tên Sản Phẩm";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell4.Weight = 1.6661370630149182D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrTableCell5.ForeColor = System.Drawing.Color.Blue;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UseForeColor = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "Số Lượng";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell5.Weight = 0.69516227388653085D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrTableCell6.ForeColor = System.Drawing.Color.Blue;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.StylePriority.UseForeColor = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.Text = "Đơn Giá";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell6.Weight = 0.703594644195322D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrTableCell3.ForeColor = System.Drawing.Color.Blue;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UseForeColor = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "Thành Tiền(USD)";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell3.Weight = 1.2005030588150869D;
            // 
            // xrLabelTieuDe
            // 
            this.xrLabelTieuDe.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold);
            this.xrLabelTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.xrLabelTieuDe.LocationFloat = new DevExpress.Utils.PointFloat(121.1714F, 14.16667F);
            this.xrLabelTieuDe.Name = "xrLabelTieuDe";
            this.xrLabelTieuDe.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelTieuDe.SizeF = new System.Drawing.SizeF(388.5417F, 44.875F);
            this.xrLabelTieuDe.StylePriority.UseFont = false;
            this.xrLabelTieuDe.StylePriority.UseForeColor = false;
            this.xrLabelTieuDe.StylePriority.UseTextAlignment = false;
            this.xrLabelTieuDe.Text = "Báo Cáo Tổng Doanh Thu";
            this.xrLabelTieuDe.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.lbDiachi,
            this.lbDienThoai1});
            this.GroupHeader2.HeightF = 125.0001F;
            this.GroupHeader2.Level = 1;
            this.GroupHeader2.Name = "GroupHeader2";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(27.42132F, 25F);
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
            this.lbDiachi.LocationFloat = new DevExpress.Utils.PointFloat(27.42132F, 62.5F);
            this.lbDiachi.Name = "lbDiachi";
            this.lbDiachi.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDiachi.SizeF = new System.Drawing.SizeF(388.7695F, 23F);
            this.lbDiachi.StylePriority.UseFont = false;
            this.lbDiachi.StylePriority.UseForeColor = false;
            this.lbDiachi.StylePriority.UseTextAlignment = false;
            this.lbDiachi.Text = "Địa chỉ: 100 Nguyễn Lương Bằng, Phường Tân Phú, Q.7, TP.HCM";
            this.lbDiachi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbDienThoai1
            // 
            this.lbDienThoai1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lbDienThoai1.ForeColor = System.Drawing.Color.Blue;
            this.lbDienThoai1.LocationFloat = new DevExpress.Utils.PointFloat(27.42132F, 87.5F);
            this.lbDienThoai1.Name = "lbDienThoai1";
            this.lbDienThoai1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDienThoai1.SizeF = new System.Drawing.SizeF(249.6933F, 23F);
            this.lbDienThoai1.StylePriority.UseFont = false;
            this.lbDienThoai1.StylePriority.UseForeColor = false;
            this.lbDienThoai1.StylePriority.UseTextAlignment = false;
            this.lbDienThoai1.Text = "Điện thoại: 08.541 369 24 - 08.541 369 25";
            this.lbDienThoai1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbTongThanhTien
            // 
            this.lbTongThanhTien.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbTongThanhTien.LocationFloat = new DevExpress.Utils.PointFloat(362.5856F, 13.12501F);
            this.lbTongThanhTien.Name = "lbTongThanhTien";
            this.lbTongThanhTien.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbTongThanhTien.SizeF = new System.Drawing.SizeF(162.5001F, 23F);
            this.lbTongThanhTien.StylePriority.UseFont = false;
            this.lbTongThanhTien.StylePriority.UseTextAlignment = false;
            this.lbTongThanhTien.Text = "Tổng Thành Tiền:";
            this.lbTongThanhTien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lbTongTT
            // 
            this.lbTongTT.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lbTongTT.ForeColor = System.Drawing.Color.Red;
            this.lbTongTT.LocationFloat = new DevExpress.Utils.PointFloat(525.0858F, 13.12501F);
            this.lbTongTT.Name = "lbTongTT";
            this.lbTongTT.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbTongTT.SizeF = new System.Drawing.SizeF(90.99051F, 23F);
            this.lbTongTT.StylePriority.UseFont = false;
            this.lbTongTT.StylePriority.UseForeColor = false;
            this.lbTongTT.Text = "lbTongTT";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.lbTienBChu,
            this.xrLabel2,
            this.lbNgayInBaoCao,
            this.xrLabel4,
            this.lbTongTT,
            this.lbTongThanhTien});
            this.GroupFooter1.HeightF = 176.0417F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(238.3971F, 52.04163F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(121.3159F, 23F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Số tiền bằng chữ:";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lbTienBChu
            // 
            this.lbTienBChu.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbTienBChu.LocationFloat = new DevExpress.Utils.PointFloat(359.713F, 52.04163F);
            this.lbTienBChu.Name = "lbTienBChu";
            this.lbTienBChu.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbTienBChu.SizeF = new System.Drawing.SizeF(254.618F, 23F);
            this.lbTienBChu.StylePriority.UseFont = false;
            this.lbTienBChu.StylePriority.UseTextAlignment = false;
            this.lbTienBChu.Text = "lbTienBChu";
            this.lbTienBChu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(364.669F, 87.5F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(142.7083F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "Ngày in báo cáo:";
            // 
            // lbNgayInBaoCao
            // 
            this.lbNgayInBaoCao.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbNgayInBaoCao.LocationFloat = new DevExpress.Utils.PointFloat(507.3773F, 87.5F);
            this.lbNgayInBaoCao.Name = "lbNgayInBaoCao";
            this.lbNgayInBaoCao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbNgayInBaoCao.SizeF = new System.Drawing.SizeF(106.9536F, 22.99998F);
            this.lbNgayInBaoCao.StylePriority.UseFont = false;
            this.lbNgayInBaoCao.Text = "NgayIn";
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.xrLabel4.ForeColor = System.Drawing.Color.Black;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(400.676F, 126.0417F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(178.125F, 23F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseForeColor = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Người Lập Báo Cáo";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(295.6887F, 10.00001F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(64.02435F, 23F);
            // 
            // rptBaoCaoTongDoanhThu
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeader1,
            this.GroupHeader2,
            this.GroupFooter1,
            this.PageFooter});
            this.Margins = new System.Drawing.Printing.Margins(100, 101, 101, 100);
            this.Version = "11.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTableTongDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.XRLabel xrLabelTieuDe;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell STT;
        private DevExpress.XtraReports.UI.XRTableCell MaDDH;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRLabel lbTongTT;
        private DevExpress.XtraReports.UI.XRLabel lbTongThanhTien;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel lbDiachi;
        private DevExpress.XtraReports.UI.XRLabel lbDienThoai1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        public DevExpress.XtraReports.UI.XRLabel lbNgayInBaoCao;
        private DevExpress.XtraReports.UI.XRLabel lbTienBChu;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
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
