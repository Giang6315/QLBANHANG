using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QLBANHANG.DataAccessLayer;
using QLBANHANG.Report;
using System.Data.SqlClient;
using QLBANHANG.BussinessLogicLayer;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmBaoCaoDoanhThuThang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmBaoCaoDoanhThuThang()
        {
            InitializeComponent();
        }
        CDatabase db = new CDatabase();
        CBaoCaoDoanhThu BC = new CBaoCaoDoanhThu();
        public void LayDanhSachThang()
        {
            cbChonThang.Items.Add("--Vui lòng chọn--");
            cbChonThang.SelectedIndex = 0;
            for (int i = 1; i <= 12; i++)
            {
                cbChonThang.Items.Add(i.ToString());
            }
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
        
        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
           
            BC = new CBaoCaoDoanhThu();
            rptBaoCaoDoanhThuTheoThang rpt = new rptBaoCaoDoanhThuTheoThang();
            rpt.DataSource = BC.LayDanhThuTheoThang_report(cbChonThang.SelectedItem.ToString(), cbChonNam.SelectedItem.ToString());
            rpt.BindBaoCaoDoanhThuTheoThang();
            rpt.lbThang.Text = cbChonThang.Text + "/" + cbChonNam.Text;
            rpt.lbTongTien.Text = BC.LayTongDoanhThuTheoThang(cbChonThang.SelectedItem.ToString(), cbChonNam.SelectedItem.ToString()).Rows[0][0].ToString();
            CDocTongThanhTien obj = new CDocTongThanhTien();
            if (rpt.lbTongTien.Text != "")
            {
                rpt.lbTienBChu.Text = obj.converNumToString(obj.slipArray(rpt.lbTongTien.Text)) + "đô la";
                printControlBaoCaoDoanhThuTheoThang.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument();
            }
            else
                MessageBox.Show("Không có doanh thu tháng hiện tại! Mời bạn chọn tháng khác!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmBaoCaoDoanhThu_Preview_Load(object sender, EventArgs e)
        {
            LayDanhSachThang();
            LayDanhSachNam();
        }

   
        
      

       
        
    }
}

