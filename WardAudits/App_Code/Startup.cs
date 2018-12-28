using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WardAudits.Startup))]
namespace WardAudits
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
