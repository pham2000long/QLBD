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

        public List<UsersDTO> ListUsers()
        {
            string sql = "select * from users";
            DataTable data = new DataTable();
            data = dal.GetTable(sql);
            List<UsersDTO> listusers = new List<UsersDTO>();
            foreach (DataRow row in data.Rows)
            {
                UsersDTO user = new UsersDTO();
                user.ID = int.Parse(row["id"].ToString());
                //category.ID = int.Parse(dt.Rows[i].ItemArray[0].ToString());
                user.UserName = row["username"].ToString();
                user.FullName = row["fullname"].ToString();
                user.Gender = row["gender"].ToString();
                user.Phone = row["phone"].ToString();
                user.Address = row["address"].ToString();
                user.Email = row["email"].ToString();
                if (int.Parse(row["roles"].ToString()) == 1)
                    user.Roles = "Admin";
                else










                    user.Roles = "Nhân viên";

                listusers.Add(user);
            }
            return listusers;
        }

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

        public void insertUser(string user, string pass, string fullName, string gender, string phone, string address, string email, int roles)
        {
            try
            {
                
                string sql = "insert into users (username, password, fullname, gender, phone, address, email, roles) values ('" + user + "', '" + pass + "', N'" + fullName + "','" + gender + "','" + int.Parse(phone) + "', N'" + address + "', '" + email + "','" + roles + "')";
                dal.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {}
        }

        //public void updateProduct(string mh, string th, string nn, int sl, Boolean tt, string ncc)
        //{
        //    string sql = "update HangHoa set TenHang=N'" + th + "', NgayCap='" + nn + "', SoLuong='" + sl + "', TinhTrang='" + tt + "', NhaCungCap=N'" + ncc + "' where MaHang='" + mh + "'";
        //    dal.ExecuteNonQuery(sql);
        //}

        public void deleteUser(string id)
        {
            string sql = "delete users where id='" + id + "'";
            dal.ExecuteNonQuery(sql);
        }

    }
}
