    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;
using QLBANHANG.BussinessLogicLayer;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmLoaiSanPham : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmLoaiSanPham()
        {
            InitializeComponent();
        }
        CLOAISANPHAM LSP = new CLOAISANPHAM();
        private void FrmLoaiSanPham_Load(object sender, EventArgs e)
        {
            dgvLoaiSanPham.DataSource = LSP.LayDanhSachLoaiSanPham();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (dgvLoaiSanPham.CurrentRow.Cells[1].Value.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên loại sản phẩm");
                return;
            }
            else
            {
                LSP.ThemLoaiSanPham(dgvLoaiSanPham.CurrentRow.Cells[0].Value.ToString(), dgvLoaiSanPham.CurrentRow.Cells[1].Value.ToString());
                dgvLoaiSanPham.DataSource = LSP.LayDanhSachLoaiSanPham();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            LSP.XoaLoaiSanPham(dgvLoaiSanPham.CurrentRow.Cells[0].Value.ToString());
            dgvLoaiSanPham.DataSource = LSP.LayDanhSachLoaiSanPham();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (dgvLoaiSanPham.CurrentRow.Cells[1].Value.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên loại sản phẩm");
                return;
            }
            else
            {
                LSP.CapNhatLoaiSanPham(dgvLoaiSanPham.CurrentRow.Cells[0].Value.ToString(), dgvLoaiSanPham.CurrentRow.Cells[1].Value.ToString());
                dgvLoaiSanPham.DataSource = LSP.LayDanhSachLoaiSanPham();
            }
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
    }
}