using MyAppMVC.Models;
using MyAppMVC.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace MyAppMVC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            //Register the Repository in the Unity Container
            container.RegisterType<IRepository<EmployeeInfo, int>, EmployeeInfoRepository>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}