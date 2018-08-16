using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using TelefonskiImeniWebUI.Controllers;
using BLL.Interfaces;
using TelefonskiImenik.Model;

namespace TelefonskiImeniWebUI
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IService<Person>, PersonService>();
            container.RegisterType<IController, People1Controller>("People");

            return container;
        }
    }
}