using Autofac;
using Autofac.Integration.Mvc;
using IOC_Autofac.Services;
using IOC_Autofac.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace IOC_Autofac
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .AsImplementedInterfaces();
         
            builder.RegisterType<DBLog>().As<ILog>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            #region 三中注册方式
           //1.builder.RegisterType<ArrayList>().As<IEnumerable>();
           //2.builder.RegisterType<SortedList>().Named<IEnumerable>("sort");
           //3.public enum ListType { Array, Sort }
           // builder.RegisterType<ArrayList>().Keyed<IEnumerable>(ListType.Array);   
           // builder.RegisterType<SortedList>().Keyed<IEnumerable>(ListType.Sort);
           #endregion

    }
    }
}
