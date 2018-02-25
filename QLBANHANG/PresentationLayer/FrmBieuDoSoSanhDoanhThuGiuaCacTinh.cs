using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraCharts;
using QLBANHANG.BussinessLogicLayer;
using QLBANHANG.DataAccessLayer;
using QLBANHANG.Report;
using System.Data.SqlClient;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmBieuDoSoSanhDoanhThuGiuaCacTinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmBieuDoSoSanhDoanhThuGiuaCacTinh()
        {
            InitializeComponent();
        }
        CDatabase db = new CDatabase();
        
        CBaoCaoDoanhThu DT = new CBaoCaoDoanhThu();
        CDonDatHangNew DDH = new CDonDatHangNew();
        public void HienThiDSTinh()
        {
            DataTable dt1 = new DataTable();
            dt1 = DT.LayDanhSachTinh_report();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                dgvDanhSachTinh.Rows.Add();
                dgvDanhSachTinh.Rows[i].Cells["MaTinh"].Value = dt1.Rows[i]["MaTinh"].ToString();
                dgvDanhSachTinh.Rows[i].Cells["TenTinh"].Value = dt1.Rows[i]["TenTinh"].ToString();
                dgvDanhSachTinh.Rows[i].Cells["COLCHECK"].Value = false;
            }
        }
        public void HienThiDSSanPham()
        {
            cbSanPham.Properties.DataSource = DT.LayDanhSachSanPham_report();
            cbSanPham.Properties.ValueMember = "MASP";
            cbSanPham.Properties.DisplayMember = "TENSP";
        }
        
        private void FrmBieuDoSoSanhDoanhThuGiuaCacTinh_Load(object sender, EventArgs e)
        {
            HienThiDSSanPham();
            HienThiDSTinh();
            dateEditTuNgay.Text = DateTime.Now.ToShortDateString();
            dateEditDenNgay.Text = DateTime.Now.ToShortDateString();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            for (int i = 0; i < dgvDanhSachTinh.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvDanhSachTinh.Rows[i].Cells["colcheck"].Value) == true)
                {
                    dgvDSTinhDuocChon.Rows.Add();
                    dgvDSTinhDuocChon.Rows[dgvDSTinhDuocChon.Rows.Count - 1].Cells["matinhchon"].Value = dgvDanhSachTinh.Rows[i].Cells["MATINH"].Value.ToString();
                    dgvDSTinhDuocChon.Rows[dgvDSTinhDuocChon.Rows.Count - 1].Cells["tentinhchon"].Value = dgvDanhSachTinh.Rows[i].Cells["TENTINH"].Value.ToString();
                    dgvDSTinhDuocChon.Rows[dgvDSTinhDuocChon.Rows.Count - 1].Cells["colcheckchon"].Value = true;
                }
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dgvDSTinhDuocChon.Rows.Count != 0)
            {
                for (int i = dgvDSTinhDuocChon.Rows.Count - 1; i >= 0; i--)
                {
                    if (Convert.ToBoolean(dgvDSTinhDuocChon.Rows[i].Cells["colcheckchon"].Value) == true)
                    {
                        dgvDSTinhDuocChon.Rows.RemoveAt(i);
                    }
                }
            }
        }

        private void btnXemBieuDo_Click_1(object sender, EventArgs e)
        {
            xtraTabControlMain.SelectedTabPage = xtpPreview;
          
                if (dateEditTuNgay.Text != "" && dateEditDenNgay.Text != "")
                {
                    if (dgvDSTinhDuocChon.Rows.Count != 0)
                    {
                        rptSoSanhDoanhThuGiuaCacTinh rpt = new rptSoSanhDoanhThuGiuaCacTinh();
                        DataTable dt = new DataTable();
                        string str;
                        for (int i = 0; i < dgvDSTinhDuocChon.Rows.Count; i++)
                        {
                            str = String.Format("EXEC SP_SOSANHDOANHTHUTHEOTINH '{0}','{1}','{2}','{3}'", dateEditTuNgay.Text, dateEditDenNgay.Text, dgvDSTinhDuocChon.Rows[i].Cells["matinhchon"].Value.ToString(), cbSanPham.GetColumnValue("MASP").ToString());
                            dt = db.ExecuteBang(str);
                            if (i == 0)
                            {
                                rpt.xrChart1.Series[0].DataSource = dt;
                                //so sanh theo ten tinh
                                rpt.xrChart1.Series[0].ArgumentDataMember = "tentinh";
                                rpt.xrChart1.Series[0].Name = dgvDSTinhDuocChon.Rows[i].Cells["tentinhchon"].Value.ToString();
                                //dieu kien de so sanh la doanh thu
                                rpt.xrChart1.Series[0].ValueDataMembers.AddRange(new string[] { "DOANHTHU" });
                            }
                            else
                            {
                                Series s = new Series();
                                s.DataSource = dt;
                                s.ArgumentDataMember = "tentinh";
                                s.Name = dgvDSTinhDuocChon.Rows[i].Cells["tentinhchon"].Value.ToString();
                                s.ValueDataMembers.AddRange(new string[] { "DOANHTHU" });
                                rpt.xrChart1.Series.Add(s);
                            }
                        }

                        rpt.xrChart1.Legend.Visible = true;
                        rpt.xrlbTuNgay.Text = Convert.ToDateTime(dateEditTuNgay.Text).ToShortDateString();
                        rpt.xrlbDenNgay.Text = Convert.ToDateTime(dateEditDenNgay.Text).ToShortDateString(); 
                        rpt.xrlbTenSP.Text = cbSanPham.Text;
                        printControlPreview.PrintingSystem = rpt.PrintingSystem;
                        rpt.CreateDocument();

                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa chọn các tỉnh cần so sánh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                    MessageBox.Show("Bạn phải nhập khoảng thời gian cần thống kê", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    

       
    }
}