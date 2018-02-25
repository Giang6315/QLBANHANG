using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using QLBANHANG.DataAccessLayer;
using QLBANHANG.PresentationLayer;

namespace QLBANHANG.BussinessLogicLayer
{
    class CCAPNHATDONDATHANG
    {
       
        CDatabase db = new CDatabase();
        DataTable dt = new DataTable();
        public DataTable LayDSCapNhatDonDatHang()
        {
            return db.ExecuteBang("SELECT CT.MADDH, SP.TENSP, CT.SOLUONGDAT FROM CTDDH CT, SANPHAM SP WHERE CT.MASP=SP.MASP ORDER BY CT.MADDH");
        }

        public string Lay_MaSP_Tu_TenSP(string TenSP)
        {
            dt = db.ExecuteBang(String.Format("SELECT MASP FROM SANPHAM WHERE TENSP= '{0}'", TenSP));
            string s = dt.Rows[0]["MASP"].ToString();
            return s;
        }
         public void SuaDonDatHang(string maddh, string masp, int soluongdat)
        {
            using (SqlCommand cmd = new SqlCommand("SP_SUADONDATHANG")) 
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MADDH", SqlDbType.Char).Value = maddh;
                cmd.Parameters.Add("@MASP", SqlDbType.Char).Value = masp;
                cmd.Parameters.Add("@SLDAT", SqlDbType.Int).Value = soluongdat;
                try
                {
                    db.ThucThiLenh(cmd);
                    XtraMessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi!" + ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
         public void XoaSanPham(string MaSP, string maddh)
         {
             using (SqlCommand cmd = new SqlCommand("SP_XOASANPHAM"))
             {
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add("@MASP", SqlDbType.Char).Value = MaSP;
                 cmd.Parameters.Add("@maddh", SqlDbType.Char).Value = maddh;
                 DialogResult kq = MessageBox.Show("Bạn có chắc là muốn xóa đơn đặt hàng này không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                 if (kq == DialogResult.Yes)
                 {
                     try
                     {
                         db.ThucThiLenh(cmd);
                         MessageBox.Show("Xóa dữ liệu thành công","Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show("Xóa dữ liệu không thành công \n" + " \nLỗi " + ex.Message, "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                     }
                 }
             }
         }
 
    }
}
