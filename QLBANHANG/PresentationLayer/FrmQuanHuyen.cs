using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;
using QLBANHANG.BussinessLogicLayer;
using QLBANHANG.DataAccessLayer;
namespace QLBANHANG.PresentationLayer
{
    public partial class FrmQuanHuyen : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmQuanHuyen()
        {
            InitializeComponent();
        }
        CQUANHUYEN QH = new CQUANHUYEN();
        CDatabase db = new CDatabase();
        CTINHTHANH TT = new CTINHTHANH();

        private void FrmQuanHuyen_Load(object sender, EventArgs e)
        {
            dgvQuanHuyen.DataSource = QH.LayDSQuanHuyen();
            dgvTinhThanh.DataSource = TT.LayDSTinhThanh();
            dgvHuyen.DataSource = QH.LayDSQuanHuyen();
            dgvTinh.DataSource = TT.LayDSTinhThanh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvQuanHuyen.CurrentRow.Cells["TENHUYEN"].Value.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên huyện");
                return;
            }
            else
            {
                QH.ThemQuanHuyen(dgvQuanHuyen.CurrentRow.Cells["TENHUYEN"].Value.ToString());
                dgvQuanHuyen.DataSource = QH.LayDSQuanHuyen();
                dgvHuyen.DataSource = QH.LayDSQuanHuyen();
               

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string[] MaHuyen = new string[dgvQuanHuyen.Rows.Count];
            int dem = 0;
            for (int i = 0; i < dgvQuanHuyen.Rows.Count; i++)
            {
                    if (dgvQuanHuyen.Rows[i].Selected == true)
                    {
                        MaHuyen[dem] = dgvQuanHuyen.Rows[i].Cells[0].Value.ToString();
                        dem += 1;
                    }
            }
            if (dem > 0)
            {
                for (int i = 0; i < dem; i++)
                {
                    QH.XoaQuanHuyen(MaHuyen[i].ToString());
                    dgvQuanHuyen.DataSource = QH.LayDSQuanHuyen();
                    dgvHuyen.DataSource = QH.LayDSQuanHuyen();
                }
            }
            QH.XoaQuanHuyen(dgvQuanHuyen.CurrentRow.Cells["MAHUYEN"].Value.ToString());
            dgvQuanHuyen.DataSource = QH.LayDSQuanHuyen();
            dgvHuyen.DataSource = QH.LayDSQuanHuyen();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvQuanHuyen.CurrentRow.Cells["TENHUYEN"].Value.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên huyện");
                return;
            }
            else
            {
                string[] MaHuyen = new string[dgvQuanHuyen.Rows.Count];
                QH.CapNhatQuanHuyen(dgvQuanHuyen.CurrentRow.Cells["MAHUYEN"].Value.ToString(), dgvQuanHuyen.CurrentRow.Cells["TENHUYEN"].Value.ToString());
                dgvQuanHuyen.DataSource = QH.LayDSQuanHuyen();
                dgvHuyen.DataSource = QH.LayDSQuanHuyen();
            }
        }
        #region PHAN QUYEN
        public void Enable_Insert()
        {
            btnThem.Enabled = true;
            btn_Them.Enabled = true;
        }
        public void Enable_Delete()
        {
            btnXoa.Enabled = true;
            btn_Xoa.Enabled = true;
        }
        public void Enable_UpDate()
        {
            btnCapNhat.Enabled = true;
            btn_CapNhat.Enabled = true;
        }
        #endregion
        private void dgvTinh_Click(object sender, EventArgs e)
        {
            dgvChitiet.DataSource=QH.LayDSHuyenCuaTinh(dgvTinh.CurrentRow.Cells["MATINH1"].Value.ToString());
        }

        private void dgvHuyen_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int temp = dgvChitiet.Rows.Count;
            if (Convert.ToBoolean(dgvHuyen.CurrentRow.Cells[0].Value) == true)
            {
                for (int i = 0; i < temp; i++)
                {
                    dgvChitiet.Rows[i].Cells[1].Value = dgvHuyen.CurrentRow.Cells[1].Value.ToString();
                    dgvChitiet.Rows[i].Cells[2].Value = dgvHuyen.CurrentRow.Cells[2].Value.ToString();
                    QH.ThemCTQH_TT(dgvChitiet.Rows[i].Cells[1].Value.ToString(), dgvTinh.CurrentRow.Cells[0].Value.ToString());
                    dgvChitiet.DataSource = QH.LayDSHuyenCuaTinh(dgvTinh.CurrentRow.Cells[0].Value.ToString());
                }
                temp++;
                dgvHuyen.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
            }
        }

        private void dgvChitiet_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToBoolean(dgvChitiet.CurrentRow.Cells[0].Value) == true)
            {
                QH.XoaCTQH_TT(dgvChitiet.CurrentRow.Cells[1].Value.ToString(), dgvTinh.CurrentRow.Cells[0].Value.ToString());
                for (int i = 0; i < dgvChitiet.Rows.Count - 1; i++)
                    dgvChitiet.Rows.RemoveAt(i);
                dgvChitiet.DataSource = QH.LayDSHuyenCuaTinh(dgvTinh.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (dgvTinhThanh.CurrentRow.Cells["TENTINH"].Value.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tỉnh");
                return;
            }
            else
            {
                TT.ThemTinhThanh(dgvTinhThanh.CurrentRow.Cells["TENTINH"].Value.ToString());
                dgvTinhThanh.DataSource = TT.LayDSTinhThanh();
            }
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            TT.XoaTinhThanh(dgvTinhThanh.CurrentRow.Cells["MATINH"].Value.ToString());
            dgvTinhThanh.DataSource = TT.LayDSTinhThanh();
            dgvTinh.DataSource = TT.LayDSTinhThanh();
        }

        private void btn_CapNhat_Click_1(object sender, EventArgs e)
        {
            if (dgvTinhThanh.CurrentRow.Cells["TENTINH"].Value.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tỉnh");
                return;
            }
            else
            {
                TT.CapNhatTinhThanh(dgvTinhThanh.CurrentRow.Cells["MATINH"].Value.ToString(),dgvTinhThanh.CurrentRow.Cells["TENTINH"].Value.ToString());
                dgvTinhThanh.DataSource = TT.LayDSTinhThanh();
                dgvTinh.DataSource = TT.LayDSTinhThanh();
            }
        }

 
    }
}