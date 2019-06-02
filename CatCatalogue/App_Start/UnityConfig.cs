using CatCatalogue.Business.PetManager;
using CatCatalogue.DataAccess.Services.PetRepository;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace CatCatalogue
{
    /******************************************************************************************
    FILE_NAME:  UnityConfig.cs
    PURPOSE:    WEB API unity configuration file  to register the dependency classes.

    ******************************************************************/
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IPetManager, PetManager>();
            container.RegisterType<IPetRepository, PetRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}