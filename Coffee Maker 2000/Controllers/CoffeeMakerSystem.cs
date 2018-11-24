using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Coffee_Maker_2000.Controllers
{
    public class CoffeeMakerSystem : Controller
    {

        public ViewResult HomeScreen() {
            return View();
        } 
    }
}