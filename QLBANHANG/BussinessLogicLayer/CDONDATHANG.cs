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
    class CDONDATHANG
    {
        CDatabase db = new CDatabase();
        DataTable dt = new DataTable();
        string s;
        //Tao tab thong tin don dat hang su dung ham cua form main
        public void TAOTABTRACUUDONDATHANG()
        {
            foreach (Form fm in Application.OpenForms)
            {
                if (fm is FrmMain)
                {
                    ((FrmMain)fm).TaoTabTraCuuDonDatHang();
                    break;
                }
            }
        }

        public DataTable LayMaDDH()
        {
            return db.ExecuteBang("SELECT MADDH FROM CTDDH");
        }
        public DataTable LayDanhSachSanPham()
        {
            return db.ExecuteBang("SELECT MASP, TENSP FROM SANPHAM");
        }

        public string LayMaSPTuTenSP(string tensp)
        {
            dt = db.ExecuteBang("SELECT MASP FROM SANPHAM WHERE TENSP='" + tensp + "'");
            s = dt.Rows[0]["MASP"].ToString();
            return s;
        }
        public DataTable LayDanhSachKhachHang()
        {
            return db.ExecuteBang("SELECT MAKH, HOTENKH FROM KHACHHANG");
        }

        public string LayMaKHTuTenKH(string tenkh)
        {
            dt = db.ExecuteBang("SELECT MAKH FROM KHACHHANG WHERE HOTENKH=N'" + tenkh + "'");
            s = dt.Rows[0]["MAKH"].ToString();
            return s;
        }
   
        public DataTable LayDSDonDatHang(string maddh)
        {
            return db.ExecuteBang("SELECT SP.MASP ,SP.TENSP, CT.SOLUONGDAT, SP.DONGIATHAMKHAO, CT.SOLUONGDAT*SP.DONGIATHAMKHAO FROM CTDDH CT, SANPHAM SP WHERE CT.MASP=SP.MASP AND MADDH= '" + maddh + "' ORDER BY CT.MASP ");

        }
        public DataTable TraCuuDonDatHang(string maddh)
        {
            return db.ExecuteBang("SELECT CT.MASP,TENSP, CT.SOLUONGDAT FROM CTDDH CT, SANPHAM SP WHERE CT.MASP=SP.MASP AND CT.MADDH='" + maddh + "'");
        }
        public DataTable HienThiTenKHVaMaDDH(string maddh)
        {
            return db.ExecuteBang("SELECT D.MADDH, K.HOTENKH FROM DONDATHANG D, KHACHHANG K WHERE D.MAKH=K.MAKH AND D.MADDH='" + maddh + "'");
        }

        public void ThemDonDatHang(string madondathang,string makhachhang, DateTime ngaydat, string masp, int soluongdat)
        {
            using (SqlCommand cmd = new SqlCommand("SP_THEMDONDATHANG")) 
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MADDH", SqlDbType.Char).Value = madondathang;
                cmd.Parameters.Add("@MAKH", SqlDbType.Char).Value = makhachhang;
                cmd.Parameters.Add("@NGAYDAT", SqlDbType.Date).Value = ngaydat;
                cmd.Parameters.Add("@MASP", SqlDbType.Char).Value = masp;
                cmd.Parameters.Add("@SLDAT", SqlDbType.Int).Value = soluongdat; ;
                try
                {
                    db.ThucThiLenh(cmd);
                    XtraMessageBox.Show("Thêm dữ liệu thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi!" + ex.Message, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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
                    MessageBox.Show("Lỗi!" + ex.Message,"Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}
