using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using QLBANHANG.DataAccessLayer;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmSaoLuuCSDL : DevExpress.XtraEditors.XtraForm
    {
        public FrmSaoLuuCSDL()
        {
            InitializeComponent();
        }
        CDatabase db = new CDatabase();
        private void btnDuyet_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtSaoLuu.Text = saveFileDialog.FileName;
            }
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(@"BACKUP DATABASE " + System.IO.Path.GetFileNameWithoutExtension((saveFileDialog.FileName.Substring(saveFileDialog.FileName.LastIndexOf("\\") + 1))) + " TO DISK='" + txtSaoLuu.Text + "'");
                db.ThucThiLenh(cmd);
                MessageBox.Show("Sao lưu dữ liệu thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi\t " + ex.Message);
            }
        }
    }
}