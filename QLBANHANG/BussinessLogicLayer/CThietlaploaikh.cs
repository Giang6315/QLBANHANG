using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using QLBANHANG.DataAccessLayer;

namespace QLBANHANG.BussinessLogicLayer
{
    class CThietlaploaikh
    {
        CDatabase db = new CDatabase();
        public void ThietLapLoaiKH(int thoihanthanthiet, int thoihanchinhthuc, float nguongcanhan, float nguongdoanhnghiep)
        {
            string sql="UPDATE THIETLAPLOAIKH SET THOIHANTHANTHIET=" + thoihanthanthiet + ", THOIHANCHINHTHUC=" + thoihanchinhthuc + ", NGUONGCANHAN=" + nguongcanhan + ",NGUONGDOANHNGHIEP=" + nguongdoanhnghiep + " WHERE MATL='TL1'";
            db.ExecuteBang(sql);
        }
    }
}
