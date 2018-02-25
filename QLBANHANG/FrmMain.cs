using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTab;
namespace QLBANHANG
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        TabCreate tab = new TabCreate();
        ribbonpage rbp = new ribbonpage();
        private void btnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            //giai thich
            //rbp.xtratabcontrol2 la tabcontrol cua form con
            //tab.taotab(tabcontrol cua form giao dien,ten tab, Name, form, ribbon image index)
            
            rbp.xtraTabControl1.Images = imageCollection32x32;
            tab.TaoTab(xtraTabControl1, "Khach Hang", "Khach Hang", rbp, ribbonPage_KhachHang.ImageIndex);
            FrmKhachHang kh = new FrmKhachHang();
            tab.TaoTab(rbp.xtraTabControl1, "Khách Hàng", "Khach Hang", kh, -1);
            
            
            //xfrmrbp1.xtraTabControl1.Images = imageCollection32x32;
            //tab.TaoTab(xtraTabControlKhachHangCover, ribbonPage_KhachHang.Name, ribbonPage_KhachHang.Name, xfrmrbp1, ribbonPage_KhachHang.ImageIndex);
            //FrmKhachHang xfrmbrbt1 = new FrmKhachHang();
            //tab.TaoTab(xfrmrbp1.xtraTabControl1, btn_KhachHang.Name, btn_KhachHang.Name, xfrmbrbt1, 5);
           
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            DevExpress.XtraTab.XtraTabControl xtab = (DevExpress.XtraTab.XtraTabControl)sender;
            if (xtab.Name == "xtraTabPage1") return;
            if (xtab.SelectedTabPageIndex == 0) return;
            int i = xtab.SelectedTabPageIndex;
            xtab.TabPages.RemoveAt(xtab.SelectedTabPageIndex);
            xtab.SelectedTabPageIndex = i - 1;
        }

    

    }
}