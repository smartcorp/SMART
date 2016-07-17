using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SMART.Startup))]
namespace SMART
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
