﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;
using QLBANHANG.BussinessLogicLayer;
using QLBANHANG.Report;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmSPDatHangNhieu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmSPDatHangNhieu()
        {
            InitializeComponent();
        }
        CXuatSanPham sp = new CXuatSanPham();
        DataTable dt = new DataTable();
        public void HienThiComboBox()
        {
            cbLoaiSanPham.Items.Add("--Vui lòng chọn--");
            cbLoaiSanPham.SelectedIndex = 0;
            for (int i = 0; i < sp.LayDSSanPham().Rows.Count; i++)
            {
                cbLoaiSanPham.Items.Add(sp.LayDSSanPham().Rows[i]["tenloai"].ToString());
            }
        }
        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            rptSPDatNhieu rpt = new rptSPDatNhieu();
            rpt.DataSource = sp.LaySPDatNhieu(deTuNgay.Text, deDenNgay.Text, sp.LayMaLoaiTuTenLoaiSP(cbLoaiSanPham.Text));
            rpt.BindDanhSachSanPham();
            printControl1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }

        private void FrmXuatSanPham_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmSPDatHangNhieu_Load(object sender, EventArgs e)
        {
            deTuNgay.Text = DateTime.Now.ToShortDateString();
            deDenNgay.Text = DateTime.Now.ToShortDateString();
            HienThiComboBox();
        }
    }
}