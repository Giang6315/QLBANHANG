using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using DevExpress;
//using DevExpress.XtraEditors;
//using DevExpress.XtraBars;
//using DevExpress.XtraTab;
//using DevExpress.XtraTab.ViewInfo;
//using DevExpress.XtraEditors.Controls;
//using DevExpress.XtraEditors.Repository;
//using QLBANHANG.PresentationLayer;
//using System.Windows.Forms;
using QLBANHANG.BussinessLogicLayer;
using QLBANHANG.DataAccessLayer;
namespace QLBANHANG
{
    public partial class FrmKhachHang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        CTAOTAB tab = new CTAOTAB();
        DataTable dt = new DataTable();
        CKHACHHANG kh = new CKHACHHANG();
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        public void LayLoaiKHTC()
        {
            for (int i = 0; i < kh.LayLoaiKH().Rows.Count; i++)
            {
                cb_Loaikh.Items.Add(kh.LayLoaiKH().Rows[i]["TENLOAIKH"].ToString());
            }
        }

        public void LayQuocGia()
        {
            for (int i = 0; i < kh.LayQuocGia().Rows.Count; i++)
            {
                cbQUOCGIA.Items.Add(kh.LayQuocGia().Rows[i]["TENQG"].ToString());
            }
        }

        public void LayNghe()
        {
            for (int i = 0; i < kh.LayNghe().Rows.Count; i++)
            {
                cbNGHENGHIEP.Items.Add(kh.LayNghe().Rows[i]["TENNGHE"].ToString());
            }
        }

        public void LayLinhVucKinhDoanh()
        {
            for (int i = 0; i < kh.LayLinhVucKinhDoanh().Rows.Count; i++)
            {
                cbLINHVUCKINHDOANH.Items.Add(kh.LayLinhVucKinhDoanh().Rows[i]["TENLV"].ToString());
            }
        }

        public void LayNguonTimThay()
        {
            for (int i = 0; i < kh.LayNguonTimThay().Rows.Count; i++)
            {
                cbNGUONTIMTHAY.Items.Add(kh.LayNguonTimThay().Rows[i]["TENNGUON"].ToString());
            }
        }

        public void LayDanToc()
        {
            for (int i = 0; i < kh.LayDanToc().Rows.Count; i++)
            {
                cbDANTOC.Items.Add(kh.LayDanToc().Rows[i]["TENDT"].ToString());
            }
        }

        public void LayNoiCongTac()
        {
            for (int i = 0; i < kh.LayNoiCongTac().Rows.Count; i++)
            {
                cbNOICONGTAC.Items.Add(kh.LayNoiCongTac().Rows[i]["TENCTY"].ToString());
            }
        }

        public void LayTonGiao()
        {
            for (int i = 0; i < kh.LayTonGiao().Rows.Count; i++)
            {
                cbTONGIAO.Items.Add(kh.LayTonGiao().Rows[i]["TENTG"].ToString());
            }
        }

        public void LayNhanVien()
        {
            for (int i = 0; i < kh.LayNhanVien().Rows.Count; i++)
            {
                cbNHANVIEN.Items.Add(kh.LayNhanVien().Rows[i]["HOTENNV"].ToString());
            }
        }

        public void Moiload()
        {
            dtNgaytimthay.Text=DateTime.Now.Date.ToString("dd/MM/yyyy");
            cbLINHVUCKINHDOANH.Enabled = false;
            txtWEBSITE.Enabled = false;
            txtDOANHTHU.Enabled = false;
            cbTINHTHANH.Enabled = false;
            cbQUANHUYEN.Enabled = false;
            //groupControl4.Enabled = false;
            //groupControl5.Enabled = false;
            //groupControl2.Enabled = false;
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            LayLoaiKHTC();
            LayQuocGia();
            LayNghe();
            LayNguonTimThay();
            LayNoiCongTac();
            LayDanToc();
            LayTonGiao();
            LayNhanVien();
            LayLinhVucKinhDoanh();
            Moiload();
        }

        private void cbQUOCGIA_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTINHTHANH.Items.Clear();
            for (int i = 0; i < kh.LayTenTinhTuTenQG(cbQUOCGIA.Text).Rows.Count; i++)
            {
                cbTINHTHANH.Items.Add(kh.LayTenTinhTuTenQG(cbQUOCGIA.Text).Rows[i]["TENTINH"].ToString());
            }
            if (cbQUOCGIA.Text == "--Vui lòng chọn--")
            {
                cbQUANHUYEN.Enabled = false;
                cbTINHTHANH.Enabled = false;
            }
            else
            {
                cbQUANHUYEN.Enabled = false;
                cbTINHTHANH.Enabled = true;
            }
        }

        private void cbTINHTHANH_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbQUANHUYEN.Items.Clear();
            for (int i = 0; i < kh.LayTenHuyenTuTenTinh(cbTINHTHANH.Text).Rows.Count; i++)
            {
                cbQUANHUYEN.Items.Add(kh.LayTenHuyenTuTenTinh(cbTINHTHANH.Text).Rows[i]["TENHUYEN"].ToString());
            }
            if (cbTINHTHANH.Text == "--Vui lòng chọn--")
                cbQUANHUYEN.Enabled = false;
            else
                cbQUANHUYEN.Enabled = true;
        }

        private void btSoanlai_Click(object sender, EventArgs e)
        {
            Soanlai();
        }

        public void Soanlai()
        {
            txtCMND.Text = "";
            txtDIACHI.Text = "";
            txtDIENTHOAIKH.Text = "";
            txtDOANHTHU.Text = "";
            txtEMAIL.Text = "";
            txtSOTAIKHOAN.Text = "";
            txtSOTHICH.Text = "";
            txtTENKH.Text = "";
            txtTHUNHAPHANGTHANG.Text = "";
            txtWEBSITE.Text = "";
            cbNOICONGTAC.Text = "--Vui lòng chọn--";
            cbDANTOC.Text = "--Vui lòng chọn--";
            cbNGHENGHIEP.Text = "--Vui lòng chọn--";
            cbNGUONTIMTHAY.Text = "--Vui lòng chọn--";
            cbNHANVIEN.Text = "--Vui lòng chọn--";
            cbQUANHUYEN.Text = "--Vui lòng chọn--";
            cbQUOCGIA.Text = "--Vui lòng chọn--";
            cbTINHTHANH.Text = "--Vui lòng chọn--";
            cbTONGIAO.Text = "--Vui lòng chọn--";
            ckLADOANHNGHIEP.Checked = false;
            chkGIOITINH.Checked = false;
            chkTINHTRANGQUANHE.Checked = false;
        }

        private void ckLADOANHNGHIEP_CheckedChanged(object sender, EventArgs e)
        {
            if (ckLADOANHNGHIEP.Checked == true)
            {
                //grpCaNhan.Enabled = false;
                cbLINHVUCKINHDOANH.Enabled = true;
                txtWEBSITE.Enabled = true;
                txtDOANHTHU.Enabled = true;
                dtNgaysinh1.Enabled = false;
                txtSOTHICH.Enabled = false;
                chkGIOITINH.Enabled = false;
                chkTINHTRANGQUANHE.Enabled = false;
                txtCMND.Enabled = false;
                txtEMAIL.Enabled = false;
                txtTHUNHAPHANGTHANG.Enabled = false;
                cbNOICONGTAC.Enabled = false;
                //grpDoanhNgiep.Enabled = true;
                cbNGHENGHIEP.Enabled = false;
                cbDANTOC.Enabled = false;
                cbTONGIAO.Enabled = false;
            }
            else
            {
                grpCaNhan.Enabled = true;
                cbLINHVUCKINHDOANH.Enabled = false;
                txtWEBSITE.Enabled = false;
                txtDOANHTHU.Enabled = false;
                dtNgaysinh1.Enabled = true;
                txtSOTHICH.Enabled = true;
                chkGIOITINH.Enabled = true;
                chkTINHTRANGQUANHE.Enabled = true;
                txtCMND.Enabled = true;
                txtEMAIL.Enabled = true;
                txtTHUNHAPHANGTHANG.Enabled = true;
                cbNOICONGTAC.Enabled = true;
                grpDoanhNgiep.Enabled = false;
                cbNGHENGHIEP.Enabled = true;
                cbDANTOC.Enabled = true;
                cbTONGIAO.Enabled = true;
                txtDOANHTHU.Text = "";
            }
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            int gt, tinhtrang, thunhap, ladn, doanhthu;
            string lv, nghe;
            string ngaysinh = Convert.ToDateTime(dtNgaysinh1.Text).ToString("MM/dd/yyyy");
            if (ckLADOANHNGHIEP.Checked == true)
                ladn = 1;
            else
                ladn = 0;
            if (chkGIOITINH.Checked == true)
                gt = 1;
            else
                gt = 0;
            if (chkTINHTRANGQUANHE.Checked == true)
                tinhtrang = 1;
            else
                tinhtrang = 0;
            if (txtDOANHTHU.Text != "")
                doanhthu = Convert.ToInt32(txtDOANHTHU.Text);
            else
                doanhthu = 0;
            if (txtTHUNHAPHANGTHANG.Text != "")
                thunhap = Convert.ToInt32(txtTHUNHAPHANGTHANG.Text);
            else
                thunhap = 0;
            if (cbLINHVUCKINHDOANH.Text == "--Vui lòng chọn--")
                lv = null;
            else
                lv = kh.LayMaLVTuTenLV(cbLINHVUCKINHDOANH.Text);
            if (cbNGHENGHIEP.Text == "--Vui lòng chọn--")
                nghe = null;
            else
                nghe = kh.LayMaNgheTuTenNghe(cbNGHENGHIEP.Text);
            if (txtTENKH.Text == "")
                MessageBox.Show("Bạn chưa nhập mã hoặc tên khách hàng");
            else
            {
                kh.ThemKhachHang(lv, kh.LayMaHuyenTuTenHuyen(cbQUANHUYEN.Text), kh.LayMaDTTuTenDT(cbDANTOC.Text), kh.LayMaTGTuTenTG(cbTONGIAO.Text), kh.LayMaNguonTuTenNguon(cbNGUONTIMTHAY.Text), txtLoaiKH.Text, kh.LayMaCTYTuTenCTY(cbNOICONGTAC.Text), kh.LayMaNVTuTenNV(cbNHANVIEN.Text), kh.LayMaTNTuTenTN(txtMucthunhap.Text), kh.LayMaNTTuTenNT(txtNhomtuoi.Text), txtTENKH.Text, txtDIENTHOAIKH.Text, txtCMND.Text, gt, tinhtrang, txtSOTHICH.Text, txtDIACHI.Text, ngaysinh, txtEMAIL.Text, txtSOTAIKHOAN.Text, txtTHUNHAPHANGTHANG.Text, nghe, ladn, txtWEBSITE.Text, doanhthu);
                Soanlai();
            }
        }

        private void btTracuu_Click(object sender, EventArgs e)
        {
                if (txtMA_KH.Text == "" && txtTEN_KH.Text == "")
                    MessageBox.Show("Bạn phải nhập tên hoặc mã khách hàng");
                else
                {
                    //dt = kh.TraCuuTheoMaVaTen(txtMA_KH.Text, txtTEN_KH.Text);
                    if (dt.Rows.Count == 0)
                        MessageBox.Show("Không có khách hàng bạn cần tìm");
                    else
                        dgvTracuu.DataSource = dt;
                }
        }

        private void btTracuu2_Click(object sender, EventArgs e)
        {
            dt = kh.TraCuuTheoLoaiKH(cb_Loaikh.Text);
            if (dt.Rows.Count == 0)
                MessageBox.Show("Không có khách hàng bạn cần tìm");
            else
                dgvTracuu.DataSource = dt;
        }

        private void btTracuu3_Click(object sender, EventArgs e)
        {
            dt = kh.TraCuuTheoNgaySinh(dtNgaysinh.Text);
            if (dt.Rows.Count == 0)
                MessageBox.Show("Không có khách hàng bạn cần tìm");
            else
                dgvTracuu.DataSource = dt;
        }

        private void rbMa_ten_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMa_ten.Checked == true)
            {
                //groupControl4.Enabled = true;
                //groupControl5.Enabled = false;
                //groupControl2.Enabled = false;
            }
            else
            {
                //groupControl4.Enabled = false;
                //groupControl5.Enabled = true;
                //groupControl2.Enabled = true;
            }
        }

        private void rbMaloai_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMaloai.Checked == true)
            {
                //groupControl4.Enabled = false;
                //groupControl5.Enabled = true;
                //groupControl2.Enabled = false;
            }
            else
            {
                //groupControl4.Enabled = true;
                //groupControl5.Enabled = false;
                //groupControl2.Enabled = true;
            }
        }

        private void rbngaysinh_CheckedChanged(object sender, EventArgs e)
        {
            if (rbngaysinh.Checked == true)
            {
                //groupControl4.Enabled = false;
                //groupControl5.Enabled = false;
                //groupControl2.Enabled = true;
            }
            else
            {
                //groupControl4.Enabled = true;
                //groupControl5.Enabled = true;
                //groupControl2.Enabled = false;
            }
        }

        private void btThongTinKH_Click(object sender, EventArgs e)
        {
            //tab.TaoTabKhachHang(); 
        }

        private void txtTHUNHAPHANGTHANG_EditValueChanged(object sender, EventArgs e)
        {
            int thunhap=int.Parse(txtTHUNHAPHANGTHANG.Text);
            if (thunhap < 2000000)
                txtMucthunhap.Text = "THẤP";
            if (thunhap > 2000000 && thunhap  < 5000000)
                txtMucthunhap.Text = "TRUNG BÌNH";
            if (thunhap > 5000000)
                txtMucthunhap.Text = "CAO";
        }

        public void Tuoi()
        {
            string ngayht = DateTime.Now.Year.ToString();
            string ngaysinh=Convert.ToDateTime(dtNgaysinh1.Text).Year.ToString();
            int tuoi = int.Parse(ngayht) - int.Parse(ngaysinh);
            if (tuoi > 18 && tuoi < 34)
                txtNhomtuoi.Text = "THANH NIÊN";
            if (tuoi > 34 && tuoi < 55)
                txtNhomtuoi.Text = "TRUNG NIÊN";
            if (tuoi > 55 && tuoi < 65)
                txtNhomtuoi.Text = "NGƯỜI GIÀ";
            if (tuoi < 18 || tuoi > 65)
                MessageBox.Show("TUỔI SAI");
        }
      
        private void dtNgaysinh1_Validated(object sender, EventArgs e)
        {
            Tuoi();
        }

        private void btBrown_Click(object sender, EventArgs e)
        {
           
        }
    }
}