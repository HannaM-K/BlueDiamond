using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDiamond.Models
{
    public class OrderPosition
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Sum => (Quantity * Product.Price);
    }
}
