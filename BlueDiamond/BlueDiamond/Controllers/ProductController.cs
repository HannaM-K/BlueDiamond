using BlueDiamond.Models;
using BlueDiamond.Models.Interfaces;
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
        private IProductRepository repository;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(string categoryName)
        {
            return View(new ProductListViewModel
            {
                Products = repository.Products.Where(p => categoryName == null || p.Categories.Any(c => c.Name == categoryName)),
                CategoryNames = categoryName == null ? "Wszystkie" : categoryName
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
