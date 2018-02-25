using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLBANHANG.DataAccessLayer;
namespace QLBANHANG.BussinessLogicLayer
{
    class CPHANQUYEN
    {
        public static CDatabase db = new CDatabase();
        public static DataTable LAYDSNGUOIDUNG()
        {
            string query = "SELECT TENDANGNHAP, MATKHAU, QUYENADMIN, QUYENTHEM, QUYENXOA, QUYENSUA  FROM QUANLYNGUOIDUNG";
            return db.ExecuteBang(query);
        }
        public void ThemNguoiDung(string TenDangNhap, string MatKhau, int QuyenAdmin, int QuyenThem, int QuyenXoa, int QuyenSua)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_THEMNGUOIDUNG ") { CommandType = CommandType.StoredProcedure })
                {
                    cmd.Parameters.Add("@TENDN", SqlDbType.VarChar).Value = TenDangNhap;
                    cmd.Parameters.Add("@MATKHAU", SqlDbType.VarChar).Value = MatKhau;
                    cmd.Parameters.Add("@ADMIN", SqlDbType.Bit).Value = QuyenAdmin;
                    cmd.Parameters.Add("@THEM", SqlDbType.Bit).Value = QuyenThem;
                    cmd.Parameters.Add("@XOA", SqlDbType.Bit).Value = QuyenXoa;
                    cmd.Parameters.Add("@SUA", SqlDbType.Bit).Value = QuyenSua;
                    db.ThucThiLenh(cmd);
                    MessageBox.Show("Thêm thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Thêm dữ liệu không thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void CapNhatNguoiDung(string TenDangNhap, string MatKhau, int QuyenAdmin, int QuyenThem, int QuyenXoa, int QuyenSua)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SP_CAPNHATNGUOIDUNG") { CommandType = CommandType.StoredProcedure })
                {
                    cmd.Parameters.Add("@TENDN", SqlDbType.VarChar).Value = TenDangNhap;
                    cmd.Parameters.Add("@MATKHAU", SqlDbType.VarChar).Value = MatKhau;
                    cmd.Parameters.Add("@ADMIN", SqlDbType.Bit).Value = QuyenAdmin;
                    cmd.Parameters.Add("@THEM", SqlDbType.Bit).Value = QuyenThem;
                    cmd.Parameters.Add("@XOA", SqlDbType.Bit).Value = QuyenXoa;
                    cmd.Parameters.Add("@SUA", SqlDbType.Bit).Value = QuyenSua;
                    db.ThucThiLenh(cmd);
                    MessageBox.Show("Sửa dữ liệu thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Sửa dữ liệu không thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void XoaNguoiDung(string TenDangNhap)
        {
             DialogResult kq = MessageBox.Show("Bạn có chắc là muốn xóa tài khoản này không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
             if (kq == DialogResult.Yes)
             {
                 using (SqlCommand cmd = new SqlCommand("SP_XOANGUOIDUNG") { CommandType = CommandType.StoredProcedure })
                 {
                     cmd.Parameters.Add("@TENDN", SqlDbType.VarChar).Value = TenDangNhap;
                     db.ThucThiLenh(cmd);
                 }
             }
        }
        
    }
}
