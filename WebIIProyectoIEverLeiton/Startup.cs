using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebIIProyectoIEverLeiton.Startup))]
namespace WebIIProyectoIEverLeiton
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
