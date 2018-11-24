using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Coffee_Maker_2000.Models
{
    public class Coffee
    {
        [Required(ErrorMessage = "You missed Water!")]
        public bool? Water { set; get; }
            
        [Required(ErrorMessage = "You missed Coffee Beans!")]
        public bool? CoffeeBeans { set; get; }
    }
}