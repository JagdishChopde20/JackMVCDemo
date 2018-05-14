using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JackMVCDemo.Startup))]
namespace JackMVCDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
