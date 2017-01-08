using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParelloZmorge.Startup))]
namespace ParelloZmorge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
