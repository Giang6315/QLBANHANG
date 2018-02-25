using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLBANHANG.DataAccessLayer;
using System.Windows.Forms;
namespace QLBANHANG.BussinessLogicLayer
{
    class CThongTinKhachHang
    {
        CDatabase db = new CDatabase();
        DataTable dt = new DataTable();
        public DataTable HienThiKhachHangLaDN()
        {
            return db.ExecuteBang("SELECT MAKH, MALV, MAHUYEN, MANGUON, MALOAIKH, MANV, HOTENKH, DIENTHOAIKH, DCHIKH, SOTK, WEBSITE, DOANHTHUHANGTHANG FROM KHACHHANG  WHERE LADN=1");
        }

        public DataTable HienThiDSKH()
        {
            return db.ExecuteBang("SELECT MAKH,LADN, HOTENKH, DIENTHOAIKH, DCHIKH, EMAIL, SOTK, MATINH, MAHUYEN, MANGUON, MALOAIKH, MANV FROM KHACHHANG");
        }

        public DataTable HienThiKhachHangKhongLaDN()
        {
            return db.ExecuteBang("SELECT MAKH, MAHUYEN, MANGUON, MANHOM, MALOAIKH, MANV, HOTENKH, DIENTHOAIKH, DCHIKH, SOTK, MADT, MATG, MACTY, MATHUNHAP, CMNDKH, GIOITINH, TINHTRANGQUANHE, NGSINH, EMAIL, THUNHAPHANGTHANG, MANGHE FROM KHACHHANG WHERE LADN=0");
        }

        public DataTable HienThiKH(string maloaikh)
        {
            return db.ExecuteBang("SELECT * FROM KHACHHANG WHERE MALOAIKH ='" + maloaikh + "'");
        }

        public DataTable TraCuuKHTheoMa(string ma)
        {
            return db.ExecuteBang("select KH.*, CN.MADT, CN.MATG, CN.MANHOM, CN.MANGHE, CN.GIOITINH, CN.NGSINH, CN.TINHTRANGQUANHE, CN.NGAYKETHON, DN.MALV, DN.NGAYTHANHLAP, DN.WEBSITE from KHACHHANG KH full join KHACHHANGCANHAN CN on KH.MAKH= cn.MAKH FULL JOIN KHACHHANGDOANHNGHIEP DN ON KH.MAKH=DN.MAKH WHERE KH.MAKH='" + ma + "'");
        }

        public DataTable TraCuuTheoTen(string ten)
        {
            return db.ExecuteBang("select KH.*, CN.MADT, CN.MATG, CN.MANHOM, CN.MANGHE, CN.GIOITINH, CN.NGSINH, CN.TINHTRANGQUANHE, CN.NGAYKETHON, DN.MALV, DN.NGAYTHANHLAP, DN.WEBSITE from KHACHHANG KH full join KHACHHANGCANHAN CN on KH.MAKH= cn.MAKH FULL JOIN KHACHHANGDOANHNGHIEP DN ON KH.MAKH=DN.MAKH WHERE (HOTENKH LIKE N'" + ten + "' OR HOTENKH LIKE N'%" + ten + "' OR HOTENKH LIKE N'" + ten + "%' OR HOTENKH LIKE N'%" + ten + "%')");
        }

        public string LayMaLoaiTuTenLoaiKH(string ten)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM LOAIKHACHHANG WHERE TENLOAIKH=N'" + ten + "'");
                string s = dt.Rows[0]["MALOAIKH"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }

        public DataTable TraCuuTheoLoaiKH(string maloai)
        {
            return db.ExecuteBang("select KH.*, CN.MADT, CN.MATG, CN.MANHOM, CN.MANGHE, CN.GIOITINH, CN.NGSINH, CN.TINHTRANGQUANHE, CN.NGAYKETHON, DN.MALV, DN.NGAYTHANHLAP, DN.WEBSITE from KHACHHANG KH full join KHACHHANGCANHAN CN on KH.MAKH= cn.MAKH FULL JOIN KHACHHANGDOANHNGHIEP DN ON KH.MAKH=DN.MAKH WHERE KH.MALOAIKH='" + maloai + "'");
        }

        public DataTable HienThiNhanVienKH()
        {
            return db.ExecuteBang("SELECT * FROM nhanvien");
        }

        public DataTable HienThiHuyen()
        {
            return db.ExecuteBang("SELECT * FROM QUANHUYEN");
        }

        public DataTable HienThiLinhVucKinhDoanh()
        {
            return db.ExecuteBang("SELECT * FROM LINHVUCKINHDOANH");
        }

        public DataTable HienThiDanToc()
        {
            return db.ExecuteBang("SELECT * FROM DANTOC");
        }

        public DataTable HienThiTonGiao()
        {
            return db.ExecuteBang("SELECT * FROM TONGIAO");
        }

        public DataTable HienThiNguonThuNhapTT()
        {
            return db.ExecuteBang("SELECT * FROM NGUONTHUNHAPTT");
        }

        public DataTable HienThiLoaiKH()
        {
            return db.ExecuteBang("SELECT * FROM LOAIKHACHHANG");
        }

        public DataTable HienThiCTy()
        {
            return db.ExecuteBang("SELECT * FROM CONGTY");
        }

        public DataTable HienThiThuNhap()
        {
            return db.ExecuteBang("SELECT * FROM MUCTHUNHAP");
        }

        public DataTable HienThiNhomTuoi()
        {
            return db.ExecuteBang("SELECT * FROM NHOMTUOI");
        }

        public DataTable HienThiNghe()
        {
            return db.ExecuteBang("SELECT * FROM NGHENGHIEP");
        }

    }
}
