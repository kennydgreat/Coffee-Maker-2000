﻿using System.Web;
using System.Web.Mvc;

namespace Coffee_Maker_2000
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
