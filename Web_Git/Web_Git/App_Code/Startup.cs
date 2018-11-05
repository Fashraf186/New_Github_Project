using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_Git.Startup))]
namespace Web_Git
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
