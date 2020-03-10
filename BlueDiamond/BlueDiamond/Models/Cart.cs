using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDiamond.Models
{
    public class Cart
    {
        private List<OrderPosition> positions = new List<OrderPosition>();
        public double Sum => (Positions == null ? 0 : Positions.Select(p => p.Sum).Sum()); 

        public virtual void AddItem(Product product, int quantity)
        {
            OrderPosition position = positions.FirstOrDefault(p => p.Product.ID == product.ID);

            if (position == null)
            {
                positions.Add(new OrderPosition { Product = product, Quantity = quantity });
            }
            else
            {
                position.Quantity += quantity;
            }
        }
        public virtual IEnumerable<OrderPosition> Positions => positions;

    }
}
