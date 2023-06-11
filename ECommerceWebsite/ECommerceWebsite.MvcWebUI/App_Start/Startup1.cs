using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(ECommerceWebsite.MvcWebUI.App_Start.Startup1))]

namespace ECommerceWebsite.MvcWebUI.App_Start
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            // Kullanıcı izin gerektiren bir işlem yapmaya çalıştığında Account/Login sayfası ile karşılaşacaklar.

            app.UseCookieAuthentication(new CookieAuthenticationOptions()
            {
                AuthenticationType = "ApplicationCookie",
                LoginPath = new PathString("/Account/Login")
            });
        }
    }
}
