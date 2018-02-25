using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using QLBANHANG.BussinessLogicLayer;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmTraCuuDonDatHang : DevExpress.XtraEditors.XtraForm
    {
        public FrmTraCuuDonDatHang()
        {
            InitializeComponent();
        }
        CTraCuuDDH tc = new CTraCuuDDH();
        CDonDatHangNew DDH = new CDonDatHangNew();
        public void Soanlai()
        {
            txtMAKH.Text = "";
            txtMAKH.Text = "";
            dtTuNgay.Text = Convert.ToDateTime(dtTuNgay.Text).ToShortDateString();
            dtDenNgay.Text = Convert.ToDateTime(dtDenNgay.Text).ToShortDateString();
            if (dgvThongTinSP.Rows.Count >1)
            {
                for (int i = dgvThongTinSP.Rows.Count - 2; i >= 0; i--)
                {
                    dgvThongTinSP.Rows.RemoveAt(i);
                }
            }
            txtTongtien.Text = "";
        }
        public void DuDoanTimTheoMADDH()
        {
            txtMaDDH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtMaDDH.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtMaDDH.AutoCompleteSource = AutoCompleteSource.CustomSource;
            DataTable dt = tc.LayMaDDH();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txtMaDDH.AutoCompleteCustomSource.Insert(i, dt.Rows[i]["MADDH"].ToString());
            }
        }
        public void DuDoanTimTheoMAKH()
        {
            txtMAKH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtMAKH.AutoCompleteSource = AutoCompleteSource.CustomSource;
            DataTable dt = tc.LayMaKH();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txtMAKH.AutoCompleteCustomSource.Insert(i, dt.Rows[i]["MAKH"].ToString());
            }
        }
        private void btTim1_Click(object sender, EventArgs e)
        {
            if (txtMaDDH.Text == "")
                MessageBox.Show("Bạn chưa nhập mã đơn đặt hàng");
            else
            {
                DataTable dt = tc.TraCuuTheoMaDDH(txtMaDDH.Text);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có đơn đặt hàng bạn cần tìm");
                    Soanlai();
                }
                else
                {
                    dgvThongTinDDH.DataSource = tc.TraCuuTheoMaDDH(txtMaDDH.Text);
                    Soanlai();
                }
            }
        }

        private void btTim2_Click(object sender, EventArgs e)
        {
            if (txtMAKH.Text == "")
                MessageBox.Show("Bạn chưa nhập mã khách hàng");
            else
            {
                DataTable dt = tc.TraCuuTheoMaKH(txtMAKH.Text);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có đơn đặt hàng bạn cần tìm");
                    Soanlai();
                }
                else
                {
                    dgvThongTinDDH.DataSource = tc.TraCuuTheoMaKH(txtMAKH.Text);
                    Soanlai();
                }
            }
        }

        private void btTim3_Click(object sender, EventArgs e)
        {
            if (dtDenNgay.Text == "" || dtTuNgay.Text=="")
                MessageBox.Show("Bạn chưa nhập thời gian cần tìm");
            else
            {
                DataTable dt = tc.TraCuuTheoThoiGian(dtTuNgay.Text, dtDenNgay.Text);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có đơn đặt hàng bạn cần tìm");
                    Soanlai();
                }
                else
                {
                    dgvThongTinDDH.DataSource = tc.TraCuuTheoThoiGian(dtTuNgay.Text, dtDenNgay.Text);
                    Soanlai();
                }
            }
        }


        private void FrmTraCuuDonDatHang_Load(object sender, EventArgs e)
        {
            dtTuNgay.Text = Convert.ToDateTime(DateTime.Now.Date).ToShortDateString();
            dtDenNgay.Text = Convert.ToDateTime(DateTime.Now.Date).ToShortDateString();
            DuDoanTimTheoMADDH();
            DuDoanTimTheoMAKH();
        }

        private void dgvThongTinDDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            float tongtien = 0, tongtiendh = 0;
            dgvThongTinSP.DataSource = tc.HienThiSPTheoMaDDH(dgvThongTinDDH.CurrentRow.Cells["MADDH"].Value.ToString());
            for (int i = 0; i < dgvThongTinSP.Rows.Count - 1; i++)
            {
                tongtien = float.Parse(dgvThongTinSP.Rows[i].Cells["SOLUONGDAT"].Value.ToString()) * float.Parse(dgvThongTinSP.Rows[i].Cells["DONGIATHAMKHAO"].Value.ToString());
                tongtiendh += tongtien;
            }
            txtTongtien.Text = tongtiendh.ToString();
        }

        private void dgvThongTinDDH_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dgvThongTinSP != null)
            {
                for (int i = dgvThongTinSP.Rows.Count - 2; i >= 0; i--)
                {
                    dgvThongTinSP.Rows.RemoveAt(i);
                }
            }
        }

        private void txtMaDDH_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void grpMaDDH_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}