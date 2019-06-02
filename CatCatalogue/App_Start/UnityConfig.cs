using CatCatalogue.Business;
using CatCatalogue.Data;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Unity.WebApi;

namespace CatCatalogue.App_Start
{
    public static class UnityConfig
    {
        public static UnityContainer Container { get; set; }
        /// <summary>
        /// Register Components the unity config file to register dependency classes
        /// </summary>
        public static UnityContainer RegisterComponents()
        {
            Container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            Container.RegisterType<IPetManager, PetManager>
                (new HierarchicalLifetimeManager());

            Container.RegisterType<IPetRepository, PetRepository>
                (new HierarchicalLifetimeManager());


            GlobalConfiguration.Configuration.DependencyResolver =
                new UnityDependencyResolver(Container);

            return Container;
        }
    }
}