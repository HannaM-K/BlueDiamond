using BlueDiamond.Models;
using BlueDiamond.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDiamond.Components
{
    public class NavigationViewComponent : ViewComponent
    {
        private IProductRepository repository;
        public NavigationViewComponent(IProductRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            return View(repository.Products
                .SelectMany(p => p.Categories.Select(n => n))
                .Distinct()
                .OrderBy(c => c));
        }
    }
}
