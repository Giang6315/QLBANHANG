using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QLBANHANG.DataAccessLayer;
using QLBANHANG.BussinessLogicLayer;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmTonGiao : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmTonGiao()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        CTonGiao tgiao = new CTonGiao();
        private void FrmTonGiao_Load(object sender, EventArgs e)
        {
            dgvTonGiao.DataSource = tgiao.HienThiTonGiao();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (dgvTonGiao.CurrentRow.Cells["TENTG"].Value.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tôn giáo");
                return;
            }
            else
            {
                tgiao.ThemTonGiao(dgvTonGiao.CurrentRow.Cells["TENTG"].Value.ToString());
                dgvTonGiao.DataSource = tgiao.HienThiTonGiao();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            tgiao.XoaTonGiao(dgvTonGiao.CurrentRow.Cells["MATG"].Value.ToString());
            dgvTonGiao.DataSource = tgiao.HienThiTonGiao();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (dgvTonGiao.CurrentRow.Cells["TENTG"].Value.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tôn giáo");
                return;
            }
            else
            {
                tgiao.CapNhatTonGiao(dgvTonGiao.CurrentRow.Cells["MATG"].Value.ToString(), dgvTonGiao.CurrentRow.Cells["TENTG"].Value.ToString());
                dgvTonGiao.DataSource = tgiao.HienThiTonGiao();
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