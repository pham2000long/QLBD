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
            string sql = "insert into order_details (order_id, product_id, quantity) values('" + order_id + "','" + product_id + "','" + quantity + "')";
            dal.ExecuteNonQuery(sql);
        }
        public void delete_orderdetail(int order_id)
        {
            string sql = "delete from order_details where order_id='" + order_id + "'";
            dal.ExecuteNonQuery(sql);
        }
    }
}
