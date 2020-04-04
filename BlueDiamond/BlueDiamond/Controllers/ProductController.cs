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
               var productIDs = JsonConvert.DeserializeObject<List<int>>(TempData["productIDs"].ToString());
                products = new List<Product>();
                foreach (var productID in productIDs)
                {
                    products.Add(repository.Products.Single(p => p.ID == productID));
                }
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

        [HttpGet("imageFile")]
        public async Task<IActionResult> GetImageFile(int productID, bool horizontal = false)
        {
            var imageBytes = repository.Products.Single(p => p.ID == productID).Images.Single(i => i.Type == (horizontal ? 1 : 0)).Img;
            return File(imageBytes, "image/png");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FilterProducts(string valueToSearch)
        {
            List<int> productIDs = new List<int>();
            foreach (var product in repository.Products)
            {
                if (product.Name.ToLower().Contains(valueToSearch.ToLower()))
                {
                    productIDs.Add(product.ID);
                }
            }
            if (productIDs.Count() > 0)
            {
                TempData["productIDs"] = JsonConvert.SerializeObject(productIDs);
                return RedirectToAction("List", "Product");
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
