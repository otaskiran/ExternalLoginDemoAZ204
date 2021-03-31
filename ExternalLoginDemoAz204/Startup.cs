using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExternalLoginDemoAz204.Startup))]
namespace ExternalLoginDemoAz204
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
