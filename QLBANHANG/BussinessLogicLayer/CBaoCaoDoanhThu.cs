using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLBANHANG.DataAccessLayer;
using System.Windows.Forms;
using DevExpress.XtraEditors;
namespace QLBANHANG.BussinessLogicLayer
{
    class CBaoCaoDoanhThu
    {
        CDatabase db = new CDatabase();
        public DataTable LayTongDoanhThuTatCa_report()
        {
            return db.ExecuteBang("	SELECT DH.MADDH, SP.TENSP, CT.SOLUONGDAT,SP.DONGIATHAMKHAO, SUM(CT.SOLUONGDAT*SP.DONGIATHAMKHAO) AS THANHTIEN FROM DONDATHANG DH INNER JOIN CTDDH CT ON DH.MADDH=CT.MADDH INNER JOIN SANPHAM SP ON SP.MASP=CT.MASP 	GROUP BY DH.MADDH, SP.TENSP, SOLUONGDAT, SP.DONGIATHAMKHAO");
        }
        public DataTable LayTongDoanhThu()
        {
            return db.ExecuteBang("SELECT SUM(a.THANHTIEN) as TT FROM (SELECT SUM(SOLUONGDAT*DONGIATHAMKHAO) AS THANHTIEN FROM SANPHAM SP, CTDDH CT,DONDATHANG DH WHERE CT.MASP=SP.MASP AND DH.MADDH=CT.MADDH)a");
        }
        public DataTable LayTongDoanhThuTheoNgay(string tungay, string denngay)
        {
            return db.ExecuteBang("SP_TINHTONGDOANHTHUTHEONGAY '" + tungay + "','" + denngay + "'");
        }
        public DataTable LayTongDoanhThuTheoThang(string thang, string nam)
        {
            return db.ExecuteBang("SELECT DBO.F_TONGDOANHTHUTHEOTHANG ('"+thang +"','"+ nam +"')");
        }
        public DataTable LayTongDoanhThuTheoNam(string nam)
        {
            return db.ExecuteBang("SP_TINHTONGDOANHTHUTHEONAM '" + nam + "'");
        }
        public DataTable LayDanhThuTheoNgay_report(DateTime tungay, DateTime denngay)
        {
            return db.ExecuteBang("EXEC SP_BAOCAODOANHTHUTHEONGAY '" + tungay + "','" + denngay + "'");
        }
        public DataTable LayDanhThuTheoThang_report(string thang, string nam)
        {
            return db.ExecuteBang("EXEC SP_BAOCAODOANHTHUSANPHAMTHEOTHANGNAM '" + thang + "','" + nam + "'");
        }
        public DataTable LayDanhThuTheoNam_report(string nam)
        {
            return db.ExecuteBang("EXEC SP_BAOCAODOANHTHUTHEONAM '" + nam + "'");
        }
        //public DataSet LayDanhThuTheoThang_report(string thang, string nam)
        //{
        //    db.sqlconn = new SqlConnection(@"Data Source=CAMVAN-PC\CAMVAN;Initial Catalog=QUANLYKHACHHANG;Persist Security Info=True;User ID=sa;Password=camvan");
        //    db.sqlconn.Open();
        //    DataSet ds = new DataSet();
        //    SqlCommand cmd = new SqlCommand("SP_BAOCAODOANHTHUSANPHAMTHEOTHANGNAM", db.sqlconn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add("@thang", SqlDbType.VarChar).Value = thang;
        //    cmd.Parameters.Add("@nam", SqlDbType.VarChar).Value = nam;
           
        //    try
        //    {
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(ds);
        //    }
        //    catch (Exception ex)
        //    {
        //        XtraMessageBox.Show("Lỗi: " + ex.Message);
        //    }
        //    return ds;
        //}
        //public DataSet LayDanhThuTheoNam_report(string nam)
        //{

        //    db.sqlconn = new SqlConnection(@"Data Source=CAMVAN-PC\CAMVAN;Initial Catalog=QUANLYKHACHHANG;Persist Security Info=True;User ID=sa;Password=camvan");
        //    db.sqlconn.Open();
        //    DataSet ds = new DataSet();
        //    SqlCommand cmd = new SqlCommand("SP_BAOCAODOANHTHUTHEONAM", db.sqlconn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add("@nam", SqlDbType.VarChar).Value = nam;

        //    try
        //    {
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(ds);
        //    }
        //    catch (Exception ex)
        //    {
        //        XtraMessageBox.Show("Lỗi: " + ex.Message);
        //    }
        //    return ds;
        //}
        //public DataSet LayDanhThuTheoNgay_report(DateTime tungay, DateTime denngay)
        //{
        //    db.sqlconn = new SqlConnection(@"Data Source=CAMVAN-PC\CAMVAN;Initial Catalog=QUANLYKHACHHANG;Persist Security Info=True;User ID=sa;Password=camvan");
        //    db.sqlconn.Open();
        //    DataSet ds = new DataSet();
        //    SqlCommand cmd = new SqlCommand("SP_BAOCAODOANHTHUTHEONGAY", db.sqlconn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add("@tungay", SqlDbType.DateTime).Value = tungay;
        //    cmd.Parameters.Add("@denngay", SqlDbType.DateTime).Value = denngay;
        //    try
        //    {
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(ds);
        //    }
        //    catch (Exception ex)
        //    {
        //        XtraMessageBox.Show("Lỗi: " + ex.Message);
        //    }
        //    return ds;
        //}
        //THONG KE DOANH THU CAC TINH
        public DataTable LayDanhSachTinh_report()
        {
            return db.ExecuteBang("SELECT MATINH, TENTINH FROM TINHTHANH");
        }
        public DataTable LayDanhSachSanPham_report()
        {
            return db.ExecuteBang("SELECT MASP, TENSP FROM SANPHAM");
        }
        //XUAT DON DAT HANG
        public DataTable LayDSSanPham_Report(string maddh)
        {
            return db.ExecuteBang("EXEC SP_LAYDSSANPHAM_REPORT '" + maddh + "'");
        }
        public DataTable LayTongTienDDH_report(string maddh)
        {
            return db.ExecuteBang("EXEC SP_LayTongThanhTien_DonDatHang '" + maddh + "'");
        }
    }
}
