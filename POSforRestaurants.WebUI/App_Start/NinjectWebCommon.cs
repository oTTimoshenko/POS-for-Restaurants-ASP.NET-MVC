[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(POSforRestaurants.WebUI.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(POSforRestaurants.WebUI.App_Start.NinjectWebCommon), "Stop")]

namespace POSforRestaurants.WebUI.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Modules;
    using Ninject.Web.Common;
    using Ninject.Web.Mvc;
    using POSforRestaurants.Domain.Infrastructure;
    using POSforRestaurants.Logic.Infrastructure;
    using POSforRestaurants.WebUI.Infrastructure;

    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            NinjectLogicModule logicModule = new NinjectLogicModule();
            NinjectDomainModule domainModule = new NinjectDomainModule("PosConnection");
            NinjectUIModule uiModule = new NinjectUIModule();

            INinjectModule[] modules = new INinjectModule[] { logicModule, domainModule };

            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                //System.Web.Http.GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(kernel);
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            System.Web.Mvc.DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}
