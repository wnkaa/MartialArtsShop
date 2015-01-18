using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.ModelConfiguration;namespace Sklep.WebApp.Models
{
    public class IdentityUserRoleConfiguration : EntityTypeConfiguration<IdentityUserRole>
    {

        public IdentityUserRoleConfiguration()
        {
            HasKey(iur => iur.RoleId);
        }

    }
}