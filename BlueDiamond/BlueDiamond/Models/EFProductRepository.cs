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
        public List<Product> Products
        {
            get
            {
                //warto by bylo chyba tworzyc tabele tymczasowe lub robic roznicowke, a nie za kazdym razem odpytywac baze
                List<Category> categories = new List<Category>();
                foreach (var product in context.Products)
                {
                    var productCategories = context.ProductCategories.Where(pc => pc.ProductID == product.ID);
                    var images = context.Images.Where(i => i.ProductID == product.ID);
                    foreach (var productCategory in productCategories)
                    {
                        categories.Add(context.Categories.Where(c => c.ID == productCategory.CategoryID).FirstOrDefault());
                    }
                    foreach (var image in images)
                    {
                        product.Images.Add(image);
                    }
                    product.Categories = new List<Category>();
                    product.Categories.AddRange(categories);
                    categories.Clear();
                }

                return context.Products.ToList();
            }
        }
    }
}
