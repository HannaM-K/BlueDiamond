using BlueDiamond.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDiamond.Components
{
    public class NavigationViewComponent : ViewComponent
    {
        private DemoRepository repository;
        public NavigationViewComponent(DemoRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            return View(repository.Products
                .Select(p => p.CategoryID)
                .Distinct()
                .OrderBy(c => c));
        }
    }
}
