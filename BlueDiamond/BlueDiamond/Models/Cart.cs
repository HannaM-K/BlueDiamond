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
        public virtual IEnumerable<OrderPosition> Positions => positions;

        public virtual void AddItem(Product product, int quantity)
        {
            OrderPosition position = FindPositionByID(product.ID);

            if (position == null)
            {
                positions.Add(new OrderPosition { Product = product, Quantity = quantity });
            }
            else
            {
                position.Quantity += quantity;
            }
        }

        private OrderPosition FindPositionByID(int ID)
        {
            return positions.FirstOrDefault(p => p.Product.ID == ID);
        }
        
        public virtual void RemoveItem(Product product)
        {
            var position = FindPositionByID(product.ID);
            if (position != null)
            {
                positions.Remove(position);
            }
        }

        public virtual void Clear()
        {
            positions.Clear();
        }
    }
}
