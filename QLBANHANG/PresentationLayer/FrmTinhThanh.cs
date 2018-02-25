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
using QLBANHANG.DataAccessLayer;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmTinhThanh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmTinhThanh()
        {
            InitializeComponent();
        }
        #region PHAN QUYEN
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
        CTINHTHANH TT = new CTINHTHANH();
        CDatabase db = new CDatabase();
        private void FrmTinhThanh_Load(object sender, EventArgs e)
        {
            
            dgvTinhThanh.DataSource = TT.LayDSTinhThanh();
        }


        private void btn_Them_Click(object sender, EventArgs e)
        {
          if (dgvTinhThanh.CurrentRow.Cells["TENTINH"].Value.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tỉnh");
                return;
            }
            else
            {
                //TT.ThemTinhThanh(TT.LayMaQGTuTenQG(dgvTinhThanh.CurrentRow.Cells["TENQG"].Value.ToString()), dgvTinhThanh.CurrentRow.Cells["TENTINH"].Value.ToString());
                dgvTinhThanh.DataSource = TT.LayDSTinhThanh();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            TT.XoaTinhThanh(dgvTinhThanh.CurrentRow.Cells["MATINH"].Value.ToString());
            dgvTinhThanh.DataSource = TT.LayDSTinhThanh();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (dgvTinhThanh.CurrentRow.Cells["TENTINH"].Value.ToString() == "")
             {
                 MessageBox.Show("Bạn chưa nhập tên tỉnh");
                 return;
             }
             else
             {
                 //TT.CapNhatTinhThanh(dgvTinhThanh.CurrentRow.Cells["MATINH"].Value.ToString(), TT.LayMaQGTuTenQG(dgvTinhThanh.CurrentRow.Cells["TENQG"].Value.ToString()), dgvTinhThanh.CurrentRow.Cells["TENTINH"].Value.ToString());
                 dgvTinhThanh.DataSource = TT.LayDSTinhThanh();
             }
        }
    }
}