using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coffee_Maker_2000.Models
{
    public class Warmer_Plate_Sensor
    {
        public const int  WARMER_EMPTY = 0;
        public const int POT_EMPTY = 1;
        public const int POT_NOT_EMPTY = 2;

        public int state = WARMER_EMPTY ;

        public void setStateToWarmerEmpty() {
            state = POT_EMPTY;
        }

        public void setStatePotEmpty() {
            state = POT_EMPTY;
        }

        public void setStatePotNOTEmpty()
        {
            state = POT_NOT_EMPTY;
        }

    }
}