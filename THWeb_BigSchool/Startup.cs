using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(THWeb_BigSchool.Startup))]
namespace THWeb_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
