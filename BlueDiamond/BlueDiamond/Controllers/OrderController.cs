using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueDiamond.Controllers
{
    public class OrderController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
