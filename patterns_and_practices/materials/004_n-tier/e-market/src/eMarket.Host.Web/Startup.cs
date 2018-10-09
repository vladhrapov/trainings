using eMarket.Host.Web.Middlewares;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(eMarket.Host.Web.Startup))]
namespace eMarket.Host.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseAutofacDependencyResolver();
            app.UseAutofacMvc();
            app.UseLocalAuthentication();
            app.UseExternalAuthentication();
        }
    }
}
