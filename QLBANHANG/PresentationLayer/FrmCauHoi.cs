using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLBANHANG.PresentationLayer;
using QLBANHANG.BussinessLogicLayer;
using QLBANHANG.DataAccessLayer;

namespace QLBANHANG.PresentationLayer
{
    public partial class FrmCauHoi : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmCauHoi()
        {
            InitializeComponent();
        }
        CCauHoi ch = new CCauHoi();
        DataTable dt = new DataTable();
        CDatabase db = new CDatabase();
        #region Load
        private void FrmCauHoi_Load(object sender, EventArgs e)
        {
            LayMaCH();
            LayMaCC();
            dgvCauChon.DataSource = ch.LayDSCauChon();
            dgvCauHoi.DataSource = ch.LayDSCauHoi();
            dgv_Cauchon.DataSource = ch.LayDSCauChon();
            dgv_Cauhoi.DataSource = ch.LayDSCauHoi();
        }
        #endregion

        #region Câu hỏi
        public void LayMaCH()
        {
            dt = db.ExecuteBang("EXEC LAYMACH");
            txtMaCH.Text = dt.Rows[0][0].ToString();
        }

        private void dgvCauHoi_Click(object sender, EventArgs e)
        {
            txtMaCH.Text = dgvCauHoi.CurrentRow.Cells["colmach"].Value.ToString();
            txtNDCH.Text = dgvCauHoi.CurrentRow.Cells["colnoidungch"].Value.ToString();
        }

        private void btThemCH_Click(object sender, EventArgs e)
        {
            int loai = 0;
            if (ckLoaiCH.Checked == true)
                loai = 1;
            else
                loai = 0;
            if (txtMaCH.Text == "" || txtNDCH.Text == "")
                MessageBox.Show("Mã hoặc tên câu hỏi không được rỗng");
            else
                ch.ThemCauHoi(txtMaCH.Text, txtNDCH.Text, loai);
            dgvCauHoi.DataSource = ch.LayDSCauHoi();
            dgv_Cauhoi.DataSource = ch.LayDSCauHoi();
            SoanLaiCH();
        }

        private void btCapNhapCH_Click(object sender, EventArgs e)
        {
            int loai = 0;
            if (ckLoaiCH.Checked == true)
                loai = 1;
            else
                loai = 0;
            if (txtMaCH.Text == "" || txtNDCH.Text == "")
                MessageBox.Show("Mã hoặc tên câu hỏi không được rỗng");
            else
                ch.CapNhatCauHoi(txtMaCH.Text, txtNDCH.Text, loai);
            dgvCauHoi.DataSource = ch.LayDSCauHoi();
            dgv_Cauhoi.DataSource = ch.LayDSCauHoi();
            SoanLaiCH();
        }

        private void btXoaCH_Click(object sender, EventArgs e)
        {
            if (txtMaCH.Text == "")
                MessageBox.Show("Mã câu hỏi không được rỗng");
            else
                ch.XoaCauHoi(txtMaCH.Text);
            dgvCauHoi.DataSource = ch.LayDSCauHoi();
            dgv_Cauhoi.DataSource = ch.LayDSCauHoi();
            SoanLaiCH();
        }

        public void SoanLaiCH()
        {
            txtMaCH.Text = "";
            txtNDCH.Text = "";
            ckLoaiCH.Checked = false;
            LayMaCH();
        }

        private void btSoanlaiCH_Click(object sender, EventArgs e)
        {
            SoanLaiCH();
        }
        #endregion

        #region Câu chọn
        public void LayMaCC()
        {
            dt = db.ExecuteBang("EXEC LAYMACC");
            txtMaCC.Text = dt.Rows[0][0].ToString();
        }

        private void btThemCC_Click(object sender, EventArgs e)
        {
            if (txtMaCC.Text == "" || txtNDCC.Text == "")
                MessageBox.Show("Mã hoặc nội dung câu chọn không được rỗng");
            else
                ch.ThemCauChon(txtMaCC.Text, txtNDCC.Text);
            dgvCauChon.DataSource = ch.LayDSCauChon();
            dgv_Cauchon.DataSource = ch.LayDSCauChon();
            SoanlaiCC();
        }

        private void btCapNhatCC_Click(object sender, EventArgs e)
        {
            if (txtMaCC.Text == "" || txtNDCC.Text == "")
                MessageBox.Show("Mã hoặc nội dung câu chọn không được rỗng");
            else
                ch.CapNhatCauChon(txtMaCC.Text, txtNDCC.Text);
            dgvCauChon.DataSource = ch.LayDSCauChon();
            dgv_Cauchon.DataSource = ch.LayDSCauChon();
            SoanlaiCC();
        }

        private void btXoaCC_Click(object sender, EventArgs e)
        {
            if (txtMaCC.Text == "")
                MessageBox.Show("Mã câu chọn không được rỗng");
            else
                ch.XoaCauChon(txtMaCC.Text);
            dgvCauChon.DataSource = ch.LayDSCauChon();
            dgv_Cauchon.DataSource = ch.LayDSCauChon();
            SoanlaiCC();
        }

        private void dgvCauChon_Click(object sender, EventArgs e)
        {
            txtMaCC.Text = dgvCauChon.CurrentRow.Cells["colmacc"].Value.ToString();
            txtNDCC.Text = dgvCauChon.CurrentRow.Cells["colnoidungcc"].Value.ToString();
        }

        public void SoanlaiCC()
        {
            txtMaCC.Text = "";
            txtNDCC.Text = "";
            LayMaCC();
        }

        private void btSoanlaiCC_Click(object sender, EventArgs e)
        {
            SoanlaiCC();
        }
        #endregion

        #region Danh sách các sự kiện
        private void dgv_Cauhoi_Click(object sender, EventArgs e)
        {
            txt_NoidungCH.Text = dgv_Cauhoi.CurrentRow.Cells["col_noidungch"].Value.ToString();
            
            dgv_Cau.DataSource = new DataTable();
            dgv_Cau.DataSource = ch.LayDSCTCH_CC(dgv_Cauhoi.CurrentRow.Cells["col_mach"].Value.ToString());
        }

        private void dgv_Cauchon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int temp = dgv_Cau.Rows.Count;
            if (Convert.ToBoolean(dgv_Cauchon.CurrentRow.Cells[0].Value) == true)
            {
                for (int i = 0; i < temp; i++)
                {
                    dgv_Cau.Rows[i].Cells[1].Value = dgv_Cauchon.CurrentRow.Cells[1].Value.ToString();
                    dgv_Cau.Rows[i].Cells[2].Value = dgv_Cauchon.CurrentRow.Cells[2].Value.ToString();
                    ch.ThemCTCH_CC(dgv_Cauhoi.CurrentRow.Cells[0].Value.ToString(), dgv_Cau.Rows[i].Cells[1].Value.ToString());
                    dgv_Cau.DataSource = ch.LayDSCTCH_CC(dgv_Cauhoi.CurrentRow.Cells[0].Value.ToString());
                }
                temp++;
                dgv_Cauchon.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
            }
        }

        private void dgv_Cauchon1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
                if (Convert.ToBoolean(dgv_Cau.CurrentRow.Cells[0].Value) == true)
                {
                    try
                    {
                        ch.XoaCTCH_CC(dgv_Cauhoi.CurrentRow.Cells[0].Value.ToString(), dgv_Cau.CurrentRow.Cells[1].Value.ToString());
                        for (int i = 0; i < dgv_Cau.Rows.Count - 1; i++)
                            dgv_Cau.Rows.RemoveAt(i);
                        DataTable dt = ch.LayDSCTCH_CC(dgv_Cauhoi.CurrentRow.Cells[0].Value.ToString());
                        dgv_Cau.DataSource = ch.LayDSCTCH_CC(dgv_Cauhoi.CurrentRow.Cells[0].Value.ToString());
                    }
                    catch
                    { }
                }

        }
        #endregion

        #region Phân quyền
        public void Enable_Insert()
        {
            btThemCC.Enabled = true;
            btSoanlaiCC.Enabled = true;
            btThemCH.Enabled = true;
            btSoanlaiCH.Enabled = true;
        }
        public void Enable_Delete()
        {
            btXoaCC.Enabled = true;
            btXoaCH.Enabled = true;
        }
        public void Enable_UpDate()
        {
            btCapNhatCC.Enabled = true;
            btSoanlaiCC.Enabled = true;
            btCapNhapCH.Enabled = true;
            btSoanlaiCH.Enabled = true;
        }
        #endregion
    }
}
