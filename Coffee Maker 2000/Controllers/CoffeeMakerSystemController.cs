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
        public Boiler_Interface boiler = new Boiler();
        public Pressure_Valve_Interface pressure_Valve = new Pressure_Relief_Valve();
        public Warm_Plate_Interface warmer_Plate = new Warmer_Plate();

        [HttpGet]
        public ActionResult Index() {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Coffee coffeeOptionResponse)
        {
            if (ModelState.IsValid)
            {
                brewButton.pressBrewButton();
                return View("StartBrewProcess");
            }
            else
            {
                //there is a validation error
                return View();
            }
        }

        public ViewResult StartBrewProcess() {
            boiler.heatWater();
           return View();
           
        }

        public ViewResult HeatingCoffee() {
            return View();
        }

        public ViewResult PouringCoffee()
        {
            return View();
        }

        public ViewResult CoffeeReady() {
            pressure_Valve.release_pressure();
            warmer_Plate.keepCoffeePotWarm();
            return View();
        }

    }
}