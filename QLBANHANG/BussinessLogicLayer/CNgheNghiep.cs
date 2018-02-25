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
    class CNgheNghiep
    {
        CDatabase db = new CDatabase();
        DataTable dt = new DataTable();
        public DataTable HienThiNghe()
        {
            return db.ExecuteBang("SELECT * FROM NGHENGHIEP");
        }

        public void ThemLV(string ten)
        {
            string proc = "SP_NGHENGHIEP N'" + ten + "'";
            try
            {
                dt = db.ExecuteBang(proc);
                MessageBox.Show("Thêm nghề thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Thêm nghề không thành công \n " + "\n Lỗi " + e.Message, "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void XoaLV(string ma)
        {
            string proc = "SP_XOANGHE '" + ma + "'";
            DialogResult kq=MessageBox.Show("Bạn có chắc muốn xóa nghề nghiệp này không? ", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(kq==DialogResult.Yes)
            {
            try
            {
                dt = db.ExecuteBang(proc);
                MessageBox.Show("Xóa nghề thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Xóa nghề không thành công \n " + "\n Lỗi " + e.Message, "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }
        }

        public void CapNhatLV(string ma, string ten)
        {
            string proc = "SP_SUANGHENGHIEP '" + ma + "',N'" + ten + "'";
            try
            {
                dt = db.ExecuteBang(proc);
                MessageBox.Show("Cập nhật nghề thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Cập nhật nghề không thành công \n " + "\n Lỗi " + e.Message, "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
