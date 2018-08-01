using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleOrgMVC.Startup))]
namespace SimpleOrgMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
