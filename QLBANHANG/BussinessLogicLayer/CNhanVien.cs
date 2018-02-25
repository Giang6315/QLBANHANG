using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLBANHANG.DataAccessLayer;
using QLBANHANG.PresentationLayer;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
namespace QLBANHANG.BussinessLogicLayer
{
    class CNhanVien
    {
        CDatabase db = new CDatabase();
        DataTable dt = new DataTable();
        string s;
        //Ham lay danh sach nhan vien

        public DataTable LayDSCV()
        {
            return db.ExecuteBang("SELECT * FROM CHUCVU");
        }

        public string LayMaCVTuTenCV(string tencv)
        {
            try
            {
                dt = db.ExecuteBang("SELECT MACV FROM CHUCVU WHERE TENCV=N'" + tencv + "'");
                s = dt.Rows[0][0].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }

        public string LayTenCVTuMaCV(string macv)
        {
            try
            {
                dt = db.ExecuteBang("SELECT TENCV FROM CHUCVU WHERE MACV='" + macv + "'");
                s = dt.Rows[0][0].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }

        public DataTable LayDanhSachNhanVien()
        {
            string s = "SELECT MANV, HOTENNV, DIENTHOAINV, a.TENCV FROM NHANVIEN inner join (select macv, tencv from chucvu) a on nhanvien.macv=a.macv";
            return db.ExecuteBang(s);
        }
        public void ThemNhanVien(string tennhanvien, string dienthoai, string macv)
        {
            SqlCommand cmd = new SqlCommand("sp_ThemNhanVien");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@HOTENNV", SqlDbType.NVarChar).Value = tennhanvien;
            cmd.Parameters.Add("@DIENTHOAINV", SqlDbType.Char).Value = dienthoai;
            cmd.Parameters.Add("@MACV", SqlDbType.Char).Value = macv;
            try
            {
                db.ThucThiLenh(cmd);
                XtraMessageBox.Show("Thêm thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi!" + ex.Message,"Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void XoaNhanVien(string manhanvien)
        {
            SqlCommand cmd = new SqlCommand("SP_XOANHANVIEN");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@manv", SqlDbType.NVarChar).Value = manhanvien;
            DialogResult kq = MessageBox.Show("Bạn có chắc là muốn xóa nhân viên này không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    db.ThucThiLenh(cmd);
                    XtraMessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi!" + ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void CapNhatNhanVien(string manhanvien,string tennhanvien, string dienthoai, string macv)
       
        {
            using (SqlCommand cmd = new SqlCommand() { CommandText = "SP_SUANHANVIEN", CommandType = CommandType.StoredProcedure })
            {
                cmd.Parameters.Add("@manv", SqlDbType.NVarChar).Value = manhanvien;
                cmd.Parameters.Add("@hotennv", SqlDbType.NVarChar).Value = tennhanvien;
                cmd.Parameters.Add("@dienthoainv", SqlDbType.Char).Value = dienthoai;
                cmd.Parameters.Add("@macv", SqlDbType.Char).Value = macv;
                try
                {
                    db.ThucThiLenh(cmd);
                    XtraMessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show( "Lỗi! " + ex.Message,"Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
