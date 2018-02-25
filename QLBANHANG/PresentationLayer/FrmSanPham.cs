using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using QLBANHANG.PresentationLayer;
using QLBANHANG.BussinessLogicLayer;
using QLBANHANG.DataAccessLayer;
using System.Runtime.InteropServices;

namespace QLBANHANG.PresentationLayer
{
    public partial class FrmSanPham : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmSanPham()
        {
            InitializeComponent();
        }
        CSanPham sp = new CSanPham();
        CDatabase db = new CDatabase();

        public void HienThiCB()
        {
            TENDVI.DataSource = sp.LayLoaiDV();
            TENDVI.ValueMember = "TENDVI";
            TENDVI.DisplayMember = "TENDVI";
        }
       
        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            HienThiCB();
            HienThiTenLoaiSP();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (dtgSanPham.CurrentRow.Cells["MASP"].Value.ToString() == "")
            {
                MessageBox.Show("Bạn chưa chọn mã sản phẩm");
                return;
            }
            else
            if (dtgSanPham.CurrentRow.Cells["TENDVI"].Value.ToString() == "")
            {
                MessageBox.Show("Bạn chưa chọn đơn vị tính");
                return;
            }
            else if (dtgSanPham.CurrentRow.Cells["TENSP"].Value.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm");
                return;
            }
            else if (dtgSanPham.CurrentRow.Cells["dongia"].Value.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập đơn giá");
                return;
            }
            else if (dtgSanPham.CurrentRow.Cells["mota"].Value.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập mô tả sản phẩm");
                return;
            }
            else
            {
                 
                sp.ThemSP(dtgSanPham.CurrentRow.Cells["MASP"].Value.ToString(),
                    sp.LayMaLoaiTuTenLoai(cbLoaiSP.Text), 
                    dtgSanPham.CurrentRow.Cells["TENSP"].Value.ToString(), 
                    sp.LayMaLoaiDVTuTenDV(dtgSanPham.CurrentRow.Cells["TENDVI"].Value.ToString()), 
                    dtgSanPham.CurrentRow.Cells["MOTA"].Value.ToString(), 
                    double.Parse(dtgSanPham.CurrentRow.Cells["DONGIA"].Value.ToString()));

                dtgSanPham.DataSource = sp.HienThiSPTheoLoaiSP(cbLoaiSP.Text);
               
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            sp.XoaSP(dtgSanPham.CurrentRow.Cells["MASP"].Value.ToString());
            dtgSanPham.DataSource = sp.HienThiSPTheoLoaiSP(cbLoaiSP.Text);
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (dtgSanPham.CurrentRow.Cells["TENDVI"].Value.ToString() == "")
            {
                MessageBox.Show("Bạn chưa chọn đơn vị tính");
                return;
            }
            else if (dtgSanPham.CurrentRow.Cells["TENSP"].Value.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm");
                return;
            }
            else if (dtgSanPham.CurrentRow.Cells["DONGIA"].Value.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập đơn giá");
                return;
            }
            else
            {
                sp.CapNhatSP(dtgSanPham.CurrentRow.Cells["MASP"].Value.ToString(), sp.LayMaLoaiTuTenLoai(cbLoaiSP.Text), sp.LayMaLoaiDVTuTenDV(dtgSanPham.CurrentRow.Cells["TENDVI"].Value.ToString()), dtgSanPham.CurrentRow.Cells["TENSP"].Value.ToString(), dtgSanPham.CurrentRow.Cells["MOTA"].Value.ToString(), double.Parse(dtgSanPham.CurrentRow.Cells["DONGIA"].Value.ToString()));
                dtgSanPham.DataSource = sp.HienThiSPTheoLoaiSP(cbLoaiSP.Text);
            }
        }

        public void HienThiTenLoaiSP()
        {
            for (int i = 0; i < sp.LayLoaiSP().Rows.Count; i++)
            {
                cbLoaiSP.Items.Add(sp.LayLoaiSP().Rows[i]["TENLOAI"].ToString());
            }
        }

        private void cbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgSanPham.DataSource= sp.HienThiSPTheoLoaiSP(cbLoaiSP.Text);
        }

        #region Phân quyền
        public void Enable_Insert()
        {
            btn_Them.Enabled = true;
        }
        public void Enable_Delete()
        {
            btn_Xoa.Enabled = true;
        }
        public void Enable_UpDate()
        {
            btn_CapNhat.Enabled = true;
        }
        #endregion

        private void btTim1_Click(object sender, EventArgs e)
        {
            if (txtMASP.Text == "")
                MessageBox.Show("Bạn chưa nhập mã sản phẩm");
            DataTable dt = sp.TCTheoMaSP(txtMASP.Text);
            if (dt.Rows.Count == 0)
                MessageBox.Show("Không có sản phẩm bạn cần tìm");
            else
                dgvTraCuu.DataSource = dt;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text == "")
                MessageBox.Show("Bạn chưa nhập tên sản phẩm");
            DataTable dt = sp.TCTheoTenSP(txtTenSP.Text);
            if (dt.Rows.Count == 0)
                MessageBox.Show("Không có sản phẩm bạn cần tìm");
            else
                dgvTraCuu.DataSource = dt;
        }
    }
}