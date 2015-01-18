using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using Sklep.WebApp.Models.Login;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Sklep.WebApp.Models;
[assembly: OwinStartup(typeof(Sklep.WebApp.App_Start.Startup))]

namespace Sklep.WebApp.App_Start
{
    public class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                // check if this not need to be ~/path
                LoginPath = new PathString("/Auth/LogIn")

            });
        }
    }
}
