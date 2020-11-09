﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        // GET: /HelloWorld/
        //public string Index()
        //{
        //    return "This is my default action....";
        //}

        // GET: /HelloWorld/Welcome/

        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}

        // GET: /HelloWorld/Welcome/
        // Requires using System.TExt.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            //return HtmlEncoder.Default.Encode($"Hello {name}, NumTime is: {numTimes}");
            return View();
        }
    }
}
