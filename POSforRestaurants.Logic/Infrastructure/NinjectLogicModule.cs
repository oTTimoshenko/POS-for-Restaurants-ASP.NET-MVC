using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using POSforRestaurants.Logic.Interfaces;
using POSforRestaurants.Logic.Services;

namespace POSforRestaurants.Logic.Infrastructure
{
    public class NinjectLogicModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IAdminService>().To<AdminService>();
            Bind<IUserService>().To<UserService>();
            Bind<IWaiterService>().To<WaiterService>();
        }
    }
}
