using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Resturant.Web.Startup))]
namespace Resturant.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
