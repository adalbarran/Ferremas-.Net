﻿using System.Web.Mvc;

namespace transbanksdkdotnetrestexample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Transbank .Net SDK";
            return View();
        }

        public ActionResult Carrito()
        {
            ViewBag.Title = "Transbank .Net SDK";
            return View();
        }
    }
}