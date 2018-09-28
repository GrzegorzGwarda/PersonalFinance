using Autofac;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinance.Core.Repositories;
using PersonalFinance.Infrastructure.Repositories;
using PersonalFinance.Infrastructure.EF;

namespace PersonalFinance.Infrastructure.IoC
{
    public class RepoModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>().InstancePerRequest();
            //.InstancePerRequest();
        }
    }
}
