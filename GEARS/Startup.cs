using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GEARS.Startup))]
namespace GEARS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
