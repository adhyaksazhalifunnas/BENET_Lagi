using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BENET.Startup))]
namespace BENET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
