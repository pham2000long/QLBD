using QLBanDay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanDay.BLL
{
    class productsBLL
    {
        dal dal = new dal();
        public List<ProductsDTO> ShowProduct()
        {
            string sql = "select * from products";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            List<ProductsDTO> listproduct = new List<ProductsDTO>();
            foreach (DataRow row in dt.Rows)
            {
                ProductsDTO product = new ProductsDTO();
                product.id = int.Parse(row["id"].ToString());
                //category.ID = int.Parse(dt.Rows[i].ItemArray[0].ToString());
                product.name = row["name"].ToString();
                product.avatar = row["avatar"].ToString();
                product.price = int.Parse(row["price"].ToString());
                product.size = int.Parse(row["size"].ToString());
                product.brand = row["brand"].ToString();
                product.color = row["color"].ToString();
                //string[] color = row["color"].ToString().Split(',').ToArray();
                //product.color = Color.FromArgb(int.Parse(color[0]), int.Parse(color[1]), int.Parse(color[2]), int.Parse(color[3]));
                //product.color.BackColor = Color.FromArgb(int.Parse(color[0]), int.Parse(color[1]), int.Parse(color[2]), int.Parse(color[3]));
                product.gender = row["gender"].ToString();
                product.amount = int.Parse(row["amount"].ToString());
                product.description = row["description"].ToString();
                product.created_at = row["created_at"].ToString();
                
                if(row["updated_at"].ToString().Trim() == null)
                {
                    product.updated_at = "";
                } else
                {
                    product.updated_at = row["updated_at"].ToString();
                }
                product.category_id = int.Parse(row["category_id"].ToString());
                listproduct.Add(product);
            }
            return listproduct;
        }
        public void Insertproduct(string name, string avatar,Int32 price,
            Int32 size,string brand,string color,string gender,
            Int32 amount,string description,int category_id)
        {
            string sql = "insert into products (name,avatar,price,size,brand " +
                ",color,gender,amount," +
                "description,category_id) values('" + name + "','" + avatar + "','" + price + "','" + size + "'," +
                "'" + brand + "','" + color + "','" + gender + "','" + amount + "','" + description + "','" + category_id + "')";
            dal.ExecuteNonQuery(sql);
        }
        public void Updateproduct(Int32 ma, string name, string avatar, Int32 price,
            Int32 size, string brand, string color, string gender,
            Int32 amount, string description, int category_id)
        {

            string sql = "update products set name='" + name + "',avatar='" + avatar + "',price='" + price + "',size='" + size + "',brand=" +
                "'" + brand + "',color='" + color + "',gender='" + gender + "',amount='" + amount + "',description='" + description + "',category_id='" + category_id + "'" +
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
