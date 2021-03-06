using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Zadanie_praktyczne.Models;

namespace Zadanie_praktyczne.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form()
        {
            ViewBag.Message = "Formularz.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Form(Person person)
        {
            if (ModelState.IsValid)
            {
                return View("Details", person);
            }
            else
            {
                return View("DetailsError", person);
            }
        }
    }
}