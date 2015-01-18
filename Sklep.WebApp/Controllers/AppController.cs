using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sklep.WebApp.Models.Login;
using System.Security.Claims;
namespace Sklep.WebApp.Controllers
{
    public abstract class AppController : Controller
    {
        public AppUserPrincipals currentUser
        {
            get { return new AppUserPrincipals(this.User as ClaimsPrincipal);}
        }
    }
}