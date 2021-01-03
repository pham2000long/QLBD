using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanDay.DTO
{
    class CategoriesDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public int Description { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
    }
}
