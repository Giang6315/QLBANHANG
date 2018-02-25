using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//khai bao de show file chm
using System.Diagnostics;
//
using DevExpress.XtraBars;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.XtraBars.Helpers;
using QLBANHANG.BussinessLogicLayer;
using QLBANHANG.DataAccessLayer;
using QLBANHANG.PresentationLayer;
namespace QLBANHANG
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
            SkinHelper.InitSkinGallery(rgiGiaoDien);
        }
        public static string TenDangNhap = string.Empty;
        CTabCreate tab = new CTabCreate();
        CDatabase db = new CDatabase();
  
        private void FrmMain_Load(object sender, EventArgs e)
        {
            DisableMenu();
            btnDangNhap.PerformClick();
        }
        private void xtraTabControl_GiaoDien_CloseButtonClick(object sender, EventArgs e)
        {
            DevExpress.XtraTab.XtraTabControl xtab = (DevExpress.XtraTab.XtraTabControl)sender;
            int i = xtab.SelectedTabPageIndex;
            xtab.TabPages.RemoveAt(xtab.SelectedTabPageIndex);
            xtab.SelectedTabPageIndex = i;
        } 
        private void btn_Thoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult traloi;
             traloi = MessageBox.Show("Bạn có chắc không? ", "Trả lời ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
             if (traloi == DialogResult.OK)
                 Application.Exit();
        }
         #region Tao The tab
         public void DongTab()
        {
            xtraTabControl_GiaoDien.TabPages.Clear();
        }
        public void TaoTabThongTinDonDatHang()
        {
            FrmThongTinDonDatHang TTDDH = new FrmThongTinDonDatHang();
            tab.TaoTab(xtraTabControl_GiaoDien, "Thông Tin Đơn Đặt Hàng","TTDDH",TTDDH, -1);
        }
        public void TaoTabTraCuuDonDatHang()
        {
            FrmTraCuuDonDatHang tc = new FrmTraCuuDonDatHang();
            tab.TaoTab(xtraTabControl_GiaoDien, "Tra cứu đơn đặt hàng", "TC", tc, -1);
        }
        public void TaoTabDonDatHang()
        {
            FrmDonDatHangNew dh = new FrmDonDatHangNew();
            tab.TaoTab(xtraTabControl_GiaoDien, "Đơn đặt hàng", "DDH", dh, -1);
        }
        public void TaoTabThongTinDonDatHang1()
        {
            FrmThongTinDonDatHang ddh = new FrmThongTinDonDatHang();
            tab.TaoTab(xtraTabControl_GiaoDien, "Thông Tin Chi Tiết Đơn Đặt Hàng", "TTCTDDH1", ddh, -1);
        }
 
        #endregion
        #region Kich Hoat Menu
        public void EnableMenuUser()
        {
            
            ribbonPageDanhMuc.Visible = true;
            ribbonPageBaoCao.Visible = false;
            ribbonPageThongKe.Visible = false;
            ribbonPageGiaoDien.Visible = false;
            ribbonPageTroGiup.Visible = true;
            ribbonPageNghiepvu.Visible = true;
            //
            btnDangXuat.Enabled = true;
            btnDangNhap.Enabled = false;
            btnThoat.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            btnPhanQuyen.Enabled = false;
            btnSaoLuu.Enabled = false;
            btnPhucHoi.Enabled = false;
           
        }
        public void DisableMenu()
        {
            
            ribbonPageDanhMuc.Visible = false;
            ribbonPageThongKe.Visible = false;
            ribbonPageBaoCao.Visible = false;
            ribbonPageGiaoDien.Visible = false;
            ribbonPageTroGiup.Visible = false;
            ribbonPageNghiepvu.Visible = false;
            //
            btnDoiMatKhau.Enabled = false;
            btnDangXuat.Enabled = false;
            btnDangNhap.Enabled = true;
            btnThoat.Enabled = true;
            btnPhanQuyen.Enabled = false;
            btnSaoLuu.Enabled = false;
            btnPhucHoi.Enabled = false;
        }
        public void EnableMenuAdmin()
        {
           
            ribbonPageDanhMuc.Visible = true;
            ribbonPageBaoCao.Visible = true;
            ribbonPageThongKe.Visible = true;
            ribbonPageGiaoDien.Visible = true;
            ribbonPageTroGiup.Visible = true;
            ribbonPageNghiepvu.Visible = true;
            //
            btnDangXuat.Enabled = true;
            btnDangNhap.Enabled = false;
            btnThoat.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            btnPhanQuyen.Enabled = true;
            btnSaoLuu.Enabled = true;
            btnPhucHoi.Enabled = true;
            
        }
        #endregion
        private void btn_DangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            xtraTabControl_GiaoDien.TabPages.Clear();
            DisableMenu();
        }
        private void btn_PhanQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmQuanLyNguoiDung QLND = new FrmQuanLyNguoiDung();
            tab.TaoTab(xtraTabControl_GiaoDien, "Quản Lý Người Dùng", "qlnd", QLND, -1);
        }
       
        private void btn_DangNhap_ItemClick(object sender, ItemClickEventArgs e)
        { 
            FrmDangNhapHeThong dn = new FrmDangNhapHeThong();
            dn.ShowDialog();
            if (!string.IsNullOrEmpty(TenDangNhap))
            {
                this.BSIDangNhap.Caption = "Chào "+TenDangNhap+"!";
            }

        }

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
           FrmDoiMatKhau rbp = new FrmDoiMatKhau();
           DataTable dt1 = new DataTable();
           dt1 = CPHANQUYEN.LAYDSNGUOIDUNG();
           for (int i = 0; i <= dt1.Rows.Count - 1; i++)
           {
               if (dt1.Rows[i]["TENDANGNHAP"].ToString() == TenDangNhap)
               {
                   if ((bool)dt1.Rows[i]["QUYENTHEM"] == true)
                   {
                       rbp.Enable_Insert();
                   }
                   if ((bool)dt1.Rows[i]["QUYENSUA"] == true)
                   {
                       rbp.Enable_UpDate();
                   }
                   if ((bool)dt1.Rows[i]["QUYENADMIN"] == true)
                   {
                       rbp.Enable_Insert();
                       rbp.Enable_Delete();
                       rbp.Enable_UpDate();
                   }
                   break;
               }
           }
           tab.TaoTab(xtraTabControl_GiaoDien,"Đổi Mật Khẩu","DMK", rbp, -1);
        }

        private void btnTroGiup_ItemClick(object sender, ItemClickEventArgs e)
        {
            string FileName = Application.StartupPath + "\\help.chm";
            System.Diagnostics.Process.Start(FileName);
        }

       
        private void btnNhanVien_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            FrmNhanVien rbp = new FrmNhanVien();
            DataTable dt1 = new DataTable();
            dt1 = CPHANQUYEN.LAYDSNGUOIDUNG();
            for (int i = 0; i <= dt1.Rows.Count - 1; i++)
            {
                if (dt1.Rows[i]["TENDANGNHAP"].ToString() == TenDangNhap)
                {
                    if ((bool)dt1.Rows[i]["QUYENTHEM"] == true)
                    {
                        rbp.Enable_Insert();
                    }
                    if ((bool)dt1.Rows[i]["QUYENXOA"] == true)
                    {
                        rbp.Enable_Delete();
                    }
                    if ((bool)dt1.Rows[i]["QUYENSUA"] == true)
                    {
                        rbp.Enable_UpDate();
                    }
                    if ((bool)dt1.Rows[i]["QUYENADMIN"] == true)
                    {
                        rbp.Enable_Insert();
                        rbp.Enable_Delete();
                        rbp.Enable_UpDate();
                    }
                    break;
                }
            }
            tab.TaoTab(xtraTabControl_GiaoDien, "Nhân Viên", "NV", rbp, -1);
        }

        private void btnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            //ACustomer rbp = new ACustomer();
            FrmKhachhangmoi rbp = new FrmKhachhangmoi();
            DataTable dt1 = new DataTable();
            dt1 = CPHANQUYEN.LAYDSNGUOIDUNG();
            for (int i = 0; i <= dt1.Rows.Count - 1; i++)
            {
                if (dt1.Rows[i]["TENDANGNHAP"].ToString() == TenDangNhap)
                {
                    if ((bool)dt1.Rows[i]["QUYENTHEM"] == true)
                    {
                        rbp.Enable_Insert();
                    }

                    if ((bool)dt1.Rows[i]["QUYENSUA"] == true)
                    {
                        rbp.Enable_UpDate();
                    }
                    if ((bool)dt1.Rows[i]["QUYENADMIN"] == true)
                    {
                        rbp.Enable_Insert();
                        rbp.Enable_UpDate();

                    }
                    break;
                }
            }
                //rbp.ShowDialog();
                tab.TaoTab(xtraTabControl_GiaoDien, "Khách Hàng", "KH", rbp, -1);
               
            }

        private void btnDonDatHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmDonDatHangNew rbp = new FrmDonDatHangNew();
            DataTable dt1 = new DataTable();
            dt1 = CPHANQUYEN.LAYDSNGUOIDUNG();
            for (int i = 0; i <= dt1.Rows.Count - 1; i++)
            {
                if (dt1.Rows[i]["TENDANGNHAP"].ToString() == TenDangNhap)
                {
                    if ((bool)dt1.Rows[i]["QUYENTHEM"] == true)
                    {
                        rbp.Enable_Insert();
                    }
                    if ((bool)dt1.Rows[i]["QUYENSUA"] == true)
                    {
                        rbp.Enable_UpDate();
                    }
                    if ((bool)dt1.Rows[i]["QUYENXOA"] == true)
                    {
                        rbp.Enable_Delete();
                    }
                    if ((bool)dt1.Rows[i]["QUYENADMIN"] == true)
                    {
                        rbp.Enable_Insert();
                        rbp.Enable_UpDate();
                    }
                    break;
                }
            }
            tab.TaoTab(xtraTabControl_GiaoDien, "Đơn Đặt Hàng", "DDH", rbp, -1);
        }

        private void btnDanToc_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmDanToc rbp = new FrmDanToc();
            DataTable dt1 = new DataTable();
            dt1 = CPHANQUYEN.LAYDSNGUOIDUNG();
            for (int i = 0; i <= dt1.Rows.Count - 1; i++)
            {
                if (dt1.Rows[i]["TENDANGNHAP"].ToString() == TenDangNhap)
                {
                    if ((bool)dt1.Rows[i]["QUYENTHEM"] == true)
                    {
                        rbp.Enable_Insert();
                    }
                    if ((bool)dt1.Rows[i]["QUYENXOA"] == true)
                    {
                        rbp.Enable_Delete();
                    }
                    if ((bool)dt1.Rows[i]["QUYENSUA"] == true)
                    {
                        rbp.Enable_UpDate();
                    }
                    if ((bool)dt1.Rows[i]["QUYENADMIN"] == true)
                    {
                        rbp.Enable_Insert();
                        rbp.Enable_Delete();
                        rbp.Enable_UpDate();
                    }
                    break;
                }
            }
            tab.TaoTab(xtraTabControl_GiaoDien, "Dân tộc", "DT", rbp, -1);
        }

        private void btnTonGiao_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmTonGiao rbp = new FrmTonGiao();
            DataTable dt1 = new DataTable();
            dt1 = CPHANQUYEN.LAYDSNGUOIDUNG();
            for (int i = 0; i <= dt1.Rows.Count - 1; i++)
            {
                if (dt1.Rows[i]["TENDANGNHAP"].ToString() == TenDangNhap)
                {
                    if ((bool)dt1.Rows[i]["QUYENTHEM"] == true)
                    {
                        rbp.Enable_Insert();
                    }
                    if ((bool)dt1.Rows[i]["QUYENXOA"] == true)
                    {
                        rbp.Enable_Delete();
                    }
                    if ((bool)dt1.Rows[i]["QUYENSUA"] == true)
                    {
                        rbp.Enable_UpDate();
                    }
                    if ((bool)dt1.Rows[i]["QUYENADMIN"] == true)
                    {
                        rbp.Enable_Insert();
                        rbp.Enable_Delete();
                        rbp.Enable_UpDate();
                    }
                    break;
                }

            }
            tab.TaoTab(xtraTabControl_GiaoDien, "Tôn giáo", "TG", rbp, -1);
        }

        private void btnLoaiKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmLoaiKhachHang rbp = new FrmLoaiKhachHang();
            DataTable dt1 = new DataTable();
            dt1 = CPHANQUYEN.LAYDSNGUOIDUNG();
            for (int i = 0; i <= dt1.Rows.Count - 1; i++)
            {
                if (dt1.Rows[i]["TENDANGNHAP"].ToString() == TenDangNhap)
                {
                    if ((bool)dt1.Rows[i]["QUYENTHEM"] == true)
                    {
                        rbp.Enable_Insert();
                    }
                    if ((bool)dt1.Rows[i]["QUYENXOA"] == true)
                    {
                        rbp.Enable_Delete();
                    }
                    if ((bool)dt1.Rows[i]["QUYENSUA"] == true)
                    {
                        rbp.Enable_UpDate();
                    }
                    if ((bool)dt1.Rows[i]["QUYENADMIN"] == true)
                    {
                        rbp.Enable_Insert();
                        rbp.Enable_Delete();
                        rbp.Enable_UpDate();
                    }
                    break;
                }

            }
            tab.TaoTab(xtraTabControl_GiaoDien, "Loại khách hàng", "LKH", rbp, -1);
        }

        private void btnQuanHuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmQuanHuyen QH = new FrmQuanHuyen();
            DataTable dt1 = new DataTable();
            dt1 = CPHANQUYEN.LAYDSNGUOIDUNG();
            for (int i = 0; i <= dt1.Rows.Count - 1; i++)
            {
                if (dt1.Rows[i]["TENDANGNHAP"].ToString() == TenDangNhap)
                {
                    if ((bool)dt1.Rows[i]["QUYENTHEM"] == true)
                    {
                        QH.Enable_Insert();
                    }
                    if ((bool)dt1.Rows[i]["QUYENXOA"] == true)
                    {
                        QH.Enable_Delete();
                    }
                    if ((bool)dt1.Rows[i]["QUYENSUA"] == true)
                    {
                        QH.Enable_UpDate();
                    }
                    if ((bool)dt1.Rows[i]["QUYENADMIN"] == true)
                    {
                        QH.Enable_Insert();
                        QH.Enable_Delete();
                        QH.Enable_UpDate();
                    }
                    break;
                }

            }
            tab.TaoTab(xtraTabControl_GiaoDien, "Quận huyện", "QH", QH, -1);
        }

        private void btnTinhThanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmTinhThanh rbp = new FrmTinhThanh();
            DataTable dt1 = new DataTable();
            dt1 = CPHANQUYEN.LAYDSNGUOIDUNG();
            for (int i = 0; i <= dt1.Rows.Count - 1; i++)
            {
                if (dt1.Rows[i]["TENDANGNHAP"].ToString() == TenDangNhap)
                {
                    if ((bool)dt1.Rows[i]["QUYENTHEM"] == true)
                    {
                        rbp.Enable_Insert();
                    }
                    if ((bool)dt1.Rows[i]["QUYENXOA"] == true)
                    {
                        rbp.Enable_Delete();
                    }
                    if ((bool)dt1.Rows[i]["QUYENSUA"] == true)
                    {
                        rbp.Enable_UpDate();
                    }
                    if ((bool)dt1.Rows[i]["QUYENADMIN"] == true)
                    {
                        rbp.Enable_Insert();
                        rbp.Enable_Delete();
                        rbp.Enable_UpDate();
                    }
                    break;
                }

            }
            tab.TaoTab(xtraTabControl_GiaoDien, "Tỉnh thành", "TINH", rbp, -1);
        }

        private void btnNgheNghiep_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmNgheNghiep rbp = new FrmNgheNghiep();
            DataTable dt1 = new DataTable();
            dt1 = CPHANQUYEN.LAYDSNGUOIDUNG();
            for (int i = 0; i <= dt1.Rows.Count - 1; i++)
            {
                if (dt1.Rows[i]["TENDANGNHAP"].ToString() == TenDangNhap)
                {
                    if ((bool)dt1.Rows[i]["QUYENTHEM"] == true)
                    {
                        rbp.Enable_Insert();
                    }
                    if ((bool)dt1.Rows[i]["QUYENXOA"] == true)
                    {
                        rbp.Enable_Delete();
                    }
                    if ((bool)dt1.Rows[i]["QUYENSUA"] == true)
                    {
                        rbp.Enable_UpDate();
                    }
                    if ((bool)dt1.Rows[i]["QUYENADMIN"] == true)
                    {
                        rbp.Enable_Insert();
                        rbp.Enable_Delete();
                        rbp.Enable_UpDate();
                    }
                    break;
                }

            }
            tab.TaoTab(xtraTabControl_GiaoDien, "Nghề nghiệp", "NNs", rbp, -1);
        }

        private void btnLoaiSanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmLoaiSanPham rbp = new FrmLoaiSanPham();
            DataTable dt1 = new DataTable();
            dt1 = CPHANQUYEN.LAYDSNGUOIDUNG();
            for (int i = 0; i <= dt1.Rows.Count - 1; i++)
            {
                if (dt1.Rows[i]["TENDANGNHAP"].ToString() == TenDangNhap)
                {
                    if ((bool)dt1.Rows[i]["QUYENTHEM"] == true)
                    {
                        rbp.Enable_Insert();
                    }
                    if ((bool)dt1.Rows[i]["QUYENXOA"] == true)
                    {
                        rbp.Enable_Delete();
                    }
                    if ((bool)dt1.Rows[i]["QUYENSUA"] == true)
                    {
                        rbp.Enable_UpDate();
                    }
                    if ((bool)dt1.Rows[i]["QUYENADMIN"] == true)
                    {
                        rbp.Enable_Insert();
                        rbp.Enable_Delete();
                        rbp.Enable_UpDate();
                    }
                    break;
                }

            }
            tab.TaoTab(xtraTabControl_GiaoDien, "Lọai sản phẩm", "LSP", rbp, -1);
        }

        private void btnDonViTinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            //FrmDonViTinh rbp = new FrmDonViTinh();
            xfrmQuiCach rbp = new xfrmQuiCach();
            DataTable dt1 = new DataTable();
            dt1 = CPHANQUYEN.LAYDSNGUOIDUNG();
            for (int i = 0; i <= dt1.Rows.Count - 1; i++)
            {
                if (dt1.Rows[i]["TENDANGNHAP"].ToString() == TenDangNhap)
                {
                    if ((bool)dt1.Rows[i]["QUYENTHEM"] == true)
                    {
                        rbp.Enable_Insert();
                    }
                    if ((bool)dt1.Rows[i]["QUYENXOA"] == true)
                    {
                        rbp.Enable_Delete();
                    }
                    if ((bool)dt1.Rows[i]["QUYENSUA"] == true)
                    {
                        rbp.Enable_UpDate();
                    }
                    if ((bool)dt1.Rows[i]["QUYENADMIN"] == true)
                    {
                        rbp.Enable_Insert();
                        rbp.Enable_Delete();
                        rbp.Enable_UpDate();
                    }
                    break;
                }

            }
            //tab.TaoTab(xtraTabControl_GiaoDien, "Đơn vị tính", "DVT", rbp, -1);
            rbp.ShowDialog();
        }

 
        private void btSanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmSanPham rbp = new FrmSanPham();
            DataTable dt1 = new DataTable();
            dt1 = CPHANQUYEN.LAYDSNGUOIDUNG();
            for (int i = 0; i <= dt1.Rows.Count - 1; i++)
            {
                if (dt1.Rows[i]["TENDANGNHAP"].ToString() == TenDangNhap)
                {
                    if ((bool)dt1.Rows[i]["QUYENTHEM"] == true)
                    {
                        rbp.Enable_Insert();
                    }
                    if ((bool)dt1.Rows[i]["QUYENXOA"] == true)
                    {
                        rbp.Enable_Delete();
                    }
                    if ((bool)dt1.Rows[i]["QUYENSUA"] == true)
                    {
                        rbp.Enable_UpDate();
                    }
                    if ((bool)dt1.Rows[i]["QUYENADMIN"] == true)
                    {
                        rbp.Enable_Insert();
                        rbp.Enable_Delete();
                        rbp.Enable_UpDate();
                    }
                    break;
                }

            }
            tab.TaoTab(xtraTabControl_GiaoDien, "Sản phẩm", "SP", rbp, -1);
        }

     
        private void btnCauHoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmCauHoi rbp = new FrmCauHoi();
            DataTable dt1 = new DataTable();
            dt1 = CPHANQUYEN.LAYDSNGUOIDUNG();
            for (int i = 0; i <= dt1.Rows.Count - 1; i++)
            {
                if (dt1.Rows[i]["TENDANGNHAP"].ToString() == TenDangNhap)
                {
                    if ((bool)dt1.Rows[i]["QUYENTHEM"] == true)
                    {
                        rbp.Enable_Insert();
                    }
                    if ((bool)dt1.Rows[i]["QUYENXOA"] == true)
                    {
                        rbp.Enable_Delete();
                    }
                    if ((bool)dt1.Rows[i]["QUYENSUA"] == true)
                    {
                        rbp.Enable_UpDate();
                    }
                    if ((bool)dt1.Rows[i]["QUYENADMIN"] == true)
                    {
                        rbp.Enable_Insert();
                        rbp.Enable_Delete();
                        rbp.Enable_UpDate();
                    }
                    break;
                }

            }
            tab.TaoTab(xtraTabControl_GiaoDien, "Câu hỏi - Câu chọn", "CHCH", rbp, -1);
        }


        #region Sao Lưu-Phục Hồi
        private void btnSaoLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmSaoLuuCSDL sl = new FrmSaoLuuCSDL();
            //tab.TaoTab(xtraTabControl_GiaoDien, "Sao Lưu Cơ Sở Dữ Liệu", "SL", sl, -1);
            sl.ShowDialog();
        }

        private void btnPhucHoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmPhucHoiCSDL PH = new FrmPhucHoiCSDL();
            //tab.TaoTab(xtraTabControl_GiaoDien, "Phục Hồi Cơ Sở Dữ Liệu", "PHCSDL", PH ,-1);
            PH.ShowDialog();
        }
        #endregion
        private void btnThietlap_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmThietLapLoaiKH rbp = new FrmThietLapLoaiKH();
            DataTable dt1 = new DataTable();
            dt1 = CPHANQUYEN.LAYDSNGUOIDUNG();
            for (int i = 0; i <= dt1.Rows.Count - 1; i++)
            {
                if (dt1.Rows[i]["TENDANGNHAP"].ToString() == TenDangNhap)
                {
                    if ((bool)dt1.Rows[i]["QUYENTHEM"] == true)
                    {
                        rbp.Enable_Insert();
                    }
                    if ((bool)dt1.Rows[i]["QUYENADMIN"] == true)
                    {
                        rbp.Enable_Insert();
                    }
                    break;
                }

            }
            tab.TaoTab(xtraTabControl_GiaoDien, "Thiết lập loại khách hàng", "LTL", rbp, -1);
        }
        
        private void btChucVu_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmChucVu CV = new FrmChucVu();
            DataTable dt1 = new DataTable();
            dt1 = CPHANQUYEN.LAYDSNGUOIDUNG();
            for (int i = 0; i <= dt1.Rows.Count - 1; i++)
            {
                if (dt1.Rows[i]["TENDANGNHAP"].ToString() == TenDangNhap)
                {
                    if ((bool)dt1.Rows[i]["QUYENTHEM"] == true)
                    {
                        CV.Enable_Insert();
                    }
                    if ((bool)dt1.Rows[i]["QUYENXOA"] == true)
                    {
                       CV.Enable_Delete();
                    }
                    if ((bool)dt1.Rows[i]["QUYENSUA"] == true)
                    {
                        CV.Enable_UpDate();
                    }
                    if ((bool)dt1.Rows[i]["QUYENADMIN"] == true)
                    {
                        CV.Enable_Insert();
                        CV.Enable_Delete();
                        CV.Enable_UpDate();
                    }
                    break;
                }
            }
            tab.TaoTab(xtraTabControl_GiaoDien, "Chức vụ", "Chuc Vu", CV, -1);
        }
        #region Báo Cáo Thống Kê
        private void btnBaoCaoTongDoanhThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmBaoCaoTongDoanhThu B = new FrmBaoCaoTongDoanhThu();
            tab.TaoTab(xtraTabControl_GiaoDien, "Báo cáo tổng doanh thu", "BCTDT", B, -1);
        }    
        private void btnBaoCaoNam_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmBaoCaoDoanhThuNam BCDTNAM = new FrmBaoCaoDoanhThuNam();
            tab.TaoTab(xtraTabControl_GiaoDien, "Báo cáo doanh thu theo năm", "BCDTNAM", BCDTNAM, -1);
        }

        private void btnBaoCaoThang_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmBaoCaoDoanhThuThang BCDTT = new FrmBaoCaoDoanhThuThang();
            tab.TaoTab(xtraTabControl_GiaoDien, "Báo cáo doanh thu theo tháng", "BCDTT", BCDTT, -1);
        }

        private void btnBaoCaoNgay_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmBaoCaoDoanhThuNgay BCNGAY = new FrmBaoCaoDoanhThuNgay();
            tab.TaoTab(xtraTabControl_GiaoDien, "Báo cáo doanh thu theo thời gian", "BCDTNGAY", BCNGAY, -1);
        }

        private void btnDoanhThuTheoThoiGian_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmThongKeDoanhThu TK = new FrmThongKeDoanhThu();
            tab.TaoTab(xtraTabControl_GiaoDien, "Thống Kê Doanh Thu Theo Thời Gian", "TKDT", TK, -1);
        }
        private void btnPhanTramKHTheoLoai_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmPhanTramKhachHangTheoLoai PTKH = new FrmPhanTramKhachHangTheoLoai();
            tab.TaoTab(xtraTabControl_GiaoDien, "Phần Trăm Khách Hàng Theo Loại", "PTTL", PTKH, -1);
        }
       

        private void btnSSDT_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmBieuDoSoSanhDoanhThuGiuaCacTinh rbp = new FrmBieuDoSoSanhDoanhThuGiuaCacTinh();
            tab.TaoTab(xtraTabControl_GiaoDien, "Biểu đồ so sanh danh thu giua các tỉnh", "SS", rbp, -1);
        }

       
        private void btnXuatDonDatHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmXuatDonDatHang rbp = new FrmXuatDonDatHang();
            tab.TaoTab(xtraTabControl_GiaoDien, "Xuất Đơn Đặt Hàng", "Xuat Don Dat Hang", rbp, -1);
        }

        private void btKHDatNhieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmKhachHangDatHangNhieuNhat khn = new FrmKhachHangDatHangNhieuNhat();
            tab.TaoTab(xtraTabControl_GiaoDien, "Khách hàng đặt hàng nhiều nhất", "KHDHN", khn, -1);
        }

        private void btSPDatNhieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmSPDatHangNhieu rbp = new FrmSPDatHangNhieu();
            tab.TaoTab(xtraTabControl_GiaoDien, "Sản phẩm đặt hàng nhiều nhất", "SPDHNN", rbp, -1);
        }

        private void btDSSP_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmXuatSanPham xsp = new FrmXuatSanPham();
            tab.TaoTab(xtraTabControl_GiaoDien, "Xuất danh sách sản phẩm theo loại", "xsp", xsp, -1);
        }

        private void btDSKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmXuatKhachHang xkh = new FrmXuatKhachHang();
            tab.TaoTab(xtraTabControl_GiaoDien, "Xuất danh sách khách hàng theo loại", "XKH", xkh, -1);
        }

        #endregion

        private void xtraTabControl_GiaoDien_CloseButtonClick_1(object sender, EventArgs e)
        {
            DevExpress.XtraTab.XtraTabControl xtab = (DevExpress.XtraTab.XtraTabControl)sender;
            int i = xtab.SelectedTabPageIndex;
            xtab.TabPages.RemoveAt(xtab.SelectedTabPageIndex);
            xtab.SelectedTabPageIndex = i;
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            //FrmKhachhangmoi KH = new FrmKhachhangmoi(); KH.ShowDialog();
        }

    }
}