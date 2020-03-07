using BlueDiamond.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDiamond.Controllers
{
    public class ProductController : Controller
    {
        private DemoRepository repository;
        public ProductController(DemoRepository repo)
        {
            repository = repo;
        }

        public ViewResult List()
        {
           return View(repository.Products);
        }
    }
}
