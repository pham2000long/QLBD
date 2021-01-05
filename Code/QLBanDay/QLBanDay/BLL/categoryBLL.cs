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
    }
}
