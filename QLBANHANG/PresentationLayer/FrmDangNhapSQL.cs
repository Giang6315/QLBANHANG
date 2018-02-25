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
using System.Data.SqlClient;
using QLBANHANG.DataAccessLayer;
using QLBANHANG.PresentationLayer;
using QLBANHANG.BussinessLogicLayer;
namespace QLBANHANG
{
    public partial class FrmDangNhapSQL : DevExpress.XtraEditors.XtraForm
    {
        public FrmDangNhapSQL()
        {
            InitializeComponent();
        }
        CDatabase db = new CDatabase();
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {

            bool kq;
            if (rd_Windows.Checked == true)
            {

                kq = db.KetNoi(txt_TenServer.Text, txt_CoSoDuLieu.Text, true, txt_TenUser.Text, null);
                if (txt_TenServer.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên Server!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txt_CoSoDuLieu.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên cơ sở dữ liệu!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
                else if (txt_CoSoDuLieu.Text != "QUANLYKHACHHANG")
                {
                    MessageBox.Show("Tên cơ sở dữ liệu không đúng!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                else
                    if(txt_CoSoDuLieu.Text == "QUANLYKHACHHANG" && txt_TenServer.Text!="")
                    {
                        this.Hide();
                        FrmMain ht = new FrmMain();
                        ht.ShowDialog();
                        
                    }
            
            }
            else if (rd_SQLServer.Checked == true)
            {
                kq = db.KetNoi(txt_TenServer.Text, txt_CoSoDuLieu.Text, true, txt_TenUser.Text, txt_MatKhau.Text);
              
                if (txt_TenServer.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên Server!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txt_TenUser.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên User!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txt_MatKhau.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txt_CoSoDuLieu.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên cơ sở dữ liệu!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txt_CoSoDuLieu.Text != "QUANLYKHACHHANG")
                {
                    MessageBox.Show("Tên cơ sở dữ liệu không đúng!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txt_CoSoDuLieu.Text == "QUANLYKHACHHANG" && txt_TenServer.Text != "" && txt_TenUser.Text != "" && txt_MatKhau.Text != "")
                {
                    this.Hide();
                    FrmMain ht = new FrmMain();
                    ht.ShowDialog();
                }
                else if (db.sqlconn.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Lỗi kết nối! ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             
                   
            }
        }

        private void rd_Windows_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_Windows.Checked== true)
            {
                txt_TenUser.Enabled = false;
                txt_MatKhau.Enabled = false;
            }
            else if(rd_SQLServer.Checked== true)
            {
                txt_TenUser.Enabled = true;
                txt_MatKhau.Enabled = true;
            }
        }



        private void FrmDangNhapSQL_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void FrmDangNhapSQL_Load(object sender, EventArgs e)
        {
            rd_Windows.Checked = true;
            //rd_SQLServer.Enabled = false;
            txt_TenServer.Text = @".\SQL2008R2";
            //txt_TenServer.Enabled = false;
            //txt_MatKhau.Enabled = false;
            txt_CoSoDuLieu.Text ="QUANLYKHACHHANG";
            txt_CoSoDuLieu.Enabled = false;
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
