using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DallasPoliceActiveCalls.Startup))]
namespace DallasPoliceActiveCalls
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
