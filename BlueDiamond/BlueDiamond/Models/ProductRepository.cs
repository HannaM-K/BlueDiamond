using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace BlueDiamond.Models
{
    public class ProductRepository
    {
        public IQueryable<Product> Products => new List<Product>() {
            new Product(1, "Etui Iphone Czarne", "Stylowe etui w kolorze czarnym, wykonane z trwałego plastiku.", 25.3, new List<string>{"Iphone", "Nowości"}),
            new Product(2, "Etui Iphone Czerwone", "Stylowe etui w kolorze czerwonym, wykonane z trwałego plastiku.", 19.99, new List<string>{"Iphone", "Nowości"}),
            new Product(3, "Etui Iphone Niebieskie", "Stylowe etui w kolorze niebieskim, wykonane z trwałego plastiku.", 39.99, new List<string>{"Iphone", "Bestsellery"}),
            new Product(4, "Etui Nokia Czarne", "Stylowe etui w kolorze czarnym, wykonane z trwałego plastiku.", 25.0, new List<string>{ "Nokia", "Nowości", "Bestsellery"}),
            new Product(5, "Etui Nokia Czerwone", "Stylowe etui w kolorze czerwonym, wykonane z trwałego plastiku.", 20.0, new List<string>{"Nokia"}),
            new Product(6, "Etui Nokia Niebieskie", "Stylowe etui w kolorze niebieskim, wykonane z trwałego plastiku.", 25.0, new List<string>{"Nokia", "Bestsellery"}),
            new Product(7, "Etui Huawei Czarne", "Stylowe etui w kolorze czarnym, wykonane z trwałego plastiku.", 15.50, new List<string>{"Huawei"}),
            new Product(8, "Etui Huawei Czerwone", "Stylowe etui w kolorze czerwonym, wykonane z trwałego plastiku.", 25.3, new List<string>{"Huawei", "Promocje"}),
            new Product(9, "Etui Huawei Niebieskie", "Stylowe etui w kolorze niebieskim, wykonane z trwałego plastiku.", 25.0, new List<string>{"Huawei"}),
            new Product(10, "Etui Xiaomi Czarne", "Stylowe etui w kolorze czarnym, wykonane z trwałego plastiku.", 19.99, new List<string>{"Xiaomi", "Promocje"}),
            new Product(11, "Etui Xiaomi Czerwone", "Stylowe etui w kolorze czerwonym, wykonane z trwałego plastiku.", 30.50, new List<string>{"Xiaomi"}),
            new Product(12, "Etui Xiaomi Niebieskie", "Stylowe etui w kolorze niebieskim, wykonane z trwałego plastiku.", 20.50, new List<string>{"Xiaomi", "Promocje"}),
            new Product(13, "Etui Samsung Czarne", "Stylowe etui w kolorze czarnym, wykonane z trwałego plastiku.", 12.33, new List<string>{"Samsung"}),
            new Product(14, "Etui Samsung Czerwone", "Stylowe etui w kolorze czerwonym, wykonane z trwałego plastiku.", 14.88, new List<string>{"Samsung"}),
            new Product(15, "Etui Samsung Niebieskie", "Stylowe etui w kolorze niebieskim, wykonane z trwałego plastiku.", 20.50, new List<string>{"Samsung", "Promocje"})
        }.AsQueryable<Product>();
    }
}
