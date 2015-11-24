using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyTree3.Startup))]
namespace MyTree3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
