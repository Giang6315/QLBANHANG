using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QLBANHANG.BussinessLogicLayer;
using QLBANHANG.DataAccessLayer;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmLoaiKhachHang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmLoaiKhachHang()
        {
            InitializeComponent();
        }
        CLoaiKH lkh = new CLoaiKH();
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (dgvLoaiKH.CurrentRow.Cells["TENLOAIKH"].Value.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên loại khách hàng");
                return;
            }
            else
            {
                lkh.ThemLoaiKH(dgvLoaiKH.CurrentRow.Cells["TENLOAIKH"].Value.ToString());
                dgvLoaiKH.DataSource = lkh.HienThiLoaiKH();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            lkh.XoaLoaiKH(dgvLoaiKH.CurrentRow.Cells["MALOAIKH"].Value.ToString());
            dgvLoaiKH.DataSource = lkh.HienThiLoaiKH();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (dgvLoaiKH.CurrentRow.Cells["TENLOAIKH"].Value.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên loại khách hàng");
                return;
            }
            else
            {
                lkh.CapNhatLoaiKH(dgvLoaiKH.CurrentRow.Cells["MALOAIKH"].Value.ToString(), dgvLoaiKH.CurrentRow.Cells["TENLOAIKH"].Value.ToString());
                dgvLoaiKH.DataSource = lkh.HienThiLoaiKH();
            }
        }

        private void FrmLoaiKhachHang_Load(object sender, EventArgs e)
        {
            dgvLoaiKH.DataSource = lkh.HienThiLoaiKH();
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