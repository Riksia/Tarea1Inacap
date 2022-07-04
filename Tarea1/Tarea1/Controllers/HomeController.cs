﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarea1.Models;

namespace Tarea1.Controllers
{
    public class HomeController : Controller
    {
        private Models.tarea_1Entities1 contextoDatos;

        HomeController()
        {
            contextoDatos = new tarea_1Entities1();
        }
        public ActionResult Index()
        {
            var productos = contextoDatos.producto.ToList();
            return View(productos);
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
    }
}