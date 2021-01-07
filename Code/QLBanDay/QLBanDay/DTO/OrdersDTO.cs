using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanDay.DTO
{
    class OrdersDTO
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public int Price_total { get; set; }
        public int Status { get; set; }
        public DateTime Created_at { get; set; }
        public int User_id { get; set; }
    }
}
