﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Progra_web_3_Tp_final.Controllers
{
    public class ArticulosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NuevoArticulo()
        {
            return View();
        }

    }
}
