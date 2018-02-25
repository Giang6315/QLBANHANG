using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using QLBANHANG.BussinessLogicLayer;
namespace QLBANHANG.Report
{
    public partial class rptBaoCao5KhachHangDatHangNhieuNhat : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBaoCao5KhachHangDatHangNhieuNhat()
        {
            InitializeComponent();
        }
        CXuat5KhachHang kh = new CXuat5KhachHang();
        public void BindDanhSachKhachHang()
        {
            
           
            colMaKH.DataBindings.Add("Text", DataSource, "MAKH");
            colTenKH.DataBindings.Add("Text", DataSource, "HOTENKH");
            colDiaChi.DataBindings.Add("Text", DataSource, "DCHIKH");
            colSoLuong.DataBindings.Add("Text", DataSource, "SOLUONGDAT");
          
            
        }
      
    }
}
