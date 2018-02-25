using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLBANHANG.DataAccessLayer;
namespace QLBANHANG.BussinessLogicLayer
{
    class CXuat5KhachHang
    {
        CDatabase db = new CDatabase();
        public DataTable XuatDanhSachKhachHang_report(DateTime tungay, DateTime denngay)
        {
            return db.ExecuteBang("exec  SP_KHACHHANGDATHANGNHIEUNHAT '" + tungay + "','" + denngay + "'");
        }
    }
}
