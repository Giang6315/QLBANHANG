using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLBANHANG.DataAccessLayer;

namespace QLBANHANG.BussinessLogicLayer
{
    class CTraCuuDDH
    {
        CDatabase db = new CDatabase();
        public DataTable LayMaDDH()
        {
            return db.ExecuteBang("SELECT MADDH FROM DONDATHANG");
        }
        public DataTable LayMaKH()
        {
            return db.ExecuteBang("SELECT MAKH FROM KHACHHANG");
        }
        public DataTable TraCuuTheoMaDDH(string maddh)
        {
            return db.ExecuteBang("SELECT * FROM DONDATHANG WHERE MADDH='" + maddh + "'");
        }

        public DataTable TraCuuTheoMaKH(string makh)
        {
            return db.ExecuteBang("SELECT * FROM DONDATHANG WHERE MAKH='" + makh + "'");
        }

        public DataTable TraCuuTheoThoiGian(string tungay, string denngay)
        {
            return db.ExecuteBang("SELECT * FROM DONDATHANG WHERE NGAYDAT >='" + tungay + "' AND NGAYDAT <='" + denngay + "'");
        }

        public DataTable HienThiSPTheoMaDDH(string maddh)
        {
            return db.ExecuteBang("SELECT CTDDH.MASP, A.TENSP, SOLUONGDAT, A.DONGIATHAMKHAO FROM CTDDH INNER JOIN (SELECT MASP,  TENSP, DONGIATHAMKHAO FROM SANPHAM) A ON CTDDH.MASP=A.MASP WHERE MADDH='" + maddh + "'");
        }
    }
}
