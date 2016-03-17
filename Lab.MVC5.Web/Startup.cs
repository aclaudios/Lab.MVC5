using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab.MVC5.Web.Startup))]
namespace Lab.MVC5.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
