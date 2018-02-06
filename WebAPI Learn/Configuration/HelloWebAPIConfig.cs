using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPI_Learn.Configuration
{
    public  static class HelloWebAPIConfig
    {
        public  static void Register(HttpConfiguration config)
        {
            //web api router
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name:"DefaultApi",
                routeTemplate:"api/{controller}/{id}",
                defaults:new { id = RouteParameter.Optional }

                );
        }
    }
}