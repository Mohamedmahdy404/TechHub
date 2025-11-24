using System;
using System.Collections.Generic;
using System.Text;

namespace TechHub.Domain.Enums
{
    public enum OrderStatus: byte
    {
        Unknown,
        Pending,
        Processing,
        Shipped,
        Delivered,
        Cancelled,
        Returned 
    }
}
