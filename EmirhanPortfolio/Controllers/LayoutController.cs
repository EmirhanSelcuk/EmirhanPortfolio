﻿using Microsoft.AspNetCore.Mvc;

namespace EmirhanPortfolio.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
