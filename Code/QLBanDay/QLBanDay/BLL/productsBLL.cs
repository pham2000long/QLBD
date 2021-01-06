using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanDay.BLL
{
    class productsBLL
    {
        dal dal = new dal();
        public DataTable ShowProduct()
        {
            string sql = "select * from products";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void Insertproduct(string name, string avatar,Int32 price,
            Int32 size,string brand,int color,bool gender,string material,
            Int32 amount,string description,int category_id)
        {
            string sql = "insert into products (name,avatar,price,size,brand " +
                ",color,gender,material ,amount," +
                "description,category_id) values('" + name + "','" + avatar + "','" + price + "','" + size + "'," +
                "'" + brand + "','" + color + "','" + gender + "','" + material + "','" + amount + "','" + description + "','" + category_id + "')";
            dal.ExecuteNonQuery(sql);
        }
        public void Updateproduct(Int32 ma, string name, string avatar, Int32 price,
            Int32 size, string brand, string color, bool gender, string material,
            Int32 amount, string description, string category_id)
        {

            string sql = "update products set name '" + name + "',avatar='" + avatar + "',price='" + price + "',size='" + size + "',brand=" +
                "'" + brand + "',color='" + color + "',gender='" + gender + "',material='" + material + "',amount='" + amount + "',description='" + description + "',category_id='" + category_id + "'" +
                "where id='"+ma+"'";
            dal.ExecuteNonQuery(sql);
        }
        public void Deleteproduct(Int32 ma)
        {
            string sql = "delete products where id= '" + ma + "'";
            dal.ExecuteNonQuery(sql);
        }
    }
}
