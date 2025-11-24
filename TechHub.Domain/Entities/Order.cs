using System;
using System.Collections.Generic;
using System.Text;
using TechHub.Domain.Enums;

namespace TechHub.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; } 
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalAmount { get; set; }
        public List<OrderItem> OrderItems { get; set; }

         
    }
}
