using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLBANHANG.Report
{
    public partial class rptSPDatNhieu : DevExpress.XtraReports.UI.XtraReport
    {
        public rptSPDatNhieu()
        {
            InitializeComponent();
        }
        public void BindDanhSachSanPham()
        {
            colMaSanPham.DataBindings.Add("Text", DataSource, "MASP");
            colTenSanPham.DataBindings.Add("Text", DataSource, "TENSP");
            colDonViTinh.DataBindings.Add("Text", DataSource, "SOLUONGDAT");
        }
    }
}
