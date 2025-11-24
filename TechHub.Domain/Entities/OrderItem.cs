using System;
using System.Collections.Generic;
using System.Text;

namespace TechHub.Domain.Entities
{
    public class OrderItem
    {
        
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}

