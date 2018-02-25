using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;
using QLBANHANG.BussinessLogicLayer;
using System.Data;
using System.Data.SqlClient;
namespace QLBANHANG.Report
{
    public partial class rptBaoCaoTongDoanhThu : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBaoCaoTongDoanhThu()
        {
            InitializeComponent();
        }
        int SoThuTu;
        private void Detail_BeforePrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
             SoThuTu++;
             colSTT.Text = SoThuTu.ToString();
             //xrLabel3.Text = "Trang " + SoThuTu.ToString();
        }
        CBaoCaoDoanhThu BC = new CBaoCaoDoanhThu();
        CDocTongThanhTien obj = new CDocTongThanhTien();
        public void BindDanhSachDonDatHang()
        {
            BC = new CBaoCaoDoanhThu();
            colMaDDH.DataBindings.Add("Text", DataSource, "MADDH");
            colTenSP.DataBindings.Add("Text", DataSource, "TENSP");
            colSoLuong.DataBindings.Add("Text", DataSource, "SOLUONGDAT");
            colDonGia.DataBindings.Add("Text", DataSource, "DONGIATHAMKHAO");
            colThanhTien.DataBindings.Add("Text", DataSource, "THANHTIEN");
            int ngay = DateTime.Now.Day;
            int thang = DateTime.Now.Month;
            int nam = DateTime.Now.Year;
            lbNgayInBaoCao.Text = ngay.ToString() + "-" + thang.ToString() + "-" + nam.ToString();
            lbTongTT.Text = BC.LayTongDoanhThuTatCa_report().Rows[0]["THANHTIEN"].ToString();
            lbTienBChu.Text = obj.converNumToString(obj.slipArray(lbTongTT.Text)) +" đô la";
        }


    }

 }
