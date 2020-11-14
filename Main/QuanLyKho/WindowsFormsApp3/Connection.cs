using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp3
{
    class Connection
    {
        private readonly string strConn = "server=CANARY-PC;database=quanlythuvien;uid=sa;pwd=system";
        public SqlConnection conn { get; set; }
        public SqlCommand cmd { get; set; }
        public SqlDataReader drd { get; set; }
        public SqlDataAdapter da { get; set; }
        public Connection()
        {
            conn = new SqlConnection(strConn);
            cmd = null;
            drd = null;
            da = null;
        }

        public bool openConn()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool closeConn()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public SqlDataReader executeSQL(string sql)
        {
            cmd = new SqlCommand(sql, conn);
            drd = cmd.ExecuteReader();
            return drd;
        }
        public int executeUpdate(string sql)
        {
            cmd = new SqlCommand(sql, conn);
            return cmd.ExecuteNonQuery();
        }

        public DataTable loadDataTable(string sql)
        {
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void UpdateTable(DataTable dt)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder();
            da.Update(dt);
        }
    }
}
