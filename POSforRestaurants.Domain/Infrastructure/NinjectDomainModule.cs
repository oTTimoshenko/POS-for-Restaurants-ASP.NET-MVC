using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using POSforRestaurants.Domain.UoWandRepositories.Interfaces;
using POSforRestaurants.Domain.UoWandRepositories.Realization;

namespace POSforRestaurants.Domain.Infrastructure
{
    public class NinjectDomainModule:NinjectModule
    {
        private string ConnectionString;

        public NinjectDomainModule(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }

        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>().WithConstructorArgument("connectionString", ConnectionString);
        }
    }
}
