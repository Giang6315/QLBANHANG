using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLBANHANG.DataAccessLayer;
namespace QLBANHANG.BussinessLogicLayer
{
    class CDocSoTiengAnh
    {   
        public static string DocSoTiengAnh(string number)
        {
            CDatabase db = new CDatabase();
            DataTable dt = new DataTable();
            dt = db.ExecuteBang(string.Format("SELECT dbo.F_DOCSOTHANHTU({0})", number));
            return dt.Rows[0][0].ToString();
        }
    }
}
