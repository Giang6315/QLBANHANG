using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLBANHANG.BussinessLogicLayer;

namespace QLBANHANG.PresentationLayer
{
    public partial class FrmThietLapLoaiKH : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmThietLapLoaiKH()
        {
            InitializeComponent();
        }
        CThietlaploaikh tl = new CThietlaploaikh();
        private void btThietlap_Click(object sender, EventArgs e)
        {
            if (txtChinhthuc.Text != "" && txtNguongcanhan.Text != "" && txtNguongdoanhnghiep.Text != "" && txtThanthiet.Text != "")
            {
                try
                {
                    tl.ThietLapLoaiKH(int.Parse(txtThanthiet.Text), int.Parse(txtChinhthuc.Text), float.Parse(txtNguongcanhan.Text), float.Parse(txtNguongdoanhnghiep.Text));
                    MessageBox.Show("Cập nhật thiết lập loại khách hàng thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNguongdoanhnghiep.Text = "";
                    txtNguongcanhan.Text = "";
                    txtChinhthuc.Text = "";
                    txtThanthiet.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật thiết lập loại khách hàng không thành công \n" + "\n Lỗi" + ex.Message, "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Dữ liệu cập nhật không đầy đủ");
        }


        #region Phan Quyen
        public void Enable_Insert()
        {
            btThietlap.Enabled = true;
        }
        #endregion

    }
}
