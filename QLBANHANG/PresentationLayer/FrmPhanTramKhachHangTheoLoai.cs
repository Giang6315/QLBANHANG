using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QLBANHANG.DataAccessLayer;
using System.Data.SqlClient;
using DevExpress.XtraCharts;
using QLBANHANG.Report;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmPhanTramKhachHangTheoLoai : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmPhanTramKhachHangTheoLoai()
        {
            InitializeComponent();
        }
        CDatabase db = new CDatabase();
        private void FrmPhanTramKhachHangTheoLoai_Load(object sender, EventArgs e)
        {
            rptPhanTramKhachHangTheoLoai rpt = new rptPhanTramKhachHangTheoLoai();
            DataTable dt = new DataTable();
            dt = db.ExecuteBang("exec SP_THONGKEPHANTRAMLOAIKHACHHANG");
            rpt.xrChartTKKHTheoLoai.DataSource = dt;
            rpt.xrChartTKKHTheoLoai.Series[0].ArgumentDataMember = "TENLOAIKH";
            rpt.xrChartTKKHTheoLoai.Series[0].ValueDataMembers.AddRange(new string[] { "PHANTRAM" });
            rpt.xrChartTKKHTheoLoai.Series[0].PointOptions.PointView = PointView.ArgumentAndValues;
            rpt.xrChartTKKHTheoLoai.Series[0].PointOptions.ValueNumericOptions.Format = NumericFormat.Percent;
            rpt.xrChartTKKHTheoLoai.Series[0].PointOptions.ValueNumericOptions.Precision = 0;
            rpt.xrChartTKKHTheoLoai.Legend.Visible = true;
            printControl1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
    }
}