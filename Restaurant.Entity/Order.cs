using System;
using System.Collections.Generic;

namespace Restaurant.Entity
{
    [Serializable]  
    public class Order
    {
        public Guid Id { get; set; }
        public Table Table { get; set; }
        public ICollection<Product> Products { get; set; }
        public Waiter Waiter { get; set; }
    }
}
