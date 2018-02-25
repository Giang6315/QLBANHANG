using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLBANHANG.BussinessLogicLayer;
using QLBANHANG.DataAccessLayer;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmChucVu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmChucVu()
        {
            InitializeComponent();
        }
        CChucVu cv = new CChucVu();

        private void FrmChucVu_Load(object sender, EventArgs e)
        {
            dgvChucVu.DataSource = cv.HienThiChiTiet();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            cv.ThemChucVu(dgvChucVu.CurrentRow.Cells[1].Value.ToString());
            dgvChucVu.DataSource = cv.HienThiChiTiet();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            cv.XoaChucVu(dgvChucVu.CurrentRow.Cells[0].Value.ToString());
            dgvChucVu.DataSource = cv.HienThiChiTiet();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            cv.CapNhatCV(dgvChucVu.CurrentRow.Cells[0].Value.ToString(), dgvChucVu.CurrentRow.Cells[1].Value.ToString());
            dgvChucVu.DataSource = cv.HienThiChiTiet();
        }
        #region Phan Quyen
        public void Enable_Insert()
        {
            btThem.Enabled = true;

        }
        public void Enable_Delete()
        {
            btXoa.Enabled = true;

        }
        public void Enable_UpDate()
        {
            btCapNhat.Enabled = true;

        }
        #endregion
    }
}
