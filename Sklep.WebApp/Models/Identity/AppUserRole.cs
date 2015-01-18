using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sklep.WebApp.Models.Identity
{
    public class AppUserRole: IdentityRole
    {
        public AppUserRole()
        {

        }
        public AppUserRole(string roleName, string descripion) : base (roleName)
        {
            this.Description = descripion;
        }

        public string Description { get; set; }
    }
}