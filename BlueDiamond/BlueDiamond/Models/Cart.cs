﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDiamond.Models
{
    public class Cart
    {
        public List<OrderPosition> Positions = new List<OrderPosition>();
        public double Sum
        {
            get { return GetSumAmount(); }
            set { Sum = value; }
        }
        //public Order()
        //{
        //    Positions = new List<OrderPosition>();
        //}
        //public double DeliveryPrice { get; set; }

        private double GetSumAmount()
        {
            return Positions == null ? 0 : Positions.Select(p => p.Sum).Sum();
        }

        public virtual void AddItem(Product product, int quantity)
        {
           Positions.Add(new OrderPosition { Product = product, Quantity = quantity });
        }
    }
}
