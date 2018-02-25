using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLBANHANG.DataAccessLayer;
namespace QLBANHANG.BussinessLogicLayer
{
    class CXuatKhachHang
    {
        CDatabase db = new CDatabase();
        string s;
        public DataTable LayDSKhachHang()
        {
            return db.ExecuteBang("select MALOAIKH, TENLOAIKH from LOAIKHACHHANG");
        }
        public DataTable XuatKhachHang_report(string maloaikh)
        {
            return db.ExecuteBang("SP_XUATDSKHACHHANGTHEOLOAI '" + maloaikh + "'");
        }
        public string LayTenLoaiTuMaLoaiKH(string tenloai)
        {
            DataTable dt = new DataTable();
            dt = db.ExecuteBang("select MALOAIKH from LOAIKHACHHANG where tenloaikh= N'" + tenloai + "'");
            s = dt.Rows[0]["MALOAIKH"].ToString();
            return s;
        }
    }
}
