using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
namespace Sklep.WebApp.Models.Login
{
    public class AppUserPrincipals: ClaimsPrincipal
    {
        public AppUserPrincipals(ClaimsPrincipal principal) : base(principal) { }
        public string Name{get { return this.FindFirst(ClaimTypes.Name).Value;}}
        public string Street { get { return this.FindFirst(ClaimTypes.StreetAddress).Value;} }
        public string Role { get { return this.FindFirst(ClaimTypes.Role).Value; } }
    }
}