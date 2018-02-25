using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QLBANHANG.DataAccessLayer
{
    class CDatabase
    {
        public SqlConnection sqlconn;
        public static string strconn;

        public bool KetNoi(string svrName, string dbName, bool integratedMode, string usrName, string pwd)
        {
            try
            {
                if (integratedMode == true)
                    strconn = "server=" + svrName + "; database=" + dbName + "; Integrated Security = True";
                else

                    strconn = "server=" + svrName + "; uid=" + usrName + "; pwd=" + pwd + " ;database=" + dbName;
                sqlconn = new SqlConnection(strconn);
                sqlconn.Open();
                return true;
            }
            catch
            {
               
                return false;
            }
        
        }
        //Ham lay du lieu datatable tu cau truy van truyen vao
        public DataTable ExecuteBang(string query)
        {
            sqlconn = new SqlConnection(strconn);
            SqlDataAdapter da = new SqlDataAdapter(query, strconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //Ham thuc hien cau truy van Insert, Update, Delete
        public void ExecuteLenh(string strquery)
        {
            try
            {
                sqlconn = new SqlConnection(strconn);
                SqlCommand sqlcom = new SqlCommand(strquery, sqlconn);
                sqlconn.Open();
                sqlcom.ExecuteNonQuery();
                sqlconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ThucThiLenh(SqlCommand cmd)
        {
            sqlconn = new SqlConnection(strconn);
            sqlconn.Open();
            cmd.Connection = sqlconn;
            cmd.ExecuteNonQuery();
            sqlconn.Close();
        }
        //Phương thức kiểm tra sự tồn tại của dữ liệu
        public bool ExcuteReader_bool(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, sqlconn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                return true;
            }
            else
            {
                dr.Close();
                return false;
            }
        }
    }
    
}
