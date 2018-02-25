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
    public partial class FrmDanToc : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmDanToc()
        {
            InitializeComponent();
        }
        DataTable dt=new DataTable();
        CDanToc dtoc=new CDanToc();
        private void FrmDanToc_Load(object sender, EventArgs e)
        {
            dgvDantoc.DataSource=dtoc.HienThiDanToc();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (dgvDantoc.CurrentRow.Cells["TENDT"].Value.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên dân tộc");
                return;
            }
            else
            {
                dtoc.ThemDanToc(dgvDantoc.CurrentRow.Cells["TENDT"].Value.ToString());
                dgvDantoc.DataSource = dtoc.HienThiDanToc();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            dtoc.XoaDanToc(dgvDantoc.CurrentRow.Cells["MADT"].Value.ToString());
            dgvDantoc.DataSource=dtoc.HienThiDanToc();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (dgvDantoc.CurrentRow.Cells["TENDT"].Value.ToString() == "")
                MessageBox.Show("Bạn chưa nhập tên dân tộc");
            else
            {
                dtoc.CapNhatDanToc(dgvDantoc.CurrentRow.Cells["MADT"].Value.ToString(), dgvDantoc.CurrentRow.Cells["TENDT"].Value.ToString());
                dgvDantoc.DataSource = dtoc.HienThiDanToc();
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