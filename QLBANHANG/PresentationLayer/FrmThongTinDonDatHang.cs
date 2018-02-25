using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBANHANG.BussinessLogicLayer;
using QLBANHANG.DataAccessLayer;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmThongTinDonDatHang : DevExpress.XtraEditors.XtraForm
    {
        public FrmThongTinDonDatHang()
        {
            InitializeComponent();
        }
        CThongTinDDH tt = new CThongTinDDH();
        CTAOTAB tab = new CTAOTAB();
        public static string MADH = "";

        private void FrmThongTinDonDatHang_Load(object sender, EventArgs e)
        {
            dgvThongTinDDH.DataSource = tt.HienThiDSDDH();
        }

        private void dgvThongTinDDH_DoubleClick(object sender, EventArgs e)
        {
           MADH= dgvThongTinDDH.CurrentRow.Cells["MADDH"].Value.ToString();
           tab.TaoTabDonDatHang();
            this.Close();
        }
    }
}