using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QLBANHANG.BussinessLogicLayer;
using QLBANHANG.DataAccessLayer;
namespace QLBANHANG.BussinessLogicLayer
{
    class CNhomTuoi
    {
        CDatabase db = new CDatabase();
        DataTable dt = new DataTable();
        public DataTable HienThiNhomTuoi()
        {
            return db.ExecuteBang("SELECT * FROM NHOMTUOI");
        }

        public void ThemNhomTuoi(string ten, int tuoitu, int tuoiden)
        {
            string proc = "SP_THEMNHOMTUOI N'" + ten + "'," + tuoitu + "," + tuoiden;
            try
            {
                dt = db.ExecuteBang(proc);
                MessageBox.Show("Thêm nhóm tuổi thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Thêm nhóm tuổi không thành công \n" + "\n Lỗi " + e.Message, "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        public void XoaNhomTuoi(string ma)
        {
            string proc = "SP_XOANHOMTUOI '" + ma + "'";
            DialogResult kq = MessageBox.Show("Bạn có chắc là muốn xóa nhóm tuổi này không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    dt = db.ExecuteBang(proc);
                    MessageBox.Show("Xóa nhóm tuổi thành công ", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Xóa nhóm tuổi không thành công \n" + "\n Lỗi " + e.Message, "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }
        }

        public void CapNhatNhomTuoi(string ma, string ten, int tuoitu, int tuoiden)
        {
            string proc = "SP_SUANHOMTUOI '" + ma + "',N'" + ten +  "'," + tuoitu + "," + tuoiden;
            try
            {
                dt = db.ExecuteBang(proc);
                MessageBox.Show("Sửa nhóm tuổi thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Sửa nhóm tuổi không thành công \n" + "\n Lỗi " + e.Message, "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }
    }
}
