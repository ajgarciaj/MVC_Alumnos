using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Alumnos.Startup))]
namespace MVC_Alumnos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
