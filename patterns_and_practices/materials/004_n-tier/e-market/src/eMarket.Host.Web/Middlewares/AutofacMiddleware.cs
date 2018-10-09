using Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;
using eMarket.Core.Entities;
using eMarket.Domain;
using eMarket.Domain.Categories;
using eMarket.Domain.Product;
using eMarket.Host.Web.Services.Account;
using eMarket.Host.Web.Services.Categories;
using eMarket.Host.Web.Services.Product;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security.DataProtection;
using Owin;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;

namespace eMarket.Host.Web.Middlewares
{
    public static class AutofacMiddleware
    {
        public static void UseAutofacDependencyResolver(this IAppBuilder app)
        {
            var builder = new ContainerBuilder();
            var contextParam = new ResolvedParameter(
                (pi, ctx) => pi.ParameterType == typeof(DbContext),
                (pi, ctx) => ctx.Resolve<MarketDbContext>()
            );

            // Register identity dependencies
            builder.RegisterType<MarketDbContext>().InstancePerRequest();
            builder.RegisterType<UserStore<User>>().As<IUserStore<User>>().WithParameter(contextParam).InstancePerRequest();
            builder.RegisterType<ApplicationUserManager>().InstancePerRequest();
            builder.RegisterType<ApplicationSignInManager>().InstancePerRequest();
            builder.Register(c => HttpContext.Current.GetOwinContext().Authentication).InstancePerRequest();
            builder.Register(c => app.GetDataProtectionProvider()).InstancePerRequest();

            // Register other types here
            // ....
            builder.RegisterType<ProductRepository>().As<IProductRepository>().InstancePerRequest();
            builder.RegisterType<ProductsService>().As<IProductsService>().InstancePerRequest();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>().InstancePerRequest();
            builder.RegisterType<CategoriesService>().As<ICategoriesService>().InstancePerRequest();

            // Register controllers
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            app.UseAutofacMiddleware(container);
        }
    }
}