using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using QLBANHANG.DataAccessLayer;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmPhucHoiCSDL : DevExpress.XtraEditors.XtraForm
    {
        public FrmPhucHoiCSDL()
        {
            InitializeComponent();
        }

        private void FrmSaoLuu_Load(object sender, EventArgs e)
        {

        }
        CDatabase db = new CDatabase();
        public OpenFileDialog OpenFile = new OpenFileDialog();
        private void btnDuyet_Click(object sender, EventArgs e)
        {
            OpenFile.Filter = "Tất cả tập tin|*.*";
            //OpenFile.DefaultExt = ".BAK";
            OpenFile.InitialDirectory = @"E:\";
            OpenFile.CheckFileExists = true;
            OpenFile.CheckPathExists = true;
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                txtSaoLuu.Text = OpenFile.FileName;
            }
        }
        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(@"use master  RESTORE DATABASE " + Path.GetFileNameWithoutExtension(OpenFile.FileName.Substring(OpenFile.FileName.LastIndexOf("\\") + 1)) + " FROM DISK='" + txtSaoLuu.Text + "' with replace");
                db.ThucThiLenh(cmd);
                MessageBox.Show("Phục hồi dữ liệu thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi\t " + ex.Message);
            }
        }


    }


}
