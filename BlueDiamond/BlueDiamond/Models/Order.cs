using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDiamond.Models
{
    public class Order
    {
        public int ID { get; set; }
        public List<OrderPosition> OrderPositions { get; set; }
    }
}
