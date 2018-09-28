using Autofac;
using Autofac.Integration.Mvc;
using PersonalFinance.Infrastructure.IoC;
using PersonalFinance.Infrastructure.Repositories;
using PersonalFinance.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalFinance.App_Start
{
    public static class AutoFacConfigurate
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterAssemblyModules(typeof(MvcApplication).Assembly);
            builder.RegisterModule<RepoModule>();
            builder.RegisterModule<ServiceModule>();
            builder.RegisterModule<SqlModule>();
            builder.RegisterModule<MapperModule>();
            

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}