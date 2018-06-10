using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Ninject.Modules;
using POSforRestaurants.Logic.Infrastructure;

namespace POSforRestaurants.WebUI.Infrastructure
{
    public class NinjectMapperModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IMapper>().ToMethod(AutoMapper).InSingletonScope();
        }

        private IMapper AutoMapper(Ninject.Activation.IContext context)
        {
            Mapper.Initialize(config =>
            {
                config.ConstructServicesUsing(type => context.Kernel.GetType());

                config.AddProfile(new MappingLogicConfig());
                config.AddProfile(new MappingUIConfig());
            });

            Mapper.AssertConfigurationIsValid(); // optional
            return Mapper.Instance;
        }
    }
}