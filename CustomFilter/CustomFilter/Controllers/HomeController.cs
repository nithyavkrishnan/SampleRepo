﻿using CustomFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomFilter.Controllers
{
    [MyFirstCustomFilter]
    public class HomeController : Controller
    {
        IDependencyRegistrar _dependencyRegistrar;


        public ActionResult Index(LoginModel loginModel)
        {
            return View();
        }

        /*     [HttpPost]
           public ActionResult Index(int id)
           {
               return View();
           }


           public ActionResult About()
           {   
               ViewBag.Message = "Your application description page.";

               return View();
           }

           public ActionResult Contact()
           {
               ViewBag.Message = "Your contact page.";

               return View();
           }
           */
    }
}