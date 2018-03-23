using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vogelteller.Startup))]
namespace Vogelteller
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
