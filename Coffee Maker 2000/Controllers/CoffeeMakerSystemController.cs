using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Coffee_Maker_2000.Models;

namespace Coffee_Maker_2000.Controllers
{
    public class CoffeeMakerSystemController : Controller
    {
        public Brew_Button_Interface brewButton = new BrewButton() ;

        public ActionResult Index() {
            return View();
        }

        public ViewResult Brew() {
            return View();
        }
    }
}