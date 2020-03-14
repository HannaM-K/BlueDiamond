﻿using BlueDiamond.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDiamond.Components
{
    public class NavigationViewComponent : ViewComponent
    {
        private ProductRepository repository;
        public NavigationViewComponent(ProductRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            return View(repository.Products
                .SelectMany(p => p.CategoryNames.Select(n => n))
                .Distinct()
                .OrderBy(c => c));
        }
    }
}
