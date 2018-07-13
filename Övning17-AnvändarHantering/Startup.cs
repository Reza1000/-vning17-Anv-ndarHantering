using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Övning17_AnvändarHantering.Startup))]
namespace Övning17_AnvändarHantering
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
