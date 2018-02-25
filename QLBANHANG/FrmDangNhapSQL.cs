using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;

namespace QLBANHANG
{
    public partial class FrmDangNhapSQL : DevExpress.XtraEditors.XtraForm
    {
        public FrmDangNhapSQL()
        {
            InitializeComponent();
        }
        private void CreateRadioEditors()
        {
           
            
        }

        private void radioGroup_DangNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            RadioGroup edit = sender as RadioGroup;
            if (edit.SelectedIndex == 0)
            {
                txtUser.Enabled = false;
                txtMatKhau.Enabled = false;
            }
            else 
            {
                txtUser.Enabled = true;
                txtMatKhau.Enabled = true;
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {

        }

    }
}
