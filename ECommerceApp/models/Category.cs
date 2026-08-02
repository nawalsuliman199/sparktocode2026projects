using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceApp.models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
