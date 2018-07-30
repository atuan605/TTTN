using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MotorbikesShop
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "DangKy",
                url: "dang-ky",
                defaults: new { controller = "LoginUser", action = "DangKy", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "TimKiem",
                url: "tim-kiem",
                defaults: new { controller = "SanPhams", action = "TimKiem", id = UrlParameter.Optional }
            );
        }
    }
}
