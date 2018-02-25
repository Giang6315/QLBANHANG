using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLBANHANG.Report
{
    public partial class rptXuatKhachHang : DevExpress.XtraReports.UI.XtraReport
    {
        public rptXuatKhachHang()
        {
            InitializeComponent();
        }
        int STT;
        private void colSTT_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            STT++;
            colSTT.Text = STT.ToString();
        }
        public void BindDanhSachKhachHang()
        {
            colMaKH.DataBindings.Add("Text", DataSource, "MAKH");
            colTenKH.DataBindings.Add("Text", DataSource, "HOTENKH");
            colDienThoai.DataBindings.Add("Text", DataSource, "DIENTHOAIKH");
        }
    }
}
