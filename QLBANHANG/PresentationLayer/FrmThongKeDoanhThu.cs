using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using QLBANHANG.DataAccessLayer;
using QLBANHANG.Report;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmThongKeDoanhThu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmThongKeDoanhThu()
        {
            InitializeComponent();
        }
        CDatabase db = new CDatabase();
        private void FrmThongKeDoanhThu_Preview_Load(object sender, EventArgs e)
        {
            dateEditDenNgay.Text = DateTime.Now.ToShortDateString();
            dateEditTuNgay.Text = DateTime.Now.ToShortDateString();
        }

        private void btnXemBieuDo_Click(object sender, EventArgs e)
        {
            if (dateEditTuNgay.Text != "" && dateEditDenNgay.Text != "")
            {
                rptThongKeDoanhThuTheoThoiGian rpt = new rptThongKeDoanhThuTheoThoiGian();
                DataTable dt = new DataTable();
                dt = db.ExecuteBang("SP_THONGKEDOANHTHUTHEOTHOIGIAN   '" + string.Format("{0:dd/MM/yyyy}",dateEditTuNgay.Text) + "','" + string.Format("{0:dd/MM/yyyy}",dateEditDenNgay.Text) + "'");
                rpt.xrChart1.DataSource = dt;
                rpt.xrChart1.Series[0].ArgumentDataMember = "THANG_NAM";
                rpt.xrChart1.Series[0].ValueDataMembers.AddRange(new string[] { "DOANH THU" });
                rpt.xrChart1.Legend.Visible = true;
                rpt.lbTuNgay.Text = string.Format("{0:dd/MM/yyyy}",dateEditTuNgay.Text);
                rpt.lbDenNgay.Text = string.Format("{0:dd/MM/yyyy}",dateEditDenNgay.Text);
                printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn thời gian cần thống kê!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        
    }
}