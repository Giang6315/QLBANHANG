using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QLBANHANG.PresentationLayer;
namespace QLBANHANG
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
             //xu li an form dang nhap
                using (var FrmDangNhapSQL = new FrmDangNhapSQL())
                    if (FrmDangNhapSQL.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                        return;
            
        }
    }
}
