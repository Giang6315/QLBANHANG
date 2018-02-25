using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using QLBANHANG.Report;
using QLBANHANG.BussinessLogicLayer;
using QLBANHANG.DataAccessLayer;
using System.Data.SqlClient;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmKhachHangDatHangNhieuNhat : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmKhachHangDatHangNhieuNhat()
        {
            InitializeComponent();
        }
        CXuat5KhachHang kh = new CXuat5KhachHang();
        CDatabase db = new CDatabase();
        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            rptBaoCao5KhachHangDatHangNhieuNhat rpt = new rptBaoCao5KhachHangDatHangNhieuNhat();
            rpt.xrlbTuNgay.Text = Convert.ToDateTime(deTuNgay.Text).ToShortDateString();
            rpt.xrlbDenNgay.Text = Convert.ToDateTime(deDenNgay.Text).ToShortDateString();
            rpt.DataSource = kh.XuatDanhSachKhachHang_report(DateTime.Parse(deTuNgay.Text), DateTime.Parse(deDenNgay.Text));
            rpt.BindDanhSachKhachHang();
            printControl1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument(); 
        }

        private void FrmKhachHangDatHangNhieuNhat_Load(object sender, EventArgs e)
        {
            deTuNgay.Text = DateTime.Now.ToShortDateString();
            deDenNgay.Text = DateTime.Now.ToShortDateString();
        }
    }
}