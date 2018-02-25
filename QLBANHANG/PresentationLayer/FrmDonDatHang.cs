using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using QLBANHANG.DataAccessLayer;
using QLBANHANG.BussinessLogicLayer;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmDonDatHang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmDonDatHang()
        {
            InitializeComponent();
        }
        CDONDATHANG DDH = new CDONDATHANG();
        CKHACHHANG KH = new CKHACHHANG();
        CDatabase db = new CDatabase();
        CCAPNHATDONDATHANG CN = new CCAPNHATDONDATHANG();
        CTAOTAB tab = new CTAOTAB();
        public static int trangthai = 0;
        public static int trangthai2 = 0;
        public void LayDSSanPham()
        {
            cbSanPham.Items.Add("--Vui lòng chọn--");
            cbSanPham.SelectedIndex = 0;
            for (int i = 0; i < DDH.LayDanhSachSanPham().Rows.Count; i++)
            {
                cbSanPham.Items.Add(DDH.LayDanhSachSanPham().Rows[i]["TENSP"].ToString());
            }
         
        }

        public void LayDSKhachHang()
        {
            cbTenKH.Items.Add("--Vui lòng chọn--");
            cbTenKH.SelectedIndex = 0;
            for (int i = 0; i < DDH.LayDanhSachKhachHang().Rows.Count; i++)
            {
                cbTenKH.Items.Add(DDH.LayDanhSachKhachHang().Rows[i]["HOTENKH"].ToString());
            }
        }
        //goi thu thuc lay ma don dat hang(Cho ma tu dong tang)
        public void LayMaDonDatHang()
        {
            using (DataTable dt = db.ExecuteBang("EXEC LAYMADDH"))
            {
                txtMaDonDatHang.Text = dt.Rows[0][0].ToString();
            }
        }

        public void TinhThanhTien()
        { 
            int socot = dataGridViewDonDatHang.Rows.Count;
            float thanhtien=0;
            for (int i = 0; i < socot - 1; i++)
                thanhtien += float.Parse(dataGridViewDonDatHang.Rows[i].Cells["THANHTIEN"].Value.ToString());
            txtTongThanhTien.Text = thanhtien.ToString();   
        }
        private void FrmDonDatHang_Load(object sender, EventArgs e)
        {
            LayMaDonDatHang();
            LayDSSanPham();
            LayDSKhachHang();
            txtNgayDat.Text = DateTime.Today.ToString("dd/MM/yyyy");
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaDonDatHang.Text == "")
                XtraMessageBox.Show("Vui lòng nhập vào mã đơn đặt hàng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtNgayDat.Text == "")
                XtraMessageBox.Show("Vui lòng nhập vào ngày đặt hàng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtSOLUONG.Text == "")
                XtraMessageBox.Show("Vui lòng nhập vào số lượng đặt!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (cbTenKH.Text == "")
                XtraMessageBox.Show("Vui lòng chọn tên khách hàng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (cbSanPham.Text == "")
                XtraMessageBox.Show("Vui lòng chọn tên sản phẩm!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {

                DDH.ThemDonDatHang(txtMaDonDatHang.Text, DDH.LayMaKHTuTenKH(cbTenKH.Text), DateTime.Parse(txtNgayDat.Text), DDH.LayMaSPTuTenSP(cbSanPham.Text), int.Parse(txtSOLUONG.Text));
                dataGridViewDonDatHang.DataSource = DDH.LayDSDonDatHang(txtMaDonDatHang.Text);
                TinhThanhTien();
                cbSanPham.Text = "--Vui lòng chọn--";
                txtSOLUONG.Text = "";
            }
        }
 
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            CN.SuaDonDatHang(txtMaDonDatHang.Text, dataGridViewDonDatHang.CurrentRow.Cells[0].Value.ToString(), int.Parse(txtSOLUONG.Text));
            dataGridViewDonDatHang.DataSource = DDH.LayDSDonDatHang(txtMaDonDatHang.Text);
            TinhThanhTien();
        }

        private void txtMaDonDatHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                cbTenKH.Focus();
            }
        }

        private void txtSOLUONG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThem.PerformClick();
            }
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            CN.XoaSanPham(dataGridViewDonDatHang.CurrentRow.Cells[0].Value.ToString(), txtMaDonDatHang.Text);
            dataGridViewDonDatHang.DataSource = DDH.LayDSDonDatHang(txtMaDonDatHang.Text);
            TinhThanhTien();
        }

        private void cbTenKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode==Keys.Down)
                cbSanPham.Focus();
        }

        private void cbSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                txtSOLUONG.Focus();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaDonDatHang.Text = "";
            cbTenKH.Text = "";
            cbSanPham.Text = "";
            txtSOLUONG.Text = "";
            LayMaDonDatHang();
            
        }

        private void dataGridViewDonDatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSOLUONG.Text = dataGridViewDonDatHang.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnTraCuuDDH_Click(object sender, EventArgs e)
        {
            DDH.TAOTABTRACUUDONDATHANG();
        }

        private void btMADDH_Click(object sender, EventArgs e)
        {
            FrmThongTinDonDatHang tt = new FrmThongTinDonDatHang();
            tt.ShowDialog();
        }

        #region Phân quyền
        #endregion
    }
}