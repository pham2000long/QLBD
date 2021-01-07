using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanDay.DTO
{
    class Order_detailDTO
    {
        public int order_id {get; set;}
        public int product_id {get; set;}
        public string product_name { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
    }
}
