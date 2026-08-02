using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceApp.models
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public int UserId { get; set; }

        
        public User User { get; set; }

        
        public List<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

       
        public Review Review { get; set; }
    }
}
