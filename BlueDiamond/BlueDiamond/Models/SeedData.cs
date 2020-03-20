using BlueDiamond.Models.Interfaces;
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

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                   new Category { Name = "Iphone" },
                   new Category { Name = "Nowości" },
                   new Category { Name = "Bestsellery" },
                   new Category { Name = "Nokia" },
                   new Category { Name = "Huawei" },
                   new Category { Name = "Promocje" },
                   new Category { Name = "Xiaomi" },
                   new Category { Name = "Samsung" }
                    );
                context.SaveChanges();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(

                    new Product("Etui Iphone Czarne", "Stylowe etui w kolorze czarnym, wykonane z trwałego plastiku.", 25.3),
                    new Product("Etui Iphone Czerwone", "Stylowe etui w kolorze czerwonym, wykonane z trwałego plastiku.", 19.99),
                    new Product("Etui Iphone Niebieskie", "Stylowe etui w kolorze niebieskim, wykonane z trwałego plastiku.", 39.99),
                    new Product("Etui Nokia Czarne", "Stylowe etui w kolorze czarnym, wykonane z trwałego plastiku.", 25.0),
                    new Product("Etui Nokia Czerwone", "Stylowe etui w kolorze czerwonym, wykonane z trwałego plastiku.", 20.0),
                    new Product("Etui Nokia Niebieskie", "Stylowe etui w kolorze niebieskim, wykonane z trwałego plastiku.", 25.0),
                    new Product("Etui Huawei Czarne", "Stylowe etui w kolorze czarnym, wykonane z trwałego plastiku.", 15.50),
                    new Product("Etui Huawei Niebieskie", "Stylowe etui w kolorze niebieskim, wykonane z trwałego plastiku.", 25.0),
                    new Product("Etui Xiaomi Czarne", "Stylowe etui w kolorze czarnym, wykonane z trwałego plastiku.", 19.99),
                    new Product("Etui Xiaomi Czerwone", "Stylowe etui w kolorze czerwonym, wykonane z trwałego plastiku.", 30.50),
                    new Product("Etui Xiaomi Niebieskie", "Stylowe etui w kolorze niebieskim, wykonane z trwałego plastiku.", 20.50),
                    new Product("Etui Samsung Czarne", "Stylowe etui w kolorze czarnym, wykonane z trwałego plastiku.", 12.33),
                    new Product("Etui Samsung Czerwone", "Stylowe etui w kolorze czerwonym, wykonane z trwałego plastiku.", 14.88),
                    new Product("Etui Samsung Niebieskie", "Stylowe etui w kolorze niebieskim, wykonane z trwałego plastiku.", 20.50)
                    );
                context.SaveChanges();
            }
            if (!context.ProductCategories.Any())
            {
                context.ProductCategories.AddRange(
                      new ProductCategory
                      {
                          ProductID = FindProductID("Etui Iphone Czarne", context),
                          CategoryID = FindCategoryID("Iphone", context)
                      },
                      new ProductCategory
                      {
                          ProductID = FindProductID("Etui Iphone Czarne", context),
                          CategoryID = FindCategoryID("Nowości", context)
                      },
                      new ProductCategory
                      {
                          ProductID = FindProductID("Etui Iphone Czerwone", context),
                          CategoryID = FindCategoryID("Iphone", context)
                      },
                      new ProductCategory
                      {
                          ProductID = FindProductID("Etui Iphone Czerwone", context),
                          CategoryID = FindCategoryID("Nowości", context)
                      },
                      new ProductCategory
                      {
                          ProductID = FindProductID("Etui Iphone Niebieskie", context),
                          CategoryID = FindCategoryID("Iphone", context)
                      },
                      new ProductCategory
                      {
                          ProductID = FindProductID("Etui Iphone Niebieskie", context),
                          CategoryID = FindCategoryID("Bestsellery", context)
                      },
                      new ProductCategory
                      {
                          ProductID = FindProductID("Etui Nokia Czarne", context),
                          CategoryID = FindCategoryID("Nokia", context)
                      },
                       new ProductCategory
                       {
                           ProductID = FindProductID("Etui Nokia Czarne", context),
                           CategoryID = FindCategoryID("Nowości", context)
                       },
                        new ProductCategory
                        {
                            ProductID = FindProductID("Etui Nokia Czarne", context),
                            CategoryID = FindCategoryID("Bestsellery", context)
                        },
                      new ProductCategory
                      {
                          ProductID = FindProductID("Etui Nokia Czerwone", context),
                          CategoryID = FindCategoryID("Nokia", context)
                      },
                      new ProductCategory
                      {
                          ProductID = FindProductID("Etui Nokia Niebieskie", context),
                          CategoryID = FindCategoryID("Nokia", context)
                      },
                      new ProductCategory
                      {
                          ProductID = FindProductID("Etui Nokia Niebieskie", context),
                          CategoryID = FindCategoryID("BestSellery", context)
                      },
                      new ProductCategory
                      {
                          ProductID = FindProductID("Etui Huawei Czarne", context),
                          CategoryID = FindCategoryID("Huawei", context)
                      },
                      new ProductCategory
                      {
                          ProductID = FindProductID("Etui Huawei Czerwone", context),
                          CategoryID = FindCategoryID("Huawei", context)
                      },
                      new ProductCategory
                      {
                          ProductID = FindProductID("Etui Huawei Czerwone", context),
                          CategoryID = FindCategoryID("Bestsellery", context)
                      },
                      new ProductCategory
                      {
                          ProductID = FindProductID("Etui Huawei Niebieskie", context),
                          CategoryID = FindCategoryID("Huawei", context)
                      },
                      new ProductCategory
                      {
                          ProductID = FindProductID("Etui Xiaomi Czarne", context),
                          CategoryID = FindCategoryID("Xiaomi", context)
                      },
                       new ProductCategory
                       {
                           ProductID = FindProductID("Etui Xiaomi Niebieskie", context),
                           CategoryID = FindCategoryID("Xiaomi", context)
                       },
                      new ProductCategory
                      {
                          ProductID = FindProductID("Etui Xiaomi Niebieskie", context),
                          CategoryID = FindCategoryID("Promocje", context)
                      },
                      new ProductCategory
                      {
                          ProductID = FindProductID("Etui Xiaomi Czerwone", context),
                          CategoryID = FindCategoryID("Xiaomi", context)
                      },
                      new ProductCategory
                      {
                          ProductID = FindProductID("Etui Samsung Czarne", context),
                          CategoryID = FindCategoryID("Samsung", context)
                      },
                      new ProductCategory
                      {
                          ProductID = FindProductID("Etui Samsung Czerwone", context),
                          CategoryID = FindCategoryID("Samsung", context)
                      },
                      new ProductCategory
                      {
                          ProductID = FindProductID("Etui Samsung Niebieskie", context),
                          CategoryID = FindCategoryID("Samsung", context)
                      },
                      new ProductCategory
                      {
                          ProductID = FindProductID("Etui Samsung Niebieskie", context),
                          CategoryID = FindCategoryID("Promocje", context)
                      }
                  );
                context.SaveChanges();
            }
        }

        private static Category FindCategory(string categoryName, ApplicationDBContext context)
        {
            var help = context.Categories.Where(c => c.Name == categoryName).FirstOrDefault();
            return help;
        }
        private static int FindCategoryID(string categoryName, ApplicationDBContext context)
        {
            var category = context.Categories.Where(c => c.Name == categoryName).FirstOrDefault();
            return category.ID;
        }
        private static int FindProductID(string productName, ApplicationDBContext context)
        {
            var product = context.Products.Where(p => p.Name == productName).FirstOrDefault();
            return product.ID;
        }
    }
}
