using BlueDiamond.Models;
using BlueDiamond.Models.Interfaces;
using BlueDiamond.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
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
            List<Product> products = null;
            if (TempData.Count() > 0)
            {
                products = JsonConvert.DeserializeObject<List<Product>>(TempData["products"].ToString());
            }
            if (products != null)
            {
                return View(new ProductListViewModel
                {
                    Products = products,
                    CategoryName = "Wszystkie"
                });
            }
            else
            {
                return View(new ProductListViewModel
                {
                    Products = repository.Products.Where(p => categoryName == null || p.Categories.Any(c => c.Name == categoryName)),
                    CategoryName = string.IsNullOrEmpty(categoryName) ? "Wszystkie" : categoryName
                });
            }
        }

        public ViewResult ProductDetails(int ID)
        {
            Product product = FindProductByID(ID);
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FilterProducts(string valueToSearch)
        {
            List<Product> productsToShow = new List<Product>();
            foreach (var product in repository.Products)
            {
                if (product.Name.ToLower().Contains(valueToSearch.ToLower()))
                {
                    productsToShow.Add(product);
                }
            }
            if (productsToShow.Count() > 0)
            {
                TempData["products"] = JsonConvert.SerializeObject(productsToShow);
                return RedirectToAction("List");
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
