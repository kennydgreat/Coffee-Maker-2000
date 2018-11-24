using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coffee_Maker_2000.Models
{
    public class Boiler : Boiler_Interface
    {
        public Heating_Element boiler_heating_Element = new Heating_Element();
        public Boiler_Senor boiler_Senor = new Boiler_Senor();
        public Pressure_Valve_Interface pressure_Valve_Interface = new Pressure_Relief_Valve();

        
        public void startBoiling() {
            boiler_heating_Element.TurnOnElement();
            boiler_Senor.setStateToBoilerNotEmpty();
        }

        public void stopBoiling() {
            boiler_heating_Element.TurnOffElement();
        }

        public void heatWater()
        {
            startBoiling();
            stopBoiling();
        }


    }
}