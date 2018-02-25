using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLBANHANG.DataAccessLayer;

namespace QLBANHANG.BussinessLogicLayer
{
    class CChucVu
    {
        CDatabase db = new CDatabase();
        DataTable dt = new DataTable();

        public DataTable HienThiChiTiet()
        {
            return db.ExecuteBang("SELECT * FROM CHUCVU");
        }

        public void ThemChucVu(string tencv)
        {
            string sql = "SP_THEM_CV N'" + tencv + "'";
            try
            {
                db.ExecuteLenh(sql);
                MessageBox.Show("Thêm chức vụ thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm chức vụ không thành công \n" + "\n Lỗi \t" + ex.Message, "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void XoaChucVu(string macv)
        {
            DialogResult kq= MessageBox.Show("Bạn có chắc muốn xóa chức vụ này không?", "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            string sql = "SP_XOA_CV '" + macv + "'";
            try
            {
                db.ExecuteLenh(sql);
                MessageBox.Show("Xoá chức vụ thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xóa chức vụ không thành công \n" + "\n Lỗi" + ex.Message, "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void CapNhatCV(string macv, string tencv)
        {
            string sql = "SP_CAPNHAT_CV '" + macv + "',N'" + tencv + "'";
            try
            {
                db.ExecuteLenh(sql);
                MessageBox.Show("Cập nhật chức vụ thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật chức vụ không thành công \n" + "\n Lỗi " + ex.Message, "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
