using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VehicleTracker.Startup))]
namespace VehicleTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
