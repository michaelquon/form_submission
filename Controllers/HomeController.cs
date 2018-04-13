﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using form.Models;

namespace form.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
        
            return View("Index");
        }
        [HttpPost]
        [Route("Register")]
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                return View("Register");
            }
            else
            {
                return View("Index");
            }
        }

    }
}
