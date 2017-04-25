using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTester.Startup))]
namespace WebTester
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
