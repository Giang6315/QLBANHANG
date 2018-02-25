using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLBANHANG.DataAccessLayer;
using System.Runtime.InteropServices;
namespace QLBANHANG.BussinessLogicLayer
{
    class CKHACHHANG
    {
        CDatabase db = new CDatabase();
        DataTable dt = new DataTable();
        string s;
        public DataTable LayDanhSachKhachHang()
        {
            string query = "SELECT * FROM KHACHHANG";
            return db.ExecuteBang(query);
        }

        public string LayLoaiLV()
        {
            dt = db.ExecuteBang("SELECT MALV FROM LINHVUCKINHDOANH");
            s = dt.Rows[0]["MALV"].ToString();
            return s;
        }

        public string LayMaNhomTuTenNhom(string tennhom)
        {
            dt = db.ExecuteBang("SELECT MANHOM FROM NHOMTUOI WHERE TENNHOM=N'" + tennhom + "'");
            s = dt.Rows[0]["MANHOM"].ToString();
            return s;
        }

        public string LayMaTNTuTenTN(string tentn)
        {
            dt = db.ExecuteBang("SELECT MATHUNHAP FROM MUCTHUNHAP WHERE TENTHUNHAP=N'" + tentn + "'");
            s = dt.Rows[0]["MATHUNHAP"].ToString();
            return s;
        }

        public string LayMaLVTuTenLV(string tenlv)
        {
            dt = db.ExecuteBang("SELECT MALV FROM LINHVUCKINHDOANH WHERE TENLV=N'" + tenlv + "'");
            s = dt.Rows[0]["MALV"].ToString();
            return s;
        }

        public string LayMaHuyenTuTenHuyen(string tenhuyen)
        {
            dt = db.ExecuteBang("SELECT MAHUYEN FROM QUANHUYEN WHERE TENHUYEN=N'" + tenhuyen + "'");
            s = dt.Rows[0]["MAHUYEN"].ToString();
            return s;
        }

        public string LayMaDTTuTenDT(string tendt)
        {
            dt = db.ExecuteBang("SELECT MADT FROM DANTOC WHERE TENDT=N'" + tendt + "'");
            s = dt.Rows[0]["MADT"].ToString();
            return s;
        }

        public string LayMaTGTuTenTG(string tentg)
        {
            dt = db.ExecuteBang("SELECT MATG FROM TONGIAO WHERE TENTG=N'" + tentg + "'");
            s = dt.Rows[0]["MATG"].ToString();
            return s;
        }

        public string LayMaNguonTuTenNguon(string tennguon)
        {
            dt = db.ExecuteBang("SELECT MANGUON FROM NGUONTHUNHAPTT WHERE TENNGUON=N'" + tennguon + "'");
            s = dt.Rows[0]["MANGUON"].ToString();
            return s;
        }

        public string LayMaLoaiTuTenLoai(string tenloai)
        {
            dt = db.ExecuteBang("SELECT MALOAIKH FROM LOAIKHACHHANG WHERE TENLOAIKH=N'" + tenloai + "'");
            s = dt.Rows[0]["MALOAIKH"].ToString();
            return s;
        }

        public string LayMaCTYTuTenCTY(string tenct)
        {
            dt = db.ExecuteBang("SELECT MACTY FROM CONGTY WHERE TENCTY=N'" + tenct + "'");
            s = dt.Rows[0]["MACTY"].ToString();
            return s;
        }

        public string LayMaNgheTuTenNghe(string tennghe)
        {
            dt = db.ExecuteBang("SELECT MANGHE FROM NGHENGHIEP WHERE TENNGHE=N'" + tennghe + "'");
            s = dt.Rows[0]["MANGHE"].ToString();
            return s;
        }

        public string LayMaNVTuTenNV(string tennv)
        {
            dt = db.ExecuteBang("SELECT MANV FROM NHANVIEN WHERE HOTENNV=N'" + tennv + "'");
            s = dt.Rows[0]["MANV"].ToString();
            return s;
        }

        public string LayMaNTTuTenNT(string tennt)
        {
            dt = db.ExecuteBang("SELECT MANHOM FROM NHOMTUOI WHERE TENNHOM=N'" + tennt + "'");
            s = dt.Rows[0]["MANHOM"].ToString();
            return s;
        }

        public DataTable LayLoaiKH()
        {
            return db. ExecuteBang("SELECT TENLOAIKH FROM LOAIKHACHHANG");
            
        }

        public DataTable LayQuocGia()
        {
            return db.ExecuteBang("SELECT TENQG FROM QUOCGIA");
        }

        public DataTable LayNghe()
        {
            return db.ExecuteBang("SELECT TENNGHE FROM NGHENGHIEP");
        }

        public DataTable LayLinhVucKinhDoanh()
        {
            return db.ExecuteBang("SELECT TENLV FROM LINHVUCKINHDOANH");
        }

        public DataTable LayNguonTimThay()
        {
            return db.ExecuteBang("SELECT TENNGUON FROM NGUONTHUNHAPTT");
        }

        public DataTable LayDanToc()
        {
            return db.ExecuteBang("SELECT TENDT FROM DANTOC");
        }

        public DataTable LayNoiCongTac()
        {
            return db.ExecuteBang("SELECT TENCTY FROM CONGTY");
        }

        public DataTable LayTonGiao()
        {
            return db.ExecuteBang("SELECT TENTG FROM TONGIAO");
        }

        public DataTable LayNhanVien()
        {
            return db.ExecuteBang("SELECT HOTENNV FROM NHANVIEN");
        }

        //public DataTable LayTenLoaiKHTuMaLoaiKH(string ten)
        //{ 
        //     return db.ExecuteBang("SELECT TENLOAIKH FROM LOAIKHACHHANG WHERE MALOAIKH='" + ten + "'");
        //}

        public DataTable LayTenNgheTuMaNghe(string ten)
        {
            return db.ExecuteBang("SELECT TENNGHE FROM NGHENGHIEP WHERE MANGHE='" + ten + "'");
        }

        //public DataTable LayTenThuNHapTuMaThuNhap(string ten)
        //{
        //    return db.ExecuteBang("SELECT TENTHUNHAP FROM MUCTHUNHAP WHERE MATHUNHAP='" + ten + "'");
        //}

        //public DataTable LayNhomTuoiTuMaNhomTuoi(string ten)
        //{
        //    return db.ExecuteBang("SELECT TENNHOM FROM NHOMTUOI WHERE MANHOM='" + ten + "'");
        //}

        public DataTable LayTenHuyenTuMaHuyen(string ten)
        {
            return db.ExecuteBang("SELECT TENHUYEN FROM QUANHUYEN WHERE MAHUYEN='" + ten + "'");
        }

        public DataTable LayTenNguonThuNhapTTTuMa(string ten)
        {
            return db.ExecuteBang("SELECT TENNGUON FROM NGUONTHUNHAPTT WHERE MANGUON='" + ten + "'");
        }

        public DataTable LayTenTinhTuMaHuyen(string ten)
        {
            return db.ExecuteBang("SELECT TENTINH FROM TINHTHANH T, QUANHUYEN Q WHERE T.MATINH=Q.MATINH AND MAHUYEN='" + ten +"'");
        }

        public DataTable LayTenQGTuMaTinh(string ten)
        {
            return db.ExecuteBang("SELECT TENQG FROM QUOCGIA Q1, TINHTHANH T WHERE TENTINH=N'" + ten + "'");
        }

        public DataTable LayTenDTTuMaDT(string ten)
        {
            return db.ExecuteBang("SELECT TENDT FROM DANTOC WHERE MADT='" + ten +"'");
        }
        
        public DataTable LayTenTGTuMaTG(string ten)
        {
            return db.ExecuteBang( "SELECT TENTG FROM TONGIAO WHERE MATG='" + ten +"'");
        }

        public DataTable LayTenNVTuMaNV(string ten)
        {
            return db.ExecuteBang("SELECT HOTENNV FROM NHANVIEN WHERE MANV='" + ten + "'");
        }

        public DataTable LayTenCTYTuMaCTY(string ten)
        {
            return db.ExecuteBang("SELECT TENCTY FROM CONGTY WHERE MACTY='" + ten +"'");
        }

        public DataTable LayTenTinhTuTenQG(string ten)
        {
            return db.ExecuteBang("SELECT TENTINH FROM TINHTHANH T, QUOCGIA Q WHERE T.MAQG=Q.MAQG AND TENQG LIKE N'" + ten + "'");
        }

        public DataTable LayTenHuyenTuTenTinh(string ten)
        {
            return db.ExecuteBang("SELECT TENHUYEN FROM QUANHUYEN Q, TINHTHANH T WHERE Q.MATINH=T.MATINH AND TENTINH LIKE N'" + ten + "'");
        }

        public DataTable TraCuuTheoMa(string ma)
        {
                return db.ExecuteBang("SELECT MAKH, HOTENKH, GIOITINH, DCHIKH, TENHUYEN, TENTINH, TENQG, TENNGHE, CMNDKH, DIENTHOAIKH, TINHTRANGQUANHE, NGSINH, SOTK FROM KHACHHANG K, QUANHUYEN Q, TINHTHANH T, QUOCGIA QG, NGHENGHIEP N WHERE K.MAHUYEN=Q.MAHUYEN AND Q.MATINH=T.MATINH AND T.MAQG=QG.MAQG AND K.MANGHE=N.MANGHE AND MAKH ='" + ma + "'");
        }

        public DataTable TraCuuTheoTen(string ten)
        {
            return db.ExecuteBang("SELECT MAKH, HOTENKH, GIOITINH, DCHIKH, TENHUYEN, TENTINH, TENQG, TENNGHE, CMNDKH, DIENTHOAIKH, TINHTRANGQUANHE, NGSINH, SOTK FROM KHACHHANG K, QUANHUYEN Q, TINHTHANH T, QUOCGIA QG, NGHENGHIEP N WHERE K.MAHUYEN=Q.MAHUYEN AND Q.MATINH=T.MATINH AND T.MAQG=QG.MAQG AND K.MANGHE=N.MANGHE AND HOTENKH LIKE N'" + ten + "' OR HOTENKH LIKE N'%" + ten + "' OR HOTENKH LIKE N'" + ten + "%' OR HOTENKH LIKE N'%" + ten + "%'");

        }

        public DataTable TraCuuTheoLoaiKH(string tenloai)
        {
            return db.ExecuteBang("SELECT MAKH, HOTENKH, GIOITINH, DCHIKH, TENHUYEN, TENTINH, TENQG, TENNGHE, CMNDKH, DIENTHOAIKH, TINHTRANGQUANHE, NGSINH, SOTK FROM KHACHHANG K, QUANHUYEN Q, TINHTHANH T, QUOCGIA QG, NGHENGHIEP N, LOAIKHACHHANG L WHERE K.MAHUYEN=Q.MAHUYEN AND Q.MATINH=T.MATINH AND T.MAQG=QG.MAQG AND K.MANGHE=N.MANGHE AND K.MALOAIKH=L.MALOAIKH AND TENLOAIKH = N'" + tenloai + "'");
        }

        public DataTable TraCuuTheoNgaySinh(string ngaysinh)
        {
            return db.ExecuteBang("SELECT MAKH, HOTENKH, GIOITINH, DCHIKH, TENHUYEN, TENTINH, TENQG, TENNGHE, CMNDKH, DIENTHOAIKH, TINHTRANGQUANHE, NGSINH, SOTK FROM KHACHHANG K, QUANHUYEN Q, TINHTHANH T, QUOCGIA QG, NGHENGHIEP N WHERE K.MAHUYEN=Q.MAHUYEN AND Q.MATINH=T.MATINH AND T.MAQG=QG.MAQG AND K.MANGHE=N.MANGHE AND NGSINH='" + ngaysinh + "'");
        }

        //public DataTable Khachhangdaitra()
        //{
        //    return db.ExecuteBang("select MAKH, HOTENKH, GIOITINH, DCHIKH, TENHUYEN, TENTINH, TENQG, TENNGHE, CMNDKH, DIENTHOAIKH, TINHTRANGQUANHE, NGSINH, SOTK FROM KHACHHANG K, QUANHUYEN Q, TINHTHANH T, QUOCGIA QG, NGHENGHIEP N WHERE K.MAHUYEN=Q.MAHUYEN AND Q.MATINH=T.MATINH AND T.MAQG=QG.MAQG AND K.MANGHE=N.MANGHE AND YEAR(getdate())-YEAR(ngaytimthay)>1 and k.MAKH in (select d.MAKH 	from DONDATHANG d, CTDDH c, HOPDONG h where d.MADDH=c.MADDH and c.MADDH=h.MADDH group by YEAR(ngaythanhtoan), MAKH having  SUM(SOLUONGHD*DONGIACHINHTHUC)<20000 and SUM(SOLUONGHD*DONGIACHINHTHUC)> 5000)"); 
        //}

        //public DataTable Khachhangthanthiet()
        //{
        //    return db.ExecuteBang("select MAKH, HOTENKH, GIOITINH, DCHIKH, TENHUYEN, TENTINH, TENQG, TENNGHE, CMNDKH, DIENTHOAIKH, TINHTRANGQUANHE, NGSINH, SOTK FROM KHACHHANG K, QUANHUYEN Q, TINHTHANH T, QUOCGIA QG, NGHENGHIEP N WHERE K.MAHUYEN=Q.MAHUYEN AND Q.MATINH=T.MATINH AND T.MAQG=QG.MAQG AND K.MANGHE=N.MANGHE AND YEAR(getdate())-YEAR(ngaytimthay)>5 and k.MAKH in (select d.MAKH 	from DONDATHANG d, CTDDH c, HOPDONG h where d.MADDH=c.MADDH and c.MADDH=h.MADDH group by YEAR(ngaythanhtoan), MAKH having  SUM(SOLUONGHD*DONGIACHINHTHUC) > 20000)");
        //}

        //public DataTable Khachhangtiemnang()
        //{
        //    return db.ExecuteBang("SELECT MAKH, HOTENKH, GIOITINH, DCHIKH, TENHUYEN, TENTINH, TENQG, TENNGHE, CMNDKH, DIENTHOAIKH, TINHTRANGQUANHE, NGSINH, SOTK FROM KHACHHANG K, QUANHUYEN Q, TINHTHANH T, QUOCGIA QG, NGHENGHIEP N WHERE K.MAHUYEN=Q.MAHUYEN AND Q.MATINH=T.MATINH AND T.MAQG=QG.MAQG AND K.MANGHE=N.MANGHE AND YEAR(GETDATE())-YEAR(NGAYTIMTHAY)<1 AND K.MAKH NOT IN (SELECT MAKH FROM DONDATHANG)");
        //}

        public void ThemKhachHang(string linhvuc, string huyen, string dtoc, string tg, string nguon, string loaikh, string cty, string nv, string thunhap, string nhom, string hoten, string dt, string cmnd, int gioitinh, int tinhtrangqh, string sothich, string dchi, string ngsinh, string email, string sotk, string thunhapht, string nghe, int ladn, string website, double doanhthu)
        {
            string proc = "SP_THEM_KHACHHANG '" + linhvuc + "','" + huyen + "','" + dtoc + "','" + tg + "','" + nguon + "','" + loaikh + "','" + cty + "','" + nv + "','" + thunhap + "','" + nhom + "',N'" + hoten + "',N'" + dt + "','" + cmnd + "'," + gioitinh + "," + tinhtrangqh + ",N'" + sothich
                                + "',N'" + dchi + "','" + ngsinh + "','" + email + "','" + sotk + "'," + thunhapht + ",'" + nghe + "'," + ladn + ",'" + website + "'," + doanhthu;
            try
            {
                db.ExecuteBang(proc);
                MessageBox.Show("Thêm khách hàng thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm khách hàng không thành công \n" + "\nLỗi " + ex.Message, "Thông báo!!!!");
            }
        }

        //public void SuaKhachHang(string linhvuc, string huyen, string dtoc, string tg, string nguon, string loaikh, string cty, string nv, string thunhap, string nhom, string hoten, string dt, string cmnd, int gioitinh, int tinhtrangqh, string sothich, string dchi, string ngsinh, string email, string sotk, string thunhapht, string nghe, int ladn, string website, int doanhthu)
        //{
        //    string proc = "SP_SUA_KHACHHANG '"  + linhvuc + "','" + huyen + "','" + dtoc + "','" + tg + "','" + nguon + "','" + loaikh + "','" + cty + "','" + nv + "','" + thunhap + "','" + nhom + "',N'" + hoten + "',N'" + dt + "','" + cmnd + "'," + gioitinh + "," + tinhtrangqh + ",N'" + sothich
        //                        + "',N'" + dchi + "','" + ngsinh + "','" + email + "','" + sotk + "'," + thunhapht + ",'" + nghe + "'," + ladn + ",'" + website + "'," + doanhthu;
        //    try
        //    {
        //        db.ExecuteBang(proc);
        //        MessageBox.Show("Sửa khách hàng thành công");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Sửa khách hàng không thành công \n" + "\nLỗi " + ex.Message, "Thông báo!!!!");
        //    }
        //}

        //public void XoaKhachHang(string makh)
        //{
        //    string proc = "SP_XOA_KHACHHANG'" + makh + "'";
        //    try
        //    {
        //        db.ExecuteBang(proc);
        //        MessageBox.Show("Xóa khách hàng thành công");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Xóa khách hàng không thành công \n" + "\n Lỗi" + ex.Message, "Thông báo!!!");
        //    }
        //}
    }
}
