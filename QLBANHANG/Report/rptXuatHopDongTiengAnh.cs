using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLBANHANG.Report
{
    public partial class rptXuatHopDongTiengAnh : DevExpress.XtraReports.UI.XtraReport
    {
        public rptXuatHopDongTiengAnh()
        {
            InitializeComponent();
        }
        public void BindHopDong()
        {
            colTenSP.DataBindings.Add("Text", DataSource, "TENSP");
            colSoLuong.DataBindings.Add("Text", DataSource, "SOLUONGHD");
            colDonGia.DataBindings.Add("Text", DataSource, "DONGIACHINHTHUC");
            colThanhTien2.DataBindings.Add("Text", DataSource, "THANHTIEN");
        }
    }
}
