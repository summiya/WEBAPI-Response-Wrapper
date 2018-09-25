using System.Web.Http;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using Resolver;
using System.Web.Mvc;

namespace AkshaakWebAPI
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new Unity.Mvc3.UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // e.g. container.RegisterType<ITestService, TestService>();            

            ComponentLoader.LoadContainer(container, ".\\bin", "AkshaakWebAPI.dll");
            ComponentLoader.LoadContainer(container, ".\\bin", "BusinessServices.dll");

            return container;
        }
    }
}