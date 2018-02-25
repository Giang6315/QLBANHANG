using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QLBANHANG.BussinessLogicLayer;
using QLBANHANG.DataAccessLayer;
namespace QLBANHANG.BussinessLogicLayer
{
    class CKhachhangNew
    {
        CDatabase db = new CDatabase();
        DataTable dt = new DataTable();
        string s;
        #region Hiển thị tất cả thông tin khách hàng
        public DataTable HienThiCT(string makh)
        {
            return db.ExecuteBang("select KH.*, CN.MADT, CN.MATG, CN.MANHOM, CN.MANGHE, CN.GIOITINH, CN.NGSINH, CN.TINHTRANGQUANHE, CN.NGAYKETHON, DN.MALV, DN.NGAYTHANHLAP, DN.WEBSITE from KHACHHANG KH full join KHACHHANGCANHAN CN on KH.MAKH= cn.MAKH FULL JOIN KHACHHANGDOANHNGHIEP DN ON KH.MAKH=DN.MAKH WHERE KH.MAKH='" + makh + "'");
        }
        #endregion

        #region Nhân viên

        public DataTable LayNV()
        {
            return db.ExecuteBang("SELECT * FROM NHANVIEN");
        }

        public string LayMaNV(string tennv)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM NHANVIEN WHERE HOTENNV=N'" + tennv + "'");
                s = dt.Rows[0]["MANV"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }

        public string LayTenNV(string manv)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM NHANVIEN WHERE MANV=N'" + manv + "'");
                s = dt.Rows[0]["HOTENNV"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }
        #endregion

        #region Quốc gia
        public DataTable LayQG()
        {
            return db.ExecuteBang("SELECT * FROM QUOCGIA");
        }

        public string LayMaQG(string tenqg)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM QUOCGIA WHERE TENQG=N'" + tenqg + "'");
                s = dt.Rows[0]["MAQG"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }

        public string LayTenQG(string maqg)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM QUOCGIA WHERE MAQG=N'" + maqg + "'");
                s = dt.Rows[0]["TENQG"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }


        public string LayMaQGTuMaTinh(string matinh)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM TINHTHANH WHERE MATINH='" + matinh + "'");
                s = dt.Rows[0]["MAQG"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }
        #endregion

        #region Tỉnh
        public DataTable LayTinh()
        {
            return db.ExecuteBang("SELECT * FROM TINHTHANH");
        }

        public string LayMaTinh(string tentinh)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM TINHTHANH WHERE TENTINH=N'" + tentinh + "'");
                s = dt.Rows[0]["MATINH"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }

        public string LayTenTinh(string matinh)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM TINHTHANH WHERE MATINH='" + matinh + "'");
                s = dt.Rows[0]["TENTINH"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }

        public string LayMaTinhTuKH(string makh)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM KHACHHANG WHERE MAKH='" + makh + "'");
                s = dt.Rows[0]["MATINH"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }
        #endregion

        #region Huyện
        public DataTable LayHuyen(string matinh)
        {
            return db.ExecuteBang("SELECT QUANHUYEN.* FROM QUANHUYEN INNER JOIN (SELECT MAHUYEN FROM CTQH_TT WHERE MATINH='" + matinh + "') A ON QUANHUYEN.MAHUYEN=A.MAHUYEN");
        }

        public string LayMaHuyen(string matinh, string tenhuyen)
        {
            try
            {
                dt = db.ExecuteBang("select QUANHUYEN.* from QUANHUYEN inner join (select mahuyen from CTQH_TT where MATINH='" + matinh +"') a on QUANHUYEN.MAHUYEN=a.MAHUYEN where TENHUYEN=N'" +  tenhuyen +"'");
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
                dt = db.ExecuteBang("SELECT * FROM QUANHUYEN WHERE MAHUYEN=N'" + mahuyen + "'");
                s = dt.Rows[0]["TENHUYEN"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }
        #endregion

        #region Nguồn tìm thấy
        public DataTable LayNguonTimThay()
        {
            return db.ExecuteBang("SELECT * FROM NGUONTHUNHAPTT");
        }

        public string LayMaNguonTimThay(string tennguon)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM NGUONTHUNHAPTT WHERE TENNGUON=N'" + tennguon + "'");
                s = dt.Rows[0]["MANGUON"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }

        public string LayTenNguonTimThay(string manguon)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM NGUONTHUNHAPTT WHERE MANGUON=N'" + manguon + "'");
                s = dt.Rows[0]["TENNGUON"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }
        #endregion

        #region Nghề nghiệp

        public DataTable LayNgheNghiep()
        {
            return db.ExecuteBang("SELECT * FROM NGHENGHIEP");
        }

        public string LayMaNghe(string tennghe)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM NGHENGHIEP WHERE TENNGHE=N'" + tennghe + "'");
                s = dt.Rows[0]["MANGHE"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }

        public string LayTenNghe(string manghe)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM NGHENGHIEP WHERE MANGHE=N'" + manghe + "'");
                s = dt.Rows[0]["TENNGHE"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }
        #endregion

        #region Dân tộc
        public DataTable LayDanToc()
        {
            return db.ExecuteBang("SELECT * FROM DANTOC");
        }

        public string LayMaDT(string tendt)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM DANTOC WHERE TENDT=N'" + tendt + "'");
                s = dt.Rows[0]["MADT"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }

        public string LayTenDT(string madt)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM DANTOC WHERE MADT=N'" + madt + "'");
                s = dt.Rows[0]["TENDT"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }
        #endregion

        #region Tôn giáo
        public DataTable LayTonGiao()
        {
            return db.ExecuteBang("SELECT * FROM TONGIAO");
        }

        public string LayMaTG(string tentg)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM TONGIAO WHERE TENTG=N'" + tentg + "'");
                s = dt.Rows[0]["MATG"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }

        public string LayTenTG(string matg)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM TONGIAO WHERE MATG=N'" + matg + "'");
                s = dt.Rows[0]["TENTG"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }
        #endregion

        #region Lĩnh vực kinh doanh
        public DataTable LayLinhVucKinhDoanh()
        {
            return db.ExecuteBang("SELECT * FROM LINHVUCKINHDOANH");
        }

        public string LayTenLVTuMa(string malv)
        {
            try
            {
                dt = db.ExecuteBang("SELECT TENLV FROM LINHVUCKINHDOANH WHERE MALV='" + malv + "'");
                s = dt.Rows[0]["TENLV"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
            
        }

        public string LayMaLinhVucKinhDoanh(string tenlv)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM LINHVUCKINHDOANH WHERE TENLV=N'" + tenlv + "'");
                s = dt.Rows[0]["MALV"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }
        #endregion

        #region Loại khách hàng
        public DataTable LayLoaiKH()
        {
            return db.ExecuteBang("SELECT * FROM LOAIKHACHHANG");
        }
        public string LayMaLoaiKH(string tenloai)
        {
            try
            {
                dt = db.ExecuteBang("SELECT MALOAIKH FROM LOAIKHACHHANG WHERE TENLOAIKH=N'" + tenloai + "'");
                s = dt.Rows[0]["MALOAIKH"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }

        public string LayTenLoaiKH(string maloai)
        {
            try
            {
                dt = db.ExecuteBang("SELECT TENLOAIKH FROM LOAIKHACHHANG WHERE MALOAIKH='" + maloai + "'");
                s = dt.Rows[0]["TENLOAIKH"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }
        #endregion

        #region Mức thu nhập
        public string LayMaThuNhap(string tentn)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM MUCTHUNHAP WHERE TENTHUNHAP=N'" + tentn + "'");
                s = dt.Rows[0]["MATHUNHAP"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }

        public string LayTenThuNhap(string matn)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM MUCTHUNHAP WHERE MATHUNHAP=N'" + matn + "'");
                s = dt.Rows[0]["TENTHUNHAP"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }
        #endregion

        #region Nhóm tuổi
        public string LayMaNhomTuoi(string tennhom)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM NHOMTUOI WHERE TENNHOM=N'" + tennhom + "'");
                s = dt.Rows[0]["MANHOM"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }

        public string LayTenNhomTuoi(string manhom)
        {
            try
            {
                dt = db.ExecuteBang("SELECT * FROM NHOMTUOI WHERE MANHOM='" + manhom + "'");
                s = dt.Rows[0]["TENNHOM"].ToString();
                return s;
            }
            catch
            {
                return "";
            }
        }
        #endregion

        #region Thêm khách hàng
        public void ThemKhachHang(string makh, string mahuyen, string matinh, string manguon, string maloai, string manv, string hoten, string dienthoai, string dchi, string email, string sotk, int ladn, string madt, string matg, string manhom, string manghe, int gioitinh, string ngaysinh, int tinhtrang, string ngaykethon, string malv, string ngaythanhlap, string website)
        {

            string proc = "SP_THEM_KHACHHANG '" + makh + "','" + mahuyen + "','" + matinh + "','" + manguon + "','" + maloai + "','" + manv + "',N'" + hoten + "','" + dienthoai + "',N'" + dchi + "','" + email + "','" + sotk + "'," + ladn + ",'" + madt + "','" + matg + "','" + manhom + "','" + manghe + "'," + gioitinh + ",'" + ngaysinh + "'," + tinhtrang + ",'" + ngaykethon + "','" + malv + "','" + ngaythanhlap + "','" + website + "'";
            try
            {
                dt = db.ExecuteBang(proc);
                MessageBox.Show("Thêm khách hàng thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm khách hàng không thành công ", "Thông báo!!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }
        #endregion
        #region Cập nhật khách hàng
        public void CapNhatKhachHang(string makh, string mahuyen, string matinh, string manguon, string maloai, string manv, string hoten, string dienthoai, string dchi, string email, string sotk, int ladn, string madt, string matg, string manhom, string manghe, int gioitinh, string ngaysinh, int tinhtrang, string ngaykethon, string malv, string ngaythanhlap, string website)
        {
            string proc = "SP_Sua_KHACHHANG '" + makh + "','" + mahuyen + "','" + matinh + "','" + manguon + "','" + maloai + "','" + manv + "',N'" + hoten + "','" + dienthoai + "',N'" + dchi + "','" + email + "','" + sotk + "'," + ladn + ",'" + madt + "','" + matg + "','" + manhom + "','" + manghe + "'," + gioitinh + ",'" + ngaysinh + "'," + tinhtrang + ",'" + ngaykethon + "','" + malv + "','" + ngaythanhlap + "','" + website + "'";
            try
            {
                dt = db.ExecuteBang(proc);
                MessageBox.Show("Cập nhật khách hàng thành công ", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Cập nhật khách hàng không thành công", "Thông báo!!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }
        #endregion
        #region Xóa khách hàng
        //public void XoaKhachHang(string makh)
        //{
        //    string proc = "SP_XOA_KHACHHANG '" + makh + "'";
        //    DialogResult kq = MessageBox.Show("Bạn có chắc là muốn xóa khách hàng này không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        //    if (kq == DialogResult.Yes)
        //    {
        //        try
        //        {
        //            dt = db.ExecuteBang(proc);
        //            MessageBox.Show("Xóa khách hàng thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Xóa khách hàng không thành công \n" + " \n Lỗi " + ex.Message, "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //        }
        //    }
        //}
        #endregion

        #region Tra cứU
        public DataTable LayTenKH()
        {
            return db.ExecuteBang("SELECT HOTENKH FROM KHACHHANG");
        }
        public DataTable TraCuuTheoMa(string ma)
        {
            return db.ExecuteBang("select KH.*, CN.MADT, CN.MATG, CN.MANHOM, CN.MANGHE, CN.GIOITINH, CN.NGSINH, CN.TINHTRANGQUANHE, CN.NGAYKETHON, DN.MALV, DN.NGAYTHANHLAP, DN.WEBSITE from KHACHHANG KH full join KHACHHANGCANHAN CN on KH.MAKH= cn.MAKH FULL JOIN KHACHHANGDOANHNGHIEP DN ON KH.MAKH=DN.MAKH WHERE KH.MAKH='" + ma + "'");
        }

        public DataTable TraCuuTheoTen(string ten)
        {
            return db.ExecuteBang("select KH.*, CN.MADT, CN.MATG, CN.MANHOM, CN.MANGHE, CN.GIOITINH, CN.NGSINH, CN.TINHTRANGQUANHE, CN.NGAYKETHON, DN.MALV, DN.NGAYTHANHLAP, DN.WEBSITE from KHACHHANG KH full join KHACHHANGCANHAN CN on KH.MAKH= cn.MAKH FULL JOIN KHACHHANGDOANHNGHIEP DN ON KH.MAKH=DN.MAKH WHERE (HOTENKH LIKE N'" + ten + "' OR HOTENKH LIKE N'%" + ten + "' OR HOTENKH LIKE N'" + ten + "%' OR HOTENKH LIKE N'%" + ten + "%')");
        }

        public DataTable TraCuuTheoLoaiKH(string maloai)
        {
            return db.ExecuteBang("select KH.*, CN.MADT, CN.MATG, CN.MANHOM, CN.MANGHE, CN.GIOITINH, CN.NGSINH, CN.TINHTRANGQUANHE, CN.NGAYKETHON, DN.MALV, DN.NGAYTHANHLAP, DN.WEBSITE from KHACHHANG KH full join KHACHHANGCANHAN CN on KH.MAKH= cn.MAKH FULL JOIN KHACHHANGDOANHNGHIEP DN ON KH.MAKH=DN.MAKH WHERE KH.MALOAIKH='" + maloai + "'");
        }

        public DataTable TraCuuTheoNgaySinh(string ngaysinh)
        {
            return db.ExecuteBang("select KH.*, CN.MADT, CN.MATG, CN.MANHOM, CN.MANGHE, CN.GIOITINH, CN.NGSINH, CN.TINHTRANGQUANHE, CN.NGAYKETHON, DN.MALV, DN.NGAYTHANHLAP, DN.WEBSITE from KHACHHANG KH full join KHACHHANGCANHAN CN on KH.MAKH= cn.MAKH FULL JOIN KHACHHANGDOANHNGHIEP DN ON KH.MAKH=DN.MAKH WHERE CN.NGSINH ='" + ngaysinh+ "'"); 
        }

        public DataTable TraCuuTheoLV(string malv)
        {
            return db.ExecuteBang("select KH.*, CN.MADT, CN.MATG, CN.MANHOM, CN.MANGHE, CN.GIOITINH, CN.NGSINH, CN.TINHTRANGQUANHE, CN.NGAYKETHON, DN.MALV, DN.NGAYTHANHLAP, DN.WEBSITE from KHACHHANG KH full join KHACHHANGCANHAN CN on KH.MAKH= cn.MAKH FULL JOIN KHACHHANGDOANHNGHIEP DN ON KH.MAKH=DN.MAKH WHERE DN.MALV ='" + malv + "'");
        }

        public DataTable TraCuuTheoNN(string manghe)
        {
            return db.ExecuteBang("select KH.*, CN.MADT, CN.MATG, CN.MANHOM, CN.MANGHE, CN.GIOITINH, CN.NGSINH, CN.TINHTRANGQUANHE, CN.NGAYKETHON, DN.MALV, DN.NGAYTHANHLAP, DN.WEBSITE from KHACHHANG KH full join KHACHHANGCANHAN CN on KH.MAKH= cn.MAKH FULL JOIN KHACHHANGDOANHNGHIEP DN ON KH.MAKH=DN.MAKH WHERE CN.MANGHE ='" + manghe + "'");
        }

        public DataTable TraCuuTheoTinhThanh(string matt)
        {
            return db.ExecuteBang("select KH.*, CN.MADT, CN.MATG, CN.MANHOM, CN.MANGHE, CN.GIOITINH, CN.NGSINH, CN.TINHTRANGQUANHE, CN.NGAYKETHON, DN.MALV, DN.NGAYTHANHLAP, DN.WEBSITE from KHACHHANG KH full join KHACHHANGCANHAN CN on KH.MAKH= cn.MAKH FULL JOIN KHACHHANGDOANHNGHIEP DN ON KH.MAKH=DN.MAKH WHERE KH.MATINH ='" + matt + "'");
        }
        #endregion
    }
}
