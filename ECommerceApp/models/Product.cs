using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceApp.models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

    }
}
