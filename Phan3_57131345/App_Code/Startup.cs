using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Phan3_57131345.Startup))]
namespace Phan3_57131345
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
