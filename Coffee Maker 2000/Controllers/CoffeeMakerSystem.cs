using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Coffee_Maker_2000.Models;

namespace Coffee_Maker_2000.Controllers
{
    public class CoffeeMakerSystem : Controller
    {
        public Brew_Button_Interface brewButton = new BrewButton() ;
        public ViewResult HomeScreen() {
            return View();
        } 
    }
}