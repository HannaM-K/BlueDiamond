using BlueDiamond.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDiamond.Controllers
{
    public class CartController : Controller
    {
        private ProductRepository repository;
        private Cart cart;

        public CartController(ProductRepository repo, Cart cartService)
        {
            repository = repo;
            cart = cartService;
        }

        public RedirectToActionResult ShowCart()
        {
            if (cart.Positions.Count() == 0)
            {
                return RedirectToAction("EmptyCart");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public ViewResult EmptyCart()
        {
            return View();
        }

        public ViewResult Index()
        {
            return View(cart);
        }

        public RedirectToActionResult AddToCart(int ID)
        {
            Product product = FindProductByID(ID);
            if (product != null)
            {
                cart.AddItem(product, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromCart(int ID)
        {
            Product product = FindProductByID(ID);
            if (product != null)
            {
                cart.RemoveItem(product);
            }

            return RedirectToAction("ShowCart");
        }

        private Product FindProductByID(int productID)
        {
            return repository.Products.ToList().FirstOrDefault(p => p.ID == productID);
        }
    }
}
