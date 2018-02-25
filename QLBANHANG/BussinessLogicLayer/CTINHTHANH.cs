using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QLBANHANG.DataAccessLayer;
namespace QLBANHANG.BussinessLogicLayer
{
    class CTINHTHANH
    {
        CDatabase db = new CDatabase();
        DataTable dt = new DataTable();
        string s;
        public DataTable LayDSTinhThanh()
        {
            return db.ExecuteBang("SELECT MATINH, TENTINH FROM TINHTHANH");
        }

        public void ThemTinhThanh(string TenTinh)
        {
            using (SqlCommand cmd = new SqlCommand("SP_THEMTINHTHANH"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TENTINH", SqlDbType.NVarChar).Value = TenTinh;
                try
                {
                    db.ThucThiLenh(cmd);
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi!" + ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void XoaTinhThanh(string MaTinh)
        {
            using (SqlCommand cmd = new SqlCommand("SP_XOATINHTHANH"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MATINH", SqlDbType.Char).Value = MaTinh;
                DialogResult kq = MessageBox.Show("Bạn có chắc là muốn xóa tỉnh thành này?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (kq == DialogResult.Yes)
                {
                    try
                    {
                        db.ThucThiLenh(cmd);
                        MessageBox.Show("Xóa dữ liệu thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi!" + ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        public void CapNhatTinhThanh(string MaTinh,string TenTinh)
        {
            using (SqlCommand cmd = new SqlCommand("SP_SUATINHTHANH"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MATINH", SqlDbType.Char).Value = MaTinh;
                cmd.Parameters.Add("@TENTINH", SqlDbType.NVarChar).Value = TenTinh;
                try
                {
                    db.ThucThiLenh(cmd);
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi!" + ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
