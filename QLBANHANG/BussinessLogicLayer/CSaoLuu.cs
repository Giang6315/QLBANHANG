using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLBANHANG.DataAccessLayer;
namespace QLBANHANG.BussinessLogicLayer
{
    class CSaoLuu
    {
        CDatabase db = new CDatabase();
       /* public void SaoLuu()
        {
            try
            {
                db.sqlconn.Open();
                string strBackup = "BACKUP DATABASE QUANLYKHACHHANG TO DISK = " + strPath;
                SqlCommand cmd = new SqlCommand(strBackup, db.sqlconn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Backup database");
                return;
            }
            finally
            {
                db.sqlconn.Close();
            }
        }
        */

    }
}
