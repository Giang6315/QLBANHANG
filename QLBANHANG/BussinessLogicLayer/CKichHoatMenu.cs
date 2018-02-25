using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace QLBANHANG.BussinessLogicLayer
{
    class CKichHoatMenu
    {
        public void KichHoatFormUser()
        {
            foreach (Form fm in Application.OpenForms)
            {
                if (fm is FrmMain)
                {
                    ((FrmMain)fm).EnableMenuUser();
                    break;
                }
            }
        }
        public void KichHoatFormAdmin()
        {
            foreach (Form fm in Application.OpenForms)
            {
                if (fm is FrmMain)
                {
                    ((FrmMain)fm).EnableMenuAdmin();
                    break;
                }
            }
        }
    }
}
