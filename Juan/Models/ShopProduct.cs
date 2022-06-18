using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Models
{
    public class ShopProduct
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
    }
}
