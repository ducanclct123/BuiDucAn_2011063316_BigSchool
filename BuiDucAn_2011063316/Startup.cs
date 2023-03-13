using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuiDucAn_2011063316.Startup))]
namespace BuiDucAn_2011063316
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
