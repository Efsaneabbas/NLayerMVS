﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace NLayerMVS.Controllers
{
    public class HomeController : Controller
    {
      

        public IActionResult Index()
        {
            return View();
        }

        
    }
}
