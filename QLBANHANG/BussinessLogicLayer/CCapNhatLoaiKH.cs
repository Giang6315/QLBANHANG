using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLBANHANG.DataAccessLayer;
using DevExpress.XtraEditors;
namespace QLBANHANG.BussinessLogicLayer
{
    class CCapNhatLoaiKH
    {
        CDatabase db = new CDatabase();
        public DataTable LayDSKhachHang()
        {
            return db.ExecuteBang("SELECT MAKH, HOTENKH, DCHIKH, DIENTHOAIKH,LADN, TENLOAIKH FROM KHACHHANG INNER JOIN LOAIKHACHHANG ON KHACHHANG.MALOAIKH=LOAIKHACHHANG.MALOAIKH");
        }
        public void CapNhatLoaiKhachHang()
        {
            SqlCommand cmd = new SqlCommand("sp_capnhatloaikhachhang");
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                db.ThucThiLenh(cmd);
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Lỗi " + e.Message);
            }
        }
        public DataTable LayDSKhachHangChinhThucQuaHan()
        {
            return db.ExecuteBang("SELECT MAKH, HOTENKH, DCHIKH, DIENTHOAIKH,LADN, TENLOAIKH FROM KHACHHANG INNER JOIN LOAIKHACHHANG ON KHACHHANG.MALOAIKH=LOAIKHACHHANG.MALOAIKH WHERE NOT EXISTS(SELECT * FROM DONDATHANG WHERE KHACHHANG.MAKH=DONDATHANG.MAKH AND NGAYDAT > DATEADD(M, -6, CURRENT_TIMESTAMP)) AND LOAIKHACHHANG.MALOAIKH='L3' and LOAIKHACHHANG.MALOAIKH <> 'L1'");
        }
        public DataTable LayDSKhachHangThanThietQuaHan()
        {
            return db.ExecuteBang("SELECT MAKH, HOTENKH, DCHIKH, DIENTHOAIKH,LADN, TENLOAIKH FROM KHACHHANG INNER JOIN LOAIKHACHHANG ON KHACHHANG.MALOAIKH=LOAIKHACHHANG.MALOAIKH WHERE NOT EXISTS(SELECT * FROM DONDATHANG WHERE KHACHHANG.MAKH=DONDATHANG.MAKH AND NGAYDAT > DATEADD(M, -12, CURRENT_TIMESTAMP)) AND LOAIKHACHHANG.MALOAIKH='L2' and LOAIKHACHHANG.MALOAIKH <>'L1'");

        }
        public void CapNhatKhachHangChinhThucQuaHan()
        {
            SqlCommand cmd = new SqlCommand("sp_CapNhatKhachHangChinhThucQuaHan");
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                db.ThucThiLenh(cmd);
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Lỗi " + e.Message);
            }
        }

        public void CapNhatKhachHangThanThietQuaHan()
        {
            SqlCommand cmd = new SqlCommand("sp_CapNhatKhachHangThanThietQuaHan");
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                db.ThucThiLenh(cmd);
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("Lỗi " + e.Message);
            }
        }

    }
}
