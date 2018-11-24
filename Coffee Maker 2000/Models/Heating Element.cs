using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coffee_Maker_2000.Models
{
    public class Heating_Element
    {
        private bool elementOn = false;

        /// <summary>
        /// sets the elementOn variable to false
        /// </summary>
        public void TurnOffElement()
        {
            elementOn = false;
        }
        /// <summary>
        /// Sets elementOn variable to true
        /// </summary>
        public void TurnOnElement()
        {
            elementOn = true;
        }
    }
}