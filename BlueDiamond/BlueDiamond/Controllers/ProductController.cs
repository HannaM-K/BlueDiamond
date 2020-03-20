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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FilterProducts(string productSearch)
        {
            var productID = 0;
            //to nie jest potrzebne, trzeba zrobic akcje List ktora przyjmie tylko parametr produktu czy cos
            if (repository.Products.Exists(p => p.Name == productSearch))
            {
                productID = repository.Products.Where(p => p.Name == productSearch).FirstOrDefault().ID;
                return RedirectToAction("ProductDetails", new { ID = productID });
            }
            else
            {
                return NoContent();
            }
        }

        private Product FindProductByID(int productID)
        {
            return repository.Products.ToList().FirstOrDefault(p => p.ID == productID);
        }
    }
}
