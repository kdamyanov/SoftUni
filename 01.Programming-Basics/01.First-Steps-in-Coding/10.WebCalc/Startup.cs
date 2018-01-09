using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_10.WebCalc.Startup))]
namespace _10.WebCalc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
