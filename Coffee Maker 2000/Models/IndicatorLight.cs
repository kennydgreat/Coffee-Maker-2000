using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coffee_Maker_2000.Models
{
    public class IndicatorLight
    {
        private bool lightOn = false;

        /// <summary>
        /// sets the lightOn variable to false
        /// </summary>
        public void TurnLightOff()
        {
            //throw new System.Exception("Not implemented");
            lightOn = false;
        }
        /// <summary>
        /// sets lightOn variable to true
        /// </summary>
        public void TurnOnElement()
        {
            lightOn = true;
        }
    }
}