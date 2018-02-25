using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLBANHANG
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
                if (sqlconn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Kết nối thành công! ", "Thông báo!");
                    FrmMain g = new FrmMain();
                    g.ShowDialog();

                }
                else if (sqlconn.State == ConnectionState.Closed)
                    MessageBox.Show("Kết nối thất bại", "Thông báo!");

                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối! " + ex.Message);
                return false;
            }

        }
        public DataTable ExecuteBang(string query)
        {
            sqlconn = new SqlConnection(strconn);
            SqlDataAdapter da = new SqlDataAdapter(query, strconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
