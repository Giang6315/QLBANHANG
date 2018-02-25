using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;
using QLBANHANG.DataAccessLayer;
using QLBANHANG.BussinessLogicLayer;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmDonViTinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmDonViTinh()
        {
            InitializeComponent();
        }
        CDatabase db = new CDatabase();
        CDONVITINH DV = new CDONVITINH();
        private void FrmDonViTinh_Load(object sender, EventArgs e)
        {
            dgvDonViTinh.DataSource = DV.LayDanhSachDonViTinh();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (dgvDonViTinh.CurrentRow.Cells[1].Value.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đơn vị tính");
                return;
            }
            else
            {
                DV.ThemDonViTinh(dgvDonViTinh.CurrentRow.Cells[1].Value.ToString());
                dgvDonViTinh.DataSource = DV.LayDanhSachDonViTinh();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DV.XoaDonViTinh(dgvDonViTinh.CurrentRow.Cells[0].Value.ToString());
            dgvDonViTinh.DataSource = DV.LayDanhSachDonViTinh();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (dgvDonViTinh.CurrentRow.Cells[1].Value.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đơn vị tính");
                return;
            }
            else
            {
                DV.CapNhatDonViTinh(dgvDonViTinh.CurrentRow.Cells[0].Value.ToString(), dgvDonViTinh.CurrentRow.Cells[1].Value.ToString());
                dgvDonViTinh.DataSource = DV.LayDanhSachDonViTinh();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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