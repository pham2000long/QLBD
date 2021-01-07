using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanDay.BLL
{
    class ordersBLL
    {
        dal dal = new dal();
        public DataTable Showorder()
        {
            string sql = "select * from orders";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void Insertorder(string fullname, string gender, Int32 phone,
            string address, string email, string note,int price_total, //X price_total update csdl
            Int32 status, int user_id)//X avatar??? update csdl
        {
            string sql = "insert into orders (fullname,gender,phone,address,email " +
                ",note,price_total,status,user_id)" +
                " values('" + fullname + "','" + gender + "','" + phone + "','" + address + "'," +
                "'" + email + "','" + note + "','"+ price_total + "','" + status + "','" + user_id + "')";
            dal.ExecuteNonQuery(sql);
        }
        public void tongtien(int id,int tongtien)
        {
            string sql= "update oreders set tongtien='"+ tongtien + "' where id='"+id+"'";
        }
        public void Updateorder(int ma,string fullname, string gender, Int32 phone,
            string address, string email, string note, Int32 price_total, //X price_total update csdl
            Int32 status, int user_id)//X avatar??? update csdl
        {

            string sql = "update orders set fullname '" + fullname + "',gender='" + gender + "',phone='" + phone + "'," +
            "address='" + address + "',email='" + email + "',note='" + note + "'," +
            "price_total='" + price_total + "',status='" + status + "',user_id='" + user_id + "'" +
                "where id='" + ma + "'";
            dal.ExecuteNonQuery(sql);
        }
        public void Deleteorder(Int32 ma)
        {
            string sql = "delete orders where id= '" + ma + "'";
            dal.ExecuteNonQuery(sql);
        }
        public int getid()
        {
            string sql = "select max(id) from orders";
            DataTable dt = dal.GetTable(sql);
            return int.Parse(dt.Rows[0].ItemArray[0].ToString());
                
        }
    }
}