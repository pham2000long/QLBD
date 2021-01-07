using QLBanDay.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLBanDay.DTO;
using System.Windows.Forms;
using System.Drawing;

namespace QLBanDay.BLL
{
    class usersBLL
    {
        dal dal = new dal();
        int id;
        public bool getUsernamPassword(string usename, string password)
        {
            string sql = "select * from users where username='" + usename + "' AND password='" + password + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            foreach (DataRow row in dt.Rows)
            {
                try
                {
                    this.id = int.Parse(row["id"].ToString());
                }
                catch (Exception x)
                {

                }
                break;
            }
            return dt.Rows.Count == 0 ? false : true;
        }

        public int idUser()
        {
            return this.id;
        }

        public List<UsersDTO> showUser()
        {
            string sql = "select * from users";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            List<UsersDTO> listuser = new List<UsersDTO>();
            foreach (DataRow row in dt.Rows)
            {
                UsersDTO user = new UsersDTO();
                user.ID = int.Parse(row["id"].ToString());
                user.UserName = row["username"].ToString();
                user.Password = row["password"].ToString();
                user.FullName = row["fullname"].ToString();
                user.Gender = row["gender"].ToString();
                user.Phone = row["username"].ToString();
                user.Address = row["address"].ToString();
                user.Email = row["email"].ToString();
                string linkAvatar = row["avatar"].ToString();
                //Bitmap
                Bitmap img;
                try
                {
                    img = new Bitmap(@"" + linkAvatar + "");
                }
                catch (ArgumentException)
                {
                    img = new Bitmap(@"C:\picture\default.jpg");
                }
                user.Avatar = img;
                user.Roles = row["roles"].ToString();
                user.Created_at = row["created_at"].ToString();
                if (row["updated_at"].ToString().Trim() == null)
                {
                    user.Updated_at = "";
                }
                else
                {
                    user.Updated_at = row["updated_at"].ToString();
                }
                listuser.Add(user);
            }
            return listuser;
        }

        public void insertUser(string username, string password, string fullName, string avatar, string gender, string phone, string address, string email, int roles)
        {

            string sql = "insert into users (username,password,fullname,avatar,gender " +
                                                ",phone,address,email,roles" +
                                                ") values(N'" + username + "','" + password + "','" + fullName + "','" + avatar + "'," +
                                                "'" + gender + "','" + phone + "',N'" + address + "','" + email + "',N'" + roles + "')";
            dal.ExecuteNonQuery(sql);
        }

        public void updateUse(int id, string username, string password, string fullName, string avatar, string gender, string phone, string address, string email, int roles)
        {
            string sql = "update users set username=N'" + username + "', password='" + password + "', fullName='" + fullName + "', avatar='" + avatar + "', gender=N'" + gender + "', phone=N'" + phone + "', address=N'" + address + "', email=N'" + email + "', roles=N'" + roles + "'where id='" + id + "'";
            dal.ExecuteNonQuery(sql);
        }

        public void deleteUser(int id)
        {
            string sql = "delete users where id='" + id + "'";
            dal.ExecuteNonQuery(sql);
        }

        public string imageLink(int id)
        {
            string sql = "select avatar from users where id='" + id + "'";
            DataTable dt = dal.GetTable(sql);//loi ko select dc cai gi ca
            return dt.Rows[0].ItemArray[0].ToString();
        }
        public int getrole(int id)
        {
            string sql = "select roles from users where id='" + id + "'";
            DataTable dt = dal.GetTable(sql);//loi ko select dc cai gi ca
            return int.Parse(dt.Rows[0].ItemArray[0].ToString());
        }
    }
}