using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLBanDay.DTO;
using System.Windows.Forms;

namespace QLBanDay
{
    class dal
    {
        private SqlConnection getConnection()
        {
            string connString = @"Data Source=DESKTOP-VOM8DSD\SQLEXPRESS;Initial Catalog=QLBanGiay;Integrated Security=True";
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
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
                return null;
            }
        }

        public void ExecuteNonQuery(String sql)
        {
            try
            {
                SqlConnection connect = getConnection();
                connect.Open();
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.ExecuteNonQuery();
            } catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
