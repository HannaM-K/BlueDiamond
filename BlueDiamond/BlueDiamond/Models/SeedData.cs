using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Builder.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDiamond.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDBContext context = app.ApplicationServices.GetRequiredService<ApplicationDBContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                        new Product("Etui Iphone Czarne", "Stylowe etui w kolorze czarnym, wykonane z trwałego plastiku.", 25.3, new List<Category> { new Category { Name = "Iphone" }, new Category { Name = "Nowości" } }),
                        new Product("Etui Iphone Czerwone", "Stylowe etui w kolorze czerwonym, wykonane z trwałego plastiku.", 19.99, new List<Category> { new Category { Name = "Iphone" }, new Category { Name = "Nowości" } }),
                        new Product("Etui Iphone Niebieskie", "Stylowe etui w kolorze niebieskim, wykonane z trwałego plastiku.", 39.99, new List<Category> { new Category { Name = "Iphone" }, new Category { Name = "Bestsellery" } }),
                        new Product("Etui Nokia Czarne", "Stylowe etui w kolorze czarnym, wykonane z trwałego plastiku.", 25.0, new List<Category> { new Category { Name = "Nokia" }, new Category { Name = "Nowości" }, new Category { Name = "Bestsellery" } }),
                        new Product("Etui Nokia Czerwone", "Stylowe etui w kolorze czerwonym, wykonane z trwałego plastiku.", 20.0, new List<Category> { new Category { Name = "Nokia" } }),
                        new Product("Etui Nokia Niebieskie", "Stylowe etui w kolorze niebieskim, wykonane z trwałego plastiku.", 25.0, new List<Category> { new Category { Name = "Nokia" }, new Category { Name = "Bestsellery" } }),
                        new Product("Etui Huawei Czarne", "Stylowe etui w kolorze czarnym, wykonane z trwałego plastiku.", 15.50, new List<Category> { new Category { Name = "Huawei" } }),
                        new Product("Etui Huawei Czerwone", "Stylowe etui w kolorze czerwonym, wykonane z trwałego plastiku.", 25.3, new List<Category> { new Category { Name = "Huawei" }, new Category { Name = "Promocje" } }),
                        new Product("Etui Huawei Niebieskie", "Stylowe etui w kolorze niebieskim, wykonane z trwałego plastiku.", 25.0, new List<Category> { new Category { Name = "Huawei" } }),
                        new Product("Etui Xiaomi Czarne", "Stylowe etui w kolorze czarnym, wykonane z trwałego plastiku.", 19.99, new List<Category> { new Category { Name = "Xiaomi" }, new Category { Name = "Promocje" } }),
                        new Product("Etui Xiaomi Czerwone", "Stylowe etui w kolorze czerwonym, wykonane z trwałego plastiku.", 30.50, new List<Category> { new Category { Name = "Xiaomi" } }),
                        new Product("Etui Xiaomi Niebieskie", "Stylowe etui w kolorze niebieskim, wykonane z trwałego plastiku.", 20.50, new List<Category> { new Category { Name = "Xiaomi" }, new Category { Name = "Promocje" } }),
                        new Product("Etui Samsung Czarne", "Stylowe etui w kolorze czarnym, wykonane z trwałego plastiku.", 12.33, new List<Category> { new Category { Name = "Samsung" } }),
                        new Product("Etui Samsung Czerwone", "Stylowe etui w kolorze czerwonym, wykonane z trwałego plastiku.", 14.88, new List<Category> { new Category { Name = "Samsung" } }),
                        new Product("Etui Samsung Niebieskie", "Stylowe etui w kolorze niebieskim, wykonane z trwałego plastiku.", 20.50, new List<Category> { new Category { Name = "Samsung" }, new Category { Name = "Promocje" } })
                        );
                context.SaveChanges();
            }
        }
    }
}
