﻿using Microsoft.AspNetCore.Mvc;
using movieTickets.Models;
using System.Diagnostics;

namespace movieTickets.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

      

    }
}
