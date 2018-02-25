using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLBANHANG.Report
{
    public partial class rptXuatSanPham : DevExpress.XtraReports.UI.XtraReport
    {
        public rptXuatSanPham()
        {
            InitializeComponent();
        }
        public void BindDanhSachSanPham()
        {
            colMaSanPham.DataBindings.Add("Text", DataSource, "MASP");
            colTenSanPham.DataBindings.Add("Text", DataSource, "TENSP");
            colDonViTinh.DataBindings.Add("Text", DataSource, "DONGIATHAMKHAO");
            colDonGia.DataBindings.Add("Text", DataSource, "TENDVI");
        }
    }
}
