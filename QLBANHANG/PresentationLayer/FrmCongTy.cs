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
    public partial class FrmCongTy : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmCongTy()
        {
            InitializeComponent();
        }
        CCongTy ct = new CCongTy();

        private void FrmCongTy_Load(object sender, EventArgs e)
        {
            dgvCongty.DataSource = ct.HienThiCongTy();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ct.ThemCongTy(dgvCongty.CurrentRow.Cells["TENCTY"].Value.ToString(), dgvCongty.CurrentRow.Cells["DIACHICTY"].Value.ToString(), dgvCongty.CurrentRow.Cells["DIENTHOAICTY"].Value.ToString());
            dgvCongty.DataSource = ct.HienThiCongTy();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            ct.XoaCongTy(dgvCongty.CurrentRow.Cells["MACTY"].Value.ToString());
            dgvCongty.DataSource = ct.HienThiCongTy();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            ct.CapNhatCongTy(dgvCongty.CurrentRow.Cells["MACTY"].Value.ToString(), dgvCongty.CurrentRow.Cells["TENCTY"].Value.ToString(), dgvCongty.CurrentRow.Cells["DIACHICTY"].Value.ToString(), dgvCongty.CurrentRow.Cells["DIENTHOAICTY"].Value.ToString());
            dgvCongty.DataSource = ct.HienThiCongTy();
        }        
    }
}