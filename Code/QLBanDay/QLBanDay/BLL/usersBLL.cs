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

        //private List<UsersDTO> ListUsers(DataTable dt)
        //{
        //    List<UsersDTO> listUsers = new List<UsersDTO>();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        UsersDTO user = new UsersDTO();
        //        user.UserName = "";
        //        user.Password = "";
        //        user.FullName = "";
        //        //user.Gender = "";
        //        user.Address = "";
        //        user.Phone = "";
        //        user.Email = "";
        //        user.Avatar = "";
        //        user.Roles = 0;
        //        user.ID = int.Parse(dt.Rows[0].ItemArray[0].ToString());
        //        user.UserName = dt.Rows[0].ItemArray[1].ToString();
        //        user.Password = dt.Rows[0].ItemArray[2].ToString();
        //        user.FullName = dt.Rows[0].ItemArray[3].ToString();
        //        //user.Gender = dt.Rows[0].ItemArray[4].ToString();
        //        user.Address = dt.Rows[0].ItemArray[5].ToString();
        //        user.Phone = dt.Rows[0].ItemArray[6].ToString();
        //        listUsers.Add(user);
        //    }
        //    return listUsers;
        //}
       
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
