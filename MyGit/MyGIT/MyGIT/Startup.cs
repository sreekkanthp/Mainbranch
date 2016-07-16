using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyGIT.Startup))]
namespace MyGIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
