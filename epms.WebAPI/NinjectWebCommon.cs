using System;
using System.Web;
using System.Web.Http;
using epms.Data.Repository;
using epms.Data.UnitOfWork;
using epms.Entities;
using epms.Entities.Repository;
using Ninject;
using Ninject.Web.Common;

namespace epms.WebAPI
{
    public static class NinjectWebCommon
    {

        public static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

            //Suport WebAPI Injection
            GlobalConfiguration.Configuration.DependencyResolver = new WebApiContrib.IoC.Ninject.NinjectResolver(kernel);

            RegisterServices(kernel);
            return kernel;
        }

        private static void RegisterServices(IKernel kernel)
        {
            //kernel.Bind<LearningContext>().To<LearningContext>().InRequestScope();
            //kernel.Bind<ILearningRepository>().To<LearningRepository>().InRequestScope();
            kernel.Bind(typeof(IRepository<>)).To(typeof(Repository<>)).InRequestScope();
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InRequestScope();
        }
    }
}