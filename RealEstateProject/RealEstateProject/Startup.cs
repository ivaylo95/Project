using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RealEstateProject.Startup))]
namespace RealEstateProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
