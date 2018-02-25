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
    class CLOAISANPHAM
    {
        CDatabase db = new CDatabase();
        public DataTable LayDanhSachLoaiSanPham()
        {
            return db.ExecuteBang("SELECT MALOAI, TENLOAI FROM LOAISANPHAM");
        }
        public void ThemLoaiSanPham(string maloai, string TenLoai)
        {
            using (SqlCommand cmd = new SqlCommand("SP_THEMLOAISANPHAM"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maloai", SqlDbType.Char).Value = maloai;
                cmd.Parameters.Add("@TENLOAI", SqlDbType.NVarChar).Value = TenLoai;
                try
                {
                    db.ThucThiLenh(cmd);
                    //MessageBox.Show("Thêm dữ liệu thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi!" + ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public void XoaLoaiSanPham(string MaLoai)
        {
            using (SqlCommand cmd = new SqlCommand("LoaiSanPham_Delete"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MALOAI", SqlDbType.Char).Value = MaLoai;
                DialogResult kq = MessageBox.Show("Bạn có chắc là muốn xóa loại sản phẩm này không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (kq == DialogResult.Yes)
                {
                    try
                    {
                        db.ThucThiLenh(cmd);
                        //MessageBox.Show("Xóa dữ liệu thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi!" + ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        public void CapNhatLoaiSanPham(string MaLoai, string TenLoai)
        {

            using (SqlCommand cmd = new SqlCommand("LoaiSanPham_Update"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MALOAI", SqlDbType.Char).Value = MaLoai;
                cmd.Parameters.Add("@TENLOAI", SqlDbType.NVarChar).Value = TenLoai;
                try
                {
                    db.ThucThiLenh(cmd);
                    //MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi!" + ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
