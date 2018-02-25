using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLBANHANG.BussinessLogicLayer;
using QLBANHANG.DataAccessLayer;
namespace QLBANHANG.BussinessLogicLayer
{
    class CTonGiao
    {
        DataTable dt = new DataTable();
        CDatabase db = new CDatabase();
        public DataTable HienThiTonGiao()
        {
            return db.ExecuteBang("SELECT * FROM TONGIAO");
        }

        public void ThemTonGiao(string ten)
        {
            string proc = "SP_THEMTONGIAO N'" + ten + "'";
            try
            {
                dt = db.ExecuteBang(proc);
                MessageBox.Show("Thêm tôn giáo thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Thêm tôn giáo không thành công \n" + "\n Lỗi " + e.Message, "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void XoaTonGiao(string ma)
        {
            string proc = "SP_XOATONGIAO '" + ma + "'";
            DialogResult kq = MessageBox.Show("Bạn có chắc là muốn xóa tôn giáo này?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    dt = db.ExecuteBang(proc);
                    MessageBox.Show("Xóa tôn giáo thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Xóa tôn giáo không thành công \n" + "\n Lỗi " + e.Message, "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void CapNhatTonGiao(string ma, string ten)
        {
            string proc = "SP_SUATONGIAO '" + ma + "',N'" + ten + "'";
            try
            {
                dt = db.ExecuteBang(proc);
                MessageBox.Show("Cập nhật tôn giáo thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Cập nhật tôn giáo không thành công \n" + "\n Lỗi " + e.Message, "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
