﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using QLBANHANG.DataAccessLayer;
using QLBANHANG.BussinessLogicLayer;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmDangNhapHeThong : DevExpress.XtraEditors.XtraForm
    {
        
        public FrmDangNhapHeThong()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        CDatabase db = new CDatabase();
        CPHANQUYEN PQ = new CPHANQUYEN();
        CKichHoatMenu open = new CKichHoatMenu();
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
                if (txt_TenDangNhap.Text != "" && txt_MatKhau.Text != "")
            {
                DataTable dt1 = new DataTable();
                dt1 = CPHANQUYEN.LAYDSNGUOIDUNG();
                FrmMain f = new FrmMain();
                bool kq = false;
                for (int i = 0; i <= dt1.Rows.Count - 1; i++)
                {
                    //khoi tao mat khau bang rong
                    //Ma hoa mat khau khi nhap vao txt_MatKhau

                    if (txt_TenDangNhap.Text == dt1.Rows[i]["TENDANGNHAP"].ToString() && CMaHoaVaGiaiMaMatKhau.EncryptString(txt_MatKhau.Text).ToString() == dt1.Rows[i]["MATKHAU"].ToString())
                    {
                        kq = true;

                        if ((bool)dt1.Rows[i]["QUYENADMIN"] == true)
                        {

                            this.Close();
                            FrmMain.TenDangNhap = txt_TenDangNhap.Text;
                            open.KichHoatFormAdmin();
                            break;
                        }
                        else if ((bool)dt1.Rows[i]["QUYENADMIN"] == false)
                        {
                            this.Close();
                            FrmMain.TenDangNhap = txt_TenDangNhap.Text;
                            open.KichHoatFormUser();
                            break;
                        }

                    }
                    else
                        kq = false;
                }
                if (kq==false)
                        XtraMessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
            }
            else
                XtraMessageBox.Show("Tên đăng nhập và mật khẩu không được rỗng!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmDangNhapHeThong_Load(object sender, EventArgs e)
        {
           
            //txt_TenDangNhap.Text = "admin";
            //txt_MatKhau.Text = "admin";
        }

        private void btn_DangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               this.DialogResult = DialogResult.OK;
               
            }
        }
    }
}