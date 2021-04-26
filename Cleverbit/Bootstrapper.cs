using System.Data.Entity;
using System.Web.Mvc;
using Cleverbit.Controllers;
using Cleverbit.Data;
using Cleverbit.Data.Repository;
using Cleverbit.Data.Services;
using Cleverbit.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Practices.Unity;
using Unity.Mvc3;

namespace Cleverbit
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
            container.RegisterType(typeof(IRepository<>), typeof(Repository<>));
            container.RegisterType<IOrderService, OrderService>();
            container.RegisterType<IProductService, ProductService>();

            container.RegisterType<DbContext, Models.ApplicationDbContext>(new HierarchicalLifetimeManager());
            container.RegisterType<UserManager<ApplicationUser>>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>(new HierarchicalLifetimeManager());
            container.RegisterType<AccountController>(new InjectionConstructor());
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();            

            return container;
        }
    }
}