using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLBANHANG.BussinessLogicLayer;
using QLBANHANG.DataAccessLayer;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmKhachhangmoi : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataTable dt;
        CKhachhangNew kh;
        CTAOTAB tab;
        CDatabase db;
        public FrmKhachhangmoi()
        {
            InitializeComponent();
            dt = new DataTable();
            tab = new CTAOTAB();
            kh = new CKhachhangNew();
            db = new CDatabase();
        }
        #region Kiểm tra dữ liệu nhập

        public static bool LaKiTu(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
        }
      
        public static bool LaSo(char c)
        {
            return c >= '0' && c <= '9';
        }
        public static bool LaKiHieu(char c)
        {
            return c > 32 && c < 127 && !LaSo(c) && !LaKiTu(c);
        }
        public static bool KiemTraKiTu(string kitu)
        {
            return kitu.Any(c => LaKiTu(c));
        }
        public static bool KiemTraKiHieu(string kihieu)
        {
            return
                 kihieu.Any(c => LaKiHieu(c));   
        }
        public static bool KiemTraSo(string chuso)
        {
            return
                  chuso.Any(c => LaSo(c));                          
        }
        #endregion
        #region Danh sách hiển thị
        public void HienThiNhanVien()
        {
            cb_Nhanvien.Items.Add("--Vui lòng chọn--");
            cb_Nhanvien.SelectedIndex = 0;
            for (int i = 0; i < kh.LayNV().Rows.Count; i++)
            {
                cb_Nhanvien.Items.Add(kh.LayNV().Rows[i]["HOTENNV"].ToString());
            }
        }

        public void HienThiTinh()
        {
            cb_Tinhthanh.Items.Add("--Vui lòng chọn--");
            cb_Tinhthanh.SelectedIndex = 0;
            for (int i = 0; i < kh.LayTinh().Rows.Count; i++)
            {
                cb_Tinhthanh.Items.Add(kh.LayTinh().Rows[i]["TENTINH"].ToString());
            }
        }

        public void HienThiTinh1()
        {
            cbTT.Items.Add("--Vui lòng chọn--");
            cbTT.SelectedIndex = 0;
            for (int i = 0; i < kh.LayTinh().Rows.Count; i++)
            {
                cbTT.Items.Add(kh.LayTinh().Rows[i]["TENTINH"].ToString());
            }
        }

        public void HienThiHuyen()
        {
            cb_Quanhuyen.Items.Add("--Vui lòng chọn--");
            cb_Quanhuyen.SelectedIndex = 0;
            for (int i = 0; i < kh.LayHuyen(kh.LayMaTinh(cb_Tinhthanh.Text)).Rows.Count; i++)
            {
                cb_Quanhuyen.Items.Add(kh.LayHuyen(kh.LayMaTinh(cb_Tinhthanh.Text)).Rows[i]["TENHUYEN"].ToString());
            }
            cb_Quanhuyen.SelectedIndex = 0;
        }

        public void HienThiNguonThuNhapTT()
        {
            cb_Nguontimthay.Items.Add("--Vui lòng chọn--");
            cb_Nguontimthay.SelectedIndex = 0;
            for (int i = 0; i < kh.LayNguonTimThay().Rows.Count; i++)
            {
                cb_Nguontimthay.Items.Add(kh.LayNguonTimThay().Rows[i]["TENNGUON"].ToString());
            }
        }

        public void HienThiNghe()
        {
            cb_Nghenghiep.Items.Add("--Vui lòng chọn--");
            cb_Nghenghiep.SelectedIndex = 0;
            for (int i = 0; i < kh.LayNgheNghiep().Rows.Count; i++)
            {
                cb_Nghenghiep.Items.Add(kh.LayNgheNghiep().Rows[i]["TENNGHE"].ToString());
            }
        }

        public void HienThiNghe1()
        {
            cbNN.Items.Add("--Vui lòng chọn--");
            cbNN.SelectedIndex = 0;
            for (int i = 0; i < kh.LayNgheNghiep().Rows.Count; i++)
            {
                cbNN.Items.Add(kh.LayNgheNghiep().Rows[i]["TENNGHE"].ToString());
            }
        }

        public void HienThiDT()
        {
            cb_Dantoc.Items.Add("--Vui lòng chọn--");
            cb_Dantoc.SelectedIndex = 0;
            for (int i = 0; i < kh.LayDanToc().Rows.Count; i++)
            {
                cb_Dantoc.Items.Add(kh.LayDanToc().Rows[i]["TENDT"].ToString());
            }
        }

        public void HienThiTG()
        {
            cb_Tongiao.Items.Add("--Vui lòng chọn--");
            cb_Tongiao.SelectedIndex = 0;
            for (int i = 0; i < kh.LayTonGiao().Rows.Count; i++)
            {
                cb_Tongiao.Items.Add(kh.LayTonGiao().Rows[i]["TENTG"].ToString());
            }
        }

        public void HienThiLinhVucKinhDoanh()
        {
            cb_Linhvuckinhdoanh.Items.Add("--Vui lòng chọn--");
            cb_Linhvuckinhdoanh.SelectedIndex = 0;
            for (int i = 0; i < kh.LayLinhVucKinhDoanh().Rows.Count; i++)
            {
                cb_Linhvuckinhdoanh.Items.Add(kh.LayLinhVucKinhDoanh().Rows[i]["TENLV"].ToString());
            }
        }

        public void HienThiLinhVucKinhDoanh1()
        {
            cbLV.Items.Add("--Vui lòng chọn--");
            cbLV.SelectedIndex = 0;
            for (int i = 0; i < kh.LayLinhVucKinhDoanh().Rows.Count; i++)
            {
                cbLV.Items.Add(kh.LayLinhVucKinhDoanh().Rows[i]["TENLV"].ToString());
            }
        }

        public void HienThiLoaiKH()
        {
            cb_Loaikh.Items.Add("--Vui lòng chọn--");
            cb_Loaikh.SelectedIndex = 0;
            for (int i = 0; i < kh.LayLoaiKH().Rows.Count; i++)
            {
                cb_Loaikh.Items.Add(kh.LayLoaiKH().Rows[i]["TENLOAIKH"].ToString());
            }
        }

        #endregion

        #region Lấy mã khách hàng
        public void LayMaKH()
        {
            dt = db.ExecuteBang("EXEC LAYMAKH");
            txtMakh.Text = dt.Rows[0][0].ToString();
        }
        #endregion

        #region Load
        private void FrmKhachhangmoi_Load(object sender, EventArgs e)
        {
            HienThiLoaiKH();
            HienThiNhanVien();
            HienThiNguonThuNhapTT();
            HienThiTinh();
            HienThiTinh1();
            HienThiNghe();
            HienThiNghe1();
            HienThiDT();
            HienThiTG();
            LayMaKH();
            cb_Quanhuyen.Items.Add("--Vui lòng chọn--");
            cb_Quanhuyen.SelectedIndex = 0;
            HienThiLinhVucKinhDoanh();
            HienThiLinhVucKinhDoanh1();
            dtNgaykethon.Enabled = false;
            dt_Ngaysinh.Text = Convert.ToDateTime(DateTime.Now.Date).ToShortDateString();
            dtNgaykethon.Text = Convert.ToDateTime(DateTime.Now.Date).ToShortDateString();
            dtNgaythanhlap.Text = Convert.ToDateTime(DateTime.Now.Date).ToShortDateString();
            dtNgaysinh.Text = Convert.ToDateTime(DateTime.Now.Date).ToShortDateString();
            grpDoanhNgiep.Enabled = false;
            grpCaNhan.Enabled = true;
            txt_Loaikh.Text = "TIỀM NĂNG";
            HienThiTTKH();
            DuDoanTimTheoMAKH();
            DuDoanTimTheoTENKH();
        }
        #endregion

        #region Danh sách các sự kiện
        private void txtMA_KH_EditValueChanged(object sender, EventArgs e)
        {
            txtTENKH.Text = "";
            cb_Loaikh.Text = "--Vui lòng chọn--";
        }

        private void txtTEN_KH_EditValueChanged(object sender, EventArgs e)
        {
            txtMA_KH.Text = "";
            cb_Loaikh.Text = "--Vui lòng chọn--";
        }

        private void cb_Loaikh_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMA_KH.Text = "";
            txtTENKH.Text = "";
        }

        private void cb_Tinhthanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_Quanhuyen.Items.Clear();
            if (cb_Tinhthanh.Text == "--Vui lòng chọn--")
                cb_Quanhuyen.Text = "";
            else
                HienThiHuyen();
        }

        private void ck_Doanhnghiep_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_Doanhnghiep.Checked == true)
            {
                grpCaNhan.Enabled = false;
                grpDoanhNgiep.Enabled = true;
                cb_Nghenghiep.Enabled = false;
                cb_Dantoc.Enabled = false;
                cb_Tongiao.Enabled = false;
            }
            else
            {
                grpCaNhan.Enabled = true;
                grpDoanhNgiep.Enabled = false;
                cb_Nghenghiep.Enabled = true;
                cb_Dantoc.Enabled = true;
                cb_Tongiao.Enabled = true;
            }
        }

        private void dt_Ngaysinh_Validated(object sender, EventArgs e)
        {
            try
            {
                int tuoi = int.Parse(DateTime.Now.Date.Year.ToString()) - int.Parse(Convert.ToDateTime(dt_Ngaysinh.Text).Year.ToString());
                if (tuoi >= 18 && tuoi <= 25)
                    txt_Nhomtuoi.Text = "TỪ 18 ĐẾN 25";
                else if (tuoi >= 26 && tuoi <= 35)
                    txt_Nhomtuoi.Text = "TỪ 26 ĐẾN 35";
                else if (tuoi >= 36 && tuoi <= 45)
                    txt_Nhomtuoi.Text = "TỪ 36 ĐẾN 45";
                else if (tuoi >= 45 && tuoi <= 55)
                    txt_Nhomtuoi.Text = "TỪ 46 ĐẾN 55";
                else if (tuoi > 55 && tuoi <= 65)
                    txt_Nhomtuoi.Text = "TỪ 56 ĐẾN 65";
            }
            catch
            {
                MessageBox.Show("Tuổi không hợp lệ");
            }
        }

        private void ck_Tinhtrang_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_Tinhtrang.Checked == true)
                dtNgaykethon.Enabled = true;
            else
                dtNgaykethon.Enabled = false;
        }
        #endregion

        #region Thêm khách hàng
        private void bt_Them_Click(object sender, EventArgs e)
        {
            int ladn, gioitinh, tinhtrang;
            string lv, nghe, dtoc, tg, nhomtuoi, ngaysinh, ngaykethon, ngaythanhlap;
            if (dt_Ngaysinh.Text == Convert.ToDateTime(DateTime.Now.Date).ToShortDateString())
                ngaysinh = null;
            else
                ngaysinh = Convert.ToDateTime(dt_Ngaysinh.Text).ToShortDateString();
            if (dtNgaythanhlap.Text == Convert.ToDateTime(DateTime.Now.Date).ToShortDateString())
                ngaythanhlap = null;
            else
                ngaythanhlap = Convert.ToDateTime(dtNgaythanhlap.Text).ToShortDateString();
            if (ck_Tinhtrang.Checked == true)
                ngaykethon = Convert.ToDateTime(dtNgaykethon.Text).ToShortDateString();
            else
                ngaykethon = null;
            nhomtuoi = kh.LayMaNhomTuoi(txt_Nhomtuoi.Text);
            if (cb_Tongiao.Text == "--Vui lòng chọn--")
                tg = null;
            else
                tg = kh.LayMaTG(cb_Tongiao.Text);
            dtoc = kh.LayMaDT(cb_Dantoc.Text);
            nghe = kh.LayMaNghe(cb_Nghenghiep.Text);
            lv = kh.LayMaLinhVucKinhDoanh(cb_Linhvuckinhdoanh.Text);
            if (ck_Doanhnghiep.Checked == true)
                ladn = 1;
            else
                ladn = 0;
            if (ck_Gioitinh.Checked == true)
                gioitinh = 1;
            else
                gioitinh = 0;
            if (ck_Tinhtrang.Checked == true)
                tinhtrang = 1;
            else
                tinhtrang = 0;
            if (ck_Doanhnghiep.Checked == true)
                if (cb_Linhvuckinhdoanh.Text == "--Vui lòng chọn--")
                    MessageBox.Show("Bạn chưa chọn lĩnh vực kinh doanh!");
            if (ck_Doanhnghiep.Checked == false)
            {
                if (cb_Nghenghiep.Text == "--Vui lòng chọn--")
                    MessageBox.Show("Bạn chưa chọn nghề nghiệp!");
                else
                    if (cb_Dantoc.Text == "--Vui lòng chọn--")
                        MessageBox.Show("Bạn chưa chọn dân tộc!");
                    else
                        if (cb_Tongiao.Text == "--Vui lòng chọn--")
                            MessageBox.Show("Bạn chưa chọn tôn giáo!");
            }
            //bắt lỗi số điện thoại
            string dienthoai = txt_Dienthoaikh.Text;
            if (txtMakh.Text == "" || txt_TenKH.Text == "")
                MessageBox.Show("Mã hoặc tên khách hàng không được rỗng!");
            else
                if (KiemTraSo(txtTENKH.Text) == true)
                    MessageBox.Show("Tên khách hàng không đúng!");
                else
                    if (KiemTraKiHieu(txtTENKH.Text) == true)
                        MessageBox.Show("Tên khách hàng không đúng!");
                    else
                        if (cb_Tinhthanh.Text == "--Vui lòng chọn--")
                            MessageBox.Show("Bạn chưa chọn tỉnh thành!");
                        else
                            if (cb_Quanhuyen.Text == "--Vui lòng chọn--")
                                MessageBox.Show("Bạn chưa chọn quận huyện!");
                            else
                                if (cb_Nhanvien.Text == "--Vui lòng chọn--")
                                    MessageBox.Show("Bạn chưa chọn nhân viên quản lý!");
                                else
                                    if (txt_Email.Text == "")
                                        MessageBox.Show("Bạn chưa nhập Email!");
                                    else
                                    if (cb_Nguontimthay.Text == "--Vui lòng chọn--")
                                        MessageBox.Show("Bạn chưa chọn nguồn tìm thấy khách hàng!");
                                    else
                                        if (dienthoai.Length < 10)
                                            MessageBox.Show("Số điện thoại tối thiểu 11 chữ số!");
                                        else
                                        if (KiemTraSo(txt_Dienthoaikh.Text) == false)

                                            MessageBox.Show("Bạn phải nhập số điện thoại là chữ số!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        else
                                            if (KiemTraKiTu(txt_Dienthoaikh.Text) == true)
                                                MessageBox.Show("Bạn phải nhập số điện thoại là chữ số!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            else
                                                if (KiemTraKiHieu(txt_Dienthoaikh.Text) == true)
                                                    MessageBox.Show("Bạn phải nhập số điện thoại là chữ số!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                           
                                                        else if (KiemTraKiHieu(txt_Sotk.Text) == true)
                                                            MessageBox.Show("Bạn phải nhập số tài khoản là chữ số!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                        else
                                                        {

                                                            kh.ThemKhachHang(txtMakh.Text, kh.LayMaHuyen(kh.LayMaTinh(cb_Tinhthanh.Text), cb_Quanhuyen.Text), kh.LayMaTinh(cb_Tinhthanh.Text), kh.LayMaNguonTimThay(cb_Nguontimthay.Text), kh.LayMaLoaiKH(txt_Loaikh.Text), kh.LayMaNV(cb_Nhanvien.Text), txt_TenKH.Text, txt_Dienthoaikh.Text, txt_Diachikh.Text, txt_Email.Text, txt_Sotk.Text, ladn, dtoc, tg, nhomtuoi, nghe, gioitinh, ngaysinh, tinhtrang, ngaykethon, lv, ngaythanhlap, txt_Website.Text);
                                                            Soanlai();

                                                        }
        }
        #endregion

        #region Tra cứu
        CTraCuuDDH tc = new CTraCuuDDH();
        public void DuDoanTimTheoMAKH()
        {
            txtMA_KH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtMA_KH.AutoCompleteSource = AutoCompleteSource.CustomSource;
            DataTable dt = tc.LayMaKH();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txtMA_KH.AutoCompleteCustomSource.Insert(i, dt.Rows[i]["MAKH"].ToString());
            }
        }
        public void DuDoanTimTheoTENKH()
        {
            txtTENKH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTENKH.AutoCompleteSource = AutoCompleteSource.CustomSource;
            DataTable dt = kh.LayTenKH();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txtTENKH.AutoCompleteCustomSource.Insert(i, dt.Rows[i]["HOTENKH"].ToString());
            }
        }
        private void btTracuu1_Click(object sender, EventArgs e)
        {
            if (txtMA_KH.Text == "")
            {
                MessageBox.Show("Mã khách hàng không được rỗng");
                if (this.dgvTracuu.DataSource != null)
                {
                    for (int i = dgvTracuu.Rows.Count - 2; i >= 0; i--)
                    {
                        dgvTracuu.Rows.RemoveAt(i);
                    }
                }
            }
            else
            {
                dt = kh.TraCuuTheoMa(txtMA_KH.Text);
                if (dt.Rows.Count == 0)
                    MessageBox.Show("Không có khách hàng bạn cần tìm");
                else
                    dgvTracuu.DataSource = dt;
            }
        }

        private void btTracuu2_Click(object sender, EventArgs e)
        {
            dt = kh.TraCuuTheoLoaiKH(kh.LayMaLoaiKH(cb_Loaikh.Text));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có khách hàng bạn cần tìm");
                if (this.dgvTracuu.DataSource != null)
                {
                    for (int i = dgvTracuu.Rows.Count - 2; i >= 0; i--)
                    {
                        dgvTracuu.Rows.RemoveAt(i);
                    }
                }
            }
            else
                dgvTracuu.DataSource = dt;
        }

        private void btTracuu3_Click(object sender, EventArgs e)
        {
            dt = kh.TraCuuTheoNgaySinh(dtNgaysinh.Text);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có khách hàng bạn cần tìm");
                if (this.dgvTracuu.DataSource != null)
                {
                    for (int i = dgvTracuu.Rows.Count - 2; i >= 0; i--)
                    {
                        dgvTracuu.Rows.RemoveAt(i);
                    }
                }
            }
            else
                dgvTracuu.DataSource = dt;
        }

        private void btTracuu_Click(object sender, EventArgs e)
        {
            if (txtTENKH.Text == "")
                MessageBox.Show("Tên khách hàng không được rỗng");
            else
            {
                dt = kh.TraCuuTheoTen(txtTENKH.Text);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có khách hàng bạn cần tìm");
                    if (this.dgvTracuu.DataSource != null)
                    {
                        for (int i = dgvTracuu.Rows.Count - 2; i >= 0; i--)
                        {
                            dgvTracuu.Rows.RemoveAt(i);
                        }
                    }
                }
                else
                    dgvTracuu.DataSource = dt;
            }
        }


        private void btTracuu4_Click(object sender, EventArgs e)
        {
            dt = kh.TraCuuTheoLV(kh.LayMaLinhVucKinhDoanh(cbLV.Text));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có khách hàng bạn cần tìm");
                if (this.dgvTracuu.DataSource != null)
                {
                    for (int i = dgvTracuu.Rows.Count - 2; i >= 0; i--)
                    {
                        dgvTracuu.Rows.RemoveAt(i);
                    }
                }
            }
            else
                dgvTracuu.DataSource = dt;
        }

        private void btTracuu5_Click(object sender, EventArgs e)
        {
            dt = kh.TraCuuTheoNN(kh.LayMaNghe(cbNN.Text));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có khách hàng bạn cần tìm");
                if (this.dgvTracuu.DataSource != null)
                {
                    for (int i = dgvTracuu.Rows.Count - 2; i >= 0; i--)
                    {
                        dgvTracuu.Rows.RemoveAt(i);
                    }
                }
            }
            else
                dgvTracuu.DataSource = dt;
        }

        private void btTracuu6_Click(object sender, EventArgs e)
        {
            dt = kh.TraCuuTheoTinhThanh(kh.LayMaTinh(cbTT.Text));
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có khách hàng bạn cần tìm");
                if (this.dgvTracuu.DataSource != null)
                {
                    for (int i = dgvTracuu.Rows.Count - 2; i >= 0; i--)
                    {
                        dgvTracuu.Rows.RemoveAt(i);
                    }
                }
            }
            else
                dgvTracuu.DataSource = dt;
        }
        #endregion

        #region Soạn lại
        public void Soanlai()
        {
            txt_Dienthoaikh.Text = "";
            txt_TenKH.Text = "";
            txt_Diachikh.Text = "";
            txt_Diachikh.Text = "";
            txt_Email.Text = "";
            txt_Nhomtuoi.Text = "";
            txt_Sotk.Text = "";
            txt_Website.Text = "";
            cb_Dantoc.Text = "--Vui lòng chọn--";
            cb_Linhvuckinhdoanh.Text = "--Vui lòng chọn--";
            cb_Nghenghiep.Text = "--Vui lòng chọn--";
            cb_Nguontimthay.Text = "--Vui lòng chọn--";
            cb_Nhanvien.Text = "--Vui lòng chọn--";
            cb_Quanhuyen.Text = "--Vui lòng chọn--";
            cb_Tinhthanh.Text = "--Vui lòng chọn--";
            cb_Tongiao.Text = "--Vui lòng chọn--";
            txt_Loaikh.Text = "TIỀM NĂNG";
            ck_Doanhnghiep.Checked = false;
            ck_Gioitinh.Checked = false;
            ck_Tinhtrang.Checked = false;
            dt_Ngaysinh.Text = Convert.ToDateTime(DateTime.Now.Date).ToShortDateString();
            dtNgaykethon.Text = Convert.ToDateTime(DateTime.Now.Date).ToShortDateString();
            dtNgaythanhlap.Text = Convert.ToDateTime(DateTime.Now.Date).ToShortDateString();
            LayMaKH();
        }

        private void btSoanlai_Click(object sender, EventArgs e)
        {
            Soanlai();
        }
        #endregion

        #region Hiển thị thông tin khách hàng hiện có

        private void btBrown_Click(object sender, EventArgs e)
        {
            FrmThongTinKhachHang f = new FrmThongTinKhachHang();
            f.ShowDialog();
            HienThiTTKH();
        }
        public void HienThiTTKH()
        {
            //tab.TaoTabKH();
            if (FrmThongTinKhachHang.MaKH != "")
            {
                DataTable dt = kh.HienThiCT(FrmThongTinKhachHang.MaKH);
                txtMakh.Text = dt.Rows[0]["MAKH"].ToString();
                txt_TenKH.Text = dt.Rows[0]["HOTENKH"].ToString();
                txt_Diachikh.Text = dt.Rows[0]["DCHIKH"].ToString();
                txt_Dienthoaikh.Text = dt.Rows[0]["DIENTHOAIKH"].ToString();
                txt_Email.Text = dt.Rows[0]["EMAIL"].ToString();
                txt_Loaikh.Text = kh.LayTenLoaiKH(dt.Rows[0]["MALOAIKH"].ToString());
                txt_Nhomtuoi.Text = kh.LayTenNhomTuoi(dt.Rows[0]["MANHOM"].ToString());
                txt_Sotk.Text = dt.Rows[0]["SOTK"].ToString();
                txt_Website.Text = dt.Rows[0]["WEBSITE"].ToString();
                if (kh.LayTenDT(dt.Rows[0]["MADT"].ToString()) == "")
                    cb_Dantoc.Text = "";
                else
                    cb_Dantoc.Text = kh.LayTenDT(dt.Rows[0]["MADT"].ToString());
                if (kh.LayTenLVTuMa(dt.Rows[0]["MALV"].ToString()) == "")
                    cb_Linhvuckinhdoanh.Text = "--Vui lòng chọn--";
                else
                    cb_Linhvuckinhdoanh.Text = kh.LayTenLVTuMa(dt.Rows[0]["MALV"].ToString());
                if (kh.LayTenNghe(dt.Rows[0]["MANGHE"].ToString()) == "")
                    cb_Nghenghiep.Text = "--Vui lòng chọn--";
                else
                    cb_Nghenghiep.Text = kh.LayTenNghe(dt.Rows[0]["MANGHE"].ToString());
                cb_Nguontimthay.Text = kh.LayTenNguonTimThay(dt.Rows[0]["MANGUON"].ToString());
                cb_Nhanvien.Text = kh.LayTenNV(dt.Rows[0]["MANV"].ToString());
                cb_Quanhuyen.Text = kh.LayTenHuyen(dt.Rows[0]["MAHUYEN"].ToString());
                cb_Tinhthanh.Text = kh.LayTenTinh(dt.Rows[0]["MATINH"].ToString());
                if (kh.LayTenTG(dt.Rows[0]["MATG"].ToString()) == "")
                    cb_Tongiao.Text = "--Vui lòng chọn--";
                else
                    cb_Tongiao.Text = kh.LayTenTG(dt.Rows[0]["MATG"].ToString());
                if (dt.Rows[0]["NGAYKETHON"].ToString() == "")
                    dtNgaykethon.Text = DateTime.Now.Date.ToShortDateString();
                else
                    dtNgaykethon.Text = Convert.ToDateTime(dt.Rows[0]["NGAYKETHON"].ToString()).ToShortDateString();
                if (dt.Rows[0]["NGAYTHANHLAP"].ToString() == "")
                    dtNgaythanhlap.Text = DateTime.Now.Date.ToShortDateString();
                else
                    dtNgaythanhlap.Text = Convert.ToDateTime(dt.Rows[0]["NGAYTHANHLAP"].ToString()).ToShortDateString();
                if (dt.Rows[0]["NGSINH"].ToString() == "")
                    dt_Ngaysinh.Text = DateTime.Now.Date.ToShortDateString();
                else
                    dt_Ngaysinh.Text = Convert.ToDateTime(dt.Rows[0]["NGSINH"].ToString()).ToShortDateString();
                try
                {
                    if (Convert.ToBoolean(dt.Rows[0]["GIOITINH"].ToString()) == true)
                        ck_Gioitinh.Checked = true;
                    else
                        ck_Gioitinh.Checked = false;
                }
                catch
                {
                    ck_Gioitinh.Checked = false;
                }
                try
                {
                    if (Convert.ToBoolean(dt.Rows[0]["TINHTRANGQUANHE"].ToString()) == true)
                        ck_Tinhtrang.Checked = true;
                    else
                        ck_Tinhtrang.Checked = false;
                }
                catch
                {
                    ck_Tinhtrang.Checked = false;
                }
                try
                {
                    if (Convert.ToBoolean(dt.Rows[0]["LADN"].ToString()) == true)
                        ck_Doanhnghiep.Checked = true;
                    else
                        ck_Doanhnghiep.Checked = false;
                }
                catch
                {
                    ck_Doanhnghiep.Checked = false;
                }
            }
            else
                return;
        }
        #endregion

        #region Cập nhật khách hàng
        private void btCapnhat_Click(object sender, EventArgs e)
        {
            if (txtMakh.Text == "" || txt_TenKH.Text == "")
                MessageBox.Show("Mã hoặc tên khách hàng không được rỗng");
            int ladn, gioitinh, tinhtrang;
            string lv, nghe, dtoc, tg, nhomtuoi, ngaysinh, ngaykethon, ngaythanhlap;
            if (dt_Ngaysinh.Text == Convert.ToDateTime(DateTime.Now.Date).ToShortDateString())
                ngaysinh = null;
            else
                ngaysinh = Convert.ToDateTime(dt_Ngaysinh.Text).ToShortDateString();
            if (dtNgaythanhlap.Text == Convert.ToDateTime(DateTime.Now.Date).ToShortDateString())
                ngaythanhlap = null;
            else
                ngaythanhlap = Convert.ToDateTime(dtNgaythanhlap.Text).ToShortDateString();
            if (dtNgaykethon.Text == Convert.ToDateTime(DateTime.Now.Date).ToShortDateString())
                ngaykethon = null;
            else
                ngaykethon = Convert.ToDateTime(dtNgaykethon.Text).ToShortDateString();
            nhomtuoi = kh.LayMaNhomTuoi(txt_Nhomtuoi.Text);
            dtoc = kh.LayMaDT(cb_Dantoc.Text);
            tg = kh.LayMaTG(cb_Tongiao.Text);
            nghe = kh.LayMaNghe(cb_Nghenghiep.Text);
            lv = kh.LayMaLinhVucKinhDoanh(cb_Linhvuckinhdoanh.Text);
            if (ck_Doanhnghiep.Checked == true)
                ladn = 1;
            else
                ladn = 0;
            if (ck_Gioitinh.Checked == true)
                gioitinh = 1;
            else
                gioitinh = 0;
            if (ck_Tinhtrang.Checked == true)
                tinhtrang = 1;
            else
                tinhtrang = 0;
            //bắt lỗi số điện thoại
            string dienthoai = txt_Dienthoaikh.Text;
            if (txtMakh.Text == "" || txt_TenKH.Text == "")
                MessageBox.Show("Mã hoặc tên khách hàng không được rỗng!");
            else
                if (KiemTraSo(txtTENKH.Text) == true)
                    MessageBox.Show("Tên khách hàng không đúng!");
                else
                    if (KiemTraKiHieu(txtTENKH.Text) == true)
                        MessageBox.Show("Tên khách hàng không đúng!");
                    else
                        if (cb_Tinhthanh.Text == "--Vui lòng chọn--")
                            MessageBox.Show("Bạn chưa chọn tỉnh thành!");
                        else
                            if (cb_Quanhuyen.Text == "--Vui lòng chọn--")
                                MessageBox.Show("Bạn chưa chọn quận huyện!");
                            else
                                if (cb_Nhanvien.Text == "--Vui lòng chọn--")
                                    MessageBox.Show("Bạn chưa chọn nhân viên quản lý!");
                                else
                                    if (txt_Email.Text == "")
                                        MessageBox.Show("Bạn chưa nhập Email!");
                                    else
                                        if (cb_Nguontimthay.Text == "--Vui lòng chọn--")
                                            MessageBox.Show("Bạn chưa chọn nguồn tìm thấy khách hàng!");
                                        else
                                            if (dienthoai.Length < 10)
                                                MessageBox.Show("Số điện thoại tối thiểu 11 chữ số!");
                                            else
                                            if (KiemTraSo(txt_Dienthoaikh.Text) == false)

                                                MessageBox.Show("Bạn phải nhập số điện thoại là chữ số!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            else
                                                if (KiemTraKiTu(txt_Dienthoaikh.Text) == true)
                                                    MessageBox.Show("Bạn phải nhập số điện thoại là chữ số!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                else
                                                    if (KiemTraKiHieu(txt_Dienthoaikh.Text) == true)
                                                        MessageBox.Show("Bạn phải nhập số điện thoại là chữ số!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                            else if (KiemTraKiHieu(txt_Sotk.Text) == true)
                                                                MessageBox.Show("Bạn phải nhập số tài khoản là chữ số!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                                            else
                                                            {
                                                                kh.CapNhatKhachHang(txtMakh.Text, kh.LayMaHuyen(kh.LayMaTinh(cb_Tinhthanh.Text), cb_Quanhuyen.Text), kh.LayMaTinh(cb_Tinhthanh.Text), kh.LayMaNguonTimThay(cb_Nguontimthay.Text), kh.LayMaLoaiKH(txt_Loaikh.Text), kh.LayMaNV(cb_Nhanvien.Text), txt_TenKH.Text, txt_Dienthoaikh.Text, txt_Diachikh.Text, txt_Email.Text, txt_Sotk.Text, ladn, dtoc, tg, nhomtuoi, nghe, gioitinh, ngaysinh, tinhtrang, ngaykethon, lv, ngaythanhlap, txt_Website.Text);
                                                                Soanlai();
                                                            }
        }
        #endregion
        #region Danh sách khách hàng quá hạn là thiết lập loại khách hàng
        CCapNhatLoaiKH LKH = new CCapNhatLoaiKH();
        public void LayDanhSachLoaiKhachHang()
        {
            dgvKHThanThiet.DataSource = LKH.LayDSKhachHang();
        }
        public void LayDanhSachKhachHangChinhThucQuaHan()
        {
            dgvKhachHangChinhThucQuaHan.DataSource = LKH.LayDSKhachHangChinhThucQuaHan();
        }

        public void LayDanhSachKhachHangThanThietQuaHan()
        {
            dgvKhachHangThanThietQuaHan.DataSource = LKH.LayDSKhachHangThanThietQuaHan();
        }
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LayDanhSachLoaiKhachHang();
        }

        private void btnCapNhatTLLKH_Click(object sender, EventArgs e)
        {
            LKH.CapNhatLoaiKhachHang();
            LayDanhSachLoaiKhachHang();
        }

        private void btnHienThiCTQH_Click(object sender, EventArgs e)
        {
            LayDanhSachKhachHangChinhThucQuaHan();
        }

        private void btnCapNhatCTQH_Click(object sender, EventArgs e)
        {
            LKH.CapNhatKhachHangChinhThucQuaHan();
            LayDanhSachKhachHangChinhThucQuaHan();
        }

        private void btnHienThiThanThietQuaHan_Click(object sender, EventArgs e)
        {
            LayDanhSachKhachHangThanThietQuaHan();
        }

        private void btnCapNhatThanThietQH_Click(object sender, EventArgs e)
        {
            LKH.CapNhatKhachHangThanThietQuaHan();
            LayDanhSachKhachHangThanThietQuaHan();
        }
        #endregion

        #region Phân quyền
        public void Enable_Insert()
        {
            bt_Them.Enabled = true;
            btSoanlai.Enabled = true;
        }
        public void Enable_UpDate()
        {
            btCapnhat.Enabled = true;
            btSoanlai.Enabled = true;
            btnCapNhatTLLKH.Enabled = true;
            btnCapNhatCTQH.Enabled = true;
            btnCapNhatThanThietQH.Enabled = true;
        }
        #endregion

    }
}
