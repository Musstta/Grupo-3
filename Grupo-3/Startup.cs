using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Grupo_3.Startup))]
namespace Grupo_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
