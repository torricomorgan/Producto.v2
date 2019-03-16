using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductoBackend.Startup))]
namespace ProductoBackend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
