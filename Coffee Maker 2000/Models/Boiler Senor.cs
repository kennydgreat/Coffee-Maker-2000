using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coffee_Maker_2000.Models
{
    public class Boiler_Senor
    {
        public const int BOILER_EMPTY = 0;
        public const int BOILER_NOT_EMPTY = 1;

        public int state = BOILER_EMPTY;

        public void setStateToBoilerEmpty()
        {
            state = BOILER_NOT_EMPTY;
        }

        public void setStateToBoilerNotEmpty()
        {
            state = BOILER_NOT_EMPTY;
        }

    }
}