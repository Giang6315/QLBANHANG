using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLBANHANG.DataAccessLayer;
namespace QLBANHANG.BussinessLogicLayer
{
    class CThongTinDDH
    {
        CDatabase db = new CDatabase();
        DataTable dt = new DataTable();

        public DataTable HienThiDSDDH()
        {
            return db.ExecuteBang("SELECT MADDH, MAKH, NGAYDAT FROM DONDATHANG");
        }
    }
}
