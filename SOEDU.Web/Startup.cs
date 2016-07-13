using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SOEDU.Web.Startup))]
namespace SOEDU.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
