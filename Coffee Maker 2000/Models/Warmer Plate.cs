using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coffee_Maker_2000.Models
{
    public class Warmer_Plate : Warm_Plate_Interface
    {
        public Heating_Element warmer_heating_Element = new Heating_Element();
        public Warmer_Plate_Sensor warmer_Plate_sensor = new Warmer_Plate_Sensor();

        public void warm_Coffee_Pot() {
            warmer_heating_Element.TurnOnElement();
            warmer_Plate_sensor.setStatePotNOTEmpty();

        }
        public void keepCoffeePotWarm()
        {
            warm_Coffee_Pot();
        }



    }
}