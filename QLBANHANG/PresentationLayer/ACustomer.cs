using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLBANHANG.BussinessLogicLayer;
using QLBANHANG.DataAccessLayer;
namespace QLBANHANG.PresentationLayer
{
    public partial class ACustomer : Form
    {
        DataTable dt;
        CACustomer kh2;
        CDatabase db;
        public ACustomer()
        {
            InitializeComponent();
            dt = new DataTable();
            kh2 = new CACustomer();
            db = new CDatabase();
        }
        #region Phân quyền
        public void Enable_Insert()
        {
            btnThem.Enabled = true;
          
        }
        public void Enable_UpDate()
        {
            btnSua.Enabled = true;
        }
        public void Enable_Delete()
        {
            btnXoa.Enabled = true;
        }
        #endregion

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }
 
        private void cb_Tinhthanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cb_TinhThanh.Items.Clear();
            //if (cb_TinhThanh.Text == "--Vui lòng chọn--")
            //    cb_TinhThanh.Text = "";
            //else
            //    HienThiTinh();
            ////HienThiTinh();
          
        }

        private void cb_QuanHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cb_QuanHuyen.Items.Clear();
            //if (cb_QuanHuyen.Text == "--Vui lòng chọn--")
            //    cb_QuanHuyen.Text = "";
            //else
            //    HienThiHuyen();
            ////HienThiHuyen();
        }

        private void ACustomer_Load(object sender, EventArgs e)
        {
      
        }
    }
}
