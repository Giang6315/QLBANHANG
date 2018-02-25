using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLBANHANG.DataAccessLayer;
using QLBANHANG.BussinessLogicLayer;

namespace QLBANHANG.PresentationLayer
{
    public partial class FrmDonDatHangNew : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmDonDatHangNew()
        {
            InitializeComponent();
        }
        CDonDatHangNew dh = new CDonDatHangNew();
        CDatabase db = new CDatabase();
        CTAOTAB tab = new CTAOTAB();
        #region Các hàm hiển thị
        public void HienThiKH()
        {
            cbHoTenKH.Items.Add("--Vui lòng chọn--");
            cbHoTenKH.SelectedIndex= 0;
            for (int i = 0; i < dh.LayDSKH().Rows.Count; i++)
            {
                cbHoTenKH.Items.Add(dh.LayDSKH().Rows[i]["HOTENKH"].ToString());
            }
        }

        public void HienThiLoaiSP()
        {
            cbLoaiSP.Items.Add("--Vui lòng chọn--");
            cbLoaiSP.SelectedIndex = 0;
            for (int i = 0; i < dh.HienThiLoaiSP().Rows.Count; i++)
            {
                cbLoaiSP.Items.Add(dh.HienThiLoaiSP().Rows[i]["TENLOAI"].ToString());
            }
        }

        public void LayMaDDH()
        {
            DataTable dt1 = db.ExecuteBang("EXEC LAYMADDH");
            txtMaDDH.Text = dt1.Rows[0][0].ToString();
        }
        #endregion

        #region Load
        private void FrmDonDatHangNew_Load(object sender, EventArgs e)
        {
            HienThiKH();
            HienThiLoaiSP();
            LayMaDDH();
            Qua1();
            HienThiTTDH();
            txtNgaydat.Text = Convert.ToDateTime(DateTime.Now.Date).ToShortDateString();
            if (dgvSPDH.DataSource != null)
            {
                for (int i = dgvSPDH.Rows.Count - 2; i>=0 ; i--)
                    dgvSPDH.Rows.RemoveAt(i);
            }
        }
        #endregion

        #region Soạn lại
        public void Soanlai()
        {
            txtDiaChi.Text = "";
            LayMaDDH();
            txtTongTien.Text = "";
            txtNgaydat.Text = Convert.ToDateTime(DateTime.Now.Date).ToShortDateString();
            txtQuanHuyen.Text = "";
            txtTinhThanh.Text = "";
            cbHoTenKH.Text = "--Vui lòng chọn--";
            cbLoaiSP.Text = "--Vui lòng chọn--";
            if (this.dgvSP.DataSource != null)
            {
                for (int i = dgvSP.Rows.Count - 2; i >= 0; i--)
                {
                    dgvSP.Rows.RemoveAt(i);
                }
            }
            if (this.dgvSPDH.DataSource != null)
            {
                for (int i = dgvSPDH.Rows.Count - 2; i >= 0; i--)
                {
                    dgvSPDH.Rows.RemoveAt(i);
                }
            }
            Qua1();
        }

        private void btSoanlai_Click(object sender, EventArgs e)
        {
            Soanlai();
        }
        #endregion

        #region Danh sách các sự kiện
        private void cbHoTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDiaChi.Text = dh.LayDiaChiKH(dh.LayMaKHTuTenKH(cbHoTenKH.Text));
            txtQuanHuyen.Text = dh.LayTenHuyen(dh.LayMaHuyen(dh.LayMaKHTuTenKH(cbHoTenKH.Text)));
            txtTinhThanh.Text = dh.LayTenTinh(dh.LayMaKHTuTenKH(cbHoTenKH.Text));
        }

        private void cbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvSP.DataSource = dh.HienThiSanPhamTuLoai(dh.LayMaLoaiTuTenLoai(cbLoaiSP.Text));
        }

        private void dgvSPDH_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            float tongtien = 0, tongtiendh = 0;
            if (txtTongTien.Text == "")
                tongtiendh = 0;
            else
                tongtiendh = float.Parse(txtTongTien.Text);
            try
            {
                tongtien = float.Parse(dgvSPDH.CurrentRow.Cells["SOLUONGDAT1"].Value.ToString()) * float.Parse(dgvSPDH.CurrentRow.Cells["DONGIA1"].Value.ToString());
                tongtiendh += tongtien;
                txtTongTien.Text = tongtiendh.ToString();
            }
            catch
            {
                
            }
        }
        #endregion

        #region Các nút di chuyển
        public void Qua1()
        {
                dt = new DataTable();
                dt.Columns.Add("MASP1");
                dt.Columns.Add("TENSP1");
                dt.Columns.Add("SOLUONGDAT1");
                dt.Columns.Add("DONGIA1");
        }

        public void Qua2()
        {
            dt2 = new DataTable();
            dt2.Columns.Add("MASP");
            dt2.Columns.Add("TENSP");
            dt2.Columns.Add("DONGIATHAMKHAO");
        }

        DataTable dt = new DataTable();
        private void btQua_Click(object sender, EventArgs e)
        {
            bool kq = false;
            int temp = dgvSPDH.Rows.Count - 1;
            DataRow dr = dt.NewRow();
            if (dgvSP.Rows.Count != 0)
            {
                if (dgvSPDH.Rows.Count - 1 != 0)
                {
                    for (int i = 0; i < dgvSPDH.Rows.Count - 1; i++)
                    {
                        if (dgvSP.CurrentRow.Cells["MaSP"].Value.ToString() == dgvSPDH.Rows[i].Cells["MASP1"].Value.ToString())
                        {
                            MessageBox.Show("Sản phẩm này đã có");
                            return;
                        }
                        else
                            kq = false;
                    }
                    if (kq == false)
                    {
                        //MessageBox.Show(dt.Columns[0].ColumnName + dt.Columns[1].ColumnName + dt.Columns[3].ColumnName);
                        dr[0] = dgvSP.CurrentRow.Cells["MaSP"].Value.ToString();
                        dr[1] = dgvSP.CurrentRow.Cells["TENSP"].Value.ToString();
                        dr[3] = string.Format("{0:0,0}", dgvSP.CurrentRow.Cells["Dongia"].Value);
                        dt.Rows.InsertAt(dr, temp);
                    }
                }
                else
                {
                    //MessageBox.Show(dt.Columns[0].ColumnName + dt.Columns[1].ColumnName + dt.Columns[2].ColumnName + dt.Columns[3].ColumnName);
                    dr[0] = dgvSP.CurrentRow.Cells["MaSP"].Value.ToString();
                    dr[1] = dgvSP.CurrentRow.Cells["TENSP"].Value.ToString();
                    dr[3] = string.Format("{0:0,0}", dgvSP.CurrentRow.Cells["Dongia"].Value);
                    dt.Rows.InsertAt(dr, temp);
                }
                dgvSPDH.DataSource = dt;
            }
            else
                MessageBox.Show("Không có thuộc tính để chuyển");
            
        }
        DataTable dt2 = new DataTable();
        private void btLui_Click(object sender, EventArgs e)
        {
            int temp = dgvSPDH.Rows.Count - 1;
            DataRow dr = dt2.NewRow();
            if (dgvSPDH.Rows.Count - 1 != 0)
                dgvSPDH.Rows.RemoveAt(dgvSPDH.CurrentRow.Index);
            else
                MessageBox.Show("Không có thuộc tính để chuyển");
        }

        private void btQuanhieu_Click(object sender, EventArgs e)
        {
            bool kq = false;
            int temp = dgvSPDH.Rows.Count - 1;
            if (dgvSP.Rows.Count != 0)
            {
                if (dgvSPDH.Rows.Count - 1 != 0)
                {
                    for (int i = 0; i < dgvSP.Rows.Count - 1; i++)
                    {
                        for (int j = 0; j < dgvSPDH.Rows.Count - 1; j++)
                        {
                            if (dgvSP.Rows[i].Cells["MaSP"].Value.ToString() == dgvSPDH.Rows[j].Cells["MASP1"].Value.ToString())
                            {
                                MessageBox.Show("Sản phẩm này đã có");
                                return;
                            }
                            else
                                kq = false;
                        }
                        if (kq == false)
                        {
                            DataRow dr = dt.NewRow();

                            dr[0] = dgvSP.Rows[i].Cells["MaSP"].Value.ToString();
                            dr[1] = dgvSP.Rows[i].Cells["TenSP"].Value.ToString();
                            dr[3] = string.Format("{0:0,0}", dgvSP.Rows[i].Cells["DONGIA"].Value);
                            dt.Rows.Add(dr);
                            temp++;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < dgvSP.Rows.Count - 1; j++)
                    {
                        DataRow dr = dt.NewRow();
                        dr[0] = dgvSP.Rows[j].Cells["MaSP"].Value.ToString();
                        dr[1] = dgvSP.Rows[j].Cells["TenSP"].Value.ToString();
                        dr[3] = string.Format("{0:0,0}", dgvSP.Rows[j].Cells["DONGIA"].Value);
                        dt.Rows.Add(dr);
                        temp++;
                    }
                }
                dgvSPDH.DataSource = dt;
            }
            else
                MessageBox.Show("Không có thuộc tính nào để chuyển");
        }

        private void btLuinhieu_Click(object sender, EventArgs e)
        {
            int temp = dgvSPDH.Rows.Count;
            if (dgvSPDH.Rows.Count != 0)
            {
                for (int j = 0; j < temp-1; j++)
                {
                    dgvSPDH.Rows.Remove(dgvSPDH.Rows[j]);
                    temp--;
                    j--;
                }
            }
            else
                MessageBox.Show("Không có thuộc tính nào để chuyển");
        }
        #endregion

        #region Thêm đơn đặt hàng
        private void btThem_Click(object sender, EventArgs e)
        {
            if (dgvSPDH.Rows.Count - 1 != 0)
            {
                try
                {
                    for (int i = 0; i < dgvSPDH.Rows.Count - 1; i++)
                    {
                        if (dgvSPDH.Rows[i].Cells["SOLUONGDAT1"].Value.ToString() == "")
                        {
                            MessageBox.Show("Bạn chưa nhập số lượng đặt hàng");
                            return;
                        }
                        else
                            dh.ThemDonDatHang(txtMaDDH.Text, dh.LayMaKHTuTenKH(cbHoTenKH.Text), txtNgaydat.Text, dgvSPDH.Rows[i].Cells["MASP1"].Value.ToString(), int.Parse(dgvSPDH.Rows[i].Cells["SOLUONGDAT1"].Value.ToString()));
                    }
                    MessageBox.Show("Thêm đơn đặt hàng thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Soanlai();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Thêm đơn đặt hàng không thành công \n" + "\n Lỗi " + ex.Message, "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm");
            }
        }
        #endregion

        #region Hiển thị dữ liệu đơn đặt hàng
        private void btBrown_Click(object sender, EventArgs e)
        {
            FrmThongTinDonDatHang tt = new FrmThongTinDonDatHang();
            tt.ShowDialog();
            HienThiTTDH();
        }

        public void HienThiTTDH()
        {
            if (FrmThongTinDonDatHang.MADH != "")
            {
                try
                {
                    dt = dh.HienThiChiTiet(FrmThongTinDonDatHang.MADH);
                    txtMaDDH.Text = dt.Rows[0]["MADDH"].ToString();
                    cbHoTenKH.Text = dh.LayTenKHTuMaKH(dt.Rows[0]["MAKH"].ToString());
                    txtNgaydat.Text = Convert.ToDateTime(dt.Rows[0]["NGAYDAT"].ToString()).ToShortDateString();
                    float tongtien = 0, tongtiendh = 0;
                    if (txtTongTien.Text == "")
                        tongtiendh = 0;
                    else
                        tongtiendh = float.Parse(txtTongTien.Text);
                    for (int i = 0; i < dgvSPDH.Rows.Count - 1; i++)
                    {
                        tongtien = float.Parse(dgvSPDH.Rows[i].Cells["SOLUONGDAT1"].Value.ToString()) * float.Parse(dgvSPDH.Rows[i].Cells["DONGIA1"].Value.ToString());
                        tongtiendh += tongtien;
                        txtTongTien.Text = tongtiendh.ToString();
                    }
                }
                catch
                { }
            }
            else
                return;
        }
        #endregion

        #region Hiển thị sản phẩm đơn đặt hàng
        private void txtMaDDH_EditValueChanged(object sender, EventArgs e)
        {
            dgvSPDH.DataSource = dh.HienThiSP(txtMaDDH.Text);
        }
        #endregion

        #region Cập nhật đơn đặt hàng
        private void btCapnhat_Click(object sender, EventArgs e)
        {
            if (dgvSPDH.Rows.Count - 1 != 0)
            {
                try
                {
                    for (int i = 0; i < dgvSPDH.Rows.Count - 1; i++)
                    {
                        dh.CapNhatDDH(txtMaDDH.Text, dgvSPDH.Rows[i].Cells["MASP1"].Value.ToString(), int.Parse(dgvSPDH.Rows[i].Cells["SOLUONGDAT1"].Value.ToString()));
                    }
                    MessageBox.Show("Cập nhật đơn đặt hàng thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Soanlai();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Cập nhật đơn đặt hàng không thành công \n" + " \n Lỗi " + ex.Message, "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Chưa có sản phẩm để cập nhật");
        }
        #endregion

        #region Xóa đơn đặt hàng
        private void btXoa_Click(object sender, EventArgs e)
        {
            dh.XoaDonDatHang(txtMaDDH.Text);
            Soanlai();
        }
        #endregion

        #region Tra cứu đơn đặt hàng
        private void btTracuu_Click(object sender, EventArgs e)
        {
            FrmTraCuuDonDatHang tc = new FrmTraCuuDonDatHang();
            tab.TaoTabTraCuuDonDatHang();
        }
        #endregion

        #region Phân quyền
        public void Enable_Insert()
        {
            btThem.Enabled = true;
            btHuy.Enabled = true;
            btSoanlai.Enabled = true;
            btTracuu.Enabled = true;
            btnXuatRaExcel.Enabled = true;
        }
        public void Enable_UpDate()
        {
            btCapnhat.Enabled = true;
            btSoanlai.Enabled = true;
            btTracuu.Enabled = true;
            btnXuatRaExcel.Enabled = true;
        }
        public void Enable_Delete()
        {
            btHuy.Enabled = true;
        }
        #endregion

        private void btnXuatRaExcel_Click(object sender, EventArgs e)
        {
            
            CXuatDDHRaExcel excel = new CXuatDDHRaExcel();
            try
            {
                DataTable dt = dh.HienThiSP(txtMaDDH.Text);
                if (dt.Rows.Count == 1)
                    MessageBox.Show("Không có sản phẩm cần xuất");
                else
                {
                    dgvSPDH.DataSource = dt;
                    excel.XuatRaExcel(dt, "DanhSachCacDonDatHang", "Danh Sách Các Đơn Đặt Hàng");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi"); 
            }
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            dh.XoaDonDatHang(txtMaDDH.Text);
            Soanlai();
        }
    }
}
