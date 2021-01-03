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

        private List<UsersDTO> ListUsers(DataTable dt)
        {
            List<UsersDTO> listUsers = new List<UsersDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                UsersDTO user = new UsersDTO();
                user.UserName = "";
                user.Password = "";
                user.FullName = "";
                //user.Gender = "";
                user.Address = "";
                user.Phone = "";
                user.Email = "";
                user.Avatar = "";
                user.Roles = 0;
                user.ID = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                user.UserName = dt.Rows[0].ItemArray[1].ToString();
                user.Password = dt.Rows[0].ItemArray[2].ToString();
                user.FullName = dt.Rows[0].ItemArray[3].ToString();
                //user.Gender = dt.Rows[0].ItemArray[4].ToString();
                user.Address = dt.Rows[0].ItemArray[5].ToString();
                user.Phone = dt.Rows[0].ItemArray[6].ToString();
                listUsers.Add(user);
            }
            return listUsers;
        }
       
        public bool getUsernamPassword(string usename, string password)
        {
            string sql = "select * from users where username='" + usename + "' AND password='" + password + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt.Rows.Count == 0 ? false : true;
            //return false;
        }

        public DataTable showProduct()
        {
            string sql = "select * from QLBanDay";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }

        public void insertProduct(UsersDTO user)
        {
            user.Created_at = DateTime.Now;
            string sql = "insert into users(username, password, fullname, phone, address, email, avartar, roles, created_at) values (@0, @2, @3, @4, @5, @6, @7, @8)";
            dal.ExecuteNonQuery(sql);
        }

        //public void updateProduct(string mh, string th, string nn, int sl, Boolean tt, string ncc)
        //{
        //    string sql = "update HangHoa set TenHang=N'" + th + "', NgayCap='" + nn + "', SoLuong='" + sl + "', TinhTrang='" + tt + "', NhaCungCap=N'" + ncc + "' where MaHang='" + mh + "'";
        //    dal.ExecuteNonQuery(sql);
        //}

        //public void deleteProduct(string mh)
        //{
        //    string sql = "delete HangHoa where MaHang='" + mh + "'";
        //    dal.ExecuteNonQuery(sql);
        //}

    }
}
