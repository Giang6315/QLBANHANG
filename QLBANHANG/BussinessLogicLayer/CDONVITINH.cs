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
    class CDONVITINH
    {
        CDatabase db = new CDatabase();
        public DataTable LayDanhSachDonViTinh()
        {
            return db.ExecuteBang("SELECT MADVI, TENDVI FROM DVITINH");
        }
        public void ThemDonViTinh(string TenDonVi)
        {
            using (SqlCommand cmd = new SqlCommand("SP_THEMDVITINH"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TENDVI", SqlDbType.NVarChar).Value = TenDonVi;
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
        public void XoaDonViTinh(string MaDonVi)
        {
            using (SqlCommand cmd = new SqlCommand("SP_XOADVTINH"))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MADVI", SqlDbType.Char).Value = MaDonVi;
                DialogResult kq = MessageBox.Show("Bạn có chắc là muốn xóa đơn vị tính này không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
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
        public void CapNhatDonViTinh(string MaDonVi, string TenDonVi)
        {
            using (SqlCommand cmd = new SqlCommand("SP_SUADVTINH "))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MADVI", SqlDbType.Char).Value = MaDonVi;
                cmd.Parameters.Add("@TENDVI", SqlDbType.NVarChar).Value = TenDonVi;
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
