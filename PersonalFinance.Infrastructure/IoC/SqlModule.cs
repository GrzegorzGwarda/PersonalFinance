using Autofac;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalFinance.Infrastructure.Services;
using PersonalFinance.Infrastructure.EF;

namespace PersonalFinance.Infrastructure.IoC
{
    public class SqlModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FinanceContext>().InstancePerRequest();
        }
    }
}
