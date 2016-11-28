using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentCar.tn.Startup))]
namespace RentCar.tn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
