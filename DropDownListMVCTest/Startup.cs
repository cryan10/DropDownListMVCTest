using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DropDownListMVCTest.Startup))]
namespace DropDownListMVCTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
