using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QLBanDay.BLL
{
    class order_detailBLL
    {
        dal dal = new dal();
        public DataTable Showorder()
        {
            string sql = "select * from order_details";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt;
        }
        public void insert_order_detail(int order_id,int product_id,int quantity)
        {
            string sql = "insert into orders (order_id, product_id, quantity) values('" + order_id + "','" + product_id + "','" + quantity + "')";
            dal.ExecuteNonQuery(sql);
        }
    }
}
