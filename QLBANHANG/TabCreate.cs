﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBANHANG
{
    class TabCreate
    {
        //CAC HAM KIEM TRA TON TAI TAB VA TAO TAB
        // <summary>
        /// Tạo thêm tab mới
        /// </summary>
        /// <param name="tabControl">Tên TabControl để add thêm tabpage mới vào</param>
        /// <param name="Text">Tiêu đề tabpage mới</param>
        /// <param name="Name">Tên tabpage mới</param>
        /// <param name="form">Tên form con của tab mới</param>
        /// <param name="imageIndex">index của icon</param>
        public void TaoTab(DevExpress.XtraTab.XtraTabControl tabControl, string Text, string Name, DevExpress.XtraEditors.XtraForm form, int imageIndex)
        {
            int index = KiemTraTonTai(tabControl, Name);
            if (index >= 0)
            {
                tabControl.SelectedTabPage = tabControl.TabPages[index];
                tabControl.SelectedTabPage.Text = Text;
            }
            else
            {
                DevExpress.XtraTab.XtraTabPage tabpage = new DevExpress.XtraTab.XtraTabPage { Text = Text, Name = Name, ImageIndex = imageIndex };
                tabControl.TabPages.Add(tabpage);
                tabControl.SelectedTabPage = tabpage;

                form.TopLevel = false;
                form.Parent = tabpage;
                form.Show();
                form.Dock = DockStyle.Fill;
            }
        }
  
        /// Kiểm tra tabpage có tồn tại hay không.
        /// <param name="tabControlName">Tên tabControl để kiểm tra.</param>
        /// <param name="tabName">Tên tabpage cần kiểm tra.</param>
        /// <returns>Tra ve</returns>
        public static int KiemTraTonTai(DevExpress.XtraTab.XtraTabControl tabControlName, string tabName)
        {
            int Temp = -1;
            for (int i = 0; i < tabControlName.TabPages.Count; i++)
            {
                if (tabControlName.TabPages[i].Name == tabName)
                {
                    Temp = i;
                    break;
                }
            }
            return Temp;
        }
    }
}
