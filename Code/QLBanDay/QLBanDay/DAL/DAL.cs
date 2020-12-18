using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLBanDay
{
    class dal
    {
        private SqlConnection getConnection()
        {
            string connString = @"Data Source=DESKTOP-VOM8DSD\SQLEXPRESS;Initial Catalog=QLBanDay;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
        public DataTable GetTable(String sql)
        {
            try
            {
                SqlConnection con = getConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (SqlException)
            {
                return null;
            }

        }
        public void ExecuteNonQuery(String sql)
        {
            try
            {
                SqlConnection con = getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException) { }
        }
    }
}
