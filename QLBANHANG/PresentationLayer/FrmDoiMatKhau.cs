using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLBANHANG.BussinessLogicLayer;
using System.Linq;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmDoiMatKhau : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }
        CDOIMATKHAU DMK = new CDOIMATKHAU();
        public static bool LaKiTu(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
        }

        public static bool LaSo(char c)
        {
            return c >= '0' && c <= '9';
        }
        public static bool LaKiHieu(char c)
        {
            return c > 32 && c < 127 && !LaSo(c) && !LaKiTu(c);
        }
        public static bool KiemTraPassword(string password)
        {
            return
               password.Any(c => LaKiTu(c)) &&
               password.Any(c => LaSo(c)) &&
               password.Any(c => LaKiHieu(c));
        }
        private void btnDoiMatKhau_Click_1(object sender, EventArgs e)
        {
            string matkhau = txtMatKhauMoi.Text;
            if (matkhau.Length < 8)
                MessageBox.Show("Mật khẩu phải có ít nhất 8 kí tự!","Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            if (KiemTraPassword(txtMatKhauMoi.Text) == true)
            {
                DMK.DOIMATKHAU(txtTenDangNhap.Text, txtMatKhauCu.Text, txtMatKhauMoi.Text);
                txtTenDangNhap.ResetText();
                txtMatKhauCu.ResetText();
                txtMatKhauMoi.ResetText();
            }
            else
                MessageBox.Show("Mật khẩu phải có kí tự, số và kí tự đặc biệt!","Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region Đổi mật khẩu
        public void Enable_Insert()
        {
            btnDoiMatKhau.Enabled = true;

        }
        public void Enable_Delete()
        {
            btnDoiMatKhau.Enabled = true;
        }
        public void Enable_UpDate()
        {
            btnDoiMatKhau.Enabled = true;
        }
        #endregion
    }
}