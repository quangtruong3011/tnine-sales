using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tnine_sales.Startup))]
namespace tnine_sales
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
