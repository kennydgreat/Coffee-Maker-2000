using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Coffee_Maker_2000.Models
{
    public class BrewButton : Brew_Button_Interface
    {
        public bool? Brew;
        public IndicatorLight indicatorLight = new IndicatorLight();

        public void brew() {
            indicatorLight.TurnOnElement();
        }

        public void pressBrewButton()
        {
            brew();
        }
    }
}