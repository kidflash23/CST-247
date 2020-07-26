﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Activity2Part1
{
    public class RouteConfig
    {

        //This is known for being the route for the Test Controller.
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }

            );

            routes.MapRoute(
                name: "Test",
                url: "{Test}",
                defaults: new {controller = "Test", Action = "Index", id = UrlParameter.Optional}
                );
        }
    }
}
