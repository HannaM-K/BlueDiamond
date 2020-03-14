using BlueDiamond.Models;
using BlueDiamond.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDiamond.Controllers
{
    public class ProductController : Controller
    {
        private ProductRepository repository;
        public ProductController(ProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(string categoryNames)
        {
            return View(new ProductListViewModel
            {
                Products = repository.Products.Where(p => categoryNames == null || p.categoryNames.Exists(c => c == categoryNames)),
                categoryNames = categoryNames == null ? "Wszystkie" : categoryNames
            });
        }

        public ViewResult ProductDetails(int productID)
        {
            return View(productID);
        }
    }
}
