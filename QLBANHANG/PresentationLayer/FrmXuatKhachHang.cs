using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;
using QLBANHANG.DataAccessLayer;
using QLBANHANG.BussinessLogicLayer;
using QLBANHANG.Report;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmXuatKhachHang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmXuatKhachHang()
        {
            InitializeComponent();
        }
        CXuatKhachHang KH = new CXuatKhachHang();
        public void HienThiCombobox()
        {
            cbTenLoai.Items.Add("--Vui lòng chọn--");
            cbTenLoai.SelectedIndex = 0;
            for (int i = 0; i < KH.LayDSKhachHang().Rows.Count; i++)
            {
                cbTenLoai.Items.Add(KH.LayDSKhachHang().Rows[i]["tenloaikh"].ToString());
            }
        }
        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            rptXuatKhachHang rpt = new rptXuatKhachHang();
            rpt.DataSource = KH.XuatKhachHang_report(KH.LayTenLoaiTuMaLoaiKH(cbTenLoai.Text));
            rpt.BindDanhSachKhachHang();
            printControl1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }

        private void FrmXuatKhachHang_Load(object sender, EventArgs e)
        {
            HienThiCombobox();
        }
    }
}