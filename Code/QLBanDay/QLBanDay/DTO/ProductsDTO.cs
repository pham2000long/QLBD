using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace QLBanDay.DTO
{
    class ProductsDTO
    {

            public int id{get; set;}
            public string name{get; set;}
            public string avatar{get; set;}
            public int price {get; set;}
            public int size {get; set;}
            public string brand{get; set;}
            public string color{get; set;}
            public string gender{get; set;}
            public int amount{get; set;}
            public string description{get; set;}
            public string created_at{get; set;}
            public string updated_at {get; set;}
            public int category_id{get; set;}
    }
}
