using QLBanDay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanDay.BLL
{
    class categoryBLL
    {
        dal dal = new dal();
        public DataTable ShowCategory()
        {
            string sql = "select * from categories";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public List<CategoriesDTO> categories()
        {
            List<CategoriesDTO> a=new List<CategoriesDTO>();
            string sql = "select * from categories";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var category = new CategoriesDTO();
                category.ID= int.Parse(dt.Rows[i].ItemArray[0].ToString());
                category.Name = dt.Rows[i].ItemArray[1].ToString();
                a.Add(category);
            }
                return a;
        }
        public void InsertCategory(string Name, string Description)
        {
            string sql = "insert into categories ( name, description ) values('" + Name + "','" + Description + "')";
            dal.ExecuteNonQuery(sql);
        }
        public void UpdateCategory(Int32 ma,string Name, string Description)
        {
            string sql = "update categories set name = '" + Name + "',description = '" + Description + "' where id='" + ma + "'";
            dal.ExecuteNonQuery(sql);
        }
        public void DeleteCategory(Int32 ma)
        {
            string sql = "delete categories where id= '" + ma + "'";
            dal.ExecuteNonQuery(sql);
        }
        public int getID(string ten)
        {
            string sql = "select ID from categories where name='" + ten + "'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return int.Parse(dt.Rows[0].ItemArray[0].ToString());
        }
    }
}
