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
        public EFProductRepository(ApplicationDBContext ctx)
        {
            context = ctx;
        }

        public List<Product> Products => context.Products.ToList();

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
