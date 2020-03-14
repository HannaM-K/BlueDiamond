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
                Products = repository.Products.Where(p => categoryNames == null || p.CategoryNames.Exists(c => c == categoryNames)),
                CategoryNames = categoryNames == null ? "Wszystkie" : categoryNames
            });
        }

        public ViewResult ProductDetails(int ID)
        {
            Product product = FindProductByID(ID);
            return View(product);
        }
        private Product FindProductByID(int productID)
        {
            return repository.Products.ToList().FirstOrDefault(p => p.ID == productID);
        }
    }
}
