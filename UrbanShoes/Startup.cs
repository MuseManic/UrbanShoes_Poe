using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UrbanShoes.Startup))]
namespace UrbanShoes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
