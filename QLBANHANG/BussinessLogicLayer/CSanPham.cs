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
    class CSanPham
    {
        CDatabase db = new CDatabase();
        string s;
        DataTable dt = new DataTable();
        public DataTable LayLoaiSP()
        {
            return db.ExecuteBang("SELECT * FROM LOAISANPHAM");
        }

        public string LayMaLoaiTuTenLoai(string ten)
        {
            dt = db.ExecuteBang("SELECT MALOAI FROM LOAISANPHAM WHERE TENLOAI=N'" + ten + "'");
            s = dt.Rows[0]["MALOAI"].ToString();
            return s;
        }

        public string LayMaDVITuTenDVI(string ten)
        {
            dt = db.ExecuteBang("SELECT MADVI FROM DVITINH WHERE TENDVI=N'" + ten + "'");
            s = dt.Rows[0]["MADVI"].ToString();
            return s;
        }

        public DataTable LayLoaiDV()
        {
            return db.ExecuteBang("SELECT * FROM DVITINH");
        }

        public string LayMaLoaiSPTuTenSP(string ten)
        {
            dt = db.ExecuteBang("SELECT MALOAI FROM LOAISANPHAM WHERE TENLOAI= N'" + ten + "'");
            s = dt.Rows[0]["MALOAI"].ToString();
            return s;
        }

        public string LayMaLoaiDVTuTenDV(string ten)
        {
            dt = db.ExecuteBang("SELECT MADVI FROM DVITINH WHERE TENDVI='" + ten + "'");
            s = dt.Rows[0]["MADVI"].ToString();
            return s;
        }

        public DataTable LaySP()
        {
            return db.ExecuteBang("SELECT A.MASP, TENSP, MOTA, DONGIA, TENLOAI, TENDVI FROM  SANPHAM A, LOAISANPHAM B, DVITINH C WHERE A.MALOAI=B.MALOAI AND A.MADVI=C.MADVI");
        }

        public void ThemSP(string masp, string mloai, string ten, string madvi, string mota, double dongia)
        {
            string proc = "SP_THEM_SANPHAM '" +masp+"','"+ mloai + "','" + ten + "','" + madvi + "', '" + mota + "'," + dongia;
            try
            {
                db.ExecuteBang(proc);
                MessageBox.Show("Thêm sản phẩm thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Thêm sản phẩm không thành công \n" + "\n Lỗi " + e.Message, "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        public void CapNhatSP(string ma, string mloai, string madvi, string ten, string mota, double dongia)
        {
            string proc = "SP_CAPNHAP_SANPHAM '" + ma + "','" + mloai + "','" + madvi + "', '" + ten + "','" + mota + "'," + dongia;
            try
            {
                db.ExecuteBang(proc);
                MessageBox.Show("Cập nhật sản phẩm thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Cập nhật sản phẩm không thành công \n" + "\n Lỗi " + e.Message, "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        public void XoaSP(string ma)
        {
            string proc = "SP_XOASANPHAM '" + ma + "'";
            DialogResult kq = MessageBox.Show("Bạn có chắc là muốn xóa sản phẩm này không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    db.ExecuteBang(proc);
                    MessageBox.Show("Xóa sản phẩm thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Xóa sản phẩm không thành công \n " + "\n Lỗi " + e.Message, "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }
        }

        public DataTable HienThiSPTheoLoaiSP(string tenloai)
        {
            return db.ExecuteBang("SELECT MASP, TENSP, MOTA, DONGIA, TENDVI FROM SANPHAM A, LOAISANPHAM B, DVITINH C WHERE A.MALOAI=B.MALOAI AND A.MADVI=C.MADVI AND B.TENLOAI=N'" + tenloai + "'");
        }

        public DataTable TCTheoMaSP(string ma)
        {
            return db.ExecuteBang("SELECT A.MASP, TENSP, MOTA, DONGIA,TENDVI FROM  SANPHAM A, DVITINH C WHERE A.MADVI=C.MADVI and MASP='" + ma + "'");
        }

        public DataTable TCTheoTenSP(string ten)
        {
            return db.ExecuteBang("SELECT A.MASP, TENSP, MOTA, DONGIA, TENDVI FROM  SANPHAM A, DVITINH C WHERE  A.MADVI=C.MADVI and TENSP like N'%" + ten + "%'");
        }
    }
}
