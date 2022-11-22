using System;
using System.Collections.Generic;

namespace StoreWebApi2.Models
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            CustomerOrder = new HashSet<CustomerOrder>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CustomerOrder> CustomerOrder { get; set; }
    }
}
