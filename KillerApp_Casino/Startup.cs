using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KillerApp_Casino.Startup))]
namespace KillerApp_Casino
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
