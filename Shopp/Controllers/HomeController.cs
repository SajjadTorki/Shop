﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Shopp.Controllers
{
   

    public class HomeController : Controller
    {

        public IActionResult Index()
        {

            return View();
        }

       
    }
}
