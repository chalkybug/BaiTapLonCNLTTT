using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoogleMapWeb.Startup))]
namespace GoogleMapWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
