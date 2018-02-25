using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;
using QLBANHANG.Report;
using QLBANHANG.DataAccessLayer;
using QLBANHANG.BussinessLogicLayer;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmBaoCaoTongDoanhThu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmBaoCaoTongDoanhThu()
        {
            InitializeComponent();
        }
        CBaoCaoDoanhThu BC = new CBaoCaoDoanhThu();
        private void FrmBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            rptBaoCaoTongDoanhThu rpt = new rptBaoCaoTongDoanhThu();
            rpt.DataSource = BC.LayTongDoanhThuTatCa_report();
            rpt.BindDanhSachDonDatHang();
            printControlBaoCaoDoanhThu.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
    }
}