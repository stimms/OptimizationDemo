using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OptimizationDemo.Startup))]
namespace OptimizationDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
