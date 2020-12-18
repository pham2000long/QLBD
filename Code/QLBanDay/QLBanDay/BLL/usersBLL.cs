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
       
        public bool getUsernamPassword(string usename, string password)
        {
            string sql = "select * from users where username='"+usename+ "' AND password='"+password+"'";
            DataTable dt = new DataTable();
            dt = dal.GetTable(sql);
            return dt.Rows.Count == 0 ? false : true;
        }

    }
}
