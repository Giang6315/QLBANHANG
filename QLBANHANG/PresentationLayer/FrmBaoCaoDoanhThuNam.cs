using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QLBANHANG.BussinessLogicLayer;
using QLBANHANG.Report;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmBaoCaoDoanhThuNam : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmBaoCaoDoanhThuNam()
        {
            InitializeComponent();
        }
        public void LayDanhSachNam()
        {
            cbChonNam.Items.Add("--Vui lòng chọn--");
            cbChonNam.SelectedIndex = 0;
            int nam = DateTime.Now.Year;
            for (int i = 1999; i <= nam; i++)
            {
                cbChonNam.Items.Add(i.ToString());
            }
        }
        private void FrmBaoCaoDoanhThuNam_Load(object sender, EventArgs e)
        {
            LayDanhSachNam();
        }
        CBaoCaoDoanhThu BC = new CBaoCaoDoanhThu();
        CDocTongThanhTien obj = new CDocTongThanhTien();
        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            BC = new CBaoCaoDoanhThu();
            rptBaoCaoDoanhThuNam rpt = new rptBaoCaoDoanhThuNam();
            rpt.DataSource = BC.LayDanhThuTheoNam_report(cbChonNam.SelectedItem.ToString());
            rpt.BindBaoCaoDoanhThuNam();
            rpt.lbNam.Text = cbChonNam.Text;
            rpt.lbTongTien.Text = BC.LayTongDoanhThuTheoNam(cbChonNam.Text).Rows[0][0].ToString();
            if (rpt.lbTongTien.Text != "")
            {
                rpt.lbTienBChu.Text = obj.converNumToString(obj.slipArray(rpt.lbTongTien.Text)) + "đô la";
                printControlBaoCaoNam.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument();
            }
            else
                MessageBox.Show("Không có doanh thu năm hiện tại! Mời bạn chọn năm khác!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
        }
       
    }
}