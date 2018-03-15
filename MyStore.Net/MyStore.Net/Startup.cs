using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyStore.Net.Startup))]
namespace MyStore.Net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
