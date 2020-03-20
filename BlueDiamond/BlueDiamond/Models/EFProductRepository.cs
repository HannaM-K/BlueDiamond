using BlueDiamond.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDiamond.Models
{
    public class EFProductRepository : IProductRepository
    {
        private ApplicationDBContext context;
        private List<Product> products;
        public EFProductRepository(ApplicationDBContext ctx)
        {
            context = ctx;
        }
        //tu moglabym zrobic taki mechanizm "różnicówki", że za każdym razem przy pobraniu stąd produktów
        //byłoby sprawdzanie czy data modyfikacji ostatniego rekordu sie zmienila, jesli tak, to uzupelnianie kategorii musialoby się odbyć na nowo
        //albo może lepiej tylko zmodyfikowanych rekordów
        //tak więc zrobie tu nie pobieranie z contextu tylko zostawię tu zmienną przechowującą.

        public List<Product> Products
        {
            get
            {
                List<Category> categories = new List<Category>();
                foreach (var product in context.Products)
                {
                    var productCategories = context.ProductCategories.Where(pc => pc.ProductID == product.ID);
                    foreach (var productCategory in productCategories)
                    {
                        categories.Add(context.Categories.Where(c => c.ID == productCategory.CategoryID).FirstOrDefault());
                    }
                    product.Categories = new List<Category>();
                    product.Categories.AddRange(categories);
                    categories.Clear();
                }

                return context.Products.ToList();
            }
        }

        //public Product DeleteProduct(int productID)
        //{
        //    throw new NotImplementedException();
        //}

        //public void SaveProduct(Product product)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
