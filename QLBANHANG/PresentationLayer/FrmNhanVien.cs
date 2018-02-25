using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//tang nay chi giao tiep voi BusinessLogiclayer
using QLBANHANG.BussinessLogicLayer;
using QLBANHANG.DataAccessLayer;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Data.SqlClient;
//thu vien cho XtraMessageBox
using DevExpress.Utils;
using DevExpress.XtraEditors;
//thu vien cho radiobutton
//using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmNhanVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        public FrmNhanVien()
        {
            InitializeComponent();
        }
        CNhanVien nv = new CNhanVien();

        public void HienThiCB()
        {
            CHUCVU.DataSource = nv.LayDSCV();
            CHUCVU.ValueMember = "TENCV";
            CHUCVU.DisplayMember = "TENCV";
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            HienThiCB();
            dgvNhanVien.DataSource = nv.LayDanhSachNhanVien();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow.Cells["HOTENNV"].Value.ToString() == "")
                MessageBox.Show("Bạn chưa nhập tên nhân viên");
            else
            {
                nv.ThemNhanVien(dgvNhanVien.CurrentRow.Cells["HOTENNV"].Value.ToString(), dgvNhanVien.CurrentRow.Cells["DIENTHOAINV"].Value.ToString(), nv.LayMaCVTuTenCV (dgvNhanVien.CurrentRow.Cells["CHUCVU"].Value.ToString()));
                dgvNhanVien.DataSource = nv.LayDanhSachNhanVien();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            nv.XoaNhanVien(dgvNhanVien.CurrentRow.Cells["MANV"].Value.ToString());
            dgvNhanVien.DataSource = nv.LayDanhSachNhanVien();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            nv.CapNhatNhanVien(dgvNhanVien.CurrentRow.Cells["MANV"].Value.ToString(), dgvNhanVien.CurrentRow.Cells["HOTENNV"].Value.ToString(), dgvNhanVien.CurrentRow.Cells["DIENTHOAINV"].Value.ToString(), nv.LayMaCVTuTenCV (dgvNhanVien.CurrentRow.Cells["CHUCVU"].Value.ToString()));
            dgvNhanVien.DataSource = nv.LayDanhSachNhanVien();
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