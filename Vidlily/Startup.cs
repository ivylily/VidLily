using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidlily.Startup))]
namespace Vidlily
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
