using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Phan4_57131345.Startup))]
namespace Phan4_57131345
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
