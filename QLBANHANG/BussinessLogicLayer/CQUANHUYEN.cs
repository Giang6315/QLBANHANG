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
    class CQUANHUYEN
    {
        CDatabase db = new CDatabase();
        DataTable dt = new DataTable();
        string s;
        public DataTable LayDSQuanHuyen()
        {
            return db.ExecuteBang("SELECT MAHUYEN, TENHUYEN FROM QUANHUYEN");
        }
       
        public string LayMaTinhTuTenTinh(string tentinh)
        {
            try
            {
                dt = db.ExecuteBang("SELECT MATINH FROM TINHTHANH WHERE TENTINH=N'" + tentinh + "'");
                s = dt.Rows[0]["MATINH"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }
        public void ThemQuanHuyen(string TenHuyen)
        {
            using (SqlCommand cmd = new SqlCommand("SP_THEMQUANHUYEN"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TENHUYEN", SqlDbType.NVarChar).Value = TenHuyen;
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
        public void XoaQuanHuyen(string MaHuyen)
        {
            using (SqlCommand cmd = new SqlCommand("SP_XOAQUANHUYEN"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MAHUYEN", SqlDbType.Char).Value = MaHuyen;
                DialogResult kq = MessageBox.Show("Bạn có chắc là muốn xóa quận huyện này không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
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
        public void CapNhatQuanHuyen(string MaHuyen,  string TenHuyen)
        {
            using (SqlCommand cmd = new SqlCommand("SP_SUAQUANHUYEN"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MAHUYEN", SqlDbType.Char).Value = MaHuyen;
                cmd.Parameters.Add("@TENHUYEN", SqlDbType.NVarChar).Value = TenHuyen;
                try
                {
                    db.ThucThiLenh(cmd);
                    MessageBox.Show("Cập nhật thành công!","Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi!" + ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
        }

        public DataTable LayDSHuyenCuaTinh(string matinh)
        {
            return db.ExecuteBang("SELECT QUANHUYEN.* FROM QUANHUYEN INNER JOIN (SELECT MAHUYEN FROM CTQH_TT WHERE MATINH='" + matinh + "') A ON QUANHUYEN.MAHUYEN=A.MAHUYEN");
        }


        public void ThemCTQH_TT(string mahuyen, string matinh)
        {
            string proc = " SP_THEM_CTQHTT '" + mahuyen + "','" + matinh + "'";
            try
            {
                dt = db.ExecuteBang(proc);
                MessageBox.Show("Thêm quận huyện cho tỉnh thành thành công", " Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                return;
            }
        }

        public void XoaCTQH_TT(string mahuyen, string matinh)
        {
            string sql = "SP_XOA_CTQHTT '" + mahuyen + "','" + matinh + "'";
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn xóa quận huyện này ra khỏi tỉnh thành không", "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    dt = db.ExecuteBang(sql);
                    MessageBox.Show("Xóa thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    return;
                }
            }
        }
    }
}
