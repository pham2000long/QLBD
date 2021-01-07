using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLBanDay.DTO;

namespace QLBanDay.BLL
{
    class usersBLL
    {
        dal dal = new dal();
        public bool getUsernamPassword(string usename, string password)
        {
            string sql = "select * from users where username='" + usename + "' AND password='" + password + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt.Rows.Count == 0 ? false : true;
            //return false;
        }

        public DataTable showUser()
        {
            string sql = "select * from users";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        public void insertUser(string user, string pass, string fullName, int gender, string phone, string address, string email, string avartar, int roles)
        {
            try
            {
                
                string sql = "insert into users (username, password, fullname, gender, phone, address, email, avatar, roles) values ('" + user + "', '" + pass + "', N'" + fullName + "','" + gender + "','" + int.Parse(phone) + "', N'" + address + "', '" + email + "','" + avartar + "','" + roles + "')";
                dal.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {}
        }

        public void updateUser(string user, string pass, string fullName, int gender, string phone, string address, string email, string avartar, int roles, int id)
        {
            try
            {
                string sql = "update users set username=N'" + user + "', password='" + pass + "', fullName=N'" + fullName + "', gender='" + gender + "', phone='" + int.Parse(phone) + "',  address=N'" + address + "',  email=N'" + email + "',  avatar=N'" + avartar + "',  roles=N'" + roles + "', updated_at='"+ DateTime.Now + "' where id='" + id + "'";
                dal.ExecuteNonQuery(sql);
            }
            catch (Exception) { }
        }

        public void deleteUser(string id)
        {
            string sql = "delete users where id='" + id + "'";
            dal.ExecuteNonQuery(sql);
        }

    }
}
