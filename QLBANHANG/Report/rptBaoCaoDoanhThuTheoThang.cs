using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QLBANHANG.BussinessLogicLayer;
namespace QLBANHANG.Report
{
    public partial class rptBaoCaoDoanhThuTheoThang : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBaoCaoDoanhThuTheoThang()
        {
            InitializeComponent();
        }
        int SoThuTu;
        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            SoThuTu++;
            colSTT.Text = SoThuTu.ToString();
        }
        CBaoCaoDoanhThu BC = new CBaoCaoDoanhThu();
       
        public void BindBaoCaoDoanhThuTheoThang()
        {
            colMaDDH.DataBindings.Add("Text", DataSource, "MADDH");
            colTenSP.DataBindings.Add("Text", DataSource, "TENSP");
            colSoLuong.DataBindings.Add("Text", DataSource, "SOLUONGDAT");
            colDonGia.DataBindings.Add("Text", DataSource, "DONGIATHAMKHAO");
            colThanhTien.DataBindings.Add("Text", DataSource, "THANHTIEN");
            int ngay = DateTime.Now.Day;
            int thang = DateTime.Now.Month;
            int nam = DateTime.Now.Year;
            lbNgayInBaoCao.Text = ngay.ToString() + "-" + thang.ToString() + "-" + nam.ToString();
            
        }

    }
}
