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
    public partial class FrmBaoCaoDoanhThuNgay : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmBaoCaoDoanhThuNgay()
        {
            InitializeComponent();
        }
        CBaoCaoDoanhThu BC = new CBaoCaoDoanhThu();
        CDocTongThanhTien obj = new CDocTongThanhTien();
        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            
            rptBaoCaoDanhThuTheoNgay rpt = new rptBaoCaoDanhThuTheoNgay();
            rpt.lbTuNgay.Text = Convert.ToDateTime(deTuNgay.Text).ToShortDateString();
            rpt.lbDenNgay.Text = Convert.ToDateTime(deDenNgay.Text).ToShortDateString();
            DateTime tungay = DateTime.Parse(deTuNgay.Text);
            DateTime denngay = DateTime.Parse(deDenNgay.Text);
            rpt.DataSource = BC.LayDanhThuTheoNgay_report(tungay, denngay);
            rpt.BindBaoCaoDoanhThuTheoNgay();
            rpt.lbTongTT.Text = BC.LayTongDoanhThuTheoNgay(deTuNgay.Text, deDenNgay.Text).Rows[0][0].ToString();
            if (rpt.lbTongTT.Text != "")
            {
                rpt.lbTienBChu.Text = obj.converNumToString(obj.slipArray(rpt.lbTongTT.Text)) + "đô la";
                printControlBaoCaoNgay.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument();
            }
            else
                MessageBox.Show("Không có doanh thu ngày hiện tại! Mời bạn chọn ngày khác!","Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void FrmBaoCaoDoanhThuNgay_Load(object sender, EventArgs e)
        {
            deTuNgay.Text = DateTime.Now.ToShortDateString();
            deDenNgay.Text = DateTime.Now.ToShortDateString();
        }
    }
}