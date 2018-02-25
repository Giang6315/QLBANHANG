using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLBANHANG.BussinessLogicLayer;
using QLBANHANG.DataAccessLayer;
using System.Windows.Forms;
namespace QLBANHANG.BussinessLogicLayer
{
    class CCongTy
    {
        CDatabase db = new CDatabase();
        DataTable dt = new DataTable();
        public DataTable HienThiCongTy()
        {
            return db.ExecuteBang("SELECT * FROM CONGTY");
        }

        public void ThemCongTy(string ten, string dchi, string dthoai)
        {
            string proc = "SP_THEMCONGTY N'" + ten + "',N'" + dchi + "','" + dthoai + "'";
            try
            {
                dt = db.ExecuteBang(proc);
                MessageBox.Show("Thêm công ty thành công");
            }
            catch (Exception e) {
                MessageBox.Show("Thêm công ty không thành công \n" + "\n Lỗi " + e.Message, "Thông báo!!!");
            }
        }

        public void XoaCongTy(string ma)
        {
            string proc = "SP_XOACTY '" + ma + "'";
            try {
                dt = db.ExecuteBang(proc);
                MessageBox.Show("Xóa công ty thành công");
            }
            catch (Exception e) {
                MessageBox.Show("Xóa công ty không thành công \n " + "\n Lỗi " + e.Message, "Thông báo!!!");
            }
        }

        public void CapNhatCongTy(string ma, string ten, string dchi, string dthoai)
        {
            string proc = "SP_SUACONGTY '" + ma + "',N'" + ten + "',N'" + dchi + "','" + dthoai + "'";
            try
            {
                dt = db.ExecuteBang(proc);
                MessageBox.Show("Cập nhật công ty thành công");
            }
            catch (Exception e)
            {
                MessageBox.Show("Cập nhật công ty không thành công \n" + "\n Lỗi " + e.Message, "Thông báo!!!");
            }
        }
    }
}
