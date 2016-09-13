using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GPRS_CLOUD.Startup))]
namespace GPRS_CLOUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
