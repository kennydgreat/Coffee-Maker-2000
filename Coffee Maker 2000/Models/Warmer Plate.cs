using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coffee_Maker_2000.Models
{
    public class Warmer_Plate
    {
        public Heating_Element heating_Element;
        public Warmer_Plate_Sensor warmer_Plate_sensor;

        public void Warm_Coffee_Pot() {
            heating_Element.TurnOnElement();
        }

    }
}