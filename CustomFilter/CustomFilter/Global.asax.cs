﻿using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
//using SmartStore.Core;
//using SmartStore.Core.Infrastructure;

namespace CustomFilter
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var builder = new ContainerBuilder();
            builder.RegisterFilterProvider();
            builder.RegisterType<MyFirstCustomFilter>().AsActionFilterFor<Controllers.HomeController>().InstancePerRequest();
          //  builder.RegisterType<MyFirstCustomFilter>().AsActionFilterFor<CustomFilterDemo.Controllers.AccountController>().InstancePerRequest();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }

         
    }
}
