using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
namespace Sklep.WebApp.Models
{
    public class IdentityUserLoginConfiguration : EntityTypeConfiguration<IdentityUserLogin>
    {

        public IdentityUserLoginConfiguration()
        {
            HasKey(iul => iul.UserId);
        }

    }
}