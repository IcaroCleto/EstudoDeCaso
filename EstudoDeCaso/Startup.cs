using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EstudoDeCaso.Startup))]
namespace EstudoDeCaso
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
