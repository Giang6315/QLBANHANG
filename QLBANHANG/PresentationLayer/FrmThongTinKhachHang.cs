using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using QLBANHANG.BussinessLogicLayer;
using QLBANHANG.DataAccessLayer;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmThongTinKhachHang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        CTAOTAB tab = new CTAOTAB();
        DataTable dt = new DataTable();
        CThongTinKhachHang tt = new CThongTinKhachHang();
        CKHACHHANG kh = new CKHACHHANG();
        public static string MaKH = "";
        public FrmThongTinKhachHang()
        {
            InitializeComponent();
        }

        #region Tra cứu
        private void btTim1_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
                MessageBox.Show("Bạn phải nhập mã khách hàng");
            else
            {
                if (tt.TraCuuKHTheoMa(txtMaKH.Text).Rows.Count == 0)
                {
                    MessageBox.Show("Không có khách hàng bạn cần tìm");
                    txtMaKH.Text = "";
                }
                else
                {
                    dgvThongtinkh.DataSource = tt.TraCuuKHTheoMa(txtMaKH.Text);
                    txtMaKH.Text = "";
                }
            }
        }

        private void btTim3_Click(object sender, EventArgs e)
        {
            dt = kh.TraCuuTheoNgaySinh(dtNgaysinh.Text);
            if (dt.Rows.Count == 0)
                MessageBox.Show("Không có khách hàng bạn cần tìm");
            else
                dgvThongtinkh.DataSource = dt;
        }

        private void btTim2_Click(object sender, EventArgs e)
        {
            dt = kh.TraCuuTheoLoaiKH(cbLoaiKH.Text);
            if (dt.Rows.Count == 0)
                MessageBox.Show("Không có khách hàng bạn cần tìm");
            else
                dgvThongtinkh.DataSource = dt;
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "")
                MessageBox.Show("Bạn phải nhập tên khách hàng");
            else
            {
                if (tt.TraCuuTheoTen(txtTenKH.Text).Rows.Count == 0)
                {
                    MessageBox.Show("Không có khách hàng bạn cần tìm");
                    txtTenKH.Text = "";
                }
                else
                {
                    dgvThongtinkh.DataSource = tt.TraCuuTheoTen(txtTenKH.Text);
                    txtTenKH.Text = "";
                }
            }
        }
        #endregion

        #region Loại khách hàng
        public void LayLoaiKH()
        {
            cbLoaiKH.Items.Add("--Vui lòng chọn--");
            cbLoaiKH.SelectedIndex = 0;
            for (int i = 0; i < kh.LayLoaiKH().Rows.Count; i++)
            {
                cbLoaiKH.Items.Add(kh.LayLoaiKH().Rows[i]["TENLOAIKH"].ToString());
            }
        }
        #endregion
       
        #region Load
        private void FrmThongTinKhachHang_Load(object sender, EventArgs e)
        {
            dgvThongtinkh.DataSource = tt.HienThiDSKH();
            LayLoaiKH();
        }
        #endregion

        #region Danh sách các sự kiện
        private void dgvThongtinkh_DoubleClick(object sender, EventArgs e)
        {
            //MaKH = dgvThongtinkh.CurrentRow.Cells["colmakh"].Value.ToString();
            //tab.TaoTabKH();
            //this.Close();
        }

        private void btThemKH_Click_1(object sender, EventArgs e)
        {
            //tab.TaoTabKH();
            //this.Close();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}