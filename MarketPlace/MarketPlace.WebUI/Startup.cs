using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarketPlace.WebUI.Startup))]
namespace MarketPlace.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
