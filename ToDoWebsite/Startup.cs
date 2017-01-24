using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToDoWebsite.Startup))]
namespace ToDoWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
