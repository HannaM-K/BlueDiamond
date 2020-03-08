using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDiamond.Models
{
    public class OrdersRepository
    {
        public List<Order> Orders { get; set; }

        public OrdersRepository()
        {
            Orders = new List<Order>();
        }
    }
}
