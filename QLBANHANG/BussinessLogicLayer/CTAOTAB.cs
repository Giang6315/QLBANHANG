using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLBANHANG.PresentationLayer;
namespace QLBANHANG.BussinessLogicLayer
{
    class CTAOTAB
    {
        public void TaoTabDonDatHang()
        {
            foreach (Form fm in Application.OpenForms)
            {
                if (fm is FrmMain)
                {
                    ((FrmMain)fm).TaoTabDonDatHang();
                    break;
                }
            }
        }

        public void TaoTabTraCuuDonDatHang()
        {
            foreach (Form fm in Application.OpenForms)
            {
                if (fm is FrmMain)
                {
                    ((FrmMain)fm).TaoTabTraCuuDonDatHang();
                    break;
                }
            }
        }

        public void TaoTabThongTinChiTietDonDatHang1()
        {
            foreach (Form fm in Application.OpenForms)
            {
                if(fm is FrmMain)
                {
                    ((FrmMain)fm).TaoTabThongTinDonDatHang1();
                    break;
                }
            }
        }
        //khach hang moi
        //public void TaoTabKhachHangMoi()
        //{
        //    foreach (Form fm in Application.OpenForms)
        //    {
        //        if (fm is FrmMain)
        //        {
        //            ((FrmMain)fm).TaoTabKH();
        //            break;
        //        }
        //    }
        //}
    }
}
