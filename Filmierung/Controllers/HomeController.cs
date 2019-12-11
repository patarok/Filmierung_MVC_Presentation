using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filmierung.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Warum FILMIERUNG?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Unsere Kontaktdaten.";

            return View();
        }

        public ActionResult Administrate()
        {
            ViewBag.Message = "Verwaltung der Filme.";

            return View();
        }

    }
}