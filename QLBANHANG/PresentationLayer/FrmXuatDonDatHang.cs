using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using QLBANHANG.DataAccessLayer;
using QLBANHANG.BussinessLogicLayer;
using QLBANHANG.Report;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmXuatDonDatHang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmXuatDonDatHang()
        {
            InitializeComponent();
        }
        CDatabase db = new CDatabase();
        public DataTable LayDSDonDatHang()
        {
            return db.ExecuteBang("SELECT MADDH FROM DONDATHANG");
        }
        public void HienThi()
        {
            lkeMaDDH.Properties.DataSource = LayDSDonDatHang();
            lkeMaDDH.Properties.ValueMember = "MADDH";
            lkeMaDDH.Properties.DisplayMember = "MADDH";
        }
        private void frmXuatDonDatHang_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        CBaoCaoDoanhThu BC = new CBaoCaoDoanhThu();
        CDocTongThanhTien obj = new CDocTongThanhTien();
        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (lkeMaDDH.Text == "--Vui lòng chọn--")
            {
                XtraMessageBox.Show("Bạn chưa chọn mã đơn đặt hàng", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                rptXuatDonDatHang rpt = new rptXuatDonDatHang();
                DataTable dt = new DataTable();
                dt = db.ExecuteBang("EXEC SP_LAYDSDONDATHANG '" + lkeMaDDH.Text + "'");
                if (dt.Rows.Count != 0)
                {
                    rpt.xrlbNgayDat.Text = Convert.ToDateTime(dt.Rows[0]["ngaydat"]).ToShortDateString();
                    rpt.xrlbMaDDH.Text = lkeMaDDH.Text;
                    rpt.xrlbTenKH.Text = dt.Rows[0]["hotenkh"].ToString();
                    rpt.xrlbDiaChi.Text = dt.Rows[0]["Dchikh"].ToString();
                    rpt.xrlbDienThoai.Text = dt.Rows[0]["dienthoaikh"].ToString();
                    rpt.DataSource = BC.LayDSSanPham_Report(lkeMaDDH.Text);
                    rpt.BindXuatDonDatHang();
                    DataTable dt1 = new DataTable();
                    dt1 = db.ExecuteBang("SELECT SUM(SOLUONGDAT) AS TONGSO FROM CTDDH WHERE MADDH='"+lkeMaDDH.Text+"'");
                    rpt.xrlbSoLuong.Text = dt1.Rows[0]["TONGSO"].ToString();
                    rpt.xrlbTongtien.Text = BC.LayTongTienDDH_report(lkeMaDDH.Text).Rows[0][0].ToString();
                    rpt.xrlbSoTienVietBangChu.Text = obj.converNumToString(obj.slipArray(rpt.xrlbTongtien.Text)) + " đô la";

                }
                printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument();
            }
        }
    }
}