using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLBANHANG.DataAccessLayer;
using QLBANHANG.BussinessLogicLayer;

namespace QLBANHANG.PresentationLayer
{
    public partial class FrmNgheNghiep : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmNgheNghiep()
        {
            InitializeComponent();
        }
        CNgheNghiep nn = new CNgheNghiep();

        private void FrmNgheNghiep_Load(object sender, EventArgs e)
        {
            dgvNghe.DataSource = nn.HienThiNghe();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (dgvNghe.CurrentRow.Cells["TENNGHE"].Value.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nghề", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                nn.ThemLV(dgvNghe.CurrentRow.Cells["TENNGHE"].Value.ToString());
                dgvNghe.DataSource = nn.HienThiNghe();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            nn.XoaLV(dgvNghe.CurrentRow.Cells["MANGHE"].Value.ToString());
            dgvNghe.DataSource = nn.HienThiNghe();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (dgvNghe.CurrentRow.Cells["TENNGHE"].Value.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nghề", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                nn.CapNhatLV(dgvNghe.CurrentRow.Cells["MANGHE"].Value.ToString(), dgvNghe.CurrentRow.Cells["TENNGHE"].Value.ToString());
                dgvNghe.DataSource = nn.HienThiNghe();
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
