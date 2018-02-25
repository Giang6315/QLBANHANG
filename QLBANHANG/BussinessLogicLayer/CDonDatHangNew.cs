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
    class CDonDatHangNew
    {
        CDatabase db = new CDatabase();
        DataTable dt = new DataTable();
        string s;

        #region Hiển thị chi tiết đơn đặt hàng
        public DataTable HienThiChiTiet(string maddh)
        {
            return db.ExecuteBang("SELECT MADDH, MAKH, NGAYDAT FROM DONDATHANG WHERE MADDH='" + maddh + "'");
        }
        #endregion

        #region Hiển thị sản phẩm từ đơn đặt hàng
        public DataTable HienThiSP(string maddh)
        {
            return db.ExecuteBang("SELECT ctddh.MASP as MASP1, a.TENSP AS TENSP1, SOLUONGDAT AS SOLUONGDAT1, a.DONGIATHAMKHAO AS DONGIA1 FROM CTDDH INNER JOIN (SELECT MASP, TENSP, DONGIATHAMKHAO FROM SANPHAM) a ON CTDDH.MASP=a.MASP WHERE MADDH='" + maddh + "'");
        }
        #endregion

        #region Khách hàng
        public DataTable LayDSKH()
        {
            return db.ExecuteBang("SELECT HOTENKH FROM KHACHHANG");
        }

        public string LayMaKHTuTenKH(string tenkh)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM KHACHHANG WHERE HOTENKH=N'" + tenkh + "'");
                s = dt.Rows[0]["MAKH"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }

        public string LayTenKHTuMaKH(string makh)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM KHACHHANG WHERE MAKH='" + makh + "'");
                s = dt.Rows[0]["HOTENKH"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }
        #endregion

        #region Địa chỉ khách hàng
        public string LayDiaChiKH(string makh)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM KHACHHANG WHERE MAKH='" + makh + "'");
                s = dt.Rows[0]["DCHIKH"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }
        #endregion

        #region Huyện
        public string LayMaHuyen(string makh)
        {
            try
            {
                dt = db.ExecuteBang("SELECT MAHUYEN FROM KHACHHANG WHERE MAKH='" + makh + "'");
                s = dt.Rows[0]["MAHUYEN"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }

        public string LayTenHuyen(string mahuyen)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM QUANHUYEN WHERE MAHUYEN='" + mahuyen + "'");
                s = dt.Rows[0]["TENHUYEN"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }
        #endregion

        #region Tỉnh
        public string LayTenTinh(string makh)
        {
            try
            {
                dt = db.ExecuteBang("SELECT t.* FROM TINHTHANH t inner join ( select distinct a.matinh from ctqh_tt inner join (select matinh from KHACHHANG where MAKH='"  +  makh + "') a on a.MATINH=CTQH_TT.MATINH ) b  on t.matinh= b.MATINH");
                s = dt.Rows[0]["TENTINH"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }
        #endregion

        #region Loại sản phẩm
        public DataTable HienThiLoaiSP()
        {
            return db.ExecuteBang("SELECT * FROM LOAISANPHAM");
        }

        public string LayMaLoaiTuTenLoai(string tenloai)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM LOAISANPHAM where tenloai=N'" + tenloai + "'");
                s = dt.Rows[0]["MALOAI"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }
        #endregion

        #region Sản phẩm
        public DataTable HienThiSanPhamTuLoai(string maloai)
        {
            return db.ExecuteBang("SELECT MASP, TENSP, DONGIATHAMKHAO FROM SANPHAM WHERE MALOAI='" + maloai + "'");
        }
        #endregion

        #region Thêm đơn đặt hàng
        public void ThemDonDatHang(string madondathang, string makhachhang, string ngaydat, string masp, int soluongdat)
        {
            if (soluongdat == null)
                MessageBox.Show("Bạn chưa nhập số lợng đặt hàng");
            else
            {
                string proc = "SP_THEMDONDATHANG '" + madondathang + "','" + makhachhang + "','" + ngaydat + "','" + masp + "'," + soluongdat;
                db.ExecuteBang(proc);
            }
        }
        #endregion

        #region Cập nhật đơn đặt hàng
        public void CapNhatDDH(string maddh, string masp, int soluong)
        {
            string proc = "SP_SUADONDATHANG '" + maddh + "','" + masp + "'," + soluong;
            db.ExecuteBang(proc);
        }
        #endregion

        #region Xóa đơn đặt hàng
        public void XoaDonDatHang(string maddh)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn hủy đơn đặt hàng này không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            string proc = "SP_XOADONDATHANG '" + maddh + "'";
            try
            {
                db.ExecuteBang(proc);
                MessageBox.Show("Hủy đơn đặt hàng thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hủy đơn đặt hàng không thành công \n" + "\n Lỗi " + ex.Message, "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        public DataTable LayMaDDH()
        {
            return db.ExecuteBang("SELECT MADDH FROM CTDDH");
        }
    }
}
