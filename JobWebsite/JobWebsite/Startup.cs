using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobWebsite.Startup))]
namespace JobWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
