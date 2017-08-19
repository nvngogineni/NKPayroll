using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NKPayroll.Startup))]
namespace NKPayroll
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
