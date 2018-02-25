using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLBANHANG.DataAccessLayer;
using QLBANHANG.BussinessLogicLayer;
namespace QLBANHANG.BussinessLogicLayer
{
    class CLoaiKH
    {
        CDatabase db = new CDatabase();
        DataTable dt = new DataTable();
        public DataTable HienThiLoaiKH()
        {
            return db.ExecuteBang("SELECT * FROM LOAIKHACHHANG");
        }

        public void CapNhatLoaiKH(string ma, string ten)
        {
            string proc = "SP_SUALOAIKHACHHANG '" + ma + "',N'" + ten + "'";
            try
            {
                dt = db.ExecuteBang(proc);
                MessageBox.Show("Cập nhật loại khách hàng thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Cập nhật loại khách hàng không thành công \n" + "\n Lỗi " + e.Message, "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        public void ThemLoaiKH(string ten)
        {
            string proc = "SP_THEMLOAIKHACHHANG N'" + ten + "'";
            try
            {
                dt = db.ExecuteBang(proc);
                MessageBox.Show("Thêm loại khách hàng thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Thêm loại khách hàng không thành công \n" + "\n Lỗi " + e.Message, "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        public void XoaLoaiKH(string ma)
        {
            string proc = "SP_XOALOAIKHACHHANG '" + ma + "'";
            DialogResult kq = MessageBox.Show("Bạn có chắc là muốn xóa loại khách hàng này không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    dt = db.ExecuteBang(proc);
                    MessageBox.Show("Xóa loại khách hàng thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Xóa loại khách hàng không thành công \n" + "\n Lỗi " + e.Message, "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
