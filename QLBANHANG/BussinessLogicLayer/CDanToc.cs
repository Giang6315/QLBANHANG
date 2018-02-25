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
    class CDanToc
    {
        CDatabase db = new CDatabase();
        DataTable dt = new DataTable();
        public DataTable HienThiDanToc()
        {
            return db.ExecuteBang("SELECT * FROM DANTOC");
        }

        public void ThemDanToc(string ten)
        {
            string proc = "SP_THEMDANTOC N'" + ten + "'";
            try {
                dt = db.ExecuteBang(proc);
                MessageBox.Show("Thêm dân tộc thành công", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e) {
                MessageBox.Show("Thêm dân tộc không thành công \n" + "\n Lỗi " + e.Message, "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        public void XoaDanToc(string ma)
        {
            string proc = "SP_XOADANTOC '" + ma + "'";
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn xóa dân tộc này không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    dt = db.ExecuteBang(proc);
                    MessageBox.Show("Xóa dân tộc thành công", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Xóa dân tộc không thành công \n" + "\n Lỗi " + e.Message, "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }
        }

        public void CapNhatDanToc(string ma, string ten)
        {
            string proc = "SP_SUADANTOC '" + ma + "',N'" + ten + "'";
            try
            {
                dt = db.ExecuteBang(proc);
                MessageBox.Show("Cập nhật dân tộc thành công", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Cập nhật dân tộc không thành công \n" + "\n Lỗi " + e.Message, "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }
    }
}
