using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QLBANHANG.BussinessLogicLayer;
namespace QLBANHANG.Report
{
    public partial class rptXuatDonDatHang : DevExpress.XtraReports.UI.XtraReport
    {
        public rptXuatDonDatHang()
        {
            InitializeComponent();
        }
     
        public void BindXuatDonDatHang()
        {
            colTenSP.DataBindings.Add("Text", DataSource, "tensp");
            colSoLuong.DataBindings.Add("Text", DataSource, "soluongdat");
            colDonGia.DataBindings.Add("Text", DataSource, "dongiathamkhao");
            colThanhTien.DataBindings.Add("Text", DataSource, "THANHTIEN");
            
        }
        int STT;
        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            STT++;
            colSTT.Text = STT.ToString();
        }

    }
}
