using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_5_Template.Startup))]
namespace MVC_5_Template
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
