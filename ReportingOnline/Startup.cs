using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReportingOnline.Startup))]
namespace ReportingOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
