using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Coffee_Maker_2000.Models
{
    public class BrewButton
    {
        public bool? Brew;
        public IndicatorLight IndicatorLight;

        public BrewButton() {
            IndicatorLight = new IndicatorLight();
        }
    }
}