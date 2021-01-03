using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanDay.DTO
{
    class ProductsDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public int Price { get; set; }
        public int Size { get; set; }
        public string Brand { get; set; }
        public int Color { get; set; }
        public bool Gender { get; set; }
        public int Amount { get; set; }
        public string Summary { get; set; }
        public int Description { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public int Category_id { get; set; }
    }
}
