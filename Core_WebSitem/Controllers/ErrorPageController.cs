﻿using Microsoft.AspNetCore.Mvc;

namespace Core_WebSitem.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Error404()
        {
            return View();
        }
    }
}
