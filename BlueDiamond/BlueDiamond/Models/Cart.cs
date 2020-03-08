using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDiamond.Models
{
    public class Cart
    {
        private List<OrderPosition> positions = new List<OrderPosition>();
        //public double Sum
        //{
        //    get { return GetSumAmount(); }
        //    set { Sum = value; }
        //}

        //private double GetSumAmount()
        //{
        //    return Positions == null ? 0 : Positions.Select(p => p.Sum).Sum();
        //}

        public virtual void AddItem(Product product, int quantity)
        {
            positions.Add(new OrderPosition { Product = product, Quantity = quantity });
        }
        public virtual IEnumerable<OrderPosition> Positions => positions;

    }
}
