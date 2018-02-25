using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLBANHANG.DataAccessLayer;
namespace QLBANHANG.BussinessLogicLayer
{
    class CXuatSanPham
    {
        CDatabase db = new CDatabase();
        string s;
        public string LayMaLoaiTuTenLoaiSP(string tenloai)
        {
            DataTable dt = new DataTable();
            dt = db.ExecuteBang("select MALOAI from LOAISANPHAM WHERE TENLOAI=N'" + tenloai + "'");
            s = dt.Rows[0]["MALOAI"].ToString();
            return s;
        }
        public DataTable LayDSSanPham()
        {
            return db.ExecuteBang("select MALOAI,TENLOAI from LOAISANPHAM");
        }
        public DataTable LayDSSanPham_report(string maloaisp)
        {
            return db.ExecuteBang("EXEC SP_XUATSANPHAMTHEOLOAI '"+maloaisp+"'");
        }

        public DataTable LaySPDatNhieu(string tungay, string denngay, string maloai)
        {
            return db.ExecuteBang("EXEC SP_SANPHAMDATHANGNHIEUNHAT '" + tungay + "','" + denngay + "','" + maloai + "'");
        }
    }
}
