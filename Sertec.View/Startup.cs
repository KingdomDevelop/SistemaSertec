using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sertec.View.Startup))]
namespace Sertec.View
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
