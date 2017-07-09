using FirstWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var Kontakty = new List<Kontakt> (new Kontakt { Imie = "Adam", Nazwisko = "Nowak", Ulica = "Bursztynowa", Miasto = "Lublin" },
                new Kontakt { Imie = "Jan", Nazwisko = "Kowalski", Ulica = "Bursztynowa", Miasto = "Lublin" },
                new Kontakt { Imie = "Roman", Nazwisko = "Sredni", Ulica = "Bursztynowa", Miasto = "Lublin" },
                new Kontakt { Imie = "Roman", Nazwisko = "Sredni", Ulica = "Bursztynowa", Miasto = "Lublin" }
                );
            ViewBag.Kontakty = Kontakty;
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
    }
}