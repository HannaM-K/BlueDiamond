using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDiamond.Models
{
    public class Order
    {
        public List<OrderPosition> Positions { get; set; }
        public double Sum
        {
            get { return GetSumAmount(); }
            set { Sum = value; }
        }
        public Order()
        {
            Positions = new List<OrderPosition>();
        }
        //public double DeliveryPrice { get; set; }

        private double GetSumAmount()
        {
            return Positions == null ? 0 : Positions.Select(p => p.Sum).Sum();
        }
    }
}
