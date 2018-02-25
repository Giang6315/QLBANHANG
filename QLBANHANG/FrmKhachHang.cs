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
    public partial class FrmKhachHang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {

            DevExpress.XtraTab.XtraTabControl xtab = (DevExpress.XtraTab.XtraTabControl)sender;
            if (xtab.TabPages.Count == 1) return;
            int i = xtab.SelectedTabPageIndex;
            xtab.TabPages.RemoveAt(xtab.SelectedTabPageIndex);
            xtab.SelectedTabPageIndex = i - 1;
        }
    }
}