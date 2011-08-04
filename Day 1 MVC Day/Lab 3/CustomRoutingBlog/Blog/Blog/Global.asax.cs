using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Blog.Models;

namespace Blog
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("DateRoute",
                          "blog/{entryDate}",
                          new { Controller = "blog", action = "GetByDate" },
                          new { entryDate = @"\d{2}-\d{2}-\d{4}" });
            
            routes.MapRoute("NumericRoute",
                             "blog/{Id}",
                             new { Controller = "blog", action = "GetById" },
                             new { Id = new IsNumberRouteConstraint() }
                             );

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{*values}", // URL with parameters
                new { controller = "blog", action = "Default", Id = "1" } // Parameter defaults
            );
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}