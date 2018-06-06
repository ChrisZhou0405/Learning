using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EF_Test.Startup))]
namespace EF_Test
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
