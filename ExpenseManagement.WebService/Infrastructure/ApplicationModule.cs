using Autofac;
using ExpenseManagement.Business;
using ExpenseManagement.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseManagement.WebService.Infrastructure
{
    public class ApplicationModule : Autofac.Module
    {
        public ApplicationModule()
        {

        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<IItemService>()
                 .As<ItemService>()
                 .SingleInstance();
        }
    }
}
