using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLBANHANG.DataAccessLayer;
using QLBANHANG.PresentationLayer;
using System.Windows.Forms;

namespace QLBANHANG.BussinessLogicLayer
{
    class CCauHoi
    {
        CDatabase db = new CDatabase();
        DataTable dt = new DataTable();

        #region Câu hỏi
        public DataTable LayDSCauHoi()
        {
            return db.ExecuteBang("SELECT * FROM CAUHOI");
        }

        public void ThemCauHoi(string mach, string noidung, int loaich)
        {
            try
            {
                dt = db.ExecuteBang("SP_THEM_CAUHOI '" + mach + "',N'" + noidung + "'," + loaich);
                MessageBox.Show("Thêm câu hỏi thành công", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm câu hỏi không thành công \n" + "\n Lỗi " + ex.Message, "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        public void CapNhatCauHoi(string mach, string noidung, int loaich)
        {
            try
            {
                dt = db.ExecuteBang( "SP_CAPNHAT_CAUHOI '" + mach + "',N'" + noidung + "'," + loaich);
                MessageBox.Show("Cập nhật câu hỏi thành công", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật câu hỏi không thành công \n" + "\n Lỗi " + ex.Message, "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        public void XoaCauHoi(string mach)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn xóa câu hỏi này không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    dt = db.ExecuteBang("SP_XOA_CAUHOI '" + mach + "'");
                    MessageBox.Show("Xóa câu hỏi thành công", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa câu hỏi không thành công \n" + "\n Lỗi " + ex.Message, "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }
        }

        #endregion

        #region Câu chọn
        public DataTable LayDSCauChon()
        {
            return db.ExecuteBang("SELECT * FROM CAUCHON");
        }

        public void ThemCauChon(string macc, string noidungcc)
        {
            try { 
                dt=db.ExecuteBang("SP_THEM_CAUCHON '" + macc + "',N'" + noidungcc + "'");
                MessageBox.Show("Thêm câu chọn thành công", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm câu chọn không thành công \n " + "\n Lỗi " + ex.Message, "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        public void CapNhatCauChon(string macc, string noidungcc)
        {
            try { 
                dt=db.ExecuteBang("SP_CAPNHAT_CAUCHON '" + macc + "',N'" + noidungcc + "'");
                MessageBox.Show("Cập nhật câu chọn thành công", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Cập nhật câu chọn không thành công \n " + "\n Lỗi " + ex.Message, "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        public void XoaCauChon(string macc)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn xóa câu chọn này không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    dt = db.ExecuteBang("SP_XOA_CAUCHON '" + macc + "'");
                    MessageBox.Show("Xóa câu chọn thành công", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa câu chọn không thành công \n " + "\n Lỗi " + ex.Message, "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }
        }
        #endregion

        #region Chi tiết câu hỏi, câu chọn
        public void ThemCTCH_CC(string mach, string macc)
        {
            try
            {
                dt = db.ExecuteBang("SP_THEM_CHCC '" + mach + "','" + macc + "'");
                MessageBox.Show("Thêm câu chọn của câu hỏi thành công", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                return;
            }
        }

        public DataTable LayDSCTCH_CC(string mach)
        {
            DataTable dt1=db.ExecuteBang("SELECT A.MACC, A.NOIDUNGCC FROM CTCH_CC INNER JOIN (SELECT MACC, NOIDUNGCC FROM CAUCHON)A ON CTCH_CC.MACC=A.MACC WHERE CTCH_CC.MACH='" + mach + "'");
            return dt1;
            
        }

        public void XoaCTCH_CC(string mach, string macc)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn hủy câu chọn này không?", "Cảnh báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (kq == DialogResult.Yes)
            {
                try
                {
                   db.ExecuteLenh("SP_XOA_CHCC '" + mach + "','" + macc + "'");
                    MessageBox.Show("Hủy câu chọn của câu hỏi thành công", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    return;
                }
            }
        }
        #endregion
    }
}
