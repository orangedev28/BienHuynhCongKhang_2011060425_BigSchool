using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BienHuynhCongKhang_2011060425_Week3.Startup))]
namespace BienHuynhCongKhang_2011060425_Week3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
