using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Preparcial2.Startup))]
namespace Preparcial2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
