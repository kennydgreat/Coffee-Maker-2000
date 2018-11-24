using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coffee_Maker_2000.Models
{
    public class Pressure_Relief_Valve : Pressure_Valve_Interface
    {
        public const int OPEN = 0;
        public const int CLOSE = 1;
        public int state = CLOSE;

        public void openValve() {
            state = CLOSE;
        }
        public void closeValve()
        {
            state = CLOSE;
        }

        public void release_pressure()
        {
            openValve();
        }
    }
}