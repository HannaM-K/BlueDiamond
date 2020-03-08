using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace BlueDiamond.Models
{
    public class ProductRepository
    {
        private int idCount = 0;

        public IQueryable<Product> Products => new List<Product>() {
            new Product(++idCount, "Etui Iphone Czarne", "Stylowe etui w kolorze czarnym, wykonane z trwałego plastiku.", 25.3, "Iphone"),
            new Product(++idCount, "Etui Iphone Czerwone", "Stylowe etui w kolorze czerwonym, wykonane z trwałego plastiku.", 19.99, "Iphone"),
            new Product(++idCount, "Etui Iphone Niebieskie", "Stylowe etui w kolorze niebieskim, wykonane z trwałego plastiku.", 39.99, "Iphone"),
            new Product(++idCount, "Etui Nokia Czarne", "Stylowe etui w kolorze czarnym, wykonane z trwałego plastiku.", 25.0, "Nokia"),
            new Product(++idCount, "Etui Nokia Czerwone", "Stylowe etui w kolorze czerwonym, wykonane z trwałego plastiku.", 20.0, "Nokia"),
            new Product(++idCount, "Etui Nokia Niebieskie", "Stylowe etui w kolorze niebieskim, wykonane z trwałego plastiku.", 25.0, "Nokia"),
            new Product(++idCount, "Etui Huawei Czarne", "Stylowe etui w kolorze czarnym, wykonane z trwałego plastiku.", 15.50, "Huawei"),
            new Product(++idCount, "Etui Huawei Czerwone", "Stylowe etui w kolorze czerwonym, wykonane z trwałego plastiku.", 25.3, "Huawei"),
            new Product(++idCount, "Etui Huawei Niebieskie", "Stylowe etui w kolorze niebieskim, wykonane z trwałego plastiku.", 25.0, "Huawei"),
            new Product(++idCount, "Etui Xiaomi Czarne", "Stylowe etui w kolorze czarnym, wykonane z trwałego plastiku.", 19.99, "Xiaomi"),
            new Product(++idCount, "Etui Xiaomi Czerwone", "Stylowe etui w kolorze czerwonym, wykonane z trwałego plastiku.", 30.50, "Xiaomi"),
            new Product(++idCount, "Etui Xiaomi Niebieskie", "Stylowe etui w kolorze niebieskim, wykonane z trwałego plastiku.", 20.50, "Xiaomi"),
            new Product(++idCount, "Etui Samsung Czarne", "Stylowe etui w kolorze czarnym, wykonane z trwałego plastiku.", 12.33, "Samsung"),
            new Product(++idCount, "Etui Samsung Czerwone", "Stylowe etui w kolorze czerwonym, wykonane z trwałego plastiku.", 14.88, "Samsung"),
            new Product(++idCount, "Etui Samsung Niebieskie", "Stylowe etui w kolorze niebieskim, wykonane z trwałego plastiku.", 20.50, "Samsung")
        }.AsQueryable<Product>();
    }
}
